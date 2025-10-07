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

namespace GenioMVC.ViewModels.T_001
{
	public class Fr_001_ViewModel : FormViewModel<Models.T_001>, IPreparableForSerialization
	{
		[JsonIgnore]
		public override bool HasWriteConditions { get => false; }

		/// <summary>
		/// Reference for the Models MsqActive property
		/// </summary>
		[JsonIgnore]
		public bool MsqActive { get; set; } = false;

		#region Foreign keys

		#endregion
		/// <summary>
		/// Title: "Profile Photo" | Type: "IJ"
		/// </summary>
		[ImageThumbnailJsonConverter(30, 50)]
		public GenioMVC.Models.ImageModel ValPhoto { get; set; }
		/// <summary>
		/// Title: "Name" | Type: "C"
		/// </summary>
		public string ValName { get; set; }
		/// <summary>
		/// Title: "Email" | Type: "C"
		/// </summary>
		public string ValEmail { get; set; }
		/// <summary>
		/// Title: "Date of Birth" | Type: "D"
		/// </summary>
		public DateTime? ValDobirth { get; set; }
		/// <summary>
		/// Title: "Telephone" | Type: "N"
		/// </summary>
		public decimal? ValTel { get; set; }



		#region Navigations
		#endregion

		#region Auxiliar Keys for Image controls



		#endregion

		#region Extra database fields



		#endregion

		#region Fields for formulas


		#endregion

		public string ValCodt_001 { get; set; }


		/// <summary>
		/// FOR DESERIALIZATION ONLY
		/// A call to Init() needs to be manually invoked after this constructor
		/// </summary>
		[Obsolete("For deserialization only")]
		public Fr_001_ViewModel() : base(null!) { }

		public Fr_001_ViewModel(UserContext userContext, bool nestedForm = false) : base(userContext, "FFR_001", nestedForm) { }

		public Fr_001_ViewModel(UserContext userContext, Models.T_001 row, bool nestedForm = false) : base(userContext, "FFR_001", row, nestedForm) { }

		public Fr_001_ViewModel(UserContext userContext, string id, bool nestedForm = false, string[]? fieldsToLoad = null) : this(userContext, nestedForm)
		{
			this.Navigation.SetValue("t_001", id);
			Model = Models.T_001.Find(id, userContext, "FFR_001", fieldsToQuery: fieldsToLoad);
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
			Models.T_001 model = new Models.T_001(userContext) { Identifier = "FFR_001" };

			var navigation = m_userContext.CurrentNavigation;
			// The "LoadKeysFromHistory" must be after the "LoadEPH" because the PHE's in the tree mark Foreign Keys to null
			// (since they cannot assign multiple values to a single field) and thus the value that comes from Navigation is lost.
			// And this makes it more like the order of loading the model when opening the form.
			model.LoadEPH("FFR_001");
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
		public override void MapFromModel(Models.T_001 m)
		{
			if (m == null)
			{
				CSGenio.framework.Log.Error("Map Model (T_001) to ViewModel (Fr_001) - Model is a null reference");
				throw new ModelNotFoundException("Model not found");
			}

			try
			{
				ValPhoto = ViewModelConversion.ToImage(m.ValPhoto);
				ValName = ViewModelConversion.ToString(m.ValName);
				ValEmail = ViewModelConversion.ToString(m.ValEmail);
				ValDobirth = ViewModelConversion.ToDateTime(m.ValDobirth);
				ValTel = ViewModelConversion.ToNumeric(m.ValTel);
				ValCodt_001 = ViewModelConversion.ToString(m.ValCodt_001);
			}
			catch (Exception)
			{
				CSGenio.framework.Log.Error("Map Model (T_001) to ViewModel (Fr_001) - Error during mapping");
				throw;
			}
		}

		/// <inheritdoc />
		public override void MapToModel()
		{
			MapToModel(this.Model);
		}

		/// <inheritdoc />
		public override void MapToModel(Models.T_001 m)
		{
			if (m == null)
			{
				CSGenio.framework.Log.Error("Map ViewModel (Fr_001) to Model (T_001) - Model is a null reference");
				throw new ModelNotFoundException("Model not found");
			}

			try
			{
				if (ValPhoto == null || !ValPhoto.IsThumbnail)
					m.ValPhoto = ViewModelConversion.ToImage(ValPhoto);
				m.ValName = ViewModelConversion.ToString(ValName);
				m.ValEmail = ViewModelConversion.ToString(ValEmail);
				m.ValDobirth = ViewModelConversion.ToDateTime(ValDobirth);
				m.ValTel = ViewModelConversion.ToNumeric(ValTel);
				m.ValCodt_001 = ViewModelConversion.ToString(ValCodt_001);
			}
			catch (Exception)
			{
				CSGenio.framework.Log.Error($"Map ViewModel (Fr_001) to Model (T_001) - Error during mapping. All user values: {HasDisabledUserValuesSecurity}");
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
					case "t_001.photo":
						this.ValPhoto = ViewModelConversion.ToImage(_value);
						break;
					case "t_001.name":
						this.ValName = ViewModelConversion.ToString(_value);
						break;
					case "t_001.email":
						this.ValEmail = ViewModelConversion.ToString(_value);
						break;
					case "t_001.dobirth":
						this.ValDobirth = ViewModelConversion.ToDateTime(_value);
						break;
					case "t_001.tel":
						this.ValTel = ViewModelConversion.ToNumeric(_value);
						break;
					case "t_001.codt_001":
						this.ValCodt_001 = ViewModelConversion.ToString(_value);
						break;
					default:
						Log.Error($"SetViewModelValue (Fr_001) - Unexpected field identifier {fullFieldName}");
						break;
				}
			}
			catch (Exception ex)
			{
				throw new FrameworkException(Resources.Resources.PEDIMOS_DESCULPA__OC63848, "SetViewModelValue (Fr_001)", "Unexpected error", ex);
			}
		}

		#endregion

		/// <summary>
		/// Reads the Model from the database based on the key that is in the history or that was passed through the parameter
		/// </summary>
		/// <param name="id">The primary key of the record that needs to be read from the database. Leave NULL to use the value from the History.</param>
		public override void LoadModel(string id = null)
		{
			try { Model = Models.T_001.Find(id ?? Navigation.GetStrValue("t_001"), m_userContext, "FFR_001"); }
			finally { Model ??= new Models.T_001(m_userContext) { Identifier = "FFR_001" }; }

			base.LoadModel();
		}

		public override void Load(NameValueCollection qs, bool editable, bool ajaxRequest = false, bool lazyLoad = false)
		{
			this.editable = editable;
			CSGenio.business.Area oldvalues = null;

			// TODO: Deve ser substituido por search do CSGenioA
			try
			{
				Model = Models.T_001.Find(Navigation.GetStrValue("t_001"), m_userContext, "FFR_001");
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

			Model.Identifier = "FFR_001";
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

		protected override void LoadDocumentsProperties(Models.T_001 row)
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
				Model = Models.T_001.Find(Navigation.GetStrValue("t_001"), m_userContext, "FFR_001");
				if (Model == null)
				{
					Model = new Models.T_001(m_userContext) { Identifier = "FFR_001" };
					Model.klass.QPrimaryKey = Navigation.GetStrValue("t_001");
				}
				MapToModel(Model);
				LoadDocumentsProperties(Model);
			}
			// Add characteristics
			Characs = new List<string>();

// USE /[MANUAL RMS VIEWMODEL_LOADPARTIAL FR_001]/
		}

// USE /[MANUAL RMS VIEWMODEL_NEW FR_001]/

		// Preencher Qvalues default dos fields do form
		protected override void LoadDefaultValues()
		{
		}

		public override CrudViewModelValidationResult Validate()
		{
			CrudViewModelFieldValidator validator = new(m_userContext.User.Language);

			validator.StringLength("ValName", Resources.Resources.NAME31974, ValName, 50);

			validator.Required("ValName", Resources.Resources.NAME31974, ViewModelConversion.ToString(ValName), FieldType.TEXT.GetFormatting());
			validator.StringLength("ValEmail", Resources.Resources.EMAIL25170, ValEmail, 50);

			validator.Required("ValEmail", Resources.Resources.EMAIL25170, ViewModelConversion.ToString(ValEmail), FieldType.TEXT.GetFormatting());

			validator.Required("ValDobirth", Resources.Resources.DATE_OF_BIRTH36542, ViewModelConversion.ToDateTime(ValDobirth), FieldType.DATE.GetFormatting());


			return validator.GetResult();
		}

		public override void Init(UserContext userContext)
		{
			base.Init(userContext);
		}
// USE /[MANUAL RMS VIEWMODEL_SAVE FR_001]/
		public override void Save()
		{


			base.Save();
		}

// USE /[MANUAL RMS VIEWMODEL_APPLY FR_001]/

// USE /[MANUAL RMS VIEWMODEL_DUPLICATE FR_001]/

// USE /[MANUAL RMS VIEWMODEL_DESTROY FR_001]/
		public override void Destroy(string id)
		{
			Model = Models.T_001.Find(id, m_userContext, "FFR_001");
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

		protected override object GetViewModelValue(string identifier, object modelValue)
		{
			return identifier switch
			{
				"t_001.photo" => ViewModelConversion.ToImage(modelValue),
				"t_001.name" => ViewModelConversion.ToString(modelValue),
				"t_001.email" => ViewModelConversion.ToString(modelValue),
				"t_001.dobirth" => ViewModelConversion.ToDateTime(modelValue),
				"t_001.tel" => ViewModelConversion.ToNumeric(modelValue),
				"t_001.codt_001" => ViewModelConversion.ToString(modelValue),
				_ => modelValue
			};
		}

		/// <inheritdoc/>
		protected override void SetTicketToImageFields()
		{
			if (ValPhoto != null)
				ValPhoto.Ticket = Helpers.Helpers.GetFileTicket(m_userContext.User, CSGenio.business.Area.AreaT_001, CSGenioAt_001.FldPhoto.Field, null, ValCodt_001);
		}

		#region Charts


		#endregion

		#region Custom code

// USE /[MANUAL RMS VIEWMODEL_CUSTOM FR_001]/

		#endregion
	}
}
