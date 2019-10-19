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
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hermanientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarNombreDeCongregacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbAsignacion = new System.Windows.Forms.GroupBox();
            this.btnVolverAHoy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbOrdenamientoAsignaciones = new System.Windows.Forms.ComboBox();
            this.lsbAsignaciones = new System.Windows.Forms.ListBox();
            this.btnEliminarAsignaciones = new System.Windows.Forms.Button();
            this.btnEditarAsignaciones = new System.Windows.Forms.Button();
            this.btnBuscarAsignaciones = new System.Windows.Forms.Button();
            this.btnAgregarAsignacion = new System.Windows.Forms.Button();
            this.grbHermanos = new System.Windows.Forms.GroupBox();
            this.cmbOrdenamientoHermanos = new System.Windows.Forms.ComboBox();
            this.lsbHermanos = new System.Windows.Forms.ListBox();
            this.btnEliminarHermano = new System.Windows.Forms.Button();
            this.btnBuscarHermano = new System.Windows.Forms.Button();
            this.btnEditarInfoHermano = new System.Windows.Forms.Button();
            this.btnAgregarHermano = new System.Windows.Forms.Button();
            this.btnAsignacionesHermanoEspecifico = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escuelaToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // hermanientasToolStripMenuItem
            // 
            this.hermanientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarNombreDeCongregacionToolStripMenuItem});
            this.hermanientasToolStripMenuItem.Name = "hermanientasToolStripMenuItem";
            this.hermanientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.hermanientasToolStripMenuItem.Text = "Herramientas";
            // 
            // cambiarNombreDeCongregacionToolStripMenuItem
            // 
            this.cambiarNombreDeCongregacionToolStripMenuItem.Name = "cambiarNombreDeCongregacionToolStripMenuItem";
            this.cambiarNombreDeCongregacionToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.cambiarNombreDeCongregacionToolStripMenuItem.Text = "Cambiar Nombre de Congregacion";
            this.cambiarNombreDeCongregacionToolStripMenuItem.Click += new System.EventHandler(this.cambiarNombreDeCongregacionToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // grbAsignacion
            // 
            this.grbAsignacion.Controls.Add(this.btnAsignacionesHermanoEspecifico);
            this.grbAsignacion.Controls.Add(this.btnVolverAHoy);
            this.grbAsignacion.Controls.Add(this.label3);
            this.grbAsignacion.Controls.Add(this.label2);
            this.grbAsignacion.Controls.Add(this.label1);
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
            this.grbAsignacion.Size = new System.Drawing.Size(872, 280);
            this.grbAsignacion.TabIndex = 1;
            this.grbAsignacion.TabStop = false;
            this.grbAsignacion.Text = "Asignacion";
            // 
            // btnVolverAHoy
            // 
            this.btnVolverAHoy.Location = new System.Drawing.Point(742, 226);
            this.btnVolverAHoy.Name = "btnVolverAHoy";
            this.btnVolverAHoy.Size = new System.Drawing.Size(123, 46);
            this.btnVolverAHoy.TabIndex = 11;
            this.btnVolverAHoy.Text = "Volver a Hoy";
            this.btnVolverAHoy.UseVisualStyleBackColor = true;
            this.btnVolverAHoy.Click += new System.EventHandler(this.btnVolverAHoy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(740, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(740, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ordenar Por";
            // 
            // cmbAño
            // 
            this.cmbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(742, 117);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(124, 21);
            this.cmbAño.TabIndex = 7;
            this.cmbAño.SelectedIndexChanged += new System.EventHandler(this.cmbAño_SelectedIndexChanged);
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(742, 77);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(124, 21);
            this.cmbMes.TabIndex = 6;
            this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.cmbMes_SelectedIndexChanged);
            // 
            // cmbOrdenamientoAsignaciones
            // 
            this.cmbOrdenamientoAsignaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenamientoAsignaciones.FormattingEnabled = true;
            this.cmbOrdenamientoAsignaciones.Location = new System.Drawing.Point(742, 37);
            this.cmbOrdenamientoAsignaciones.Name = "cmbOrdenamientoAsignaciones";
            this.cmbOrdenamientoAsignaciones.Size = new System.Drawing.Size(124, 21);
            this.cmbOrdenamientoAsignaciones.TabIndex = 5;
            this.cmbOrdenamientoAsignaciones.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenamientoAsignaciones_SelectedIndexChanged);
            // 
            // lsbAsignaciones
            // 
            this.lsbAsignaciones.FormattingEnabled = true;
            this.lsbAsignaciones.HorizontalScrollbar = true;
            this.lsbAsignaciones.Location = new System.Drawing.Point(135, 21);
            this.lsbAsignaciones.Name = "lsbAsignaciones";
            this.lsbAsignaciones.Size = new System.Drawing.Size(601, 251);
            this.lsbAsignaciones.TabIndex = 4;
            // 
            // btnEliminarAsignaciones
            // 
            this.btnEliminarAsignaciones.Location = new System.Drawing.Point(6, 226);
            this.btnEliminarAsignaciones.Name = "btnEliminarAsignaciones";
            this.btnEliminarAsignaciones.Size = new System.Drawing.Size(123, 46);
            this.btnEliminarAsignaciones.TabIndex = 3;
            this.btnEliminarAsignaciones.Text = "Eliminar Asignación";
            this.btnEliminarAsignaciones.UseVisualStyleBackColor = true;
            this.btnEliminarAsignaciones.Click += new System.EventHandler(this.btnEliminarAsignaciones_Click);
            // 
            // btnEditarAsignaciones
            // 
            this.btnEditarAsignaciones.Location = new System.Drawing.Point(6, 71);
            this.btnEditarAsignaciones.Name = "btnEditarAsignaciones";
            this.btnEditarAsignaciones.Size = new System.Drawing.Size(123, 46);
            this.btnEditarAsignaciones.TabIndex = 2;
            this.btnEditarAsignaciones.Text = "Editar Asignación";
            this.btnEditarAsignaciones.UseVisualStyleBackColor = true;
            this.btnEditarAsignaciones.Click += new System.EventHandler(this.btnEditarAsignaciones_Click);
            // 
            // btnBuscarAsignaciones
            // 
            this.btnBuscarAsignaciones.Location = new System.Drawing.Point(6, 123);
            this.btnBuscarAsignaciones.Name = "btnBuscarAsignaciones";
            this.btnBuscarAsignaciones.Size = new System.Drawing.Size(123, 46);
            this.btnBuscarAsignaciones.TabIndex = 1;
            this.btnBuscarAsignaciones.Text = "Buscar Asignación";
            this.btnBuscarAsignaciones.UseVisualStyleBackColor = true;
            this.btnBuscarAsignaciones.Click += new System.EventHandler(this.btnBuscarAsignaciones_Click);
            // 
            // btnAgregarAsignacion
            // 
            this.btnAgregarAsignacion.Location = new System.Drawing.Point(6, 19);
            this.btnAgregarAsignacion.Name = "btnAgregarAsignacion";
            this.btnAgregarAsignacion.Size = new System.Drawing.Size(123, 46);
            this.btnAgregarAsignacion.TabIndex = 0;
            this.btnAgregarAsignacion.Text = "Crear  Asignación";
            this.btnAgregarAsignacion.UseVisualStyleBackColor = true;
            this.btnAgregarAsignacion.Click += new System.EventHandler(this.btnAgregarAsignacion_Click);
            // 
            // grbHermanos
            // 
            this.grbHermanos.Controls.Add(this.cmbOrdenamientoHermanos);
            this.grbHermanos.Controls.Add(this.lsbHermanos);
            this.grbHermanos.Controls.Add(this.btnEliminarHermano);
            this.grbHermanos.Controls.Add(this.btnBuscarHermano);
            this.grbHermanos.Controls.Add(this.btnEditarInfoHermano);
            this.grbHermanos.Controls.Add(this.btnAgregarHermano);
            this.grbHermanos.Location = new System.Drawing.Point(12, 313);
            this.grbHermanos.Name = "grbHermanos";
            this.grbHermanos.Size = new System.Drawing.Size(872, 229);
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
            this.cmbOrdenamientoHermanos.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenamientoHermanos_SelectedIndexChanged);
            // 
            // lsbHermanos
            // 
            this.lsbHermanos.FormattingEnabled = true;
            this.lsbHermanos.Location = new System.Drawing.Point(135, 22);
            this.lsbHermanos.Name = "lsbHermanos";
            this.lsbHermanos.ScrollAlwaysVisible = true;
            this.lsbHermanos.Size = new System.Drawing.Size(730, 173);
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
            this.btnBuscarHermano.Click += new System.EventHandler(this.btnBuscarHermano_Click);
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
            // btnAsignacionesHermanoEspecifico
            // 
            this.btnAsignacionesHermanoEspecifico.Location = new System.Drawing.Point(6, 175);
            this.btnAsignacionesHermanoEspecifico.Name = "btnAsignacionesHermanoEspecifico";
            this.btnAsignacionesHermanoEspecifico.Size = new System.Drawing.Size(123, 46);
            this.btnAsignacionesHermanoEspecifico.TabIndex = 12;
            this.btnAsignacionesHermanoEspecifico.Text = "Asignaciones de Hermano Especifico";
            this.btnAsignacionesHermanoEspecifico.UseVisualStyleBackColor = true;
            this.btnAsignacionesHermanoEspecifico.Click += new System.EventHandler(this.btnAsignacionesHermanoEspecifico_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 587);
            this.Controls.Add(this.grbHermanos);
            this.Controls.Add(this.grbAsignacion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioPrincipal";
            this.Text = "AssigManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbAsignacion.ResumeLayout(false);
            this.grbAsignacion.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem cambiarNombreDeCongregacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.Button btnVolverAHoy;
        private System.Windows.Forms.Button btnAsignacionesHermanoEspecifico;
    }
}

