using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;


namespace WARM_2
{
    class txt
    {

        public static void BinaryWriter ()
        {
            var startupPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            var date= DateTime.Now.ToString("HH:mm:ss tt");//zaman ro mide
            FileStream fs = new FileStream(startupPath+"read me bitch:)"+" ("+ date+")", FileMode.Create);

            StreamWriter writer = new StreamWriter(fs);

            writer.Write(Program.msg);
            writer.Close();


        }


    }
}
