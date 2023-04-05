namespace Presentacion
{
    partial class Frm_trabajandoCombobox
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
            this.cmb_cursosdisponibles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cursonuevo = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_cursosdisponibles
            // 
            this.cmb_cursosdisponibles.FormattingEnabled = true;
            this.cmb_cursosdisponibles.Items.AddRange(new object[] {
            "VISUAL FOXPRO",
            "C SHARP",
            "VISUAL BASIC .NET"});
            this.cmb_cursosdisponibles.Location = new System.Drawing.Point(557, 44);
            this.cmb_cursosdisponibles.Name = "cmb_cursosdisponibles";
            this.cmb_cursosdisponibles.Size = new System.Drawing.Size(215, 21);
            this.cmb_cursosdisponibles.TabIndex = 0;
            this.cmb_cursosdisponibles.Text = "Seleccione un curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cursos Disponibles";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(531, 129);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(241, 107);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Curso Seleccionado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Curso nuevo";
            // 
            // txt_cursonuevo
            // 
            this.txt_cursonuevo.Location = new System.Drawing.Point(92, 61);
            this.txt_cursonuevo.Name = "txt_cursonuevo";
            this.txt_cursonuevo.Size = new System.Drawing.Size(132, 20);
            this.txt_cursonuevo.TabIndex = 5;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(22, 120);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(88, 36);
            this.btn_registrar.TabIndex = 6;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            // 
            // Frm_trabajandoCombobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 290);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_cursonuevo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_cursosdisponibles);
            this.Name = "Frm_trabajandoCombobox";
            this.Text = "Frm_trabajandoCombobox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_cursosdisponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cursonuevo;
        private System.Windows.Forms.Button btn_registrar;
    }
}