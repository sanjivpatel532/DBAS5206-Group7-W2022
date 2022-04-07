
using System.Runtime.CompilerServices;
using MaterialSkin.Controls;

namespace LakeridgeCommunityHospital
{
	public partial class Form1 : MaterialForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
			this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
			this.materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
			this.lstBoxColDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.materialTabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(3, 775);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1408, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column1});
			this.dataGridView1.GridColor = System.Drawing.Color.Azure;
			this.dataGridView1.Location = new System.Drawing.Point(3, 66);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(449, 403);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Admitted";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Date";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Appointment";
			this.Column4.Name = "Column4";
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Patient ";
			this.Column1.Name = "Column1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.materialTabControl1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.materialListView1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(454, 67);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(954, 705);
			this.panel1.TabIndex = 5;
			// 
			// materialTabControl1
			// 
			this.materialTabControl1.Controls.Add(this.tabPage1);
			this.materialTabControl1.Controls.Add(this.tabPage2);
			this.materialTabControl1.Depth = 0;
			this.materialTabControl1.Location = new System.Drawing.Point(444, 13);
			this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabControl1.Multiline = true;
			this.materialTabControl1.Name = "materialTabControl1";
			this.materialTabControl1.SelectedIndex = 0;
			this.materialTabControl1.Size = new System.Drawing.Size(507, 496);
			this.materialTabControl1.TabIndex = 7;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.tabPage1.Controls.Add(this.materialButton2);
			this.tabPage1.Controls.Add(this.materialButton1);
			this.tabPage1.Controls.Add(this.materialMultiLineTextBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 27);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(499, 465);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Selected  Note View";
			// 
			// materialButton2
			// 
			this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.materialButton2.Depth = 0;
			this.materialButton2.HighEmphasis = true;
			this.materialButton2.Icon = null;
			this.materialButton2.Location = new System.Drawing.Point(291, 411);
			this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialButton2.Name = "materialButton2";
			this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
			this.materialButton2.Size = new System.Drawing.Size(158, 36);
			this.materialButton2.TabIndex = 2;
			this.materialButton2.Text = "materialButton2";
			this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.materialButton2.UseAccentColor = false;
			this.materialButton2.UseVisualStyleBackColor = true;
			// 
			// materialButton1
			// 
			this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.materialButton1.Depth = 0;
			this.materialButton1.HighEmphasis = true;
			this.materialButton1.Icon = null;
			this.materialButton1.Location = new System.Drawing.Point(68, 411);
			this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialButton1.Name = "materialButton1";
			this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
			this.materialButton1.Size = new System.Drawing.Size(158, 36);
			this.materialButton1.TabIndex = 1;
			this.materialButton1.Text = "materialButton1";
			this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.materialButton1.UseAccentColor = false;
			this.materialButton1.UseVisualStyleBackColor = true;
			// 
			// materialMultiLineTextBox1
			// 
			this.materialMultiLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialMultiLineTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.materialMultiLineTextBox1.Depth = 0;
			this.materialMultiLineTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialMultiLineTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialMultiLineTextBox1.Location = new System.Drawing.Point(0, 3);
			this.materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
			this.materialMultiLineTextBox1.Size = new System.Drawing.Size(499, 391);
			this.materialMultiLineTextBox1.TabIndex = 0;
			this.materialMultiLineTextBox1.Text = "";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 27);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(499, 465);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Add New Note";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(589, 13);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(0, 24);
			this.label2.TabIndex = 6;
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// materialListView1
			// 
			this.materialListView1.AutoSizeTable = false;
			this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstBoxColDate,
            this.columnHeader1});
			this.materialListView1.Depth = 0;
			this.materialListView1.FullRowSelect = true;
			this.materialListView1.HideSelection = false;
			this.materialListView1.Location = new System.Drawing.Point(13, 50);
			this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
			this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
			this.materialListView1.Name = "materialListView1";
			this.materialListView1.OwnerDraw = true;
			this.materialListView1.Size = new System.Drawing.Size(425, 635);
			this.materialListView1.TabIndex = 2;
			this.materialListView1.UseCompatibleStateImageBehavior = false;
			this.materialListView1.View = System.Windows.Forms.View.Details;
			// 
			// lstBoxColDate
			// 
			this.lstBoxColDate.Text = "Date Recorded";
			this.lstBoxColDate.Width = 200;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Note Reason";
			this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader1.Width = 200;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(119, 13);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(218, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Patent Record Logs:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(3, 465);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(449, 307);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Appointment Details";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(1414, 800);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lakeridge Community Hospital";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.materialTabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private MaterialListView materialListView1;
		private System.Windows.Forms.Label label2;
		private MaterialTabControl materialTabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private MaterialMultiLineTextBox materialMultiLineTextBox1;
		private MaterialButton materialButton2;
		private MaterialButton materialButton1;
		private System.Windows.Forms.ColumnHeader lstBoxColDate;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

