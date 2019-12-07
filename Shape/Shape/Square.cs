namespace Shape
{
    public class Square : Shape
    {
        public Square (double bokA)
        {
            this.BokA = bokA;
            
        }
        public double Area()
        {
            Pole = BokA * BokA;
            return Pole;
        }
        
        public double Perimeter() //obwod
        {
            
            Obwod = 4 * BokA;
            return Obwod;
        
        }
        
        
    }
    
}