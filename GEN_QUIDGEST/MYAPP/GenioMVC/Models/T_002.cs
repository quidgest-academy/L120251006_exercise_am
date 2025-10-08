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

		[DisplayName("")]
		/// <summary>Field : "" Tipo: "CE" Formula:  ""</summary>
		[ShouldSerialize("T_002.ValCodt_001")]
		public string ValCodt_001 { get { return klass.ValCodt_001; } set { klass.ValCodt_001 = value; } }

		private T_001 _t_001;
		[DisplayName("T_001")]
		[ShouldSerialize("T_001")]
		public virtual T_001 T_001
		{
			get
			{
				if (!isEmptyModel && (_t_001 == null || (!string.IsNullOrEmpty(ValCodt_001) && (_t_001.isEmptyModel || _t_001.klass.QPrimaryKey != ValCodt_001))))
					_t_001 = Models.T_001.Find(ValCodt_001, m_userContext, Identifier, _fieldsToSerialize);
				_t_001 ??= new Models.T_001(m_userContext, true, _fieldsToSerialize);
				return _t_001;
			}
			set { _t_001 = value; }
		}

		[DisplayName("")]
		/// <summary>Field : "" Tipo: "CE" Formula:  ""</summary>
		[ShouldSerialize("T_002.ValCodt_004")]
		public string ValCodt_004 { get { return klass.ValCodt_004; } set { klass.ValCodt_004 = value; } }

		private T_004 _t_004;
		[DisplayName("T_004")]
		[ShouldSerialize("T_004")]
		public virtual T_004 T_004
		{
			get
			{
				if (!isEmptyModel && (_t_004 == null || (!string.IsNullOrEmpty(ValCodt_004) && (_t_004.isEmptyModel || _t_004.klass.QPrimaryKey != ValCodt_004))))
					_t_004 = Models.T_004.Find(ValCodt_004, m_userContext, Identifier, _fieldsToSerialize);
				_t_004 ??= new Models.T_004(m_userContext, true, _fieldsToSerialize);
				return _t_004;
			}
			set { _t_004 = value; }
		}

		[DisplayName("Size")]
		/// <summary>Field : "Size" Tipo: "N" Formula:  ""</summary>
		[ShouldSerialize("T_002.ValSize")]
		[NumericAttribute(3)]
		public decimal? ValSize { get { return Convert.ToDecimal(GenFunctions.RoundQG(klass.ValSize, 3)); } set { klass.ValSize = Convert.ToDecimal(value); } }

		[DisplayName("Bathroums Number")]
		/// <summary>Field : "Bathroums Number" Tipo: "N" Formula:  ""</summary>
		[ShouldSerialize("T_002.ValBathnumber")]
		[NumericAttribute(0)]
		public decimal? ValBathnumber { get { return Convert.ToDecimal(GenFunctions.RoundQG(klass.ValBathnumber, 0)); } set { klass.ValBathnumber = Convert.ToDecimal(value); } }

		[DisplayName("Year Built")]
		/// <summary>Field : "Year Built" Tipo: "N" Formula:  ""</summary>
		[ShouldSerialize("T_002.ValYearbuilt")]
		[NumericAttribute(0)]
		public decimal? ValYearbuilt { get { return Convert.ToDecimal(GenFunctions.RoundQG(klass.ValYearbuilt, 0)); } set { klass.ValYearbuilt = Convert.ToDecimal(value); } }

		[DisplayName("Building Type")]
		/// <summary>Field : "Building Type" Tipo: "AC" Formula:  ""</summary>
		[ShouldSerialize("T_002.ValType")]
		[DataArray("E_01", GenioMVC.Helpers.ArrayType.Character)]
		public string ValType { get { return klass.ValType; } set { klass.ValType = value; } }
		[JsonIgnore]
		public SelectList ArrayValtype { get { return new SelectList(CSGenio.business.ArrayE_01.GetDictionary(), "Key", "Value", ValType); } set { ValType = value.SelectedValue as string; } }

		[DisplayName("Building Typology")]
		/// <summary>Field : "Building Typology" Tipo: "AC" Formula:  ""</summary>
		[ShouldSerialize("T_002.ValTypology")]
		[DataArray("E_02", GenioMVC.Helpers.ArrayType.Character)]
		public string ValTypology { get { return klass.ValTypology; } set { klass.ValTypology = value; } }
		[JsonIgnore]
		public SelectList ArrayValtypology { get { return new SelectList(CSGenio.business.ArrayE_02.GetDictionary(), "Key", "Value", ValTypology); } set { ValTypology = value.SelectedValue as string; } }

		[DisplayName("Property Order")]
		/// <summary>Field : "Property Order" Tipo: "N" Formula: DG "(1)"</summary>
		[ShouldSerialize("T_002.ValOrder")]
		[NumericAttribute(0)]
		public decimal? ValOrder { get { return Convert.ToDecimal(GenFunctions.RoundQG(klass.ValOrder, 0)); } set { klass.ValOrder = Convert.ToDecimal(value); } }

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
					case "t_001":
						_t_001 ??= new T_001(m_userContext, true, _fieldsToSerialize);
						_t_001.klass.insertNameValueField(Qfield.FullName, Qfield.Value);
						break;
					case "t_004":
						_t_004 ??= new T_004(m_userContext, true, _fieldsToSerialize);
						_t_004.klass.insertNameValueField(Qfield.FullName, Qfield.Value);
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
