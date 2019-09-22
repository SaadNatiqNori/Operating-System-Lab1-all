using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_os_saad18__0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                          This is an example about the Addresing");
            Console.WriteLine("************************************************************************************************************************");

            for (;;)
            {
                Console.Write("                                          Limet Program = ");
                int limetProgram = int.Parse(Console.ReadLine());
                Console.Write("                                          Relocation Address = ");
                int relocation = int.Parse(Console.ReadLine());
                Console.Write("                                          Logical Address = ");
                int logicalAddress = int.Parse(Console.ReadLine());
                //this is for result
                int resultOfPhysicalAddress;

                if (logicalAddress < limetProgram)
                {
                    resultOfPhysicalAddress = logicalAddress + relocation;
                    Console.WriteLine("                                          The Physical address = " + resultOfPhysicalAddress.ToString());
                }else
                {
                    Console.WriteLine("                                          Trap: Error Addressing");
                }
                Console.Write("                                          Do you want to check again ? ( y / n ) --> ");
                char resultOfcheck = char.Parse(Console.ReadLine());
                if (resultOfcheck == 'y' || resultOfcheck == 'Y')
                {
                    continue;
                }else
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("****************************************************[Closed]********************************************************");
            Console.ReadKey();
        }
    }
}
