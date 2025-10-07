
 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using CSGenio.framework;
using CSGenio.persistence;
using Quidgest.Persistence;
using Quidgest.Persistence.GenericQuery;
using System.Linq;

namespace CSGenio.business
{
	/// <summary>
	/// Property
	/// </summary>
	public class CSGenioAt_002 : DbArea
	{
		/// <summary>
		/// Meta-information on this area
		/// </summary>
		protected readonly static AreaInfo informacao = InicializaAreaInfo();

		public CSGenioAt_002(User user, string module)
		{
            this.user = user;
            this.module = module;
			// USE /[MANUAL RMS CONSTRUTOR T_002]/
		}

		public CSGenioAt_002(User user) : this(user, user.CurrentModule)
		{
		}

		/// <summary>
		/// Initializes the metadata relative to the fields of this area
		/// </summary>
		private static void InicializaCampos(AreaInfo info)
		{
			Field Qfield = null;
#pragma warning disable CS0168, S1481 // Variable is declared but never used
			List<ByAreaArguments> argumentsListByArea;
#pragma warning restore CS0168, S1481 // Variable is declared but never used
			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "codt_002", FieldType.KEY_INT);
			Qfield.FieldDescription = "";
			Qfield.FieldSize =  8;
			Qfield.MQueue = false;
			Qfield.CavDesignation = "";

			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "photo", FieldType.IMAGE);
			Qfield.FieldDescription = "Property Photo";
			Qfield.FieldSize =  3;
			Qfield.MQueue = false;
			Qfield.CavDesignation = "PROPERTY_PHOTO29666";

			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "title", FieldType.TEXT);
			Qfield.FieldDescription = "Property Title";
			Qfield.FieldSize =  50;
			Qfield.MQueue = false;
			Qfield.CavDesignation = "PROPERTY_TITLE56931";

            Qfield.NotNull = true;
			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "price", FieldType.CURRENCY);
			Qfield.FieldDescription = "Property Price";
			Qfield.FieldSize =  12;
			Qfield.MQueue = false;
			Qfield.IntegerDigits = 9;
			Qfield.Decimals = 2;
			Qfield.CavDesignation = "PROPERTY_PRICE21441";

            Qfield.NotNull = true;
			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "codt_001", FieldType.KEY_INT);
			Qfield.FieldDescription = "";
			Qfield.FieldSize =  8;
			Qfield.MQueue = false;
			Qfield.CavDesignation = "";

			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "codt_004", FieldType.KEY_INT);
			Qfield.FieldDescription = "";
			Qfield.FieldSize =  8;
			Qfield.MQueue = false;
			Qfield.CavDesignation = "";

			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "size", FieldType.NUMERIC);
			Qfield.FieldDescription = "Size";
			Qfield.FieldSize =  10;
			Qfield.MQueue = false;
			Qfield.IntegerDigits = 6;
			Qfield.Decimals = 3;
			Qfield.CavDesignation = "SIZE10299";

            Qfield.NotNull = true;
			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "bathnumber", FieldType.NUMERIC);
			Qfield.FieldDescription = "Bathroums Number";
			Qfield.FieldSize =  2;
			Qfield.MQueue = false;
			Qfield.IntegerDigits = 2;
			Qfield.CavDesignation = "BATHROUMS_NUMBER42941";

            Qfield.NotNull = true;
			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "yearbuilt", FieldType.NUMERIC);
			Qfield.FieldDescription = "Year Built";
			Qfield.FieldSize =  4;
			Qfield.MQueue = false;
			Qfield.IntegerDigits = 4;
			Qfield.CavDesignation = "YEAR_BUILT55277";

            Qfield.NotNull = true;
			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "zzstate", FieldType.INTEGER);
			Qfield.FieldDescription = "Estado da ficha";
			info.RegisterFieldDB(Qfield);

		}

		/// <summary>
		/// Initializes metadata for paths direct to other areas
		/// </summary>
		private static void InicializaRelacoes(AreaInfo info)
		{
			// Daughters Relations
			//------------------------------
			info.ChildTable = new ChildRelation[2];
			info.ChildTable[0]= new ChildRelation("t_006", new String[] {"codt_002"}, DeleteProc.NA);
			info.ChildTable[1]= new ChildRelation("t_005", new String[] {"codt_002"}, DeleteProc.NA);

			// Mother Relations
			//------------------------------
			info.ParentTables = new Dictionary<string, Relation>();
			info.ParentTables.Add("t_001", new Relation("RMS", "rmsproperty", "t_002", "codt_002", "codt_001", "RMS", "rmst_agent", "t_001", "codt_001", "codt_001"));
			info.ParentTables.Add("t_004", new Relation("RMS", "rmsproperty", "t_002", "codt_002", "codt_004", "RMS", "rmscity", "t_004", "codt_004", "codt_004"));
		}

		/// <summary>
		/// Initializes metadata for indirect paths to other areas
		/// </summary>
		private static void InicializaCaminhos(AreaInfo info)
		{
			// Pathways
			//------------------------------
			info.Pathways = new Dictionary<string, string>(5);
			info.Pathways.Add("t_004","t_004");
			info.Pathways.Add("t_001","t_001");
			info.Pathways.Add("t_003","t_004");
			info.Pathways.Add("at_01","t_001");
			info.Pathways.Add("at_02","t_001");
		}

		/// <summary>
		/// Initializes metadata for triggers and formula arguments
		/// </summary>
		private static void InicializaFormulas(AreaInfo info)
		{
			// Formulas
			//------------------------------








			//Write conditions
			List<ConditionFormula> conditions = new List<ConditionFormula>();
			info.WriteConditions = conditions.Where(c=> c.IsWriteCondition()).ToList();
			info.CrudConditions = conditions.Where(c=> c.IsCrudCondition()).ToList();

		}

		/// <summary>
		/// static CSGenioAt_002()
		/// </summary>
		private static AreaInfo InicializaAreaInfo()
		{
			AreaInfo info = new AreaInfo();

			// Area meta-information
			info.QSystem="RMS";
			info.TableName="rmsproperty";
			info.ShadowTabName="";
			info.ShadowTabKeyName="";

			info.PrimaryKeyName="codt_002";
			info.HumanKeyName="title,".TrimEnd(',');
			info.Alias="t_002";
			info.IsDomain = true;
			info.PersistenceType = PersistenceType.Database;
			info.AreaDesignation="Property";
			info.AreaPluralDesignation="Properties";
			info.DescriptionCav="PROPERTY43977";

			//sincronização
			info.SyncIncrementalDateStart = TimeSpan.FromHours(8);
			info.SyncIncrementalDateEnd = TimeSpan.FromHours(23);
			info.SyncCompleteHour = TimeSpan.FromHours(0.5);
			info.SyncIncrementalPeriod = TimeSpan.FromHours(1);
			info.BatchSync = 100;
			info.SyncType = SyncType.Central;
            info.SolrList = new List<string>();
        	info.QueuesList = new List<GenioServer.business.QueueGenio>();





			//RS 22.03.2011 I separated in submetodos due to performance problems with the JIT in 64bits
			// that in very large projects took 2 minutes on the first call.
			// After a Microsoft analysis of the JIT algortimo it was revealed that it has a
			// complexity O(n*m) where n are the lines of code and m the number of variables of a function.
			// Tests have revealed that splitting into subfunctions cuts the JIT time by more than half by 64-bit.
			//------------------------------
			InicializaCampos(info);

			//------------------------------
			InicializaRelacoes(info);

			//------------------------------
			InicializaCaminhos(info);

			//------------------------------
			InicializaFormulas(info);

			// Automatic audit stamps in BD
            //------------------------------

            // Documents in DB
            //------------------------------

            // Historics
            //------------------------------

			// Duplication
			//------------------------------

			// Ephs
			//------------------------------
			info.Ephs=new Hashtable();

			// Table minimum roles and access levels
			//------------------------------
            info.QLevel = new QLevel();
            info.QLevel.Query = Role.AUTHORIZED;
            info.QLevel.Create = Role.AUTHORIZED;
            info.QLevel.AlterAlways = Role.AUTHORIZED;
            info.QLevel.RemoveAlways = Role.AUTHORIZED;

      		return info;
		}

		/// <summary>
		/// Meta-information about this area
		/// </summary>
		public override AreaInfo Information
		{
			get { return informacao; }
		}
		/// <summary>
		/// Meta-information about this area
		/// </summary>
		public static AreaInfo GetInformation()
		{
			return informacao;
		}

		/// <summary>Field : "" Tipo: "+" Formula:  ""</summary>
		public static FieldRef FldCodt_002 { get { return m_fldCodt_002; } }
		private static FieldRef m_fldCodt_002 = new FieldRef("t_002", "codt_002");

		/// <summary>Field : "" Tipo: "+" Formula:  ""</summary>
		public string ValCodt_002
		{
			get { return (string)returnValueField(FldCodt_002); }
			set { insertNameValueField(FldCodt_002, value); }
		}

		/// <summary>Field : "Property Photo" Tipo: "IJ" Formula:  ""</summary>
		public static FieldRef FldPhoto { get { return m_fldPhoto; } }
		private static FieldRef m_fldPhoto = new FieldRef("t_002", "photo");

		/// <summary>Field : "Property Photo" Tipo: "IJ" Formula:  ""</summary>
		public byte[] ValPhoto
		{
			get { return (byte[])returnValueField(FldPhoto); }
			set { insertNameValueField(FldPhoto, value); }
		}

		/// <summary>Field : "Property Title" Tipo: "C" Formula:  ""</summary>
		public static FieldRef FldTitle { get { return m_fldTitle; } }
		private static FieldRef m_fldTitle = new FieldRef("t_002", "title");

		/// <summary>Field : "Property Title" Tipo: "C" Formula:  ""</summary>
		public string ValTitle
		{
			get { return (string)returnValueField(FldTitle); }
			set { insertNameValueField(FldTitle, value); }
		}

		/// <summary>Field : "Property Price" Tipo: "$" Formula:  ""</summary>
		public static FieldRef FldPrice { get { return m_fldPrice; } }
		private static FieldRef m_fldPrice = new FieldRef("t_002", "price");

		/// <summary>Field : "Property Price" Tipo: "$" Formula:  ""</summary>
		public decimal ValPrice
		{
			get { return (decimal)returnValueField(FldPrice); }
			set { insertNameValueField(FldPrice, value); }
		}

		/// <summary>Field : "" Tipo: "CE" Formula:  ""</summary>
		public static FieldRef FldCodt_001 { get { return m_fldCodt_001; } }
		private static FieldRef m_fldCodt_001 = new FieldRef("t_002", "codt_001");

		/// <summary>Field : "" Tipo: "CE" Formula:  ""</summary>
		public string ValCodt_001
		{
			get { return (string)returnValueField(FldCodt_001); }
			set { insertNameValueField(FldCodt_001, value); }
		}

		/// <summary>Field : "" Tipo: "CE" Formula:  ""</summary>
		public static FieldRef FldCodt_004 { get { return m_fldCodt_004; } }
		private static FieldRef m_fldCodt_004 = new FieldRef("t_002", "codt_004");

		/// <summary>Field : "" Tipo: "CE" Formula:  ""</summary>
		public string ValCodt_004
		{
			get { return (string)returnValueField(FldCodt_004); }
			set { insertNameValueField(FldCodt_004, value); }
		}

		/// <summary>Field : "Size" Tipo: "N" Formula:  ""</summary>
		public static FieldRef FldSize { get { return m_fldSize; } }
		private static FieldRef m_fldSize = new FieldRef("t_002", "size");

		/// <summary>Field : "Size" Tipo: "N" Formula:  ""</summary>
		public decimal ValSize
		{
			get { return (decimal)returnValueField(FldSize); }
			set { insertNameValueField(FldSize, value); }
		}

		/// <summary>Field : "Bathroums Number" Tipo: "N" Formula:  ""</summary>
		public static FieldRef FldBathnumber { get { return m_fldBathnumber; } }
		private static FieldRef m_fldBathnumber = new FieldRef("t_002", "bathnumber");

		/// <summary>Field : "Bathroums Number" Tipo: "N" Formula:  ""</summary>
		public decimal ValBathnumber
		{
			get { return (decimal)returnValueField(FldBathnumber); }
			set { insertNameValueField(FldBathnumber, value); }
		}

		/// <summary>Field : "Year Built" Tipo: "N" Formula:  ""</summary>
		public static FieldRef FldYearbuilt { get { return m_fldYearbuilt; } }
		private static FieldRef m_fldYearbuilt = new FieldRef("t_002", "yearbuilt");

		/// <summary>Field : "Year Built" Tipo: "N" Formula:  ""</summary>
		public decimal ValYearbuilt
		{
			get { return (decimal)returnValueField(FldYearbuilt); }
			set { insertNameValueField(FldYearbuilt, value); }
		}

		/// <summary>Field : "ZZSTATE" Type: "INT" Formula:  ""</summary>
		public static FieldRef FldZzstate { get { return m_fldZzstate; } }
		private static FieldRef m_fldZzstate = new FieldRef("t_002", "zzstate");



		/// <summary>Field : "ZZSTATE" Type: "INT"</summary>
		public int ValZzstate
		{
			get { return (int)returnValueField(FldZzstate); }
			set { insertNameValueField(FldZzstate, value); }
		}

        /// <summary>
        /// Obtains a partially populated area with the record corresponding to a primary key
        /// </summary>
        /// <param name="sp">Persistent support from where to get the registration</param>
        /// <param name="key">The value of the primary key</param>
        /// <param name="user">The context of the user</param>
        /// <param name="fields">The fields to be filled in the area</param>
        /// <returns>An area with the fields requests of the record read or null if the key does not exist</returns>
        /// <remarks>Persistence operations should not be used on a partially positioned register</remarks>
        public static CSGenioAt_002 search(PersistentSupport sp, string key, User user, string[] fields = null)
        {
			if (string.IsNullOrEmpty(key))
				return null;

		    CSGenioAt_002 area = new CSGenioAt_002(user, user.CurrentModule);

            if (sp.getRecord(area, key, fields))
                return area;
			return null;
        }


		public static string GetkeyFromControlledRecord(PersistentSupport sp, string ID, User user)
		{
			if (informacao.ControlledRecords != null)
				return informacao.ControlledRecords.GetPrimaryKeyFromControlledRecord(sp, user, ID);
			return String.Empty;
		}


        /// <summary>
        /// Search for all records of this area that comply with a condition
        /// </summary>
        /// <param name="sp">Persistent support from where to get the list</param>
        /// <param name="user">The context of the user</param>
        /// <param name="where">The search condition for the records. Use null to get all records</param>
        /// <param name="fields">The fields to be filled in the area</param>
        /// <param name="distinct">Get distinct from fields</param>
        /// <param name="noLock">NOLOCK</param>
        /// <returns>A list of area records with all fields populated</returns>
        /// <remarks>Persistence operations should not be used on a partially positioned register</remarks>
        public static List<CSGenioAt_002> searchList(PersistentSupport sp, User user, CriteriaSet where, string[] fields = null, bool distinct = false, bool noLock = false)
        {
				return sp.searchListWhere<CSGenioAt_002>(where, user, fields, distinct, noLock);
        }



       	/// <summary>
        /// Search for all records of this area that comply with a condition
        /// </summary>
        /// <param name="sp">Persistent support from where to get the list</param>
        /// <param name="user">The context of the user</param>
        /// <param name="where">The search condition for the records. Use null to get all records</param>
        /// <param name="listing">List configuration</param>
        /// <returns>A list of area records with all fields populated</returns>
        /// <remarks>Persistence operations should not be used on a partially positioned register</remarks>
        public static void searchListAdvancedWhere(PersistentSupport sp, User user, CriteriaSet where, ListingMVC<CSGenioAt_002> listing)
        {
			sp.searchListAdvancedWhere<CSGenioAt_002>(where, listing);
        }




		/// <summary>
		/// Check if a record exist
		/// </summary>
		/// <param name="key">Record key</param>
		/// <param name="sp">DB conecntion</param>
		/// <returns>True if the record exist</returns>
		public static bool RecordExist(string key, PersistentSupport sp) => DbArea.RecordExist(key, informacao, sp);








		// USE /[MANUAL RMS TABAUX T_002]/

 

          

	}
}
