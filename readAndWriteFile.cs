internal class Program

  
  static void Main(string[] args)
  {
    //Input
    Console.WriteLine("Enter Centimeter: ");
    input Centimeter = Convert.ToDouble(Console.ReadLine());
    
    //Function & //Output
    
    double Miles = inputCentimeter / 160980;
    Console.WriteLine("Miles " + miles);
    
    double Inches = inputCentimeter / 2.54;
    Console.WriteLine("Inches "+ inches);
    
    double Feet = inputCentimeter / 30.48;
    Console.WriteLine("Feet " + ft);
    
    double Millimiter = inputCentimeter / 10;
    Console.WriteLine("Millimiter " + mm);
    
    double Killometer = inputCentimeter / 100000;
    Console.WriteLine("Killometer " + km);
         
    }
  }
}
