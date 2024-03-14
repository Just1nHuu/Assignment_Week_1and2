namespace file_explorer
{
    partial class Form2
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
            this.btnforward = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnback = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnforward
            // 
            this.btnforward.Location = new System.Drawing.Point(56, 12);
            this.btnforward.Name = "btnforward";
            this.btnforward.Size = new System.Drawing.Size(50, 23);
            this.btnforward.TabIndex = 1;
            this.btnforward.Text = ">>";
            this.btnforward.UseVisualStyleBackColor = true;
            this.btnforward.Click += new System.EventHandler(this.btnforward_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(114, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 41);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(555, 437);
            this.webBrowser1.TabIndex = 5;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(0, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(50, 23);
            this.btnback.TabIndex = 6;
            this.btnback.Text = "<<";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(150, 12);
            this.txtpath.Name = "txtpath";
            this.txtpath.ReadOnly = true;
            this.txtpath.Size = new System.Drawing.Size(331, 22);
            this.txtpath.TabIndex = 7;
            this.txtpath.TextChanged += new System.EventHandler(this.txtpath_TextChanged);
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(487, 11);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 23);
            this.btnopen.TabIndex = 8;
            this.btnopen.Text = "open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(567, 490);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnforward);
            this.Name = "Form2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnforward;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Button btnopen;
    }
}

