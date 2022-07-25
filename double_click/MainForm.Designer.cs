
namespace double_click
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
            // this.buttonTryDoubleClick = new System.Windows.Forms.Button();
            this.buttonTryDoubleClick = new double_click.ButtonWithDoubleClick();
            this.SuspendLayout();
            // 
            // buttonTryDoubleClick
            // 
            this.buttonTryDoubleClick.Location = new System.Drawing.Point(35, 65);
            this.buttonTryDoubleClick.Name = "buttonTryDoubleClick";
            this.buttonTryDoubleClick.Size = new System.Drawing.Size(180, 34);
            this.buttonTryDoubleClick.TabIndex = 0;
            this.buttonTryDoubleClick.Text = "Double-Click Me";
            this.buttonTryDoubleClick.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.buttonTryDoubleClick);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        // private System.Windows.Forms.Button buttonTryDoubleClick; 
        private double_click.ButtonWithDoubleClick buttonTryDoubleClick;
    }
}

