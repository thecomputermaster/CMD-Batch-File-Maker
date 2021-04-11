using OpenQA.Selenium;
using System;
using System.IO;
using VisioForge.Shared.MediaFoundation.OPM;

namespace CMD_Batch_File_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is a command line tool tool which allows to create batch files from within the Windows CMD. Program C 2021 Keifmeister Technologies.");

            Console.WriteLine("Enter the code for your batch file below, and then press 1 and we will save it. Press 2 to quit.");

            string batchfile = Convert.ToString(Console.ReadLine());

          
                int caseSwitch = Convert.ToInt32(Console.ReadLine());

                switch (caseSwitch)
                {
                    case 1:

                        Console.WriteLine("Enter the location and name to save the file:");
                        string batchfiletosave = Convert.ToString(Console.ReadLine());
                        if (File.Exists(batchfiletosave))
                        {
                            Console.WriteLine("A batch file with this name already exists in this location. Overwrite it? Press 1 for yes and 2 for no.");
                            int fileoverwritecheck = Convert.ToInt32(Console.ReadLine());

                            try
                            {
                                File.WriteAllText(batchfiletosave + ".bat", batchfile);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Could not save the file. Either the location does not exist, or you need Administrator rights to be able to acces it. Please also check for typos in the location.");
                            }
                        }
                       
                        else
                        {
                            try
                            {
                                File.WriteAllText(batchfiletosave + ".bat", batchfile);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Could not save the file. Either the location does not exist, or you need Administrator rights to be able to acces it. Please also check for typos in the location.");
                            }
                        }
                
                        break;
                    case 2:
                        Console.WriteLine("Will now quit. Thank you for using.");
                        break;
                }
            }
        }
    }

