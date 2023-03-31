//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


////Create a C# program to manage a photo book using OOPs.
////To start, create a class called PhotoBook.It must also have a public method GetNumberPages that will
////return the number of photo book pages.
////The default constructor will create an album with 16 pages. There will be an additional constructor,
////with which we can specify the number of pages we want in the album.
////There is also a AddPhotoBook class whose constructor will create an album with 64 pages.

////Finally create a PhotoBookTest class to perform the following actions:

////Create a default photo book and show the number of pages
////Create a photo book with 32 pages and show the number of pages
////Create a large photo book and show the number of pages
//namespace day_9_hands_on
//{
//    public class PhotoBook
//    {
//        public int pages;
//        public PhotoBook() 
//        {
//            pages = 16;
//        }

//        public PhotoBook(int pageInput)
//        {
//            pages = pageInput;
//        }

//        public int GetPages() 
//        {
//            return pages;
//        }
//    }

//    public class AddPhotoBook {
//        public int pages;
//        public AddPhotoBook() 
//        {
//            pages = 64;
//        }
//        public int GetPages()
//        {
//            return pages;
//        }
//    }

//    public class PhotoBookTest { 
//    public static void Main(string[] args)
//        {

//            PhotoBook book = new PhotoBook();
//            PhotoBook book2 = new PhotoBook(32);
//            AddPhotoBook largeBook = new AddPhotoBook();

//            Console.WriteLine(book.GetPages());
//            Console.WriteLine(book2.GetPages());
//            Console.WriteLine(largeBook.GetPages());

//        }
//    }
//}
