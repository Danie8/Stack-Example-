namespace Indices
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lstbNombres = new System.Windows.Forms.ListBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctmenuOpcLista = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moverAntesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moverDespuésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmenuOpcLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbNombres
            // 
            this.lstbNombres.FormattingEnabled = true;
            this.lstbNombres.Location = new System.Drawing.Point(12, 30);
            this.lstbNombres.Name = "lstbNombres";
            this.lstbNombres.Size = new System.Drawing.Size(191, 160);
            this.lstbNombres.TabIndex = 0;
            this.lstbNombres.SelectedIndexChanged += new System.EventHandler(this.lstbNombres_SelectedIndexChanged);
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(103, 4);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(100, 20);
            this.txtbNombre.TabIndex = 1;
            this.txtbNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbNombre_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres";
            // 
            // ctmenuOpcLista
            // 
            this.ctmenuOpcLista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.organizarToolStripMenuItem,
            this.pegarToolStripMenuItem});
            this.ctmenuOpcLista.Name = "ctmenuOpcLista";
            this.ctmenuOpcLista.Size = new System.Drawing.Size(181, 114);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // organizarToolStripMenuItem
            // 
            this.organizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moverAntesToolStripMenuItem,
            this.moverDespuésToolStripMenuItem});
            this.organizarToolStripMenuItem.Name = "organizarToolStripMenuItem";
            this.organizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.organizarToolStripMenuItem.Text = "Organizar";
            // 
            // moverAntesToolStripMenuItem
            // 
            this.moverAntesToolStripMenuItem.Name = "moverAntesToolStripMenuItem";
            this.moverAntesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moverAntesToolStripMenuItem.Text = "Mover Antes";
            this.moverAntesToolStripMenuItem.Click += new System.EventHandler(this.moverAntesToolStripMenuItem_Click);
            // 
            // moverDespuésToolStripMenuItem
            // 
            this.moverDespuésToolStripMenuItem.Name = "moverDespuésToolStripMenuItem";
            this.moverDespuésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moverDespuésToolStripMenuItem.Text = "Mover Después";
            this.moverDespuésToolStripMenuItem.Click += new System.EventHandler(this.moverDespuésToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 201);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lstbNombres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ctmenuOpcLista.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbNombres;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip ctmenuOpcLista;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moverAntesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moverDespuésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
    }
}

