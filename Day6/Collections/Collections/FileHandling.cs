using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Collections
{
    internal class FileHandling
    {
        public static void Main3(string[] args)
        {

            string filename = @"E:\wipro\Collections\file.txt";
            // string destinationname = @"E:\wipro\Collections\file2.txt";
            //  FileStream fs = new FileStream(filename, FileMode.Create);


            //   Console.WriteLine("File created");
            //  FileStream fs1 = new FileStream(filename, FileMode.Append);
            // create a byte array which contain the string type of data

            /* byte[] b = Encoding.Default.GetBytes("this is c# file which got created");

             fs1.Write(b, 0, b.Length);
             Console.WriteLine("Data Saved in a file");
             fs1.Close();*/


            /*
            FileStream fs1 = new FileStream(filename, FileMode.Open);

                //create an instance of streamReader object to read the data from the stream 

                using (StreamReader sr = new StreamReader(fs1))
                {

               Data   =  sr.ReadToEnd();

                }

            Console.WriteLine(Data);*/

            /*
                        //to copy the content from one file to another
                        File.Copy(filename, destinationname);
                        string linescopied=File.ReadAllText(destinationname);
                        Console.WriteLine(linescopied);
                        File.Delete(filename);
            */


            //Streamreader***********
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("Dotnet learning for all");
                sw.WriteLine("contents added");
            }

            //Reading the data 1. ReadToEnd()
            using (StreamReader sw = new StreamReader(filename))
            {
                Console.WriteLine(sw.ReadToEnd());
            }
            //2.ReadLine()
            using (StreamReader sr = new StreamReader(filename))
            {
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                string strData = sr.ReadLine();

                while (strData != null) { 
                Console.WriteLine(strData);
                    strData = sr.ReadLine();
                }
            }
            FileInfo fileinfo= new FileInfo(filename);
            Console.WriteLine(fileinfo.FullName);
            Console.WriteLine(fileinfo.DirectoryName);
            Console.WriteLine(fileinfo.Extension);
            //Creating new directory
            string newfile = @"E:\wipro\Collections\Mydir";
            DirectoryInfo df=new DirectoryInfo(newfile);
            df.Create();

               

        }

    }
}


/*
 
     string Data;
    string filename = @"C:\Users\Niti Dwivedi\Documents\dotnetprograms\Day-5\CollectionExamples\CollectionExamples\bin\myfile.txt";
    string destinationfile = @"C:\Users\Niti Dwivedi\Documents\dotnetprograms\Day-5\CollectionExamples\CollectionExamples\bin\myfilecopy.txt";

    //  FileStream fs = new FileStream(filename, FileMode.Create);


    //   Console.WriteLine("File created");
    //  FileStream fs1 = new FileStream(filename, FileMode.Append);
    // create a byte array which contain the string type of data

    /* byte[] b = Encoding.Default.GetBytes("this is c# file which got created");

     fs1.Write(b, 0, b.Length);
     Console.WriteLine("Data Saved in a file");
     fs1.Close();*/

    /*  FileStream fs1 = new FileStream(filename, FileMode.Open);

      //create an instance of streamReader object to read the data from the stream 

      using (StreamReader sr = new StreamReader(fs1))
      {

          Data = sr.ReadToEnd();

      }

      Console.WriteLine(Data);*/


    // File class ************ working directly with the files 

    /* if (File.Exists(filename))
     {
         string[] dataarray = File.ReadAllLines(filename);
         foreach (var line in dataarray)
         {
             Console.WriteLine(line);
         }
     }
     else
     {
         Console.WriteLine("File not exist");
     }

     // to copy the content from one file to another
     File.Copy(filename, destinationfile);

     string linescopied = File.ReadAllText(destinationfile);
     Console.WriteLine(linescopied);
     File.Delete(filename);*/



    //StreamReader  ***********************
    //Writing the data in a file
  /*  using (StreamWriter sw = new StreamWriter(filename))
    {    
        sw.WriteLine("Dot learning for all");
        sw.WriteLine("Some more content added");
     }

    //Reading the data 1. ReadToEnd()
    using (StreamReader sw = new StreamReader(filename))
    {
        Console.WriteLine(sw.ReadToEnd());  
    }

    // 2. ReadLine()
    using (StreamReader sr = new StreamReader(filename))
    {
        sr.BaseStream.Seek(0, SeekOrigin.Begin);

        string strData = sr.ReadLine();
        while (strData != null)
        { 
           Console.WriteLine($"{strData}");
            strData = sr.ReadLine();
        }

       
    }

    FileInfo fileinfo = new FileInfo(filename);

    Console.WriteLine(fileinfo.FullName);
    Console.WriteLine(fileinfo.DirectoryName);
    Console.WriteLine(fileinfo.Extension);

    string newfile = @"C:\Users\Niti Dwivedi\Documents\dotnetprograms\Day-6\log";

    DirectoryInfo df = new DirectoryInfo(newfile);
   df.Create();
    Console.WriteLine(df.CreationTime);
    Console.WriteLine(df.LastAccessTime);
    Console.WriteLine("Directory created");

    Console.WriteLine(df.GetFiles());

}
 
 
 
 */