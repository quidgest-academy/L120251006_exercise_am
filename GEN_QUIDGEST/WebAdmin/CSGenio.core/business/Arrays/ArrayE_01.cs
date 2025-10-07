using System.Collections.Generic;

namespace CSGenio.business
{
	/// <summary>
	/// Array E_01 (Building Type)
	/// </summary>
	public class ArrayE_01 : Array<string>
	{
		/// <summary>
		/// The instance
		/// </summary>
		private static readonly ArrayE_01 _instance = new ArrayE_01();

		/// <summary>
		/// Gets the instance.
		/// </summary>
		/// <value>
		/// The instance.
		/// </value>
		public static ArrayE_01 Instance { get => _instance; }

		/// <summary>
		/// Array code type
		/// </summary>
		public static ArrayType Type { get { return ArrayType.STRING; } }

		/// <summary>
		/// Apartment
		/// </summary>
		public const string E_EE01_1 = "EE_01";
		/// <summary>
		/// House
		/// </summary>
		public const string E_EE02_2 = "EE_02";
		/// <summary>
		/// Other
		/// </summary>
		public const string E_EE03_3 = "EE_03";

		/// <summary>
		/// Prevents a default instance of the <see cref="ArrayE_01"/> class from being created.
		/// </summary>
		private ArrayE_01() : base() {}

		/// <summary>
        /// Loads the dictionary.
        /// </summary>
        /// <returns></returns>
		protected override Dictionary<string, ArrayElement> LoadDictionary()
		{
			return new Dictionary<string, ArrayElement>()
			{
				{ E_EE01_1, new ArrayElement() { ResourceId = "APARTMENT12665", HelpId = "", Group = "" } },
				{ E_EE02_2, new ArrayElement() { ResourceId = "HOUSE01993", HelpId = "", Group = "" } },
				{ E_EE03_3, new ArrayElement() { ResourceId = "OTHER37293", HelpId = "", Group = "" } },
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
