namespace GUIPrincipal
{
    partial class FormInicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnFrmGUIAsignaciones = new System.Windows.Forms.Button();
            this.btnFrmGUIInformes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Que desea hacer?";
            // 
            // btnFrmGUIAsignaciones
            // 
            this.btnFrmGUIAsignaciones.Location = new System.Drawing.Point(25, 95);
            this.btnFrmGUIAsignaciones.Name = "btnFrmGUIAsignaciones";
            this.btnFrmGUIAsignaciones.Size = new System.Drawing.Size(156, 96);
            this.btnFrmGUIAsignaciones.TabIndex = 1;
            this.btnFrmGUIAsignaciones.Text = "Gestionar Asignaciones de la Escuela";
            this.btnFrmGUIAsignaciones.UseVisualStyleBackColor = true;
            // 
            // btnFrmGUIInformes
            // 
            this.btnFrmGUIInformes.Location = new System.Drawing.Point(211, 95);
            this.btnFrmGUIInformes.Name = "btnFrmGUIInformes";
            this.btnFrmGUIInformes.Size = new System.Drawing.Size(156, 96);
            this.btnFrmGUIInformes.TabIndex = 2;
            this.btnFrmGUIInformes.Text = "Gestionar Informes del Ministerio";
            this.btnFrmGUIInformes.UseVisualStyleBackColor = true;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 227);
            this.Controls.Add(this.btnFrmGUIInformes);
            this.Controls.Add(this.btnFrmGUIAsignaciones);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormInicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFrmGUIAsignaciones;
        private System.Windows.Forms.Button btnFrmGUIInformes;
    }
}

