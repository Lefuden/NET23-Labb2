//Daniel Frykman, .NET23
namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ensure encoding works for squares, ask for user input.
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Hur stort ska shackbrädan vara? Ange ett heltal mellan 2 - 50.");
            
            int size;
            string board = "";

            //Take user input, with error handling by running a loop until conditions are met.
            //User input needs to be an integer and within specified range.
            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out size) && size >= 2 && size <= 50)
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("Felaktigt värde, ange ett heltal mellan 2 - 50.");
            }

            //Let user decide on shape, or leave it blank for default value.
            Console.WriteLine("Hur ska svarta rutor se ut? Tryck Enter om du vill ha en svart ruta.");
            Console.Write("> ");
            string black = Console.ReadLine();
            if (black == "")
            {
                black = "□ ";
            }

            Console.WriteLine("Hur ska vita rutor se ut? Tryck Enter om du vill ha en vit ruta.");
            Console.Write("> ");
            string white = Console.ReadLine();
            if (white == "")
            {
                white = "■ ";
            }

            //create nested for-loops to count and compare amount of output required.
            for (int y = 0; y < size; y++)
            {
                //create a row by stepping through using modulus to decide black or white square.
                for (int x = 0; x < size; x++)
                {
                    if ((x + y) % 2 == 0)
                    {
                        board += white;
                    }
                    else
                    {
                        board += black;
                    }
                }
                //add new row and loop again until finished.
                board += "\n";
            }
            //output the completed chessboard.
            Console.WriteLine(board);
        }
    }
}
//I'll keep this here for posterity. Was fun tinkering, and it works!
//for (int x = 0; x < number; x++) board += ((x + y) % 2 == 0 ? white : black);