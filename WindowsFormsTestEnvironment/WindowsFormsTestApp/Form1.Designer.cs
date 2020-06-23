namespace WindowsFormsTestApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.option1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choice1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choice2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choice3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variant1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variant2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.option2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choice1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.choice2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.option3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxTest = new System.Windows.Forms.CheckBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AllowDrop = true;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.option1ToolStripMenuItem,
            this.option2ToolStripMenuItem,
            this.option3ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 70);
            // 
            // option1ToolStripMenuItem
            // 
            this.option1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choice1ToolStripMenuItem,
            this.choice2ToolStripMenuItem,
            this.choice3ToolStripMenuItem});
            this.option1ToolStripMenuItem.Name = "option1ToolStripMenuItem";
            this.option1ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.option1ToolStripMenuItem.Text = "option1";
            // 
            // choice1ToolStripMenuItem
            // 
            this.choice1ToolStripMenuItem.Name = "choice1ToolStripMenuItem";
            this.choice1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.choice1ToolStripMenuItem.Text = "choice1";
            // 
            // choice2ToolStripMenuItem
            // 
            this.choice2ToolStripMenuItem.Name = "choice2ToolStripMenuItem";
            this.choice2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.choice2ToolStripMenuItem.Text = "choice2";
            // 
            // choice3ToolStripMenuItem
            // 
            this.choice3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.variant1ToolStripMenuItem,
            this.variant2ToolStripMenuItem});
            this.choice3ToolStripMenuItem.Name = "choice3ToolStripMenuItem";
            this.choice3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.choice3ToolStripMenuItem.Text = "choice3";
            // 
            // variant1ToolStripMenuItem
            // 
            this.variant1ToolStripMenuItem.Name = "variant1ToolStripMenuItem";
            this.variant1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.variant1ToolStripMenuItem.Text = "variant1";
            // 
            // variant2ToolStripMenuItem
            // 
            this.variant2ToolStripMenuItem.Name = "variant2ToolStripMenuItem";
            this.variant2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.variant2ToolStripMenuItem.Text = "variant2";
            // 
            // option2ToolStripMenuItem
            // 
            this.option2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choice1ToolStripMenuItem1,
            this.choice2ToolStripMenuItem1});
            this.option2ToolStripMenuItem.Name = "option2ToolStripMenuItem";
            this.option2ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.option2ToolStripMenuItem.Text = "option2";
            // 
            // choice1ToolStripMenuItem1
            // 
            this.choice1ToolStripMenuItem1.Name = "choice1ToolStripMenuItem1";
            this.choice1ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.choice1ToolStripMenuItem1.Text = "choice1";
            // 
            // choice2ToolStripMenuItem1
            // 
            this.choice2ToolStripMenuItem1.Name = "choice2ToolStripMenuItem1";
            this.choice2ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.choice2ToolStripMenuItem1.Text = "choice2";
            // 
            // option3ToolStripMenuItem
            // 
            this.option3ToolStripMenuItem.Name = "option3ToolStripMenuItem";
            this.option3ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.option3ToolStripMenuItem.Text = "option3";
            // 
            // checkBoxTest
            // 
            this.checkBoxTest.AutoSize = true;
            this.checkBoxTest.Location = new System.Drawing.Point(12, 212);
            this.checkBoxTest.Name = "checkBoxTest";
            this.checkBoxTest.Size = new System.Drawing.Size(100, 17);
            this.checkBoxTest.TabIndex = 2;
            this.checkBoxTest.Text = "tick to see label";
            this.checkBoxTest.UseVisualStyleBackColor = true;
            this.checkBoxTest.CheckedChanged += new System.EventHandler(this.checkBoxTest_CheckedChanged);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(172, 213);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "akuku";
            this.labelResult.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.checkBoxTest);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem option1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choice1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choice2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choice3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variant1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variant2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem option2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choice1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem choice2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem option3ToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxTest;
        private System.Windows.Forms.Label labelResult;
    }
}

