using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3dn
{
    class Program
    {
        static void Main(string[] args)
        {
            File file1 = new File();
            file1.name = "File1";  

            File file2 = new File();
            file2.name = "File2";  

            File file3 = new File();
            file3.name = "File3"; 

            File file4 = new File();
            file4.name = "File4";  

            Folder folder1 = new Folder();
            folder1.name = "Folder1";
            folder1.files.Add(file1);
            folder1.files.Add(file2);

            Folder folder2 = new Folder();
            folder2.name = "Folder2";
            folder2.files.Add(file3);
            folder2.files.Add(file4);


            Disk disk1 = new Disk();
            disk1.name = "Disk1";
            disk1.folders.Add(folder1);
            disk1.folders.Add(folder2);
            Console.WriteLine(disk1.GetDetails());

            Console.WriteLine("------------CLONE------------\n");

            Disk diskCOPY = (Disk)disk1.Clone();
            Console.WriteLine(diskCOPY.GetDetails());

            Console.ReadKey();
        }
    }
}
