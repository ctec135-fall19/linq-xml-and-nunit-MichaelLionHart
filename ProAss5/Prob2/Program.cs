/*
Author:     Michael Hart
Date:       11/3/19
CTEC 135:   Microsoft Software Development with C#
<Module 6, Programming Assignment 5, Problem 2>
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Linq;

namespace Prob2
{
    // The Main() method should call the methods described below.See appendix B

    // Create a static method that creates an XML document and saves it.See pages 
    // 3 and 10 in Appendix B

    // Create a static method that creates an XML document from an array and 
    // saves it.See page 12 in Appendix B

    // Create a static method that loads an XML document and prints it to the screen.
    // You can load the doc created in 2 above.See page  13 in Appendix B. Note that 
    // all I am asking for is for you to load the document and print.You can 
    // ignore the parsing part of the book's example code.

    // At a minimum implement the examples from Appendix B.Extra points will be 
    // awarded for coming up with a different example than what is in the book. 
    // Additional bonus points will be awarded for something more 
    // complex than the book's examples.
    class Program
    {
        static void Main(string[] args)
        {
            // Calling first XDocument
            CreateXDocument();

            // Calling XDocumentFromArray() Method
            XDocumentFromArray();

            // Calling LoadXDocument() method to load document 
            // from method 1 - CreateXDocument
            LoadXDocument();

            //XDocument myDoc = XDocument.Load("SimpleInventory.xml");
            //Console.WriteLine(myDoc);
        }

        // Create a static method that creates an XML document and saves it.
        static void CreateXDocument()
        {
            XDocument inventoryDoc =
                new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("List of Weezer Color Albums"),
                    new XProcessingInstruction("xml-stylesheet",
                    "href='MyStyles.css' title='Compact' type='text/css'"),
                    new XElement("Albums",
                     new XElement("Album", new XAttribute("ID", "1"),
                      new XElement("Name", "Blue Album"),
                      new XElement("Year", "1994"),
                      new XElement("Sales", "$3.3M")
                     ),
                     new XElement("Album", new XAttribute("ID", "2"),
                      new XElement("Name", "Green Album"),
                      new XElement("Year", "2001"),
                      new XElement("Sales", "$1.6M")
                     ),
                     new XElement("Album", new XAttribute("ID", "3"),
                      new XElement("Name", "Red Album"),
                      new XElement("Year", "2008"),
                      new XElement("Sales", "$.44M")
                     ),
                     new XElement("Album", new XAttribute("ID", "4"),
                      new XElement("Name", "White Album"),
                      new XElement("Year", "2016"),
                      new XElement("Sales", "N/A")
                     ),
                     new XElement("Album", new XAttribute("ID", "5"),
                      new XElement("Name", "Teal Album"),
                      new XElement("Year", "2019"),
                      new XElement("Sales", "N/A")
                     )
                    )
                   );

            // save to disk.
            inventoryDoc.Save("SimpleInventory.xml");
            
        }

        // Create a static method that creates an XML document from an array and 
        // saves it.
        static void XDocumentFromArray()
        {
            // create an anonymous array of anonymous types
            var courses = new[]
            {
                new {CourseName = "Software Development w/ C#",
                CourseID = "CTEC 135", Time = "TTh - 1:00-3:20pm" },

                new {CourseName = "Business Web Practices",
                CourseID = "CTEC 165", Time = "MW - 4:00-5:50pm" },

                new {CourseName = "User Experience Design",
                CourseID = "CTEC 117", Time = "TTh - 9:00-11:50am" }
            };

            // Create XElements based on array data
            Console.WriteLine("***** XML Document from Array *****");
            XElement courseDoc =
                new XElement("Courses",
                    from x in courses
                    select new XElement("Course", new XAttribute("ID", x.CourseID),
                      new XElement("CourseName", x.CourseName),
                      new XElement("Time", x.Time))
                    );
            Console.WriteLine(courseDoc);
            Console.WriteLine();
            //return courseDoc;
        }

        // Create a static method that loads an XML document and prints it to the screen.
        // You can load the doc created in 2 above.See page  13 in Appendix B. Note that 
        // all I am asking for is for you to load the document and print.You can 
        // ignore the parsing part of the book's example code.
        static void LoadXDocument()
        {            
            XDocument myDoc = XDocument.Load("SimpleInventory.xml");
            Console.WriteLine(myDoc);
            Console.WriteLine();
        }
    }
}
