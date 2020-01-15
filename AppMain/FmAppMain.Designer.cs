namespace AppMain
{
    partial class FmAppMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmAppMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tssbTools = new System.Windows.Forms.ToolStripSplitButton();
            this.noteBookItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbTools});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tssbTools
            // 
            this.tssbTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssbTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noteBookItem,
            this.bToolStripMenuItem,
            this.cToolStripMenuItem});
            this.tssbTools.Image = ((System.Drawing.Image)(resources.GetObject("tssbTools.Image")));
            this.tssbTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbTools.Name = "tssbTools";
            this.tssbTools.Size = new System.Drawing.Size(58, 24);
            this.tssbTools.Text = "工具";
            // 
            // noteBookItem
            // 
            this.noteBookItem.Name = "noteBookItem";
            this.noteBookItem.Size = new System.Drawing.Size(216, 26);
            this.noteBookItem.Text = "笔记本";
            this.noteBookItem.Click += new System.EventHandler(this.noteBookItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bToolStripMenuItem.Text = "b";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cToolStripMenuItem.Text = "c";
            // 
            // FmAppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FmAppMain";
            this.Text = "FmAppMain";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton tssbTools;
        private System.Windows.Forms.ToolStripMenuItem noteBookItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
    }
}