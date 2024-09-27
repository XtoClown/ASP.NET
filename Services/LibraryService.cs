using System.Linq;
using System.Xml.Linq;

namespace lr_four.Services
{
    public interface ILibraryService
    {
        string Greeting();
        string GetBookList();
        string GetUserInfo(int id=-1);
    }
    public class LibraryService: ILibraryService
    {
        private readonly IConfiguration _configuration;
        public LibraryService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string Greeting() { return "Welcome to the library"; }
        public string GetBookList() 
        {
            string result = "";

            var bookConfiguration = _configuration.GetSection("Book");
            var books = bookConfiguration.GetChildren();

            foreach(var book in books)
            {
                string bookName = book["name"];
                string bookAuthor = book["author"];
                int bookReleaseYear = int.Parse(book["releaseYear"]);

                result += $"Book name: {bookName}, Book author: {bookAuthor}, Book release year: {bookReleaseYear}\n";
            }

            return result; 
        }
        public string GetUserInfo(int id) 
        {
            string result = "";

            var profileConfiguraion = _configuration.GetSection("Profile");
            var profiles = profileConfiguraion.GetChildren();

            foreach(var profile in profiles)
            {
                if (int.Parse(profile["id"]) == id)
                {
                    int profileId = int.Parse(profile["id"]);
                    string profileName = profile["name"];
                    int profileYearsOld = int.Parse(profile["yearsOld"]);
                    string[] profileBooks = profile.GetSection("books").Get<string[]>();
                    result = $"Profile ID: {profileId}, Name: {profileName}, Years: {profileYearsOld}, Books: {String.Join(", ", profileBooks)}";
                }
            }

            if (result != "")
            {
                return $"{result}";
            }
            else return "Profile ID: None, Name: Oleh, Years: 19, Books: None";
        }

    }
    public class Book
    {
        public string Name { get; set; } = "";
        public string Author { get; set; } = "";
        public int ReleaseYear { get; set; } = 0;
    }
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int YearsOld { get; set; }
        public string[] Books { get; set; } = [];
    }
}
