namespace Zadanie1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 1', 'czynnosc 1', 'opis czynnosci pierwszej', 5, 10 ,30 , " +
                "'12/03/2014' , '12/03/2015') ");

            Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 2', 'czynnosc 2', 'opis czynnosci drugiej', 1, 1 ,21 , " +
                "'12/03/2014' , '12/03/2016') ");

            Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 3', 'czynnosc 3', 'opis czynnosci trzeciej', 4, 1 ,44 , " +
                "'12/03/2013' , '12/03/2014') ");

            Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 4', 'czynnosc 4', 'opis czynnosci czwartej', 2, 2 ,17 , " +
                "'12/03/2010' , '12/03/2012') ");

            Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 5', 'czynnosc 5', 'opis czynnosci piatej', 1, 1 ,21 , " +
                "'12/05/2014' , '12/01/2016') ");

            Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 6', 'czynnosc 6', 'opis czynnosci szóstej', 4, 3 ,2 , " +
                "'11/03/2012' , '12/03/2012') ");

            Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 7', 'czynnosc 7', 'opis czynnosci siudmej', 6, 2 ,1 , " +
                "'12/03/2014' , '12/03/2016') ");

            Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 8', 'czynnosc 8', 'opis czynnosci ósmej', 10, 5 ,99 , " +
                "'12/03/2014' , '12/03/2016') ");

            Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 9', 'czynnosc 9', 'opis czynnosci dziewi¹tej', 4, 3 ,2 , " +
                "'12/03/2014' , '12/03/2016') ");

            Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 10', 'czynnosc 10', 'opis czynnosci kolejnej :D', 2, 7 ,44 , " +
                "'10/03/2017' , '01/03/2018') ");
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 11', 'czynnosc 11', 'opis czynnosci kolejnej :D', 2, 7 ,44 , " +
                "'10/03/2017' , '01/03/2018') ");
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 12', 'czynnosc 12', 'opis czynnosci kolejnej :D', 2, 7 ,44 , " +
                "'10/03/2017' , '01/03/2018') ");
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 13', 'czynnosc 13', 'opis czynnosci kolejnej :D', 2, 7 ,44 , " +
                "'10/03/2017' , '01/03/2018') ");
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 14', 'czynnosc 14', 'opis czynnosci kolejnej :D', 2, 7 ,44 , " +
                "'10/03/2017' , '01/03/2018') ");
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 15', 'czynnosc 15', 'opis czynnosci kolejnej :D', 2, 7 ,44 , " +
                "'10/03/2017' , '01/03/2018') ");
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 16', 'czynnosc 16', 'opis czynnosci kolejnej :D', 2, 7 ,44 , " +
                "'10/03/2017' , '01/03/2018') ");
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 17', 'czynnosc 17', 'opis czynnosci kolejnej :D', 2, 7 ,44 , " +
                "'10/03/2017' , '01/03/2018') ");
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 18', 'czynnosc 18', 'opis czynnosci kolejnej :D', 2, 7 ,44 , " +
                "'10/03/2017' , '01/03/2018') ");
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 19', 'czynnosc 19', 'opis czynnosci kolejnej :D', 2, 7 ,44 , " +
                "'10/03/2017' , '01/03/2018') ");

                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 20', 'czynnosc 20', 'opis czynnosci kolejnej :D', 1, 3 ,25 , " +
                "'10/04/2017' , '01/05/2018') ");
      
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 21', 'czynnosc 21', 'opis czynnosci kolejnej :D', 1, 3 ,25 , " +
                "'10/04/2017' , '01/05/2018') ");
      
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 22', 'czynnosc 22', 'opis czynnosci kolejnej :D', 1, 3 ,25 , " +
                "'10/04/2017' , '01/05/2018') ");
      
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 23', 'czynnosc 23', 'opis czynnosci kolejnej :D', 1, 3 ,25 , " +
                "'10/04/2017' , '01/05/2018') ");
      
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 24', 'czynnosc 24', 'opis czynnosci kolejnej :D', 1, 3 ,25 , " +
                "'10/04/2017' , '01/05/2018') ");
      
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 25', 'czynnosc 25', 'opis czynnosci kolejnej :D', 1, 3 ,25 , " +
                "'10/04/2017' , '01/05/2018') ");
      
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 26', 'czynnosc 26', 'opis czynnosci kolejnej :D', 1, 3 ,25 , " +
                "'10/04/2017' , '01/05/2018') ");
      
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 27', 'czynnosc 27', 'opis czynnosci kolejnej :D', 1, 3 ,25 , " +
                "'10/04/2017' , '01/05/2018') ");
      
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 28', 'czynnosc 28', 'opis czynnosci kolejnej :D', 1, 3 ,25 , " +
                "'10/04/2017' , '01/05/2018') ");
      
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 29', 'czynnosc 29', 'opis czynnosci kolejnej :D', 1, 3 ,25 , " +
                "'10/04/2017' , '01/05/2018') ");
      
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 30', 'czynnosc 30', 'opis czynnosci kolejnej :D', 3, 6 ,50 , " +
                "'10/04/2017' , '01/05/2018') ");
                 
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 31', 'czynnosc 31', 'opis czynnosci kolejnej :D', 3, 6 ,50 , " +
                "'10/04/2017' , '01/05/2018') ");
                 
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 32', 'czynnosc 32', 'opis czynnosci kolejnej :D', 3, 6 ,50 , " +
                "'10/04/2017' , '01/05/2018') ");
                 
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 33', 'czynnosc 33', 'opis czynnosci kolejnej :D', 3, 6 ,50 , " +
                "'10/04/2017' , '01/05/2018') ");
                 
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 34', 'czynnosc 34', 'opis czynnosci kolejnej :D', 3, 6 ,50 , " +
                "'10/04/2017' , '01/05/2018') ");
                 
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 35', 'czynnosc 35', 'opis czynnosci kolejnej :D', 3, 6 ,50 , " +
                "'10/04/2017' , '01/05/2018') ");
                 
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 36', 'czynnosc 36', 'opis czynnosci kolejnej :D', 3, 6 ,50 , " +
                "'10/04/2017' , '01/05/2018') ");
                 
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 37', 'czynnosc 37', 'opis czynnosci kolejnej :D', 3, 6 ,50 , " +
                "'10/04/2017' , '01/05/2018') ");
                 
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 38', 'czynnosc 38', 'opis czynnosci kolejnej :D', 3, 6 ,50 , " +
                "'10/04/2017' , '01/05/2018') ");
                 
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 39', 'czynnosc 39', 'opis czynnosci kolejnej :D', 3, 6 ,50 , " +
                "'10/04/2017' , '01/05/2018') ");
                 
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 40', 'czynnosc 40', 'opis czynnosci kolejnej :D', 4, 9 ,75 , " +
                "'10/04/2017' , '01/05/2018') ");
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 41', 'czynnosc 41', 'opis czynnosci kolejnej :D', 4, 9 ,75 , " +
                "'10/04/2017' , '01/05/2018') ");
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 42', 'czynnosc 42', 'opis czynnosci kolejnej :D', 4, 9 ,75 , " +
                "'10/04/2017' , '01/05/2018') ");
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 43', 'czynnosc 43', 'opis czynnosci kolejnej :D', 4, 9 ,75 , " +
                "'10/04/2017' , '01/05/2018') ");
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 44', 'czynnosc 44', 'opis czynnosci kolejnej :D', 4, 9 ,75 , " +
                "'10/04/2017' , '01/05/2018') ");
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 45', 'czynnosc 45', 'opis czynnosci kolejnej :D', 4, 9 ,75 , " +
                "'10/04/2017' , '01/05/2018') ");
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 46', 'czynnosc 46', 'opis czynnosci kolejnej :D', 4, 9 ,75 , " +
                "'10/04/2017' , '01/05/2018') ");
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 47', 'czynnosc 47', 'opis czynnosci kolejnej :D', 4, 9 ,75 , " +
                "'10/04/2017' , '01/05/2018') ");
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 48', 'czynnosc 48', 'opis czynnosci kolejnej :D', 4, 9 ,75 , " +
                "'10/04/2017' , '01/05/2018') ");
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 49', 'czynnosc 49', 'opis czynnosci kolejnej :D', 4, 9 ,75 , " +
                "'10/04/2017' , '01/05/2018') ");
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 50', 'czynnosc 50', 'opis czynnosci kolejnej :D', 5, 12 ,100 , " +
                "'10/05/2017' , '09/05/2018') ");
           
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 51', 'czynnosc 51', 'opis czynnosci kolejnej :D', 5, 12 ,100 , " +
                "'10/05/2017' , '09/05/2018') ");
           
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 52', 'czynnosc 52', 'opis czynnosci kolejnej :D', 5, 12 ,100 , " +
                "'10/05/2017' , '09/05/2018') ");
           
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 53', 'czynnosc 53', 'opis czynnosci kolejnej :D', 5, 12 ,100 , " +
                "'10/05/2017' , '09/05/2018') ");
           
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 54', 'czynnosc 54', 'opis czynnosci kolejnej :D', 5, 12 ,100 , " +
                "'10/05/2017' , '09/05/2018') ");
           
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 55', 'czynnosc 55', 'opis czynnosci kolejnej :D', 5, 12 ,100 , " +
                "'10/05/2017' , '09/05/2018') ");
           
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 56', 'czynnosc 56', 'opis czynnosci kolejnej :D', 5, 12 ,100 , " +
                "'10/05/2017' , '09/05/2018') ");
           
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 57', 'czynnosc 57', 'opis czynnosci kolejnej :D', 5, 12 ,100 , " +
                "'10/05/2017' , '09/05/2018') ");
           
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 58', 'czynnosc 58', 'opis czynnosci kolejnej :D', 5, 12 ,100 , " +
                "'10/05/2017' , '09/05/2018') ");
           
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 59', 'czynnosc 59', 'opis czynnosci kolejnej :D', 5, 12 ,100 , " +
                "'10/05/2017' , '09/05/2018') ");
           
                           
                  Sql("INSERT INTO Danes (temat, czynnosc,opis, status, priorytet, procent_zakonczenia,data_rozpoczecia, data_zakonczenia) " +
                "VALUES ('temat 60', 'czynnosc 60', 'opis czynnosci kolejnej :D', 6, 12 ,100 , " +
                "'10/05/2017' , '09/05/2018') ");
           
        }
        
        public override void Down()
        {
        }
    }
}
