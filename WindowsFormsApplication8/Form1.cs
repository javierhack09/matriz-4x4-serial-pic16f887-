using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        int flag = 0,i=0;
        string lectura;
        float numero1 = 0,numero2=0,total=0;
        string[] lectura2 = new string[10];
        
        public Form1()
        {
            InitializeComponent();
            ON.Enabled = true;
            OFF.Enabled = false;
            try { serialPort1.Open(); }
            catch (Exception msg) { MessageBox.Show(msg.ToString()); }
            
        }
        
        private void ON_Click(object sender, EventArgs e)
        {
            flag = 1;
            ON.Enabled = false;
            OFF.Enabled = true;
            clear.Enabled = true;
            pictureBox4.Visible = true;
            pictureBox3.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.Visible = true;
        }

        private void OFF_Click(object sender, EventArgs e)
        {
            flag = 2;
            OFF.Enabled = false;
            ON.Enabled = true;
            clear.Enabled = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if(flag == 1)
            {
                lectura = serialPort1.ReadLine();
                
                lectura2[i] = lectura;

                i++;

                if(i>=4)
                {
                    i = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lectura2[0] = "";
            lectura2[1] = "";
            lectura2[2] = "";
            lectura2[3] = "";
            label1.Text = "";
            pictureBox1.Image = WindowsFormsApplication8.Properties.Resources.blanco;
            pictureBox2.Image = WindowsFormsApplication8.Properties.Resources.blanco;
            pictureBox3.Image = WindowsFormsApplication8.Properties.Resources.blanco;
            pictureBox4.Image = WindowsFormsApplication8.Properties.Resources.blanco;
            pictureBox5.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            if (lectura2[0] == "1")
            {
                pictureBox1.Image = WindowsFormsApplication8.Properties.Resources.uno;
                numero1 = 1;
            }

            if (lectura2[0] == "2")
            {
                pictureBox1.Image = WindowsFormsApplication8.Properties.Resources.dos;
                numero1 = 2;
            }
            if (lectura2[0] == "3")
            {
                pictureBox1.Image = WindowsFormsApplication8.Properties.Resources.tres;
                numero1 = 3;
            }
            if (lectura2[0] == "4")
            {
                pictureBox1.Image = WindowsFormsApplication8.Properties.Resources.cuatro;
                numero1 = 4;
            }
            if (lectura2[0] == "5")
            {
                pictureBox1.Image = WindowsFormsApplication8.Properties.Resources.cinco;
                numero1 = 5;
            }

            if (lectura2[0] == "6")
            {
                pictureBox1.Image = WindowsFormsApplication8.Properties.Resources.seis;
                numero1 = 6;
            }

            if (lectura2[0] == "7")
            {
                pictureBox1.Image = WindowsFormsApplication8.Properties.Resources.siete;
                numero1 = 7;
            }

            if (lectura2[0] == "8")
            {
                pictureBox1.Image = WindowsFormsApplication8.Properties.Resources.ocho;
                numero1 = 8;
            }

            if (lectura2[0] == "9")
            {
                pictureBox1.Image = WindowsFormsApplication8.Properties.Resources.nueve;
                numero1 = 9;
            }
            if (lectura2[0] == "0")
            {
                pictureBox1.Image = WindowsFormsApplication8.Properties.Resources.cero;
                numero1 = 0;
            }

            if (lectura2[1] == "A")
            {
                pictureBox2.Image = WindowsFormsApplication8.Properties.Resources.mas1;
                total = numero1 + numero2;
                if (lectura2[3] == "#")
                {
                   
                    pictureBox4.Image = WindowsFormsApplication8.Properties.Resources.igual3;
                    string strImage = total.ToString();
                    //CreateImageFromString(strImage);
                    //pictureBox5.Image = Image.FromFile("C:\\AMD\\prueba.png");
                    label1.Text = total.ToString();
                    lectura2[3] = "*";
                }
            }
            if (lectura2[1] == "B")
            {
                pictureBox2.Image = WindowsFormsApplication8.Properties.Resources.menos1;
                total = numero1 - numero2;
                if (lectura2[3] == "#")
                {
                    
                    pictureBox4.Image = WindowsFormsApplication8.Properties.Resources.igual3;
                    string strImage = total.ToString();
                    //CreateImageFromString(strImage);
                    //pictureBox5.Image = Image.FromFile("C:\\AMD\\prueba.png");
                    label1.Text = total.ToString();
                    lectura2[3] = "*";
                }
            }
            if (lectura2[1] == "C")
            {
                pictureBox2.Image = WindowsFormsApplication8.Properties.Resources.por1;
                total = numero1 * numero2;
                if (lectura2[3] == "#")
                {
                    
                    pictureBox4.Image = WindowsFormsApplication8.Properties.Resources.igual3;
                    string strImage = total.ToString();
                    //CreateImageFromString(strImage);
                    //pictureBox5.Image = Image.FromFile("C:\\AMD\\prueba.png");
                    label1.Text = total.ToString();
                    lectura2[3] = "*";
                }
            }
            if (lectura2[1] == "D")
            {
                pictureBox2.Image = WindowsFormsApplication8.Properties.Resources.division1;
                total = numero1 / numero2;
                if (lectura2[3] == "#")
                {
                    
                    pictureBox4.Image = WindowsFormsApplication8.Properties.Resources.igual3;
                    string strImage = total.ToString();
                    //CreateImageFromString(strImage);
                    //pictureBox5.Image = Image.FromFile("C:\\AMD\\prueba.png");
                    label1.Text = total.ToString();
                    lectura2[3] = "*";
                    

                }
            }

            if (lectura2[2] == "1")
            {
                pictureBox3.Image = WindowsFormsApplication8.Properties.Resources.uno;
                numero2 = 1;
            }

            if (lectura2[2] == "2")
            {
                pictureBox3.Image = WindowsFormsApplication8.Properties.Resources.dos;
                numero2 = 2;
            }
            if (lectura2[2] == "3")
            {
                pictureBox3.Image = WindowsFormsApplication8.Properties.Resources.tres;
                numero2 = 3;
            }
            if (lectura2[2] == "4")
            {
                pictureBox3.Image = WindowsFormsApplication8.Properties.Resources.cuatro;
                numero2 = 4;
            }
            if (lectura2[2] == "5")
            {
                pictureBox3.Image = WindowsFormsApplication8.Properties.Resources.cinco;
                numero2 = 5;
            }

            if (lectura2[2] == "6")
            {
                pictureBox3.Image = WindowsFormsApplication8.Properties.Resources.seis;
                numero2 = 6;
            }

            if (lectura2[2] == "7")
            {
                pictureBox3.Image = WindowsFormsApplication8.Properties.Resources.siete;
                numero2 = 7;
            }

            if (lectura2[2] == "8")
            {
                pictureBox3.Image = WindowsFormsApplication8.Properties.Resources.ocho;
                numero2 = 8;
            }

            if (lectura2[2] == "9")
            {
                pictureBox3.Image = WindowsFormsApplication8.Properties.Resources.nueve;
                numero2 = 9;
            }
            if (lectura2[2] == "0")
            {
                pictureBox3.Image = WindowsFormsApplication8.Properties.Resources.cero;
                numero2 = 0;
            }


        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        public void CreateImageFromString(string strImage)
        {

            string text = strImage;
            //create new image
            Bitmap bitmap = new Bitmap(1, 1);
            //Properties string to draw
            Font font = new Font("Arial", 200, FontStyle.Regular, GraphicsUnit.Pixel);
            Graphics graphics = Graphics.FromImage(bitmap);
            //properties new image
            int width = (int)graphics.MeasureString(text, font).Width;
            int height = (int)graphics.MeasureString(text, font).Height;
            bitmap = new Bitmap(bitmap, new Size(width, height));
            //add text to image
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            //graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            graphics.DrawString(text, font, new SolidBrush(Color.Black), 0, 0);
            //execute pending graphics
            graphics.Flush();
            //release resources used by graphics
            graphics.Dispose();
            //save the image
            bitmap.Save("C:\\AMD\\prueba.png", System.Drawing.Imaging.ImageFormat.Png);
            //do something with image
            
        }




    }
}
