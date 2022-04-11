using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Data.Sql;
using System.Web.UI.Design.WebControls;


namespace LakeridgeCommunityHospital
{
	public partial class Form1 : MaterialForm
	{
		public Form1()
		{
			InitializeComponent();
			

		 	var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo400, Primary.Indigo700, Primary.Indigo200, Accent.LightBlue200, TextShade.WHITE);


			// string connection = @"Data Source=KUROMATSU-MSI\\SQLEXPRESS;Initial Catalog=LakeRidgeHospital;Integrated Security=True;Context Connection=False";
		}


		private void LoadNoteSelected()
		{
			//string connection = @"Data Source=KUROMATSU-MSI\\SQLEXPRESS;Initial Catalog=LakeRidgeHospital;Integrated Security=True;Context Connection=False";
			//String sqlStatement = "Select Entry FROM NOTE Where ADMISSION_NUMBER = '1000000'";
			//SqlConnection cn = new SqlConnection(connection);
			//cn.Open();
			//SqlCommand command = new SqlCommand(sqlStatement, cn);
			//SqlDataAdapter thisAdapter = new SqlDataAdapter(command);
			//DataTable data = new DataTable("one note");
			//thisAdapter.Fill(data);
			//mtlTextBoxNoteSelect.Text = data.DefaultView.ToString();


			//cn.Close();
			richTextBox1.Text = @"This note is to confirm that Baker, Mary A, she is suffering from allergies and I recommend you to allow her to discontinue classes for two months.";

			//richTextBox1.Text;
		}

		private void GenerateNoteView(object sender, EventArgs e)
		{
			
			string connection = @"Data Source=KUROMATSU-MSI\SQLEXPRESS;Initial Catalog=LakeRidgeHospital;Integrated Security=True;Context Connection=False";
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
				string connection = "Data Source=KUROMATSU-MSI\\SQLEXPRESS;Initial Catalog=LakeRidgeHospital;Integrated Security=True;Context Connection=False";

				String sqlStatement = "SELECT p.Patient_Name, ap.TIME, a.DATE_DISCHARGED, a.ADMISSION_NUMBER FROM ADMISSION a, Patient p, Appointment ap WHERE p.Patient_Number = a.Patient_Number ";
						SqlConnection cn = new SqlConnection(connection);
						cn.Open();
				SqlCommand command = new SqlCommand(sqlStatement, cn);
						SqlDataAdapter thisAdapter = new SqlDataAdapter(command);

						DataTable data = new DataTable("Temp Data Query");
						thisAdapter.Fill(data);
						dvgPatientListTable.DataSource = data.DefaultView;

						cn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		

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

	}
}