
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbAddNewNote = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddNote = new MaterialSkin.Controls.MaterialButton();
            this.materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.lstBoxColDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPatientDetails = new System.Windows.Forms.GroupBox();
            this.Admittion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admitted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discharged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Appointment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddTreatment = new MaterialSkin.Controls.MaterialButton();
            this.tbxNewNote = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tbAddNewNote.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.lblPatientDetails.SuspendLayout();
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
            this.statusStrip1.Size = new System.Drawing.Size(1490, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Admittion,
            this.Admitted,
            this.Discharged,
            this.Appointment,
            this.Patient});
            this.dataGridView1.GridColor = System.Drawing.Color.Azure;
            this.dataGridView1.Location = new System.Drawing.Point(3, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(769, 303);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbAddNewNote);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.materialListView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(778, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 697);
            this.panel1.TabIndex = 5;
            // 
            // tbAddNewNote
            // 
            this.tbAddNewNote.Controls.Add(this.tabPage1);
            this.tbAddNewNote.Controls.Add(this.tabPage2);
            this.tbAddNewNote.Depth = 0;
            this.tbAddNewNote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbAddNewNote.Location = new System.Drawing.Point(343, 40);
            this.tbAddNewNote.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbAddNewNote.Multiline = true;
            this.tbAddNewNote.Name = "tbAddNewNote";
            this.tbAddNewNote.SelectedIndex = 0;
            this.tbAddNewNote.Size = new System.Drawing.Size(354, 645);
            this.tbAddNewNote.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.materialMultiLineTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(346, 614);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Selected  Note View";
            // 
            // btnAddNote
            // 
            this.btnAddNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNote.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddNote.Depth = 0;
            this.btnAddNote.HighEmphasis = true;
            this.btnAddNote.Icon = null;
            this.btnAddNote.Location = new System.Drawing.Point(138, 596);
            this.btnAddNote.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddNote.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddNote.Size = new System.Drawing.Size(92, 36);
            this.btnAddNote.TabIndex = 2;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddNote.UseAccentColor = false;
            this.btnAddNote.UseVisualStyleBackColor = true;
            // 
            // materialMultiLineTextBox1
            // 
            this.materialMultiLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox1.Depth = 0;
            this.materialMultiLineTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox1.Location = new System.Drawing.Point(9, 6);
            this.materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            this.materialMultiLineTextBox1.Size = new System.Drawing.Size(331, 629);
            this.materialMultiLineTextBox1.TabIndex = 0;
            this.materialMultiLineTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.AllowDrop = true;
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.tbxNewNote);
            this.tabPage2.Controls.Add(this.btnAddNote);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(346, 614);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add New Note";
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
            this.materialListView1.Size = new System.Drawing.Size(324, 635);
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
            // lblPatientDetails
            // 
            this.lblPatientDetails.Controls.Add(this.btnAddTreatment);
            this.lblPatientDetails.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientDetails.Location = new System.Drawing.Point(3, 365);
            this.lblPatientDetails.Name = "lblPatientDetails";
            this.lblPatientDetails.Size = new System.Drawing.Size(769, 407);
            this.lblPatientDetails.TabIndex = 6;
            this.lblPatientDetails.TabStop = false;
            this.lblPatientDetails.Text = "Patient Details";
            this.lblPatientDetails.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Admittion
            // 
            this.Admittion.HeaderText = "Admittion Number";
            this.Admittion.Name = "Admittion";
            // 
            // Admitted
            // 
            this.Admitted.HeaderText = "Admitted ";
            this.Admitted.Name = "Admitted";
            // 
            // Discharged
            // 
            this.Discharged.HeaderText = "Discharged";
            this.Discharged.Name = "Discharged";
            // 
            // Appointment
            // 
            this.Appointment.HeaderText = "Appointment";
            this.Appointment.Name = "Appointment";
            // 
            // Patient
            // 
            this.Patient.HeaderText = "Patient Name";
            this.Patient.Name = "Patient";
            // 
            // btnAddTreatment
            // 
            this.btnAddTreatment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTreatment.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddTreatment.Depth = 0;
            this.btnAddTreatment.HighEmphasis = true;
            this.btnAddTreatment.Icon = null;
            this.btnAddTreatment.Location = new System.Drawing.Point(622, 359);
            this.btnAddTreatment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddTreatment.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddTreatment.Name = "btnAddTreatment";
            this.btnAddTreatment.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddTreatment.Size = new System.Drawing.Size(140, 36);
            this.btnAddTreatment.TabIndex = 8;
            this.btnAddTreatment.Text = "Add Treatment";
            this.btnAddTreatment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddTreatment.UseAccentColor = false;
            this.btnAddTreatment.UseVisualStyleBackColor = true;
            this.btnAddTreatment.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // tbxNewNote
            // 
            this.tbxNewNote.Location = new System.Drawing.Point(6, 3);
            this.tbxNewNote.Name = "tbxNewNote";
            this.tbxNewNote.Size = new System.Drawing.Size(337, 584);
            this.tbxNewNote.TabIndex = 0;
            this.tbxNewNote.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1496, 800);
            this.Controls.Add(this.lblPatientDetails);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lakeridge Community Hospital";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbAddNewNote.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.lblPatientDetails.ResumeLayout(false);
            this.lblPatientDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private MaterialListView materialListView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage tabPage1;
		private MaterialMultiLineTextBox materialMultiLineTextBox1;
		private MaterialButton btnAddNote;
		private System.Windows.Forms.ColumnHeader lstBoxColDate;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.GroupBox lblPatientDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admittion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admitted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discharged;
        private System.Windows.Forms.DataGridViewTextBoxColumn Appointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
        private MaterialButton btnAddTreatment;
        private System.Windows.Forms.RichTextBox tbxNewNote;
        public MaterialTabControl tbAddNewNote;
        public System.Windows.Forms.TabPage tabPage2;
    }
}

