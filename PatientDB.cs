using System;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace LakeridgeCommunityHospital
{
	internal class PatientDB
	{
		#region DVG DATA

		

		/// <summary>
		/// List for a collection of patients
		/// </summary>
		public static List<PatientDB> patientsList = new List<PatientDB>();

		public PatientDB()
		{
			PatientDB patientDB = this;
			patientDB.PatientNumber = patientDB.ToString();
			patientDB.PatientName = patientDB.ToString();
			patientDB.AppTime = patientDB.ToString();
			patientDB.DateDischarge = patientDB.ToString();
			patientDB.AdmiNum = patientDB.ToString();
		}

		public PatientDB(string patientNumber, string patientName, string appTime, string dateDischarge, string admiNum)
		{
			PatientNumber = patientNumber;
			PatientName = patientName;
			AppTime = appTime;
			DateDischarge = dateDischarge;
			AdmiNum = admiNum;
		}
		/// <summary>
		/// Variables for getting data for DVG on PhysicianDashboard
		/// </summary>
		public string PatientNumber { get; set; }
		public string PatientName { get; set; }
		public string AppTime { get; set; }
		public string DateDischarge { get; set; }
		public string AdmiNum { get; set; }

		#endregion

		#region SQL
		
		/// <summary>
		/// Method for connection string
		/// </summary>
		/// <returns></returns>
		private static string GetConnectionString()
		{
			string returnValue = null;

			// Look for myConnectionString in the connectionStrings section.
			ConnectionStringSettings myConnectionString = ConfigurationManager.ConnectionStrings[1];

			//// If found, return the connection string.
			if (true)
				returnValue = myConnectionString.ConnectionString;

			//YEY CONNECTION!
			return returnValue;
		}
		#endregion

#region PHYSICIAN DASHBOARD MEDTHODS

		/// <summary>
		/// Method for obtaining patient's number from patient object
		/// </summary>
		/// <param name="patient"></param>
		/// <returns></returns>
		public static int GetPatientNumber(PatientDB patient)
		{
			int number = 0;
			number = Convert.ToInt32(patient.PatientNumber);

			return number;
		}

		/// <summary>
		/// Method for adding patients to a list object
		/// </summary>
		/// <returns></returns>
		public static List<PatientDB> GetPatientListData()
		{
			List<PatientDB> patients = new List<PatientDB>();
			string connectionStr = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
			SqlConnection connection = new SqlConnection(connectionStr);
			connection.Open();
			string sqlStatement = "SELECT p.Patient_Name, ap.TIME, a.DATE_DISCHARGED, a.ADMISSION_NUMBER FROM LakeRidgeHospital.dbo.ADMISSION a, LakeRidgeHospital.dbo.PatientDB p, LakeRidgeHospital.dbo.Appointment ap WHERE p.Patient_Number = a.Patient_Number ";
			SqlCommand command = new SqlCommand(sqlStatement, connection);
			SqlDataReader reader = command.ExecuteReader(CommandBehavior.SequentialAccess);
			while (reader.Read())
			{
				PatientDB patient = new PatientDB();	
				patient.PatientNumber = reader["Patient_Number"].ToString();
				patient.PatientName = reader["Patient_Name"].ToString();
				patient.AppTime = reader["TIME"].ToString();
				patient.DateDischarge = reader["DATE_DISCHARGED"].ToString();
				patient.AdmiNum = reader["ADMISSION_NUMBER"].ToString();
				//add retreived patient to list
				patients.Add(patient);
			}

			return patients;
		}

		/// <summary>
		/// Method for inserting new note entry
		/// for patient
		/// </summary>
		/// <param name="admissionNum"></param>
		/// <param name="note"></param>
		public static void SetPatientNote(int admissionNum, RichTextBox note)
		{
			string newNote = note.ToString();
			string insertNote = @"INSERT INTO LakeRidgeHospital.dbo.NOTE (ADMISSION_NUMBER, ENTRY) VALUES" + admissionNum + "," + newNote + ")";
			string connection = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
			// set a variable for current patient viewed & get  admission number
			SqlConnection cn = new SqlConnection(connection);
			cn.Open();
			SqlCommand command = new SqlCommand(insertNote, cn);
			command.ExecuteNonQuery();
			cn.Close();

		}


		public static void GetPatientDetails(int patientNumber)
		{
			//string sqlStatement = "Select p.* , f.Provider, a.Date_admitted, a.Date_Discharged, a.Room_Number, a.Bed_Char  " +
			//    "From  Patient p , Admission a ,Financial_Status f " +
			//    "Where "
		}


		public static void GetPatientNote(string admissionNumber)
		{
			string connection = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
			string sqlStatement = "Select  a.DATE_ADMITTED,n.Entry  FROM LakeRidgeHospital.dbo.NOTE n , LakeRidgeHospital.dbo.ADMISSION a WHERE n.ADMISSION_Number = a." + admissionNumber + ";";
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


#endregion







	}
}