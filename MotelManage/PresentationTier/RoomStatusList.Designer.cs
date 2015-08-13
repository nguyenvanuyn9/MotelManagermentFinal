namespace MotelManage.PresentationTier
{
    partial class RoomStatusList
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
            this.gridRoomStatus = new System.Windows.Forms.DataGridView();
            this.btSearch = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoomStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // gridRoomStatus
            // 
            this.gridRoomStatus.AllowUserToAddRows = false;
            this.gridRoomStatus.AllowUserToDeleteRows = false;
            this.gridRoomStatus.AllowUserToResizeColumns = false;
            this.gridRoomStatus.AllowUserToResizeRows = false;
            this.gridRoomStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRoomStatus.Location = new System.Drawing.Point(9, 134);
            this.gridRoomStatus.Margin = new System.Windows.Forms.Padding(2);
            this.gridRoomStatus.Name = "gridRoomStatus";
            this.gridRoomStatus.ReadOnly = true;
            this.gridRoomStatus.RowTemplate.Height = 24;
            this.gridRoomStatus.Size = new System.Drawing.Size(445, 162);
            this.gridRoomStatus.TabIndex = 6;
            this.gridRoomStatus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRoomStatus_CellClick);
            this.gridRoomStatus.SelectionChanged += new System.EventHandler(this.gridRoomStatus_SelectionChanged);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(38, 91);
            this.btSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(76, 27);
            this.btSearch.TabIndex = 2;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(364, 91);
            this.btDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(76, 27);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(149, 91);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(76, 27);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(257, 91);
            this.btEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(76, 27);
            this.btEdit.TabIndex = 4;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(64, 48);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.MaxLength = 100;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(170, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(64, 20);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.MaxLength = 10;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(170, 20);
            this.tbID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Id";
            // 
            // RoomStatusList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 304);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.gridRoomStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomStatusList";
            this.Text = "RoomStatusList";
            this.Load += new System.EventHandler(this.RoomStatusList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRoomStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridRoomStatus;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}