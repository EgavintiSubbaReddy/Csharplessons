namespace LibraryA
{
    
       public class Book
        {
            public string Title = String.Empty;
            public string Author = String.Empty;
            public string Genere = String.Empty;
            public DateTime DateOfPublish;
            public int BookPrice;
            public int TotalPages = 100;



            public void OpenBook()
            {



                Console.WriteLine("Book is open");



            }



            public void BookMarkPage(int pageNo)
            {
                Console.WriteLine($" Page No: { pageNo} BookMarkPage");
            }



            public int GetCurrentPage()
            {
                Random rnd = new Random();
                return rnd.Next(TotalPages);
            }
        }
    }


