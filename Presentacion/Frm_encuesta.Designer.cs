namespace Presentacion
{
    partial class Frm_encuesta
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
            this.chk_vfp = new System.Windows.Forms.CheckBox();
            this.chk_csharp = new System.Windows.Forms.CheckBox();
            this.chk_vbnet = new System.Windows.Forms.CheckBox();
            this.lbl_cursosdisponibles = new System.Windows.Forms.Label();
            this.chk_java = new System.Windows.Forms.CheckBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.lbl_resultadocursosseleccionados = new System.Windows.Forms.Label();
            this.btn_procesar = new System.Windows.Forms.Button();
            this.rdb_presencial = new System.Windows.Forms.RadioButton();
            this.rdb_virtual = new System.Windows.Forms.RadioButton();
            this.lbl_aprendizajegustaria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_vfp
            // 
            this.chk_vfp.AutoSize = true;
            this.chk_vfp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_vfp.Location = new System.Drawing.Point(37, 98);
            this.chk_vfp.Name = "chk_vfp";
            this.chk_vfp.Size = new System.Drawing.Size(109, 20);
            this.chk_vfp.TabIndex = 0;
            this.chk_vfp.Text = "Visual FoxPro";
            this.chk_vfp.UseVisualStyleBackColor = true;
            // 
            // chk_csharp
            // 
            this.chk_csharp.AutoSize = true;
            this.chk_csharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_csharp.Location = new System.Drawing.Point(37, 137);
            this.chk_csharp.Name = "chk_csharp";
            this.chk_csharp.Size = new System.Drawing.Size(42, 20);
            this.chk_csharp.TabIndex = 1;
            this.chk_csharp.Text = "C#";
            this.chk_csharp.UseVisualStyleBackColor = true;
            // 
            // chk_vbnet
            // 
            this.chk_vbnet.AutoSize = true;
            this.chk_vbnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_vbnet.Location = new System.Drawing.Point(37, 177);
            this.chk_vbnet.Name = "chk_vbnet";
            this.chk_vbnet.Size = new System.Drawing.Size(75, 20);
            this.chk_vbnet.TabIndex = 2;
            this.chk_vbnet.Text = "VB.NET";
            this.chk_vbnet.UseVisualStyleBackColor = true;
            // 
            // lbl_cursosdisponibles
            // 
            this.lbl_cursosdisponibles.AutoSize = true;
            this.lbl_cursosdisponibles.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cursosdisponibles.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_cursosdisponibles.Location = new System.Drawing.Point(34, 54);
            this.lbl_cursosdisponibles.Name = "lbl_cursosdisponibles";
            this.lbl_cursosdisponibles.Size = new System.Drawing.Size(253, 18);
            this.lbl_cursosdisponibles.TabIndex = 3;
            this.lbl_cursosdisponibles.Text = "Cursos disponibles en Promocion";
            // 
            // chk_java
            // 
            this.chk_java.AutoSize = true;
            this.chk_java.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_java.Location = new System.Drawing.Point(37, 214);
            this.chk_java.Name = "chk_java";
            this.chk_java.Size = new System.Drawing.Size(56, 20);
            this.chk_java.TabIndex = 4;
            this.chk_java.Text = "Java";
            this.chk_java.UseVisualStyleBackColor = true;
            this.chk_java.CheckedChanged += new System.EventHandler(this.chk_java_CheckedChanged);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultado.Location = new System.Drawing.Point(353, 243);
            this.txt_resultado.Multiline = true;
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(418, 148);
            this.txt_resultado.TabIndex = 5;
            // 
            // lbl_resultadocursosseleccionados
            // 
            this.lbl_resultadocursosseleccionados.AutoSize = true;
            this.lbl_resultadocursosseleccionados.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultadocursosseleccionados.ForeColor = System.Drawing.Color.Brown;
            this.lbl_resultadocursosseleccionados.Location = new System.Drawing.Point(350, 213);
            this.lbl_resultadocursosseleccionados.Name = "lbl_resultadocursosseleccionados";
            this.lbl_resultadocursosseleccionados.Size = new System.Drawing.Size(297, 18);
            this.lbl_resultadocursosseleccionados.TabIndex = 6;
            this.lbl_resultadocursosseleccionados.Text = "Resultado de los Cursos Seleccionados";
            this.lbl_resultadocursosseleccionados.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_procesar
            // 
            this.btn_procesar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_procesar.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procesar.Location = new System.Drawing.Point(37, 274);
            this.btn_procesar.Name = "btn_procesar";
            this.btn_procesar.Size = new System.Drawing.Size(125, 82);
            this.btn_procesar.TabIndex = 7;
            this.btn_procesar.Text = "Procesar";
            this.btn_procesar.UseVisualStyleBackColor = false;
            this.btn_procesar.Click += new System.EventHandler(this.btn_procesar_Click);
            // 
            // rdb_presencial
            // 
            this.rdb_presencial.AutoSize = true;
            this.rdb_presencial.Location = new System.Drawing.Point(374, 140);
            this.rdb_presencial.Name = "rdb_presencial";
            this.rdb_presencial.Size = new System.Drawing.Size(74, 17);
            this.rdb_presencial.TabIndex = 8;
            this.rdb_presencial.TabStop = true;
            this.rdb_presencial.Text = "Presencial";
            this.rdb_presencial.UseVisualStyleBackColor = true;
            this.rdb_presencial.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdb_virtual
            // 
            this.rdb_virtual.AutoSize = true;
            this.rdb_virtual.Location = new System.Drawing.Point(613, 140);
            this.rdb_virtual.Name = "rdb_virtual";
            this.rdb_virtual.Size = new System.Drawing.Size(54, 17);
            this.rdb_virtual.TabIndex = 9;
            this.rdb_virtual.TabStop = true;
            this.rdb_virtual.Text = "Virtual";
            this.rdb_virtual.UseVisualStyleBackColor = true;
            // 
            // lbl_aprendizajegustaria
            // 
            this.lbl_aprendizajegustaria.AutoSize = true;
            this.lbl_aprendizajegustaria.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aprendizajegustaria.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_aprendizajegustaria.Location = new System.Drawing.Point(381, 100);
            this.lbl_aprendizajegustaria.Name = "lbl_aprendizajegustaria";
            this.lbl_aprendizajegustaria.Size = new System.Drawing.Size(342, 18);
            this.lbl_aprendizajegustaria.TabIndex = 10;
            this.lbl_aprendizajegustaria.Text = "En que escenario de aprendizaje te gustaria?";
            // 
            // Frm_encuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_aprendizajegustaria);
            this.Controls.Add(this.rdb_virtual);
            this.Controls.Add(this.rdb_presencial);
            this.Controls.Add(this.btn_procesar);
            this.Controls.Add(this.lbl_resultadocursosseleccionados);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.chk_java);
            this.Controls.Add(this.lbl_cursosdisponibles);
            this.Controls.Add(this.chk_vbnet);
            this.Controls.Add(this.chk_csharp);
            this.Controls.Add(this.chk_vfp);
            this.Name = "Frm_encuesta";
            this.Text = "ENCUESTA DE CURSOS DISPONIBLES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_vfp;
        private System.Windows.Forms.CheckBox chk_csharp;
        private System.Windows.Forms.CheckBox chk_vbnet;
        private System.Windows.Forms.Label lbl_cursosdisponibles;
        private System.Windows.Forms.CheckBox chk_java;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label lbl_resultadocursosseleccionados;
        private System.Windows.Forms.Button btn_procesar;
        private System.Windows.Forms.RadioButton rdb_presencial;
        private System.Windows.Forms.RadioButton rdb_virtual;
        private System.Windows.Forms.Label lbl_aprendizajegustaria;
    }
}