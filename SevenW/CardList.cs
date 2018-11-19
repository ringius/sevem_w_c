using System.Collections.Generic;
using System.Linq;

namespace SevenW
{
	public sealed class CardList : Dictionary<int, Playcard>
	{
		public override string ToString()
		{
			if (this.Count() == 0)
			{
				return "[]";
			}

			string res = "[";
			Enumerator iter = this.GetEnumerator();
			while (iter.MoveNext())
			{
				res += iter.Current.Value.ToString() + ",";
			}
						
			string r = res.Substring(0, (res.Length - 1));
			r += "]";
			return r;
		}
	}
}
