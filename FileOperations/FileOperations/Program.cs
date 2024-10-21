using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           FileManagementSystem f1 = new FileManagementSystem();
           String filePath = @"D:\Edstem\one.txt";
           f1.fileCreation();
           f1.writeToAFile(filePath);
           f1.appendToAText(filePath);
           f1.readFromAFile(filePath);
           f1.readAllLinesInFile(filePath);
           f1.numberOftextsInFile(filePath);
           f1.numberOfCharactersInFile(filePath);
        }
    }
}
