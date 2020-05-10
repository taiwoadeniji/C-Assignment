using System;
using System.IO;

namespace C_Assignment
{
  class Program
  {
   
    
    static void Main(string[] args)
    {
        string filename = "";
        string Inputs = "";
        bool endOfProgram = false;
     
      while ( !endOfProgram )
       {
        Console.WriteLine("Enter an option:");
        Inputs = Console.ReadLine();

        switch ( Inputs) 
        {
          case "1":
            Console.WriteLine(" Enter filename:");
            filename=Console.ReadLine();

            if ( !File.Exists( filename ) ) 
            {
               Console.WriteLine( "This filename name does not exist!!!! Enter option 1 to choose another filename." );
            }

            break;
          case "2":
            Console.WriteLine("Enter String here:");
            string modifyString = Console.ReadLine();

            if (File.Exists(filename)) 
            {
              string fileContent = File.ReadAllText(filename);
              string[] fileText = fileContent.Split(modifyString);
              string showText ="";

              foreach ( string words in fileText )
            {
                showText = showText + words + " " ;
              }
              File.WriteAllText( filename, showText );
            } else {
               Console.WriteLine(  "This filename name does not exist!!!! Enter option 1 to choose another filename.");
            }
            break;
          case "3":
            endOfProgram = true;
            Console.WriteLine("The Program has been Terminated.");
            break;
          default:
            Console.WriteLine("Invalid Option!!! Choose from 1 to 3");
            
           Console.WriteLine("Enter an Option:");
           Console.WriteLine("Enter Option 1 to input filename.");
           Console.WriteLine("Enter Option 2 to input the string to be modified.");
            Console.WriteLine("Enter Option 3 to terminate the program.");;
            break;
        }
      }
    }
  }
}
