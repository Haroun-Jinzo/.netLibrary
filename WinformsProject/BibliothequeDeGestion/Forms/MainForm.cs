using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView.WinForms;
using Microsoft.Extensions.DependencyInjection;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.SKCharts;
using LiveChartsCore.SkiaSharpView.VisualElements;
using SkiaSharp;

namespace BibliothequeDeGestion.Forms
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly LibraryContext _db;
        private readonly EmailService _emailService;

        private BookManagementForm? _bookForm; // Marked as nullable
        private MemberManagementForm? _memberForm; // Marked as nullable

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public MainForm(IServiceProvider serviceProvider, LibraryContext dbContext, EmailService emailService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _db = dbContext;
            _emailService = emailService;
            loadPieChart();
        }

        // Load books and members
        private void LoadDashboard()
        {
            //dgvBooks.DataSource = _db.Books.ToList();
            //dgvMembers.DataSource = _db.Members.ToList();
        }

        private void kryptonCustomPaletteBase1_PalettePaint(object sender, Krypton.Toolkit.PaletteLayoutEventArgs e)
        {

        }

        private void onBookBtn_click(object sender, EventArgs e)
        {
            ShowBookForm();
        }

        void ShowBookForm()
        {
            if (_bookForm == null || _bookForm.IsDisposed)
            {
                _bookForm = _serviceProvider.GetRequiredService<BookManagementForm>();
            }
            _bookForm.Show();
            _bookForm.Activate();
        }

        private void onMembersBtn_click(object sender, EventArgs e)
        {
            ShowMemberForm();
        }

        void ShowMemberForm()
        {
            if (_memberForm == null || _memberForm.IsDisposed)
            {
                _memberForm = _serviceProvider.GetRequiredService<MemberManagementForm>();
            }
            _memberForm.Show();
            _memberForm.Activate();
        }

        void loadPieChart()
        {
            // Get data from database
            var authorCounts = _db.Books
                .GroupBy(b => b.Author)
                .Select(g => new { Author = g.Key ?? "Unknown", Count = g.Count() })
                .OrderByDescending(a => a.Count)
                .ToList();

            // Create series collection
            var series = new List<ISeries>();
            var random = new Random();
            var totalBooks = authorCounts.Sum(a => a.Count);

            foreach (var author in authorCounts)
            {
                series.Add(new PieSeries<double>
                {
                    Name = author.Author,
                    Values = new[] { (double)author.Count },
                    Fill = new SolidColorPaint(new SKColor(
                        (byte)random.Next(150, 256),  // More vibrant colors
                        (byte)random.Next(150, 256),
                        (byte)random.Next(150, 256))),
                    DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                    DataLabelsFormatter = point =>
                        $"{point.Context.Series.Name}\n" +
                        $"{point.StackedValue.Share:P1}"
                });
            }

            // Configure pie chart
            pieChart1.Series = series;

            // Chart title configuration
            pieChart1.Title = new LabelVisual
            {
                Text = "Book Distribution by Author",
                TextSize = 18,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };

            // Legend configuration
            pieChart1.LegendPosition = LiveChartsCore.Measure.LegendPosition.Right;
            pieChart1.LegendTextPaint = new SolidColorPaint(SKColors.DarkSlateGray);
            pieChart1.LegendBackgroundPaint = new SolidColorPaint(SKColors.WhiteSmoke);

            // Tooltip configuration
            pieChart1.TooltipTextPaint = new SolidColorPaint(SKColors.White);
            pieChart1.TooltipBackgroundPaint = new SolidColorPaint(SKColors.DimGray);
        }
    }
}
