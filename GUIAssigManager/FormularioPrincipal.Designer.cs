namespace GUIAssigManager
{
    partial class FormularioPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escuelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarCambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hermanientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbAsignacion = new System.Windows.Forms.GroupBox();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbOrdenamientoAsignaciones = new System.Windows.Forms.ComboBox();
            this.lsbAsignaciones = new System.Windows.Forms.ListBox();
            this.btnEliminarAsignaciones = new System.Windows.Forms.Button();
            this.btnEditarAsignaciones = new System.Windows.Forms.Button();
            this.btnBuscarAsignaciones = new System.Windows.Forms.Button();
            this.btnAgregarAsignacion = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbHermanos = new System.Windows.Forms.GroupBox();
            this.cmbOrdenamientoHermanos = new System.Windows.Forms.ComboBox();
            this.lsbHermanos = new System.Windows.Forms.ListBox();
            this.btnEliminarHermano = new System.Windows.Forms.Button();
            this.btnBuscarHermano = new System.Windows.Forms.Button();
            this.btnEditarInfoHermano = new System.Windows.Forms.Button();
            this.btnAgregarHermano = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblNombreCongregacion = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grbAsignacion.SuspendLayout();
            this.grbHermanos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.hermanientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarCambiosToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escuelaToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // escuelaToolStripMenuItem
            // 
            this.escuelaToolStripMenuItem.Name = "escuelaToolStripMenuItem";
            this.escuelaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.escuelaToolStripMenuItem.Text = "Escuela";
            this.escuelaToolStripMenuItem.Click += new System.EventHandler(this.escuelaToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarCambiosToolStripMenuItem
            // 
            this.guardarCambiosToolStripMenuItem.Name = "guardarCambiosToolStripMenuItem";
            this.guardarCambiosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.guardarCambiosToolStripMenuItem.Text = "Guardar cambios";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // hermanientasToolStripMenuItem
            // 
            this.hermanientasToolStripMenuItem.Name = "hermanientasToolStripMenuItem";
            this.hermanientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.hermanientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // grbAsignacion
            // 
            this.grbAsignacion.Controls.Add(this.cmbAño);
            this.grbAsignacion.Controls.Add(this.cmbMes);
            this.grbAsignacion.Controls.Add(this.cmbOrdenamientoAsignaciones);
            this.grbAsignacion.Controls.Add(this.lsbAsignaciones);
            this.grbAsignacion.Controls.Add(this.btnEliminarAsignaciones);
            this.grbAsignacion.Controls.Add(this.btnEditarAsignaciones);
            this.grbAsignacion.Controls.Add(this.btnBuscarAsignaciones);
            this.grbAsignacion.Controls.Add(this.btnAgregarAsignacion);
            this.grbAsignacion.Location = new System.Drawing.Point(12, 27);
            this.grbAsignacion.Name = "grbAsignacion";
            this.grbAsignacion.Size = new System.Drawing.Size(534, 229);
            this.grbAsignacion.TabIndex = 1;
            this.grbAsignacion.TabStop = false;
            this.grbAsignacion.Text = "Asignacion";
            // 
            // cmbAño
            // 
            this.cmbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(427, 200);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(101, 21);
            this.cmbAño.TabIndex = 7;
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(281, 200);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(140, 21);
            this.cmbMes.TabIndex = 6;
            // 
            // cmbOrdenamientoAsignaciones
            // 
            this.cmbOrdenamientoAsignaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenamientoAsignaciones.FormattingEnabled = true;
            this.cmbOrdenamientoAsignaciones.Location = new System.Drawing.Point(135, 200);
            this.cmbOrdenamientoAsignaciones.Name = "cmbOrdenamientoAsignaciones";
            this.cmbOrdenamientoAsignaciones.Size = new System.Drawing.Size(140, 21);
            this.cmbOrdenamientoAsignaciones.TabIndex = 5;
            // 
            // lsbAsignaciones
            // 
            this.lsbAsignaciones.FormattingEnabled = true;
            this.lsbAsignaciones.Location = new System.Drawing.Point(135, 22);
            this.lsbAsignaciones.Name = "lsbAsignaciones";
            this.lsbAsignaciones.Size = new System.Drawing.Size(393, 173);
            this.lsbAsignaciones.TabIndex = 4;
            // 
            // btnEliminarAsignaciones
            // 
            this.btnEliminarAsignaciones.Location = new System.Drawing.Point(6, 175);
            this.btnEliminarAsignaciones.Name = "btnEliminarAsignaciones";
            this.btnEliminarAsignaciones.Size = new System.Drawing.Size(123, 46);
            this.btnEliminarAsignaciones.TabIndex = 3;
            this.btnEliminarAsignaciones.Text = "Eliminar Asignación";
            this.btnEliminarAsignaciones.UseVisualStyleBackColor = true;
            // 
            // btnEditarAsignaciones
            // 
            this.btnEditarAsignaciones.Location = new System.Drawing.Point(6, 123);
            this.btnEditarAsignaciones.Name = "btnEditarAsignaciones";
            this.btnEditarAsignaciones.Size = new System.Drawing.Size(123, 46);
            this.btnEditarAsignaciones.TabIndex = 2;
            this.btnEditarAsignaciones.Text = "Editar Asignación";
            this.btnEditarAsignaciones.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAsignaciones
            // 
            this.btnBuscarAsignaciones.Location = new System.Drawing.Point(6, 71);
            this.btnBuscarAsignaciones.Name = "btnBuscarAsignaciones";
            this.btnBuscarAsignaciones.Size = new System.Drawing.Size(123, 46);
            this.btnBuscarAsignaciones.TabIndex = 1;
            this.btnBuscarAsignaciones.Text = "Buscar Asignación";
            this.btnBuscarAsignaciones.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAsignacion
            // 
            this.btnAgregarAsignacion.Location = new System.Drawing.Point(6, 19);
            this.btnAgregarAsignacion.Name = "btnAgregarAsignacion";
            this.btnAgregarAsignacion.Size = new System.Drawing.Size(123, 46);
            this.btnAgregarAsignacion.TabIndex = 0;
            this.btnAgregarAsignacion.Text = "Crear  Asignación";
            this.btnAgregarAsignacion.UseVisualStyleBackColor = true;
            // 
            // grbHermanos
            // 
            this.grbHermanos.Controls.Add(this.cmbOrdenamientoHermanos);
            this.grbHermanos.Controls.Add(this.lsbHermanos);
            this.grbHermanos.Controls.Add(this.btnEliminarHermano);
            this.grbHermanos.Controls.Add(this.btnBuscarHermano);
            this.grbHermanos.Controls.Add(this.btnEditarInfoHermano);
            this.grbHermanos.Controls.Add(this.btnAgregarHermano);
            this.grbHermanos.Location = new System.Drawing.Point(12, 262);
            this.grbHermanos.Name = "grbHermanos";
            this.grbHermanos.Size = new System.Drawing.Size(786, 229);
            this.grbHermanos.TabIndex = 2;
            this.grbHermanos.TabStop = false;
            this.grbHermanos.Text = "Hermanos";
            // 
            // cmbOrdenamientoHermanos
            // 
            this.cmbOrdenamientoHermanos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenamientoHermanos.FormattingEnabled = true;
            this.cmbOrdenamientoHermanos.Location = new System.Drawing.Point(135, 200);
            this.cmbOrdenamientoHermanos.Name = "cmbOrdenamientoHermanos";
            this.cmbOrdenamientoHermanos.Size = new System.Drawing.Size(140, 21);
            this.cmbOrdenamientoHermanos.TabIndex = 6;
            // 
            // lsbHermanos
            // 
            this.lsbHermanos.FormattingEnabled = true;
            this.lsbHermanos.Location = new System.Drawing.Point(135, 22);
            this.lsbHermanos.Name = "lsbHermanos";
            this.lsbHermanos.Size = new System.Drawing.Size(645, 173);
            this.lsbHermanos.TabIndex = 5;
            // 
            // btnEliminarHermano
            // 
            this.btnEliminarHermano.Location = new System.Drawing.Point(6, 175);
            this.btnEliminarHermano.Name = "btnEliminarHermano";
            this.btnEliminarHermano.Size = new System.Drawing.Size(123, 46);
            this.btnEliminarHermano.TabIndex = 4;
            this.btnEliminarHermano.Text = "Eliminar Hermano";
            this.btnEliminarHermano.UseVisualStyleBackColor = true;
            this.btnEliminarHermano.Click += new System.EventHandler(this.btnEliminarHermano_Click);
            // 
            // btnBuscarHermano
            // 
            this.btnBuscarHermano.Location = new System.Drawing.Point(6, 123);
            this.btnBuscarHermano.Name = "btnBuscarHermano";
            this.btnBuscarHermano.Size = new System.Drawing.Size(123, 46);
            this.btnBuscarHermano.TabIndex = 3;
            this.btnBuscarHermano.Text = "Buscar Hermano";
            this.btnBuscarHermano.UseVisualStyleBackColor = true;
            // 
            // btnEditarInfoHermano
            // 
            this.btnEditarInfoHermano.Location = new System.Drawing.Point(6, 71);
            this.btnEditarInfoHermano.Name = "btnEditarInfoHermano";
            this.btnEditarInfoHermano.Size = new System.Drawing.Size(123, 46);
            this.btnEditarInfoHermano.TabIndex = 2;
            this.btnEditarInfoHermano.Text = "Editar Información de Hermano";
            this.btnEditarInfoHermano.UseVisualStyleBackColor = true;
            this.btnEditarInfoHermano.Click += new System.EventHandler(this.btnEditarInfoHermano_Click);
            // 
            // btnAgregarHermano
            // 
            this.btnAgregarHermano.Location = new System.Drawing.Point(6, 22);
            this.btnAgregarHermano.Name = "btnAgregarHermano";
            this.btnAgregarHermano.Size = new System.Drawing.Size(123, 46);
            this.btnAgregarHermano.TabIndex = 1;
            this.btnAgregarHermano.Text = "Agregar Hermano";
            this.btnAgregarHermano.UseVisualStyleBackColor = true;
            this.btnAgregarHermano.Click += new System.EventHandler(this.btnAgregarHermano_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(552, 49);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // lblNombreCongregacion
            // 
            this.lblNombreCongregacion.AutoSize = true;
            this.lblNombreCongregacion.Location = new System.Drawing.Point(552, 27);
            this.lblNombreCongregacion.Name = "lblNombreCongregacion";
            this.lblNombreCongregacion.Size = new System.Drawing.Size(104, 13);
            this.lblNombreCongregacion.TabIndex = 4;
            this.lblNombreCongregacion.Text = "NombreConregacion";
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 501);
            this.Controls.Add(this.lblNombreCongregacion);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.grbHermanos);
            this.Controls.Add(this.grbAsignacion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioPrincipal";
            this.Text = "AssigManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbAsignacion.ResumeLayout(false);
            this.grbHermanos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hermanientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escuelaToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbAsignacion;
        private System.Windows.Forms.ComboBox cmbOrdenamientoAsignaciones;
        private System.Windows.Forms.ListBox lsbAsignaciones;
        private System.Windows.Forms.Button btnEliminarAsignaciones;
        private System.Windows.Forms.Button btnEditarAsignaciones;
        private System.Windows.Forms.Button btnBuscarAsignaciones;
        private System.Windows.Forms.Button btnAgregarAsignacion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.GroupBox grbHermanos;
        private System.Windows.Forms.Button btnEliminarHermano;
        private System.Windows.Forms.Button btnBuscarHermano;
        private System.Windows.Forms.Button btnEditarInfoHermano;
        private System.Windows.Forms.Button btnAgregarHermano;
        private System.Windows.Forms.ComboBox cmbOrdenamientoHermanos;
        private System.Windows.Forms.ListBox lsbHermanos;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarCambiosToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblNombreCongregacion;
    }
}

