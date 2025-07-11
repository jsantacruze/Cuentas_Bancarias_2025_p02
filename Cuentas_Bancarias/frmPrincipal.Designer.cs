namespace Cuentas_Bancarias
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeClienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasDeAhorroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasCorrientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetasDeCréditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personasToolStripMenuItem,
            this.cuentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1208, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDePersonasToolStripMenuItem,
            this.listaDeClienToolStripMenuItem,
            this.listaDeEmpleadosToolStripMenuItem});
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.personasToolStripMenuItem.Text = "PERSONAS";
            // 
            // listaDePersonasToolStripMenuItem
            // 
            this.listaDePersonasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listaDePersonasToolStripMenuItem.Image")));
            this.listaDePersonasToolStripMenuItem.Name = "listaDePersonasToolStripMenuItem";
            this.listaDePersonasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.listaDePersonasToolStripMenuItem.Text = "Lista de Personas";
            this.listaDePersonasToolStripMenuItem.Click += new System.EventHandler(this.listaDePersonasToolStripMenuItem_Click);
            // 
            // listaDeClienToolStripMenuItem
            // 
            this.listaDeClienToolStripMenuItem.Name = "listaDeClienToolStripMenuItem";
            this.listaDeClienToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.listaDeClienToolStripMenuItem.Text = "Lista de Clientes";
            // 
            // listaDeEmpleadosToolStripMenuItem
            // 
            this.listaDeEmpleadosToolStripMenuItem.Name = "listaDeEmpleadosToolStripMenuItem";
            this.listaDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.listaDeEmpleadosToolStripMenuItem.Text = "Lista de E,mpleados";
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasDeAhorroToolStripMenuItem,
            this.cuentasCorrientesToolStripMenuItem,
            this.tarjetasDeCréditoToolStripMenuItem});
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.cuentasToolStripMenuItem.Text = "CUENTAS";
            // 
            // cuentasDeAhorroToolStripMenuItem
            // 
            this.cuentasDeAhorroToolStripMenuItem.Name = "cuentasDeAhorroToolStripMenuItem";
            this.cuentasDeAhorroToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cuentasDeAhorroToolStripMenuItem.Text = "Cuentas de Ahorro";
            // 
            // cuentasCorrientesToolStripMenuItem
            // 
            this.cuentasCorrientesToolStripMenuItem.Name = "cuentasCorrientesToolStripMenuItem";
            this.cuentasCorrientesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cuentasCorrientesToolStripMenuItem.Text = "Cuentas Corrientes";
            // 
            // tarjetasDeCréditoToolStripMenuItem
            // 
            this.tarjetasDeCréditoToolStripMenuItem.Name = "tarjetasDeCréditoToolStripMenuItem";
            this.tarjetasDeCréditoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.tarjetasDeCréditoToolStripMenuItem.Text = "Tarjetas de Crédito";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 617);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Gestión Financiera";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDePersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeClienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasDeAhorroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasCorrientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarjetasDeCréditoToolStripMenuItem;
    }
}