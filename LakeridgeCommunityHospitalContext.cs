using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LakeridgeCommunityHospital
{
	public partial class LakeridgeCommunityHospitalContext : DbContext
	{
		public LakeridgeCommunityHospitalContext()
			: base("name=LakeridgeCommunityHospitalContext1")
		{
		}

		public virtual DbSet<ADMISSION> ADMISSIONs { get; set; }
		public virtual DbSet<APPOINTMENT> APPOINTMENTs { get; set; }
		public virtual DbSet<BED> BEDs { get; set; }
		public virtual DbSet<CHARGE> CHARGEs { get; set; }
		public virtual DbSet<CHARGE_TRANSACTION> CHARGE_TRANSACTION { get; set; }
		public virtual DbSet<COST_CENTER> COST_CENTER { get; set; }
		public virtual DbSet<DB_USER> DB_USER { get; set; }
		public virtual DbSet<DIAGNOSI> DIAGNOSIS { get; set; }
		public virtual DbSet<FINANCIAL_STATUS> FINANCIAL_STATUS { get; set; }
		public virtual DbSet<ITEM> ITEMs { get; set; }
		public virtual DbSet<NOTE> NOTEs { get; set; }
		public virtual DbSet<PATIENT> PATIENTs { get; set; }
		public virtual DbSet<PHYSICIAN> PHYSICIANs { get; set; }
		public virtual DbSet<PHYSICIAN_SPECIALTY> PHYSICIAN_SPECIALTY { get; set; }
		public virtual DbSet<ROOM> ROOMs { get; set; }
		public virtual DbSet<ROOM_TYPE> ROOM_TYPE { get; set; }
		public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
		public virtual DbSet<TREATMENT> TREATMENTs { get; set; }
		public virtual DbSet<USER_TYPE> USER_TYPE { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ADMISSION>()
				.Property(e => e.BED_CHAR)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<ADMISSION>()
				.HasMany(e => e.CHARGEs)
				.WithRequired(e => e.ADMISSION)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<ADMISSION>()
				.HasMany(e => e.NOTEs)
				.WithRequired(e => e.ADMISSION)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<ADMISSION>()
				.HasMany(e => e.PATIENTs)
				.WithMany(e => e.ADMISSIONs1)
				.Map(m => m.ToTable("ADMISSION_LINE_ITEM").MapLeftKey("ADMISSION_NUMBER").MapRightKey("PATIENT_NUMBER"));

			modelBuilder.Entity<APPOINTMENT>()
				.Property(e => e.DESCRIPTION)
				.IsUnicode(false);

			modelBuilder.Entity<BED>()
				.Property(e => e.BED_CHAR)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<BED>()
				.HasMany(e => e.ADMISSIONs)
				.WithRequired(e => e.BED)
				.HasForeignKey(e => new { e.ROOM_NUMBER, e.BED_CHAR })
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<CHARGE>()
				.HasMany(e => e.CHARGE_TRANSACTION)
				.WithMany(e => e.CHARGEs)
				.Map(m => m.ToTable("TRANSACTION_LINE_ITEM").MapLeftKey("CHARGE_NUMBER").MapRightKey("TRANSACTION_NUMBER"));

			modelBuilder.Entity<CHARGE_TRANSACTION>()
				.Property(e => e.PAID)
				.HasPrecision(19, 4);

			modelBuilder.Entity<COST_CENTER>()
				.Property(e => e.DEPARTMENT_NAME)
				.IsUnicode(false);

			modelBuilder.Entity<COST_CENTER>()
				.HasMany(e => e.ITEMs)
				.WithRequired(e => e.COST_CENTER)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<DB_USER>()
				.Property(e => e.PASSWORD)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<DB_USER>()
				.HasMany(e => e.PHYSICIANs)
				.WithRequired(e => e.DB_USER)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<DIAGNOSI>()
				.Property(e => e.DIAGNOSIS)
				.IsUnicode(false);

			modelBuilder.Entity<DIAGNOSI>()
				.HasMany(e => e.TREATMENTs)
				.WithRequired(e => e.DIAGNOSI)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<FINANCIAL_STATUS>()
				.Property(e => e.PROVIDER)
				.IsUnicode(false);

			modelBuilder.Entity<FINANCIAL_STATUS>()
				.HasMany(e => e.CHARGE_TRANSACTION)
				.WithRequired(e => e.FINANCIAL_STATUS)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<FINANCIAL_STATUS>()
				.HasMany(e => e.PATIENTs)
				.WithRequired(e => e.FINANCIAL_STATUS)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<ITEM>()
				.Property(e => e.DESCRIPTION)
				.IsUnicode(false);

			modelBuilder.Entity<ITEM>()
				.Property(e => e.CHARGE)
				.HasPrecision(10, 4);

			modelBuilder.Entity<ITEM>()
				.HasMany(e => e.CHARGEs)
				.WithRequired(e => e.ITEM)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<NOTE>()
				.Property(e => e.ENTRY)
				.IsUnicode(false);

			modelBuilder.Entity<PATIENT>()
				.Property(e => e.PATIENT_NAME)
				.IsUnicode(false);

			modelBuilder.Entity<PATIENT>()
				.Property(e => e.PATIENT_ADDRESS)
				.IsUnicode(false);

			modelBuilder.Entity<PATIENT>()
				.Property(e => e.CITY)
				.IsUnicode(false);

			modelBuilder.Entity<PATIENT>()
				.Property(e => e.PROVINCE)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<PATIENT>()
				.Property(e => e.POSTAL_CODE)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<PATIENT>()
				.Property(e => e.TELEPHONE)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<PATIENT>()
				.Property(e => e.SEX)
				.IsUnicode(false);

			modelBuilder.Entity<PATIENT>()
				.HasMany(e => e.ADMISSIONs)
				.WithRequired(e => e.PATIENT)
				.HasForeignKey(e => e.PATIENT_NUMBER)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<PATIENT>()
				.HasMany(e => e.APPOINTMENTs)
				.WithRequired(e => e.PATIENT)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<PATIENT>()
				.HasMany(e => e.TREATMENTs)
				.WithRequired(e => e.PATIENT)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<PHYSICIAN>()
				.Property(e => e.PHYSICIAN_NAME)
				.IsUnicode(false);

			modelBuilder.Entity<PHYSICIAN>()
				.Property(e => e.TELEPHONE)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<PHYSICIAN>()
				.Property(e => e.SPECIALTY_ID)
				.IsUnicode(false);

			modelBuilder.Entity<PHYSICIAN>()
				.HasMany(e => e.TREATMENTs)
				.WithRequired(e => e.PHYSICIAN)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<PHYSICIAN_SPECIALTY>()
				.Property(e => e.SPECIALTY_ID)
				.IsUnicode(false);

			modelBuilder.Entity<PHYSICIAN_SPECIALTY>()
				.Property(e => e.SPECIALTY)
				.IsUnicode(false);

			modelBuilder.Entity<PHYSICIAN_SPECIALTY>()
				.HasMany(e => e.PHYSICIANs)
				.WithRequired(e => e.PHYSICIAN_SPECIALTY)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<ROOM>()
				.Property(e => e.ROOM_TYPE_NUMBER)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<ROOM>()
				.HasMany(e => e.BEDs)
				.WithRequired(e => e.ROOM)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<ROOM_TYPE>()
				.Property(e => e.ROOM_TYPE_ID)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<ROOM_TYPE>()
				.Property(e => e.DESCRIPTION)
				.IsUnicode(false);

			modelBuilder.Entity<ROOM_TYPE>()
				.HasMany(e => e.ROOMs)
				.WithRequired(e => e.ROOM_TYPE)
				.HasForeignKey(e => e.ROOM_TYPE_NUMBER)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<TREATMENT>()
				.Property(e => e.DESCRIPTION)
				.IsUnicode(false);

			modelBuilder.Entity<USER_TYPE>()
				.Property(e => e.USER_TYPE1)
				.IsUnicode(false);

			modelBuilder.Entity<USER_TYPE>()
				.HasMany(e => e.DB_USER)
				.WithRequired(e => e.USER_TYPE)
				.WillCascadeOnDelete(false);
		}
	}
}
