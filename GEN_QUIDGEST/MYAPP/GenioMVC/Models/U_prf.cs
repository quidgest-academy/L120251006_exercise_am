using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using CSGenio.business;
using CSGenio.framework;
using CSGenio.persistence;
using GenioMVC.Helpers;
using GenioMVC.Models.Navigation;
using Quidgest.Persistence;
using Quidgest.Persistence.GenericQuery;

using SelectList = Microsoft.AspNetCore.Mvc.Rendering.SelectList;
using JsonIgnoreAttribute = System.Text.Json.Serialization.JsonIgnoreAttribute;

namespace GenioMVC.Models
{
	public class U_prf : ModelBase
	{
		[JsonIgnore]
		public CSGenioAu_prf klass { get { return baseklass as CSGenioAu_prf; } set { baseklass = value; } }

		[Key]
		/// <summary>Field : "" Tipo: "+" Formula:  ""</summary>
		[ShouldSerialize("U_prf.ValCodu_prf")]
		public string ValCodu_prf { get { return klass.ValCodu_prf; } set { klass.ValCodu_prf = value; } }

		[DisplayName("Username")]
		/// <summary>Field : "Username" Tipo: "C" Formula:  ""</summary>
		[ShouldSerialize("U_prf.ValUsername")]
		public string ValUsername { get { return klass.ValUsername; } set { klass.ValUsername = value; } }

		[DisplayName("Date of Birth")]
		/// <summary>Field : "Date of Birth" Tipo: "D" Formula:  ""</summary>
		[ShouldSerialize("U_prf.ValBday")]
		[DataType(DataType.Date)]
		[DateAttribute("D")]
		public DateTime? ValBday { get { return klass.ValBday; } set { klass.ValBday = value ?? DateTime.MinValue; } }

		[DisplayName("User Image")]
		/// <summary>Field : "User Image" Tipo: "IJ" Formula:  ""</summary>
		[ShouldSerialize("U_prf.ValU_img")]
		[ImageThumbnailJsonConverter(75, 75)]
		public ImageModel ValU_img { get { return new ImageModel(klass.ValU_img) { Ticket = ValU_imgQTicket }; } set { klass.ValU_img = value; } }
		[JsonIgnore]
		public string ValU_imgQTicket = null;

		[DisplayName("Email")]
		/// <summary>Field : "Email" Tipo: "C" Formula:  ""</summary>
		[ShouldSerialize("U_prf.ValU_email")]
		public string ValU_email { get { return klass.ValU_email; } set { klass.ValU_email = value; } }

		[DisplayName("ZZSTATE")]
		[ShouldSerialize("U_prf.ValZzstate")]
		/// <summary>Field: "ZZSTATE", Type: "INT", Formula: ""</summary>
		public virtual int ValZzstate { get { return klass.ValZzstate; } set { klass.ValZzstate = value; } }

		public U_prf(UserContext userContext, bool isEmpty = false, string[]? fieldsToSerialize = null) : base(userContext)
		{
			klass = new CSGenioAu_prf(userContext.User);
			isEmptyModel = isEmpty;
			if (fieldsToSerialize != null)
				SetFieldsToSerialize(fieldsToSerialize);
		}

		public U_prf(UserContext userContext, CSGenioAu_prf val, bool isEmpty = false, string[]? fieldsToSerialize = null) : base(userContext)
		{
			klass = val;
			isEmptyModel = isEmpty;
			if (fieldsToSerialize != null)
				SetFieldsToSerialize(fieldsToSerialize);
			FillRelatedAreas(val);
		}

		public void FillRelatedAreas(CSGenioAu_prf csgenioa)
		{
			if (csgenioa == null)
				return;

			foreach (RequestedField Qfield in csgenioa.Fields.Values)
			{
				switch (Qfield.Area)
				{
					default:
						break;
				}
			}
		}

		/// <summary>
		/// Search the row by key.
		/// </summary>
		/// <param name="id">The primary key.</param>
		/// <param name="userCtx">The user context.</param>
		/// <param name="identifier">The identifier.</param>
		/// <param name="fieldsToSerialize">The fields to serialize.</param>
		/// <param name="fieldsToQuery">The fields to query.</param>
		/// <returns>Model or NULL</returns>
		public static U_prf Find(string id, UserContext userCtx, string identifier = null, string[] fieldsToSerialize = null, string[] fieldsToQuery = null)
		{
			var record = Find<CSGenioAu_prf>(id, userCtx, identifier, fieldsToQuery);
			return record == null ? null : new U_prf(userCtx, record, false, fieldsToSerialize) { Identifier = identifier };
		}

		public static List<U_prf> AllModel(UserContext userCtx, CriteriaSet args = null, string identifier = null)
		{
			return Where<CSGenioAu_prf>(userCtx, false, args, numRegs: -1, identifier: identifier).RowsForViewModel<U_prf>((r) => new U_prf(userCtx, r));
		}

// USE /[MANUAL RMS MODEL U_PRF]/
	}
}
