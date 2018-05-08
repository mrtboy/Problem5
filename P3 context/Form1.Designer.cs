namespace P3_context
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
            this.btnClickMe = new System.Windows.Forms.Button();
            this.cmsButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWigth = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmsForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dupilicateFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMyButton = new System.Windows.Forms.Button();
            this.cmsButton.SuspendLayout();
            this.cmsForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClickMe
            // 
            this.btnClickMe.ContextMenuStrip = this.cmsButton;
            this.btnClickMe.Location = new System.Drawing.Point(317, 141);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(125, 90);
            this.btnClickMe.TabIndex = 0;
            this.btnClickMe.Text = "Click me";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            this.btnClickMe.MouseHover += new System.EventHandler(this.btnClickMe_MouseHover);
            // 
            // cmsButton
            // 
            this.cmsButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorToolStripMenuItem,
            this.changeSizeToolStripMenuItem});
            this.cmsButton.Name = "cmsButton";
            this.cmsButton.Size = new System.Drawing.Size(148, 48);
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.changeColorToolStripMenuItem.Text = "Change Color";
            this.changeColorToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // changeSizeToolStripMenuItem
            // 
            this.changeSizeToolStripMenuItem.Name = "changeSizeToolStripMenuItem";
            this.changeSizeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.changeSizeToolStripMenuItem.Text = "Change Size";
            this.changeSizeToolStripMenuItem.Click += new System.EventHandler(this.changeSizeToolStripMenuItem_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(317, 43);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(125, 20);
            this.txtText.TabIndex = 1;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(561, 220);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(125, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(561, 141);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(125, 20);
            this.txtHeight.TabIndex = 4;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(561, 122);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "Height";
            // 
            // lblWigth
            // 
            this.lblWigth.AutoSize = true;
            this.lblWigth.Location = new System.Drawing.Point(561, 204);
            this.lblWigth.Name = "lblWigth";
            this.lblWigth.Size = new System.Drawing.Size(35, 13);
            this.lblWigth.TabIndex = 6;
            this.lblWigth.Text = "Wight";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(588, 283);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmsForm
            // 
            this.cmsForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dupilicateFormToolStripMenuItem,
            this.controlToolStripMenuItem});
            this.cmsForm.Name = "cmsForm";
            this.cmsForm.Size = new System.Drawing.Size(159, 48);
            // 
            // dupilicateFormToolStripMenuItem
            // 
            this.dupilicateFormToolStripMenuItem.Name = "dupilicateFormToolStripMenuItem";
            this.dupilicateFormToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.dupilicateFormToolStripMenuItem.Text = "Dupilicate Form";
            this.dupilicateFormToolStripMenuItem.Click += new System.EventHandler(this.dupilicateFormToolStripMenuItem_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonToolStripMenuItem,
            this.textboxToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // buttonToolStripMenuItem
            // 
            this.buttonToolStripMenuItem.Name = "buttonToolStripMenuItem";
            this.buttonToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.buttonToolStripMenuItem.Text = "Button";
            this.buttonToolStripMenuItem.Click += new System.EventHandler(this.buttonToolStripMenuItem_Click);
            // 
            // textboxToolStripMenuItem
            // 
            this.textboxToolStripMenuItem.Name = "textboxToolStripMenuItem";
            this.textboxToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.textboxToolStripMenuItem.Text = "Textbox";
            this.textboxToolStripMenuItem.Click += new System.EventHandler(this.textboxToolStripMenuItem_Click);
            // 
            // btnMyButton
            // 
            this.btnMyButton.Location = new System.Drawing.Point(346, 296);
            this.btnMyButton.Name = "btnMyButton";
            this.btnMyButton.Size = new System.Drawing.Size(75, 23);
            this.btnMyButton.TabIndex = 8;
            this.btnMyButton.Text = "MyButton";
            this.btnMyButton.UseVisualStyleBackColor = true;
            this.btnMyButton.Click += new System.EventHandler(this.btnMyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.cmsForm;
            this.Controls.Add(this.btnMyButton);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblWigth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnClickMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.cmsButton.ResumeLayout(false);
            this.cmsForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.ContextMenuStrip cmsButton;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSizeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWigth;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ContextMenuStrip cmsForm;
        private System.Windows.Forms.ToolStripMenuItem dupilicateFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textboxToolStripMenuItem;
        private System.Windows.Forms.Button btnMyButton;
    }
}

