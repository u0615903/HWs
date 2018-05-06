namespace FusionFlips
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
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.pbTarget = new System.Windows.Forms.PictureBox();
            this.tbPath1 = new System.Windows.Forms.TextBox();
            this.btnOpenS = new System.Windows.Forms.Button();
            this.tbPath2 = new System.Windows.Forms.TextBox();
            this.btnOpenT = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRevResult = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelResult = new System.Windows.Forms.Panel();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.panelTarget = new System.Windows.Forms.Panel();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.lbTarget = new System.Windows.Forms.Label();
            this.panelSource = new System.Windows.Forms.Panel();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.lbSource = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelResult.SuspendLayout();
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
            // pbResult
            // 
            this.pbResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbResult.Location = new System.Drawing.Point(0, 12);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(512, 512);
            this.pbResult.TabIndex = 11;
            this.pbResult.TabStop = false;
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
            this.tbPath1.Size = new System.Drawing.Size(1369, 22);
            this.tbPath1.TabIndex = 1;
            this.tbPath1.Text = "Baboon-RGB.bmp";
            // 
            // btnOpenS
            // 
            this.btnOpenS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenS.Location = new System.Drawing.Point(1465, 5);
            this.btnOpenS.Name = "btnOpenS";
            this.btnOpenS.Size = new System.Drawing.Size(75, 23);
            this.btnOpenS.TabIndex = 0;
            this.btnOpenS.Text = "Load";
            this.btnOpenS.UseVisualStyleBackColor = true;
            this.btnOpenS.Click += new System.EventHandler(this.btnOpenS_Click);
            // 
            // tbPath2
            // 
            this.tbPath2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath2.Location = new System.Drawing.Point(90, 33);
            this.tbPath2.Name = "tbPath2";
            this.tbPath2.Size = new System.Drawing.Size(1369, 22);
            this.tbPath2.TabIndex = 1;
            this.tbPath2.Text = "Lena-RGB.bmp";
            // 
            // btnOpenT
            // 
            this.btnOpenT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenT.Location = new System.Drawing.Point(1465, 33);
            this.btnOpenT.Name = "btnOpenT";
            this.btnOpenT.Size = new System.Drawing.Size(75, 23);
            this.btnOpenT.TabIndex = 0;
            this.btnOpenT.Text = "Load";
            this.btnOpenT.UseVisualStyleBackColor = true;
            this.btnOpenT.Click += new System.EventHandler(this.btnOpenT_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRevResult);
            this.panel3.Controls.Add(this.btnGo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 693);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1546, 36);
            this.panel3.TabIndex = 2;
            // 
            // btnRevResult
            // 
            this.btnRevResult.Location = new System.Drawing.Point(87, 6);
            this.btnRevResult.Name = "btnRevResult";
            this.btnRevResult.Size = new System.Drawing.Size(75, 23);
            this.btnRevResult.TabIndex = 1;
            this.btnRevResult.Text = "GoRev";
            this.btnRevResult.UseVisualStyleBackColor = true;
            this.btnRevResult.Click += new System.EventHandler(this.btnRevResult_Click);
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
            this.panel4.Controls.Add(this.btnOpenT);
            this.panel4.Controls.Add(this.tbPath2);
            this.panel4.Controls.Add(this.btnOpenS);
            this.panel4.Controls.Add(this.tbPath1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1546, 60);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target Image:";
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
            this.panel5.Controls.Add(this.panelResult);
            this.panel5.Controls.Add(this.panelTarget);
            this.panel5.Controls.Add(this.panelSource);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1546, 633);
            this.panel5.TabIndex = 1;
            // 
            // panelResult
            // 
            this.panelResult.Controls.Add(this.tbResult);
            this.panelResult.Controls.Add(this.pbResult);
            this.panelResult.Controls.Add(this.lbResult);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult.Location = new System.Drawing.Point(1024, 0);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(512, 633);
            this.panelResult.TabIndex = 3;
            // 
            // tbResult
            // 
            this.tbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbResult.Location = new System.Drawing.Point(0, 524);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResult.Size = new System.Drawing.Size(512, 109);
            this.tbResult.TabIndex = 6;
            // 
            // lbResult
            // 
            this.lbResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbResult.Location = new System.Drawing.Point(0, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(512, 12);
            this.lbResult.TabIndex = 10;
            this.lbResult.Text = "Result";
            // 
            // panelTarget
            // 
            this.panelTarget.Controls.Add(this.tbTarget);
            this.panelTarget.Controls.Add(this.pbTarget);
            this.panelTarget.Controls.Add(this.lbTarget);
            this.panelTarget.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTarget.Location = new System.Drawing.Point(512, 0);
            this.panelTarget.Name = "panelTarget";
            this.panelTarget.Size = new System.Drawing.Size(512, 633);
            this.panelTarget.TabIndex = 4;
            // 
            // tbTarget
            // 
            this.tbTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTarget.Location = new System.Drawing.Point(0, 524);
            this.tbTarget.Multiline = true;
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbTarget.Size = new System.Drawing.Size(512, 109);
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
            this.panelSource.Size = new System.Drawing.Size(512, 633);
            this.panelSource.TabIndex = 2;
            // 
            // tbSource
            // 
            this.tbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSource.Location = new System.Drawing.Point(0, 524);
            this.tbSource.Multiline = true;
            this.tbSource.Name = "tbSource";
            this.tbSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSource.Size = new System.Drawing.Size(512, 109);
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
            this.ClientSize = new System.Drawing.Size(1546, 729);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "MainForm";
            this.Text = "FusionFlips";
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.panelTarget.ResumeLayout(false);
            this.panelTarget.PerformLayout();
            this.panelSource.ResumeLayout(false);
            this.panelSource.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath1;
        private System.Windows.Forms.Button btnOpenS;
        private System.Windows.Forms.TextBox tbPath2;
        private System.Windows.Forms.Button btnOpenT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.PictureBox pbSource;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.PictureBox pbTarget;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Panel panelTarget;
        private System.Windows.Forms.Panel panelSource;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbTarget;
        private System.Windows.Forms.Label lbSource;
        private System.Windows.Forms.Button btnRevResult;
    }
}

