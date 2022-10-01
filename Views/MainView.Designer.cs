namespace CrudMVP.Views
{
  partial class MainView
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
      this.PanelEntities = new System.Windows.Forms.Panel();
      this.BtnOwners = new System.Windows.Forms.Button();
      this.BtnPets = new System.Windows.Forms.Button();
      this.PanelEntities.SuspendLayout();
      this.SuspendLayout();
      // 
      // PanelEntities
      // 
      this.PanelEntities.Controls.Add(this.BtnOwners);
      this.PanelEntities.Controls.Add(this.BtnPets);
      this.PanelEntities.Dock = System.Windows.Forms.DockStyle.Left;
      this.PanelEntities.Location = new System.Drawing.Point(0, 0);
      this.PanelEntities.Margin = new System.Windows.Forms.Padding(0);
      this.PanelEntities.Name = "PanelEntities";
      this.PanelEntities.Size = new System.Drawing.Size(250, 612);
      this.PanelEntities.TabIndex = 0;
      // 
      // BtnOwners
      // 
      this.BtnOwners.AutoSize = true;
      this.BtnOwners.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.BtnOwners.Location = new System.Drawing.Point(0, 143);
      this.BtnOwners.Margin = new System.Windows.Forms.Padding(0);
      this.BtnOwners.Name = "BtnOwners";
      this.BtnOwners.Size = new System.Drawing.Size(250, 38);
      this.BtnOwners.TabIndex = 1;
      this.BtnOwners.Text = "Owners";
      this.BtnOwners.UseVisualStyleBackColor = true;
      this.BtnOwners.Click += new System.EventHandler(this.BtnOwners_Click);
      // 
      // BtnPets
      // 
      this.BtnPets.AutoSize = true;
      this.BtnPets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.BtnPets.Location = new System.Drawing.Point(0, 66);
      this.BtnPets.Margin = new System.Windows.Forms.Padding(0);
      this.BtnPets.Name = "BtnPets";
      this.BtnPets.Size = new System.Drawing.Size(250, 38);
      this.BtnPets.TabIndex = 0;
      this.BtnPets.Text = "Pets";
      this.BtnPets.UseVisualStyleBackColor = true;
      // 
      // MainView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1134, 612);
      this.Controls.Add(this.PanelEntities);
      this.IsMdiContainer = true;
      this.Name = "MainView";
      this.Text = "Main";
      this.PanelEntities.ResumeLayout(false);
      this.PanelEntities.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private Panel PanelEntities;
    private Button BtnPets;
    private Button BtnOwners;
  }
}