using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    public class PhotoBook 
    {
        //To start, create a class called PhotoBook with a private attribute numPages of type int.
        //It must also have a public method GetNumberPages that will return the number of photo book pages.


        //The default constructor will create an album with 16 pages.There will be an additional constructor,
        //with which we can specify the number of pages we want in the album.


        protected int numPages;
       
        public PhotoBook()//default constructor
        {
             numPages = 16;
        }
        
        public PhotoBook(int pg)//additional constructor, specify the number of pages we want in the album
        {
            numPages=pg;
        }
        public int GetNumberPages()//return the number of photo book pages
        {
            return numPages;
        }
    }

    //There is also a BigPhotoBook class whose constructor will create an album with 64 pages.

    public class BigPhotoBook :PhotoBook
    {
        public BigPhotoBook()
        {
             numPages = 64;
        }
    }
    public class PhotoBookTest
    {
        //Finally create a PhotoBookTest class to perform the following actions:
            
        static void Main(string[] args)
        {
            //Create a default photo book and show the number of pages
            PhotoBook pb = new PhotoBook();
            Console.WriteLine("Number Of Page : " + pb.GetNumberPages());

            //Create a photo book with 24 pages and show the number of pages
            PhotoBook pb1 = new PhotoBook(24);
            Console.WriteLine("Number Of Page : " + pb1.GetNumberPages());
          

            //Create a Big photo book and show the number of pages
            BigPhotoBook bpb = new BigPhotoBook();
            Console.WriteLine("Number Of Page : " + bpb.GetNumberPages());  
        }
    }
}





//Output:
/*

Number Of Page : 16
Number Of Page : 24
Number Of Page : 64

*/



/*
Problem Statement:


Create a C# program to manage a photo book using object-oriented programming.

To start, create a class called PhotoBook with a private attribute numPages of type int. 
It must also have a public method GetNumberPages that will return the number of photo book pages.

The default constructor will create an album with 16 pages. There will be an additional constructor, 
with which we can specify the number of pages we want in the album.

There is also a BigPhotoBook class whose constructor will create an album with 64 pages.

Finally create a PhotoBookTest class to perform the following actions:

Create a default photo book and show the number of pages
Create a photo book with 24 pages and show the number of pages
Create a Big photo book and show the number of pages
  
*/