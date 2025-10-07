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
using GenioMVC.ViewModels.T_003;
using Quidgest.Persistence.GenericQuery;

// USE /[MANUAL RMS INCLUDE_CONTROLLER T_003]/

namespace GenioMVC.Controllers
{
	public partial class T_003Controller : ControllerBase
	{
		#region NavigationLocation Names

		private static readonly NavigationLocation ACTION_FR_003_CANCEL = new("COUNTRY64133", "Fr_003_Cancel", "T_003") { vueRouteName = "form-FR_003", mode = "CANCEL" };
		private static readonly NavigationLocation ACTION_FR_003_SHOW = new("COUNTRY64133", "Fr_003_Show", "T_003") { vueRouteName = "form-FR_003", mode = "SHOW" };
		private static readonly NavigationLocation ACTION_FR_003_NEW = new("COUNTRY64133", "Fr_003_New", "T_003") { vueRouteName = "form-FR_003", mode = "NEW" };
		private static readonly NavigationLocation ACTION_FR_003_EDIT = new("COUNTRY64133", "Fr_003_Edit", "T_003") { vueRouteName = "form-FR_003", mode = "EDIT" };
		private static readonly NavigationLocation ACTION_FR_003_DUPLICATE = new("COUNTRY64133", "Fr_003_Duplicate", "T_003") { vueRouteName = "form-FR_003", mode = "DUPLICATE" };
		private static readonly NavigationLocation ACTION_FR_003_DELETE = new("COUNTRY64133", "Fr_003_Delete", "T_003") { vueRouteName = "form-FR_003", mode = "DELETE" };

		#endregion

		#region Fr_003 private

		private void FormHistoryLimits_Fr_003()
		{

		}

		#endregion

		#region Fr_003_Show

// USE /[MANUAL RMS CONTROLLER_SHOW FR_003]/

		[HttpPost]
		public ActionResult Fr_003_Show_GET([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new Fr_003_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_003_Show_GET",
				AreaName = "t_003",
				Location = ACTION_FR_003_SHOW,
				BeforeOp = (sink, sp) =>
				{
					FormHistoryLimits_Fr_003();
// USE /[MANUAL RMS BEFORE_LOAD_SHOW FR_003]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_SHOW FR_003]/
				}
			};

			return GenericHandleGetFormShow(eventSink, model, id);
		}

		#endregion

		#region Fr_003_New

// USE /[MANUAL RMS CONTROLLER_NEW_GET FR_003]/
		[HttpPost]
		public ActionResult Fr_003_New_GET([FromBody]RequestNewGetModel requestModel)
		{
			var id = requestModel.Id;
			var isNewLocation = requestModel.IsNewLocation;
			var prefillValues = requestModel.PrefillValues;

			var model = new Fr_003_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_003_New_GET",
				AreaName = "t_003",
				FormName = "FR_003",
				Location = ACTION_FR_003_NEW,
				BeforeAll = (sink, sp) =>
				{
					FormHistoryLimits_Fr_003();
				},
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_NEW FR_003]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_NEW FR_003]/
				}
			};

			return GenericHandleGetFormNew(eventSink, model, id, isNewLocation, prefillValues);
		}

		//
		// POST: /T_003/Fr_003_New
// USE /[MANUAL RMS CONTROLLER_NEW_POST FR_003]/
		[HttpPost]
		public ActionResult Fr_003_New([FromBody]Fr_003_ViewModel model, [FromQuery]bool redirect = true)
		{
			var eventSink = new EventSink()
			{
				MethodName = "Fr_003_New",
				ViewName = "Fr_003",
				AreaName = "t_003",
				Location = ACTION_FR_003_NEW,
				Redirect = redirect,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_SAVE_NEW FR_003]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_SAVE_NEW FR_003]/
				},
				BeforeException = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_NEW_EX FR_003]/
				},
				AfterException = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_NEW_EX FR_003]/
				}
			};

			return GenericHandlePostFormNew(eventSink, model);
		}

		#endregion

		#region Fr_003_Edit

// USE /[MANUAL RMS CONTROLLER_EDIT_GET FR_003]/
		[HttpPost]
		public ActionResult Fr_003_Edit_GET([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new Fr_003_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_003_Edit_GET",
				AreaName = "t_003",
				FormName = "FR_003",
				Location = ACTION_FR_003_EDIT,
				BeforeOp = (sink, sp) =>
				{
					FormHistoryLimits_Fr_003();
// USE /[MANUAL RMS BEFORE_LOAD_EDIT FR_003]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_EDIT FR_003]/
				}
			};

			return GenericHandleGetFormEdit(eventSink, model, id);
		}

		//
		// POST: /T_003/Fr_003_Edit
// USE /[MANUAL RMS CONTROLLER_EDIT_POST FR_003]/
		[HttpPost]
		public ActionResult Fr_003_Edit([FromBody]Fr_003_ViewModel model, [FromQuery]bool redirect)
		{
			var eventSink = new EventSink()
			{
				MethodName = "Fr_003_Edit",
				ViewName = "Fr_003",
				AreaName = "t_003",
				Location = ACTION_FR_003_EDIT,
				Redirect = redirect,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_SAVE_EDIT FR_003]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_SAVE_EDIT FR_003]/
				},
				BeforeException = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_EDIT_EX FR_003]/
				},
				AfterException = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_EDIT_EX FR_003]/
				}
			};

			return GenericHandlePostFormEdit(eventSink, model);
		}

		#endregion

		#region Fr_003_Delete

// USE /[MANUAL RMS CONTROLLER_DELETE_GET FR_003]/
		[HttpPost]
		public ActionResult Fr_003_Delete_GET([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new Fr_003_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_003_Delete_GET",
				AreaName = "t_003",
				FormName = "FR_003",
				Location = ACTION_FR_003_DELETE,
				BeforeOp = (sink, sp) =>
				{
					FormHistoryLimits_Fr_003();
// USE /[MANUAL RMS BEFORE_LOAD_DELETE FR_003]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_DELETE FR_003]/
				}
			};

			return GenericHandleGetFormDelete(eventSink, model, id);
		}

		//
		// POST: /T_003/Fr_003_Delete
// USE /[MANUAL RMS CONTROLLER_DELETE_POST FR_003]/
		[HttpPost]
		public ActionResult Fr_003_Delete([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new Fr_003_ViewModel (UserContext.Current, id);
			model.MapFromModel();

			var eventSink = new EventSink()
			{
				MethodName = "Fr_003_Delete",
				ViewName = "Fr_003",
				AreaName = "t_003",
				Location = ACTION_FR_003_DELETE,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_DESTROY_DELETE FR_003]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_DESTROY_DELETE FR_003]/
				}
			};

			return GenericHandlePostFormDelete(eventSink, model);
		}

		public ActionResult Fr_003_Delete_Redirect()
		{
			//FOR: FORM MENU GO BACK
			return RedirectToFormMenuGoBack("FR_003");
		}

		#endregion

		#region Fr_003_Duplicate

// USE /[MANUAL RMS CONTROLLER_DUPLICATE_GET FR_003]/

		[HttpPost]
		public ActionResult Fr_003_Duplicate_GET([FromBody]RequestNewGetModel requestModel)
		{
			var id = requestModel.Id;
			var isNewLocation = requestModel.IsNewLocation;

			var model = new Fr_003_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_003_Duplicate_GET",
				AreaName = "t_003",
				FormName = "FR_003",
				Location = ACTION_FR_003_DUPLICATE,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_DUPLICATE FR_003]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_DUPLICATE FR_003]/
				}
			};

			return GenericHandleGetFormDuplicate(eventSink, model, id, isNewLocation);
		}

		//
		// POST: /T_003/Fr_003_Duplicate
// USE /[MANUAL RMS CONTROLLER_DUPLICATE_POST FR_003]/
		[HttpPost]
		public ActionResult Fr_003_Duplicate([FromBody]Fr_003_ViewModel model, [FromQuery]bool redirect = true)
		{
			var eventSink = new EventSink()
			{
				MethodName = "Fr_003_Duplicate",
				ViewName = "Fr_003",
				AreaName = "t_003",
				Location = ACTION_FR_003_DUPLICATE,
				Redirect = redirect,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_SAVE_DUPLICATE FR_003]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_SAVE_DUPLICATE FR_003]/
				},
				BeforeException = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_DUPLICATE_EX FR_003]/
				},
				AfterException = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_DUPLICATE_EX FR_003]/
				}
			};

			return GenericHandlePostFormDuplicate(eventSink, model);
		}

		#endregion

		#region Fr_003_Cancel

		//
		// GET: /T_003/Fr_003_Cancel
// USE /[MANUAL RMS CONTROLLER_CANCEL_GET FR_003]/
		public ActionResult Fr_003_Cancel()
		{
			if (Navigation.CurrentLevel.FormMode == FormMode.New || Navigation.CurrentLevel.FormMode == FormMode.Duplicate)
			{
				PersistentSupport sp = UserContext.Current.PersistentSupport;
				try
				{
					var model = new GenioMVC.Models.T_003(UserContext.Current);
					model.klass.QPrimaryKey = Navigation.GetStrValue("t_003");

// USE /[MANUAL RMS BEFORE_CANCEL FR_003]/

					sp.openTransaction();
					model.Destroy();
					sp.closeTransaction();

// USE /[MANUAL RMS AFTER_CANCEL FR_003]/

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

				Navigation.SetValue("ForcePrimaryRead_t_003", "true", true);
			}

			Navigation.ClearValue("t_003");

			return JsonOK(new { Success = true, currentNavigationLevel = Navigation.CurrentLevel.Level });
		}

		#endregion


		// POST: /T_003/Fr_003_SaveEdit
		[HttpPost]
		public ActionResult Fr_003_SaveEdit([FromBody] Fr_003_ViewModel model)
		{
			EventSink eventSink = new()
			{
				MethodName = "Fr_003_SaveEdit",
				ViewName = "Fr_003",
				AreaName = "t_003",
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_APPLY_EDIT FR_003]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_APPLY_EDIT FR_003]/
				}
			};

			return GenericHandlePostFormApply(eventSink, model);
		}

		public class Fr_003DocumValidateTickets : RequestDocumValidateTickets
		{
			public Fr_003_ViewModel Model { get; set; }
		}

		/// <summary>
		/// Checks if the model is valid and, if so, updates the specified tickets with write permissions
		/// </summary>
		/// <param name="requestModel">The request model with a list of tickets and the form model</param>
		/// <returns>A JSON response with the result of the operation</returns>
		public ActionResult UpdateFilesTicketsFr_003([FromBody] Fr_003DocumValidateTickets requestModel)
		{
			requestModel.Model.Init(UserContext.Current);
			return UpdateFilesTickets(requestModel.Tickets, requestModel.Model, requestModel.IsApply);
		}
	}
}
