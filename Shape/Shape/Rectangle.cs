namespace Shape
{
    public class Rectangle : Shape
    {
        private double _bokB;

        public double BokB
        {
            get => _bokB;
            set => _bokB = value;
        }

        public Rectangle (double bokA, double bokB)
        {
            this.BokA = bokA;
            this.BokB = bokB;
            
        }
        public double Area()
        {
            Pole = BokA * BokB;
            return Pole;
        }
        
        
        public double Perimeter() //obwod
        {
            
            Obwod = 2 * BokA + 2 * BokB;
            return Obwod;
        
        }
    }
}