//Create an interface named IBike This is going to be one of the Abstract Products.
//Each distinct product of the Bike product family should have a base interface.
//In this case, all variants of Bike products (SportsBike and RegularBike) must implement this IBike interface.
//As you can see, we have created the following interface with one abstract method.
//That method will be implemented by the subclasses (SportsBike and RegularBike) of the IBike interface.

public interface IBike
{
    void GetDetails();
}
//Create an interface named ICar This is going to be one of the Abstract Products.
//Each distinct product of the Car product family should have a base interface.
//In this case, all variants of the Car products (SportsCar and RegularCar) must implement this ICar interface.
//As you can see, we have created the following interface with one abstract method, 
//which will be implemented by the subclasses of the ICar interface.
public interface ICar
{
    void GetDetails();
}

public class RegularBike: IBike
{
    public void GetDetails()
    {
        Console.WriteLine("Fetching Regular Bike Details...");
    }
}

public class SportBike: IBike
{
    public void GetDetails()
    {
        Console.WriteLine("Fetching Sports Bike Details...");
    }
}
public class RegularCar: ICar
{
    public void GetDetails()
    {
        Console.WriteLine("Fetching Regular Car Details...");
    }
}
public class Sportscar: ICar
{
    public void GetDetails()
    {
        Console.WriteLine("Fetching Sports Car Details...");
    }
}
public interface IVehicleFactory
{
    IBike CreateBike();
    ICar Createcar();
}

public class RegularVehicleFactory: IVehicleFactory
{
    public IBike CreateBike()
    {
        return new RegularBike();
    }
    public ICar Createcar()
    {
        return new RegularCar();
    }
}

public class SportsVehicleFactory : IVehicleFactory
{
    public IBike CreateBike()
    {
        return new SportBike();
    }
    public ICar Createcar()
    {
        return new Sportscar();
    }
}

class Program
{
    public static void Main()
    {
        // Fetch the Regular Bike and Car Details
        //Creating RegularVehicleFactory instance
        IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();
        //regularVehicleFactory.CreateBike() will create and return Regular Bike
        IBike regularBike = regularVehicleFactory.CreateBike();
        regularBike.GetDetails();
        //regularVehicleFactory.CreateCar() will create and return Regular Car
        ICar regularCar = regularVehicleFactory.Createcar();
        regularCar.GetDetails();
        // Fetch the Sports Bike and Car Details Created
        // Creating SportsVehicleFactory instance 
        IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();
        //sportsVehicleFactory.CreateBike() will create and return Sports Bike
        IBike sportsBike = sportsVehicleFactory.CreateBike();
        sportsBike.GetDetails();
        //sportsVehicleFactory.CreateCar() will create and return Sports Car
        ICar sportsCar = sportsVehicleFactory.Createcar();
        sportsCar.GetDetails();
        Console.ReadKey();
    }
}