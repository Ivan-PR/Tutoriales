namespace OpenWebinarsForms
{
    partial class Form2
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
            if (disposing&&(components!=null))
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
            this.buttonExtended1 = new OpenWebinarsForms.ButtonExtended();
            this.customUserControl1 = new OpenWebinarsForms.CustomUserControl();
            this.SuspendLayout();
            // 
            // buttonExtended1
            // 
            this.buttonExtended1.Location = new System.Drawing.Point(35, 86);
            this.buttonExtended1.Name = "buttonExtended1";
            this.buttonExtended1.Size = new System.Drawing.Size(117, 51);
            this.buttonExtended1.TabIndex = 1;
            this.buttonExtended1.Text = "buttonExtended1";
            this.buttonExtended1.UseVisualStyleBackColor = true;
            // 
            // customUserControl1
            // 
            this.customUserControl1.LabelTitle = "Introducir ubicacion fichero";
            this.customUserControl1.Location = new System.Drawing.Point(12, 12);
            this.customUserControl1.Name = "customUserControl1";
            this.customUserControl1.Size = new System.Drawing.Size(316, 67);
            this.customUserControl1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExtended1);
            this.Controls.Add(this.customUserControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUserControl customUserControl1;
        private ButtonExtended buttonExtended1;
    }
}