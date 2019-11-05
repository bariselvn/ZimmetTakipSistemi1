namespace ZimmetTakipSistemi
{
    partial class LİST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LİST));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bgeri = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bgeri);
            this.bunifuGradientPanel1.Controls.Add(this.dataGridView);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-1, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(758, 330);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // bgeri
            // 
            this.bgeri.ActiveBorderThickness = 1;
            this.bgeri.ActiveCornerRadius = 20;
            this.bgeri.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bgeri.ActiveForecolor = System.Drawing.Color.White;
            this.bgeri.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bgeri.BackColor = System.Drawing.SystemColors.Control;
            this.bgeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bgeri.BackgroundImage")));
            this.bgeri.ButtonText = "GERİ";
            this.bgeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bgeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgeri.ForeColor = System.Drawing.Color.SeaGreen;
            this.bgeri.IdleBorderThickness = 1;
            this.bgeri.IdleCornerRadius = 20;
            this.bgeri.IdleFillColor = System.Drawing.Color.White;
            this.bgeri.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bgeri.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bgeri.Location = new System.Drawing.Point(47, 272);
            this.bgeri.Margin = new System.Windows.Forms.Padding(5);
            this.bgeri.Name = "bgeri";
            this.bgeri.Size = new System.Drawing.Size(101, 43);
            this.bgeri.TabIndex = 1;
            this.bgeri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bgeri.Click += new System.EventHandler(this.bgeri_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(65, 36);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(629, 218);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LİST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 329);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LİST";
            this.Text = "LİST";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bgeri;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}