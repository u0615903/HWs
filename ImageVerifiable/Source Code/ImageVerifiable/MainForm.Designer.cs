namespace ImageVerifiable
{
    partial class MainForm
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
            this.pbSource = new System.Windows.Forms.PictureBox();
            this.pbTarget = new System.Windows.Forms.PictureBox();
            this.tbPath1 = new System.Windows.Forms.TextBox();
            this.btnOpenS = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelTarget = new System.Windows.Forms.Panel();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.lbTarget = new System.Windows.Forms.Label();
            this.panelSource = new System.Windows.Forms.Panel();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.lbSource = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelTarget.SuspendLayout();
            this.panelSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSource
            // 
            this.pbSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbSource.Location = new System.Drawing.Point(0, 12);
            this.pbSource.Name = "pbSource";
            this.pbSource.Size = new System.Drawing.Size(512, 512);
            this.pbSource.TabIndex = 12;
            this.pbSource.TabStop = false;
            // 
            // pbTarget
            // 
            this.pbTarget.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbTarget.Location = new System.Drawing.Point(0, 12);
            this.pbTarget.Name = "pbTarget";
            this.pbTarget.Size = new System.Drawing.Size(512, 512);
            this.pbTarget.TabIndex = 9;
            this.pbTarget.TabStop = false;
            // 
            // tbPath1
            // 
            this.tbPath1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath1.Location = new System.Drawing.Point(90, 5);
            this.tbPath1.Name = "tbPath1";
            this.tbPath1.Size = new System.Drawing.Size(856, 22);
            this.tbPath1.TabIndex = 1;
            this.tbPath1.Text = "Lena-RGB.bmp";
            // 
            // btnOpenS
            // 
            this.btnOpenS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenS.Location = new System.Drawing.Point(952, 5);
            this.btnOpenS.Name = "btnOpenS";
            this.btnOpenS.Size = new System.Drawing.Size(75, 23);
            this.btnOpenS.TabIndex = 0;
            this.btnOpenS.Text = "Load";
            this.btnOpenS.UseVisualStyleBackColor = true;
            this.btnOpenS.Click += new System.EventHandler(this.btnOpenS_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 693);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1033, 36);
            this.panel3.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(6, 6);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnOpenS);
            this.panel4.Controls.Add(this.tbPath1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1033, 32);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Image:";
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.panelTarget);
            this.panel5.Controls.Add(this.panelSource);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1033, 661);
            this.panel5.TabIndex = 1;
            // 
            // panelTarget
            // 
            this.panelTarget.Controls.Add(this.tbTarget);
            this.panelTarget.Controls.Add(this.pbTarget);
            this.panelTarget.Controls.Add(this.lbTarget);
            this.panelTarget.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTarget.Location = new System.Drawing.Point(512, 0);
            this.panelTarget.Name = "panelTarget";
            this.panelTarget.Size = new System.Drawing.Size(512, 661);
            this.panelTarget.TabIndex = 4;
            // 
            // tbTarget
            // 
            this.tbTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTarget.Location = new System.Drawing.Point(0, 524);
            this.tbTarget.Multiline = true;
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbTarget.Size = new System.Drawing.Size(512, 137);
            this.tbTarget.TabIndex = 12;
            // 
            // lbTarget
            // 
            this.lbTarget.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTarget.Location = new System.Drawing.Point(0, 0);
            this.lbTarget.Name = "lbTarget";
            this.lbTarget.Size = new System.Drawing.Size(512, 12);
            this.lbTarget.TabIndex = 13;
            this.lbTarget.Text = "Target";
            // 
            // panelSource
            // 
            this.panelSource.Controls.Add(this.tbSource);
            this.panelSource.Controls.Add(this.pbSource);
            this.panelSource.Controls.Add(this.lbSource);
            this.panelSource.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSource.Location = new System.Drawing.Point(0, 0);
            this.panelSource.Name = "panelSource";
            this.panelSource.Size = new System.Drawing.Size(512, 661);
            this.panelSource.TabIndex = 2;
            // 
            // tbSource
            // 
            this.tbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSource.Location = new System.Drawing.Point(0, 524);
            this.tbSource.Multiline = true;
            this.tbSource.Name = "tbSource";
            this.tbSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSource.Size = new System.Drawing.Size(512, 137);
            this.tbSource.TabIndex = 12;
            // 
            // lbSource
            // 
            this.lbSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSource.Location = new System.Drawing.Point(0, 0);
            this.lbSource.Name = "lbSource";
            this.lbSource.Size = new System.Drawing.Size(512, 12);
            this.lbSource.TabIndex = 14;
            this.lbSource.Text = "Source";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 729);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "MainForm";
            this.Text = "ImageVerifiable";
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panelTarget.ResumeLayout(false);
            this.panelTarget.PerformLayout();
            this.panelSource.ResumeLayout(false);
            this.panelSource.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath1;
        private System.Windows.Forms.Button btnOpenS;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.PictureBox pbSource;
        private System.Windows.Forms.PictureBox pbTarget;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelTarget;
        private System.Windows.Forms.Panel panelSource;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Label lbTarget;
        private System.Windows.Forms.Label lbSource;
    }
}

