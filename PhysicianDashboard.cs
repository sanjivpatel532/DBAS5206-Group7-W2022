using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;
using System.IO;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace LakeridgeCommunityHospital
{
	public partial class Form1 : MaterialForm
	{
		private PatientDB _frmPatient = new();
		public Form1()
		{
			InitializeComponent();
			

		 	var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo400, Primary.Indigo700, Primary.Indigo200, Accent.LightBlue200, TextShade.WHITE);

		}


		private void LoadNoteSelected()
		{
			string connection = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
			//String sqlStatement = "Select Entry FROM NOTE Where ADMISSION_NUMBER = '1000000'";
			//SqlConnection cn = new SqlConnection(connection);
			//cn.Open();
			//SqlCommand command = new SqlCommand(sqlStatement, cn);
			//SqlDataAdapter thisAdapter = new SqlDataAdapter(command);
			//DataTable data = new DataTable("one note");
			//thisAdapter.Fill(data);
			//mtlTextBoxNoteSelect.Text = data.DefaultView.ToString();


			//cn.Close();
			rtboxNewNote.Text = @"This note is to confirm that Baker, Mary A, she is suffering from allergies and I recommend you to allow her to discontinue classes for two months.";

			
		}

		private void GenerateNoteView(object sender, EventArgs e)
		{

			string connection = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
			String sqlStatement = "Select  a.DATE_ADMITTED,n.Entry  FROM NOTE n , ADMISSION a WHERE n.ADMISSION_Number = a.ADMISSION_NUMBER";
			SqlConnection cn = new SqlConnection(connection);
			cn.Open();
			SqlCommand command = new SqlCommand(sqlStatement, cn);
			SqlDataAdapter thisAdapter = new SqlDataAdapter(command);
			DataTable data = new DataTable("fill ME");
			thisAdapter.Fill(data);

			for (int i = 0; i < data.Rows.Count; i++)
			{
				DataRow datRow = data.Rows[i];
				ListViewItem datItem = new ListViewItem(datRow["ADMISSION_NUMBER"].ToString());
				datItem.SubItems.Add(datRow["DATE_ADMITTED"].ToString());
				datItem.SubItems.Add(datRow["ENTRY"].ToString());
			}

			cn.Close();
		}

		private void PatientListGenerate(object sender, EventArgs e)
		{
			try
			{
				
				//Use method for calling data from database as a list
				PatientDB.GetPatientListData();

				//Add data to DVG table
				dvgPatientListTable.DataSource	 =  PatientDB.patientsList;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

			frmNewNote_Load(sender, e);
		}
		#region Singleton Pattern
		// Singleton Pattern
		/// <summary>
		/// variable for form instance
		/// </summary>
		private static Form1 paientInstance;
		/// <summary>
		/// Method for form to get current instance of form (aka null or new)
		/// </summary>
		public static Form1 Instance
		{
			get
			{
				if (paientInstance == null)
				{
					paientInstance = new Form1();
					
				}
				else
				{
					//nothing
				}
				return paientInstance;
			}
		}
		#endregion



		#region GLOBAL VARS
		/// <summary>
		/// Method for getting and setting current filename
		/// </summary>
		public string FileNameCurrent { get; set; }

		#endregion


		private void frmNewNote_Load(object sender, EventArgs e)
		{
			//CurrentDocument.Text = rtbCanvas.Text;

			//.Filter = "Text Documents (*.txt)|*.txt";
			// openFileDialog.Filter = "Text Documents (*.txt)|*.txt";
			Document.TextFile.Text = rtboxNewNote.Text;
			Instance.FileNameCurrent = Document.TextFile.FileName;
			SetFileName();
			//SetChangeStatus(false);
		}
		/// <summary>
		/// Sets the file name on the text property of the form.
		/// </summary>
		/// <param name="str"></param>
		private void SetFileName()
		{
			if (Instance.FileNameCurrent == string.Empty)
			{
				this.Text = "Untitled";
			}
			else
			{
				//FilePath = openFileDialog.FileName;
				string thisText = null;
				thisText = Path.GetFileName(FileNameCurrent);
				this.Text = thisText + @"- PatientDB Note";
			}
		}
		///// <summary>
		///// Keeps track of changes in the textbox and counts the characters.
		///// </summary>
		///// <param name="sender"></param>
		///// <param name="e"></param>
		private void rtbCanvas_TextChanged(object sender, EventArgs e)
		{
			Document.TextFile.Text = rtboxNewNote.Text;
			int chars = rtboxNewNote.Text.Length;
			statusChange.Text = @"New note stated";
		}


		/// <summary>
		/// Method to set instance of form, upon close, to null
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmClosed(object sender, FormClosedEventArgs e)
		{
			paientInstance = null;
		}
		/// <summary>
		/// cuts the currently selected text within text editor
		/// </summary>
		public void CutText()
		{
			rtboxNewNote.Cut();
		}
		/// <summary>
		/// Pastes text from clipboard into text editor
		/// </summary>
		public void PasteText()
		{
			rtboxNewNote.Paste();
		}
		/// <summary>
		/// Copies the currently selected text in text editor
		/// </summary>
		public void CopyText()
		{
			rtboxNewNote.Copy();
		}
		/// <summary>
		/// Selects all text within Text editor
		/// </summary>
		public void SelectAllText()
		{
			rtboxNewNote.SelectAll();
		}

		private void AddNoteClick(object sender, EventArgs e)
		{
			PatientDB.GetPatientNumber(_frmPatient);
			PatientDB.SetPatientNote(int.Parse(_frmPatient.AdmiNum), rtboxNewNote );
		}

		private void GetCurrentPatientSelection(object sender, EventArgs e)
		{
			try
			{
				if (dvgPatientListTable.CurrentRow != null)
					_frmPatient = (PatientDB)dvgPatientListTable.CurrentRow.Cells.GetEnumerator();

			}
			catch (NullReferenceException)
			{
				//nothing!
			}
		}
	}
	}
