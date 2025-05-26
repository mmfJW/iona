namespace WisejPWAWebApplicationExample
{

    partial class InstallAppPanel
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallAppPanel));
            Wisej.Web.JavaScript.ClientEvent clientEvent2 = new Wisej.Web.JavaScript.ClientEvent();
            pictureBox1 = new Wisej.Web.PictureBox();
            label1 = new Wisej.Web.Label();
            buttonInstall = new Wisej.Web.Button();
            buttonClose = new Wisej.Web.Button();
            animation1 = new Wisej.Web.Animation(components);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(22, 117, 242);
            pictureBox1.CssStyle = "border-radius:5px";
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(13, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(40, 40);
            pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            label1.Location = new System.Drawing.Point(59, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(133, 15);
            label1.TabIndex = 1;
            label1.Text = "Test PWA App";
            // 
            // buttonInstall
            // 
            buttonInstall.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            clientEvent2.Event = "execute";
            clientEvent2.JavaScript = "Wisej.showPWAPrompt()";
            buttonInstall.ClientEvents.Add(clientEvent2);
            buttonInstall.CssStyle = "border-radius:5px";
            buttonInstall.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            buttonInstall.ForeColor = System.Drawing.Color.White;
            buttonInstall.Location = new System.Drawing.Point(198, 11);
            buttonInstall.Name = "buttonInstall";
            buttonInstall.Size = new System.Drawing.Size(75, 35);
            buttonInstall.TabIndex = 2;
            buttonInstall.Text = "Install";
            buttonInstall.Click += new System.EventHandler(buttonInstall_Click);
            // 
            // buttonClose
            // 
            buttonClose.BackColor = System.Drawing.Color.Transparent;
            buttonClose.BorderStyle = Wisej.Web.BorderStyle.None;
            buttonClose.Display = Wisej.Web.Display.Icon;
            buttonClose.ForeColor = System.Drawing.Color.White;
            buttonClose.ImageSource = "window-close";
            buttonClose.Location = new System.Drawing.Point(292, 16);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new System.Drawing.Size(24, 24);
            buttonClose.TabIndex = 3;
            buttonClose.Text = "Close";
            buttonClose.Click += new System.EventHandler(buttonClose_Click);
            // 
            // InstallAppPanel
            // 
            Anchor = Wisej.Web.AnchorStyles.Bottom;
            animation1.GetAnimation(this).Event = "appear";
            animation1.GetAnimation(this).Name = "slideUpIn";
            BackColor = System.Drawing.Color.Black;
            Controls.Add(buttonClose);
            Controls.Add(buttonInstall);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            CssStyle = "border-radius:10px";
            ForeColor = System.Drawing.Color.White;
            Name = "InstallAppPanel";
            Size = new System.Drawing.Size(332, 56);
            Load += new System.EventHandler(InstallAppPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.Label label1;
        private Wisej.Web.Button buttonInstall;
        private Wisej.Web.Button buttonClose;
        private Wisej.Web.Animation animation1;
    }
}
