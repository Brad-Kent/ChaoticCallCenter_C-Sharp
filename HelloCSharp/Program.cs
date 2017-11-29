using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrameMain());

            //if (!File.Exists("test.txt"))
            //{
            //    Console.WriteLine("Creating File");
            //    FileStream outFile = new FileStream("test.txt", FileMode.Create, FileAccess.Write);
            //    StreamWriter streamOut = new StreamWriter(outFile);
            //    streamOut.WriteLine("Hello World!, My Name Jeff");
            //    streamOut.Close();
            // }
            //Console.WriteLine("Hello There");

          //  Console.WriteLine(Directory.GetDirectoryRoot("Test.txt"));


            //FileStream inFile = new FileStream("customers.txt", FileMode.Open, FileAccess.Read);
            //StreamReader streamIn = new StreamReader(inFile);
            //string data = ""; int dataSep = 0;
            //while ((data = streamIn.ReadLine()) != null)
            //{
            //    if (dataSep > 7)
            //    {
            //        Console.WriteLine();
            //        dataSep = 0;
            //    }

            //    Console.Write(data + " |");
            //    dataSep++;
            //}
            //Customer.setUpCustomers();
            //String[] temp = Customer.getCustomer(0);

            //for (int i = 0; i < temp.Length; i++)
            //{
            //    Console.WriteLine("Temp:::: " + temp[i]);
            //}

        }
    }
}
