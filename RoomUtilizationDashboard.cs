using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;

namespace LakeridgeCommunityHospital
{
	public partial class RoomUtilizationDashboard : MaterialForm
	{
		
		public RoomUtilizationDashboard()
		{
			InitializeComponent();

			var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo400, Primary.Indigo700, Primary.Indigo200, Accent.LightBlue200, TextShade.WHITE);



		}

		#region Singleton Pattern
		// Singleton Pattern
		/// <summary>
		/// variable for form instance
		/// </summary>
		private static RoomUtilizationDashboard roomInstance;
		/// <summary>
		/// Method for form to get current instance of form (aka null or new)
		/// </summary>
		public static RoomUtilizationDashboard Instance
		{
			get
			{
				if (roomInstance == null)
				{
					roomInstance = new RoomUtilizationDashboard();
				}
				else
				{
					//nothing
				}
				return roomInstance;
			}
		}
		#endregion



		//private void FillDVG()
		//{

		//}

		private void RoomUtilizationDashboard_Load(object sender, EventArgs e)
		{
			try
			{
				//string connection = "Data Source=KUROMATSU-MSI\\SQLEXPRESS;Initial Catalog=LakeRidgeHospital;Integrated Security=True;Context Connection=False";

				//String sqlStatement = "SELECT r.ROOM_NUMBER , r.ROOM_TYPE, b.BED_CHAR FROM ROOM r , BED b ";
				//SqlConnection cn = new SqlConnection(connection);
				////cn.Open();
				//SqlCommand command = new SqlCommand(sqlStatement, cn);
				//SqlDataAdapter thisAdapter = new SqlDataAdapter(command);

				//DataTable data = new DataTable("Temp Data Query");
				//thisAdapter.Fill(data);
				//dataGridView1.DataSource = data.DefaultView;

				////cn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
