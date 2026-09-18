namespace Task08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01 
            #region Problem1 
            //IVehicle vehicle = new Car();
            //vehicle.StartEngine();
            //vehicle.StopEngine();
            //Console.WriteLine();
            //vehicle = new Bike();
            //vehicle.StartEngine();
            //vehicle.StopEngine();
            #endregion

            #region Problem2  
            //Shape rectangle = new Rectangle(10.5, 5.5); 
            //Shape circle = new Circle(5.5);
            //rectangle.Display();
            //Console.WriteLine($"Rectangle Area = {rectangle.GetArea()}");
            //Console.WriteLine();
            //circle.Display(); 
            //Console.WriteLine($"Circle Area = {circle.GetArea()}"); 
            #endregion

            #region Problem3 
            //Product[] products =
            //{
            //    new Product { Id = 1, Name = "Laptop", Price = 30000 },
            //    new Product { Id = 2, Name = "Mouse", Price = 500 },
            //    new Product { Id = 3, Name = "Keyboard", Price = 1500 },
            //    new Product { Id = 4, Name = "Monitor", Price = 8000 }
            //};


            //Array.Sort(products);

            //foreach (Product item in products)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem4  
            //Student std01 = new Student()
            //{
            //    Id = 101,
            //    Name = "Mohamed",
            //    Grade = 'B'
            //};

            //Student std02 = new Student()
            //{
            //    Id = 104,
            //    Name = "Malak",
            //    Grade = 'C'
            //};

            //// before shallow copy 
            //Console.WriteLine("Before shallow copy");
            //Console.WriteLine("============================");
            //Console.WriteLine(std01);//Mohamed
            //Console.WriteLine(std02);//Malak
            //Console.WriteLine(std01.GetHashCode());//deferant
            //Console.WriteLine(std02.GetHashCode());//deferant
            //Console.WriteLine("============================");
            //Console.WriteLine();
            //// after shallow copy 
            //Console.WriteLine("After shallow copy");
            //std01 = std02;
            //Console.WriteLine("============================");
            //Console.WriteLine(std01);//Malak
            //Console.WriteLine(std02);//Malak
            //Console.WriteLine(std01.GetHashCode());//same
            //Console.WriteLine(std02.GetHashCode());//same
            //Console.WriteLine("============================");
            //--------------------------------------------------------------------------------
            //deep copy

            //std01 = new Student(std02);
            //Console.WriteLine(std01);//Malak
            //Console.WriteLine(std02);//Malak
            //Console.WriteLine(std01.GetHashCode());//different
            //Console.WriteLine(std02.GetHashCode());//different 

            #endregion

            #region Problem5  
            //Robot robot = new Robot();
            //robot.Walk();
            //IWalkable walkable = robot;
            //walkable.Walk(); 
            #endregion

            #region Problem6 
            //Account account = new Account();

            //account.AccountId = 1001;
            //account.AccountHolder = "Mohamed";
            //account.Balance = 5000;

            //Console.WriteLine($"Account ID: {account.AccountId}");
            //Console.WriteLine($"Account Holder: {account.AccountHolder}");
            //Console.WriteLine($"Balance: {account.Balance}"); 
            #endregion

            #endregion




            Console.ReadKey();
        }
    }
}
