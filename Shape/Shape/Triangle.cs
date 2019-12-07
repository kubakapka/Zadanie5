namespace Shape
{
    public class Triangle : Shape
    {
        private double _bokB;
        private double _bokC;
        

        public double BokB
        {
            get => _bokB;
            set => _bokB = value;
        }

        public double BokC
        {
            get => _bokC;
            set => _bokC = value;
        }
        public Triangle (double bokA, double bokB, double bokC)
        {
            this.BokA = bokA;
            this.BokB = bokB;
            this.BokC = bokC;

        }

        public double Area()
        {
            Pole = (BokA + BokB + BokC) /2;
            return Pole;
        }
        
        
        public double Perimeter() //obwod
        {
            
            Obwod = BokA + BokB + BokC;
            return Obwod;
        
        }
    }
}