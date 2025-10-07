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
	public class T_005 : ModelBase
	{
		[JsonIgnore]
		public CSGenioAt_005 klass { get { return baseklass as CSGenioAt_005; } set { baseklass = value; } }

		[Key]
		/// <summary>Field : "" Tipo: "+" Formula:  ""</summary>
		[ShouldSerialize("T_005.ValCodt_005")]
		public string ValCodt_005 { get { return klass.ValCodt_005; } set { klass.ValCodt_005 = value; } }

		[DisplayName("Date")]
		/// <summary>Field : "Date" Tipo: "D" Formula:  ""</summary>
		[ShouldSerialize("T_005.ValDatre")]
		[DataType(DataType.Date)]
		[DateAttribute("D")]
		public DateTime? ValDatre { get { return klass.ValDatre; } set { klass.ValDatre = value ?? DateTime.MinValue; } }

		[DisplayName("Client Name")]
		/// <summary>Field : "Client Name" Tipo: "C" Formula:  ""</summary>
		[ShouldSerialize("T_005.ValClientname")]
		public string ValClientname { get { return klass.ValClientname; } set { klass.ValClientname = value; } }

		[DisplayName("Email Contact")]
		/// <summary>Field : "Email Contact" Tipo: "C" Formula:  ""</summary>
		[ShouldSerialize("T_005.ValEmail")]
		public string ValEmail { get { return klass.ValEmail; } set { klass.ValEmail = value; } }

		[DisplayName("Phone Contact")]
		/// <summary>Field : "Phone Contact" Tipo: "C" Formula:  ""</summary>
		[ShouldSerialize("T_005.ValPhone")]
		public string ValPhone { get { return klass.ValPhone; } set { klass.ValPhone = value; } }

		[DisplayName("Description")]
		/// <summary>Field : "Description" Tipo: "C" Formula:  ""</summary>
		[ShouldSerialize("T_005.ValDescription")]
		public string ValDescription { get { return klass.ValDescription; } set { klass.ValDescription = value; } }

		[DisplayName("")]
		/// <summary>Field : "" Tipo: "CE" Formula:  ""</summary>
		[ShouldSerialize("T_005.ValCodt_002")]
		public string ValCodt_002 { get { return klass.ValCodt_002; } set { klass.ValCodt_002 = value; } }

		private T_002 _t_002;
		[DisplayName("T_002")]
		[ShouldSerialize("T_002")]
		public virtual T_002 T_002
		{
			get
			{
				if (!isEmptyModel && (_t_002 == null || (!string.IsNullOrEmpty(ValCodt_002) && (_t_002.isEmptyModel || _t_002.klass.QPrimaryKey != ValCodt_002))))
					_t_002 = Models.T_002.Find(ValCodt_002, m_userContext, Identifier, _fieldsToSerialize);
				_t_002 ??= new Models.T_002(m_userContext, true, _fieldsToSerialize);
				return _t_002;
			}
			set { _t_002 = value; }
		}

		[DisplayName("ZZSTATE")]
		[ShouldSerialize("T_005.ValZzstate")]
		/// <summary>Field: "ZZSTATE", Type: "INT", Formula: ""</summary>
		public virtual int ValZzstate { get { return klass.ValZzstate; } set { klass.ValZzstate = value; } }

		public T_005(UserContext userContext, bool isEmpty = false, string[]? fieldsToSerialize = null) : base(userContext)
		{
			klass = new CSGenioAt_005(userContext.User);
			isEmptyModel = isEmpty;
			if (fieldsToSerialize != null)
				SetFieldsToSerialize(fieldsToSerialize);
		}

		public T_005(UserContext userContext, CSGenioAt_005 val, bool isEmpty = false, string[]? fieldsToSerialize = null) : base(userContext)
		{
			klass = val;
			isEmptyModel = isEmpty;
			if (fieldsToSerialize != null)
				SetFieldsToSerialize(fieldsToSerialize);
			FillRelatedAreas(val);
		}

		public void FillRelatedAreas(CSGenioAt_005 csgenioa)
		{
			if (csgenioa == null)
				return;

			foreach (RequestedField Qfield in csgenioa.Fields.Values)
			{
				switch (Qfield.Area)
				{
					case "t_002":
						_t_002 ??= new T_002(m_userContext, true, _fieldsToSerialize);
						_t_002.klass.insertNameValueField(Qfield.FullName, Qfield.Value);
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
		public static T_005 Find(string id, UserContext userCtx, string identifier = null, string[] fieldsToSerialize = null, string[] fieldsToQuery = null)
		{
			var record = Find<CSGenioAt_005>(id, userCtx, identifier, fieldsToQuery);
			return record == null ? null : new T_005(userCtx, record, false, fieldsToSerialize) { Identifier = identifier };
		}

		public static List<T_005> AllModel(UserContext userCtx, CriteriaSet args = null, string identifier = null)
		{
			return Where<CSGenioAt_005>(userCtx, false, args, numRegs: -1, identifier: identifier).RowsForViewModel<T_005>((r) => new T_005(userCtx, r));
		}

// USE /[MANUAL RMS MODEL T_005]/
	}
}
