namespace Presentacion
{
    partial class MiPrimerFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiPrimerFormulario));
            this.grb_mantenimiento = new System.Windows.Forms.GroupBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_botones_principales = new System.Windows.Forms.GroupBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.grb_mantenimiento.SuspendLayout();
            this.grb_botones_principales.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_mantenimiento
            // 
            this.grb_mantenimiento.BackColor = System.Drawing.Color.LightCyan;
            this.grb_mantenimiento.Controls.Add(this.btn_cancelar);
            this.grb_mantenimiento.Controls.Add(this.btn_guardar);
            this.grb_mantenimiento.Controls.Add(this.txt_descripcion);
            this.grb_mantenimiento.Controls.Add(this.label2);
            this.grb_mantenimiento.Controls.Add(this.txt_codigo);
            this.grb_mantenimiento.Controls.Add(this.label1);
            resources.ApplyResources(this.grb_mantenimiento, "grb_mantenimiento");
            this.grb_mantenimiento.Name = "grb_mantenimiento";
            this.grb_mantenimiento.TabStop = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btn_cancelar, "btn_cancelar");
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Teal;
            resources.ApplyResources(this.btn_guardar, "btn_guardar");
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // txt_descripcion
            // 
            resources.ApplyResources(this.txt_descripcion, "txt_descripcion");
            this.txt_descripcion.Name = "txt_descripcion";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txt_codigo
            // 
            resources.ApplyResources(this.txt_codigo, "txt_codigo");
            this.txt_codigo.Name = "txt_codigo";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // grb_botones_principales
            // 
            this.grb_botones_principales.Controls.Add(this.btn_salir);
            this.grb_botones_principales.Controls.Add(this.btn_reporte);
            this.grb_botones_principales.Controls.Add(this.btn_eliminar);
            this.grb_botones_principales.Controls.Add(this.btn_actualizar);
            this.grb_botones_principales.Controls.Add(this.btn_nuevo);
            resources.ApplyResources(this.grb_botones_principales, "grb_botones_principales");
            this.grb_botones_principales.Name = "grb_botones_principales";
            this.grb_botones_principales.TabStop = false;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.btn_salir, "btn_salir");
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            // 
            // btn_reporte
            // 
            this.btn_reporte.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.btn_reporte, "btn_reporte");
            this.btn_reporte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.btn_eliminar, "btn_eliminar");
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.btn_actualizar, "btn_actualizar");
            this.btn_actualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.btn_nuevo, "btn_nuevo");
            this.btn_nuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // MiPrimerFormulario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.grb_botones_principales);
            this.Controls.Add(this.grb_mantenimiento);
            this.Name = "MiPrimerFormulario";
            this.Load += new System.EventHandler(this.MiPrimerFormulario_Load);
            this.grb_mantenimiento.ResumeLayout(false);
            this.grb_mantenimiento.PerformLayout();
            this.grb_botones_principales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grb_mantenimiento;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_botones_principales;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_nuevo;
    }
}