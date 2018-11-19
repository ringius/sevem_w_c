using System;


namespace SevenW
{
    public class Player
    {
        private string name;
        private Player eastPlayer;
        private Player westPlayer;
        //Wonder wonder;
        int balance;
        //Cardlist ownedCards;

        public Player(string n) { name = n; }

        public string Name { get => name; set => name = value; }
        public Player EastPlayer { get => eastPlayer; set => eastPlayer = value; }
        public Player WestPlayer { get => westPlayer; set => westPlayer = value; }
        override public string ToString()
        {
            return name;
        }
    }
}
