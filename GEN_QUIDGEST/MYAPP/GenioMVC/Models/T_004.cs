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
	public class T_004 : ModelBase
	{
		[JsonIgnore]
		public CSGenioAt_004 klass { get { return baseklass as CSGenioAt_004; } set { baseklass = value; } }

		[Key]
		/// <summary>Field : "" Tipo: "+" Formula:  ""</summary>
		[ShouldSerialize("T_004.ValCodt_004")]
		public string ValCodt_004 { get { return klass.ValCodt_004; } set { klass.ValCodt_004 = value; } }

		[DisplayName("City")]
		/// <summary>Field : "City" Tipo: "C" Formula:  ""</summary>
		[ShouldSerialize("T_004.ValCity")]
		public string ValCity { get { return klass.ValCity; } set { klass.ValCity = value; } }

		[DisplayName("Country")]
		/// <summary>Field : "Country" Tipo: "CE" Formula:  ""</summary>
		[ShouldSerialize("T_004.ValCodt_003")]
		public string ValCodt_003 { get { return klass.ValCodt_003; } set { klass.ValCodt_003 = value; } }

		private T_003 _t_003;
		[DisplayName("T_003")]
		[ShouldSerialize("T_003")]
		public virtual T_003 T_003
		{
			get
			{
				if (!isEmptyModel && (_t_003 == null || (!string.IsNullOrEmpty(ValCodt_003) && (_t_003.isEmptyModel || _t_003.klass.QPrimaryKey != ValCodt_003))))
					_t_003 = Models.T_003.Find(ValCodt_003, m_userContext, Identifier, _fieldsToSerialize);
				_t_003 ??= new Models.T_003(m_userContext, true, _fieldsToSerialize);
				return _t_003;
			}
			set { _t_003 = value; }
		}

		[DisplayName("ZZSTATE")]
		[ShouldSerialize("T_004.ValZzstate")]
		/// <summary>Field: "ZZSTATE", Type: "INT", Formula: ""</summary>
		public virtual int ValZzstate { get { return klass.ValZzstate; } set { klass.ValZzstate = value; } }

		public T_004(UserContext userContext, bool isEmpty = false, string[]? fieldsToSerialize = null) : base(userContext)
		{
			klass = new CSGenioAt_004(userContext.User);
			isEmptyModel = isEmpty;
			if (fieldsToSerialize != null)
				SetFieldsToSerialize(fieldsToSerialize);
		}

		public T_004(UserContext userContext, CSGenioAt_004 val, bool isEmpty = false, string[]? fieldsToSerialize = null) : base(userContext)
		{
			klass = val;
			isEmptyModel = isEmpty;
			if (fieldsToSerialize != null)
				SetFieldsToSerialize(fieldsToSerialize);
			FillRelatedAreas(val);
		}

		public void FillRelatedAreas(CSGenioAt_004 csgenioa)
		{
			if (csgenioa == null)
				return;

			foreach (RequestedField Qfield in csgenioa.Fields.Values)
			{
				switch (Qfield.Area)
				{
					case "t_003":
						_t_003 ??= new T_003(m_userContext, true, _fieldsToSerialize);
						_t_003.klass.insertNameValueField(Qfield.FullName, Qfield.Value);
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
		public static T_004 Find(string id, UserContext userCtx, string identifier = null, string[] fieldsToSerialize = null, string[] fieldsToQuery = null)
		{
			var record = Find<CSGenioAt_004>(id, userCtx, identifier, fieldsToQuery);
			return record == null ? null : new T_004(userCtx, record, false, fieldsToSerialize) { Identifier = identifier };
		}

		public static List<T_004> AllModel(UserContext userCtx, CriteriaSet args = null, string identifier = null)
		{
			return Where<CSGenioAt_004>(userCtx, false, args, numRegs: -1, identifier: identifier).RowsForViewModel<T_004>((r) => new T_004(userCtx, r));
		}

// USE /[MANUAL RMS MODEL T_004]/
	}
}
