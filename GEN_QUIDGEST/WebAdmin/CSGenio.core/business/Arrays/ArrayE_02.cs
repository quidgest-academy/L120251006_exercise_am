using System.Collections.Generic;

namespace CSGenio.business
{
	/// <summary>
	/// Array E_02 (Building Typology)
	/// </summary>
	public class ArrayE_02 : Array<string>
	{
		/// <summary>
		/// The instance
		/// </summary>
		private static readonly ArrayE_02 _instance = new ArrayE_02();

		/// <summary>
		/// Gets the instance.
		/// </summary>
		/// <value>
		/// The instance.
		/// </value>
		public static ArrayE_02 Instance { get => _instance; }

		/// <summary>
		/// Array code type
		/// </summary>
		public static ArrayType Type { get { return ArrayType.STRING; } }

		/// <summary>
		/// T0
		/// </summary>
		public const string E_EE01_1 = "EE_01";
		/// <summary>
		/// T1
		/// </summary>
		public const string E_EE02_2 = "EE_02";
		/// <summary>
		/// T3
		/// </summary>
		public const string E_EE03_3 = "EE_03";
		/// <summary>
		/// More
		/// </summary>
		public const string E_EE04_4 = "EE_04";

		/// <summary>
		/// Prevents a default instance of the <see cref="ArrayE_02"/> class from being created.
		/// </summary>
		private ArrayE_02() : base() {}

		/// <summary>
        /// Loads the dictionary.
        /// </summary>
        /// <returns></returns>
		protected override Dictionary<string, ArrayElement> LoadDictionary()
		{
			return new Dictionary<string, ArrayElement>()
			{
				{ E_EE01_1, new ArrayElement() { ResourceId = "T036607", HelpId = "", Group = "" } },
				{ E_EE02_2, new ArrayElement() { ResourceId = "T133664", HelpId = "", Group = "" } },
				{ E_EE03_3, new ArrayElement() { ResourceId = "T333958", HelpId = "", Group = "" } },
				{ E_EE04_4, new ArrayElement() { ResourceId = "MORE38452", HelpId = "", Group = "" } },
			};
		}

		/// <summary>
		/// Gets the element's description.
		/// </summary>
		/// <param name="cod">The cod.</param>
		/// <returns></returns>
		public static string CodToDescricao(string cod)
		{
			return Instance.CodToDescricaoImpl(cod);
		}

		/// <summary>
		/// Gets the elements.
		/// </summary>
		/// <returns></returns>
		public static List<string> GetElements()
		{
			return Instance.GetElementsImpl();
		}

		/// <summary>
		/// Gets the element.
		/// </summary>
		/// <param name="cod">The cod.</param>
		/// <returns></returns>
		public static ArrayElement GetElement(string cod)
		{
            return Instance.GetElementImpl(cod);
        }

		/// <summary>
		/// Gets the dictionary.
		/// </summary>
		/// <returns></returns>
		public static IDictionary<string, string> GetDictionary()
		{
			return Instance.GetDictionaryImpl();
		}

		/// <summary>
		/// Gets the help identifier.
		/// </summary>
		/// <param name="cod">The cod.</param>
		/// <returns></returns>
		public static string GetHelpId(string cod)
		{
			return Instance.GetHelpIdImpl(cod);
		}
	}
}
