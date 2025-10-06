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
using GenioMVC.ViewModels.T_001;
using Quidgest.Persistence.GenericQuery;

// USE /[MANUAL RMS INCLUDE_CONTROLLER T_001]/

namespace GenioMVC.Controllers
{
	public partial class T_001Controller : ControllerBase
	{
		#region NavigationLocation Names

		private static readonly NavigationLocation ACTION_FR_001_CANCEL = new("AGENT_ADD58504", "Fr_001_Cancel", "T_001") { vueRouteName = "form-FR_001", mode = "CANCEL" };
		private static readonly NavigationLocation ACTION_FR_001_SHOW = new("AGENT_ADD58504", "Fr_001_Show", "T_001") { vueRouteName = "form-FR_001", mode = "SHOW" };
		private static readonly NavigationLocation ACTION_FR_001_NEW = new("AGENT_ADD58504", "Fr_001_New", "T_001") { vueRouteName = "form-FR_001", mode = "NEW" };
		private static readonly NavigationLocation ACTION_FR_001_EDIT = new("AGENT_ADD58504", "Fr_001_Edit", "T_001") { vueRouteName = "form-FR_001", mode = "EDIT" };
		private static readonly NavigationLocation ACTION_FR_001_DUPLICATE = new("AGENT_ADD58504", "Fr_001_Duplicate", "T_001") { vueRouteName = "form-FR_001", mode = "DUPLICATE" };
		private static readonly NavigationLocation ACTION_FR_001_DELETE = new("AGENT_ADD58504", "Fr_001_Delete", "T_001") { vueRouteName = "form-FR_001", mode = "DELETE" };

		#endregion

		#region Fr_001 private

		private void FormHistoryLimits_Fr_001()
		{

		}

		#endregion

		#region Fr_001_Show

// USE /[MANUAL RMS CONTROLLER_SHOW FR_001]/

		[HttpPost]
		public ActionResult Fr_001_Show_GET([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new Fr_001_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_001_Show_GET",
				AreaName = "t_001",
				Location = ACTION_FR_001_SHOW,
				BeforeOp = (sink, sp) =>
				{
					FormHistoryLimits_Fr_001();
// USE /[MANUAL RMS BEFORE_LOAD_SHOW FR_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_SHOW FR_001]/
				}
			};

			return GenericHandleGetFormShow(eventSink, model, id);
		}

		#endregion

		#region Fr_001_New

// USE /[MANUAL RMS CONTROLLER_NEW_GET FR_001]/
		[HttpPost]
		public ActionResult Fr_001_New_GET([FromBody]RequestNewGetModel requestModel)
		{
			var id = requestModel.Id;
			var isNewLocation = requestModel.IsNewLocation;
			var prefillValues = requestModel.PrefillValues;

			var model = new Fr_001_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_001_New_GET",
				AreaName = "t_001",
				FormName = "FR_001",
				Location = ACTION_FR_001_NEW,
				BeforeAll = (sink, sp) =>
				{
					FormHistoryLimits_Fr_001();
				},
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_NEW FR_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_NEW FR_001]/
				}
			};

			return GenericHandleGetFormNew(eventSink, model, id, isNewLocation, prefillValues);
		}

		//
		// POST: /T_001/Fr_001_New
// USE /[MANUAL RMS CONTROLLER_NEW_POST FR_001]/
		[HttpPost]
		public ActionResult Fr_001_New([FromBody]Fr_001_ViewModel model, [FromQuery]bool redirect = true)
		{
			var eventSink = new EventSink()
			{
				MethodName = "Fr_001_New",
				ViewName = "Fr_001",
				AreaName = "t_001",
				Location = ACTION_FR_001_NEW,
				Redirect = redirect,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_SAVE_NEW FR_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_SAVE_NEW FR_001]/
				},
				BeforeException = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_NEW_EX FR_001]/
				},
				AfterException = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_NEW_EX FR_001]/
				}
			};

			return GenericHandlePostFormNew(eventSink, model);
		}

		#endregion

		#region Fr_001_Edit

// USE /[MANUAL RMS CONTROLLER_EDIT_GET FR_001]/
		[HttpPost]
		public ActionResult Fr_001_Edit_GET([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new Fr_001_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_001_Edit_GET",
				AreaName = "t_001",
				FormName = "FR_001",
				Location = ACTION_FR_001_EDIT,
				BeforeOp = (sink, sp) =>
				{
					FormHistoryLimits_Fr_001();
// USE /[MANUAL RMS BEFORE_LOAD_EDIT FR_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_EDIT FR_001]/
				}
			};

			return GenericHandleGetFormEdit(eventSink, model, id);
		}

		//
		// POST: /T_001/Fr_001_Edit
// USE /[MANUAL RMS CONTROLLER_EDIT_POST FR_001]/
		[HttpPost]
		public ActionResult Fr_001_Edit([FromBody]Fr_001_ViewModel model, [FromQuery]bool redirect)
		{
			var eventSink = new EventSink()
			{
				MethodName = "Fr_001_Edit",
				ViewName = "Fr_001",
				AreaName = "t_001",
				Location = ACTION_FR_001_EDIT,
				Redirect = redirect,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_SAVE_EDIT FR_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_SAVE_EDIT FR_001]/
				},
				BeforeException = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_EDIT_EX FR_001]/
				},
				AfterException = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_EDIT_EX FR_001]/
				}
			};

			return GenericHandlePostFormEdit(eventSink, model);
		}

		#endregion

		#region Fr_001_Delete

// USE /[MANUAL RMS CONTROLLER_DELETE_GET FR_001]/
		[HttpPost]
		public ActionResult Fr_001_Delete_GET([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new Fr_001_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_001_Delete_GET",
				AreaName = "t_001",
				FormName = "FR_001",
				Location = ACTION_FR_001_DELETE,
				BeforeOp = (sink, sp) =>
				{
					FormHistoryLimits_Fr_001();
// USE /[MANUAL RMS BEFORE_LOAD_DELETE FR_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_DELETE FR_001]/
				}
			};

			return GenericHandleGetFormDelete(eventSink, model, id);
		}

		//
		// POST: /T_001/Fr_001_Delete
// USE /[MANUAL RMS CONTROLLER_DELETE_POST FR_001]/
		[HttpPost]
		public ActionResult Fr_001_Delete([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new Fr_001_ViewModel (UserContext.Current, id);
			model.MapFromModel();

			var eventSink = new EventSink()
			{
				MethodName = "Fr_001_Delete",
				ViewName = "Fr_001",
				AreaName = "t_001",
				Location = ACTION_FR_001_DELETE,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_DESTROY_DELETE FR_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_DESTROY_DELETE FR_001]/
				}
			};

			return GenericHandlePostFormDelete(eventSink, model);
		}

		public ActionResult Fr_001_Delete_Redirect()
		{
			//FOR: FORM MENU GO BACK
			return RedirectToFormMenuGoBack("FR_001");
		}

		#endregion

		#region Fr_001_Duplicate

// USE /[MANUAL RMS CONTROLLER_DUPLICATE_GET FR_001]/

		[HttpPost]
		public ActionResult Fr_001_Duplicate_GET([FromBody]RequestNewGetModel requestModel)
		{
			var id = requestModel.Id;
			var isNewLocation = requestModel.IsNewLocation;

			var model = new Fr_001_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "Fr_001_Duplicate_GET",
				AreaName = "t_001",
				FormName = "FR_001",
				Location = ACTION_FR_001_DUPLICATE,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_DUPLICATE FR_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_DUPLICATE FR_001]/
				}
			};

			return GenericHandleGetFormDuplicate(eventSink, model, id, isNewLocation);
		}

		//
		// POST: /T_001/Fr_001_Duplicate
// USE /[MANUAL RMS CONTROLLER_DUPLICATE_POST FR_001]/
		[HttpPost]
		public ActionResult Fr_001_Duplicate([FromBody]Fr_001_ViewModel model, [FromQuery]bool redirect = true)
		{
			var eventSink = new EventSink()
			{
				MethodName = "Fr_001_Duplicate",
				ViewName = "Fr_001",
				AreaName = "t_001",
				Location = ACTION_FR_001_DUPLICATE,
				Redirect = redirect,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_SAVE_DUPLICATE FR_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_SAVE_DUPLICATE FR_001]/
				},
				BeforeException = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_DUPLICATE_EX FR_001]/
				},
				AfterException = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_DUPLICATE_EX FR_001]/
				}
			};

			return GenericHandlePostFormDuplicate(eventSink, model);
		}

		#endregion

		#region Fr_001_Cancel

		//
		// GET: /T_001/Fr_001_Cancel
// USE /[MANUAL RMS CONTROLLER_CANCEL_GET FR_001]/
		public ActionResult Fr_001_Cancel()
		{
			if (Navigation.CurrentLevel.FormMode == FormMode.New || Navigation.CurrentLevel.FormMode == FormMode.Duplicate)
			{
				PersistentSupport sp = UserContext.Current.PersistentSupport;
				try
				{
					var model = new GenioMVC.Models.T_001(UserContext.Current);
					model.klass.QPrimaryKey = Navigation.GetStrValue("t_001");

// USE /[MANUAL RMS BEFORE_CANCEL FR_001]/

					sp.openTransaction();
					model.Destroy();
					sp.closeTransaction();

// USE /[MANUAL RMS AFTER_CANCEL FR_001]/

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

				Navigation.SetValue("ForcePrimaryRead_t_001", "true", true);
			}

			Navigation.ClearValue("t_001");

			return JsonOK(new { Success = true, currentNavigationLevel = Navigation.CurrentLevel.Level });
		}

		#endregion


		// POST: /T_001/Fr_001_SaveEdit
		[HttpPost]
		public ActionResult Fr_001_SaveEdit([FromBody] Fr_001_ViewModel model)
		{
			EventSink eventSink = new()
			{
				MethodName = "Fr_001_SaveEdit",
				ViewName = "Fr_001",
				AreaName = "t_001",
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_APPLY_EDIT FR_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_APPLY_EDIT FR_001]/
				}
			};

			return GenericHandlePostFormApply(eventSink, model);
		}

		public class Fr_001DocumValidateTickets : RequestDocumValidateTickets
		{
			public Fr_001_ViewModel Model { get; set; }
		}

		/// <summary>
		/// Checks if the model is valid and, if so, updates the specified tickets with write permissions
		/// </summary>
		/// <param name="requestModel">The request model with a list of tickets and the form model</param>
		/// <returns>A JSON response with the result of the operation</returns>
		public ActionResult UpdateFilesTicketsFr_001([FromBody] Fr_001DocumValidateTickets requestModel)
		{
			requestModel.Model.Init(UserContext.Current);
			return UpdateFilesTickets(requestModel.Tickets, requestModel.Model, requestModel.IsApply);
		}
	}
}
