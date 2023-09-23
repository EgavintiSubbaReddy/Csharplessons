using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirstMvcApp.Models
{
    public class AuthorRepository
    {


        public static Dictionary<int, Author> GetAuthorDictionary()

        {

            String fName = @"c:\temp\Author.txt";

            Dictionary<int, Author> list = new Dictionary<int, Author>();

            bool isFileExists = System.IO.File.Exists(fName);

            if (isFileExists)

            {

                using (StreamReader sr = new StreamReader(fName))

                {

                    string strAuthor = $"{sr.ReadLine()}";

                    String[] data = strAuthor.Split(',');

                    Author author = null;

                    if (data.Length == 5)

                    {

                        author = StringToAuthor(data, new Author());

                        list.Add(author.Id, author); // ensures the uniqiueness

                        while (!sr.EndOfStream)

                        {

                            strAuthor = $"{sr.ReadLine()}";

                            data = strAuthor.Split(',');

                            if (data.Length == 5)

                            {

                                author = StringToAuthor(data, new Author());

                                list.Add(author.Id, author);

                            }





                        }

                    }



                }

            }

            return list;





        }



        private static Author StringToAuthor(String[] data, Author author)

        {

            author.Id = int.Parse(data[0]);

            author.AuthorName = data[1];

            author.DateOfBirth = DateTime.Parse(data[2]);

            author.BooksPublished = int.Parse(data[3]);

            author.Royalty = int.Parse((String)data[4]);

            return author;

        }

        public static void SaveTOFile(Author pAuthor)
        {
            string fName = @"c:\temp\Author.csv";
            string strAuthor = $"{pAuthor.Id}, {pAuthor.AuthorName},{pAuthor.Royalty}";
            using (StreamWriter sw = new StreamWriter(strAuthor))
            {
                sw.Write(strAuthor);
            }
        }
        public static Author FindAuthorid(int id)
        {
            Dictionary<int, Author> List = AuthorRepository.GetAuthorDictionary();
            Author author = null;
            if (List != null)
            {
                author = List.FirstOrDefault(x => (x.Key == id)).Value;
            }
            return author;
        }
        public static void UpdateAuthorToFile(Author pAuthor)
        {
            String fName = @"c:temp\Author.txt";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            string strAuthor = String.Empty;
            using (StreamWriter sw = new StreamWriter(fName))
            {
                foreach (Author author in list.Values)
                {
                    if (author.Id != pAuthor.Id)
                        strAuthor = $"{author.Id}, {author.AuthorName}, {author.Royalty}, {author.BooksPublished}";
                    else
                        strAuthor = $"{author.Id}, {author.AuthorName}, {author.Royalty}, {author.BooksPublished}";
                    sw.Write(strAuthor);
                }
            }
        }
        public static void RemoveAuthor(int id)
        {
            string fName = @"c:temp\Author.txt";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            StringBuilder sbAuthors = new StringBuilder(list.Count + 100);


            foreach (Author author in list.Values)
            {
                if (author.Id != id)
                    sbAuthors.Append($"{author.Id}, {author.AuthorName}, {author.Royalty}, {author.BooksPublished}" + $"{author.Royalty}, {author.DateOfBirth}, {Environment.NewLine}");




            }
            File.WriteAllText(fName, sbAuthors.ToString());
        }
    }
}



