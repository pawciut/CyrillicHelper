namespace CyrillicHelper
{
    partial class LookupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookupForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAlwaysOnTop = new System.Windows.Forms.ToolStripButton();
            this.btnSound = new System.Windows.Forms.ToolStripButton();
            this.wpfControlHost = new System.Windows.Forms.Integration.ElementHost();
            this.lookupStackPanel1 = new CyrillicHelper.WPFControls.LookupStackPanel();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.wpfControlHost);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 518);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 543);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAlwaysOnTop,
            this.btnSound});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(215, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // btnAlwaysOnTop
            // 
            this.btnAlwaysOnTop.Checked = true;
            this.btnAlwaysOnTop.CheckOnClick = true;
            this.btnAlwaysOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnAlwaysOnTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAlwaysOnTop.Image = ((System.Drawing.Image)(resources.GetObject("btnAlwaysOnTop.Image")));
            this.btnAlwaysOnTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlwaysOnTop.Name = "btnAlwaysOnTop";
            this.btnAlwaysOnTop.Size = new System.Drawing.Size(106, 22);
            this.btnAlwaysOnTop.Text = "Always on Top (T)";
            this.btnAlwaysOnTop.Click += new System.EventHandler(this.btnAlwaysOnTop_Click);
            // 
            // btnSound
            // 
            this.btnSound.CheckOnClick = true;
            this.btnSound.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSound.Image = ((System.Drawing.Image)(resources.GetObject("btnSound.Image")));
            this.btnSound.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(97, 22);
            this.btnSound.Text = "Mute sound (M)";
            this.btnSound.ToolTipText = "Toggle sound on/off";
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // wpfControlHost
            // 
            this.wpfControlHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wpfControlHost.Location = new System.Drawing.Point(0, 0);
            this.wpfControlHost.Name = "wpfControlHost";
            this.wpfControlHost.Size = new System.Drawing.Size(800, 518);
            this.wpfControlHost.TabIndex = 0;
            this.wpfControlHost.Text = "element host";
            this.wpfControlHost.Child = this.lookupStackPanel1;
            // 
            // LookupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.toolStripContainer1);
            this.KeyPreview = true;
            this.Name = "LookupForm";
            this.Text = "LookupForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LookupForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LookupForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LookupForm_KeyPress);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAlwaysOnTop;
        private System.Windows.Forms.Integration.ElementHost wpfControlHost;
        private WPFControls.LookupStackPanel lookupStackPanel1;
        private System.Windows.Forms.ToolStripButton btnSound;
    }
}