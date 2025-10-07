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
using GenioMVC.ViewModels.T_004;
using Quidgest.Persistence.GenericQuery;

// USE /[MANUAL RMS INCLUDE_CONTROLLER T_004]/

namespace GenioMVC.Controllers
{
	public partial class T_004Controller : ControllerBase
	{
		#region NavigationLocation Names

		private static readonly NavigationLocation ACTION_FR_004_CANCEL = new("CITY42505", "Fr_004_Cancel", "T_004") { vueRouteName = "form-FR_004", mode = "CANCEL" };
		private static readonly NavigationLocation ACTION_FR_004_SHOW = new("CITY42505", "Fr_004_Show", "T_004") { vueRouteName = "form-FR_004", mode = "SHOW" };
		private static readonly NavigationLocation ACTION_FR_004_NEW = new("CITY42505", "Fr_004_New", "T_004") { vueRouteName = "form-FR_004", mode = "NEW" };
		private static readonly NavigationLocation ACTION_FR_004_EDIT = new("CITY42505", "Fr_004_Edit", "T_004") { vueRouteName = "form-FR_004", mode = "EDIT" };
		private static readonly NavigationLocation ACTION_FR_004_DUPLICATE = new("CITY42505", "Fr_004_Duplicate", "T_004") { vueRouteName = "form-FR_004", mode = "DUPLICATE" };
		private static readonly NavigationLocation ACTION_FR_004_DELETE = new("CITY42505", "Fr_004_Delete", "T_004") { vueRouteName = "form-FR_004", mode = "DELETE" };

		#endregion

		#region Fr_004 private

		private void FormHistoryLimits_Fr_004()
		{

		}

		#endregion

		#region Fr_004_Show

// USE /[MANUAL RMS CONTROLLER_SHOW FR_004]/

		[HttpPost]
		public ActionResult Fr_004_Show_GET([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new Fr_004_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_004_Show_GET",
				AreaName = "t_004",
				Location = ACTION_FR_004_SHOW,
				BeforeOp = (sink, sp) =>
				{
					FormHistoryLimits_Fr_004();
// USE /[MANUAL RMS BEFORE_LOAD_SHOW FR_004]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_SHOW FR_004]/
				}
			};

			return GenericHandleGetFormShow(eventSink, model, id);
		}

		#endregion

		#region Fr_004_New

// USE /[MANUAL RMS CONTROLLER_NEW_GET FR_004]/
		[HttpPost]
		public ActionResult Fr_004_New_GET([FromBody]RequestNewGetModel requestModel)
		{
			var id = requestModel.Id;
			var isNewLocation = requestModel.IsNewLocation;
			var prefillValues = requestModel.PrefillValues;

			var model = new Fr_004_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_004_New_GET",
				AreaName = "t_004",
				FormName = "FR_004",
				Location = ACTION_FR_004_NEW,
				BeforeAll = (sink, sp) =>
				{
					FormHistoryLimits_Fr_004();
				},
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_NEW FR_004]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_NEW FR_004]/
				}
			};

			return GenericHandleGetFormNew(eventSink, model, id, isNewLocation, prefillValues);
		}

		//
		// POST: /T_004/Fr_004_New
// USE /[MANUAL RMS CONTROLLER_NEW_POST FR_004]/
		[HttpPost]
		public ActionResult Fr_004_New([FromBody]Fr_004_ViewModel model, [FromQuery]bool redirect = true)
		{
			var eventSink = new EventSink()
			{
				MethodName = "Fr_004_New",
				ViewName = "Fr_004",
				AreaName = "t_004",
				Location = ACTION_FR_004_NEW,
				Redirect = redirect,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_SAVE_NEW FR_004]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_SAVE_NEW FR_004]/
				},
				BeforeException = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_NEW_EX FR_004]/
				},
				AfterException = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_NEW_EX FR_004]/
				}
			};

			return GenericHandlePostFormNew(eventSink, model);
		}

		#endregion

		#region Fr_004_Edit

// USE /[MANUAL RMS CONTROLLER_EDIT_GET FR_004]/
		[HttpPost]
		public ActionResult Fr_004_Edit_GET([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new Fr_004_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_004_Edit_GET",
				AreaName = "t_004",
				FormName = "FR_004",
				Location = ACTION_FR_004_EDIT,
				BeforeOp = (sink, sp) =>
				{
					FormHistoryLimits_Fr_004();
// USE /[MANUAL RMS BEFORE_LOAD_EDIT FR_004]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_EDIT FR_004]/
				}
			};

			return GenericHandleGetFormEdit(eventSink, model, id);
		}

		//
		// POST: /T_004/Fr_004_Edit
// USE /[MANUAL RMS CONTROLLER_EDIT_POST FR_004]/
		[HttpPost]
		public ActionResult Fr_004_Edit([FromBody]Fr_004_ViewModel model, [FromQuery]bool redirect)
		{
			var eventSink = new EventSink()
			{
				MethodName = "Fr_004_Edit",
				ViewName = "Fr_004",
				AreaName = "t_004",
				Location = ACTION_FR_004_EDIT,
				Redirect = redirect,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_SAVE_EDIT FR_004]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_SAVE_EDIT FR_004]/
				},
				BeforeException = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_EDIT_EX FR_004]/
				},
				AfterException = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_EDIT_EX FR_004]/
				}
			};

			return GenericHandlePostFormEdit(eventSink, model);
		}

		#endregion

		#region Fr_004_Delete

// USE /[MANUAL RMS CONTROLLER_DELETE_GET FR_004]/
		[HttpPost]
		public ActionResult Fr_004_Delete_GET([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new Fr_004_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_004_Delete_GET",
				AreaName = "t_004",
				FormName = "FR_004",
				Location = ACTION_FR_004_DELETE,
				BeforeOp = (sink, sp) =>
				{
					FormHistoryLimits_Fr_004();
// USE /[MANUAL RMS BEFORE_LOAD_DELETE FR_004]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_DELETE FR_004]/
				}
			};

			return GenericHandleGetFormDelete(eventSink, model, id);
		}

		//
		// POST: /T_004/Fr_004_Delete
// USE /[MANUAL RMS CONTROLLER_DELETE_POST FR_004]/
		[HttpPost]
		public ActionResult Fr_004_Delete([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new Fr_004_ViewModel (UserContext.Current, id);
			model.MapFromModel();

			var eventSink = new EventSink()
			{
				MethodName = "Fr_004_Delete",
				ViewName = "Fr_004",
				AreaName = "t_004",
				Location = ACTION_FR_004_DELETE,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_DESTROY_DELETE FR_004]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_DESTROY_DELETE FR_004]/
				}
			};

			return GenericHandlePostFormDelete(eventSink, model);
		}

		public ActionResult Fr_004_Delete_Redirect()
		{
			//FOR: FORM MENU GO BACK
			return RedirectToFormMenuGoBack("FR_004");
		}

		#endregion

		#region Fr_004_Duplicate

// USE /[MANUAL RMS CONTROLLER_DUPLICATE_GET FR_004]/

		[HttpPost]
		public ActionResult Fr_004_Duplicate_GET([FromBody]RequestNewGetModel requestModel)
		{
			var id = requestModel.Id;
			var isNewLocation = requestModel.IsNewLocation;

			var model = new Fr_004_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_004_Duplicate_GET",
				AreaName = "t_004",
				FormName = "FR_004",
				Location = ACTION_FR_004_DUPLICATE,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_DUPLICATE FR_004]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_DUPLICATE FR_004]/
				}
			};

			return GenericHandleGetFormDuplicate(eventSink, model, id, isNewLocation);
		}

		//
		// POST: /T_004/Fr_004_Duplicate
// USE /[MANUAL RMS CONTROLLER_DUPLICATE_POST FR_004]/
		[HttpPost]
		public ActionResult Fr_004_Duplicate([FromBody]Fr_004_ViewModel model, [FromQuery]bool redirect = true)
		{
			var eventSink = new EventSink()
			{
				MethodName = "Fr_004_Duplicate",
				ViewName = "Fr_004",
				AreaName = "t_004",
				Location = ACTION_FR_004_DUPLICATE,
				Redirect = redirect,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_SAVE_DUPLICATE FR_004]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_SAVE_DUPLICATE FR_004]/
				},
				BeforeException = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_DUPLICATE_EX FR_004]/
				},
				AfterException = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_DUPLICATE_EX FR_004]/
				}
			};

			return GenericHandlePostFormDuplicate(eventSink, model);
		}

		#endregion

		#region Fr_004_Cancel

		//
		// GET: /T_004/Fr_004_Cancel
// USE /[MANUAL RMS CONTROLLER_CANCEL_GET FR_004]/
		public ActionResult Fr_004_Cancel()
		{
			if (Navigation.CurrentLevel.FormMode == FormMode.New || Navigation.CurrentLevel.FormMode == FormMode.Duplicate)
			{
				PersistentSupport sp = UserContext.Current.PersistentSupport;
				try
				{
					var model = new GenioMVC.Models.T_004(UserContext.Current);
					model.klass.QPrimaryKey = Navigation.GetStrValue("t_004");

// USE /[MANUAL RMS BEFORE_CANCEL FR_004]/

					sp.openTransaction();
					model.Destroy();
					sp.closeTransaction();

// USE /[MANUAL RMS AFTER_CANCEL FR_004]/

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

				Navigation.SetValue("ForcePrimaryRead_t_004", "true", true);
			}

			Navigation.ClearValue("t_004");

			return JsonOK(new { Success = true, currentNavigationLevel = Navigation.CurrentLevel.Level });
		}

		#endregion


		public class Fr_004_T_003ValCountryModel : RequestLookupModel
		{
			public Fr_004_ViewModel Model { get; set; }
		}

		//
		// GET: /T_004/Fr_004_T_003ValCountry
		// POST: /T_004/Fr_004_T_003ValCountry
		[ActionName("Fr_004_T_003ValCountry")]
		public ActionResult Fr_004_T_003ValCountry([FromBody] Fr_004_T_003ValCountryModel requestModel)
		{
			var queryParams = requestModel.QueryParams;

			int perPage = CSGenio.framework.Configuration.NrRegDBedit;
			string rowsPerPageOptionsString = "";

			// If there was a recent operation on this table then force the primary persistence server to be called and ignore the read only feature
			if (string.IsNullOrEmpty(Navigation.GetStrValue("ForcePrimaryRead_t_003")))
				UserContext.Current.SetPersistenceReadOnly(true);
			else
			{
				Navigation.DestroyEntry("ForcePrimaryRead_t_003");
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

			Models.T_004 parentCtx = requestModel.Model == null ? null : new(UserContext.Current);
			requestModel.Model?.Init(UserContext.Current);
			requestModel.Model?.MapToModel(parentCtx);
			Fr_004_T_003ValCountry_ViewModel model = new(UserContext.Current, parentCtx);

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

		// POST: /T_004/Fr_004_SaveEdit
		[HttpPost]
		public ActionResult Fr_004_SaveEdit([FromBody] Fr_004_ViewModel model)
		{
			EventSink eventSink = new()
			{
				MethodName = "Fr_004_SaveEdit",
				ViewName = "Fr_004",
				AreaName = "t_004",
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_APPLY_EDIT FR_004]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_APPLY_EDIT FR_004]/
				}
			};

			return GenericHandlePostFormApply(eventSink, model);
		}

		public class Fr_004DocumValidateTickets : RequestDocumValidateTickets
		{
			public Fr_004_ViewModel Model { get; set; }
		}

		/// <summary>
		/// Checks if the model is valid and, if so, updates the specified tickets with write permissions
		/// </summary>
		/// <param name="requestModel">The request model with a list of tickets and the form model</param>
		/// <returns>A JSON response with the result of the operation</returns>
		public ActionResult UpdateFilesTicketsFr_004([FromBody] Fr_004DocumValidateTickets requestModel)
		{
			requestModel.Model.Init(UserContext.Current);
			return UpdateFilesTickets(requestModel.Tickets, requestModel.Model, requestModel.IsApply);
		}
	}
}
