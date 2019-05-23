using System;
using System.IO;
using System.Collections;

namespace FileTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //EmployeeText emp = new EmployeeText("AEG_ImportBTC1ImportEmployees.Designer.cs ", @"C:\Workspace\NET\FireflyFlavor\ABIMM_ARAPR\ABIMM_SR.AEG_Processes\TextIO\" , 289, "this.txtVScheduledEmployeeInput.Name = 'txtVScheduledEmployeeInput';");
            //string empName = emp.getName();
            //emp.addToHashTable(300, "test text");
            //Hashtable hash = emp.GetHashtable();
            //foreach (LineText pair in hash.Values)
            //{
            //    Console.WriteLine(pair.line);
            //}

            string textFile = @"C:\Users\vsandhu\Desktop\employeeReport.txt";
            string desktopPath = @"C:\Users\vsandhu\Desktop\create.txt";
            string[] lines = File.ReadAllLines(textFile);
            if (File.Exists(textFile)){
                using (StreamWriter sw = File.CreateText(desktopPath))
                {
                    Console.WriteLine("new file created!");
                    sw.WriteLine("Vishal Created this");
                    int counter = 0;
                    foreach (string line in lines)
                    {
                        try
                        {


                            if (line[0] == 'C')
                            {
                                Console.WriteLine("HAS A C");
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Made it");
                        }
                        if (counter > 3)
                        {
                            try
                            {
                                sw.WriteLine(line.Split(' ')[0] + "       ------>      " + line.Split('?')[1]);

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("EXCEPTION");
                                throw;
                            }
                        }
                        counter++;

                    }

                    counter = 0;
                    foreach (string line in lines)
                    {
                        if (counter > 3)
                        {
                            Console.WriteLine(line.Split('?')[1]);
                            break;
                        }
                        counter++;

                    }
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
                
            }
        }
    }
}
