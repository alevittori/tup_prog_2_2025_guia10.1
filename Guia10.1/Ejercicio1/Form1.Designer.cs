namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnRecibirPaquete = new Button();
            tbDireccion = new TextBox();
            label1 = new Label();
            tbNombre = new TextBox();
            label2 = new Label();
            tbDNI = new TextBox();
            label3 = new Label();
            btnPrepararCamion = new Button();
            groupBox2 = new GroupBox();
            label4 = new Label();
            lsbPaquetesRecibidos = new ListBox();
            groupBox3 = new GroupBox();
            label8 = new Label();
            lsbPaquetesAEntregar = new ListBox();
            btnEntragarPaquete = new Button();
            btnIniciarReparto = new Button();
            gbEntregar = new GroupBox();
            tbDirEntrega = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            tbNombreEntrega = new TextBox();
            tbDniEntrega = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            gbEntregar.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRecibirPaquete);
            groupBox1.Controls.Add(tbDireccion);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbDNI);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 356);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Atencion al Cliente";
            // 
            // btnRecibirPaquete
            // 
            btnRecibirPaquete.Location = new Point(65, 280);
            btnRecibirPaquete.Name = "btnRecibirPaquete";
            btnRecibirPaquete.Size = new Size(117, 60);
            btnRecibirPaquete.TabIndex = 1;
            btnRecibirPaquete.Text = "Recibir Correspondencia";
            btnRecibirPaquete.UseVisualStyleBackColor = true;
            btnRecibirPaquete.Click += btnRecibirPaquete_Click;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(88, 132);
            tbDireccion.Multiline = true;
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(130, 50);
            tbDireccion.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 45);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 1;
            label1.Text = "DNI";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(88, 80);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(130, 23);
            tbNombre.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 84);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE";
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(88, 41);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(130, 23);
            tbDNI.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 150);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 3;
            label3.Text = "DIRECCION";
            // 
            // btnPrepararCamion
            // 
            btnPrepararCamion.Location = new Point(551, 287);
            btnPrepararCamion.Name = "btnPrepararCamion";
            btnPrepararCamion.Size = new Size(113, 53);
            btnPrepararCamion.TabIndex = 1;
            btnPrepararCamion.Text = "Preparar Camion";
            btnPrepararCamion.UseVisualStyleBackColor = true;
            btnPrepararCamion.Click += btnPrepararCamion_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnPrepararCamion);
            groupBox2.Controls.Add(lsbPaquetesRecibidos);
            groupBox2.Location = new Point(253, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(679, 356);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sector de embarque";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 23);
            label4.Name = "label4";
            label4.Size = new Size(123, 15);
            label4.TabIndex = 7;
            label4.Text = "PAQUETES RECIBIDOS";
            // 
            // lsbPaquetesRecibidos
            // 
            lsbPaquetesRecibidos.FormattingEnabled = true;
            lsbPaquetesRecibidos.ItemHeight = 15;
            lsbPaquetesRecibidos.Location = new Point(6, 41);
            lsbPaquetesRecibidos.Name = "lsbPaquetesRecibidos";
            lsbPaquetesRecibidos.Size = new Size(531, 229);
            lsbPaquetesRecibidos.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(lsbPaquetesAEntregar);
            groupBox3.Controls.Add(btnEntragarPaquete);
            groupBox3.Controls.Add(btnIniciarReparto);
            groupBox3.Controls.Add(gbEntregar);
            groupBox3.Location = new Point(12, 389);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(920, 267);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "TAREA DE REPARTO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(343, 19);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 8;
            label8.Text = "Listado a entregar";
            // 
            // lsbPaquetesAEntregar
            // 
            lsbPaquetesAEntregar.FormattingEnabled = true;
            lsbPaquetesAEntregar.ItemHeight = 15;
            lsbPaquetesAEntregar.Location = new Point(343, 43);
            lsbPaquetesAEntregar.Name = "lsbPaquetesAEntregar";
            lsbPaquetesAEntregar.Size = new Size(562, 214);
            lsbPaquetesAEntregar.TabIndex = 10;
            // 
            // btnEntragarPaquete
            // 
            btnEntragarPaquete.Location = new Point(203, 182);
            btnEntragarPaquete.Name = "btnEntragarPaquete";
            btnEntragarPaquete.Size = new Size(113, 53);
            btnEntragarPaquete.TabIndex = 9;
            btnEntragarPaquete.Text = "Entregar Paquete";
            btnEntragarPaquete.UseVisualStyleBackColor = true;
            btnEntragarPaquete.Click += btnEntragarPaquete_Click;
            // 
            // btnIniciarReparto
            // 
            btnIniciarReparto.Location = new Point(17, 182);
            btnIniciarReparto.Name = "btnIniciarReparto";
            btnIniciarReparto.Size = new Size(113, 53);
            btnIniciarReparto.TabIndex = 8;
            btnIniciarReparto.Text = "Iniciar Reparto";
            btnIniciarReparto.UseVisualStyleBackColor = true;
            btnIniciarReparto.Click += btnIniciarReparto_Click;
            // 
            // gbEntregar
            // 
            gbEntregar.Controls.Add(tbDirEntrega);
            gbEntregar.Controls.Add(label6);
            gbEntregar.Controls.Add(label5);
            gbEntregar.Controls.Add(label7);
            gbEntregar.Controls.Add(tbNombreEntrega);
            gbEntregar.Controls.Add(tbDniEntrega);
            gbEntregar.Location = new Point(17, 32);
            gbEntregar.Name = "gbEntregar";
            gbEntregar.Size = new Size(299, 144);
            gbEntregar.TabIndex = 0;
            gbEntregar.TabStop = false;
            gbEntregar.Text = "Próximo a entregar";
            // 
            // tbDirEntrega
            // 
            tbDirEntrega.Location = new Point(99, 80);
            tbDirEntrega.Multiline = true;
            tbDirEntrega.Name = "tbDirEntrega";
            tbDirEntrega.Size = new Size(178, 50);
            tbDirEntrega.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 55);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 8;
            label6.Text = "NOMBRE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 27);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 7;
            label5.Text = "DNI";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 80);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 9;
            label7.Text = "DIRECCION";
            // 
            // tbNombreEntrega
            // 
            tbNombreEntrega.Location = new Point(99, 51);
            tbNombreEntrega.Name = "tbNombreEntrega";
            tbNombreEntrega.Size = new Size(178, 23);
            tbNombreEntrega.TabIndex = 11;
            // 
            // tbDniEntrega
            // 
            tbDniEntrega.Location = new Point(99, 23);
            tbDniEntrega.Name = "tbDniEntrega";
            tbDniEntrega.Size = new Size(130, 23);
            tbDniEntrega.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 721);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Despacho de Paquetes";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            gbEntregar.ResumeLayout(false);
            gbEntregar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbDNI;
        private TextBox tbNombre;
        private TextBox tbDireccion;
        private Button btnRecibirPaquete;
        private Button btnPrepararCamion;
        private GroupBox groupBox2;
        private ListBox lsbPaquetesRecibidos;
        private Label label4;
        private GroupBox groupBox3;
        private GroupBox gbEntregar;
        private TextBox tbDirEntrega;
        private Label label6;
        private Label label5;
        private Label label7;
        private TextBox tbNombreEntrega;
        private TextBox tbDniEntrega;
        private Label label8;
        private ListBox lsbPaquetesAEntregar;
        private Button btnEntragarPaquete;
        private Button btnIniciarReparto;
    }
}
