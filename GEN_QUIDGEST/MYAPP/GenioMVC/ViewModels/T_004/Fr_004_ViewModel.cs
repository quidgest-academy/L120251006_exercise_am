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

namespace GenioMVC.ViewModels.T_004
{
	public class Fr_004_ViewModel : FormViewModel<Models.T_004>, IPreparableForSerialization
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
		/// Title: "Country Name" | Type: "CE"
		/// </summary>
		public string ValCodt_003 { get; set; }

		#endregion
		/// <summary>
		/// Title: "City" | Type: "C"
		/// </summary>
		public string ValCity { get; set; }
		/// <summary>
		/// Title: "Country Name" | Type: "C"
		/// </summary>
		[ValidateSetAccess]
		public TableDBEdit<GenioMVC.Models.T_003> TableT_003F_001 { get; set; }



		#region Navigations
		#endregion

		#region Auxiliar Keys for Image controls



		#endregion

		#region Extra database fields



		#endregion

		#region Fields for formulas


		#endregion

		public string ValCodt_004 { get; set; }


		/// <summary>
		/// FOR DESERIALIZATION ONLY
		/// A call to Init() needs to be manually invoked after this constructor
		/// </summary>
		[Obsolete("For deserialization only")]
		public Fr_004_ViewModel() : base(null!) { }

		public Fr_004_ViewModel(UserContext userContext, bool nestedForm = false) : base(userContext, "FFR_004", nestedForm) { }

		public Fr_004_ViewModel(UserContext userContext, Models.T_004 row, bool nestedForm = false) : base(userContext, "FFR_004", row, nestedForm) { }

		public Fr_004_ViewModel(UserContext userContext, string id, bool nestedForm = false, string[]? fieldsToLoad = null) : this(userContext, nestedForm)
		{
			this.Navigation.SetValue("t_004", id);
			Model = Models.T_004.Find(id, userContext, "FFR_004", fieldsToQuery: fieldsToLoad);
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
			Models.T_004 model = new Models.T_004(userContext) { Identifier = "FFR_004" };

			var navigation = m_userContext.CurrentNavigation;
			// The "LoadKeysFromHistory" must be after the "LoadEPH" because the PHE's in the tree mark Foreign Keys to null
			// (since they cannot assign multiple values to a single field) and thus the value that comes from Navigation is lost.
			// And this makes it more like the order of loading the model when opening the form.
			model.LoadEPH("FFR_004");
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
		public override void MapFromModel(Models.T_004 m)
		{
			if (m == null)
			{
				CSGenio.framework.Log.Error("Map Model (T_004) to ViewModel (Fr_004) - Model is a null reference");
				throw new ModelNotFoundException("Model not found");
			}

			try
			{
				ValCodt_003 = ViewModelConversion.ToString(m.ValCodt_003);
				ValCity = ViewModelConversion.ToString(m.ValCity);
				ValCodt_004 = ViewModelConversion.ToString(m.ValCodt_004);
			}
			catch (Exception)
			{
				CSGenio.framework.Log.Error("Map Model (T_004) to ViewModel (Fr_004) - Error during mapping");
				throw;
			}
		}

		/// <inheritdoc />
		public override void MapToModel()
		{
			MapToModel(this.Model);
		}

		/// <inheritdoc />
		public override void MapToModel(Models.T_004 m)
		{
			if (m == null)
			{
				CSGenio.framework.Log.Error("Map ViewModel (Fr_004) to Model (T_004) - Model is a null reference");
				throw new ModelNotFoundException("Model not found");
			}

			try
			{
				m.ValCodt_003 = ViewModelConversion.ToString(ValCodt_003);
				m.ValCity = ViewModelConversion.ToString(ValCity);
				m.ValCodt_004 = ViewModelConversion.ToString(ValCodt_004);
			}
			catch (Exception)
			{
				CSGenio.framework.Log.Error($"Map ViewModel (Fr_004) to Model (T_004) - Error during mapping. All user values: {HasDisabledUserValuesSecurity}");
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
					case "t_004.codt_003":
						this.ValCodt_003 = ViewModelConversion.ToString(_value);
						break;
					case "t_004.city":
						this.ValCity = ViewModelConversion.ToString(_value);
						break;
					case "t_004.codt_004":
						this.ValCodt_004 = ViewModelConversion.ToString(_value);
						break;
					default:
						Log.Error($"SetViewModelValue (Fr_004) - Unexpected field identifier {fullFieldName}");
						break;
				}
			}
			catch (Exception ex)
			{
				throw new FrameworkException(Resources.Resources.PEDIMOS_DESCULPA__OC63848, "SetViewModelValue (Fr_004)", "Unexpected error", ex);
			}
		}

		#endregion

		/// <summary>
		/// Reads the Model from the database based on the key that is in the history or that was passed through the parameter
		/// </summary>
		/// <param name="id">The primary key of the record that needs to be read from the database. Leave NULL to use the value from the History.</param>
		public override void LoadModel(string id = null)
		{
			try { Model = Models.T_004.Find(id ?? Navigation.GetStrValue("t_004"), m_userContext, "FFR_004"); }
			finally { Model ??= new Models.T_004(m_userContext) { Identifier = "FFR_004" }; }

			base.LoadModel();
		}

		public override void Load(NameValueCollection qs, bool editable, bool ajaxRequest = false, bool lazyLoad = false)
		{
			this.editable = editable;
			CSGenio.business.Area oldvalues = null;

			// TODO: Deve ser substituido por search do CSGenioA
			try
			{
				Model = Models.T_004.Find(Navigation.GetStrValue("t_004"), m_userContext, "FFR_004");
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

			Model.Identifier = "FFR_004";
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

		protected override void LoadDocumentsProperties(Models.T_004 row)
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
				Model = Models.T_004.Find(Navigation.GetStrValue("t_004"), m_userContext, "FFR_004");
				if (Model == null)
				{
					Model = new Models.T_004(m_userContext) { Identifier = "FFR_004" };
					Model.klass.QPrimaryKey = Navigation.GetStrValue("t_004");
				}
				MapToModel(Model);
				LoadDocumentsProperties(Model);
			}
			// Add characteristics
			Characs = new List<string>();

			Load_Fr_004__t_003f_001___(qs, lazyLoad);
// USE /[MANUAL RMS VIEWMODEL_LOADPARTIAL FR_004]/
		}

// USE /[MANUAL RMS VIEWMODEL_NEW FR_004]/

		// Preencher Qvalues default dos fields do form
		protected override void LoadDefaultValues()
		{
		}

		public override CrudViewModelValidationResult Validate()
		{
			CrudViewModelFieldValidator validator = new(m_userContext.User.Language);

			validator.StringLength("ValCity", Resources.Resources.CITY42505, ValCity, 50);

			validator.Required("ValCity", Resources.Resources.CITY42505, ViewModelConversion.ToString(ValCity), FieldType.TEXT.GetFormatting());


			return validator.GetResult();
		}

		public override void Init(UserContext userContext)
		{
			base.Init(userContext);
		}
// USE /[MANUAL RMS VIEWMODEL_SAVE FR_004]/
		public override void Save()
		{


			base.Save();
		}

// USE /[MANUAL RMS VIEWMODEL_APPLY FR_004]/

// USE /[MANUAL RMS VIEWMODEL_DUPLICATE FR_004]/

// USE /[MANUAL RMS VIEWMODEL_DESTROY FR_004]/
		public override void Destroy(string id)
		{
			Model = Models.T_004.Find(id, m_userContext, "FFR_004");
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
		/// TableT_003F_001 -> (DB)
		/// </summary>
		/// <param name="qs"></param>
		/// <param name="lazyLoad">Lazy loading of dropdown items</param>
		public void Load_Fr_004__t_003f_001___(NameValueCollection qs, bool lazyLoad = false)
		{
			bool fr_004__t_003f_001___DoLoad = true;
			CriteriaSet fr_004__t_003f_001___Conds = CriteriaSet.And();
			{
				object hValue = Navigation.GetValue("t_003", true);
				if (hValue != null && !(hValue is Array) && !string.IsNullOrEmpty(Convert.ToString(hValue)))
				{
					fr_004__t_003f_001___Conds.Equal(CSGenioAt_003.FldCodt_003, hValue);
					this.ValCodt_003 = DBConversion.ToString(hValue);
				}
			}

			TableT_003F_001 = new TableDBEdit<Models.T_003>
			{
				IsLazyLoad = lazyLoad
			};

			if (lazyLoad)
			{
				if (Navigation.CurrentLevel.GetEntry("RETURN_t_003") != null)
				{
					this.ValCodt_003 = Navigation.GetStrValue("RETURN_t_003");
					Navigation.CurrentLevel.SetEntry("RETURN_t_003", null);
				}
				FillDependant_Fr_004TableT_003F_001(lazyLoad);
				return;
			}

			if (fr_004__t_003f_001___DoLoad)
			{
				List<ColumnSort> sorts = new List<ColumnSort>();
				ColumnSort requestedSort = GetRequestSort(TableT_003F_001, "sTableT_003F_001", "dTableT_003F_001", qs, "t_003");
				if (requestedSort != null)
					sorts.Add(requestedSort);
				sorts.Add(new ColumnSort(new ColumnReference(CSGenioAt_003.FldCountry), SortOrder.Ascending));

				string query = "";
				if (!string.IsNullOrEmpty(qs["TableT_003F_001_tableFilters"]))
					TableT_003F_001.TableFilters = bool.Parse(qs["TableT_003F_001_tableFilters"]);
				else
					TableT_003F_001.TableFilters = false;

				query = qs["qTableT_003F_001"];

				//RS 26.07.2016 O preenchimento da lista de ajuda dos Dbedits passa a basear-se apenas no campo do próprio DbEdit
				// O interface de pesquisa rápida não fica coerente quando se visualiza apenas uma coluna mas a pesquisa faz matching com 5 ou 6 colunas diferentes
				//  tornando confuso to o user porque determinada row foi devolvida quando o Qresult não mostra como o matching foi feito
				CriteriaSet search_filters = CriteriaSet.And();
				if (!string.IsNullOrEmpty(query))
				{
					search_filters.Like(CSGenioAt_003.FldCountry, query + "%");
				}
				fr_004__t_003f_001___Conds.SubSet(search_filters);

				string tryParsePage = qs["pTableT_003F_001"] != null ? qs["pTableT_003F_001"].ToString() : "1";
				int page = !string.IsNullOrEmpty(tryParsePage) ? int.Parse(tryParsePage) : 1;
				int numberItems = CSGenio.framework.Configuration.NrRegDBedit;
				int offset = (page - 1) * numberItems;

				FieldRef[] fields = new FieldRef[] { CSGenioAt_003.FldCodt_003, CSGenioAt_003.FldCountry, CSGenioAt_003.FldZzstate };

// USE /[MANUAL RMS OVERRQ FR_004_T_003F_001]/

				// Limitation by Zzstate
				/*
					Records that are currently being inserted or duplicated will also be included.
					Client-side persistence will try to fill the "text" value of that option.
				*/
				if (Navigation.checkFormMode("t_003", FormMode.New) || Navigation.checkFormMode("t_003", FormMode.Duplicate))
					fr_004__t_003f_001___Conds.SubSet(CriteriaSet.Or()
						.Equal(CSGenioAt_003.FldZzstate, 0)
						.Equal(CSGenioAt_003.FldCodt_003, Navigation.GetStrValue("t_003")));
				else
					fr_004__t_003f_001___Conds.Criterias.Add(new Criteria(new ColumnReference(CSGenioAt_003.FldZzstate), CriteriaOperator.Equal, 0));

				FieldRef firstVisibleColumn = new FieldRef("t_003", "country");
				ListingMVC<CSGenioAt_003> listing = Models.ModelBase.Where<CSGenioAt_003>(m_userContext, false, fr_004__t_003f_001___Conds, fields, offset, numberItems, sorts, "LED_FR_004__T_003F_001___", true, false, firstVisibleColumn: firstVisibleColumn);

				TableT_003F_001.SetPagination(page, numberItems, listing.HasMore, listing.GetTotal, listing.TotalRecords);
				TableT_003F_001.Query = query;
				TableT_003F_001.Elements = listing.RowsForViewModel<GenioMVC.Models.T_003>((r) => new GenioMVC.Models.T_003(m_userContext, r, true, _fieldsToSerialize_FR_004__T_003F_001___));

				//created by [ MH ] at [ 14.04.2016 ] - Foi alterada a forma de retornar a key do novo registo inserido / editado no form de apoio do DBEdit.
				//last update by [ MH ] at [ 10.05.2016 ] - Validação se key encontra-se no level atual, as chaves dos niveis anteriores devem ser ignorados.
				if (Navigation.CurrentLevel.GetEntry("RETURN_t_003") != null)
				{
					this.ValCodt_003 = Navigation.GetStrValue("RETURN_t_003");
					Navigation.CurrentLevel.SetEntry("RETURN_t_003", null);
				}

				TableT_003F_001.List = new SelectList(TableT_003F_001.Elements.ToSelectList(x => x.ValCountry, x => x.ValCodt_003,  x => x.ValCodt_003 == this.ValCodt_003), "Value", "Text", this.ValCodt_003);
				FillDependant_Fr_004TableT_003F_001();
			}
		}

		/// <summary>
		/// Get Dependant fields values -> TableT_003F_001 (DB)
		/// </summary>
		/// <param name="PKey">Primary Key of T_003</param>
		public ConcurrentDictionary<string, object> GetDependant_Fr_004TableT_003F_001(string PKey)
		{
			FieldRef[] refDependantFields = [CSGenioAt_003.FldCodt_003, CSGenioAt_003.FldCountry];

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

			CSGenioAt_003 tempArea = new(u);

			// Fields to select
			SelectQuery querySelect = new();
			querySelect.PageSize(1);
			foreach (FieldRef field in refDependantFields)
				querySelect.Select(field);

			querySelect.From(tempArea.QSystem, tempArea.TableName, tempArea.Alias)
				.Where(wherecodition.Equal(CSGenioAt_003.FldCodt_003, PKey));

			string[] dependantFields = refDependantFields.Select(f => f.FullName).ToArray();
			QueryUtils.SetInnerJoins(dependantFields, null, tempArea, querySelect);

			ArrayList values = sp.executeReaderOneRow(querySelect);
			bool useDefaults = values.Count == 0;

			if (useDefaults)
				return GetViewModelFieldValues(refDependantFields);
			return GetViewModelFieldValues(refDependantFields, values);
		}

		/// <summary>
		/// Fill Dependant fields values -> TableT_003F_001 (DB)
		/// </summary>
		/// <param name="lazyLoad">Lazy loading of dropdown items</param>
		public void FillDependant_Fr_004TableT_003F_001(bool lazyLoad = false)
		{
			var row = GetDependant_Fr_004TableT_003F_001(this.ValCodt_003);
			try
			{

				// Fill List fields
				this.ValCodt_003 = ViewModelConversion.ToString(row["t_003.codt_003"]);
				TableT_003F_001.Value = (string)row["t_003.country"];
				if (GenFunctions.emptyG(this.ValCodt_003) == 1)
				{
					this.ValCodt_003 = "";
					TableT_003F_001.Value = "";
					Navigation.ClearValue("t_003");
				}
				else if (lazyLoad)
				{
					TableT_003F_001.SetPagination(1, 0, false, false, 1);
					TableT_003F_001.List = new SelectList(new List<SelectListItem>()
					{
						new SelectListItem
						{
							Value = Convert.ToString(this.ValCodt_003),
							Text = Convert.ToString(TableT_003F_001.Value),
							Selected = true
						}
					}, "Value", "Text", this.ValCodt_003);
				}

				TableT_003F_001.Selected = this.ValCodt_003;
			}
			catch (Exception ex)
			{
				CSGenio.framework.Log.Error(string.Format("FillDependant_Error (TableT_003F_001): {0}; {1}", ex.Message, ex.InnerException != null ? ex.InnerException.Message : ""));
			}
		}

		private readonly string[] _fieldsToSerialize_FR_004__T_003F_001___ = ["T_003", "T_003.ValCodt_003", "T_003.ValZzstate", "T_003.ValCountry"];

		protected override object GetViewModelValue(string identifier, object modelValue)
		{
			return identifier switch
			{
				"t_004.codt_003" => ViewModelConversion.ToString(modelValue),
				"t_004.city" => ViewModelConversion.ToString(modelValue),
				"t_004.codt_004" => ViewModelConversion.ToString(modelValue),
				"t_003.codt_003" => ViewModelConversion.ToString(modelValue),
				"t_003.country" => ViewModelConversion.ToString(modelValue),
				_ => modelValue
			};
		}

		#region Charts


		#endregion

		#region Custom code

// USE /[MANUAL RMS VIEWMODEL_CUSTOM FR_004]/

		#endregion
	}
}
