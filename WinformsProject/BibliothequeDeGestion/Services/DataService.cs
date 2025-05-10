using System.Text;

public class DataService
{
    public void ExportBooksToCsv(string filePath, List<Book> books)
    {
        var csv = new StringBuilder();
        csv.AppendLine("Title,Author,ISBN");
        foreach (var book in books)
        {
            csv.AppendLine($"{book.Title},{book.Author},{book.ISBN}");
        }
        File.WriteAllText(filePath, csv.ToString());
    }

    public List<Book> ImportBooksFromCsv(string filePath)
    {
        return File.ReadAllLines(filePath)
            .Skip(1)
            .Select(line => line.Split(','))
            .Select(fields => new Book
            {
                Title = fields[0],
                Author = fields[1],
                ISBN = fields[2]
            }).ToList();
    }
}