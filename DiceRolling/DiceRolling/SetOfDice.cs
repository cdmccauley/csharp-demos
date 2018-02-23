using System;

namespace DiceRolling
{
    class SetOfDice
    {
        // properties
        public int Quantity { get; set; }
        public int Sides { get; set; }
        private Random dieRoll;
        private int[] results;

        // constructor
        public SetOfDice(int quantity, int sides)
        {
            dieRoll = new Random();
            results = new int[((sides * quantity) + 1)];
            Quantity = quantity;
            Sides = sides;
        }

        // roll the set of dice numRolls times
        public void RollDice(int numRolls)
        {
            int rollResult;

            for (int i = 0; i < numRolls; ++i)
            {
                rollResult = 0;
                for (int j = 0; j < Quantity; ++j)
                {
                    rollResult += dieRoll.Next(1, (Sides + 1));
                }
                ++results[rollResult];
            }
        }

        // clear the stored results
        public void ClearRolls()
        {
            for (int i = 0; i < results.Length; ++i)
                results[i] = 0;
        }

        // ToString override, haven't learned about c# override yet, sorry if misused.
        public override string ToString()
        {
            string resultString = "";

            for (int i = Quantity; i < results.Length; ++i)
                resultString += (i + ": " + results[i] + "; ");
            return (resultString);
        }
    }
}
