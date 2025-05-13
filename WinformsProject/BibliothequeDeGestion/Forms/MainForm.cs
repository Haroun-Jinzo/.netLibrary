using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using LiveChartsCore.Drawing; // Add this for Padding
using LiveChartsCore.SkiaSharpView.WinForms;
using Microsoft.Extensions.DependencyInjection;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using SkiaSharp;
using Microsoft.EntityFrameworkCore;
using LiveChartsCore.SkiaSharpView.SKCharts;
using LiveChartsCore.Kernel;
using LiveChartsCore.SkiaSharpView.Drawing;
using System.Diagnostics;
using BibliothequeDeGestion.LoanForms;

namespace BibliothequeDeGestion.Forms
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly LibraryContext _db;
        private readonly EmailService _emailService;

        private BookManagementForm? _bookForm; // Marked as nullable
        private MemberManagementForm? _memberForm; // Marked as nullable
        private LoanManagementForm? _loanForm; // Marked as nullable


        private void MainForm_Load(object sender, EventArgs e)
        {
            loadPieChart();
            LoadColumnChart();
        }

        public MainForm(IServiceProvider serviceProvider, LibraryContext dbContext, EmailService emailService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _db = dbContext;
            _emailService = emailService;
            loadPieChart();
            LoadColumnChart();
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
        private void onLoansBtn_click(object sender, EventArgs e)
        {
            ShowLoanForm();
        }
        void ShowLoanForm()
        {
            if (_loanForm == null || _loanForm.IsDisposed)
            {
                _loanForm = _serviceProvider.GetRequiredService<LoanManagementForm>();
            }
            _loanForm.Show();
            _loanForm.Activate();
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

        private void LoadColumnChart()
        {
            try
            {
                // 1. Get data with explicit date handling  
                var membersByYear = _db.Members
                    .AsNoTracking()
                    .GroupBy(m => m.SubscriptionDate.Year)
                    .Select(g => new { Year = g.Key, Count = g.Count() })
                    .OrderBy(x => x.Year)
                    .ToList();

                // Debug output  
                Debug.WriteLine($"Found {membersByYear.Count} years:");
                foreach (var item in membersByYear)
                {
                    Debug.WriteLine($"{item.Year}: {item.Count} members");
                }

                if (!membersByYear.Any())
                {
                    MessageBox.Show("No subscription data found");
                    return;
                }

                // 2. Create series with enhanced visibility  
                var columnSeries = new ColumnSeries<int>
                {
                    Values = membersByYear.Select(x => x.Count).ToArray(),
                    Name = "Subscriptions",
                    DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                    Fill = new SolidColorPaint(SKColors.MediumSlateBlue),
                    Stroke = new SolidColorPaint(SKColors.Navy, 2),
                    MaxBarWidth = 40,
                    Padding = 20
                };

                // 3. Configure axes with explicit formatting  
                cartesianChart1.XAxes = new[]
                {
                   new Axis
                   {
                       Labels = membersByYear.Select(x => x.Year.ToString()).ToArray(),
                       LabelsRotation = 0,
                       SeparatorsPaint = new SolidColorPaint(SKColors.LightGray),
                       Name = "Subscription Year",
                       NamePaint = new SolidColorPaint(SKColors.DarkSlateGray)
                   }
               };

                cartesianChart1.YAxes = new[]
                {
                   new Axis
                   {
                       MinLimit = 0,
                       MaxLimit = membersByYear.Max(x => x.Count) + 1,
                       ForceStepToMin = true,
                       MinStep = 1, // Corrected property name  
                       Name = "Number of Members",
                       NamePaint = new SolidColorPaint(SKColors.DarkSlateGray)
                   }
               };

                // 4. Clear previous data and update  
                cartesianChart1.Series = Array.Empty<ISeries>();
                cartesianChart1.Series = new[] { columnSeries };
                cartesianChart1.CoreCanvas.Invalidate();

                // 5. Force UI update  
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading chart: {ex.Message}");
            }
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            loadPieChart();
            LoadColumnChart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
