using JsonIgnoreAttribute = System.Text.Json.Serialization.JsonIgnoreAttribute;
using JsonPropertyName = System.Text.Json.Serialization.JsonPropertyNameAttribute;
using SelectList = Microsoft.AspNetCore.Mvc.Rendering.SelectList;
using System.Collections.Specialized;
using System.Data;
using System.Globalization;
using System.Linq;

using CSGenio.business;
using CSGenio.core.di;
using CSGenio.framework;
using GenioMVC.Helpers;
using GenioMVC.Models.Exception;
using GenioMVC.Models.Navigation;
using Quidgest.Persistence;
using Quidgest.Persistence.GenericQuery;

namespace GenioMVC.ViewModels.T_002
{
	public class RMS_Menu_411_ViewModel : MenuListViewModel<Models.T_002>
	{
		/// <summary>
		/// Gets or sets the object that represents the table and its elements.
		/// </summary>
		[JsonPropertyName("Table")]
		public TablePartial<RMS_Menu_411_RowViewModel> Menu { get; set; }

		/// <inheritdoc/>
		[JsonIgnore]
		public override string TableAlias => "t_002";

		/// <inheritdoc/>
		public override string Uuid => "304e6bf4-5627-43ac-aa36-2646b77aaf2e";

		/// <inheritdoc/>
		protected override string[] FieldsToSerialize => _fieldsToSerialize;

		/// <inheritdoc/>
		protected override List<TableSearchColumn> SearchableColumns => _searchableColumns;

		/// <summary>
		/// The context of the parent.
		/// </summary>
		[JsonIgnore]
		public Models.ModelBase ParentCtx { get; set; }

		/// <inheritdoc/>
		[JsonIgnore]
		public override CriteriaSet StaticLimits
		{
			get
			{
				CriteriaSet conditions = CriteriaSet.And();
				// Limitations

				return conditions;
			}
		}

		/// <inheritdoc/>
		[JsonIgnore]
		public override CriteriaSet baseConditions
		{
			get
			{
				CriteriaSet conds = CriteriaSet.And();
				conds.Equal(CSGenioAt_002.FldCodt_001, Navigation.GetValue("t_001"));

				return conds;
			}
		}

		/// <inheritdoc/>
		[JsonIgnore]
		public override List<Relation> relations
		{
			get
			{
				List<Relation> relations = null;
				return relations;
			}
		}

		public override CriteriaSet GetCustomizedStaticLimits(CriteriaSet crs)
		{
// USE /[MANUAL RMS LIST_LIMITS 411]/

			return crs;
		}

		public override int GetCount(User user)
		{
			CSGenio.persistence.PersistentSupport sp = m_userContext.PersistentSupport;
			var areaBase = CSGenio.business.Area.createArea("t_002", user, "RMS");

			//gets eph conditions to be applied in listing
			CriteriaSet conditions = CSGenio.business.Listing.CalculateConditionsEphGeneric(areaBase, "ML411");
			conditions.Equal(CSGenioAt_002.FldZzstate, 0); //valid zzstate only

			// Fixed limits and relations:
			conditions.SubSets.Add(GetCustomizedStaticLimits(StaticLimits));

			// Checks for foreign tables in fields and conditions
			FieldRef[] fields = new FieldRef[] { CSGenioAt_002.FldCodt_002, CSGenioAt_002.FldZzstate, CSGenioAt_002.FldPhoto, CSGenioAt_002.FldTitle, CSGenioAt_002.FldSize, CSGenioAt_002.FldTypology, CSGenioAt_002.FldType, CSGenioAt_002.FldBathnumber, CSGenioAt_002.FldCodt_004, CSGenioAt_004.FldCodt_004, CSGenioAt_004.FldCity, CSGenioAt_002.FldYearbuilt, CSGenioAt_002.FldPrice };

			ListingMVC<CSGenioAt_002> listing = new(fields, null, 1, 1, false, user, true, string.Empty, true);
			SelectQuery qs = sp.getSelectQueryFromListingMVC(conditions, listing);

			// Menu relations:
			if (qs.FromTable == null)
				qs.From(areaBase.QSystem, areaBase.TableName, areaBase.Alias);

			if (!qs.Joins.Select(x => x.Table).Select(y => y.TableAlias).Contains(CSGenio.business.Area.AreaT_001.Alias))
				qs.Join(CSGenio.business.Area.AreaT_001, TableJoinType.Inner).On(CriteriaSet.And().Equal(CSGenioAt_001.FldCodt_001, CSGenioAt_002.FldCodt_001));



			//operation: Count menu records
			return CSGenio.persistence.DBConversion.ToInteger(sp.ExecuteScalar(CSGenio.persistence.QueryUtils.buildQueryCount(qs)));
		}

		/// <summary>
		/// FOR DESERIALIZATION ONLY
		/// </summary>
		[Obsolete("For deserialization only")]
		public RMS_Menu_411_ViewModel() : base(null!) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="RMS_Menu_411_ViewModel" /> class.
		/// </summary>
		/// <param name="userContext">The current user request context</param>
		public RMS_Menu_411_ViewModel(UserContext userContext) : base(userContext)
		{
			this.RoleToShow = CSGenio.framework.Role.ROLE_30;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RMS_Menu_411_ViewModel" /> class.
		/// </summary>
		/// <param name="userContext">The current user request context</param>
		/// <param name="parentCtx">The context of the parent</param>
		public RMS_Menu_411_ViewModel(UserContext userContext, Models.ModelBase parentCtx) : this(userContext)
		{
			ParentCtx = parentCtx;
		}

		/// <inheritdoc/>
		public override List<Exports.QColumn> GetColumnsToExport()
		{
			return
			[
				new Exports.QColumn(CSGenioAt_002.FldTitle, FieldType.TEXT, Resources.Resources.PROPERTY_TITLE56931, 30, 0, true),
				new Exports.QColumn(CSGenioAt_002.FldSize, FieldType.NUMERIC, Resources.Resources.SIZE10299, 10, 3, true),
				new Exports.QColumn(CSGenioAt_002.FldTypology, FieldType.ARRAY_TEXT, Resources.Resources.BUILDING_TYPOLOGY07362, 5, 0, true, "E_02"),
				new Exports.QColumn(CSGenioAt_002.FldType, FieldType.ARRAY_TEXT, Resources.Resources.BUILDING_TYPE39168, 10, 0, true, "E_01"),
				new Exports.QColumn(CSGenioAt_002.FldBathnumber, FieldType.NUMERIC, Resources.Resources.BATHROUMS_NUMBER42941, 2, 0, true),
				new Exports.QColumn(CSGenioAt_004.FldCity, FieldType.TEXT, Resources.Resources.CITY42505, 30, 0, true),
				new Exports.QColumn(CSGenioAt_002.FldYearbuilt, FieldType.DATE, Resources.Resources.YEAR_BUILT55277, 4, 0, true),
				new Exports.QColumn(CSGenioAt_002.FldPrice, FieldType.CURRENCY, Resources.Resources.PROPERTY_PRICE21441, 12, 2, true),
			];
		}

		public void LoadToExport(out ListingMVC<CSGenioAt_002> listing, out CriteriaSet conditions, out List<Exports.QColumn> columns, NameValueCollection requestValues, bool ajaxRequest = false)
		{
			CSGenio.framework.TableConfiguration.TableConfiguration tableConfig = new();
			LoadToExport(out listing, out conditions, out columns, tableConfig, requestValues, ajaxRequest);
		}

		public void LoadToExport(out ListingMVC<CSGenioAt_002> listing, out CriteriaSet conditions, out List<Exports.QColumn> columns, CSGenio.framework.TableConfiguration.TableConfiguration tableConfig, NameValueCollection requestValues, bool ajaxRequest = false)
		{
			listing = null;
			conditions = null;
			columns = this.GetExportColumns(tableConfig.ColumnConfiguration);

			// Store number of records to reset it after loading
			int rowsPerPage = tableConfig.RowsPerPage;
			tableConfig.RowsPerPage = -1;

			Load(tableConfig, requestValues, ajaxRequest, true, ref listing, ref conditions);

			// Reset number of records to original value
			tableConfig.RowsPerPage = rowsPerPage;
		}

		/// <inheritdoc/>
		public override CriteriaSet BuildCriteriaSet(NameValueCollection requestValues, out bool tableReload, CriteriaSet crs = null, bool isToExport = false)
		{
			CSGenio.framework.TableConfiguration.TableConfiguration tableConfig = new();
			return BuildCriteriaSet(tableConfig, requestValues, out tableReload, crs, isToExport);
		}

		/// <inheritdoc/>
		public override CriteriaSet BuildCriteriaSet(CSGenio.framework.TableConfiguration.TableConfiguration tableConfig, NameValueCollection requestValues, out bool tableReload, CriteriaSet crs = null, bool isToExport = false)
		{
			User u = m_userContext.User;
			tableReload = true;

			if (crs == null)
				crs = CriteriaSet.And();


			if (Menu == null)
				Menu = new TablePartial<RMS_Menu_411_RowViewModel>();
			// Set table name (used in getting searchable column names)
			Menu.TableName = TableAlias;

			Menu.SetFilters(false, false);


			crs.SubSets.Add(ProcessSearchFilters(Menu, GetSearchColumns(tableConfig.ColumnConfiguration), tableConfig));


			//Subfilters
			CriteriaSet subfilters = CriteriaSet.And();


			crs.SubSets.Add(subfilters);


			crs.SubSets.Add(GetCustomizedStaticLimits(StaticLimits));

			// Limitations
			// Limit "DB"
			crs.Equal(CSGenioAt_002.FldCodt_001, Navigation.GetValue("t_001"));
			if (isToExport)
			{
				// EPH
				crs = Models.T_002.AddEPH<CSGenioAt_002>(ref u, crs, "ML411");

				// Export only records with ZZState == 0
				crs.Equal(CSGenioAt_002.FldZzstate, 0);

				return crs;
			}

			// Limitation by Zzstate
			if (!Navigation.checkFormMode("T_002", FormMode.New)) // TODO: Check in Duplicate mode
				crs = extendWithZzstateCondition(crs, CSGenioAt_002.FldZzstate, null);


			if (tableReload)
			{
				string QMVC_POS_RECORD = Navigation.GetStrValue("QMVC_POS_RECORD_t_002");
				Navigation.DestroyEntry("QMVC_POS_RECORD_t_002");
				if (!string.IsNullOrEmpty(QMVC_POS_RECORD))
					crs.Equals(Models.T_002.AddEPH<CSGenioAt_002>(ref u, null, "ML411"));
			}

			return crs;
		}

		/// <summary>
		/// Loads the list with the specified number of rows.
		/// </summary>
		/// <param name="numberListItems">The number of rows to load.</param>
		/// <param name="ajaxRequest">Whether the request was initiated via AJAX.</param>
		public void Load(int numberListItems, bool ajaxRequest = false)
		{
			Load(numberListItems, new NameValueCollection(), ajaxRequest);
		}

		/// <summary>
		/// Loads the list with the specified number of rows.
		/// </summary>
		/// <param name="numberListItems">The number of rows to load.</param>
		/// <param name="requestValues">The request values.</param>
		/// <param name="ajaxRequest">Whether the request was initiated via AJAX.</param>
		/// <param name="conditions">The conditions.</param>
		public void Load(int numberListItems, NameValueCollection requestValues, bool ajaxRequest = false, CriteriaSet conditions = null)
		{
			ListingMVC<CSGenioAt_002> listing = null;

			Load(numberListItems, requestValues, ajaxRequest, false, ref listing, ref conditions);
		}

		/// <summary>
		/// Loads the list with the specified number of rows.
		/// </summary>
		/// <param name="numberListItems">The number of rows to load.</param>
		/// <param name="requestValues">The request values.</param>
		/// <param name="ajaxRequest">Whether the request was initiated via AJAX.</param>
		/// <param name="isToExport">Whether the list is being loaded to be exported</param>
		/// <param name="Qlisting">The rows.</param>
		/// <param name="conditions">The conditions.</param>
		public void Load(int numberListItems, NameValueCollection requestValues, bool ajaxRequest, bool isToExport, ref ListingMVC<CSGenioAt_002> Qlisting, ref CriteriaSet conditions)
		{
			CSGenio.framework.TableConfiguration.TableConfiguration tableConfig = new CSGenio.framework.TableConfiguration.TableConfiguration();

			tableConfig.RowsPerPage = numberListItems;

			Load(tableConfig, requestValues, ajaxRequest, isToExport, ref Qlisting, ref conditions);
		}

		/// <summary>
		/// Loads the table with the specified configuration.
		/// </summary>
		/// <param name="tableConfig">The table configuration object</param>
		/// <param name="requestValues">The request values.</param>
		/// <param name="ajaxRequest">Whether the request was initiated via AJAX.</param>
		/// <param name="isToExport">Whether the list is being loaded to be exported</param>
		/// <param name="conditions">The conditions.</param>
		public void Load(CSGenio.framework.TableConfiguration.TableConfiguration tableConfig, NameValueCollection requestValues, bool ajaxRequest, bool isToExport = false, CriteriaSet conditions = null)
		{
			ListingMVC<CSGenioAt_002> listing = null;

			Load(tableConfig, requestValues, ajaxRequest, isToExport, ref listing, ref conditions);
		}

		/// <summary>
		/// Loads the table with the specified configuration.
		/// </summary>
		/// <param name="tableConfig">The table configuration object</param>
		/// <param name="requestValues">The request values.</param>
		/// <param name="ajaxRequest">Whether the request was initiated via AJAX.</param>
		/// <param name="isToExport">Whether the list is being loaded to be exported</param>
		/// <param name="Qlisting">The rows.</param>
		/// <param name="conditions">The conditions.</param>
		public void Load(CSGenio.framework.TableConfiguration.TableConfiguration tableConfig, NameValueCollection requestValues, bool ajaxRequest, bool isToExport, ref ListingMVC<CSGenioAt_002> Qlisting, ref CriteriaSet conditions)
		{
				User u = m_userContext.User;
				Menu = new TablePartial<RMS_Menu_411_RowViewModel>();

				CriteriaSet rms_menu_411Conds = CriteriaSet.And();
				bool tableReload = true;

				//FOR: MENU LIST SORTING
				Dictionary<string, OrderedDictionary> allSortOrders = new Dictionary<string, OrderedDictionary>();
				allSortOrders.Add("T_002.TITLE", new OrderedDictionary());
				allSortOrders["T_002.TITLE"].Add("T_002.TITLE", "A");



				int numberListItems = tableConfig.RowsPerPage;
				var pageNumber = ajaxRequest ? tableConfig.Page : 1;

				// Added to avoid 0 or -1 pages when setting number of records to -1 to disable pagination
				if (pageNumber < 1)
					pageNumber = 1;

				List<ColumnSort> sorts = GetRequestSorts(this.Menu, tableConfig.ColumnOrderBy, "t_002", allSortOrders);

				if (sorts == null || sorts.Count == 0)
				{
					sorts = new List<ColumnSort>();
				sorts.Add(new ColumnSort(new ColumnReference(CSGenioAt_002.FldTitle), SortOrder.Ascending));

				}

				FieldRef[] fields = new FieldRef[] { CSGenioAt_002.FldCodt_002, CSGenioAt_002.FldZzstate, CSGenioAt_002.FldPhoto, CSGenioAt_002.FldTitle, CSGenioAt_002.FldSize, CSGenioAt_002.FldTypology, CSGenioAt_002.FldType, CSGenioAt_002.FldBathnumber, CSGenioAt_002.FldCodt_004, CSGenioAt_004.FldCodt_004, CSGenioAt_004.FldCity, CSGenioAt_002.FldYearbuilt, CSGenioAt_002.FldPrice };


				// Totalizers
				List<FieldRef> fieldsWithTotalizers = fields.Where(field => tableConfig.TotalizerColumns.Contains(field.FullName)).ToList();

				FieldRef firstVisibleColumn = null;

				if (sorts == null)
				{
					firstVisibleColumn = tableConfig?.getFirstVisibleColumn(TableAlias);

					firstVisibleColumn ??= new FieldRef("t_002", "photo");
				}


				// Limitations
				this.tableLimits ??= [];
				// Comparer to check if limit is already present in tableLimits
				LimitComparer limitComparer = new();

				//Tooltip for EPHs affecting this viewmodel list
				{
					Limit limit = new Limit();
					limit.TipoLimite = LimitType.EPH;
					CSGenioAt_002 model_limit_area = new CSGenioAt_002(m_userContext.User);
					List<Limit> area_EPH_limits = EPH_Limit_Filler(ref limit, model_limit_area, "ML411");
					if (area_EPH_limits.Count > 0)
						this.tableLimits.AddRange(area_EPH_limits);
				}

				// Tooltips: Making a tooltip for each valid limitation: 1 Limit(s) detected.
				// Limit origin: menu 

				//Limit type: "DB"
				//Current Area = "T_002"
				//1st Area Limit: "T_001"
				//1st Area Field: "CODT_001"
				//1st Area Value: ""
				{
					Limit limit = new Limit();
					limit.TipoLimite = LimitType.DB;
					limit.NaoAplicaSeNulo = false;
					CSGenioAt_001 model_limit_area = new CSGenioAt_001(m_userContext.User);
					string limit_field = "codt_001", limit_field_value = "";
					object this_limit_field = Navigation.GetStrValue(limit_field_value);
					Limit_Filler(ref limit, model_limit_area, limit_field, limit_field_value, this_limit_field, LimitAreaType.AreaLimita);
					if (!this.tableLimits.Contains(limit, limitComparer)) //to avoid repetitions (i.e: DB and EPH applying same limit)
						this.tableLimits.Add(limit);
				}

				if (conditions == null)
					conditions = CriteriaSet.And();

				conditions.SubSets.Add(rms_menu_411Conds);
				rms_menu_411Conds = BuildCriteriaSet(tableConfig, requestValues, out bool hasAllRequiredLimits, conditions, isToExport);
				tableReload &= hasAllRequiredLimits;

// USE /[MANUAL RMS OVERRQ 411]/

				bool distinct = false;

				if (isToExport)
				{
					if (!tableReload)
						return;

					Qlisting = Models.ModelBase.Where<CSGenioAt_002>(m_userContext, false, rms_menu_411Conds, fields, (pageNumber - 1) * numberListItems, numberListItems, sorts, "ML411", true, firstVisibleColumn: firstVisibleColumn);

// USE /[MANUAL RMS OVERRQLSTEXP 411]/

					return;
				}

				if (tableReload)
				{
// USE /[MANUAL RMS OVERRQLIST 411]/

					string QMVC_POS_RECORD = Navigation.GetStrValue("QMVC_POS_RECORD_t_002");
					Navigation.DestroyEntry("QMVC_POS_RECORD_t_002");
					CriteriaSet m_PagingPosEPHs = null;

					if (!string.IsNullOrEmpty(QMVC_POS_RECORD))
					{
						var m_iCurPag = m_userContext.PersistentSupport.getPagingPos(CSGenioAt_002.GetInformation(), QMVC_POS_RECORD, sorts, rms_menu_411Conds, m_PagingPosEPHs, firstVisibleColumn: firstVisibleColumn);
						if (m_iCurPag != -1)
							pageNumber = ((m_iCurPag - 1) / numberListItems) + 1;
					}

					ListingMVC<CSGenioAt_002> listing = Models.ModelBase.Where<CSGenioAt_002>(m_userContext, distinct, rms_menu_411Conds, fields, (pageNumber - 1) * numberListItems, numberListItems, sorts, "ML411", true, true, QMVC_POS_RECORD, m_PagingPosEPHs, firstVisibleColumn, fieldsWithTotalizers, tableConfig.SelectedRows);

					if (listing.CurrentPage > 0)
						pageNumber = listing.CurrentPage;

					//Added to avoid 0 or -1 pages when setting number of records to -1 to disable pagination
					if (pageNumber < 1)
						pageNumber = 1;

					//Set document field values to objects
					SetDocumentFields(listing);

					Menu.Elements = MapRMS_Menu_411(listing);

					Menu.Identifier = "ML411";
					Menu.Slots = new Dictionary<string, List<object>>();

					// Last updated by [CJP] at [2015.02.03]
					// Adds the identifier to each element
					foreach (var element in Menu.Elements)
						element.Identifier = "ML411";

					Menu.SetPagination(pageNumber, listing.NumRegs, listing.HasMore, listing.GetTotal, listing.TotalRecords);

					// Set table totalizers
					if (listing.Totalizers != null && listing.Totalizers.Count > 0)
						Menu.SetTotalizers(listing.Totalizers);
				}

				// Set table limits display property
				FillTableLimitsDisplayData();

				// Store table configuration so it gets sent to the client-side to be processed
				CurrentTableConfig = tableConfig;

				// Load the user table configuration names and default name
				LoadUserTableConfigNameProperties();
		}

		private List<RMS_Menu_411_RowViewModel> MapRMS_Menu_411(ListingMVC<CSGenioAt_002> Qlisting)
		{
			List<RMS_Menu_411_RowViewModel> Elements = [];
			int i = 0;

			if (Qlisting.Rows != null)
			{
				foreach (var row in Qlisting.Rows)
				{
					if (Qlisting.NumRegs > 0 && i >= Qlisting.NumRegs) // Copiado da versão antiga do RowsToViewModels
						break;
					Elements.Add(MapRMS_Menu_411(row));
					i++;
				}
			}

			return Elements;
		}

		/// <summary>
		/// Maps a single CSGenioAt_002 row
		/// to a RMS_Menu_411_RowViewModel object.
		/// </summary>
		/// <param name="row">The row.</param>
		private RMS_Menu_411_RowViewModel MapRMS_Menu_411(CSGenioAt_002 row)
		{
			var model = new RMS_Menu_411_RowViewModel(m_userContext, true, _fieldsToSerialize);
			if (row == null)
				return model;

			foreach (RequestedField Qfield in row.Fields.Values)
			{
				switch (Qfield.Area)
				{
					case "t_002":
						model.klass.insertNameValueField(Qfield.FullName, Qfield.Value); break;
					case "t_004":
						model.T_004.klass.insertNameValueField(Qfield.FullName, Qfield.Value); break;
					default:
						break;
				}
			}

			model.InitRowData();

			SetTicketToImageFields(model);
			return model;
		}

		/// <summary>
		/// Checks the loaded model for pending rows (zzsttate not 0).
		/// </summary>
		public bool CheckForZzstate()
		{
			if (Menu?.Elements == null)
				return false;

			return Menu.Elements.Any(row => row.ValZzstate != 0);
		}

		/// <summary>
		/// Sets the document field values to objects.
		/// </summary>
		/// <param name="listing">The rows</param>
		private void SetDocumentFields(ListingMVC<CSGenioAt_002> listing)
		{
		}

		#region Mapper

		/// <inheritdoc />
		public override void MapFromModel(Models.T_002 m)
		{
		}

		/// <inheritdoc />
		public override void MapToModel(Models.T_002 m)
		{
		}

		#endregion

		#region Custom code

// USE /[MANUAL RMS VIEWMODEL_CUSTOM RMS_MENU_411]/

		#endregion

		private static readonly string[] _fieldsToSerialize =
		[
			"T_002", "T_002.ValCodt_002", "T_002.ValZzstate", "T_002.ValPhoto", "T_002.ValTitle", "T_002.ValSize", "T_002.ValTypology", "T_002.ValType", "T_002.ValBathnumber", "T_004", "T_004.ValCity", "T_002.ValYearbuilt", "T_002.ValPrice", "T_002.ValCodt_001", "T_002.ValCodt_004"
		];

		private static readonly List<TableSearchColumn> _searchableColumns =
		[
			new TableSearchColumn("ValTitle", CSGenioAt_002.FldTitle, typeof(string), defaultSearch : true),
			new TableSearchColumn("ValSize", CSGenioAt_002.FldSize, typeof(decimal?)),
			new TableSearchColumn("ValTypology", CSGenioAt_002.FldTypology, typeof(string), array : "E_02"),
			new TableSearchColumn("ValType", CSGenioAt_002.FldType, typeof(string), array : "E_01"),
			new TableSearchColumn("ValBathnumber", CSGenioAt_002.FldBathnumber, typeof(decimal?)),
			new TableSearchColumn("T_004_ValCity", CSGenioAt_004.FldCity, typeof(string)),
			new TableSearchColumn("ValYearbuilt", CSGenioAt_002.FldYearbuilt, typeof(DateTime?)),
			new TableSearchColumn("ValPrice", CSGenioAt_002.FldPrice, typeof(decimal?)),
		];
		protected void SetTicketToImageFields(Models.T_002 row)
		{
			if (row == null)
				return;

			row.ValPhotoQTicket = Helpers.Helpers.GetFileTicket(m_userContext.User, CSGenio.business.Area.AreaT_002, CSGenioAt_002.FldPhoto.Field, null, row.ValCodt_002);
		}
	}
}
