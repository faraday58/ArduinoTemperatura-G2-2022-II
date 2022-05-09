namespace ArduinoTemperatura_G2_2022_II
{
    partial class FormContenedor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.velocidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.verificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebaLEDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semáforoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem,
            this.aplicacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2523, 61);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puertosToolStripMenuItem,
            this.velocidadToolStripMenuItem,
            this.toolStripMenuItem1,
            this.verificarToolStripMenuItem,
            this.conectarToolStripMenuItem,
            this.desconectatToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(280, 52);
            this.configuraciónToolStripMenuItem.Text = "Configuración ";
            // 
            // aplicacionesToolStripMenuItem
            // 
            this.aplicacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pruebaLEDToolStripMenuItem,
            this.temperaturaToolStripMenuItem,
            this.semáforoToolStripMenuItem});
            this.aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            this.aplicacionesToolStripMenuItem.Size = new System.Drawing.Size(246, 57);
            this.aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // puertosToolStripMenuItem
            // 
            this.puertosToolStripMenuItem.Name = "puertosToolStripMenuItem";
            this.puertosToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.puertosToolStripMenuItem.Text = "Puertos";
            // 
            // velocidadToolStripMenuItem
            // 
            this.velocidadToolStripMenuItem.Name = "velocidadToolStripMenuItem";
            this.velocidadToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.velocidadToolStripMenuItem.Text = "Velocidad";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(535, 6);
            // 
            // verificarToolStripMenuItem
            // 
            this.verificarToolStripMenuItem.Name = "verificarToolStripMenuItem";
            this.verificarToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.verificarToolStripMenuItem.Text = "Verificar";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.conectarToolStripMenuItem.Text = "Conectar";
            // 
            // desconectatToolStripMenuItem
            // 
            this.desconectatToolStripMenuItem.Name = "desconectatToolStripMenuItem";
            this.desconectatToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.desconectatToolStripMenuItem.Text = "Desconectar";
            // 
            // pruebaLEDToolStripMenuItem
            // 
            this.pruebaLEDToolStripMenuItem.Name = "pruebaLEDToolStripMenuItem";
            this.pruebaLEDToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.pruebaLEDToolStripMenuItem.Text = "Prueba LED";
            // 
            // temperaturaToolStripMenuItem
            // 
            this.temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
            this.temperaturaToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.temperaturaToolStripMenuItem.Text = "Temperatura";
            this.temperaturaToolStripMenuItem.Click += new System.EventHandler(this.temperaturaToolStripMenuItem_Click);
            // 
            // semáforoToolStripMenuItem
            // 
            this.semáforoToolStripMenuItem.Name = "semáforoToolStripMenuItem";
            this.semáforoToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.semáforoToolStripMenuItem.Text = "Semáforo";
            // 
            // FormContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2523, 997);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormContenedor";
            this.Text = "Contenedor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private ToolStripMenuItem puertosToolStripMenuItem;
        private ToolStripMenuItem velocidadToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem verificarToolStripMenuItem;
        private ToolStripMenuItem conectarToolStripMenuItem;
        private ToolStripMenuItem desconectatToolStripMenuItem;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem pruebaLEDToolStripMenuItem;
        private ToolStripMenuItem temperaturaToolStripMenuItem;
        private ToolStripMenuItem semáforoToolStripMenuItem;
    }
}