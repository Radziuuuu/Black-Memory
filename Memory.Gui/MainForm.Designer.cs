namespace Memory.Gui
{
    partial class MainForm
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
            boardControl1 = new Memory.Controls.BoardControl();
            SuspendLayout();
            // 
            // boardControl1
            // 
            boardControl1.Dock = DockStyle.Fill;
            boardControl1.Location = new Point(0, 0);
            boardControl1.Name = "boardControl1";
            boardControl1.Size = new Size(800, 450);
            boardControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(boardControl1);
            Name = "MainForm";
            Text = "Memory.Gui";
            ResumeLayout(false);
        }

        #endregion

        private Controls.BoardControl boardControl1;
    }
}
