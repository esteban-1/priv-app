namespace @private
{
    partial class formprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formprincipal));
            this.panel = new System.Windows.Forms.Panel();
            this.panellog = new System.Windows.Forms.Panel();
            this.imglogo = new System.Windows.Forms.PictureBox();
            this.btnhome = new FontAwesome.Sharp.IconButton();
            this.btnrestore = new FontAwesome.Sharp.IconButton();
            this.btnothers = new FontAwesome.Sharp.IconButton();
            this.btnfot = new FontAwesome.Sharp.IconButton();
            this.btnsettings = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.panellog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imglogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(47)))));
            this.panel.Controls.Add(this.btnsettings);
            this.panel.Controls.Add(this.btnfot);
            this.panel.Controls.Add(this.btnothers);
            this.panel.Controls.Add(this.btnrestore);
            this.panel.Controls.Add(this.btnhome);
            this.panel.Controls.Add(this.panellog);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(233, 476);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panellog
            // 
            this.panellog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(47)))));
            this.panellog.Controls.Add(this.imglogo);
            this.panellog.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellog.Location = new System.Drawing.Point(0, 0);
            this.panellog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panellog.Name = "panellog";
            this.panellog.Size = new System.Drawing.Size(233, 123);
            this.panellog.TabIndex = 0;
            this.panellog.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // imglogo
            // 
            this.imglogo.Image = ((System.Drawing.Image)(resources.GetObject("imglogo.Image")));
            this.imglogo.Location = new System.Drawing.Point(-3, 21);
            this.imglogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imglogo.Name = "imglogo";
            this.imglogo.Size = new System.Drawing.Size(237, 63);
            this.imglogo.TabIndex = 0;
            this.imglogo.TabStop = false;
            this.imglogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(47)))));
            this.btnhome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnhome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnhome.IconChar = FontAwesome.Sharp.IconChar.FeatherAlt;
            this.btnhome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnhome.IconSize = 36;
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(0, 123);
            this.btnhome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnhome.Name = "btnhome";
            this.btnhome.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnhome.Rotation = 0D;
            this.btnhome.Size = new System.Drawing.Size(233, 49);
            this.btnhome.TabIndex = 1;
            this.btnhome.Text = "Management";
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnrestore
            // 
            this.btnrestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(47)))));
            this.btnrestore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnrestore.FlatAppearance.BorderSize = 0;
            this.btnrestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrestore.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnrestore.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnrestore.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btnrestore.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnrestore.IconSize = 36;
            this.btnrestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrestore.Location = new System.Drawing.Point(0, 172);
            this.btnrestore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnrestore.Name = "btnrestore";
            this.btnrestore.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnrestore.Rotation = 0D;
            this.btnrestore.Size = new System.Drawing.Size(233, 49);
            this.btnrestore.TabIndex = 2;
            this.btnrestore.Text = "Restore";
            this.btnrestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnrestore.UseVisualStyleBackColor = false;
            // 
            // btnothers
            // 
            this.btnothers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(47)))));
            this.btnothers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnothers.FlatAppearance.BorderSize = 0;
            this.btnothers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnothers.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnothers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnothers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnothers.IconChar = FontAwesome.Sharp.IconChar.AccessibleIcon;
            this.btnothers.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnothers.IconSize = 36;
            this.btnothers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnothers.Location = new System.Drawing.Point(0, 221);
            this.btnothers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnothers.Name = "btnothers";
            this.btnothers.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnothers.Rotation = 0D;
            this.btnothers.Size = new System.Drawing.Size(233, 49);
            this.btnothers.TabIndex = 3;
            this.btnothers.Text = "Others";
            this.btnothers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnothers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnothers.UseVisualStyleBackColor = false;
            // 
            // btnfot
            // 
            this.btnfot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(47)))));
            this.btnfot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnfot.FlatAppearance.BorderSize = 0;
            this.btnfot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfot.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnfot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnfot.IconChar = FontAwesome.Sharp.IconChar.AccessibleIcon;
            this.btnfot.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnfot.IconSize = 36;
            this.btnfot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfot.Location = new System.Drawing.Point(0, 427);
            this.btnfot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnfot.Name = "btnfot";
            this.btnfot.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnfot.Rotation = 0D;
            this.btnfot.Size = new System.Drawing.Size(233, 49);
            this.btnfot.TabIndex = 4;
            this.btnfot.Text = "Remove all";
            this.btnfot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnfot.UseVisualStyleBackColor = false;
            // 
            // btnsettings
            // 
            this.btnsettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(34)))), ((int)(((byte)(47)))));
            this.btnsettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsettings.FlatAppearance.BorderSize = 0;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnsettings.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnsettings.IconChar = FontAwesome.Sharp.IconChar.Redhat;
            this.btnsettings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnsettings.IconSize = 36;
            this.btnsettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsettings.Location = new System.Drawing.Point(0, 270);
            this.btnsettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnsettings.Rotation = 0D;
            this.btnsettings.Size = new System.Drawing.Size(233, 49);
            this.btnsettings.TabIndex = 5;
            this.btnsettings.Text = "Settings";
            this.btnsettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsettings.UseVisualStyleBackColor = false;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(233, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 476);
            this.panel1.TabIndex = 1;
            // 
            // formprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 476);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formprincipal";
            this.Load += new System.EventHandler(this.formprincipal_Load);
            this.panel.ResumeLayout(false);
            this.panellog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imglogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panellog;
        private System.Windows.Forms.PictureBox imglogo;
        private FontAwesome.Sharp.IconButton btnsettings;
        private FontAwesome.Sharp.IconButton btnfot;
        private FontAwesome.Sharp.IconButton btnothers;
        private FontAwesome.Sharp.IconButton btnrestore;
        private FontAwesome.Sharp.IconButton btnhome;
        private System.Windows.Forms.Panel panel1;
    }
}

