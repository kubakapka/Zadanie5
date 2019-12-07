namespace Shape
{
    public class Circle : Shape
    {
        public Circle (double bokA)
        {
            this.BokA = bokA;
            
        }
        public double Area()
        {
            Pole = 3.14 * (BokA * BokA);
            return Pole;
        }
       
        public double Perimeter() //obwod
        {
            
            Obwod = 2 * 3.14 * BokA;
            return Obwod;
        
        }
    }
}