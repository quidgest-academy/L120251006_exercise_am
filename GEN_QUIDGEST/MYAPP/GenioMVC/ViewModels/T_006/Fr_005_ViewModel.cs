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

namespace GenioMVC.ViewModels.T_006
{
	public class Fr_005_ViewModel : FormViewModel<Models.T_006>, IPreparableForSerialization
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
		/// Title: "Property Title" | Type: "CE"
		/// </summary>
		public string ValCodt_002 { get; set; }

		#endregion
		/// <summary>
		/// Title: "Photo" | Type: "IJ"
		/// </summary>
		[ImageThumbnailJsonConverter(100, 50)]
		public GenioMVC.Models.ImageModel ValPhoto { get; set; }
		/// <summary>
		/// Title: "Description" | Type: "C"
		/// </summary>
		public string ValDescription { get; set; }
		/// <summary>
		/// Title: "Property Title" | Type: "C"
		/// </summary>
		[ValidateSetAccess]
		public TableDBEdit<GenioMVC.Models.T_002> TableT_002F_002 { get; set; }



		#region Navigations
		#endregion

		#region Auxiliar Keys for Image controls



		#endregion

		#region Extra database fields



		#endregion

		#region Fields for formulas


		#endregion

		public string ValCodt_006 { get; set; }


		/// <summary>
		/// FOR DESERIALIZATION ONLY
		/// A call to Init() needs to be manually invoked after this constructor
		/// </summary>
		[Obsolete("For deserialization only")]
		public Fr_005_ViewModel() : base(null!) { }

		public Fr_005_ViewModel(UserContext userContext, bool nestedForm = false) : base(userContext, "FFR_005", nestedForm) { }

		public Fr_005_ViewModel(UserContext userContext, Models.T_006 row, bool nestedForm = false) : base(userContext, "FFR_005", row, nestedForm) { }

		public Fr_005_ViewModel(UserContext userContext, string id, bool nestedForm = false, string[]? fieldsToLoad = null) : this(userContext, nestedForm)
		{
			this.Navigation.SetValue("t_006", id);
			Model = Models.T_006.Find(id, userContext, "FFR_005", fieldsToQuery: fieldsToLoad);
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
			Models.T_006 model = new Models.T_006(userContext) { Identifier = "FFR_005" };

			var navigation = m_userContext.CurrentNavigation;
			// The "LoadKeysFromHistory" must be after the "LoadEPH" because the PHE's in the tree mark Foreign Keys to null
			// (since they cannot assign multiple values to a single field) and thus the value that comes from Navigation is lost.
			// And this makes it more like the order of loading the model when opening the form.
			model.LoadEPH("FFR_005");
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
		public override void MapFromModel(Models.T_006 m)
		{
			if (m == null)
			{
				CSGenio.framework.Log.Error("Map Model (T_006) to ViewModel (Fr_005) - Model is a null reference");
				throw new ModelNotFoundException("Model not found");
			}

			try
			{
				ValCodt_002 = ViewModelConversion.ToString(m.ValCodt_002);
				ValPhoto = ViewModelConversion.ToImage(m.ValPhoto);
				ValDescription = ViewModelConversion.ToString(m.ValDescription);
				ValCodt_006 = ViewModelConversion.ToString(m.ValCodt_006);
			}
			catch (Exception)
			{
				CSGenio.framework.Log.Error("Map Model (T_006) to ViewModel (Fr_005) - Error during mapping");
				throw;
			}
		}

		/// <inheritdoc />
		public override void MapToModel()
		{
			MapToModel(this.Model);
		}

		/// <inheritdoc />
		public override void MapToModel(Models.T_006 m)
		{
			if (m == null)
			{
				CSGenio.framework.Log.Error("Map ViewModel (Fr_005) to Model (T_006) - Model is a null reference");
				throw new ModelNotFoundException("Model not found");
			}

			try
			{
				m.ValCodt_002 = ViewModelConversion.ToString(ValCodt_002);
				if (ValPhoto == null || !ValPhoto.IsThumbnail)
					m.ValPhoto = ViewModelConversion.ToImage(ValPhoto);
				m.ValDescription = ViewModelConversion.ToString(ValDescription);
				m.ValCodt_006 = ViewModelConversion.ToString(ValCodt_006);
			}
			catch (Exception)
			{
				CSGenio.framework.Log.Error($"Map ViewModel (Fr_005) to Model (T_006) - Error during mapping. All user values: {HasDisabledUserValuesSecurity}");
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
					case "t_006.codt_002":
						this.ValCodt_002 = ViewModelConversion.ToString(_value);
						break;
					case "t_006.photo":
						this.ValPhoto = ViewModelConversion.ToImage(_value);
						break;
					case "t_006.description":
						this.ValDescription = ViewModelConversion.ToString(_value);
						break;
					case "t_006.codt_006":
						this.ValCodt_006 = ViewModelConversion.ToString(_value);
						break;
					default:
						Log.Error($"SetViewModelValue (Fr_005) - Unexpected field identifier {fullFieldName}");
						break;
				}
			}
			catch (Exception ex)
			{
				throw new FrameworkException(Resources.Resources.PEDIMOS_DESCULPA__OC63848, "SetViewModelValue (Fr_005)", "Unexpected error", ex);
			}
		}

		#endregion

		/// <summary>
		/// Reads the Model from the database based on the key that is in the history or that was passed through the parameter
		/// </summary>
		/// <param name="id">The primary key of the record that needs to be read from the database. Leave NULL to use the value from the History.</param>
		public override void LoadModel(string id = null)
		{
			try { Model = Models.T_006.Find(id ?? Navigation.GetStrValue("t_006"), m_userContext, "FFR_005"); }
			finally { Model ??= new Models.T_006(m_userContext) { Identifier = "FFR_005" }; }

			base.LoadModel();
		}

		public override void Load(NameValueCollection qs, bool editable, bool ajaxRequest = false, bool lazyLoad = false)
		{
			this.editable = editable;
			CSGenio.business.Area oldvalues = null;

			// TODO: Deve ser substituido por search do CSGenioA
			try
			{
				Model = Models.T_006.Find(Navigation.GetStrValue("t_006"), m_userContext, "FFR_005");
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

			Model.Identifier = "FFR_005";
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

		protected override void LoadDocumentsProperties(Models.T_006 row)
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
				Model = Models.T_006.Find(Navigation.GetStrValue("t_006"), m_userContext, "FFR_005");
				if (Model == null)
				{
					Model = new Models.T_006(m_userContext) { Identifier = "FFR_005" };
					Model.klass.QPrimaryKey = Navigation.GetStrValue("t_006");
				}
				MapToModel(Model);
				LoadDocumentsProperties(Model);
			}
			// Add characteristics
			Characs = new List<string>();

			Load_Fr_005__t_002f_002___(qs, lazyLoad);
// USE /[MANUAL RMS VIEWMODEL_LOADPARTIAL FR_005]/
		}

// USE /[MANUAL RMS VIEWMODEL_NEW FR_005]/

		// Preencher Qvalues default dos fields do form
		protected override void LoadDefaultValues()
		{
		}

		public override CrudViewModelValidationResult Validate()
		{
			CrudViewModelFieldValidator validator = new(m_userContext.User.Language);


			validator.Required("ValPhoto", Resources.Resources.PHOTO51874, ViewModelConversion.ToImage(ValPhoto), FieldType.IMAGE.GetFormatting());
			validator.StringLength("ValDescription", Resources.Resources.DESCRIPTION07383, ValDescription, 200);


			return validator.GetResult();
		}

		public override void Init(UserContext userContext)
		{
			base.Init(userContext);
		}
// USE /[MANUAL RMS VIEWMODEL_SAVE FR_005]/
		public override void Save()
		{


			base.Save();
		}

// USE /[MANUAL RMS VIEWMODEL_APPLY FR_005]/

// USE /[MANUAL RMS VIEWMODEL_DUPLICATE FR_005]/

// USE /[MANUAL RMS VIEWMODEL_DESTROY FR_005]/
		public override void Destroy(string id)
		{
			Model = Models.T_006.Find(id, m_userContext, "FFR_005");
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
		/// TableT_002F_002 -> (DB)
		/// </summary>
		/// <param name="qs"></param>
		/// <param name="lazyLoad">Lazy loading of dropdown items</param>
		public void Load_Fr_005__t_002f_002___(NameValueCollection qs, bool lazyLoad = false)
		{
			bool fr_005__t_002f_002___DoLoad = true;
			CriteriaSet fr_005__t_002f_002___Conds = CriteriaSet.And();
			{
				object hValue = Navigation.GetValue("t_002", true);
				if (hValue != null && !(hValue is Array) && !string.IsNullOrEmpty(Convert.ToString(hValue)))
				{
					fr_005__t_002f_002___Conds.Equal(CSGenioAt_002.FldCodt_002, hValue);
					this.ValCodt_002 = DBConversion.ToString(hValue);
				}
			}

			TableT_002F_002 = new TableDBEdit<Models.T_002>
			{
				IsLazyLoad = lazyLoad
			};

			if (lazyLoad)
			{
				if (Navigation.CurrentLevel.GetEntry("RETURN_t_002") != null)
				{
					this.ValCodt_002 = Navigation.GetStrValue("RETURN_t_002");
					Navigation.CurrentLevel.SetEntry("RETURN_t_002", null);
				}
				FillDependant_Fr_005TableT_002F_002(lazyLoad);
				return;
			}

			if (fr_005__t_002f_002___DoLoad)
			{
				List<ColumnSort> sorts = new List<ColumnSort>();
				ColumnSort requestedSort = GetRequestSort(TableT_002F_002, "sTableT_002F_002", "dTableT_002F_002", qs, "t_002");
				if (requestedSort != null)
					sorts.Add(requestedSort);
				sorts.Add(new ColumnSort(new ColumnReference(CSGenioAt_002.FldTitle), SortOrder.Ascending));

				string query = "";
				if (!string.IsNullOrEmpty(qs["TableT_002F_002_tableFilters"]))
					TableT_002F_002.TableFilters = bool.Parse(qs["TableT_002F_002_tableFilters"]);
				else
					TableT_002F_002.TableFilters = false;

				query = qs["qTableT_002F_002"];

				//RS 26.07.2016 O preenchimento da lista de ajuda dos Dbedits passa a basear-se apenas no campo do próprio DbEdit
				// O interface de pesquisa rápida não fica coerente quando se visualiza apenas uma coluna mas a pesquisa faz matching com 5 ou 6 colunas diferentes
				//  tornando confuso to o user porque determinada row foi devolvida quando o Qresult não mostra como o matching foi feito
				CriteriaSet search_filters = CriteriaSet.And();
				if (!string.IsNullOrEmpty(query))
				{
					search_filters.Like(CSGenioAt_002.FldTitle, query + "%");
				}
				fr_005__t_002f_002___Conds.SubSet(search_filters);

				string tryParsePage = qs["pTableT_002F_002"] != null ? qs["pTableT_002F_002"].ToString() : "1";
				int page = !string.IsNullOrEmpty(tryParsePage) ? int.Parse(tryParsePage) : 1;
				int numberItems = CSGenio.framework.Configuration.NrRegDBedit;
				int offset = (page - 1) * numberItems;

				FieldRef[] fields = new FieldRef[] { CSGenioAt_002.FldCodt_002, CSGenioAt_002.FldTitle, CSGenioAt_002.FldZzstate };

// USE /[MANUAL RMS OVERRQ FR_005_T_002F_002]/

				// Limitation by Zzstate
				/*
					Records that are currently being inserted or duplicated will also be included.
					Client-side persistence will try to fill the "text" value of that option.
				*/
				if (Navigation.checkFormMode("t_002", FormMode.New) || Navigation.checkFormMode("t_002", FormMode.Duplicate))
					fr_005__t_002f_002___Conds.SubSet(CriteriaSet.Or()
						.Equal(CSGenioAt_002.FldZzstate, 0)
						.Equal(CSGenioAt_002.FldCodt_002, Navigation.GetStrValue("t_002")));
				else
					fr_005__t_002f_002___Conds.Criterias.Add(new Criteria(new ColumnReference(CSGenioAt_002.FldZzstate), CriteriaOperator.Equal, 0));

				FieldRef firstVisibleColumn = new FieldRef("t_002", "title");
				ListingMVC<CSGenioAt_002> listing = Models.ModelBase.Where<CSGenioAt_002>(m_userContext, false, fr_005__t_002f_002___Conds, fields, offset, numberItems, sorts, "LED_FR_005__T_002F_002___", true, false, firstVisibleColumn: firstVisibleColumn);

				TableT_002F_002.SetPagination(page, numberItems, listing.HasMore, listing.GetTotal, listing.TotalRecords);
				TableT_002F_002.Query = query;
				TableT_002F_002.Elements = listing.RowsForViewModel<GenioMVC.Models.T_002>((r) => new GenioMVC.Models.T_002(m_userContext, r, true, _fieldsToSerialize_FR_005__T_002F_002___));

				//created by [ MH ] at [ 14.04.2016 ] - Foi alterada a forma de retornar a key do novo registo inserido / editado no form de apoio do DBEdit.
				//last update by [ MH ] at [ 10.05.2016 ] - Validação se key encontra-se no level atual, as chaves dos niveis anteriores devem ser ignorados.
				if (Navigation.CurrentLevel.GetEntry("RETURN_t_002") != null)
				{
					this.ValCodt_002 = Navigation.GetStrValue("RETURN_t_002");
					Navigation.CurrentLevel.SetEntry("RETURN_t_002", null);
				}

				TableT_002F_002.List = new SelectList(TableT_002F_002.Elements.ToSelectList(x => x.ValTitle, x => x.ValCodt_002,  x => x.ValCodt_002 == this.ValCodt_002), "Value", "Text", this.ValCodt_002);
				FillDependant_Fr_005TableT_002F_002();
			}
		}

		/// <summary>
		/// Get Dependant fields values -> TableT_002F_002 (DB)
		/// </summary>
		/// <param name="PKey">Primary Key of T_002</param>
		public ConcurrentDictionary<string, object> GetDependant_Fr_005TableT_002F_002(string PKey)
		{
			FieldRef[] refDependantFields = [CSGenioAt_002.FldCodt_002, CSGenioAt_002.FldTitle];

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

			CSGenioAt_002 tempArea = new(u);

			// Fields to select
			SelectQuery querySelect = new();
			querySelect.PageSize(1);
			foreach (FieldRef field in refDependantFields)
				querySelect.Select(field);

			querySelect.From(tempArea.QSystem, tempArea.TableName, tempArea.Alias)
				.Where(wherecodition.Equal(CSGenioAt_002.FldCodt_002, PKey));

			string[] dependantFields = refDependantFields.Select(f => f.FullName).ToArray();
			QueryUtils.SetInnerJoins(dependantFields, null, tempArea, querySelect);

			ArrayList values = sp.executeReaderOneRow(querySelect);
			bool useDefaults = values.Count == 0;

			if (useDefaults)
				return GetViewModelFieldValues(refDependantFields);
			return GetViewModelFieldValues(refDependantFields, values);
		}

		/// <summary>
		/// Fill Dependant fields values -> TableT_002F_002 (DB)
		/// </summary>
		/// <param name="lazyLoad">Lazy loading of dropdown items</param>
		public void FillDependant_Fr_005TableT_002F_002(bool lazyLoad = false)
		{
			var row = GetDependant_Fr_005TableT_002F_002(this.ValCodt_002);
			try
			{

				// Fill List fields
				this.ValCodt_002 = ViewModelConversion.ToString(row["t_002.codt_002"]);
				TableT_002F_002.Value = (string)row["t_002.title"];
				if (GenFunctions.emptyG(this.ValCodt_002) == 1)
				{
					this.ValCodt_002 = "";
					TableT_002F_002.Value = "";
					Navigation.ClearValue("t_002");
				}
				else if (lazyLoad)
				{
					TableT_002F_002.SetPagination(1, 0, false, false, 1);
					TableT_002F_002.List = new SelectList(new List<SelectListItem>()
					{
						new SelectListItem
						{
							Value = Convert.ToString(this.ValCodt_002),
							Text = Convert.ToString(TableT_002F_002.Value),
							Selected = true
						}
					}, "Value", "Text", this.ValCodt_002);
				}

				TableT_002F_002.Selected = this.ValCodt_002;
			}
			catch (Exception ex)
			{
				CSGenio.framework.Log.Error(string.Format("FillDependant_Error (TableT_002F_002): {0}; {1}", ex.Message, ex.InnerException != null ? ex.InnerException.Message : ""));
			}
		}

		private readonly string[] _fieldsToSerialize_FR_005__T_002F_002___ = ["T_002", "T_002.ValCodt_002", "T_002.ValZzstate", "T_002.ValTitle"];

		protected override object GetViewModelValue(string identifier, object modelValue)
		{
			return identifier switch
			{
				"t_006.codt_002" => ViewModelConversion.ToString(modelValue),
				"t_006.photo" => ViewModelConversion.ToImage(modelValue),
				"t_006.description" => ViewModelConversion.ToString(modelValue),
				"t_006.codt_006" => ViewModelConversion.ToString(modelValue),
				"t_002.codt_002" => ViewModelConversion.ToString(modelValue),
				"t_002.title" => ViewModelConversion.ToString(modelValue),
				_ => modelValue
			};
		}

		/// <inheritdoc/>
		protected override void SetTicketToImageFields()
		{
			if (ValPhoto != null)
				ValPhoto.Ticket = Helpers.Helpers.GetFileTicket(m_userContext.User, CSGenio.business.Area.AreaT_006, CSGenioAt_006.FldPhoto.Field, null, ValCodt_006);
		}

		#region Charts


		#endregion

		#region Custom code

// USE /[MANUAL RMS VIEWMODEL_CUSTOM FR_005]/

		#endregion
	}
}
