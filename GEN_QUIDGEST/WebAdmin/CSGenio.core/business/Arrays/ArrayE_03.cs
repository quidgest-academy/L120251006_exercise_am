using System.Collections.Generic;

namespace CSGenio.business
{
	/// <summary>
	/// Array E_03 (Sold)
	/// </summary>
	public class ArrayE_03 : Array<int>
	{
		/// <summary>
		/// The instance
		/// </summary>
		private static readonly ArrayE_03 _instance = new ArrayE_03();

		/// <summary>
		/// Gets the instance.
		/// </summary>
		/// <value>
		/// The instance.
		/// </value>
		public static ArrayE_03 Instance { get => _instance; }

		/// <summary>
		/// Array code type
		/// </summary>
		public static ArrayType Type { get { return ArrayType.LOGICAL; } }

		/// <summary>
		/// 
		/// </summary>
		public const int E_1_1 = 1;

		/// <summary>
		/// Prevents a default instance of the <see cref="ArrayE_03"/> class from being created.
		/// </summary>
		private ArrayE_03() : base() {}

		/// <summary>
        /// Loads the dictionary.
        /// </summary>
        /// <returns></returns>
		protected override Dictionary<int, ArrayElement> LoadDictionary()
		{
			return new Dictionary<int, ArrayElement>()
			{
				{ E_1_1, new ArrayElement() { ResourceId = "", HelpId = "", Group = "" } },
			};
		}

		/// <summary>
		/// Gets the element's description.
		/// </summary>
		/// <param name="cod">The cod.</param>
		/// <returns></returns>
		public static string CodToDescricao(int cod)
		{
			return Instance.CodToDescricaoImpl(cod);
		}

		/// <summary>
		/// Gets the elements.
		/// </summary>
		/// <returns></returns>
		public static List<int> GetElements()
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
            return Instance.GetElementImpl(int.Parse(cod));
        }

		/// <summary>
		/// Gets the dictionary.
		/// </summary>
		/// <returns></returns>
		public static IDictionary<int, string> GetDictionary()
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
			return Instance.GetHelpIdImpl(int.Parse(cod));
		}
	}
}
