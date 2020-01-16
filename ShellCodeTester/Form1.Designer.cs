﻿namespace ShellCodeTester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtShellcode = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.cbBreakpoint = new System.Windows.Forms.CheckBox();
            this.sbStatus = new System.Windows.Forms.StatusStrip();
            this.cbAlighStack = new System.Windows.Forms.CheckBox();
            this.rb32Bits = new System.Windows.Forms.RadioButton();
            this.rb64Bits = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shellcode";
            // 
            // txtShellcode
            // 
            this.txtShellcode.Location = new System.Drawing.Point(12, 47);
            this.txtShellcode.Multiline = true;
            this.txtShellcode.Name = "txtShellcode";
            this.txtShellcode.Size = new System.Drawing.Size(655, 173);
            this.txtShellcode.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(592, 226);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Executar";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // cbBreakpoint
            // 
            this.cbBreakpoint.AutoSize = true;
            this.cbBreakpoint.Location = new System.Drawing.Point(351, 230);
            this.cbBreakpoint.Name = "cbBreakpoint";
            this.cbBreakpoint.Size = new System.Drawing.Size(235, 17);
            this.cbBreakpoint.TabIndex = 3;
            this.cbBreakpoint.Text = "Adicionar um Breakpoint antes do Shellcode";
            this.cbBreakpoint.UseVisualStyleBackColor = true;
            // 
            // sbStatus
            // 
            this.sbStatus.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.sbStatus.Location = new System.Drawing.Point(0, 276);
            this.sbStatus.Name = "sbStatus";
            this.sbStatus.Size = new System.Drawing.Size(679, 22);
            this.sbStatus.TabIndex = 4;
            this.sbStatus.Text = "statusStrip1";
            // 
            // cbAlighStack
            // 
            this.cbAlighStack.AutoSize = true;
            this.cbAlighStack.Location = new System.Drawing.Point(351, 254);
            this.cbAlighStack.Name = "cbAlighStack";
            this.cbAlighStack.Size = new System.Drawing.Size(105, 17);
            this.cbAlighStack.TabIndex = 5;
            this.cbAlighStack.Text = "Realinhar a pilha";
            this.cbAlighStack.UseVisualStyleBackColor = true;
            // 
            // rb32Bits
            // 
            this.rb32Bits.AutoSize = true;
            this.rb32Bits.Checked = true;
            this.rb32Bits.Location = new System.Drawing.Point(205, 230);
            this.rb32Bits.Name = "rb32Bits";
            this.rb32Bits.Size = new System.Drawing.Size(57, 17);
            this.rb32Bits.TabIndex = 6;
            this.rb32Bits.TabStop = true;
            this.rb32Bits.Text = "32 Bits";
            this.rb32Bits.UseVisualStyleBackColor = true;
            // 
            // rb64Bits
            // 
            this.rb64Bits.AutoSize = true;
            this.rb64Bits.Location = new System.Drawing.Point(205, 254);
            this.rb64Bits.Name = "rb64Bits";
            this.rb64Bits.Size = new System.Drawing.Size(56, 17);
            this.rb64Bits.TabIndex = 7;
            this.rb64Bits.Text = "64 bits";
            this.rb64Bits.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Arquitetura";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fileToolStripMenuItem.Text = "Arquivo";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Abrir";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 298);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb64Bits);
            this.Controls.Add(this.rb32Bits);
            this.Controls.Add(this.cbAlighStack);
            this.Controls.Add(this.sbStatus);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cbBreakpoint);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtShellcode);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShellcode;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.CheckBox cbBreakpoint;
        private System.Windows.Forms.StatusStrip sbStatus;
        private System.Windows.Forms.CheckBox cbAlighStack;
        private System.Windows.Forms.RadioButton rb32Bits;
        private System.Windows.Forms.RadioButton rb64Bits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

