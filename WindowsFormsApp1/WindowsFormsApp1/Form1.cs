using System.IO;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;                         
using System.Text;                                                               
using System.Threading.Tasks;              
using System.Windows.Forms;                
using System.Diagnostics;                  
using System;                              

namespace WindowsFormsApp1
{

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            
            string error = "The program was not found at the specified path in the code, if you chose MyApp, Try to contact the author of the program Master pro 1322#5500";
            string name = Environment.UserName;

            string text = textBox1.Text;

            

            try
            {
                switch (index)
                {
                    
                    case 0: Process.Start("taskmgr.exe"); break;
                    case 1: Process.Start("Notepad.exe"); break;
                    case 2: Process.Start(@"D:\Minecraft\MinecraftLauncher.exe"); break;
                    case 3: Process.Start(@"C:\Users\{name}\AppData\Roaming\Spotify\Spotify.exe"); break;
                    case 4: label2.Visible = false; label1.Visible = true; textBox1.Visible = true; Process.Start(text); break;
                    default: MessageBox.Show("You have not selected an application"); break;
                }
            }

            catch { MessageBox.Show(error); }
        }
            private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    }



//case номер кейса:
//                    try
//{
//    Process.Start("Путь к программе");
//}
//catch
//{
//    MessageBox.Show("Программа не найдена по указанному пути в коде" +
//"\nПопробуйте связаться с автором программы Master pro 1322#5500");
//}
//break;
//При добавлении программы добавить коллекцию в комбобокс1 

    //СТАРАЯ ВЕРСИЯ !!!!! 18.06.2021
//try
//            {
//                switch (index)
//                {

//                    case 0:


//                        Process.Start("taskmgr.exe");

//                        break;
//                    case 1:

//                        Process.Start("Notepad.exe");

//                        break;
//                    case 2:

//                        Process.Start("D:\\Minecraft\\MinecraftLauncher.exe");

//                        break;
//                    case 3:

//                        Process.Start("C:\\Users\\Арслан\\AppData\\Roaming\\Spotify\\Spotify.exe");
//                        break;
//                    case 4:

//                        string pathtoapp = textBox1.Lines[2];
//                        Process.Start(pathtoapp);
                        
//                        break;
//                }
//            }
//            catch
//{
//    MessageBox.Show("Программа не найдена по указанному пути в коде" +
//"\nПопробуйте связаться с автором программы Master pro 1322#5500");
//}
//        } 