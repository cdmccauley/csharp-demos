namespace PayrollSystem0
{
    class PieceWorker : Employee // derivative class
    {
        // declarations
        private decimal wage;
        private int pieces;

        // properties
        public decimal Wage
        {
            get => wage;
            private set => wage = value;
        }

        public int Pieces
        {
            get => pieces;
            private set => pieces = value;
        }

        // constructor
        public PieceWorker(string first, string last, string ssn, string bday, decimal pieceWage, int piecesMade) : base(first, last, ssn, bday)
        {
            Wage = pieceWage;
            Pieces = piecesMade;
        }

        // Earnings() implementation
        public override decimal Earnings()
        {
            return Wage * Pieces;
        }

        // ToString() overrride
        public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3}\n{4}: {5:C2}", "piece-worker employee", base.ToString(), "pieces produced", Pieces, "wage per piece", Wage);
        }
    }
}
