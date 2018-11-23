using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Script;
//using System.Web.Script.Serialization;

namespace SevenWonder.Models
{
    public class Playcard
    {
    
        public enum CardType { RawMaterial, Goods, CivilianStructure, ScienceStructure, CommercialStructure, Wonder, MilitaryStructure, Guild };

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public CardType Type { get; set; }
        
        public Playcard()
        {
        }


        public Playcard(int Id, string Name, int Age, CardType Type)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.Type = Type;   
        }

        public override string ToString()
        {
            string res = "id: " + Id + " age: " + Age + " Name: " + Name;
            return res;
        }

        /*
        static public Playcard ReadTest()
        {
            string test_string = @"{""Id"" : 50, ""Name"" : ""Lumber Yard"", ""Age"" : 1}"; // , ""type"" : ""RawMaterial""}";

            Playcard card = new JavaScriptSerializer().Deserialize<Playcard> (test_string);
            Console.WriteLine(card.ToString());

            return new Playcard(1, "test", 1);
        }
        */
        /// <summary>
        /// TODO: IMPLEMENT
        /// </summary>
        /// <param name="p"></param>
        /*
		internal bool UpdatePlayer(Player p)
		{
			/// Should return false is something goes wrong so that the caller can throw an exception
			/// (as per original design)
			return true;
		}
        */
    }
}
