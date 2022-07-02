

// A basic guide to setup Entity Framework and DB . 

/*
Installing everything

   Install Entity framework on your machine first with CMD or POWERSHELL.
   
   Type this CLI : 

   Start a Console App project . 
   In the project go to manage NuGet packages and install : Microsoft.EntityFrameworkCore.SqlServer .
                                                            Microsoft.EntityFrameworkCore.Tools     .
                                                            Microsoft.EntityFrameworkCore.Design    .
------------------------------------------------------------------------------------------------------

Setting it UP

   Create a new Class a DbContext class.( Or give it any other relavant name like for example ApplicationDbContext .)
   Let this Class inherit from DbContext and install the Microsoft.EntityFrameworkCore namespace .(By pressing CTRL DOT )
   See Class for example , in this class you also place the connectionstring. (Server name , Database name , security setting)

   In your solution create a folder to organize your Entities , inside that folder creat a new Class with properties (for example Person)
   After that go back to the DbContext and create a property called DbSet and give it a name (see example) this will create and name the table.
   And install the Entity_Framework_Setup.Entities namespace .(By pressing CTRL DOT )(Will have the project name)
   (if you keep getting green squigles onder People and Name , turn of Non Nullable ref types. , goto the Csproj file and disable Nullable,
   you can find it by double clicking the project name in solution explorer after that save the file )

   Now we will setup the Migration.
   Open the Package manager CONSOLE type : Add-Migration Initial
   This will an intial file with code that actually creates the table based on the previous steps.
   Open the Package manager CONSOLE again and type : update-database
   This will create the database for you , and fill it withe the needed table and a migration table to sees if any futere migrations took place.
   
   Finished for now and enjoy your database endevours and experiments
                              
  
 */
namespace Entity_Framework_Setup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tadaaaaa , this was the very short & simpel explanation of Entity Frame work ");
        }
    }


}
