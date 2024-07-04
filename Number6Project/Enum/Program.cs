internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("-----------------------------------");
        //Question 1
        Console.WriteLine(DayOfTheWeek.ThuHai);
        Console.WriteLine(DayOfTheWeek.ThuBa);
        Console.WriteLine(DayOfTheWeek.ThuTu);
        Console.WriteLine(DayOfTheWeek.ThuNam);
        Console.WriteLine(DayOfTheWeek.ThuSau);
        Console.WriteLine(DayOfTheWeek.ThuBay);
        Console.WriteLine(DayOfTheWeek.ChuNhat);
        //Question 2
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(EnemyState.Idle);
        Console.WriteLine(EnemyState.Patrol);
        Console.WriteLine(EnemyState.Attack);
        //Question 3
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(FlightStatus.Ascending);
        Console.WriteLine(FlightStatus.Decending);
        Console.WriteLine(FlightStatus.Stationary);
        //Question 4
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(TitleRank.Begineer);
        Console.WriteLine(TitleRank.Intermediate);
        Console.WriteLine(TitleRank.Advanced);
        //Question 5
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(PlayerMovement.Idle);
        Console.WriteLine(PlayerMovement.Walk);
        Console.WriteLine(PlayerMovement.Run);
        //Question 6
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(DayOfTheWeek2.Monday);
        Console.WriteLine(DayOfTheWeek2.Tuesday);
        Console.WriteLine(DayOfTheWeek2.Wednesday);
        Console.WriteLine(DayOfTheWeek2.Friday);
        Console.WriteLine(DayOfTheWeek2.Saturday);
        Console.WriteLine(DayOfTheWeek2.Sunday);
    }
    enum DayOfTheWeek
    {
        ThuHai,
        ThuBa,
        ThuTu,
        ThuNam,
        ThuSau,
        ThuBay,
        ChuNhat
    }

    enum EnemyState
    {
        Idle,
        Patrol,
        Attack
    }
    enum FlightStatus
    {
        Ascending,
        Decending,
        Stationary
    }
    enum TitleRank{
        Begineer,
        Intermediate,
        Advanced
    }
    enum PlayerMovement{
        Idle,
        Walk,
        Run
    }
    enum DayOfTheWeek2{
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}