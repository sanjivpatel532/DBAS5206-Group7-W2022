
namespace LakeridgeCommunityHospital
{
	partial class RoomUtilizationDashboard
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gbxRoomStats = new System.Windows.Forms.GroupBox();
            this.btnAssignRoom = new MaterialSkin.Controls.MaterialButton();
            this.btnDischargeRoom = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedChar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsOccupied = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DateFree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 809);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1156, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gbxRoomStats
            // 
            this.gbxRoomStats.Location = new System.Drawing.Point(684, 89);
            this.gbxRoomStats.Name = "gbxRoomStats";
            this.gbxRoomStats.Size = new System.Drawing.Size(405, 475);
            this.gbxRoomStats.TabIndex = 2;
            this.gbxRoomStats.TabStop = false;
            this.gbxRoomStats.Text = "Room Statistics";
            this.gbxRoomStats.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAssignRoom
            // 
            this.btnAssignRoom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAssignRoom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAssignRoom.Depth = 0;
            this.btnAssignRoom.HighEmphasis = true;
            this.btnAssignRoom.Icon = null;
            this.btnAssignRoom.Location = new System.Drawing.Point(987, 624);
            this.btnAssignRoom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAssignRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAssignRoom.Name = "btnAssignRoom";
            this.btnAssignRoom.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAssignRoom.Size = new System.Drawing.Size(119, 36);
            this.btnAssignRoom.TabIndex = 3;
            this.btnAssignRoom.Text = "Assign Room";
            this.btnAssignRoom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAssignRoom.UseAccentColor = false;
            this.btnAssignRoom.UseVisualStyleBackColor = true;
            // 
            // btnDischargeRoom
            // 
            this.btnDischargeRoom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDischargeRoom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDischargeRoom.Depth = 0;
            this.btnDischargeRoom.HighEmphasis = true;
            this.btnDischargeRoom.Icon = null;
            this.btnDischargeRoom.Location = new System.Drawing.Point(818, 624);
            this.btnDischargeRoom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDischargeRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDischargeRoom.Name = "btnDischargeRoom";
            this.btnDischargeRoom.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDischargeRoom.Size = new System.Drawing.Size(148, 36);
            this.btnDischargeRoom.TabIndex = 4;
            this.btnDischargeRoom.Text = "Discharge Room";
            this.btnDischargeRoom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDischargeRoom.UseAccentColor = false;
            this.btnDischargeRoom.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumber,
            this.BedChar,
            this.RoomType,
            this.IsOccupied,
            this.DateFree});
            this.dataGridView1.Location = new System.Drawing.Point(15, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 465);
            this.dataGridView1.TabIndex = 0;
            // 
            // RoomNumber
            // 
            this.RoomNumber.HeaderText = "Room #";
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.ReadOnly = true;
            this.RoomNumber.Width = 150;
            // 
            // BedChar
            // 
            this.BedChar.HeaderText = "Bed";
            this.BedChar.Name = "BedChar";
            this.BedChar.ReadOnly = true;
            this.BedChar.Width = 120;
            // 
            // RoomType
            // 
            this.RoomType.HeaderText = "Room Type";
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            // 
            // IsOccupied
            // 
            this.IsOccupied.HeaderText = "Is Occupied";
            this.IsOccupied.Name = "IsOccupied";
            this.IsOccupied.ReadOnly = true;
            // 
            // DateFree
            // 
            this.DateFree.HeaderText = "Discharge Date";
            this.DateFree.Name = "DateFree";
            this.DateFree.ReadOnly = true;
            this.DateFree.Width = 150;
            // 
            // RoomUtilizationDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 834);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDischargeRoom);
            this.Controls.Add(this.btnAssignRoom);
            this.Controls.Add(this.gbxRoomStats);
            this.Controls.Add(this.statusStrip1);
            this.Name = "RoomUtilizationDashboard";
            this.Text = "Room Utilization Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.GroupBox gbxRoomStats;
        private MaterialSkin.Controls.MaterialButton btnAssignRoom;
        private MaterialSkin.Controls.MaterialButton btnDischargeRoom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedChar;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsOccupied;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFree;
    }
}