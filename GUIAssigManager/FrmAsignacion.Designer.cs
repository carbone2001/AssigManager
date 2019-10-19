namespace GUIAssigManager
{
    partial class FrmAsignacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHermano = new System.Windows.Forms.ComboBox();
            this.cmbAsignacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Semana = new System.Windows.Forms.Label();
            this.dtpSemanaAsignacion = new System.Windows.Forms.DateTimePicker();
            this.cmbEscuela = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ckbRechazada = new System.Windows.Forms.CheckBox();
            this.cmbAyudante = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAspectoOratoria = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAspectoOratoria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hermano";
            // 
            // cmbHermano
            // 
            this.cmbHermano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHermano.FormattingEnabled = true;
            this.cmbHermano.Location = new System.Drawing.Point(12, 40);
            this.cmbHermano.Name = "cmbHermano";
            this.cmbHermano.Size = new System.Drawing.Size(311, 21);
            this.cmbHermano.TabIndex = 1;
            // 
            // cmbAsignacion
            // 
            this.cmbAsignacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsignacion.FormattingEnabled = true;
            this.cmbAsignacion.Location = new System.Drawing.Point(14, 120);
            this.cmbAsignacion.Name = "cmbAsignacion";
            this.cmbAsignacion.Size = new System.Drawing.Size(135, 21);
            this.cmbAsignacion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Asignacion";
            // 
            // Semana
            // 
            this.Semana.AutoSize = true;
            this.Semana.Location = new System.Drawing.Point(14, 154);
            this.Semana.Name = "Semana";
            this.Semana.Size = new System.Drawing.Size(59, 13);
            this.Semana.TabIndex = 4;
            this.Semana.Text = "Asignacion";
            // 
            // dtpSemanaAsignacion
            // 
            this.dtpSemanaAsignacion.Location = new System.Drawing.Point(17, 170);
            this.dtpSemanaAsignacion.Name = "dtpSemanaAsignacion";
            this.dtpSemanaAsignacion.Size = new System.Drawing.Size(200, 20);
            this.dtpSemanaAsignacion.TabIndex = 6;
            // 
            // cmbEscuela
            // 
            this.cmbEscuela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEscuela.FormattingEnabled = true;
            this.cmbEscuela.Location = new System.Drawing.Point(156, 120);
            this.cmbEscuela.Name = "cmbEscuela";
            this.cmbEscuela.Size = new System.Drawing.Size(61, 21);
            this.cmbEscuela.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Escuela";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(14, 217);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(104, 46);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(221, 217);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 46);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ckbRechazada
            // 
            this.ckbRechazada.AutoSize = true;
            this.ckbRechazada.Location = new System.Drawing.Point(223, 173);
            this.ckbRechazada.Name = "ckbRechazada";
            this.ckbRechazada.Size = new System.Drawing.Size(81, 17);
            this.ckbRechazada.TabIndex = 11;
            this.ckbRechazada.Text = "Rechazada";
            this.ckbRechazada.UseVisualStyleBackColor = true;
            // 
            // cmbAyudante
            // 
            this.cmbAyudante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAyudante.FormattingEnabled = true;
            this.cmbAyudante.Location = new System.Drawing.Point(14, 80);
            this.cmbAyudante.Name = "cmbAyudante";
            this.cmbAyudante.Size = new System.Drawing.Size(311, 21);
            this.cmbAyudante.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ayudante";
            // 
            // nudAspectoOratoria
            // 
            this.nudAspectoOratoria.Location = new System.Drawing.Point(223, 121);
            this.nudAspectoOratoria.Name = "nudAspectoOratoria";
            this.nudAspectoOratoria.Size = new System.Drawing.Size(50, 20);
            this.nudAspectoOratoria.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Aspecto de la Oratoria";
            // 
            // FrmAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 279);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudAspectoOratoria);
            this.Controls.Add(this.cmbAyudante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckbRechazada);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEscuela);
            this.Controls.Add(this.dtpSemanaAsignacion);
            this.Controls.Add(this.Semana);
            this.Controls.Add(this.cmbAsignacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbHermano);
            this.Controls.Add(this.label1);
            this.Name = "FrmAsignacion";
            this.Text = "Formulario De Asignacion";
            ((System.ComponentModel.ISupportInitialize)(this.nudAspectoOratoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHermano;
        private System.Windows.Forms.ComboBox cmbAsignacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Semana;
        private System.Windows.Forms.DateTimePicker dtpSemanaAsignacion;
        private System.Windows.Forms.ComboBox cmbEscuela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox ckbRechazada;
        private System.Windows.Forms.ComboBox cmbAyudante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAspectoOratoria;
        private System.Windows.Forms.Label label5;
    }
}