namespace DemoCalculator;

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
        splitContainer1 = new System.Windows.Forms.SplitContainer();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        zeroButton = new System.Windows.Forms.Button();
        changeSignButton = new System.Windows.Forms.Button();
        decimalButton = new System.Windows.Forms.Button();
        additionButton = new System.Windows.Forms.Button();
        oneButton = new System.Windows.Forms.Button();
        twoButton = new System.Windows.Forms.Button();
        threeButton = new System.Windows.Forms.Button();
        substractionButton = new System.Windows.Forms.Button();
        equalsButton = new System.Windows.Forms.Button();
        fourButton = new System.Windows.Forms.Button();
        fiveButton = new System.Windows.Forms.Button();
        sixButton = new System.Windows.Forms.Button();
        multiplicationButton = new System.Windows.Forms.Button();
        textBox1 = new System.Windows.Forms.TextBox();
        sevenButton = new System.Windows.Forms.Button();
        eightButton = new System.Windows.Forms.Button();
        nineButton = new System.Windows.Forms.Button();
        divisionButton = new System.Windows.Forms.Button();
        clearButton = new System.Windows.Forms.Button();
        listView1 = new System.Windows.Forms.ListView();
        History = new System.Windows.Forms.ColumnHeader();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        splitContainer1.Location = new System.Drawing.Point(0, 0);
        splitContainer1.Margin = new System.Windows.Forms.Padding(5);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(listView1);
        splitContainer1.Size = new System.Drawing.Size(968, 712);
        splitContainer1.SplitterDistance = 681;
        splitContainer1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 5;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.Controls.Add(zeroButton, 0, 4);
        tableLayoutPanel1.Controls.Add(changeSignButton, 1, 4);
        tableLayoutPanel1.Controls.Add(decimalButton, 2, 4);
        tableLayoutPanel1.Controls.Add(additionButton, 3, 4);
        tableLayoutPanel1.Controls.Add(oneButton, 0, 3);
        tableLayoutPanel1.Controls.Add(twoButton, 1, 3);
        tableLayoutPanel1.Controls.Add(threeButton, 2, 3);
        tableLayoutPanel1.Controls.Add(substractionButton, 3, 3);
        tableLayoutPanel1.Controls.Add(equalsButton, 4, 3);
        tableLayoutPanel1.Controls.Add(fourButton, 0, 2);
        tableLayoutPanel1.Controls.Add(fiveButton, 1, 2);
        tableLayoutPanel1.Controls.Add(sixButton, 2, 2);
        tableLayoutPanel1.Controls.Add(multiplicationButton, 3, 2);
        tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
        tableLayoutPanel1.Controls.Add(sevenButton, 0, 1);
        tableLayoutPanel1.Controls.Add(eightButton, 1, 1);
        tableLayoutPanel1.Controls.Add(nineButton, 2, 1);
        tableLayoutPanel1.Controls.Add(divisionButton, 3, 1);
        tableLayoutPanel1.Controls.Add(clearButton, 4, 1);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 5;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.251747F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.748253F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
        tableLayoutPanel1.Size = new System.Drawing.Size(681, 712);
        tableLayoutPanel1.TabIndex = 0;
        tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_2);
        // 
        // zeroButton
        // 
        zeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
        zeroButton.Location = new System.Drawing.Point(5, 583);
        zeroButton.Margin = new System.Windows.Forms.Padding(5);
        zeroButton.Name = "zeroButton";
        zeroButton.Size = new System.Drawing.Size(126, 124);
        zeroButton.TabIndex = 16;
        zeroButton.Text = "0";
        zeroButton.UseVisualStyleBackColor = true;
        // 
        // changeSignButton
        // 
        changeSignButton.Dock = System.Windows.Forms.DockStyle.Fill;
        changeSignButton.Location = new System.Drawing.Point(141, 583);
        changeSignButton.Margin = new System.Windows.Forms.Padding(5);
        changeSignButton.Name = "changeSignButton";
        changeSignButton.Size = new System.Drawing.Size(126, 124);
        changeSignButton.TabIndex = 17;
        changeSignButton.Text = "+/-";
        changeSignButton.UseVisualStyleBackColor = true;
        // 
        // decimalButton
        // 
        decimalButton.Dock = System.Windows.Forms.DockStyle.Fill;
        decimalButton.Location = new System.Drawing.Point(277, 583);
        decimalButton.Margin = new System.Windows.Forms.Padding(5);
        decimalButton.Name = "decimalButton";
        decimalButton.Size = new System.Drawing.Size(126, 124);
        decimalButton.TabIndex = 18;
        decimalButton.Text = ".";
        decimalButton.UseVisualStyleBackColor = true;
        // 
        // additionButton
        // 
        additionButton.Dock = System.Windows.Forms.DockStyle.Fill;
        additionButton.Location = new System.Drawing.Point(413, 583);
        additionButton.Margin = new System.Windows.Forms.Padding(5);
        additionButton.Name = "additionButton";
        additionButton.Size = new System.Drawing.Size(126, 124);
        additionButton.TabIndex = 19;
        additionButton.Text = "+";
        additionButton.UseVisualStyleBackColor = true;
        // 
        // oneButton
        // 
        oneButton.Dock = System.Windows.Forms.DockStyle.Fill;
        oneButton.Location = new System.Drawing.Point(5, 439);
        oneButton.Margin = new System.Windows.Forms.Padding(5);
        oneButton.Name = "oneButton";
        oneButton.Size = new System.Drawing.Size(126, 134);
        oneButton.TabIndex = 11;
        oneButton.Text = "1";
        oneButton.UseVisualStyleBackColor = true;
        // 
        // twoButton
        // 
        twoButton.Dock = System.Windows.Forms.DockStyle.Fill;
        twoButton.Location = new System.Drawing.Point(141, 439);
        twoButton.Margin = new System.Windows.Forms.Padding(5);
        twoButton.Name = "twoButton";
        twoButton.Size = new System.Drawing.Size(126, 134);
        twoButton.TabIndex = 12;
        twoButton.Text = "2";
        twoButton.UseVisualStyleBackColor = true;
        // 
        // threeButton
        // 
        threeButton.Dock = System.Windows.Forms.DockStyle.Fill;
        threeButton.Location = new System.Drawing.Point(277, 439);
        threeButton.Margin = new System.Windows.Forms.Padding(5);
        threeButton.Name = "threeButton";
        threeButton.Size = new System.Drawing.Size(126, 134);
        threeButton.TabIndex = 13;
        threeButton.Text = "3";
        threeButton.UseVisualStyleBackColor = true;
        // 
        // substractionButton
        // 
        substractionButton.Dock = System.Windows.Forms.DockStyle.Fill;
        substractionButton.Location = new System.Drawing.Point(413, 439);
        substractionButton.Margin = new System.Windows.Forms.Padding(5);
        substractionButton.Name = "substractionButton";
        substractionButton.Size = new System.Drawing.Size(126, 134);
        substractionButton.TabIndex = 14;
        substractionButton.Text = "-";
        substractionButton.UseVisualStyleBackColor = true;
        // 
        // equalsButton
        // 
        equalsButton.Dock = System.Windows.Forms.DockStyle.Fill;
        equalsButton.Location = new System.Drawing.Point(549, 439);
        equalsButton.Margin = new System.Windows.Forms.Padding(5);
        equalsButton.Name = "equalsButton";
        tableLayoutPanel1.SetRowSpan(equalsButton, 2);
        equalsButton.Size = new System.Drawing.Size(127, 268);
        equalsButton.TabIndex = 15;
        equalsButton.Text = "=";
        equalsButton.UseVisualStyleBackColor = true;
        // 
        // fourButton
        // 
        fourButton.Dock = System.Windows.Forms.DockStyle.Fill;
        fourButton.Location = new System.Drawing.Point(5, 291);
        fourButton.Margin = new System.Windows.Forms.Padding(5);
        fourButton.Name = "fourButton";
        fourButton.Size = new System.Drawing.Size(126, 138);
        fourButton.TabIndex = 6;
        fourButton.Text = "4";
        fourButton.UseVisualStyleBackColor = true;
        fourButton.Click += new System.EventHandler(this.fourButton_Click);
        // 
        // fiveButton
        // 
        fiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
        fiveButton.Location = new System.Drawing.Point(141, 291);
        fiveButton.Margin = new System.Windows.Forms.Padding(5);
        fiveButton.Name = "fiveButton";
        fiveButton.Size = new System.Drawing.Size(126, 138);
        fiveButton.TabIndex = 7;
        fiveButton.Text = "5";
        fiveButton.UseVisualStyleBackColor = true;
        // 
        // sixButton
        // 
        sixButton.Dock = System.Windows.Forms.DockStyle.Fill;
        sixButton.Location = new System.Drawing.Point(277, 291);
        sixButton.Margin = new System.Windows.Forms.Padding(5);
        sixButton.Name = "sixButton";
        sixButton.Size = new System.Drawing.Size(126, 138);
        sixButton.TabIndex = 8;
        sixButton.Text = "6";
        sixButton.UseVisualStyleBackColor = true;
        sixButton.Click += new System.EventHandler(this.sixButton_Click);
        // 
        // multiplicationButton
        // 
        multiplicationButton.Dock = System.Windows.Forms.DockStyle.Fill;
        multiplicationButton.Location = new System.Drawing.Point(413, 291);
        multiplicationButton.Margin = new System.Windows.Forms.Padding(5);
        multiplicationButton.Name = "multiplicationButton";
        multiplicationButton.Size = new System.Drawing.Size(126, 138);
        multiplicationButton.TabIndex = 9;
        multiplicationButton.Text = "*";
        multiplicationButton.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        tableLayoutPanel1.SetColumnSpan(textBox1, 5);
        textBox1.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        textBox1.Location = new System.Drawing.Point(3, 34);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(675, 70);
        textBox1.TabIndex = 0;
        // 
        // sevenButton
        // 
        sevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
        sevenButton.Location = new System.Drawing.Point(5, 143);
        sevenButton.Margin = new System.Windows.Forms.Padding(5);
        sevenButton.Name = "sevenButton";
        sevenButton.Size = new System.Drawing.Size(126, 138);
        sevenButton.TabIndex = 1;
        sevenButton.Text = "7";
        sevenButton.UseVisualStyleBackColor = true;
        // 
        // eightButton
        // 
        eightButton.Dock = System.Windows.Forms.DockStyle.Fill;
        eightButton.Location = new System.Drawing.Point(141, 143);
        eightButton.Margin = new System.Windows.Forms.Padding(5);
        eightButton.Name = "eightButton";
        eightButton.Size = new System.Drawing.Size(126, 138);
        eightButton.TabIndex = 2;
        eightButton.Text = "8";
        eightButton.UseVisualStyleBackColor = true;
        // 
        // nineButton
        // 
        nineButton.Dock = System.Windows.Forms.DockStyle.Fill;
        nineButton.Location = new System.Drawing.Point(277, 143);
        nineButton.Margin = new System.Windows.Forms.Padding(5);
        nineButton.Name = "nineButton";
        nineButton.Size = new System.Drawing.Size(126, 138);
        nineButton.TabIndex = 3;
        nineButton.Text = "9";
        nineButton.UseVisualStyleBackColor = true;
        // 
        // divisionButton
        // 
        divisionButton.Dock = System.Windows.Forms.DockStyle.Fill;
        divisionButton.Location = new System.Drawing.Point(413, 143);
        divisionButton.Margin = new System.Windows.Forms.Padding(5);
        divisionButton.Name = "divisionButton";
        divisionButton.Size = new System.Drawing.Size(126, 138);
        divisionButton.TabIndex = 4;
        divisionButton.Text = "/";
        divisionButton.UseVisualStyleBackColor = true;
        // 
        // clearButton
        // 
        clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
        clearButton.Location = new System.Drawing.Point(549, 143);
        clearButton.Margin = new System.Windows.Forms.Padding(5);
        clearButton.Name = "clearButton";
        tableLayoutPanel1.SetRowSpan(clearButton, 2);
        clearButton.Size = new System.Drawing.Size(127, 286);
        clearButton.TabIndex = 5;
        clearButton.Text = "Clear";
        clearButton.UseVisualStyleBackColor = true;
        // 
        // listView1
        // 
        listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { History });
        listView1.Dock = System.Windows.Forms.DockStyle.Fill;
        listView1.Location = new System.Drawing.Point(0, 0);
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(283, 712);
        listView1.TabIndex = 0;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
        // 
        // History
        // 
        History.Name = "History";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(968, 712);
        Controls.Add(splitContainer1);
        Text = "Form1";
        this.Load += new System.EventHandler(this.Form1_Load);
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button sevenButton;
    private System.Windows.Forms.Button eightButton;
    private System.Windows.Forms.Button nineButton;
    private System.Windows.Forms.Button divisionButton;
    private System.Windows.Forms.Button clearButton;
    private System.Windows.Forms.Button fourButton;
    private System.Windows.Forms.Button fiveButton;
    private System.Windows.Forms.Button sixButton;
    private System.Windows.Forms.Button multiplicationButton;
    private System.Windows.Forms.Button oneButton;
    private System.Windows.Forms.Button twoButton;
    private System.Windows.Forms.Button threeButton;
    private System.Windows.Forms.Button substractionButton;
    private System.Windows.Forms.Button equalsButton;
    private System.Windows.Forms.Button zeroButton;
    private System.Windows.Forms.Button changeSignButton;
    private System.Windows.Forms.Button decimalButton;
    private System.Windows.Forms.Button additionButton;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.ColumnHeader History;

    private System.Windows.Forms.ListView listView1;

    private System.Windows.Forms.SplitContainer splitContainer1;

    #endregion
}