using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Codigo_QR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (txt_Nombre.Text != "")
            {
               
                BarcodeWriter br = new BarcodeWriter();
                
                br.Format = BarcodeFormat.QR_CODE;
                
                Bitmap bm = new Bitmap(br.Write(txt_Nombre.Text), 300, 300);
                pbg_Generar.Image = bm;
            }
            
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                Guardar.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
                Image imagen = pbg_Generar.BackgroundImage;
                
                pbg_Generar.Image.Save(Guardar.FileName);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
        }
    }
}
