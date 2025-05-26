namespace Iona
{
    partial class Page1
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

        #region Wisej.NET Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Wisej.Resources.ComponentResourceManager resources = new Wisej.Resources.ComponentResourceManager(typeof(Page1));
            panel1 = new Wisej.Web.Panel();
            pictureBox1 = new Wisej.Web.PictureBox();
            label2 = new Wisej.Web.Label();
            button1 = new Wisej.Web.Button();
            label1 = new Wisej.Web.Label();
            button2 = new Wisej.Web.Button();
            flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Orange;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Cursor = null;
            panel1.Dock = Wisej.Web.DockStyle.Top;
            panel1.ForeColor = System.Drawing.Color.White;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(2482, 50);
            panel1.TabIndex = 1;
            panel1.TabStop = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right;
            pictureBox1.CssStyle = "border-radius:40px";
            pictureBox1.ImageSource = "https://www.gravatar.com/avatar/?d=identicon";
            pictureBox1.Location = new System.Drawing.Point(2429, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(40, 40);
            pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(67, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 18);
            label2.TabIndex = 1;
            label2.Text = "PWA Test App";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.BorderStyle = Wisej.Web.BorderStyle.None;
            button1.Display = Wisej.Web.Display.Icon;
            button1.ForeColor = System.Drawing.Color.White;
            button1.ImageSource = "menu-overflow";
            button1.Location = new System.Drawing.Point(3, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(39, 44);
            button1.TabIndex = 0;
            button1.Text = "button1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CssStyle = "line-height:24px";
            label1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            label1.Location = new System.Drawing.Point(43, 43);
            label1.Name = "label1";
            label1.Padding = new Wisej.Web.Padding(0, 0, 0, 30);
            label1.Size = new System.Drawing.Size(2391, 73);
            label1.TabIndex = 2;
            label1.Text = resources.GetString("label1.Text");
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(232, 236, 239);
            button2.BorderStyle = Wisej.Web.BorderStyle.None;
            button2.CssStyle = "border-radius:5px";
            button2.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            button2.ForeColor = System.Drawing.Color.FromArgb(22, 117, 242);
            button2.ImageSource = "icon-right";
            button2.Location = new System.Drawing.Point(43, 149);
            button2.Margin = new Wisej.Web.Padding(3, 30, 3, 3);
            button2.Name = "button2";
            button2.Padding = new Wisej.Web.Padding(0, 0, 10, 0);
            button2.Size = new System.Drawing.Size(182, 36);
            button2.TabIndex = 3;
            button2.Text = "Read about PWA apps";
            button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Cursor = null;
            flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Wisej.Web.Padding(40);
            flowLayoutPanel1.Size = new System.Drawing.Size(2482, 1107);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.TabStop = true;
            // 
            // Page1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "Page1";
            Size = new System.Drawing.Size(2482, 1157);
            Text = "Page1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.Label label2;
        private Wisej.Web.Button button1;
        private Wisej.Web.Label label1;
        private Wisej.Web.Button button2;
        private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
    }
}
