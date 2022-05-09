namespace ArduinoTemperatura_G2_2022_II
{
    partial class FormTemperatura
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pararToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTemperatura = new System.Windows.Forms.DataGridView();
            this.ColumnTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTemperatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timerTemperatura = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemperatura)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.controlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2027, 61);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(168, 57);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(166, 57);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem1,
            this.pararToolStripMenuItem});
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.iniciarToolStripMenuItem.Text = "Simular";
            // 
            // iniciarToolStripMenuItem1
            // 
            this.iniciarToolStripMenuItem1.Name = "iniciarToolStripMenuItem1";
            this.iniciarToolStripMenuItem1.Size = new System.Drawing.Size(538, 66);
            this.iniciarToolStripMenuItem1.Text = "Iniciar";
            this.iniciarToolStripMenuItem1.Click += new System.EventHandler(this.iniciarToolStripMenuItem1_Click);
            // 
            // pararToolStripMenuItem
            // 
            this.pararToolStripMenuItem.Name = "pararToolStripMenuItem";
            this.pararToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.pararToolStripMenuItem.Text = "Parar";
            this.pararToolStripMenuItem.Click += new System.EventHandler(this.pararToolStripMenuItem_Click);
            // 
            // dgvTemperatura
            // 
            this.dgvTemperatura.AllowUserToAddRows = false;
            this.dgvTemperatura.AllowUserToDeleteRows = false;
            this.dgvTemperatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemperatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTiempo,
            this.ColumnTemperatura});
            this.dgvTemperatura.Location = new System.Drawing.Point(50, 119);
            this.dgvTemperatura.Name = "dgvTemperatura";
            this.dgvTemperatura.ReadOnly = true;
            this.dgvTemperatura.RowHeadersWidth = 123;
            this.dgvTemperatura.RowTemplate.Height = 57;
            this.dgvTemperatura.Size = new System.Drawing.Size(763, 813);
            this.dgvTemperatura.TabIndex = 1;
            // 
            // ColumnTiempo
            // 
            this.ColumnTiempo.Frozen = true;
            this.ColumnTiempo.HeaderText = "Tiempo";
            this.ColumnTiempo.MinimumWidth = 15;
            this.ColumnTiempo.Name = "ColumnTiempo";
            this.ColumnTiempo.ReadOnly = true;
            this.ColumnTiempo.Width = 300;
            // 
            // ColumnTemperatura
            // 
            this.ColumnTemperatura.Frozen = true;
            this.ColumnTemperatura.HeaderText = "Temperatura";
            this.ColumnTemperatura.MinimumWidth = 15;
            this.ColumnTemperatura.Name = "ColumnTemperatura";
            this.ColumnTemperatura.ReadOnly = true;
            this.ColumnTemperatura.Width = 300;
            // 
            // timerTemperatura
            // 
            this.timerTemperatura.Tick += new System.EventHandler(this.timerTemperatura_Tick);
            // 
            // FormTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2027, 968);
            this.Controls.Add(this.dgvTemperatura);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTemperatura";
            this.Text = "Temperatura";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemperatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem controlToolStripMenuItem;
        private ToolStripMenuItem iniciarToolStripMenuItem;
        private ToolStripMenuItem iniciarToolStripMenuItem1;
        private ToolStripMenuItem pararToolStripMenuItem;
        private DataGridView dgvTemperatura;
        private DataGridViewTextBoxColumn ColumnTiempo;
        private DataGridViewTextBoxColumn ColumnTemperatura;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timerTemperatura;
    }
}