using JsonIgnoreAttribute = System.Text.Json.Serialization.JsonIgnoreAttribute;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;

using CSGenio.business;
using CSGenio.framework;
using CSGenio.persistence;
using GenioMVC.Helpers;
using GenioMVC.Models.Exception;
using GenioMVC.Models.Navigation;
using Quidgest.Persistence;
using Quidgest.Persistence.GenericQuery;

namespace GenioMVC.ViewModels.T_002
{
	public class Fr_002_ViewModel : FormViewModel<Models.T_002>, IPreparableForSerialization
	{
		[JsonIgnore]
		public override bool HasWriteConditions { get => false; }

		/// <summary>
		/// Reference for the Models MsqActive property
		/// </summary>
		[JsonIgnore]
		public bool MsqActive { get; set; } = false;

		#region Foreign keys
		/// <summary>
		/// Title: "" | Type: "CE"
		/// </summary>
		[ValidateSetAccess]
		public string ValCodt_001 { get; set; }
		/// <summary>
		/// Title: "City" | Type: "CE"
		/// </summary>
		public string ValCodt_004 { get; set; }

		#endregion
		/// <summary>
		/// Title: "Property Photo" | Type: "IJ"
		/// </summary>
		[ImageThumbnailJsonConverter(30, 50)]
		public GenioMVC.Models.ImageModel ValPhoto { get; set; }
		/// <summary>
		/// Title: "Property Title" | Type: "C"
		/// </summary>
		public string ValTitle { get; set; }
		/// <summary>
		/// Title: "Property Price" | Type: "$"
		/// </summary>
		public decimal? ValPrice { get; set; }
		/// <summary>
		/// Title: "City" | Type: "C"
		/// </summary>
		[ValidateSetAccess]
		public TableDBEdit<GenioMVC.Models.T_004> TableT_004F_001 { get; set; }
		/// <summary>
		/// Title: "Year Built" | Type: "N"
		/// </summary>
		public decimal? ValYearbuilt { get; set; }
		/// <summary>
		/// Title: "Size" | Type: "N"
		/// </summary>
		public decimal? ValSize { get; set; }
		/// <summary>
		/// Title: "Bathroums Number" | Type: "N"
		/// </summary>
		public decimal? ValBathnumber { get; set; }



		#region Navigations
		#endregion

		#region Auxiliar Keys for Image controls



		#endregion

		#region Extra database fields



		#endregion

		#region Fields for formulas


		#endregion

		public string ValCodt_002 { get; set; }


		/// <summary>
		/// FOR DESERIALIZATION ONLY
		/// A call to Init() needs to be manually invoked after this constructor
		/// </summary>
		[Obsolete("For deserialization only")]
		public Fr_002_ViewModel() : base(null!) { }

		public Fr_002_ViewModel(UserContext userContext, bool nestedForm = false) : base(userContext, "FFR_002", nestedForm) { }

		public Fr_002_ViewModel(UserContext userContext, Models.T_002 row, bool nestedForm = false) : base(userContext, "FFR_002", row, nestedForm) { }

		public Fr_002_ViewModel(UserContext userContext, string id, bool nestedForm = false, string[]? fieldsToLoad = null) : this(userContext, nestedForm)
		{
			this.Navigation.SetValue("t_002", id);
			Model = Models.T_002.Find(id, userContext, "FFR_002", fieldsToQuery: fieldsToLoad);
			if (Model == null)
				throw new ModelNotFoundException("Model not found");
			InitModel();
		}

		protected override void InitLevels()
		{
			this.RoleToShow = CSGenio.framework.Role.ROLE_1;
			this.RoleToEdit = CSGenio.framework.Role.ROLE_1;
		}

		#region Form conditions

		public override StatusMessage InsertConditions()
		{
			return InsertConditions(m_userContext);
		}

		public static StatusMessage InsertConditions(UserContext userContext)
		{
			var m_userContext = userContext;
			StatusMessage result = new StatusMessage(Status.OK, "");
			Models.T_002 model = new Models.T_002(userContext) { Identifier = "FFR_002" };

			var navigation = m_userContext.CurrentNavigation;
			// The "LoadKeysFromHistory" must be after the "LoadEPH" because the PHE's in the tree mark Foreign Keys to null
			// (since they cannot assign multiple values to a single field) and thus the value that comes from Navigation is lost.
			// And this makes it more like the order of loading the model when opening the form.
			model.LoadEPH("FFR_002");
			if (navigation != null)
				model.LoadKeysFromHistory(navigation, navigation.CurrentLevel.Level);

			var tableResult = model.EvaluateTableConditions(ConditionType.INSERT);
			result.MergeStatusMessage(tableResult);
			return result;
		}

		public override StatusMessage UpdateConditions()
		{
			StatusMessage result = new StatusMessage(Status.OK, "");
			var model = Model;

			var tableResult = model.EvaluateTableConditions(ConditionType.UPDATE);
			result.MergeStatusMessage(tableResult);
			return result;
		}

		public override StatusMessage DeleteConditions()
		{
			StatusMessage result = new StatusMessage(Status.OK, "");
			var model = Model;

			var tableResult = model.EvaluateTableConditions(ConditionType.DELETE);
			result.MergeStatusMessage(tableResult);
			return result;
		}

		public override StatusMessage ViewConditions()
		{
			var model = Model;
			StatusMessage result = model.EvaluateTableConditions(ConditionType.VIEW);
			var tableResult = model.EvaluateTableConditions(ConditionType.VIEW);
			result.MergeStatusMessage(tableResult);
			return result;
		}

		public override StatusMessage EvaluateWriteConditions(bool isApply)
		{
			StatusMessage result = new StatusMessage(Status.OK, "");
			return result;
		}

		public StatusMessage EvaluateTableConditions(ConditionType type)
		{
			return Model.EvaluateTableConditions(type);
		}

		#endregion

		#region Mapper

		/// <inheritdoc />
		public override void MapFromModel(Models.T_002 m)
		{
			if (m == null)
			{
				CSGenio.framework.Log.Error("Map Model (T_002) to ViewModel (Fr_002) - Model is a null reference");
				throw new ModelNotFoundException("Model not found");
			}

			try
			{
				ValCodt_001 = ViewModelConversion.ToString(m.ValCodt_001);
				ValCodt_004 = ViewModelConversion.ToString(m.ValCodt_004);
				ValPhoto = ViewModelConversion.ToImage(m.ValPhoto);
				ValTitle = ViewModelConversion.ToString(m.ValTitle);
				ValPrice = ViewModelConversion.ToNumeric(m.ValPrice);
				ValYearbuilt = ViewModelConversion.ToNumeric(m.ValYearbuilt);
				ValSize = ViewModelConversion.ToNumeric(m.ValSize);
				ValBathnumber = ViewModelConversion.ToNumeric(m.ValBathnumber);
				ValCodt_002 = ViewModelConversion.ToString(m.ValCodt_002);
			}
			catch (Exception)
			{
				CSGenio.framework.Log.Error("Map Model (T_002) to ViewModel (Fr_002) - Error during mapping");
				throw;
			}
		}

		/// <inheritdoc />
		public override void MapToModel()
		{
			MapToModel(this.Model);
		}

		/// <inheritdoc />
		public override void MapToModel(Models.T_002 m)
		{
			if (m == null)
			{
				CSGenio.framework.Log.Error("Map ViewModel (Fr_002) to Model (T_002) - Model is a null reference");
				throw new ModelNotFoundException("Model not found");
			}

			try
			{
				m.ValCodt_004 = ViewModelConversion.ToString(ValCodt_004);
				if (ValPhoto == null || !ValPhoto.IsThumbnail)
					m.ValPhoto = ViewModelConversion.ToImage(ValPhoto);
				m.ValTitle = ViewModelConversion.ToString(ValTitle);
				m.ValPrice = ViewModelConversion.ToNumeric(ValPrice);
				m.ValYearbuilt = ViewModelConversion.ToNumeric(ValYearbuilt);
				m.ValSize = ViewModelConversion.ToNumeric(ValSize);
				m.ValBathnumber = ViewModelConversion.ToNumeric(ValBathnumber);
				m.ValCodt_002 = ViewModelConversion.ToString(ValCodt_002);

				/*
					At this moment, in the case of runtime calculation of server-side formulas, to improve performance and reduce database load,
						the values coming from the client-side will be accepted as valid, since they will not be saved and are only being used for calculation.
				*/
				if (!HasDisabledUserValuesSecurity)
					return;

				m.ValCodt_001 = ViewModelConversion.ToString(ValCodt_001);
			}
			catch (Exception)
			{
				CSGenio.framework.Log.Error($"Map ViewModel (Fr_002) to Model (T_002) - Error during mapping. All user values: {HasDisabledUserValuesSecurity}");
				throw;
			}
		}

		/// <summary>
		/// Sets the value of a single property of the view model based on the provided table and field names.
		/// </summary>
		/// <param name="fullFieldName">The full field name in the format "table.field".</param>
		/// <param name="value">The field value.</param>
		/// <exception cref="ArgumentNullException">Thrown if <paramref name="fullFieldName"/> is null.</exception>
		public override void SetViewModelValue(string fullFieldName, object value)
		{
			try
			{
				ArgumentNullException.ThrowIfNull(fullFieldName);
				// Obtain a valid value from JsonValueKind that can come from "prefillValues" during the pre-filling of fields during insertion
				var _value = ViewModelConversion.ToRawValue(value);

				switch (fullFieldName)
				{
					case "t_002.codt_004":
						this.ValCodt_004 = ViewModelConversion.ToString(_value);
						break;
					case "t_002.photo":
						this.ValPhoto = ViewModelConversion.ToImage(_value);
						break;
					case "t_002.title":
						this.ValTitle = ViewModelConversion.ToString(_value);
						break;
					case "t_002.price":
						this.ValPrice = ViewModelConversion.ToNumeric(_value);
						break;
					case "t_002.yearbuilt":
						this.ValYearbuilt = ViewModelConversion.ToNumeric(_value);
						break;
					case "t_002.size":
						this.ValSize = ViewModelConversion.ToNumeric(_value);
						break;
					case "t_002.bathnumber":
						this.ValBathnumber = ViewModelConversion.ToNumeric(_value);
						break;
					case "t_002.codt_002":
						this.ValCodt_002 = ViewModelConversion.ToString(_value);
						break;
					default:
						Log.Error($"SetViewModelValue (Fr_002) - Unexpected field identifier {fullFieldName}");
						break;
				}
			}
			catch (Exception ex)
			{
				throw new FrameworkException(Resources.Resources.PEDIMOS_DESCULPA__OC63848, "SetViewModelValue (Fr_002)", "Unexpected error", ex);
			}
		}

		#endregion

		/// <summary>
		/// Reads the Model from the database based on the key that is in the history or that was passed through the parameter
		/// </summary>
		/// <param name="id">The primary key of the record that needs to be read from the database. Leave NULL to use the value from the History.</param>
		public override void LoadModel(string id = null)
		{
			try { Model = Models.T_002.Find(id ?? Navigation.GetStrValue("t_002"), m_userContext, "FFR_002"); }
			finally { Model ??= new Models.T_002(m_userContext) { Identifier = "FFR_002" }; }

			base.LoadModel();
		}

		public override void Load(NameValueCollection qs, bool editable, bool ajaxRequest = false, bool lazyLoad = false)
		{
			this.editable = editable;
			CSGenio.business.Area oldvalues = null;

			// TODO: Deve ser substituido por search do CSGenioA
			try
			{
				Model = Models.T_002.Find(Navigation.GetStrValue("t_002"), m_userContext, "FFR_002");
			}
			finally
			{
				if (Model == null)
					throw new ModelNotFoundException("Model not found");

				if (Navigation.CurrentLevel.FormMode == FormMode.New || Navigation.CurrentLevel.FormMode == FormMode.Duplicate)
					LoadDefaultValues();
				else
					oldvalues = Model.klass;
			}

			Model.Identifier = "FFR_002";
			InitModel(qs, lazyLoad);

			if (Navigation.CurrentLevel.FormMode == FormMode.New || Navigation.CurrentLevel.FormMode == FormMode.Edit || Navigation.CurrentLevel.FormMode == FormMode.Duplicate)
			{
				// MH - Voltar calcular as formulas to "atualizar" os Qvalues dos fields fixos
				// Conexão deve estar aberta de fora. Podem haver formulas que utilizam funções "manuais".
				// TODO: It needs to be analyzed whether we should disable the security of field filling here. If there is any case where the field with the block condition can only be calculated after the double calculation of the formulas.
				MapToModel(Model);

				// If it's inserting or duplicating, needs to fill the default values.
				if (Navigation.CurrentLevel.FormMode == FormMode.New || Navigation.CurrentLevel.FormMode == FormMode.Duplicate)
				{
					FunctionType funcType = Navigation.CurrentLevel.FormMode == FormMode.New
						? FunctionType.INS
						: FunctionType.DUP;

					Model.baseklass.fillValuesDefault(m_userContext.PersistentSupport, funcType);
				}

				// Preencher operações internas
				Model.klass.fillInternalOperations(m_userContext.PersistentSupport, oldvalues);
				MapFromModel(Model);
			}

			// Load just the selected row primary keys for checklists.
			// Needed for submitting forms incase checklists are in collapsible zones that have not been expanded to load the checklist data.
			LoadChecklistsSelectedIDs();
		}

		protected override void FillExtraProperties()
		{
		}

		protected override void LoadDocumentsProperties(Models.T_002 row)
		{
		}

		/// <summary>
		/// Load Partial
		/// </summary>
		/// <param name="lazyLoad">Lazy loading of dropdown items</param>
		public override void LoadPartial(NameValueCollection qs, bool lazyLoad = false)
		{
			// MH [bugfix] - Quando o POST da ficha falha, ao recaregar a view os documentos na BD perdem alguma informação (ex: name do file)
			if (Model == null)
			{
				// Precisamos fazer o Find to obter as chaves dos documentos que já foram anexados
				// TODO: Conseguir passar estas chaves no POST to poder retirar o Find.
				Model = Models.T_002.Find(Navigation.GetStrValue("t_002"), m_userContext, "FFR_002");
				if (Model == null)
				{
					Model = new Models.T_002(m_userContext) { Identifier = "FFR_002" };
					Model.klass.QPrimaryKey = Navigation.GetStrValue("t_002");
				}
				MapToModel(Model);
				LoadDocumentsProperties(Model);
			}
			// Add characteristics
			Characs = new List<string>();

			Load_Fr_002__t_004f_001___(qs, lazyLoad);
// USE /[MANUAL RMS VIEWMODEL_LOADPARTIAL FR_002]/
		}

// USE /[MANUAL RMS VIEWMODEL_NEW FR_002]/

		// Preencher Qvalues default dos fields do form
		protected override void LoadDefaultValues()
		{
		}

		public override CrudViewModelValidationResult Validate()
		{
			CrudViewModelFieldValidator validator = new(m_userContext.User.Language);

			validator.StringLength("ValTitle", Resources.Resources.PROPERTY_TITLE56931, ValTitle, 50);

			validator.Required("ValTitle", Resources.Resources.PROPERTY_TITLE56931, ViewModelConversion.ToString(ValTitle), FieldType.TEXT.GetFormatting());

			validator.Required("ValPrice", Resources.Resources.PROPERTY_PRICE21441, ViewModelConversion.ToNumeric(ValPrice), FieldType.CURRENCY.GetFormatting());

			validator.Required("ValYearbuilt", Resources.Resources.YEAR_BUILT55277, ViewModelConversion.ToNumeric(ValYearbuilt), FieldType.NUMERIC.GetFormatting());

			validator.Required("ValSize", Resources.Resources.SIZE10299, ViewModelConversion.ToNumeric(ValSize), FieldType.NUMERIC.GetFormatting());

			validator.Required("ValBathnumber", Resources.Resources.BATHROUMS_NUMBER42941, ViewModelConversion.ToNumeric(ValBathnumber), FieldType.NUMERIC.GetFormatting());


			return validator.GetResult();
		}

		public override void Init(UserContext userContext)
		{
			base.Init(userContext);
		}
// USE /[MANUAL RMS VIEWMODEL_SAVE FR_002]/
		public override void Save()
		{


			base.Save();
		}

// USE /[MANUAL RMS VIEWMODEL_APPLY FR_002]/

// USE /[MANUAL RMS VIEWMODEL_DUPLICATE FR_002]/

// USE /[MANUAL RMS VIEWMODEL_DESTROY FR_002]/
		public override void Destroy(string id)
		{
			Model = Models.T_002.Find(id, m_userContext, "FFR_002");
			if (Model == null)
				throw new ModelNotFoundException("Model not found");
			this.flashMessage = Model.Destroy();
		}

		/// <summary>
		/// Load selected row primary keys for all checklists
		/// </summary>
		public void LoadChecklistsSelectedIDs()
		{
		}

		/// <summary>
		/// TableT_004F_001 -> (DB)
		/// </summary>
		/// <param name="qs"></param>
		/// <param name="lazyLoad">Lazy loading of dropdown items</param>
		public void Load_Fr_002__t_004f_001___(NameValueCollection qs, bool lazyLoad = false)
		{
			bool fr_002__t_004f_001___DoLoad = true;
			CriteriaSet fr_002__t_004f_001___Conds = CriteriaSet.And();
			{
				object hValue = Navigation.GetValue("t_004", true);
				if (hValue != null && !(hValue is Array) && !string.IsNullOrEmpty(Convert.ToString(hValue)))
				{
					fr_002__t_004f_001___Conds.Equal(CSGenioAt_004.FldCodt_004, hValue);
					this.ValCodt_004 = DBConversion.ToString(hValue);
				}
			}

			TableT_004F_001 = new TableDBEdit<Models.T_004>
			{
				IsLazyLoad = lazyLoad
			};

			if (lazyLoad)
			{
				if (Navigation.CurrentLevel.GetEntry("RETURN_t_004") != null)
				{
					this.ValCodt_004 = Navigation.GetStrValue("RETURN_t_004");
					Navigation.CurrentLevel.SetEntry("RETURN_t_004", null);
				}
				FillDependant_Fr_002TableT_004F_001(lazyLoad);
				return;
			}

			if (fr_002__t_004f_001___DoLoad)
			{
				List<ColumnSort> sorts = new List<ColumnSort>();
				ColumnSort requestedSort = GetRequestSort(TableT_004F_001, "sTableT_004F_001", "dTableT_004F_001", qs, "t_004");
				if (requestedSort != null)
					sorts.Add(requestedSort);
				sorts.Add(new ColumnSort(new ColumnReference(CSGenioAt_004.FldCity), SortOrder.Ascending));

				string query = "";
				if (!string.IsNullOrEmpty(qs["TableT_004F_001_tableFilters"]))
					TableT_004F_001.TableFilters = bool.Parse(qs["TableT_004F_001_tableFilters"]);
				else
					TableT_004F_001.TableFilters = false;

				query = qs["qTableT_004F_001"];

				//RS 26.07.2016 O preenchimento da lista de ajuda dos Dbedits passa a basear-se apenas no campo do próprio DbEdit
				// O interface de pesquisa rápida não fica coerente quando se visualiza apenas uma coluna mas a pesquisa faz matching com 5 ou 6 colunas diferentes
				//  tornando confuso to o user porque determinada row foi devolvida quando o Qresult não mostra como o matching foi feito
				CriteriaSet search_filters = CriteriaSet.And();
				if (!string.IsNullOrEmpty(query))
				{
					search_filters.Like(CSGenioAt_004.FldCity, query + "%");
				}
				fr_002__t_004f_001___Conds.SubSet(search_filters);

				string tryParsePage = qs["pTableT_004F_001"] != null ? qs["pTableT_004F_001"].ToString() : "1";
				int page = !string.IsNullOrEmpty(tryParsePage) ? int.Parse(tryParsePage) : 1;
				int numberItems = CSGenio.framework.Configuration.NrRegDBedit;
				int offset = (page - 1) * numberItems;

				FieldRef[] fields = new FieldRef[] { CSGenioAt_004.FldCodt_004, CSGenioAt_004.FldCity, CSGenioAt_004.FldZzstate };

// USE /[MANUAL RMS OVERRQ FR_002_T_004F_001]/

				// Limitation by Zzstate
				/*
					Records that are currently being inserted or duplicated will also be included.
					Client-side persistence will try to fill the "text" value of that option.
				*/
				if (Navigation.checkFormMode("t_004", FormMode.New) || Navigation.checkFormMode("t_004", FormMode.Duplicate))
					fr_002__t_004f_001___Conds.SubSet(CriteriaSet.Or()
						.Equal(CSGenioAt_004.FldZzstate, 0)
						.Equal(CSGenioAt_004.FldCodt_004, Navigation.GetStrValue("t_004")));
				else
					fr_002__t_004f_001___Conds.Criterias.Add(new Criteria(new ColumnReference(CSGenioAt_004.FldZzstate), CriteriaOperator.Equal, 0));

				FieldRef firstVisibleColumn = new FieldRef("t_004", "city");
				ListingMVC<CSGenioAt_004> listing = Models.ModelBase.Where<CSGenioAt_004>(m_userContext, false, fr_002__t_004f_001___Conds, fields, offset, numberItems, sorts, "LED_FR_002__T_004F_001___", true, false, firstVisibleColumn: firstVisibleColumn);

				TableT_004F_001.SetPagination(page, numberItems, listing.HasMore, listing.GetTotal, listing.TotalRecords);
				TableT_004F_001.Query = query;
				TableT_004F_001.Elements = listing.RowsForViewModel<GenioMVC.Models.T_004>((r) => new GenioMVC.Models.T_004(m_userContext, r, true, _fieldsToSerialize_FR_002__T_004F_001___));

				//created by [ MH ] at [ 14.04.2016 ] - Foi alterada a forma de retornar a key do novo registo inserido / editado no form de apoio do DBEdit.
				//last update by [ MH ] at [ 10.05.2016 ] - Validação se key encontra-se no level atual, as chaves dos niveis anteriores devem ser ignorados.
				if (Navigation.CurrentLevel.GetEntry("RETURN_t_004") != null)
				{
					this.ValCodt_004 = Navigation.GetStrValue("RETURN_t_004");
					Navigation.CurrentLevel.SetEntry("RETURN_t_004", null);
				}

				TableT_004F_001.List = new SelectList(TableT_004F_001.Elements.ToSelectList(x => x.ValCity, x => x.ValCodt_004,  x => x.ValCodt_004 == this.ValCodt_004), "Value", "Text", this.ValCodt_004);
				FillDependant_Fr_002TableT_004F_001();
			}
		}

		/// <summary>
		/// Get Dependant fields values -> TableT_004F_001 (DB)
		/// </summary>
		/// <param name="PKey">Primary Key of T_004</param>
		public ConcurrentDictionary<string, object> GetDependant_Fr_002TableT_004F_001(string PKey)
		{
			FieldRef[] refDependantFields = [CSGenioAt_004.FldCodt_004, CSGenioAt_004.FldCity];

			var returnEmptyDependants = false;
			CriteriaSet wherecodition = CriteriaSet.And();

			// Return default values
			if (GenFunctions.emptyG(PKey) == 1)
				returnEmptyDependants = true;

			// Check if the limit(s) is filled if exists
			// - - - - - - - - - - - - - - - - - - - - -

			if (returnEmptyDependants)
				return GetViewModelFieldValues(refDependantFields);

			PersistentSupport sp = m_userContext.PersistentSupport;
			User u = m_userContext.User;

			CSGenioAt_004 tempArea = new(u);

			// Fields to select
			SelectQuery querySelect = new();
			querySelect.PageSize(1);
			foreach (FieldRef field in refDependantFields)
				querySelect.Select(field);

			querySelect.From(tempArea.QSystem, tempArea.TableName, tempArea.Alias)
				.Where(wherecodition.Equal(CSGenioAt_004.FldCodt_004, PKey));

			string[] dependantFields = refDependantFields.Select(f => f.FullName).ToArray();
			QueryUtils.SetInnerJoins(dependantFields, null, tempArea, querySelect);

			ArrayList values = sp.executeReaderOneRow(querySelect);
			bool useDefaults = values.Count == 0;

			if (useDefaults)
				return GetViewModelFieldValues(refDependantFields);
			return GetViewModelFieldValues(refDependantFields, values);
		}

		/// <summary>
		/// Fill Dependant fields values -> TableT_004F_001 (DB)
		/// </summary>
		/// <param name="lazyLoad">Lazy loading of dropdown items</param>
		public void FillDependant_Fr_002TableT_004F_001(bool lazyLoad = false)
		{
			var row = GetDependant_Fr_002TableT_004F_001(this.ValCodt_004);
			try
			{

				// Fill List fields
				this.ValCodt_004 = ViewModelConversion.ToString(row["t_004.codt_004"]);
				TableT_004F_001.Value = (string)row["t_004.city"];
				if (GenFunctions.emptyG(this.ValCodt_004) == 1)
				{
					this.ValCodt_004 = "";
					TableT_004F_001.Value = "";
					Navigation.ClearValue("t_004");
				}
				else if (lazyLoad)
				{
					TableT_004F_001.SetPagination(1, 0, false, false, 1);
					TableT_004F_001.List = new SelectList(new List<SelectListItem>()
					{
						new SelectListItem
						{
							Value = Convert.ToString(this.ValCodt_004),
							Text = Convert.ToString(TableT_004F_001.Value),
							Selected = true
						}
					}, "Value", "Text", this.ValCodt_004);
				}

				TableT_004F_001.Selected = this.ValCodt_004;
			}
			catch (Exception ex)
			{
				CSGenio.framework.Log.Error(string.Format("FillDependant_Error (TableT_004F_001): {0}; {1}", ex.Message, ex.InnerException != null ? ex.InnerException.Message : ""));
			}
		}

		private readonly string[] _fieldsToSerialize_FR_002__T_004F_001___ = ["T_004", "T_004.ValCodt_004", "T_004.ValZzstate", "T_004.ValCity"];

		protected override object GetViewModelValue(string identifier, object modelValue)
		{
			return identifier switch
			{
				"t_002.codt_001" => ViewModelConversion.ToString(modelValue),
				"t_002.codt_004" => ViewModelConversion.ToString(modelValue),
				"t_002.photo" => ViewModelConversion.ToImage(modelValue),
				"t_002.title" => ViewModelConversion.ToString(modelValue),
				"t_002.price" => ViewModelConversion.ToNumeric(modelValue),
				"t_002.yearbuilt" => ViewModelConversion.ToNumeric(modelValue),
				"t_002.size" => ViewModelConversion.ToNumeric(modelValue),
				"t_002.bathnumber" => ViewModelConversion.ToNumeric(modelValue),
				"t_002.codt_002" => ViewModelConversion.ToString(modelValue),
				"t_004.codt_004" => ViewModelConversion.ToString(modelValue),
				"t_004.city" => ViewModelConversion.ToString(modelValue),
				_ => modelValue
			};
		}

		/// <inheritdoc/>
		protected override void SetTicketToImageFields()
		{
			if (ValPhoto != null)
				ValPhoto.Ticket = Helpers.Helpers.GetFileTicket(m_userContext.User, CSGenio.business.Area.AreaT_002, CSGenioAt_002.FldPhoto.Field, null, ValCodt_002);
		}

		#region Charts


		#endregion

		#region Custom code

// USE /[MANUAL RMS VIEWMODEL_CUSTOM FR_002]/

		#endregion
	}
}
