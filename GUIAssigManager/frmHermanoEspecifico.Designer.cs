namespace GUIAssigManager
{
    partial class frmHermanoEspecifico
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
            this.cmbListaDeHermanos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbListaAsignacionesDelHermano = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOrdenamientos = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbListaDeHermanos
            // 
            this.cmbListaDeHermanos.FormattingEnabled = true;
            this.cmbListaDeHermanos.Location = new System.Drawing.Point(12, 38);
            this.cmbListaDeHermanos.Name = "cmbListaDeHermanos";
            this.cmbListaDeHermanos.Size = new System.Drawing.Size(491, 21);
            this.cmbListaDeHermanos.TabIndex = 0;
            this.cmbListaDeHermanos.SelectedIndexChanged += new System.EventHandler(this.cmbListaDeHermanos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hermano";
            // 
            // lsbListaAsignacionesDelHermano
            // 
            this.lsbListaAsignacionesDelHermano.FormattingEnabled = true;
            this.lsbListaAsignacionesDelHermano.HorizontalScrollbar = true;
            this.lsbListaAsignacionesDelHermano.Location = new System.Drawing.Point(12, 78);
            this.lsbListaAsignacionesDelHermano.Name = "lsbListaAsignacionesDelHermano";
            this.lsbListaAsignacionesDelHermano.Size = new System.Drawing.Size(491, 147);
            this.lsbListaAsignacionesDelHermano.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista de Asignaciones ";
            // 
            // cmbOrdenamientos
            // 
            this.cmbOrdenamientos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenamientos.FormattingEnabled = true;
            this.cmbOrdenamientos.Location = new System.Drawing.Point(12, 231);
            this.cmbOrdenamientos.Name = "cmbOrdenamientos";
            this.cmbOrdenamientos.Size = new System.Drawing.Size(148, 21);
            this.cmbOrdenamientos.TabIndex = 4;
            this.cmbOrdenamientos.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenamientos_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(385, 231);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 38);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmHermanoEspecifico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 279);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbOrdenamientos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsbListaAsignacionesDelHermano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbListaDeHermanos);
            this.Name = "frmHermanoEspecifico";
            this.Text = "Buscar Asignaciones de Hermano Especifico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbListaDeHermanos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbListaAsignacionesDelHermano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOrdenamientos;
        private System.Windows.Forms.Button btnSalir;
    }
}