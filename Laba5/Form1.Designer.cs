namespace FractalsAndHermite
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabHermite;
        private System.Windows.Forms.TabPage tabKoch;

        private System.Windows.Forms.PictureBox pictureBoxHermite;
        private System.Windows.Forms.Button btnHermiteStart;

        private System.Windows.Forms.PictureBox pictureBoxKoch;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Button btnDrawKoch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHermite = new System.Windows.Forms.TabPage();
            this.tabKoch = new System.Windows.Forms.TabPage();

            this.pictureBoxHermite = new System.Windows.Forms.PictureBox();
            this.btnHermiteStart = new System.Windows.Forms.Button();

            this.pictureBoxKoch = new System.Windows.Forms.PictureBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.btnDrawKoch = new System.Windows.Forms.Button();

            this.tabControl.SuspendLayout();
            this.tabHermite.SuspendLayout();
            this.tabKoch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHermite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKoch)).BeginInit();
            this.SuspendLayout();

            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHermite);
            this.tabControl.Controls.Add(this.tabKoch);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(820, 720);
            this.tabControl.TabIndex = 0;

            // 
            // tabHermite
            // 
            this.tabHermite.Controls.Add(this.btnHermiteStart);
            this.tabHermite.Controls.Add(this.pictureBoxHermite);
            this.tabHermite.Location = new System.Drawing.Point(4, 24);
            this.tabHermite.Name = "tabHermite";
            this.tabHermite.Padding = new System.Windows.Forms.Padding(3);
            this.tabHermite.Size = new System.Drawing.Size(812, 692);
            this.tabHermite.TabIndex = 0;
            this.tabHermite.Text = "Крива Ерміта";
            this.tabHermite.UseVisualStyleBackColor = true;

            // 
            // pictureBoxHermite
            // 
            this.pictureBoxHermite.Location = new System.Drawing.Point(10, 60);
            this.pictureBoxHermite.Name = "pictureBoxHermite";
            this.pictureBoxHermite.Size = new System.Drawing.Size(760, 600);
            this.pictureBoxHermite.TabIndex = 0;
            this.pictureBoxHermite.TabStop = false;
            this.pictureBoxHermite.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxHermite_Paint);

            // 
            // btnHermiteStart
            // 
            this.btnHermiteStart.Location = new System.Drawing.Point(10, 20);
            this.btnHermiteStart.Name = "btnHermiteStart";
            this.btnHermiteStart.Size = new System.Drawing.Size(200, 30);
            this.btnHermiteStart.TabIndex = 1;
            this.btnHermiteStart.Text = "Почати малювання";
            this.btnHermiteStart.UseVisualStyleBackColor = true;
            this.btnHermiteStart.Click += new System.EventHandler(this.btnHermiteStart_Click);

            // 
            // tabKoch
            // 
            this.tabKoch.Controls.Add(this.txtD);
            this.tabKoch.Controls.Add(this.txtK);
            this.tabKoch.Controls.Add(this.btnDrawKoch);
            this.tabKoch.Controls.Add(this.pictureBoxKoch);
            this.tabKoch.Location = new System.Drawing.Point(4, 24);
            this.tabKoch.Name = "tabKoch";
            this.tabKoch.Padding = new System.Windows.Forms.Padding(3);
            this.tabKoch.Size = new System.Drawing.Size(812, 692);
            this.tabKoch.TabIndex = 1;
            this.tabKoch.Text = "Фрактал Коха";
            this.tabKoch.UseVisualStyleBackColor = true;

            // 
            // pictureBoxKoch
            // 
            this.pictureBoxKoch.Location = new System.Drawing.Point(10, 100);
            this.pictureBoxKoch.Name = "pictureBoxKoch";
            this.pictureBoxKoch.Size = new System.Drawing.Size(760, 580);
            this.pictureBoxKoch.TabIndex = 0;
            this.pictureBoxKoch.TabStop = false;
            this.pictureBoxKoch.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxKoch_Paint);

            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(10, 20);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(100, 23);
            this.txtD.TabIndex = 1;
            this.txtD.Text = "400";

            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(120, 20);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 23);
            this.txtK.TabIndex = 2;
            this.txtK.Text = "3";

            // 
            // btnDrawKoch
            // 
            this.btnDrawKoch.Location = new System.Drawing.Point(230, 20);
            this.btnDrawKoch.Name = "btnDrawKoch";
            this.btnDrawKoch.Size = new System.Drawing.Size(120, 30);
            this.btnDrawKoch.TabIndex = 3;
            this.btnDrawKoch.Text = "Побудувати фрактал";
            this.btnDrawKoch.UseVisualStyleBackColor = true;
            this.btnDrawKoch.Click += new System.EventHandler(this.btnDrawKoch_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(820, 720);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Крива Ерміта та Фрактал Коха";

            this.tabControl.ResumeLayout(false);
            this.tabHermite.ResumeLayout(false);
            this.tabKoch.ResumeLayout(false);
            this.tabKoch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHermite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKoch)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
