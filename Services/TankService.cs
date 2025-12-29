using Tanks.Models;

namespace Tanks.Services;

public class TankService
{
    //Each quote added will be given available ID
    static int availableId = 3;

    //temporary database --cache
    static List<Tank> TanksDB;

    //this class must not be instatiated anymore --- "Singleton"
    static TankService()
    {
        //Populate the database with initial data
        TanksDB = new List<Tank>()
        {
            new Tank{
                Id = 0,
                Name = "RT1",
                Product = "Raw Milk",
                BF = 4.01,
                TS = 13.89
            },
            new Tank{
                Id = 1,
                Name = "PT1",
                Product = "Pasturized Cream",
                BF = 43.31,
                TS = 48.98
            },
            new Tank{
                Id = 2,
                Name = "HH01",
                Product = "Half and Half",
                BF = 10.9,
                TS = 19.76
            }
        };
    }
    //Gets all the quotes
    public static List<Tank> GetAll() => TanksDB;
}