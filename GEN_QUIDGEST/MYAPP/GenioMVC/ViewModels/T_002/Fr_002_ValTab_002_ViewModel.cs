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
	public class Fr_002_ValTab_002_ViewModel : MenuListViewModel<Models.T_005>
	{
		/// <summary>
		/// Gets or sets the object that represents the table and its elements.
		/// </summary>
		[JsonPropertyName("Table")]
		public TablePartial<Fr_002_ValTab_002_RowViewModel> Menu { get; set; }

		/// <inheritdoc/>
		[JsonIgnore]
		public override string TableAlias => "t_005";

		/// <inheritdoc/>
		public override string Uuid => "Fr_002_ValTab_002";

		/// <inheritdoc/>
		protected override string[] FieldsToSerialize => _fieldsToSerialize;

		/// <inheritdoc/>
		protected override List<TableSearchColumn> SearchableColumns => _searchableColumns;

		/// <summary>
		/// The primary key field.
		/// </summary>
		[JsonIgnore]
		public string T_002ValCodt_002 { get; set; }

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
// USE /[MANUAL RMS LIST_LIMITS FR_002_PSEUDTAB_002]/

			return crs;
		}

		public override int GetCount(User user)
		{
			throw new NotImplementedException("This operation is not supported");
		}

		/// <summary>
		/// FOR DESERIALIZATION ONLY
		/// </summary>
		[Obsolete("For deserialization only")]
		public Fr_002_ValTab_002_ViewModel() : base(null!) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="Fr_002_ValTab_002_ViewModel" /> class.
		/// </summary>
		/// <param name="userContext">The current user request context</param>
		public Fr_002_ValTab_002_ViewModel(UserContext userContext) : base(userContext)
		{
			T_002ValCodt_002 = userContext.CurrentNavigation.CurrentLevel.GetEntry("t_002")?.ToString();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Fr_002_ValTab_002_ViewModel" /> class.
		/// </summary>
		/// <param name="userContext">The current user request context</param>
		/// <param name="parentCtx">The context of the parent</param>
		public Fr_002_ValTab_002_ViewModel(UserContext userContext, Models.ModelBase parentCtx) : this(userContext)
		{
			ParentCtx = parentCtx;
		}

		/// <inheritdoc/>
		public override List<Exports.QColumn> GetColumnsToExport()
		{
			return
			[
				new Exports.QColumn(CSGenioAt_005.FldClientname, FieldType.TEXT, Resources.Resources.CLIENT_NAME26049, 30, 0, true),
				new Exports.QColumn(CSGenioAt_005.FldDatre, FieldType.DATE, Resources.Resources.DATE18475, 8, 0, true),
				new Exports.QColumn(CSGenioAt_005.FldDescription, FieldType.TEXT, Resources.Resources.DESCRIPTION07383, 30, 0, true),
			];
		}

		public void LoadToExport(out ListingMVC<CSGenioAt_005> listing, out CriteriaSet conditions, out List<Exports.QColumn> columns, NameValueCollection requestValues, bool ajaxRequest = false)
		{
			CSGenio.framework.TableConfiguration.TableConfiguration tableConfig = new();
			LoadToExport(out listing, out conditions, out columns, tableConfig, requestValues, ajaxRequest);
		}

		public void LoadToExport(out ListingMVC<CSGenioAt_005> listing, out CriteriaSet conditions, out List<Exports.QColumn> columns, CSGenio.framework.TableConfiguration.TableConfiguration tableConfig, NameValueCollection requestValues, bool ajaxRequest = false)
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
				Menu = new TablePartial<Fr_002_ValTab_002_RowViewModel>();
			// Set table name (used in getting searchable column names)
			Menu.TableName = TableAlias;

			Menu.SetFilters(false, false);


			crs.SubSets.Add(ProcessSearchFilters(Menu, GetSearchColumns(tableConfig.ColumnConfiguration), tableConfig));


			//Subfilters
			CriteriaSet subfilters = CriteriaSet.And();


			crs.SubSets.Add(subfilters);

			// Form field filters
			if (tableConfig.FieldFilters != null)
				crs.SubSets.Add(ProcessFieldFilters(tableConfig.FieldFilters));

			if (this.T_002ValCodt_002 != null)
				crs.Equal(CSGenioAt_005.FldCodt_002, this.T_002ValCodt_002);


			crs.SubSets.Add(GetCustomizedStaticLimits(StaticLimits));

			if (isToExport)
			{
				// EPH
				crs = Models.T_005.AddEPH<CSGenioAt_005>(ref u, crs, "IBL_FR_002__PSEUDTAB_002_");

				// Export only records with ZZState == 0
				crs.Equal(CSGenioAt_005.FldZzstate, 0);

				return crs;
			}

			// Limitation by Zzstate
			if (!Navigation.checkFormMode("T_005", FormMode.New)) // TODO: Check in Duplicate mode
				crs = extendWithZzstateCondition(crs, CSGenioAt_005.FldZzstate, null);


			if (tableReload)
			{
				string QMVC_POS_RECORD = Navigation.GetStrValue("QMVC_POS_RECORD_t_005");
				Navigation.DestroyEntry("QMVC_POS_RECORD_t_005");
				if (!string.IsNullOrEmpty(QMVC_POS_RECORD))
					crs.Equals(Models.T_005.AddEPH<CSGenioAt_005>(ref u, null, "IBL_FR_002__PSEUDTAB_002_"));
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
			ListingMVC<CSGenioAt_005> listing = null;

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
		public void Load(int numberListItems, NameValueCollection requestValues, bool ajaxRequest, bool isToExport, ref ListingMVC<CSGenioAt_005> Qlisting, ref CriteriaSet conditions)
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
			ListingMVC<CSGenioAt_005> listing = null;

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
		public void Load(CSGenio.framework.TableConfiguration.TableConfiguration tableConfig, NameValueCollection requestValues, bool ajaxRequest, bool isToExport, ref ListingMVC<CSGenioAt_005> Qlisting, ref CriteriaSet conditions)
		{
				User u = m_userContext.User;
				Menu = new TablePartial<Fr_002_ValTab_002_RowViewModel>();

				CriteriaSet fr_002__pseudtab_002_Conds = CriteriaSet.And();
				bool tableReload = true;

				//FOR: MENU LIST SORTING
				Dictionary<string, OrderedDictionary> allSortOrders = new Dictionary<string, OrderedDictionary>();



				int numberListItems = tableConfig.RowsPerPage;
				var pageNumber = ajaxRequest ? tableConfig.Page : 1;

				// Added to avoid 0 or -1 pages when setting number of records to -1 to disable pagination
				if (pageNumber < 1)
					pageNumber = 1;

				List<ColumnSort> sorts = GetRequestSorts(this.Menu, tableConfig.ColumnOrderBy, "t_005", allSortOrders);


				FieldRef[] fields = new FieldRef[] { CSGenioAt_005.FldCodt_005, CSGenioAt_005.FldZzstate, CSGenioAt_005.FldClientname, CSGenioAt_005.FldDatre, CSGenioAt_005.FldDescription };


				// Totalizers
				List<FieldRef> fieldsWithTotalizers = fields.Where(field => tableConfig.TotalizerColumns.Contains(field.FullName)).ToList();

				FieldRef firstVisibleColumn = null;

				if (sorts == null)
				{
					firstVisibleColumn = tableConfig?.getFirstVisibleColumn(TableAlias);

					firstVisibleColumn ??= new FieldRef("t_005", "clientname");
				}


				// Limitations
				this.tableLimits ??= [];
				// Comparer to check if limit is already present in tableLimits
				LimitComparer limitComparer = new();

				//Tooltip for EPHs affecting this viewmodel list
				{
					Limit limit = new Limit();
					limit.TipoLimite = LimitType.EPH;
					CSGenioAt_005 model_limit_area = new CSGenioAt_005(m_userContext.User);
					List<Limit> area_EPH_limits = EPH_Limit_Filler(ref limit, model_limit_area, "IBL_FR_002__PSEUDTAB_002_");
					if (area_EPH_limits.Count > 0)
						this.tableLimits.AddRange(area_EPH_limits);
				}


				if (conditions == null)
					conditions = CriteriaSet.And();

				conditions.SubSets.Add(fr_002__pseudtab_002_Conds);
				fr_002__pseudtab_002_Conds = BuildCriteriaSet(tableConfig, requestValues, out bool hasAllRequiredLimits, conditions, isToExport);
				tableReload &= hasAllRequiredLimits;

// USE /[MANUAL RMS OVERRQ FR_002_PSEUDTAB_002]/

				bool distinct = false;

				if (isToExport)
				{
					if (!tableReload)
						return;

					Qlisting = Models.ModelBase.Where<CSGenioAt_005>(m_userContext, false, fr_002__pseudtab_002_Conds, fields, (pageNumber - 1) * numberListItems, numberListItems, sorts, "IBL_FR_002__PSEUDTAB_002_", true, firstVisibleColumn: firstVisibleColumn);

// USE /[MANUAL RMS OVERRQLSTEXP FR_002_PSEUDTAB_002]/

					return;
				}

				if (tableReload)
				{
// USE /[MANUAL RMS OVERRQLIST FR_002_PSEUDTAB_002]/

					string QMVC_POS_RECORD = Navigation.GetStrValue("QMVC_POS_RECORD_t_005");
					Navigation.DestroyEntry("QMVC_POS_RECORD_t_005");
					CriteriaSet m_PagingPosEPHs = null;

					if (!string.IsNullOrEmpty(QMVC_POS_RECORD))
					{
						var m_iCurPag = m_userContext.PersistentSupport.getPagingPos(CSGenioAt_005.GetInformation(), QMVC_POS_RECORD, sorts, fr_002__pseudtab_002_Conds, m_PagingPosEPHs, firstVisibleColumn: firstVisibleColumn);
						if (m_iCurPag != -1)
							pageNumber = ((m_iCurPag - 1) / numberListItems) + 1;
					}

					ListingMVC<CSGenioAt_005> listing = Models.ModelBase.Where<CSGenioAt_005>(m_userContext, distinct, fr_002__pseudtab_002_Conds, fields, (pageNumber - 1) * numberListItems, numberListItems, sorts, "IBL_FR_002__PSEUDTAB_002_", true, false, QMVC_POS_RECORD, m_PagingPosEPHs, firstVisibleColumn, fieldsWithTotalizers, tableConfig.SelectedRows);

					if (listing.CurrentPage > 0)
						pageNumber = listing.CurrentPage;

					//Added to avoid 0 or -1 pages when setting number of records to -1 to disable pagination
					if (pageNumber < 1)
						pageNumber = 1;

					//Set document field values to objects
					SetDocumentFields(listing);

					Menu.Elements = MapFr_002_ValTab_002(listing);

					Menu.Identifier = "IBL_FR_002__PSEUDTAB_002_";

					// Last updated by [CJP] at [2015.02.03]
					// Adds the identifier to each element
					foreach (var element in Menu.Elements)
						element.Identifier = "IBL_FR_002__PSEUDTAB_002_";

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

		private List<Fr_002_ValTab_002_RowViewModel> MapFr_002_ValTab_002(ListingMVC<CSGenioAt_005> Qlisting)
		{
			List<Fr_002_ValTab_002_RowViewModel> Elements = [];
			int i = 0;

			if (Qlisting.Rows != null)
			{
				foreach (var row in Qlisting.Rows)
				{
					if (Qlisting.NumRegs > 0 && i >= Qlisting.NumRegs) // Copiado da versão antiga do RowsToViewModels
						break;
					Elements.Add(MapFr_002_ValTab_002(row));
					i++;
				}
			}

			return Elements;
		}

		/// <summary>
		/// Maps a single CSGenioAt_005 row
		/// to a Fr_002_ValTab_002_RowViewModel object.
		/// </summary>
		/// <param name="row">The row.</param>
		private Fr_002_ValTab_002_RowViewModel MapFr_002_ValTab_002(CSGenioAt_005 row)
		{
			var model = new Fr_002_ValTab_002_RowViewModel(m_userContext, true, _fieldsToSerialize);
			if (row == null)
				return model;

			foreach (RequestedField Qfield in row.Fields.Values)
			{
				switch (Qfield.Area)
				{
					case "t_005":
						model.klass.insertNameValueField(Qfield.FullName, Qfield.Value); break;
					default:
						break;
				}
			}

			model.InitRowData();

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
		private void SetDocumentFields(ListingMVC<CSGenioAt_005> listing)
		{
		}

		#region Mapper

		/// <inheritdoc />
		public override void MapFromModel(Models.T_005 m)
		{
		}

		/// <inheritdoc />
		public override void MapToModel(Models.T_005 m)
		{
		}

		#endregion

		#region Custom code

// USE /[MANUAL RMS VIEWMODEL_CUSTOM FR_002_VALTAB_002]/

		#endregion

		private static readonly string[] _fieldsToSerialize =
		[
			"T_005", "T_005.ValCodt_005", "T_005.ValZzstate", "T_005.ValClientname", "T_005.ValDatre", "T_005.ValDescription", "T_005.ValCodt_002"
		];

		private static readonly List<TableSearchColumn> _searchableColumns =
		[
			new TableSearchColumn("ValClientname", CSGenioAt_005.FldClientname, typeof(string), defaultSearch : true),
			new TableSearchColumn("ValDatre", CSGenioAt_005.FldDatre, typeof(DateTime?)),
			new TableSearchColumn("ValDescription", CSGenioAt_005.FldDescription, typeof(string)),
		];
	}
}
