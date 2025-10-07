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
	public class T_002 : ModelBase
	{
		[JsonIgnore]
		public CSGenioAt_002 klass { get { return baseklass as CSGenioAt_002; } set { baseklass = value; } }

		[Key]
		/// <summary>Field : "" Tipo: "+" Formula:  ""</summary>
		[ShouldSerialize("T_002.ValCodt_002")]
		public string ValCodt_002 { get { return klass.ValCodt_002; } set { klass.ValCodt_002 = value; } }

		[DisplayName("Property Photo")]
		/// <summary>Field : "Property Photo" Tipo: "IJ" Formula:  ""</summary>
		[ShouldSerialize("T_002.ValPhoto")]
		[ImageThumbnailJsonConverter(75, 75)]
		public ImageModel ValPhoto { get { return new ImageModel(klass.ValPhoto) { Ticket = ValPhotoQTicket }; } set { klass.ValPhoto = value; } }
		[JsonIgnore]
		public string ValPhotoQTicket = null;

		[DisplayName("Property Title")]
		/// <summary>Field : "Property Title" Tipo: "C" Formula:  ""</summary>
		[ShouldSerialize("T_002.ValTitle")]
		public string ValTitle { get { return klass.ValTitle; } set { klass.ValTitle = value; } }

		[DisplayName("Property Price")]
		/// <summary>Field : "Property Price" Tipo: "$" Formula:  ""</summary>
		[ShouldSerialize("T_002.ValPrice")]
		[CurrencyAttribute("EUR", 2)]
		public decimal? ValPrice { get { return Convert.ToDecimal(GenFunctions.RoundQG(klass.ValPrice, 2)); } set { klass.ValPrice = Convert.ToDecimal(value); } }

		[DisplayName("ZZSTATE")]
		[ShouldSerialize("T_002.ValZzstate")]
		/// <summary>Field: "ZZSTATE", Type: "INT", Formula: ""</summary>
		public virtual int ValZzstate { get { return klass.ValZzstate; } set { klass.ValZzstate = value; } }

		public T_002(UserContext userContext, bool isEmpty = false, string[]? fieldsToSerialize = null) : base(userContext)
		{
			klass = new CSGenioAt_002(userContext.User);
			isEmptyModel = isEmpty;
			if (fieldsToSerialize != null)
				SetFieldsToSerialize(fieldsToSerialize);
		}

		public T_002(UserContext userContext, CSGenioAt_002 val, bool isEmpty = false, string[]? fieldsToSerialize = null) : base(userContext)
		{
			klass = val;
			isEmptyModel = isEmpty;
			if (fieldsToSerialize != null)
				SetFieldsToSerialize(fieldsToSerialize);
			FillRelatedAreas(val);
		}

		public void FillRelatedAreas(CSGenioAt_002 csgenioa)
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
		public static T_002 Find(string id, UserContext userCtx, string identifier = null, string[] fieldsToSerialize = null, string[] fieldsToQuery = null)
		{
			var record = Find<CSGenioAt_002>(id, userCtx, identifier, fieldsToQuery);
			return record == null ? null : new T_002(userCtx, record, false, fieldsToSerialize) { Identifier = identifier };
		}

		public static List<T_002> AllModel(UserContext userCtx, CriteriaSet args = null, string identifier = null)
		{
			return Where<CSGenioAt_002>(userCtx, false, args, numRegs: -1, identifier: identifier).RowsForViewModel<T_002>((r) => new T_002(userCtx, r));
		}

// USE /[MANUAL RMS MODEL T_002]/
	}
}
