namespace TheMoneyDrop
{
  partial class MoneydropView
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.btnVallen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVallen
            // 
            this.btnVallen.Location = new System.Drawing.Point(107, 197);
            this.btnVallen.Name = "btnVallen";
            this.btnVallen.Size = new System.Drawing.Size(75, 23);
            this.btnVallen.TabIndex = 0;
            this.btnVallen.Text = "Vallen";
            this.btnVallen.UseVisualStyleBackColor = true;
            // 
            // MoneydropView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVallen);
            this.Name = "MoneydropView";
            this.Size = new System.Drawing.Size(286, 252);
            this.Load += new System.EventHandler(this.MoneydropView_Load);
            this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Button btnVallen;
    }
}
