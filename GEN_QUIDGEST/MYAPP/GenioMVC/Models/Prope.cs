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
	public class Prope : ModelBase
	{
		[JsonIgnore]
		public CSGenioAprope klass { get { return baseklass as CSGenioAprope; } set { baseklass = value; } }

		[Key]
		/// <summary>Field : "" Tipo: "+" Formula:  ""</summary>
		[ShouldSerialize("Prope.ValCodprope")]
		public string ValCodprope { get { return klass.ValCodprope; } set { klass.ValCodprope = value; } }

		[DisplayName("Property name")]
		/// <summary>Field : "Property name" Tipo: "C" Formula:  ""</summary>
		[ShouldSerialize("Prope.ValProperty_name")]
		public string ValProperty_name { get { return klass.ValProperty_name; } set { klass.ValProperty_name = value; } }

		[DisplayName("Property Price")]
		/// <summary>Field : "Property Price" Tipo: "$" Formula:  ""</summary>
		[ShouldSerialize("Prope.ValProperty_price")]
		[CurrencyAttribute("EUR", 2)]
		public decimal? ValProperty_price { get { return Convert.ToDecimal(GenFunctions.RoundQG(klass.ValProperty_price, 2)); } set { klass.ValProperty_price = Convert.ToDecimal(value); } }

		[DisplayName("")]
		/// <summary>Field : "" Tipo: "CE" Formula:  ""</summary>
		[ShouldSerialize("Prope.ValCodu_prf")]
		public string ValCodu_prf { get { return klass.ValCodu_prf; } set { klass.ValCodu_prf = value; } }

		private U_prf _u_prf;
		[DisplayName("U_prf")]
		[ShouldSerialize("U_prf")]
		public virtual U_prf U_prf
		{
			get
			{
				if (!isEmptyModel && (_u_prf == null || (!string.IsNullOrEmpty(ValCodu_prf) && (_u_prf.isEmptyModel || _u_prf.klass.QPrimaryKey != ValCodu_prf))))
					_u_prf = Models.U_prf.Find(ValCodu_prf, m_userContext, Identifier, _fieldsToSerialize);
				_u_prf ??= new Models.U_prf(m_userContext, true, _fieldsToSerialize);
				return _u_prf;
			}
			set { _u_prf = value; }
		}

		[DisplayName("ZZSTATE")]
		[ShouldSerialize("Prope.ValZzstate")]
		/// <summary>Field: "ZZSTATE", Type: "INT", Formula: ""</summary>
		public virtual int ValZzstate { get { return klass.ValZzstate; } set { klass.ValZzstate = value; } }

		public Prope(UserContext userContext, bool isEmpty = false, string[]? fieldsToSerialize = null) : base(userContext)
		{
			klass = new CSGenioAprope(userContext.User);
			isEmptyModel = isEmpty;
			if (fieldsToSerialize != null)
				SetFieldsToSerialize(fieldsToSerialize);
		}

		public Prope(UserContext userContext, CSGenioAprope val, bool isEmpty = false, string[]? fieldsToSerialize = null) : base(userContext)
		{
			klass = val;
			isEmptyModel = isEmpty;
			if (fieldsToSerialize != null)
				SetFieldsToSerialize(fieldsToSerialize);
			FillRelatedAreas(val);
		}

		public void FillRelatedAreas(CSGenioAprope csgenioa)
		{
			if (csgenioa == null)
				return;

			foreach (RequestedField Qfield in csgenioa.Fields.Values)
			{
				switch (Qfield.Area)
				{
					case "u_prf":
						_u_prf ??= new U_prf(m_userContext, true, _fieldsToSerialize);
						_u_prf.klass.insertNameValueField(Qfield.FullName, Qfield.Value);
						break;
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
		public static Prope Find(string id, UserContext userCtx, string identifier = null, string[] fieldsToSerialize = null, string[] fieldsToQuery = null)
		{
			var record = Find<CSGenioAprope>(id, userCtx, identifier, fieldsToQuery);
			return record == null ? null : new Prope(userCtx, record, false, fieldsToSerialize) { Identifier = identifier };
		}

		public static List<Prope> AllModel(UserContext userCtx, CriteriaSet args = null, string identifier = null)
		{
			return Where<CSGenioAprope>(userCtx, false, args, numRegs: -1, identifier: identifier).RowsForViewModel<Prope>((r) => new Prope(userCtx, r));
		}

// USE /[MANUAL RMS MODEL PROPE]/
	}
}
