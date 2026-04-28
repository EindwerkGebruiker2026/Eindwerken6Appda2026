namespace Eindwerken6Appda2025
{
    partial class frmHoofdformulier
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			menuStrip1 = new MenuStrip();
			wiskundeInoefenenToolStripMenuItem = new ToolStripMenuItem();
			jaimyDiscriminantToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(24, 24);
			menuStrip1.Items.AddRange(new ToolStripItem[] { wiskundeInoefenenToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 33);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// wiskundeInoefenenToolStripMenuItem
			// 
			wiskundeInoefenenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jaimyDiscriminantToolStripMenuItem });
			wiskundeInoefenenToolStripMenuItem.Name = "wiskundeInoefenenToolStripMenuItem";
			wiskundeInoefenenToolStripMenuItem.Size = new Size(189, 29);
			wiskundeInoefenenToolStripMenuItem.Text = "Wiskunde inoefenen";
			// 
			// jaimyDiscriminantToolStripMenuItem
			// 
			jaimyDiscriminantToolStripMenuItem.Name = "jaimyDiscriminantToolStripMenuItem";
			jaimyDiscriminantToolStripMenuItem.Size = new Size(273, 34);
			jaimyDiscriminantToolStripMenuItem.Text = "Jaimy - Discriminant";
			jaimyDiscriminantToolStripMenuItem.Click += jaimyDiscriminantToolStripMenuItem_Click;
			// 
			// frmHoofdformulier
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "frmHoofdformulier";
			Text = "Wiskunde inoefenen";
			Load += frmHoofdformulier_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem wiskundeInoefenenToolStripMenuItem;
		private ToolStripMenuItem jaimyDiscriminantToolStripMenuItem;
	}
}
