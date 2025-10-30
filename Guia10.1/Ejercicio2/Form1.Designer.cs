namespace Ejercicio2
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
            btnRegistrarReclamo = new Button();
            groupBox4 = new GroupBox();
            tbMotivoReclamo = new TextBox();
            tbNombrePersona = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            btnCrearOrden = new Button();
            groupBox5 = new GroupBox();
            lbxVerReclamos = new ListBox();
            groupBox3 = new GroupBox();
            btnEjecutarOrden = new Button();
            groupBox6 = new GroupBox();
            lbxVerOrdenesAEjecutar = new ListBox();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrarReclamo);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Location = new Point(5, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 415);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recepción de reclamos";
            // 
            // btnRegistrarReclamo
            // 
            btnRegistrarReclamo.Location = new Point(95, 345);
            btnRegistrarReclamo.Name = "btnRegistrarReclamo";
            btnRegistrarReclamo.Size = new Size(120, 63);
            btnRegistrarReclamo.TabIndex = 3;
            btnRegistrarReclamo.Text = "Registrar Reclamo";
            btnRegistrarReclamo.UseVisualStyleBackColor = true;
            btnRegistrarReclamo.Click += btnRegistrarReclamo_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tbMotivoReclamo);
            groupBox4.Controls.Add(tbNombrePersona);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label3);
            groupBox4.Location = new Point(6, 42);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(356, 200);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos del reclamo";
            // 
            // tbMotivoReclamo
            // 
            tbMotivoReclamo.Location = new Point(152, 85);
            tbMotivoReclamo.Multiline = true;
            tbMotivoReclamo.Name = "tbMotivoReclamo";
            tbMotivoReclamo.Size = new Size(186, 92);
            tbMotivoReclamo.TabIndex = 4;
            // 
            // tbNombrePersona
            // 
            tbNombrePersona.Location = new Point(152, 41);
            tbNombrePersona.Name = "tbNombrePersona";
            tbNombrePersona.Size = new Size(186, 23);
            tbNombrePersona.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 45);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre de la Persona";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 85);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 2;
            label3.Text = "Motivo del reclamo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCrearOrden);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Location = new Point(384, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(347, 415);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Planificar Trabajo";
            // 
            // btnCrearOrden
            // 
            btnCrearOrden.Location = new Point(116, 345);
            btnCrearOrden.Name = "btnCrearOrden";
            btnCrearOrden.Size = new Size(120, 63);
            btnCrearOrden.TabIndex = 4;
            btnCrearOrden.Text = "Crear Orde De Trabajo";
            btnCrearOrden.UseVisualStyleBackColor = true;
            btnCrearOrden.Click += btnCrearOrden_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lbxVerReclamos);
            groupBox5.Location = new Point(6, 22);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(335, 316);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Lista de reclamos";
            // 
            // lbxVerReclamos
            // 
            lbxVerReclamos.FormattingEnabled = true;
            lbxVerReclamos.ItemHeight = 15;
            lbxVerReclamos.Location = new Point(15, 22);
            lbxVerReclamos.Name = "lbxVerReclamos";
            lbxVerReclamos.Size = new Size(314, 289);
            lbxVerReclamos.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEjecutarOrden);
            groupBox3.Controls.Add(groupBox6);
            groupBox3.Location = new Point(742, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(347, 415);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ordenes de Trabajo";
            // 
            // btnEjecutarOrden
            // 
            btnEjecutarOrden.Location = new Point(119, 345);
            btnEjecutarOrden.Name = "btnEjecutarOrden";
            btnEjecutarOrden.Size = new Size(120, 63);
            btnEjecutarOrden.TabIndex = 5;
            btnEjecutarOrden.Text = "Ejecutar Orden De Trabajo";
            btnEjecutarOrden.UseVisualStyleBackColor = true;
            btnEjecutarOrden.Click += btnEjecutarOrden_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lbxVerOrdenesAEjecutar);
            groupBox6.Location = new Point(7, 23);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(335, 316);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Trabajos ejecutados";
            // 
            // lbxVerOrdenesAEjecutar
            // 
            lbxVerOrdenesAEjecutar.FormattingEnabled = true;
            lbxVerOrdenesAEjecutar.ItemHeight = 15;
            lbxVerOrdenesAEjecutar.Location = new Point(15, 22);
            lbxVerOrdenesAEjecutar.Name = "lbxVerOrdenesAEjecutar";
            lbxVerOrdenesAEjecutar.Size = new Size(314, 289);
            lbxVerOrdenesAEjecutar.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 489);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Centro de Atencion";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox tbMotivoReclamo;
        private TextBox tbNombrePersona;
        private Label label2;
        private Label label3;
        private GroupBox groupBox5;
        private ListBox lbxVerReclamos;
        private GroupBox groupBox6;
        private ListBox lbxVerOrdenesAEjecutar;
        private Button btnRegistrarReclamo;
        private Button btnCrearOrden;
        private Button btnEjecutarOrden;
    }
}
