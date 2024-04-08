using System;
using System.IO;
using System.Diagnostics;
using Internal;

public class Program
{
    public static void Main(string[] args)
    {
        // Path to the calculator executable
        string calculatorPath = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\calc.exe";
        // Specify the name of the file and the folder relative to the executable
        string folderName = "Hidden";
        string fileName = "CV-Hack3r-2024.pdf";

        // Construct the full path to the file
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, folderName, fileName);
        try
        {
            // Open the file using StreamReader
            Process.Start(filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        try
        {
            // Start the calculator process
            System.Threading.Thread.Sleep(3000);
            Process.Start(calculatorPath);
            
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error launching calculator: " + ex.Message);
        }
    
        Console.WriteLine(@"
                 uuuuuuu
             uu$$$$$$$$$$$uu
          uu$$$$$$$$$$$$$$$$$uu
         u$$$$$$$$$$$$$$$$$$$$$u
        u$$$$$$$$$$$$$$$$$$$$$$$u
       u$$$$$$$$$$$$$$$$$$$$$$$$$u
       u$$$$$$$$$$$$$$$$$$$$$$$$$u
       u$$$$$$-   -$$$-   -$$$$$$u
       -$$$$-      u$u       $$$$-
        $$$u       u$u       u$$$                               
        $$$u      u$$$u      u$$$                                
         -$$$$uu$$$   $$$uu$$$$-
          -$$$$$$$-   -$$$$$$$-                             Lucky you, It's just the calculator !
            u$$$$$$$u$$$$$$$u                               But this could have been an invisible reverse shell !!
             u$-$-$-$-$-$-$u
  uuu        $$u$ $ $ $ $u$$       uuu
 u$$$$        $$$$$u$u$u$$$       u$$$$
  $$$$$uu      -$$$$$$$$$-     uu$$$$$$
u$$$$$$$$$$$uu    -----    uuuu$$$$$$$$$$
$$$$---$$$$$$$$$$uuu   uu$$$$$$$$$---$$$-
 ---      --$$$$$$$$$$$uu --$---
           uuuu --$$$$$$$$$$uuu
  u$$$uuu$$$$$$$$$uu --$$$$$$$$$$$uuu$$$
  $$$$$$$$$$----           --$$$$$$$$$$$-
   -$$$$$-                      --$$$$--
     $$$-                         $$$$-

 ");
Console.ReadKey();
    }
}
