namespace CrudMVP.Views
{
  partial class FormPetView
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
      this.LabelHeader = new System.Windows.Forms.Label();
      this.PanelHeader = new System.Windows.Forms.Panel();
      this.BtnClose = new System.Windows.Forms.Button();
      this.TabControlPet = new System.Windows.Forms.TabControl();
      this.TabPagePetDetail = new System.Windows.Forms.TabPage();
      this.BtnCancel = new System.Windows.Forms.Button();
      this.BtnSave = new System.Windows.Forms.Button();
      this.TxtBoxPetColour = new System.Windows.Forms.TextBox();
      this.LabelPetColour = new System.Windows.Forms.Label();
      this.TxtBoxPetType = new System.Windows.Forms.TextBox();
      this.LabelPetType = new System.Windows.Forms.Label();
      this.TxtBoxPetName = new System.Windows.Forms.TextBox();
      this.LabelPetName = new System.Windows.Forms.Label();
      this.TxtBoxPetID = new System.Windows.Forms.TextBox();
      this.LabelPetID = new System.Windows.Forms.Label();
      this.TabPagePetList = new System.Windows.Forms.TabPage();
      this.BtnSearch = new System.Windows.Forms.Button();
      this.BtnDelete = new System.Windows.Forms.Button();
      this.BtnEdit = new System.Windows.Forms.Button();
      this.BtnAdd = new System.Windows.Forms.Button();
      this.DgvPet = new System.Windows.Forms.DataGridView();
      this.TxtBoxSearch = new System.Windows.Forms.TextBox();
      this.LabelSearchPet = new System.Windows.Forms.Label();
      this.PanelHeader.SuspendLayout();
      this.TabControlPet.SuspendLayout();
      this.TabPagePetDetail.SuspendLayout();
      this.TabPagePetList.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DgvPet)).BeginInit();
      this.SuspendLayout();
      // 
      // LabelHeader
      // 
      this.LabelHeader.AutoSize = true;
      this.LabelHeader.Location = new System.Drawing.Point(12, 9);
      this.LabelHeader.Margin = new System.Windows.Forms.Padding(0);
      this.LabelHeader.Name = "LabelHeader";
      this.LabelHeader.Size = new System.Drawing.Size(41, 20);
      this.LabelHeader.TabIndex = 0;
      this.LabelHeader.Text = "PETS";
      // 
      // PanelHeader
      // 
      this.PanelHeader.Controls.Add(this.BtnClose);
      this.PanelHeader.Controls.Add(this.LabelHeader);
      this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.PanelHeader.Location = new System.Drawing.Point(0, 0);
      this.PanelHeader.Margin = new System.Windows.Forms.Padding(0);
      this.PanelHeader.Name = "PanelHeader";
      this.PanelHeader.Size = new System.Drawing.Size(800, 40);
      this.PanelHeader.TabIndex = 1;
      // 
      // BtnClose
      // 
      this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnClose.Location = new System.Drawing.Point(697, 9);
      this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
      this.BtnClose.Name = "BtnClose";
      this.BtnClose.Size = new System.Drawing.Size(94, 29);
      this.BtnClose.TabIndex = 4;
      this.BtnClose.Text = "Close";
      this.BtnClose.UseVisualStyleBackColor = true;
      // 
      // TabControlPet
      // 
      this.TabControlPet.Controls.Add(this.TabPagePetDetail);
      this.TabControlPet.Controls.Add(this.TabPagePetList);
      this.TabControlPet.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TabControlPet.Location = new System.Drawing.Point(0, 40);
      this.TabControlPet.Margin = new System.Windows.Forms.Padding(0);
      this.TabControlPet.Name = "TabControlPet";
      this.TabControlPet.SelectedIndex = 0;
      this.TabControlPet.Size = new System.Drawing.Size(800, 513);
      this.TabControlPet.TabIndex = 2;
      // 
      // TabPagePetDetail
      // 
      this.TabPagePetDetail.Controls.Add(this.BtnCancel);
      this.TabPagePetDetail.Controls.Add(this.BtnSave);
      this.TabPagePetDetail.Controls.Add(this.TxtBoxPetColour);
      this.TabPagePetDetail.Controls.Add(this.LabelPetColour);
      this.TabPagePetDetail.Controls.Add(this.TxtBoxPetType);
      this.TabPagePetDetail.Controls.Add(this.LabelPetType);
      this.TabPagePetDetail.Controls.Add(this.TxtBoxPetName);
      this.TabPagePetDetail.Controls.Add(this.LabelPetName);
      this.TabPagePetDetail.Controls.Add(this.TxtBoxPetID);
      this.TabPagePetDetail.Controls.Add(this.LabelPetID);
      this.TabPagePetDetail.Location = new System.Drawing.Point(4, 29);
      this.TabPagePetDetail.Margin = new System.Windows.Forms.Padding(0);
      this.TabPagePetDetail.Name = "TabPagePetDetail";
      this.TabPagePetDetail.Size = new System.Drawing.Size(792, 480);
      this.TabPagePetDetail.TabIndex = 0;
      this.TabPagePetDetail.Text = "Pet detail";
      this.TabPagePetDetail.UseVisualStyleBackColor = true;
      // 
      // BtnCancel
      // 
      this.BtnCancel.Location = new System.Drawing.Point(184, 281);
      this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
      this.BtnCancel.Name = "BtnCancel";
      this.BtnCancel.Size = new System.Drawing.Size(125, 29);
      this.BtnCancel.TabIndex = 9;
      this.BtnCancel.Text = "Cancel";
      this.BtnCancel.UseVisualStyleBackColor = true;
      // 
      // BtnSave
      // 
      this.BtnSave.Location = new System.Drawing.Point(43, 281);
      this.BtnSave.Margin = new System.Windows.Forms.Padding(0);
      this.BtnSave.Name = "BtnSave";
      this.BtnSave.Size = new System.Drawing.Size(125, 29);
      this.BtnSave.TabIndex = 8;
      this.BtnSave.Text = "Save";
      this.BtnSave.UseVisualStyleBackColor = true;
      // 
      // TxtBoxPetColour
      // 
      this.TxtBoxPetColour.Location = new System.Drawing.Point(43, 218);
      this.TxtBoxPetColour.Margin = new System.Windows.Forms.Padding(0);
      this.TxtBoxPetColour.Name = "TxtBoxPetColour";
      this.TxtBoxPetColour.Size = new System.Drawing.Size(266, 27);
      this.TxtBoxPetColour.TabIndex = 7;
      // 
      // LabelPetColour
      // 
      this.LabelPetColour.AutoSize = true;
      this.LabelPetColour.Location = new System.Drawing.Point(40, 192);
      this.LabelPetColour.Margin = new System.Windows.Forms.Padding(0);
      this.LabelPetColour.Name = "LabelPetColour";
      this.LabelPetColour.Size = new System.Drawing.Size(78, 20);
      this.LabelPetColour.TabIndex = 6;
      this.LabelPetColour.Text = "Pet colour:";
      // 
      // TxtBoxPetType
      // 
      this.TxtBoxPetType.Location = new System.Drawing.Point(184, 136);
      this.TxtBoxPetType.Margin = new System.Windows.Forms.Padding(0);
      this.TxtBoxPetType.Name = "TxtBoxPetType";
      this.TxtBoxPetType.Size = new System.Drawing.Size(125, 27);
      this.TxtBoxPetType.TabIndex = 5;
      // 
      // LabelPetType
      // 
      this.LabelPetType.AutoSize = true;
      this.LabelPetType.Location = new System.Drawing.Point(181, 110);
      this.LabelPetType.Margin = new System.Windows.Forms.Padding(0);
      this.LabelPetType.Name = "LabelPetType";
      this.LabelPetType.Size = new System.Drawing.Size(65, 20);
      this.LabelPetType.TabIndex = 4;
      this.LabelPetType.Text = "Pet type:";
      // 
      // TxtBoxPetName
      // 
      this.TxtBoxPetName.Location = new System.Drawing.Point(43, 136);
      this.TxtBoxPetName.Margin = new System.Windows.Forms.Padding(0);
      this.TxtBoxPetName.Name = "TxtBoxPetName";
      this.TxtBoxPetName.Size = new System.Drawing.Size(125, 27);
      this.TxtBoxPetName.TabIndex = 3;
      // 
      // LabelPetName
      // 
      this.LabelPetName.AutoSize = true;
      this.LabelPetName.Location = new System.Drawing.Point(40, 110);
      this.LabelPetName.Margin = new System.Windows.Forms.Padding(0);
      this.LabelPetName.Name = "LabelPetName";
      this.LabelPetName.Size = new System.Drawing.Size(73, 20);
      this.LabelPetName.TabIndex = 2;
      this.LabelPetName.Text = "Pet name:";
      // 
      // TxtBoxPetID
      // 
      this.TxtBoxPetID.Location = new System.Drawing.Point(43, 64);
      this.TxtBoxPetID.Margin = new System.Windows.Forms.Padding(0);
      this.TxtBoxPetID.Name = "TxtBoxPetID";
      this.TxtBoxPetID.ReadOnly = true;
      this.TxtBoxPetID.Size = new System.Drawing.Size(125, 27);
      this.TxtBoxPetID.TabIndex = 1;
      this.TxtBoxPetID.Text = "0";
      // 
      // LabelPetID
      // 
      this.LabelPetID.AutoSize = true;
      this.LabelPetID.Location = new System.Drawing.Point(40, 38);
      this.LabelPetID.Margin = new System.Windows.Forms.Padding(0);
      this.LabelPetID.Name = "LabelPetID";
      this.LabelPetID.Size = new System.Drawing.Size(51, 20);
      this.LabelPetID.TabIndex = 0;
      this.LabelPetID.Text = "Pet ID:";
      // 
      // TabPagePetList
      // 
      this.TabPagePetList.Controls.Add(this.BtnSearch);
      this.TabPagePetList.Controls.Add(this.BtnDelete);
      this.TabPagePetList.Controls.Add(this.BtnEdit);
      this.TabPagePetList.Controls.Add(this.BtnAdd);
      this.TabPagePetList.Controls.Add(this.DgvPet);
      this.TabPagePetList.Controls.Add(this.TxtBoxSearch);
      this.TabPagePetList.Controls.Add(this.LabelSearchPet);
      this.TabPagePetList.Location = new System.Drawing.Point(4, 29);
      this.TabPagePetList.Margin = new System.Windows.Forms.Padding(0);
      this.TabPagePetList.Name = "TabPagePetList";
      this.TabPagePetList.Size = new System.Drawing.Size(792, 480);
      this.TabPagePetList.TabIndex = 1;
      this.TabPagePetList.Text = "Pet list";
      this.TabPagePetList.UseVisualStyleBackColor = true;
      // 
      // BtnSearch
      // 
      this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnSearch.Location = new System.Drawing.Point(593, 23);
      this.BtnSearch.Margin = new System.Windows.Forms.Padding(0);
      this.BtnSearch.Name = "BtnSearch";
      this.BtnSearch.Size = new System.Drawing.Size(94, 27);
      this.BtnSearch.TabIndex = 6;
      this.BtnSearch.Text = "Search";
      this.BtnSearch.UseVisualStyleBackColor = true;
      // 
      // BtnDelete
      // 
      this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnDelete.Location = new System.Drawing.Point(693, 126);
      this.BtnDelete.Margin = new System.Windows.Forms.Padding(0);
      this.BtnDelete.Name = "BtnDelete";
      this.BtnDelete.Size = new System.Drawing.Size(94, 29);
      this.BtnDelete.TabIndex = 5;
      this.BtnDelete.Text = "Delete";
      this.BtnDelete.UseVisualStyleBackColor = true;
      // 
      // BtnEdit
      // 
      this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnEdit.Location = new System.Drawing.Point(693, 91);
      this.BtnEdit.Margin = new System.Windows.Forms.Padding(0);
      this.BtnEdit.Name = "BtnEdit";
      this.BtnEdit.Size = new System.Drawing.Size(94, 29);
      this.BtnEdit.TabIndex = 4;
      this.BtnEdit.Text = "Edit";
      this.BtnEdit.UseVisualStyleBackColor = true;
      // 
      // BtnAdd
      // 
      this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnAdd.Location = new System.Drawing.Point(693, 56);
      this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
      this.BtnAdd.Name = "BtnAdd";
      this.BtnAdd.Size = new System.Drawing.Size(94, 29);
      this.BtnAdd.TabIndex = 3;
      this.BtnAdd.Text = "Add new";
      this.BtnAdd.UseVisualStyleBackColor = true;
      // 
      // DgvPet
      // 
      this.DgvPet.AllowUserToAddRows = false;
      this.DgvPet.AllowUserToDeleteRows = false;
      this.DgvPet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.DgvPet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.DgvPet.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.DgvPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DgvPet.Location = new System.Drawing.Point(0, 56);
      this.DgvPet.Margin = new System.Windows.Forms.Padding(0);
      this.DgvPet.MultiSelect = false;
      this.DgvPet.Name = "DgvPet";
      this.DgvPet.ReadOnly = true;
      this.DgvPet.RowHeadersWidth = 51;
      this.DgvPet.RowTemplate.Height = 29;
      this.DgvPet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.DgvPet.Size = new System.Drawing.Size(687, 424);
      this.DgvPet.TabIndex = 2;
      // 
      // TxtBoxSearch
      // 
      this.TxtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.TxtBoxSearch.Location = new System.Drawing.Point(0, 23);
      this.TxtBoxSearch.Margin = new System.Windows.Forms.Padding(0);
      this.TxtBoxSearch.Name = "TxtBoxSearch";
      this.TxtBoxSearch.Size = new System.Drawing.Size(587, 27);
      this.TxtBoxSearch.TabIndex = 1;
      // 
      // LabelSearchPet
      // 
      this.LabelSearchPet.AutoSize = true;
      this.LabelSearchPet.Location = new System.Drawing.Point(0, 0);
      this.LabelSearchPet.Margin = new System.Windows.Forms.Padding(0);
      this.LabelSearchPet.Name = "LabelSearchPet";
      this.LabelSearchPet.Size = new System.Drawing.Size(207, 20);
      this.LabelSearchPet.TabIndex = 0;
      this.LabelSearchPet.Text = "Search pet by ID or Pet Name:";
      // 
      // FormPetView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 553);
      this.Controls.Add(this.TabControlPet);
      this.Controls.Add(this.PanelHeader);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "FormPetView";
      this.Text = "Pet Store";
      this.PanelHeader.ResumeLayout(false);
      this.PanelHeader.PerformLayout();
      this.TabControlPet.ResumeLayout(false);
      this.TabPagePetDetail.ResumeLayout(false);
      this.TabPagePetDetail.PerformLayout();
      this.TabPagePetList.ResumeLayout(false);
      this.TabPagePetList.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DgvPet)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Label LabelHeader;
    private Panel PanelHeader;
    private TabControl TabControlPet;
    private TabPage TabPagePetDetail;
    private TabPage TabPagePetList;
    private Button BtnSearch;
    private Button BtnDelete;
    private Button BtnEdit;
    private Button BtnAdd;
    private DataGridView DgvPet;
    private TextBox TxtBoxSearch;
    private Label LabelSearchPet;
    private Button BtnCancel;
    private Button BtnSave;
    private TextBox TxtBoxPetColour;
    private Label LabelPetColour;
    private TextBox TxtBoxPetType;
    private Label LabelPetType;
    private TextBox TxtBoxPetName;
    private Label LabelPetName;
    private TextBox TxtBoxPetID;
    private Label LabelPetID;
    private Button BtnClose;
  }
}