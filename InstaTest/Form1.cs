using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using InstaTest;
using System.Diagnostics;
using System.Text;
using System.Web;
using System.Threading;

namespace Demo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "1";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        static string postTrack;
        //static string location;




        public static void GetTrackFile()
        {
            var xx = new StreamReader("postTrack.txt");
            string input = xx.ReadLine();
            postTrack = input;
            xx.Close();
            xx.Dispose();
            Clipboard.Clear();
            OperationsWithFile.DeleteFirstLineFromFile("postTrack.txt");
            
        }

        //public static void WriteFinalInfoInFile()
        //{
        //    Clipboard.Clear();
        //    string fileName = "123.txt";
        //    string textToAdd = location;


        //    using (StreamWriter writer = new StreamWriter(fileName, true, Encoding.UTF8))
        //    {
        //        writer.WriteLine(textToAdd);
        //    }
        //    //var xx = new StreamWriter("finalResult.txt");
        //    //string input = xx.Write();
        //    //string finalInfo = postTrack + "  " + location + "\n";
        //    //File.AppendAllText("finalResult.txt", finalInfo, System.Text.Encoding.Default); //write in file
        //}


        private void button1_Click(object sender, EventArgs e)

        {

            for (int i = 0; i < Convert.ToInt32(comboBox1.SelectedItem); i++)
            {


                //Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe", "--window-position=0,0 --window-size=800,600  ");

                System.Threading.Thread.Sleep(1500);
                Process.Start("https://post.kz/#!/");
                System.Threading.Thread.Sleep(3000);


                
                //WriteFinalInfoInFile();


                SendKeys.SendWait("{Tab}");
                SendKeys.SendWait("{Tab}");
                SendKeys.SendWait("{Tab}");
                SendKeys.SendWait("{Tab}");
                SendKeys.SendWait("{Tab}");
                SendKeys.SendWait("{Tab}");
                SendKeys.SendWait("{Tab}");
                SendKeys.SendWait("{Tab}");
                GetTrackFile();
                System.Threading.Thread.Sleep(1500);
                Clipboard.SetText(postTrack);
                SendKeys.SendWait("^(v)");
                SendKeys.SendWait("{Enter}");
                System.Threading.Thread.Sleep(5000);
                SendKeys.SendWait("{PGDN}");
                SendKeys.SendWait("{PGDN}");


                Cursor.Position = new Point(400, 175);
                System.Threading.Thread.Sleep(3000);
                VirtualMouse.DoubleLeftClick();
                VirtualMouse.DoubleLeftClick();
                System.Threading.Thread.Sleep(1500);
                //SendKeys.Send("^{c}");
                //SendKeys.SendWait("^{c}");
                //SendKeys.Send("^{c}");
                SendKeys.SendWait("^{c}");
                System.Threading.Thread.Sleep(1500);
                string location = Clipboard.GetText(TextDataFormat.UnicodeText);
                StreamWriter stream = new StreamWriter("C:\\clients.txt", true, Encoding.Default, 10);
                stream.WriteLine(postTrack + "  " + location);

                stream.Close();
                stream.Dispose();
                //WriteFinalInfoInFile();
                //System.Threading.Thread.Sleep(1500);
                //Cursor.Position = new Point(250, 100);
                //System.Threading.Thread.Sleep(1500);
                //VirtualMouse.LeftClick();
                //System.Threading.Thread.Sleep(1500);
                //Cursor.Position = new Point(150, 200);
                //System.Threading.Thread.Sleep(1500);
                //VirtualMouse.LeftClick();
                //VirtualMouse.LeftClick();
                //SendKeys.SendWait("{Esc}");
                //SendKeys.Send("^{w}");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe", "--window-position=0,0 --window-size=800,600  ");
            Process.Start("C:\\Users\\Masha\\Desktop\\Internet Options - Shortcut");

        }


    }
}

