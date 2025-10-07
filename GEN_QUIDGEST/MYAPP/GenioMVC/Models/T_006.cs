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
	public class T_006 : ModelBase
	{
		[JsonIgnore]
		public CSGenioAt_006 klass { get { return baseklass as CSGenioAt_006; } set { baseklass = value; } }

		[Key]
		/// <summary>Field : "" Tipo: "+" Formula:  ""</summary>
		[ShouldSerialize("T_006.ValCodt_006")]
		public string ValCodt_006 { get { return klass.ValCodt_006; } set { klass.ValCodt_006 = value; } }

		[DisplayName("Photo")]
		/// <summary>Field : "Photo" Tipo: "IJ" Formula:  ""</summary>
		[ShouldSerialize("T_006.ValPhoto")]
		[ImageThumbnailJsonConverter(75, 75)]
		public ImageModel ValPhoto { get { return new ImageModel(klass.ValPhoto) { Ticket = ValPhotoQTicket }; } set { klass.ValPhoto = value; } }
		[JsonIgnore]
		public string ValPhotoQTicket = null;

		[DisplayName("Description")]
		/// <summary>Field : "Description" Tipo: "C" Formula:  ""</summary>
		[ShouldSerialize("T_006.ValDescription")]
		public string ValDescription { get { return klass.ValDescription; } set { klass.ValDescription = value; } }

		[DisplayName("")]
		/// <summary>Field : "" Tipo: "CE" Formula:  ""</summary>
		[ShouldSerialize("T_006.ValCodt_002")]
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
		[ShouldSerialize("T_006.ValZzstate")]
		/// <summary>Field: "ZZSTATE", Type: "INT", Formula: ""</summary>
		public virtual int ValZzstate { get { return klass.ValZzstate; } set { klass.ValZzstate = value; } }

		public T_006(UserContext userContext, bool isEmpty = false, string[]? fieldsToSerialize = null) : base(userContext)
		{
			klass = new CSGenioAt_006(userContext.User);
			isEmptyModel = isEmpty;
			if (fieldsToSerialize != null)
				SetFieldsToSerialize(fieldsToSerialize);
		}

		public T_006(UserContext userContext, CSGenioAt_006 val, bool isEmpty = false, string[]? fieldsToSerialize = null) : base(userContext)
		{
			klass = val;
			isEmptyModel = isEmpty;
			if (fieldsToSerialize != null)
				SetFieldsToSerialize(fieldsToSerialize);
			FillRelatedAreas(val);
		}

		public void FillRelatedAreas(CSGenioAt_006 csgenioa)
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
		public static T_006 Find(string id, UserContext userCtx, string identifier = null, string[] fieldsToSerialize = null, string[] fieldsToQuery = null)
		{
			var record = Find<CSGenioAt_006>(id, userCtx, identifier, fieldsToQuery);
			return record == null ? null : new T_006(userCtx, record, false, fieldsToSerialize) { Identifier = identifier };
		}

		public static List<T_006> AllModel(UserContext userCtx, CriteriaSet args = null, string identifier = null)
		{
			return Where<CSGenioAt_006>(userCtx, false, args, numRegs: -1, identifier: identifier).RowsForViewModel<T_006>((r) => new T_006(userCtx, r));
		}

// USE /[MANUAL RMS MODEL T_006]/
	}
}
