namespace Codigo_QR
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_Nombre = new System.Windows.Forms.RichTextBox();
            this.pbg_Generar = new System.Windows.Forms.PictureBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pbg_codigo = new System.Windows.Forms.PictureBox();
            this.btn_Abrir = new System.Windows.Forms.Button();
            this.txt_Texto = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_Detener = new System.Windows.Forms.Button();
            this.vsp_camara = new AForge.Controls.VideoSourcePlayer();
            this.cmbx_CamSelec = new System.Windows.Forms.ComboBox();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.txt_TextoCam = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbg_Generar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbg_codigo)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(8, 20);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(242, 150);
            this.txt_Nombre.TabIndex = 2;
            this.txt_Nombre.Text = "";
            this.txt_Nombre.TextChanged += new System.EventHandler(this.txt_Nombre_TextChanged);
            // 
            // pbg_Generar
            // 
            this.pbg_Generar.Location = new System.Drawing.Point(8, 189);
            this.pbg_Generar.Name = "pbg_Generar";
            this.pbg_Generar.Size = new System.Drawing.Size(293, 288);
            this.pbg_Generar.TabIndex = 3;
            this.pbg_Generar.TabStop = false;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(256, 148);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 4;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "probando";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(383, 533);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pbg_Generar);
            this.tabPage1.Controls.Add(this.btn_Guardar);
            this.tabPage1.Controls.Add(this.txt_Nombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(375, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pbg_codigo);
            this.tabPage2.Controls.Add(this.btn_Abrir);
            this.tabPage2.Controls.Add(this.txt_Texto);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(375, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Leer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pbg_codigo
            // 
            this.pbg_codigo.Location = new System.Drawing.Point(26, 194);
            this.pbg_codigo.Name = "pbg_codigo";
            this.pbg_codigo.Size = new System.Drawing.Size(293, 288);
            this.pbg_codigo.TabIndex = 6;
            this.pbg_codigo.TabStop = false;
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.Location = new System.Drawing.Point(274, 153);
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(75, 23);
            this.btn_Abrir.TabIndex = 7;
            this.btn_Abrir.Text = "Abrir";
            this.btn_Abrir.UseVisualStyleBackColor = true;
            this.btn_Abrir.Click += new System.EventHandler(this.btn_Abrir_Click);
            // 
            // txt_Texto
            // 
            this.txt_Texto.Location = new System.Drawing.Point(26, 25);
            this.txt_Texto.Name = "txt_Texto";
            this.txt_Texto.Size = new System.Drawing.Size(242, 150);
            this.txt_Texto.TabIndex = 5;
            this.txt_Texto.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_Detener);
            this.tabPage3.Controls.Add(this.vsp_camara);
            this.tabPage3.Controls.Add(this.cmbx_CamSelec);
            this.tabPage3.Controls.Add(this.btn_Iniciar);
            this.tabPage3.Controls.Add(this.txt_TextoCam);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(375, 507);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Leer por Camara";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_Detener
            // 
            this.btn_Detener.Location = new System.Drawing.Point(275, 8);
            this.btn_Detener.Name = "btn_Detener";
            this.btn_Detener.Size = new System.Drawing.Size(75, 21);
            this.btn_Detener.TabIndex = 4;
            this.btn_Detener.Text = "Detener";
            this.btn_Detener.UseVisualStyleBackColor = true;
            this.btn_Detener.Click += new System.EventHandler(this.btn_Detener_Click);
            // 
            // vsp_camara
            // 
            this.vsp_camara.Location = new System.Drawing.Point(8, 35);
            this.vsp_camara.Name = "vsp_camara";
            this.vsp_camara.Size = new System.Drawing.Size(358, 223);
            this.vsp_camara.TabIndex = 3;
            this.vsp_camara.Text = "videoSourcePlayer1";
            this.vsp_camara.VideoSource = null;
            // 
            // cmbx_CamSelec
            // 
            this.cmbx_CamSelec.FormattingEnabled = true;
            this.cmbx_CamSelec.Location = new System.Drawing.Point(51, 8);
            this.cmbx_CamSelec.Name = "cmbx_CamSelec";
            this.cmbx_CamSelec.Size = new System.Drawing.Size(121, 21);
            this.cmbx_CamSelec.TabIndex = 2;
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.Location = new System.Drawing.Point(194, 8);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(75, 21);
            this.btn_Iniciar.TabIndex = 1;
            this.btn_Iniciar.Text = "Iniciar";
            this.btn_Iniciar.UseVisualStyleBackColor = true;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // txt_TextoCam
            // 
            this.txt_TextoCam.Location = new System.Drawing.Point(8, 264);
            this.txt_TextoCam.Name = "txt_TextoCam";
            this.txt_TextoCam.Size = new System.Drawing.Size(358, 235);
            this.txt_TextoCam.TabIndex = 0;
            this.txt_TextoCam.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 534);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbg_Generar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbg_codigo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox txt_Nombre;
        private System.Windows.Forms.PictureBox pbg_Generar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pbg_codigo;
        private System.Windows.Forms.Button btn_Abrir;
        private System.Windows.Forms.RichTextBox txt_Texto;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox txt_TextoCam;
        private System.Windows.Forms.ComboBox cmbx_CamSelec;
        private System.Windows.Forms.Button btn_Iniciar;
        private AForge.Controls.VideoSourcePlayer vsp_camara;
        private System.Windows.Forms.Button btn_Detener;
        private System.Windows.Forms.Timer timer1;
    }
}

