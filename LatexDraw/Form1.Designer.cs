namespace LatexDraw
{
    partial class LatexDraw
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
            this.CreateBtn = new System.Windows.Forms.Button();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.PathLbl = new System.Windows.Forms.Label();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(512, 38);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(100, 28);
            this.CreateBtn.TabIndex = 0;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(512, 6);
            this.BrowseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(100, 28);
            this.BrowseBtn.TabIndex = 1;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // PathLbl
            // 
            this.PathLbl.AutoSize = true;
            this.PathLbl.Location = new System.Drawing.Point(16, 11);
            this.PathLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PathLbl.Name = "PathLbl";
            this.PathLbl.Size = new System.Drawing.Size(37, 17);
            this.PathLbl.TabIndex = 2;
            this.PathLbl.Text = "Path";
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(63, 7);
            this.PathBox.Margin = new System.Windows.Forms.Padding(4);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(440, 22);
            this.PathBox.TabIndex = 3;
            this.PathBox.TextChanged += new System.EventHandler(this.PathBox_TextChanged);
            this.PathBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LatexDraw_KeyPress);
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(16, 106);
            this.StatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(0, 17);
            this.StatusLbl.TabIndex = 4;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(63, 39);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(440, 22);
            this.NameBox.TabIndex = 6;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LatexDraw_KeyPress);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(16, 43);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(45, 17);
            this.NameLbl.TabIndex = 5;
            this.NameLbl.Text = "Name";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Location = new System.Drawing.Point(16, 74);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(35, 17);
            this.TitleLbl.TabIndex = 7;
            this.TitleLbl.Text = "Title";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(63, 69);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(4);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(440, 22);
            this.TitleBox.TabIndex = 8;
            this.TitleBox.TextChanged += new System.EventHandler(this.TitleBox_TextChanged);
            this.TitleBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LatexDraw_KeyPress);
            // 
            // LatexDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 132);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.PathLbl);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.CreateBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LatexDraw";
            this.ShowIcon = false;
            this.Text = "LatexDraw";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LatexDraw_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Label PathLbl;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.TextBox TitleBox;
    }
}

