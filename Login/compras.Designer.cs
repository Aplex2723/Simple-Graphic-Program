namespace Login
{
    partial class compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compras));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureCompras = new System.Windows.Forms.PictureBox();
            this.dataClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(428, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compras";
            // 
            // pictureCompras
            // 
            this.pictureCompras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureCompras.Image = ((System.Drawing.Image)(resources.GetObject("pictureCompras.Image")));
            this.pictureCompras.Location = new System.Drawing.Point(392, 8);
            this.pictureCompras.Name = "pictureCompras";
            this.pictureCompras.Size = new System.Drawing.Size(41, 37);
            this.pictureCompras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCompras.TabIndex = 13;
            this.pictureCompras.TabStop = false;
            // 
            // dataClientes
            // 
            this.dataClientes.AllowUserToAddRows = false;
            this.dataClientes.AllowUserToDeleteRows = false;
            this.dataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientes.Location = new System.Drawing.Point(12, 68);
            this.dataClientes.Name = "dataClientes";
            this.dataClientes.ReadOnly = true;
            this.dataClientes.Size = new System.Drawing.Size(974, 456);
            this.dataClientes.TabIndex = 14;
            this.dataClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataClientes_CellContentClick);
            // 
            // compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(998, 536);
            this.Controls.Add(this.dataClientes);
            this.Controls.Add(this.pictureCompras);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "compras";
            this.Load += new System.EventHandler(this.compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureCompras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataClientes;
    }
}