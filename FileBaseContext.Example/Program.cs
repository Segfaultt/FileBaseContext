using System.Globalization;

using Microsoft.EntityFrameworkCore;


using FileDb;


internal class Program
{

    private static void Main()
    {
          try
        {

            DbFileSystem db = new DbFileSystem();

            Console.WriteLine("Initializing database...");
            DbFileSystem.InitDb(db);

            Console.WriteLine("Loading contents...");
            db.Contents.Load();
            db.Users.Load();

            User? user = db.Users.FirstOrDefault();
            if(user == null)
            {
                Console.WriteLine("No user found in the database.");
                return;
            }

            Console.WriteLine($"User found: {user.Name}");
            user.Name = "changed name - " + DateTime.Now.ToString(CultureInfo.InvariantCulture);
            db.SaveChanges();
            Console.WriteLine("User name updated successfully.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        catch(Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        
    }

 


    //private static void TestDbMockFileSystem()
    //{
    //    try
    //    {
    //        MockFileSystem fileSystem = new();
    //        DbTestContext db = new(fileSystem);

    //        Console.WriteLine("Initializing database...");
    //        DbTestContext.InitDb(db);

    //        Console.WriteLine("Loading contents...");
    //        db.Contents.Load();
    //        db.Users.Load();

    //        User? user = db.Users.FirstOrDefault();
    //        if(user == null)
    //        {
    //            Console.WriteLine("No user found in the database.");
    //            return;
    //        }

    //        Console.WriteLine($"User found: {user.Name}");
    //        user.Name = "changed name - " + DateTime.Now.ToString(CultureInfo.InvariantCulture);
    //        db.SaveChanges();
    //        Console.WriteLine("User name updated successfully.");

    //        Console.WriteLine("Press any key to exit...");
    //        Console.ReadKey();
    //    }
    //    catch(Exception ex)
    //    {
    //        Console.WriteLine($"An error occurred: {ex.Message}");
    //    }
    //}
}

