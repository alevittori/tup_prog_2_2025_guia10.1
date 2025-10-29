namespace Ejercicio1
{
    partial class FDatoCamion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAceptar = new Button();
            label1 = new Label();
            nupCapacidadCamion = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nupCapacidadCamion).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(44, 107);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 39);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 45);
            label1.Name = "label1";
            label1.Size = new Size(165, 21);
            label1.TabIndex = 1;
            label1.Text = "Capacidad del Camión";
            // 
            // nupCapacidadCamion
            // 
            nupCapacidadCamion.Location = new Point(233, 45);
            nupCapacidadCamion.Name = "nupCapacidadCamion";
            nupCapacidadCamion.Size = new Size(98, 23);
            nupCapacidadCamion.TabIndex = 2;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(219, 107);
            button1.Name = "button1";
            button1.Size = new Size(112, 39);
            button1.TabIndex = 3;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FDatoCamion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 207);
            Controls.Add(button1);
            Controls.Add(nupCapacidadCamion);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FDatoCamion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Datos del Camión";
            ((System.ComponentModel.ISupportInitialize)nupCapacidadCamion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Label label1;
        private Button button1;
        public NumericUpDown nupCapacidadCamion;
    }
}