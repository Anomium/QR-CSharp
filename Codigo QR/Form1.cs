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
using AForge.Video;
using AForge.Video.DirectShow;
namespace Codigo_QR
{
    public partial class Form1 : Form
    {

        private FilterInfoCollection Dispositivos;
        private VideoCaptureDevice FuenteDeVideo;
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (txt_Nombre.Text != "")
            {

                ZXing.BarcodeWriter br = new ZXing.BarcodeWriter();
                
                br.Format = ZXing.BarcodeFormat.QR_CODE;
                
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
            Dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo x in Dispositivos)
            {
                cmbx_CamSelec.Items.Add(x.Name);
            }
            cmbx_CamSelec.SelectedIndex = 0;
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();
            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                Abrir.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
                Image imagen = pbg_Generar.BackgroundImage;

                pbg_codigo.Image = Image.FromFile(Abrir.FileName);
                ZXing.BarcodeReader br = new ZXing.BarcodeReader();
                string texto = br.Decode((Bitmap)pbg_codigo.Image).ToString();
                txt_Texto.Text = texto;
            }
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            FuenteDeVideo = new VideoCaptureDevice(Dispositivos[cmbx_CamSelec.SelectedIndex].MonikerString);
            vsp_camara.VideoSource = FuenteDeVideo;
            vsp_camara.Start();
        }

        private void btn_Detener_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            vsp_camara.SignalToStop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (vsp_camara.GetCurrentVideoFrame() != null)
            {
                
                Bitmap img = new Bitmap(vsp_camara.GetCurrentVideoFrame());
                string[] resultados = BarcodeLib.BarcodeReader.BarcodeReader.read(img, BarcodeLib.BarcodeReader.BarcodeReader.QRCODE);
                img.Dispose();
                if (resultados != null && resultados.Count() > 0)
                {
                    txt_TextoCam.Text = resultados[0];
                }
                
            }
        }
    }
}
