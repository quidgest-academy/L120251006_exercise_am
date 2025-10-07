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
	public class T_001 : ModelBase
	{
		[JsonIgnore]
		public CSGenioAt_001 klass { get { return baseklass as CSGenioAt_001; } set { baseklass = value; } }

		[Key]
		/// <summary>Field : "" Tipo: "+" Formula:  ""</summary>
		[ShouldSerialize("T_001.ValCodt_001")]
		public string ValCodt_001 { get { return klass.ValCodt_001; } set { klass.ValCodt_001 = value; } }

		[DisplayName("Name")]
		/// <summary>Field : "Name" Tipo: "C" Formula:  ""</summary>
		[ShouldSerialize("T_001.ValName")]
		public string ValName { get { return klass.ValName; } set { klass.ValName = value; } }

		[DisplayName("Email")]
		/// <summary>Field : "Email" Tipo: "C" Formula:  ""</summary>
		[ShouldSerialize("T_001.ValEmail")]
		public string ValEmail { get { return klass.ValEmail; } set { klass.ValEmail = value; } }

		[DisplayName("Date of Birth")]
		/// <summary>Field : "Date of Birth" Tipo: "D" Formula:  ""</summary>
		[ShouldSerialize("T_001.ValDobirth")]
		[DataType(DataType.Date)]
		[DateAttribute("D")]
		public DateTime? ValDobirth { get { return klass.ValDobirth; } set { klass.ValDobirth = value ?? DateTime.MinValue; } }

		[DisplayName("Profile Photo")]
		/// <summary>Field : "Profile Photo" Tipo: "IJ" Formula:  ""</summary>
		[ShouldSerialize("T_001.ValPhoto")]
		[ImageThumbnailJsonConverter(75, 75)]
		public ImageModel ValPhoto { get { return new ImageModel(klass.ValPhoto) { Ticket = ValPhotoQTicket }; } set { klass.ValPhoto = value; } }
		[JsonIgnore]
		public string ValPhotoQTicket = null;

		[DisplayName("Telephone")]
		/// <summary>Field : "Telephone" Tipo: "N" Formula:  ""</summary>
		[ShouldSerialize("T_001.ValTel")]
		[NumericAttribute(0)]
		public decimal? ValTel { get { return Convert.ToDecimal(GenFunctions.RoundQG(klass.ValTel, 0)); } set { klass.ValTel = Convert.ToDecimal(value); } }

		[DisplayName("Country of Origin")]
		/// <summary>Field : "Country of Origin" Tipo: "CE" Formula:  ""</summary>
		[ShouldSerialize("T_001.ValF_006")]
		public string ValF_006 { get { return klass.ValF_006; } set { klass.ValF_006 = value; } }

		private At_01 _at_01;
		[DisplayName("At_01")]
		[ShouldSerialize("At_01")]
		public virtual At_01 At_01
		{
			get
			{
				if (!isEmptyModel && (_at_01 == null || (!string.IsNullOrEmpty(ValF_006) && (_at_01.isEmptyModel || _at_01.klass.QPrimaryKey != ValF_006))))
					_at_01 = Models.At_01.Find(ValF_006, m_userContext, Identifier, _fieldsToSerialize);
				_at_01 ??= new Models.At_01(m_userContext, true, _fieldsToSerialize);
				return _at_01;
			}
			set { _at_01 = value; }
		}

		[DisplayName("Country of Residence")]
		/// <summary>Field : "Country of Residence" Tipo: "CE" Formula:  ""</summary>
		[ShouldSerialize("T_001.ValF_007")]
		public string ValF_007 { get { return klass.ValF_007; } set { klass.ValF_007 = value; } }

		private At_02 _at_02;
		[DisplayName("At_02")]
		[ShouldSerialize("At_02")]
		public virtual At_02 At_02
		{
			get
			{
				if (!isEmptyModel && (_at_02 == null || (!string.IsNullOrEmpty(ValF_007) && (_at_02.isEmptyModel || _at_02.klass.QPrimaryKey != ValF_007))))
					_at_02 = Models.At_02.Find(ValF_007, m_userContext, Identifier, _fieldsToSerialize);
				_at_02 ??= new Models.At_02(m_userContext, true, _fieldsToSerialize);
				return _at_02;
			}
			set { _at_02 = value; }
		}

		[DisplayName("ZZSTATE")]
		[ShouldSerialize("T_001.ValZzstate")]
		/// <summary>Field: "ZZSTATE", Type: "INT", Formula: ""</summary>
		public virtual int ValZzstate { get { return klass.ValZzstate; } set { klass.ValZzstate = value; } }

		public T_001(UserContext userContext, bool isEmpty = false, string[]? fieldsToSerialize = null) : base(userContext)
		{
			klass = new CSGenioAt_001(userContext.User);
			isEmptyModel = isEmpty;
			if (fieldsToSerialize != null)
				SetFieldsToSerialize(fieldsToSerialize);
		}

		public T_001(UserContext userContext, CSGenioAt_001 val, bool isEmpty = false, string[]? fieldsToSerialize = null) : base(userContext)
		{
			klass = val;
			isEmptyModel = isEmpty;
			if (fieldsToSerialize != null)
				SetFieldsToSerialize(fieldsToSerialize);
			FillRelatedAreas(val);
		}

		public void FillRelatedAreas(CSGenioAt_001 csgenioa)
		{
			if (csgenioa == null)
				return;

			foreach (RequestedField Qfield in csgenioa.Fields.Values)
			{
				switch (Qfield.Area)
				{
					case "at_01":
						_at_01 ??= new At_01(m_userContext, true, _fieldsToSerialize);
						_at_01.klass.insertNameValueField(Qfield.FullName, Qfield.Value);
						break;
					case "at_02":
						_at_02 ??= new At_02(m_userContext, true, _fieldsToSerialize);
						_at_02.klass.insertNameValueField(Qfield.FullName, Qfield.Value);
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
		public static T_001 Find(string id, UserContext userCtx, string identifier = null, string[] fieldsToSerialize = null, string[] fieldsToQuery = null)
		{
			var record = Find<CSGenioAt_001>(id, userCtx, identifier, fieldsToQuery);
			return record == null ? null : new T_001(userCtx, record, false, fieldsToSerialize) { Identifier = identifier };
		}

		public static List<T_001> AllModel(UserContext userCtx, CriteriaSet args = null, string identifier = null)
		{
			return Where<CSGenioAt_001>(userCtx, false, args, numRegs: -1, identifier: identifier).RowsForViewModel<T_001>((r) => new T_001(userCtx, r));
		}

// USE /[MANUAL RMS MODEL T_001]/
	}
}
