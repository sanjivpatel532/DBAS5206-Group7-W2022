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
using Microsoft.EntityFrameworkCore.Query;

namespace LakeridgeCommunityHospital
{
	public partial class Form1 : MaterialForm
	{

		private LakeridgeCommunityHospitalContext context = new LakeridgeCommunityHospitalContext();
		public Form1()
		{
			InitializeComponent();

			var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo400, Primary.Indigo700, Primary.Indigo200, Accent.LightBlue200, TextShade.WHITE);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			using (context)
			{
				var addmitted = context.ADMISSIONs;
				var allPatients = context.PATIENTs;
				var notes = context.NOTEs;
				var treatments = context.TREATMENTs;
				var diagnosis = context.DIAGNOSIS;



			}
		}


		private void LoadPatientData()
		{
			dvgPatientListTable.Columns.Clear();
			
		}

		private void LoadNoteSelected()
		{
			
		}

		private void GenerateNoteView(object sender, EventArgs e)
		{
			//context.Database.SqlQuery("");
			//string noteView = "";

			
		}
	}
}
