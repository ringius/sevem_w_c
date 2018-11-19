using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenW
{
	public class Wonder
	{
		#region Fields

		private bool A_side;
		private int currentLevel;
		private string name;
		private int noOfLevels;
		private Playcard startCard;
		private CardList levelCards;
		private CardList stashedCards;

		#endregion

		public Wonder(String name, bool A_side, int noOfLevels, Playcard startCard)
		{
			this.currentLevel = 0;
			this.name = name;
			this.A_side = A_side;
			this.noOfLevels = noOfLevels;
			this.startCard = startCard;
			this.levelCards = null;
			this.stashedCards = new CardList();
		}

		public Playcard upgrade(Playcard stashedCard)
		{
			if (this.currentLevel == this.noOfLevels)
			{
				return null;
			}

			this.stashedCards.Add(this.currentLevel, stashedCard);
			this.currentLevel++;

			Playcard result = null;
			int desiredIndex = this.currentLevel - 1;

			System.Diagnostics.Trace.Assert(
				this.levelCards.TryGetValue(desiredIndex, out result),
				string.Format("Failed to get card at {0} !", desiredIndex)
			);

			return result;
		}

		public void addLevels(CardList levelCards)
		{
			this.levelCards = levelCards;
		}

		void updatePlayer(Player p)
		{
			if (!this.startCard.updatePlayer(p)) //Need to change to updatePlayer(player, boolean:isPrivate);
				throw new Exception("TODO: Something went wrong !!!");
		}

		public override string ToString()
		{
			string res = string.Copy(this.name);
			if (this.A_side)
				res += " (A)";
			else
				res += " (B)";

			return res;
		}

		public Playcard getStartCard()
		{
			return this.startCard;
		}

		public String getFileName()
		{
			if (this.A_side)
				return this.name + "_a.png";
			else
				return this.name += "_b.png";
		}
	}
}