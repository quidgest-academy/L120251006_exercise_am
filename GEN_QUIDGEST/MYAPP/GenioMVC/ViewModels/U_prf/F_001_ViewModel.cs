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

namespace GenioMVC.ViewModels.U_prf
{
	public class F_001_ViewModel : FormViewModel<Models.U_prf>, IPreparableForSerialization
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
		/// Title: "Username" | Type: "C"
		/// </summary>
		public string ValUsername { get; set; }
		/// <summary>
		/// Title: "Date of Birth" | Type: "D"
		/// </summary>
		public DateTime? ValBday { get; set; }
		/// <summary>
		/// Title: "Image" | Type: "IJ"
		/// </summary>
		[ImageThumbnailJsonConverter(100, 50)]
		public GenioMVC.Models.ImageModel ValU_img { get; set; }
		/// <summary>
		/// Title: "Email" | Type: "C"
		/// </summary>
		public string ValU_email { get; set; }



		#region Navigations
		#endregion

		#region Auxiliar Keys for Image controls



		#endregion

		#region Extra database fields



		#endregion

		#region Fields for formulas


		#endregion

		public string ValCodu_prf { get; set; }


		/// <summary>
		/// FOR DESERIALIZATION ONLY
		/// A call to Init() needs to be manually invoked after this constructor
		/// </summary>
		[Obsolete("For deserialization only")]
		public F_001_ViewModel() : base(null!) { }

		public F_001_ViewModel(UserContext userContext, bool nestedForm = false) : base(userContext, "FF_001", nestedForm) { }

		public F_001_ViewModel(UserContext userContext, Models.U_prf row, bool nestedForm = false) : base(userContext, "FF_001", row, nestedForm) { }

		public F_001_ViewModel(UserContext userContext, string id, bool nestedForm = false, string[]? fieldsToLoad = null) : this(userContext, nestedForm)
		{
			this.Navigation.SetValue("u_prf", id);
			Model = Models.U_prf.Find(id, userContext, "FF_001", fieldsToQuery: fieldsToLoad);
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
			Models.U_prf model = new Models.U_prf(userContext) { Identifier = "FF_001" };

			var navigation = m_userContext.CurrentNavigation;
			// The "LoadKeysFromHistory" must be after the "LoadEPH" because the PHE's in the tree mark Foreign Keys to null
			// (since they cannot assign multiple values to a single field) and thus the value that comes from Navigation is lost.
			// And this makes it more like the order of loading the model when opening the form.
			model.LoadEPH("FF_001");
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
		public override void MapFromModel(Models.U_prf m)
		{
			if (m == null)
			{
				CSGenio.framework.Log.Error("Map Model (U_prf) to ViewModel (F_001) - Model is a null reference");
				throw new ModelNotFoundException("Model not found");
			}

			try
			{
				ValUsername = ViewModelConversion.ToString(m.ValUsername);
				ValBday = ViewModelConversion.ToDateTime(m.ValBday);
				ValU_img = ViewModelConversion.ToImage(m.ValU_img);
				ValU_email = ViewModelConversion.ToString(m.ValU_email);
				ValCodu_prf = ViewModelConversion.ToString(m.ValCodu_prf);
			}
			catch (Exception)
			{
				CSGenio.framework.Log.Error("Map Model (U_prf) to ViewModel (F_001) - Error during mapping");
				throw;
			}
		}

		/// <inheritdoc />
		public override void MapToModel()
		{
			MapToModel(this.Model);
		}

		/// <inheritdoc />
		public override void MapToModel(Models.U_prf m)
		{
			if (m == null)
			{
				CSGenio.framework.Log.Error("Map ViewModel (F_001) to Model (U_prf) - Model is a null reference");
				throw new ModelNotFoundException("Model not found");
			}

			try
			{
				m.ValUsername = ViewModelConversion.ToString(ValUsername);
				m.ValBday = ViewModelConversion.ToDateTime(ValBday);
				if (ValU_img == null || !ValU_img.IsThumbnail)
					m.ValU_img = ViewModelConversion.ToImage(ValU_img);
				m.ValU_email = ViewModelConversion.ToString(ValU_email);
				m.ValCodu_prf = ViewModelConversion.ToString(ValCodu_prf);
			}
			catch (Exception)
			{
				CSGenio.framework.Log.Error($"Map ViewModel (F_001) to Model (U_prf) - Error during mapping. All user values: {HasDisabledUserValuesSecurity}");
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
					case "u_prf.username":
						this.ValUsername = ViewModelConversion.ToString(_value);
						break;
					case "u_prf.bday":
						this.ValBday = ViewModelConversion.ToDateTime(_value);
						break;
					case "u_prf.u_img":
						this.ValU_img = ViewModelConversion.ToImage(_value);
						break;
					case "u_prf.u_email":
						this.ValU_email = ViewModelConversion.ToString(_value);
						break;
					case "u_prf.codu_prf":
						this.ValCodu_prf = ViewModelConversion.ToString(_value);
						break;
					default:
						Log.Error($"SetViewModelValue (F_001) - Unexpected field identifier {fullFieldName}");
						break;
				}
			}
			catch (Exception ex)
			{
				throw new FrameworkException(Resources.Resources.PEDIMOS_DESCULPA__OC63848, "SetViewModelValue (F_001)", "Unexpected error", ex);
			}
		}

		#endregion

		/// <summary>
		/// Reads the Model from the database based on the key that is in the history or that was passed through the parameter
		/// </summary>
		/// <param name="id">The primary key of the record that needs to be read from the database. Leave NULL to use the value from the History.</param>
		public override void LoadModel(string id = null)
		{
			try { Model = Models.U_prf.Find(id ?? Navigation.GetStrValue("u_prf"), m_userContext, "FF_001"); }
			finally { Model ??= new Models.U_prf(m_userContext) { Identifier = "FF_001" }; }

			base.LoadModel();
		}

		public override void Load(NameValueCollection qs, bool editable, bool ajaxRequest = false, bool lazyLoad = false)
		{
			this.editable = editable;
			CSGenio.business.Area oldvalues = null;

			// TODO: Deve ser substituido por search do CSGenioA
			try
			{
				Model = Models.U_prf.Find(Navigation.GetStrValue("u_prf"), m_userContext, "FF_001");
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

			Model.Identifier = "FF_001";
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

		protected override void LoadDocumentsProperties(Models.U_prf row)
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
				Model = Models.U_prf.Find(Navigation.GetStrValue("u_prf"), m_userContext, "FF_001");
				if (Model == null)
				{
					Model = new Models.U_prf(m_userContext) { Identifier = "FF_001" };
					Model.klass.QPrimaryKey = Navigation.GetStrValue("u_prf");
				}
				MapToModel(Model);
				LoadDocumentsProperties(Model);
			}
			// Add characteristics
			Characs = new List<string>();

// USE /[MANUAL RMS VIEWMODEL_LOADPARTIAL F_001]/
		}

// USE /[MANUAL RMS VIEWMODEL_NEW F_001]/

		// Preencher Qvalues default dos fields do form
		protected override void LoadDefaultValues()
		{
		}

		public override CrudViewModelValidationResult Validate()
		{
			CrudViewModelFieldValidator validator = new(m_userContext.User.Language);

			validator.StringLength("ValUsername", Resources.Resources.USERNAME51409, ValUsername, 12);

			validator.Required("ValUsername", Resources.Resources.USERNAME51409, ViewModelConversion.ToString(ValUsername), FieldType.TEXT.GetFormatting());

			validator.Required("ValBday", Resources.Resources.DATE_OF_BIRTH36542, ViewModelConversion.ToDateTime(ValBday), FieldType.DATE.GetFormatting());
			validator.StringLength("ValU_email", Resources.Resources.EMAIL25170, ValU_email, 50);


			return validator.GetResult();
		}

		public override void Init(UserContext userContext)
		{
			base.Init(userContext);
		}
// USE /[MANUAL RMS VIEWMODEL_SAVE F_001]/
		public override void Save()
		{


			base.Save();
		}

// USE /[MANUAL RMS VIEWMODEL_APPLY F_001]/

// USE /[MANUAL RMS VIEWMODEL_DUPLICATE F_001]/

// USE /[MANUAL RMS VIEWMODEL_DESTROY F_001]/
		public override void Destroy(string id)
		{
			Model = Models.U_prf.Find(id, m_userContext, "FF_001");
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
				"u_prf.username" => ViewModelConversion.ToString(modelValue),
				"u_prf.bday" => ViewModelConversion.ToDateTime(modelValue),
				"u_prf.u_img" => ViewModelConversion.ToImage(modelValue),
				"u_prf.u_email" => ViewModelConversion.ToString(modelValue),
				"u_prf.codu_prf" => ViewModelConversion.ToString(modelValue),
				_ => modelValue
			};
		}

		/// <inheritdoc/>
		protected override void SetTicketToImageFields()
		{
			if (ValU_img != null)
				ValU_img.Ticket = Helpers.Helpers.GetFileTicket(m_userContext.User, CSGenio.business.Area.AreaU_PRF, CSGenioAu_prf.FldU_img.Field, null, ValCodu_prf);
		}

		#region Charts


		#endregion

		#region Custom code

// USE /[MANUAL RMS VIEWMODEL_CUSTOM F_001]/

		#endregion
	}
}
