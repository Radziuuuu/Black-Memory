using System.Drawing;
public static class Logic
{
    private static Dictionary<int, string> board =  new Dictionary<int, string>();
    public static int points
    {
        get
        {
            return points;
        }
        set
        {
            points = value;
            if (points == maxPoints)
            {
                EndGame();
            }
        }
    }

    private static readonly int maxPoints = 80;

    private static void EndGame()
    {
        
    }

    public static void ResetGame()
    {
        
    }
}