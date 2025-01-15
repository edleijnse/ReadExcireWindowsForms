namespace ReadExcireWindowsForms;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        buttonReadAnnotations = new System.Windows.Forms.Button();
        listViewAnnotations = new System.Windows.Forms.ListView();
        label1 = new System.Windows.Forms.Label();
        labelTotalAnnotations = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // buttonReadAnnotations
        // 
        buttonReadAnnotations.Location = new System.Drawing.Point(61, 26);
        buttonReadAnnotations.Name = "buttonReadAnnotations";
        buttonReadAnnotations.Size = new System.Drawing.Size(192, 61);
        buttonReadAnnotations.TabIndex = 0;
        buttonReadAnnotations.Text = "read Annotations";
        buttonReadAnnotations.UseVisualStyleBackColor = true;
        buttonReadAnnotations.Click += buttonReadAnnotations_Click;
        // 
        // listViewAnnotations
        // 
        listViewAnnotations.Location = new System.Drawing.Point(60, 129);
        listViewAnnotations.Name = "listViewAnnotations";
        listViewAnnotations.Size = new System.Drawing.Size(660, 217);
        listViewAnnotations.TabIndex = 1;
        listViewAnnotations.UseCompatibleStateImageBehavior = false;
        listViewAnnotations.SelectedIndexChanged += listViewAnnotations_SelectedIndexChanged;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(65, 365);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(153, 25);
        label1.TabIndex = 2;
        label1.Text = "total annotations:";
        // 
        // labelTotalAnnotations
        // 
        labelTotalAnnotations.Location = new System.Drawing.Point(68, 396);
        labelTotalAnnotations.Name = "labelTotalAnnotations";
        labelTotalAnnotations.Size = new System.Drawing.Size(96, 24);
        labelTotalAnnotations.TabIndex = 3;
        labelTotalAnnotations.Text = "0";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(labelTotalAnnotations);
        Controls.Add(label1);
        Controls.Add(listViewAnnotations);
        Controls.Add(buttonReadAnnotations);
        Text = "Read Excire Database";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label labelTotalAnnotations;

    private System.Windows.Forms.ListView listViewAnnotations;

    private System.Windows.Forms.Button buttonReadAnnotations;

    #endregion
}