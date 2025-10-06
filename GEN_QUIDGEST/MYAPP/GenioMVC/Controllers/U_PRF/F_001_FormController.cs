﻿using Microsoft.AspNetCore.Authorization;
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
using GenioMVC.ViewModels.U_prf;
using Quidgest.Persistence.GenericQuery;

// USE /[MANUAL RMS INCLUDE_CONTROLLER U_PRF]/

namespace GenioMVC.Controllers
{
	public partial class U_prfController : ControllerBase
	{
		#region NavigationLocation Names

		private static readonly NavigationLocation ACTION_F_001_CANCEL = new("USER_PROFILE06358", "F_001_Cancel", "U_prf") { vueRouteName = "form-F_001", mode = "CANCEL" };
		private static readonly NavigationLocation ACTION_F_001_SHOW = new("USER_PROFILE06358", "F_001_Show", "U_prf") { vueRouteName = "form-F_001", mode = "SHOW" };
		private static readonly NavigationLocation ACTION_F_001_NEW = new("USER_PROFILE06358", "F_001_New", "U_prf") { vueRouteName = "form-F_001", mode = "NEW" };
		private static readonly NavigationLocation ACTION_F_001_EDIT = new("USER_PROFILE06358", "F_001_Edit", "U_prf") { vueRouteName = "form-F_001", mode = "EDIT" };
		private static readonly NavigationLocation ACTION_F_001_DUPLICATE = new("USER_PROFILE06358", "F_001_Duplicate", "U_prf") { vueRouteName = "form-F_001", mode = "DUPLICATE" };
		private static readonly NavigationLocation ACTION_F_001_DELETE = new("USER_PROFILE06358", "F_001_Delete", "U_prf") { vueRouteName = "form-F_001", mode = "DELETE" };

		#endregion

		#region F_001 private

		private void FormHistoryLimits_F_001()
		{

		}

		#endregion

		#region F_001_Show

// USE /[MANUAL RMS CONTROLLER_SHOW F_001]/

		[HttpPost]
		public ActionResult F_001_Show_GET([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new F_001_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "F_001_Show_GET",
				AreaName = "u_prf",
				Location = ACTION_F_001_SHOW,
				BeforeOp = (sink, sp) =>
				{
					FormHistoryLimits_F_001();
// USE /[MANUAL RMS BEFORE_LOAD_SHOW F_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_SHOW F_001]/
				}
			};

			return GenericHandleGetFormShow(eventSink, model, id);
		}

		#endregion

		#region F_001_New

// USE /[MANUAL RMS CONTROLLER_NEW_GET F_001]/
		[HttpPost]
		public ActionResult F_001_New_GET([FromBody]RequestNewGetModel requestModel)
		{
			var id = requestModel.Id;
			var isNewLocation = requestModel.IsNewLocation;
			var prefillValues = requestModel.PrefillValues;

			var model = new F_001_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "F_001_New_GET",
				AreaName = "u_prf",
				FormName = "F_001",
				Location = ACTION_F_001_NEW,
				BeforeAll = (sink, sp) =>
				{
					FormHistoryLimits_F_001();
				},
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_NEW F_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_NEW F_001]/
				}
			};

			return GenericHandleGetFormNew(eventSink, model, id, isNewLocation, prefillValues);
		}

		//
		// POST: /U_prf/F_001_New
// USE /[MANUAL RMS CONTROLLER_NEW_POST F_001]/
		[HttpPost]
		public ActionResult F_001_New([FromBody]F_001_ViewModel model, [FromQuery]bool redirect = true)
		{
			var eventSink = new EventSink()
			{
				MethodName = "F_001_New",
				ViewName = "F_001",
				AreaName = "u_prf",
				Location = ACTION_F_001_NEW,
				Redirect = redirect,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_SAVE_NEW F_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_SAVE_NEW F_001]/
				},
				BeforeException = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_NEW_EX F_001]/
				},
				AfterException = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_NEW_EX F_001]/
				}
			};

			return GenericHandlePostFormNew(eventSink, model);
		}

		#endregion

		#region F_001_Edit

// USE /[MANUAL RMS CONTROLLER_EDIT_GET F_001]/
		[HttpPost]
		public ActionResult F_001_Edit_GET([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new F_001_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "F_001_Edit_GET",
				AreaName = "u_prf",
				FormName = "F_001",
				Location = ACTION_F_001_EDIT,
				BeforeOp = (sink, sp) =>
				{
					FormHistoryLimits_F_001();
// USE /[MANUAL RMS BEFORE_LOAD_EDIT F_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_EDIT F_001]/
				}
			};

			return GenericHandleGetFormEdit(eventSink, model, id);
		}

		//
		// POST: /U_prf/F_001_Edit
// USE /[MANUAL RMS CONTROLLER_EDIT_POST F_001]/
		[HttpPost]
		public ActionResult F_001_Edit([FromBody]F_001_ViewModel model, [FromQuery]bool redirect)
		{
			var eventSink = new EventSink()
			{
				MethodName = "F_001_Edit",
				ViewName = "F_001",
				AreaName = "u_prf",
				Location = ACTION_F_001_EDIT,
				Redirect = redirect,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_SAVE_EDIT F_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_SAVE_EDIT F_001]/
				},
				BeforeException = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_EDIT_EX F_001]/
				},
				AfterException = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_EDIT_EX F_001]/
				}
			};

			return GenericHandlePostFormEdit(eventSink, model);
		}

		#endregion

		#region F_001_Delete

// USE /[MANUAL RMS CONTROLLER_DELETE_GET F_001]/
		[HttpPost]
		public ActionResult F_001_Delete_GET([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new F_001_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "F_001_Delete_GET",
				AreaName = "u_prf",
				FormName = "F_001",
				Location = ACTION_F_001_DELETE,
				BeforeOp = (sink, sp) =>
				{
					FormHistoryLimits_F_001();
// USE /[MANUAL RMS BEFORE_LOAD_DELETE F_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_DELETE F_001]/
				}
			};

			return GenericHandleGetFormDelete(eventSink, model, id);
		}

		//
		// POST: /U_prf/F_001_Delete
// USE /[MANUAL RMS CONTROLLER_DELETE_POST F_001]/
		[HttpPost]
		public ActionResult F_001_Delete([FromBody]RequestIdModel requestModel)
		{
			var id = requestModel.Id;
			var model = new F_001_ViewModel (UserContext.Current, id);
			model.MapFromModel();

			var eventSink = new EventSink()
			{
				MethodName = "F_001_Delete",
				ViewName = "F_001",
				AreaName = "u_prf",
				Location = ACTION_F_001_DELETE,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_DESTROY_DELETE F_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_DESTROY_DELETE F_001]/
				}
			};

			return GenericHandlePostFormDelete(eventSink, model);
		}

		public ActionResult F_001_Delete_Redirect()
		{
			//FOR: FORM MENU GO BACK
			return RedirectToFormMenuGoBack("F_001");
		}

		#endregion

		#region F_001_Duplicate

// USE /[MANUAL RMS CONTROLLER_DUPLICATE_GET F_001]/

		[HttpPost]
		public ActionResult F_001_Duplicate_GET([FromBody]RequestNewGetModel requestModel)
		{
			var id = requestModel.Id;
			var isNewLocation = requestModel.IsNewLocation;

			var model = new F_001_ViewModel(UserContext.Current);
			var eventSink = new EventSink()
			{
				MethodName = "F_001_Duplicate_GET",
				AreaName = "u_prf",
				FormName = "F_001",
				Location = ACTION_F_001_DUPLICATE,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_DUPLICATE F_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_DUPLICATE F_001]/
				}
			};

			return GenericHandleGetFormDuplicate(eventSink, model, id, isNewLocation);
		}

		//
		// POST: /U_prf/F_001_Duplicate
// USE /[MANUAL RMS CONTROLLER_DUPLICATE_POST F_001]/
		[HttpPost]
		public ActionResult F_001_Duplicate([FromBody]F_001_ViewModel model, [FromQuery]bool redirect = true)
		{
			var eventSink = new EventSink()
			{
				MethodName = "F_001_Duplicate",
				ViewName = "F_001",
				AreaName = "u_prf",
				Location = ACTION_F_001_DUPLICATE,
				Redirect = redirect,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_SAVE_DUPLICATE F_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_SAVE_DUPLICATE F_001]/
				},
				BeforeException = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_LOAD_DUPLICATE_EX F_001]/
				},
				AfterException = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_LOAD_DUPLICATE_EX F_001]/
				}
			};

			return GenericHandlePostFormDuplicate(eventSink, model);
		}

		#endregion

		#region F_001_Cancel

		//
		// GET: /U_prf/F_001_Cancel
// USE /[MANUAL RMS CONTROLLER_CANCEL_GET F_001]/
		public ActionResult F_001_Cancel()
		{
			if (Navigation.CurrentLevel.FormMode == FormMode.New || Navigation.CurrentLevel.FormMode == FormMode.Duplicate)
			{
				PersistentSupport sp = UserContext.Current.PersistentSupport;
				try
				{
					var model = new GenioMVC.Models.U_prf(UserContext.Current);
					model.klass.QPrimaryKey = Navigation.GetStrValue("u_prf");

// USE /[MANUAL RMS BEFORE_CANCEL F_001]/

					sp.openTransaction();
					model.Destroy();
					sp.closeTransaction();

// USE /[MANUAL RMS AFTER_CANCEL F_001]/

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

				Navigation.SetValue("ForcePrimaryRead_u_prf", "true", true);
			}

			Navigation.ClearValue("u_prf");

			return JsonOK(new { Success = true, currentNavigationLevel = Navigation.CurrentLevel.Level });
		}

		#endregion


		// POST: /U_prf/F_001_SaveEdit
		[HttpPost]
		public ActionResult F_001_SaveEdit([FromBody] F_001_ViewModel model)
		{
			EventSink eventSink = new()
			{
				MethodName = "F_001_SaveEdit",
				ViewName = "F_001",
				AreaName = "u_prf",
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL RMS BEFORE_APPLY_EDIT F_001]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL RMS AFTER_APPLY_EDIT F_001]/
				}
			};

			return GenericHandlePostFormApply(eventSink, model);
		}

		public class F_001DocumValidateTickets : RequestDocumValidateTickets
		{
			public F_001_ViewModel Model { get; set; }
		}

		/// <summary>
		/// Checks if the model is valid and, if so, updates the specified tickets with write permissions
		/// </summary>
		/// <param name="requestModel">The request model with a list of tickets and the form model</param>
		/// <returns>A JSON response with the result of the operation</returns>
		public ActionResult UpdateFilesTicketsF_001([FromBody] F_001DocumValidateTickets requestModel)
		{
			requestModel.Model.Init(UserContext.Current);
			return UpdateFilesTickets(requestModel.Tickets, requestModel.Model, requestModel.IsApply);
		}
	}
}
