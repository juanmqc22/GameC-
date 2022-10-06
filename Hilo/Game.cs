using Unit02.Game;

/// This part make the code funtion. We use the others methods that we created to play this game. 
namespace Unit02
{

    class Program
    {

        static int Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
            return 0;
        }
    }
}
