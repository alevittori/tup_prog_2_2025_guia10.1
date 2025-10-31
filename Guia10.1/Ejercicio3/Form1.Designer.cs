namespace Ejercicio3
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
            lbxPedidosEntrantes = new ListBox();
            tbDir = new TextBox();
            tbTel = new TextBox();
            btnAtender = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lbxOcupado = new ListBox();
            lbxDisponibles = new ListBox();
            btnAsignarCoche = new Button();
            label4 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            nupNumMovil = new NumericUpDown();
            btnLiberarConche = new Button();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupNumMovil).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbxPedidosEntrantes);
            groupBox1.Controls.Add(tbDir);
            groupBox1.Controls.Add(tbTel);
            groupBox1.Controls.Add(btnAtender);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(302, 410);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recibir Pedido Taxi";
            // 
            // lbxPedidosEntrantes
            // 
            lbxPedidosEntrantes.FormattingEnabled = true;
            lbxPedidosEntrantes.ItemHeight = 15;
            lbxPedidosEntrantes.Location = new Point(22, 197);
            lbxPedidosEntrantes.Name = "lbxPedidosEntrantes";
            lbxPedidosEntrantes.Size = new Size(273, 109);
            lbxPedidosEntrantes.TabIndex = 6;
            // 
            // tbDir
            // 
            tbDir.Location = new Point(110, 83);
            tbDir.Multiline = true;
            tbDir.Name = "tbDir";
            tbDir.Size = new Size(172, 67);
            tbDir.TabIndex = 5;
            // 
            // tbTel
            // 
            tbTel.Location = new Point(110, 39);
            tbTel.Name = "tbTel";
            tbTel.Size = new Size(172, 23);
            tbTel.TabIndex = 4;
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(75, 328);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(129, 60);
            btnAtender.TabIndex = 3;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 172);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 2;
            label3.Text = "Pedidos Entrantes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 83);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Direccion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 43);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Telefono";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbxOcupado);
            groupBox2.Controls.Add(lbxDisponibles);
            groupBox2.Controls.Add(btnAsignarCoche);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(358, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(369, 410);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Central de taxis";
            // 
            // lbxOcupado
            // 
            lbxOcupado.FormattingEnabled = true;
            lbxOcupado.ItemHeight = 15;
            lbxOcupado.Location = new Point(27, 198);
            lbxOcupado.Name = "lbxOcupado";
            lbxOcupado.Size = new Size(273, 109);
            lbxOcupado.TabIndex = 8;
            // 
            // lbxDisponibles
            // 
            lbxDisponibles.FormattingEnabled = true;
            lbxDisponibles.ItemHeight = 15;
            lbxDisponibles.Location = new Point(27, 48);
            lbxDisponibles.Name = "lbxDisponibles";
            lbxDisponibles.Size = new Size(273, 109);
            lbxDisponibles.TabIndex = 7;
            // 
            // btnAsignarCoche
            // 
            btnAsignarCoche.Location = new Point(116, 328);
            btnAsignarCoche.Name = "btnAsignarCoche";
            btnAsignarCoche.Size = new Size(129, 60);
            btnAsignarCoche.TabIndex = 4;
            btnAsignarCoche.Text = "Asignar Coche a Cliente";
            btnAsignarCoche.UseVisualStyleBackColor = true;
            btnAsignarCoche.Click += btnAsignarCoche_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 30);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 3;
            label4.Text = "Vehículos Disponibles";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 172);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 4;
            label5.Text = "Vehículos Ocupados";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nupNumMovil);
            groupBox3.Controls.Add(btnLiberarConche);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(773, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(302, 410);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Acciones del chofer";
            // 
            // nupNumMovil
            // 
            nupNumMovil.Location = new Point(167, 59);
            nupNumMovil.Name = "nupNumMovil";
            nupNumMovil.Size = new Size(87, 23);
            nupNumMovil.TabIndex = 6;
            // 
            // btnLiberarConche
            // 
            btnLiberarConche.Location = new Point(125, 328);
            btnLiberarConche.Name = "btnLiberarConche";
            btnLiberarConche.Size = new Size(129, 60);
            btnLiberarConche.TabIndex = 5;
            btnLiberarConche.Text = "Liberar Coche";
            btnLiberarConche.UseVisualStyleBackColor = true;
            btnLiberarConche.Click += btnLiberarConche_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 63);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 5;
            label6.Text = "Número del Vehículo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 468);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agencia de Taxis";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupNumMovil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox tbDir;
        private TextBox tbTel;
        private Button btnAtender;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAsignarCoche;
        private Label label4;
        private Label label5;
        private NumericUpDown nupNumMovil;
        private Button btnLiberarConche;
        private Label label6;
        private ListBox lbxPedidosEntrantes;
        private ListBox lbxOcupado;
        private ListBox lbxDisponibles;
    }
}
