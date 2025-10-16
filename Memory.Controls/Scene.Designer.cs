using System.ComponentModel;

namespace Memory.Controls;

partial class Scene
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
        label1 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(48, 32);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(131, 32);
        label1.TabIndex = 0;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(48, 116);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(123, 33);
        button1.TabIndex = 1;
        button1.Text = "RESET BUTTON";
        button1.UseVisualStyleBackColor = true;
        // 
        // Scene
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(button1);
        Controls.Add(label1);
        Size = new System.Drawing.Size(235, 659);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;

    #endregion
}