namespace Home5 
{
    public class Book
    {
        public int BookId { get; set; }
        public string Author {get; set;}
        public string BookTitle {get; set;}
        public string YearOfIssue {get; set; }

        public Book(int id,string auth,string title,string year){
            BookId = id;
            Author = auth;
            BookTitle = title;
            YearOfIssue = year;
        }
    } 
}