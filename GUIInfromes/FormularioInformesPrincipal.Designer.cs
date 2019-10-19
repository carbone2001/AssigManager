namespace GUIInfromes
{
    partial class FormularioInformesPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lsbListaInformes = new System.Windows.Forms.ListBox();
            this.btnEliminarInforme = new System.Windows.Forms.Button();
            this.btnInformesUnHermano = new System.Windows.Forms.Button();
            this.btnEditarInforme = new System.Windows.Forms.Button();
            this.btnAgregarInforme = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.congregacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lsbListaInformes);
            this.groupBox1.Controls.Add(this.btnEliminarInforme);
            this.groupBox1.Controls.Add(this.btnInformesUnHermano);
            this.groupBox1.Controls.Add(this.btnEditarInforme);
            this.groupBox1.Controls.Add(this.btnAgregarInforme);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informes";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(459, 21);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(88, 21);
            this.comboBox3.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(316, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(137, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // lsbListaInformes
            // 
            this.lsbListaInformes.FormattingEnabled = true;
            this.lsbListaInformes.Location = new System.Drawing.Point(124, 45);
            this.lsbListaInformes.Name = "lsbListaInformes";
            this.lsbListaInformes.Size = new System.Drawing.Size(634, 277);
            this.lsbListaInformes.TabIndex = 4;
            // 
            // btnEliminarInforme
            // 
            this.btnEliminarInforme.Location = new System.Drawing.Point(6, 252);
            this.btnEliminarInforme.Name = "btnEliminarInforme";
            this.btnEliminarInforme.Size = new System.Drawing.Size(112, 71);
            this.btnEliminarInforme.TabIndex = 3;
            this.btnEliminarInforme.Text = "Eliminar Informe";
            this.btnEliminarInforme.UseVisualStyleBackColor = true;
            // 
            // btnInformesUnHermano
            // 
            this.btnInformesUnHermano.Location = new System.Drawing.Point(6, 175);
            this.btnInformesUnHermano.Name = "btnInformesUnHermano";
            this.btnInformesUnHermano.Size = new System.Drawing.Size(112, 71);
            this.btnInformesUnHermano.TabIndex = 2;
            this.btnInformesUnHermano.Text = "Informes de un Hermano";
            this.btnInformesUnHermano.UseVisualStyleBackColor = true;
            // 
            // btnEditarInforme
            // 
            this.btnEditarInforme.Location = new System.Drawing.Point(6, 98);
            this.btnEditarInforme.Name = "btnEditarInforme";
            this.btnEditarInforme.Size = new System.Drawing.Size(112, 71);
            this.btnEditarInforme.TabIndex = 1;
            this.btnEditarInforme.Text = "Editar Informe";
            this.btnEditarInforme.UseVisualStyleBackColor = true;
            // 
            // btnAgregarInforme
            // 
            this.btnAgregarInforme.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarInforme.Location = new System.Drawing.Point(6, 21);
            this.btnAgregarInforme.Name = "btnAgregarInforme";
            this.btnAgregarInforme.Size = new System.Drawing.Size(112, 71);
            this.btnAgregarInforme.TabIndex = 0;
            this.btnAgregarInforme.Text = "Agregar Informe";
            this.btnAgregarInforme.UseVisualStyleBackColor = false;
            this.btnAgregarInforme.Click += new System.EventHandler(this.btnAgregarInforme_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.congregacionToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // congregacionToolStripMenuItem
            // 
            this.congregacionToolStripMenuItem.Name = "congregacionToolStripMenuItem";
            this.congregacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.congregacionToolStripMenuItem.Text = "Congregacion";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.editarToolStripMenuItem.Text = "Configuracion";
            // 
            // FormularioInformesPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(788, 368);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioInformesPrincipal";
            this.Text = "AssigManager";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminarInforme;
        private System.Windows.Forms.Button btnInformesUnHermano;
        private System.Windows.Forms.Button btnEditarInforme;
        private System.Windows.Forms.Button btnAgregarInforme;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox lsbListaInformes;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem congregacionToolStripMenuItem;
    }
}

