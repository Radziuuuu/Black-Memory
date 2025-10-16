using System.ComponentModel;

namespace Memory.Controls;

partial class MainControl
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        splitContainer1 = new System.Windows.Forms.SplitContainer();
        scene1 = new Memory.Controls.Scene();
        boardControl1 = new Memory.Controls.BoardControl();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.Location = new System.Drawing.Point(3, 3);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(scene1);
        splitContainer1.Panel1MinSize = 15;
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(boardControl1);
        splitContainer1.Size = new System.Drawing.Size(722, 471);
        splitContainer1.SplitterDistance = 238;
        splitContainer1.TabIndex = 0;
        splitContainer1.Text = "splitContainer1";
        // 
        // scene1
        // 
        scene1.Location = new System.Drawing.Point(4, 4);
        scene1.Name = "scene1";
        scene1.Size = new System.Drawing.Size(232, 684);
        scene1.TabIndex = 0;
        // 
        // boardControl1
        // 
        boardControl1.Location = new System.Drawing.Point(3, 4);
        boardControl1.Name = "boardControl1";
        boardControl1.Size = new System.Drawing.Size(399, 403);
        boardControl1.TabIndex = 0;
        // 
        // MainControl
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(splitContainer1);
        Size = new System.Drawing.Size(887, 691);
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private Memory.Controls.BoardControl boardControl1;

    private System.Windows.Forms.SplitContainer splitContainer1;

    private Memory.Controls.Scene scene1;

    #endregion
    
}