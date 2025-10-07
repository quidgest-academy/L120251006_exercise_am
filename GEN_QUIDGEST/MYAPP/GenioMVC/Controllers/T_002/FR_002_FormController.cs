using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Dynamic;

using CSGenio.business;
using CSGenio.core.persistence;
using CSGenio.framework;
using CSGenio.persistence;
using CSGenio.reporting;
using GenioMVC.Helpers;
using GenioMVC.Models;
using GenioMVC.Models.Exception;
using GenioMVC.Models.Navigation;
using GenioMVC.Resources;
using GenioMVC.ViewModels;
using GenioMVC.ViewModels.T_002;
using Quidgest.Persistence.GenericQuery;

// USE /[MANUAL RMS INCLUDE_CONTROLLER T_002]/

namespace GenioMVC.Controllers
{
	public partial class T_002Controller : ControllerBase
	{
		#region NavigationLocation Names

		private static readonly NavigationLocation ACTION_FR_002_CANCEL = new("PROPERTY43977", "Fr_002_Cancel", "T_002") { vueRouteName = "form-FR_002", mode = "CANCEL" };
		private static readonly NavigationLocation ACTION_FR_002_SHOW = new("PROPERTY43977", "Fr_002_Show", "T_002") { vueRouteName = "form-FR_002", mode = "SHOW" };
		private static readonly NavigationLocation ACTION_FR_002_NEW = new("PROPERTY43977", "Fr_002_New", "T_002") { vueRouteName = "form-FR_002", mode = "NEW" };
		private static readonly NavigationLocation ACTION_FR_002_EDIT = new("PROPERTY43977", "Fr_002_Edit", "T_002") { vueRouteName = "form-FR_002", mode = "EDIT" };
		private static readonly NavigationLocation ACTION_FR_002_DUPLICATE = new("PROPERTY43977", "Fr_002_Duplicate", "T_002") { vueRouteName = "form-FR_002", mode = "DUPLICATE" };
		private static readonly NavigationLocation ACTION_FR_002_DELETE = new("PROPERTY43977", "Fr_002_Delete", "T_002") { vueRouteName = "form-FR_002", mode = "DELETE" };

		#endregion

		#region Fr_002 private

		private void FormHistoryLimits_Fr_002()
		{

		}

		#endregion

		#region Fr_002_Show

// USE /[MANUAL RMS CONTROLLER_SHOW FR_002]/

		[HttpPost]
		public ActionResult Fr_002_Show_GET([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new Fr_002_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_002_Show_GET",
				AreaName = "t_002",
				Location = ACTION_FR_002_SHOW,
				BeforeOp = (sink, sp) =>
				{
					FormHistoryLimits_Fr_002();
// USE /[MANUAL RMS BEFORE_LOAD_SHOW FR_002]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_SHOW FR_002]/
				}
			};

			return GenericHandleGetFormShow(eventSink, model, id);
		}

		#endregion

		#region Fr_002_New

// USE /[MANUAL RMS CONTROLLER_NEW_GET FR_002]/
		[HttpPost]
		public ActionResult Fr_002_New_GET([FromBody]RequestNewGetModel requestModel)
		{
			var id = requestModel.Id;
			var isNewLocation = requestModel.IsNewLocation;
			var prefillValues = requestModel.PrefillValues;

			var model = new Fr_002_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_002_New_GET",
				AreaName = "t_002",
				FormName = "FR_002",
				Location = ACTION_FR_002_NEW,
				BeforeAll = (sink, sp) =>
				{
					FormHistoryLimits_Fr_002();
				},
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_NEW FR_002]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_NEW FR_002]/
				}
			};

			return GenericHandleGetFormNew(eventSink, model, id, isNewLocation, prefillValues);
		}

		//
		// POST: /T_002/Fr_002_New
// USE /[MANUAL RMS CONTROLLER_NEW_POST FR_002]/
		[HttpPost]
		public ActionResult Fr_002_New([FromBody]Fr_002_ViewModel model, [FromQuery]bool redirect = true)
		{
			var eventSink = new EventSink()
			{
				MethodName = "Fr_002_New",
				ViewName = "Fr_002",
				AreaName = "t_002",
				Location = ACTION_FR_002_NEW,
				Redirect = redirect,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_SAVE_NEW FR_002]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_SAVE_NEW FR_002]/
				},
				BeforeException = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_NEW_EX FR_002]/
				},
				AfterException = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_NEW_EX FR_002]/
				}
			};

			return GenericHandlePostFormNew(eventSink, model);
		}

		#endregion

		#region Fr_002_Edit

// USE /[MANUAL RMS CONTROLLER_EDIT_GET FR_002]/
		[HttpPost]
		public ActionResult Fr_002_Edit_GET([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new Fr_002_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_002_Edit_GET",
				AreaName = "t_002",
				FormName = "FR_002",
				Location = ACTION_FR_002_EDIT,
				BeforeOp = (sink, sp) =>
				{
					FormHistoryLimits_Fr_002();
// USE /[MANUAL RMS BEFORE_LOAD_EDIT FR_002]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_EDIT FR_002]/
				}
			};

			return GenericHandleGetFormEdit(eventSink, model, id);
		}

		//
		// POST: /T_002/Fr_002_Edit
// USE /[MANUAL RMS CONTROLLER_EDIT_POST FR_002]/
		[HttpPost]
		public ActionResult Fr_002_Edit([FromBody]Fr_002_ViewModel model, [FromQuery]bool redirect)
		{
			var eventSink = new EventSink()
			{
				MethodName = "Fr_002_Edit",
				ViewName = "Fr_002",
				AreaName = "t_002",
				Location = ACTION_FR_002_EDIT,
				Redirect = redirect,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_SAVE_EDIT FR_002]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_SAVE_EDIT FR_002]/
				},
				BeforeException = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_EDIT_EX FR_002]/
				},
				AfterException = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_EDIT_EX FR_002]/
				}
			};

			return GenericHandlePostFormEdit(eventSink, model);
		}

		#endregion

		#region Fr_002_Delete

// USE /[MANUAL RMS CONTROLLER_DELETE_GET FR_002]/
		[HttpPost]
		public ActionResult Fr_002_Delete_GET([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new Fr_002_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_002_Delete_GET",
				AreaName = "t_002",
				FormName = "FR_002",
				Location = ACTION_FR_002_DELETE,
				BeforeOp = (sink, sp) =>
				{
					FormHistoryLimits_Fr_002();
// USE /[MANUAL RMS BEFORE_LOAD_DELETE FR_002]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_DELETE FR_002]/
				}
			};

			return GenericHandleGetFormDelete(eventSink, model, id);
		}

		//
		// POST: /T_002/Fr_002_Delete
// USE /[MANUAL RMS CONTROLLER_DELETE_POST FR_002]/
		[HttpPost]
		public ActionResult Fr_002_Delete([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new Fr_002_ViewModel (UserContext.Current, id);
			model.MapFromModel();

			var eventSink = new EventSink()
			{
				MethodName = "Fr_002_Delete",
				ViewName = "Fr_002",
				AreaName = "t_002",
				Location = ACTION_FR_002_DELETE,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_DESTROY_DELETE FR_002]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_DESTROY_DELETE FR_002]/
				}
			};

			return GenericHandlePostFormDelete(eventSink, model);
		}

		public ActionResult Fr_002_Delete_Redirect()
		{
			//FOR: FORM MENU GO BACK
			return RedirectToFormMenuGoBack("FR_002");
		}

		#endregion

		#region Fr_002_Duplicate

// USE /[MANUAL RMS CONTROLLER_DUPLICATE_GET FR_002]/

		[HttpPost]
		public ActionResult Fr_002_Duplicate_GET([FromBody]RequestNewGetModel requestModel)
		{
			var id = requestModel.Id;
			var isNewLocation = requestModel.IsNewLocation;

			var model = new Fr_002_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_002_Duplicate_GET",
				AreaName = "t_002",
				FormName = "FR_002",
				Location = ACTION_FR_002_DUPLICATE,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_DUPLICATE FR_002]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_DUPLICATE FR_002]/
				}
			};

			return GenericHandleGetFormDuplicate(eventSink, model, id, isNewLocation);
		}

		//
		// POST: /T_002/Fr_002_Duplicate
// USE /[MANUAL RMS CONTROLLER_DUPLICATE_POST FR_002]/
		[HttpPost]
		public ActionResult Fr_002_Duplicate([FromBody]Fr_002_ViewModel model, [FromQuery]bool redirect = true)
		{
			var eventSink = new EventSink()
			{
				MethodName = "Fr_002_Duplicate",
				ViewName = "Fr_002",
				AreaName = "t_002",
				Location = ACTION_FR_002_DUPLICATE,
				Redirect = redirect,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_SAVE_DUPLICATE FR_002]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_SAVE_DUPLICATE FR_002]/
				},
				BeforeException = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_DUPLICATE_EX FR_002]/
				},
				AfterException = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_DUPLICATE_EX FR_002]/
				}
			};

			return GenericHandlePostFormDuplicate(eventSink, model);
		}

		#endregion

		#region Fr_002_Cancel

		//
		// GET: /T_002/Fr_002_Cancel
// USE /[MANUAL RMS CONTROLLER_CANCEL_GET FR_002]/
		public ActionResult Fr_002_Cancel()
		{
			if (Navigation.CurrentLevel.FormMode == FormMode.New || Navigation.CurrentLevel.FormMode == FormMode.Duplicate)
			{
				PersistentSupport sp = UserContext.Current.PersistentSupport;
				try
				{
					var model = new GenioMVC.Models.T_002(UserContext.Current);
					model.klass.QPrimaryKey = Navigation.GetStrValue("t_002");

// USE /[MANUAL RMS BEFORE_CANCEL FR_002]/

					sp.openTransaction();
					model.Destroy();
					sp.closeTransaction();

// USE /[MANUAL RMS AFTER_CANCEL FR_002]/

				}
				catch (Exception e)
				{
					sp.rollbackTransaction();
					sp.closeConnection();

					var exceptionUserMessage = Resources.Resources.PEDIMOS_DESCULPA__OC63848;
					if (e is GenioException && (e as GenioException).UserMessage != null)
						exceptionUserMessage = Translations.Get((e as GenioException).UserMessage, UserContext.Current.User.Language);
					return JsonERROR(exceptionUserMessage);
				}

				Navigation.SetValue("ForcePrimaryRead_t_002", "true", true);
			}

			Navigation.ClearValue("t_002");

			return JsonOK(new { Success = true, currentNavigationLevel = Navigation.CurrentLevel.Level });
		}

		#endregion


		public class Fr_002_T_004ValCityModel : RequestLookupModel
		{
			public Fr_002_ViewModel Model { get; set; }
		}

		//
		// GET: /T_002/Fr_002_T_004ValCity
		// POST: /T_002/Fr_002_T_004ValCity
		[ActionName("Fr_002_T_004ValCity")]
		public ActionResult Fr_002_T_004ValCity([FromBody] Fr_002_T_004ValCityModel requestModel)
		{
			var queryParams = requestModel.QueryParams;

			int perPage = CSGenio.framework.Configuration.NrRegDBedit;
			string rowsPerPageOptionsString = "";

			// If there was a recent operation on this table then force the primary persistence server to be called and ignore the read only feature
			if (string.IsNullOrEmpty(Navigation.GetStrValue("ForcePrimaryRead_t_004")))
				UserContext.Current.SetPersistenceReadOnly(true);
			else
			{
				Navigation.DestroyEntry("ForcePrimaryRead_t_004");
				UserContext.Current.SetPersistenceReadOnly(false);
			}

			var requestValues = new NameValueCollection();
			if (queryParams != null)
			{
				// Add to request values
				foreach (var kv in queryParams)
					requestValues.Add(kv.Key, kv.Value);
			}

			IsStateReadonly = true;

			Models.T_002 parentCtx = requestModel.Model == null ? null : new(UserContext.Current);
			requestModel.Model?.Init(UserContext.Current);
			requestModel.Model?.MapToModel(parentCtx);
			Fr_002_T_004ValCity_ViewModel model = new(UserContext.Current, parentCtx);

			// Table configuration load options
			CSGenio.framework.TableConfiguration.TableConfigurationLoadOptions tableConfigOptions = new CSGenio.framework.TableConfiguration.TableConfigurationLoadOptions();

			// Determine which table configuration to use and load it
			CSGenio.framework.TableConfiguration.TableConfiguration tableConfig = TableUiSettings.Load(
				UserContext.Current.PersistentSupport,
				model.Uuid,
				UserContext.Current.User,
				tableConfigOptions
			).DetermineTableConfig(
				requestModel?.TableConfiguration,
				requestModel?.UserTableConfigName,
				(bool)requestModel?.LoadDefaultView,
				tableConfigOptions
			);

			// Determine rows per page
			tableConfig.RowsPerPage = CSGenio.framework.TableConfiguration.TableConfigurationHelpers.DetermineRowsPerPage(tableConfig.RowsPerPage, perPage, rowsPerPageOptionsString);

			// Determine which columns have totalizers
			tableConfig.TotalizerColumns = requestModel.TotalizerColumns;

			// For tables with multiple selection enabled, determine currently selected rows
			tableConfig.SelectedRows = requestModel.SelectedRows;

			// Add form field filters to the table configuration
			tableConfig.FieldFilters = requestModel.RelatedFilterValues;

			model.setModes(Request.Query["m"].ToString());
			model.Load(tableConfig, requestValues, Request.IsAjaxRequest());

			return JsonOK(model);
		}

		public class Fr_002_T_001ValEmailModel : RequestLookupModel
		{
			public Fr_002_ViewModel Model { get; set; }
		}

		//
		// GET: /T_002/Fr_002_T_001ValEmail
		// POST: /T_002/Fr_002_T_001ValEmail
		[ActionName("Fr_002_T_001ValEmail")]
		public ActionResult Fr_002_T_001ValEmail([FromBody] Fr_002_T_001ValEmailModel requestModel)
		{
			var queryParams = requestModel.QueryParams;

			int perPage = CSGenio.framework.Configuration.NrRegDBedit;
			string rowsPerPageOptionsString = "";

			// If there was a recent operation on this table then force the primary persistence server to be called and ignore the read only feature
			if (string.IsNullOrEmpty(Navigation.GetStrValue("ForcePrimaryRead_t_001")))
				UserContext.Current.SetPersistenceReadOnly(true);
			else
			{
				Navigation.DestroyEntry("ForcePrimaryRead_t_001");
				UserContext.Current.SetPersistenceReadOnly(false);
			}

			var requestValues = new NameValueCollection();
			if (queryParams != null)
			{
				// Add to request values
				foreach (var kv in queryParams)
					requestValues.Add(kv.Key, kv.Value);
			}

			IsStateReadonly = true;

			Models.T_002 parentCtx = requestModel.Model == null ? null : new(UserContext.Current);
			requestModel.Model?.Init(UserContext.Current);
			requestModel.Model?.MapToModel(parentCtx);
			Fr_002_T_001ValEmail_ViewModel model = new(UserContext.Current, parentCtx);

			// Table configuration load options
			CSGenio.framework.TableConfiguration.TableConfigurationLoadOptions tableConfigOptions = new CSGenio.framework.TableConfiguration.TableConfigurationLoadOptions();

			// Determine which table configuration to use and load it
			CSGenio.framework.TableConfiguration.TableConfiguration tableConfig = TableUiSettings.Load(
				UserContext.Current.PersistentSupport,
				model.Uuid,
				UserContext.Current.User,
				tableConfigOptions
			).DetermineTableConfig(
				requestModel?.TableConfiguration,
				requestModel?.UserTableConfigName,
				(bool)requestModel?.LoadDefaultView,
				tableConfigOptions
			);

			// Determine rows per page
			tableConfig.RowsPerPage = CSGenio.framework.TableConfiguration.TableConfigurationHelpers.DetermineRowsPerPage(tableConfig.RowsPerPage, perPage, rowsPerPageOptionsString);

			// Determine which columns have totalizers
			tableConfig.TotalizerColumns = requestModel.TotalizerColumns;

			// For tables with multiple selection enabled, determine currently selected rows
			tableConfig.SelectedRows = requestModel.SelectedRows;

			// Add form field filters to the table configuration
			tableConfig.FieldFilters = requestModel.RelatedFilterValues;

			model.setModes(Request.Query["m"].ToString());
			model.Load(tableConfig, requestValues, Request.IsAjaxRequest());

			return JsonOK(model);
		}

		public class Fr_002_ValTab_001Model : RequestLookupModel
		{
			public Fr_002_ViewModel Model { get; set; }
		}

		//
		// GET: /T_002/Fr_002_ValTab_001
		// POST: /T_002/Fr_002_ValTab_001
		[ActionName("Fr_002_ValTab_001")]
		public ActionResult Fr_002_ValTab_001([FromBody] Fr_002_ValTab_001Model requestModel)
		{
			var queryParams = requestModel.QueryParams;

			int perPage = CSGenio.framework.Configuration.NrRegDBedit;
			string rowsPerPageOptionsString = "";

			// If there was a recent operation on this table then force the primary persistence server to be called and ignore the read only feature
			if (string.IsNullOrEmpty(Navigation.GetStrValue("ForcePrimaryRead_t_006")))
				UserContext.Current.SetPersistenceReadOnly(true);
			else
			{
				Navigation.DestroyEntry("ForcePrimaryRead_t_006");
				UserContext.Current.SetPersistenceReadOnly(false);
			}

			var requestValues = new NameValueCollection();
			if (queryParams != null)
			{
				// Add to request values
				foreach (var kv in queryParams)
					requestValues.Add(kv.Key, kv.Value);
			}

			Models.T_002 parentCtx = requestModel.Model == null ? null : new(UserContext.Current);
			requestModel.Model?.Init(UserContext.Current);
			requestModel.Model?.MapToModel(parentCtx);
			Fr_002_ValTab_001_ViewModel model = new(UserContext.Current, parentCtx);

			// Table configuration load options
			CSGenio.framework.TableConfiguration.TableConfigurationLoadOptions tableConfigOptions = new CSGenio.framework.TableConfiguration.TableConfigurationLoadOptions();

			// Determine which table configuration to use and load it
			CSGenio.framework.TableConfiguration.TableConfiguration tableConfig = TableUiSettings.Load(
				UserContext.Current.PersistentSupport,
				model.Uuid,
				UserContext.Current.User,
				tableConfigOptions
			).DetermineTableConfig(
				requestModel?.TableConfiguration,
				requestModel?.UserTableConfigName,
				(bool)requestModel?.LoadDefaultView,
				tableConfigOptions
			);

			// Determine rows per page
			tableConfig.RowsPerPage = CSGenio.framework.TableConfiguration.TableConfigurationHelpers.DetermineRowsPerPage(tableConfig.RowsPerPage, perPage, rowsPerPageOptionsString);

			// Determine which columns have totalizers
			tableConfig.TotalizerColumns = requestModel.TotalizerColumns;

			// For tables with multiple selection enabled, determine currently selected rows
			tableConfig.SelectedRows = requestModel.SelectedRows;

			// Add form field filters to the table configuration
			tableConfig.FieldFilters = requestModel.RelatedFilterValues;

			model.setModes(Request.Query["m"].ToString());
			model.Load(tableConfig, requestValues, Request.IsAjaxRequest());

			return JsonOK(model);
		}

		public class Fr_002_ValTab_002Model : RequestLookupModel
		{
			public Fr_002_ViewModel Model { get; set; }
		}

		//
		// GET: /T_002/Fr_002_ValTab_002
		// POST: /T_002/Fr_002_ValTab_002
		[ActionName("Fr_002_ValTab_002")]
		public ActionResult Fr_002_ValTab_002([FromBody] Fr_002_ValTab_002Model requestModel)
		{
			var queryParams = requestModel.QueryParams;

			int perPage = CSGenio.framework.Configuration.NrRegDBedit;
			string rowsPerPageOptionsString = "";

			// If there was a recent operation on this table then force the primary persistence server to be called and ignore the read only feature
			if (string.IsNullOrEmpty(Navigation.GetStrValue("ForcePrimaryRead_t_005")))
				UserContext.Current.SetPersistenceReadOnly(true);
			else
			{
				Navigation.DestroyEntry("ForcePrimaryRead_t_005");
				UserContext.Current.SetPersistenceReadOnly(false);
			}

			var requestValues = new NameValueCollection();
			if (queryParams != null)
			{
				// Add to request values
				foreach (var kv in queryParams)
					requestValues.Add(kv.Key, kv.Value);
			}

			Models.T_002 parentCtx = requestModel.Model == null ? null : new(UserContext.Current);
			requestModel.Model?.Init(UserContext.Current);
			requestModel.Model?.MapToModel(parentCtx);
			Fr_002_ValTab_002_ViewModel model = new(UserContext.Current, parentCtx);

			// Table configuration load options
			CSGenio.framework.TableConfiguration.TableConfigurationLoadOptions tableConfigOptions = new CSGenio.framework.TableConfiguration.TableConfigurationLoadOptions();

			// Determine which table configuration to use and load it
			CSGenio.framework.TableConfiguration.TableConfiguration tableConfig = TableUiSettings.Load(
				UserContext.Current.PersistentSupport,
				model.Uuid,
				UserContext.Current.User,
				tableConfigOptions
			).DetermineTableConfig(
				requestModel?.TableConfiguration,
				requestModel?.UserTableConfigName,
				(bool)requestModel?.LoadDefaultView,
				tableConfigOptions
			);

			// Determine rows per page
			tableConfig.RowsPerPage = CSGenio.framework.TableConfiguration.TableConfigurationHelpers.DetermineRowsPerPage(tableConfig.RowsPerPage, perPage, rowsPerPageOptionsString);

			// Determine which columns have totalizers
			tableConfig.TotalizerColumns = requestModel.TotalizerColumns;

			// For tables with multiple selection enabled, determine currently selected rows
			tableConfig.SelectedRows = requestModel.SelectedRows;

			// Add form field filters to the table configuration
			tableConfig.FieldFilters = requestModel.RelatedFilterValues;

			model.setModes(Request.Query["m"].ToString());
			model.Load(tableConfig, requestValues, Request.IsAjaxRequest());

			return JsonOK(model);
		}

		// POST: /T_002/Fr_002_SaveEdit
		[HttpPost]
		public ActionResult Fr_002_SaveEdit([FromBody] Fr_002_ViewModel model)
		{
			EventSink eventSink = new()
			{
				MethodName = "Fr_002_SaveEdit",
				ViewName = "Fr_002",
				AreaName = "t_002",
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_APPLY_EDIT FR_002]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_APPLY_EDIT FR_002]/
				}
			};

			return GenericHandlePostFormApply(eventSink, model);
		}

		public class Fr_002DocumValidateTickets : RequestDocumValidateTickets
		{
			public Fr_002_ViewModel Model { get; set; }
		}

		/// <summary>
		/// Checks if the model is valid and, if so, updates the specified tickets with write permissions
		/// </summary>
		/// <param name="requestModel">The request model with a list of tickets and the form model</param>
		/// <returns>A JSON response with the result of the operation</returns>
		public ActionResult UpdateFilesTicketsFr_002([FromBody] Fr_002DocumValidateTickets requestModel)
		{
			requestModel.Model.Init(UserContext.Current);
			return UpdateFilesTickets(requestModel.Tickets, requestModel.Model, requestModel.IsApply);
		}
	}
}
