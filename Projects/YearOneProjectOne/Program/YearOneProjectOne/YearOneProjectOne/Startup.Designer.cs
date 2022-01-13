
namespace YearOneProjectOne
{
    partial class Startup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.WMPStartup = new AxWMPLib.AxWindowsMediaPlayer();
            this.BTNLogIn = new System.Windows.Forms.Button();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.WMPScreensaver = new AxWMPLib.AxWindowsMediaPlayer();
            this.mainDatabase1 = new YearOneProjectOne.MainDatabase();
            this.TBDebug = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.WMPStartup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPScreensaver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabase1)).BeginInit();
            this.SuspendLayout();
            // 
            // WMPStartup
            // 
            this.WMPStartup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WMPStartup.Enabled = true;
            this.WMPStartup.Location = new System.Drawing.Point(0, 0);
            this.WMPStartup.Name = "WMPStartup";
            this.WMPStartup.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPStartup.OcxState")));
            this.WMPStartup.Size = new System.Drawing.Size(800, 450);
            this.WMPStartup.TabIndex = 1;
            this.WMPStartup.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.WMPStartup.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // BTNLogIn
            // 
            this.BTNLogIn.Location = new System.Drawing.Point(360, 415);
            this.BTNLogIn.Name = "BTNLogIn";
            this.BTNLogIn.Size = new System.Drawing.Size(75, 23);
            this.BTNLogIn.TabIndex = 2;
            this.BTNLogIn.Text = "Log In";
            this.BTNLogIn.UseVisualStyleBackColor = true;
            this.BTNLogIn.Click += new System.EventHandler(this.BTNLogIn_Click);
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(346, 389);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 3;
            this.TBPassword.Text = "Password";
            this.TBPassword.UseSystemPasswordChar = true;
            this.TBPassword.Click += new System.EventHandler(this.TBPassword_Click);
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(346, 363);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(100, 20);
            this.TBUsername.TabIndex = 4;
            this.TBUsername.Text = "Username";
            this.TBUsername.Click += new System.EventHandler(this.TBUsername_Click);
            // 
            // WMPScreensaver
            // 
            this.WMPScreensaver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WMPScreensaver.Enabled = true;
            this.WMPScreensaver.Location = new System.Drawing.Point(0, 0);
            this.WMPScreensaver.Name = "WMPScreensaver";
            this.WMPScreensaver.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPScreensaver.OcxState")));
            this.WMPScreensaver.Size = new System.Drawing.Size(800, 450);
            this.WMPScreensaver.TabIndex = 7;
            this.WMPScreensaver.Visible = false;
            // 
            // mainDatabase1
            // 
            this.mainDatabase1.DataSetName = "MainDatabase";
            this.mainDatabase1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBDebug
            // 
            this.TBDebug.Location = new System.Drawing.Point(665, 363);
            this.TBDebug.Name = "TBDebug";
            this.TBDebug.Size = new System.Drawing.Size(100, 20);
            this.TBDebug.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TBDebug);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.BTNLogIn);
            this.Controls.Add(this.WMPScreensaver);
            this.Controls.Add(this.WMPStartup);
            this.Name = "Startup";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WMPStartup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPScreensaver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabase1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxWMPLib.AxWindowsMediaPlayer WMPStartup;
        private System.Windows.Forms.Button BTNLogIn;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBUsername;
        private AxWMPLib.AxWindowsMediaPlayer WMPScreensaver;
        private MainDatabase mainDatabase1;
        private System.Windows.Forms.TextBox TBDebug;
        private System.Windows.Forms.TextBox textBox1;
    }
}

