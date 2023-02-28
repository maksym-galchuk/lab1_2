using System.Reflection.Metadata.Ecma335;
using Rectangle_lib;

namespace Program;

class Program {
    public static void Main(String[] args) {
        // Choose the task you want to run (1 or 2) or -1 to exit the program.
        
        
    }

    public static void MainTask() {
        while (true) {
            Console.WriteLine("Enter the coordinates in the following format: x1, y1, x2, y2. To end the program, enter 'Stop'.");
            string? rawCoordinates = Console.ReadLine();
            
            if (rawCoordinates == null) {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }
            if (rawCoordinates.ToLower() == "stop") {
                Console.WriteLine("Program ended.");
                break;
            }
            
            string[] coordinates = rawCoordinates.Split(',');
            if (coordinates.Length != 4) {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }
            
            double x1, y1, x2, y2;
            try {
                x1 = double.Parse(coordinates[0]);
                y1 = double.Parse(coordinates[1]);
                x2 = double.Parse(coordinates[2]);
                y2 = double.Parse(coordinates[3]);
            } catch (FormatException) {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }
            
            Rectangle r1 = new Rectangle(x1, y1, x2, y2);
            
            Console.WriteLine($"Coordinates: {r1.ToString()}");
            if (r1.IsRectangle()) {
                Console.WriteLine("Width: " + r1.Width);
                Console.WriteLine("Height: " + r1.Height);
                Console.WriteLine("Area: " + r1.Area());
                Console.WriteLine("Perimeter: " + r1.Perimeter() + "\n");
            } else {
                Console.WriteLine("This is not a rectangle.\n");
            }
        }
    }
    public static void AdditionalTask() {
        Rectangle[] rectangles = new Rectangle[26];

        for (int i = 0; i < rectangles.Length / 2; i++) {
            rectangles[i] = new Rectangle(i, i + 2, i - 1, i + 1);
        }
        
        for (int i = 0; i < rectangles.Length / 2; i++) {
            rectangles[rectangles.Length - 1 - i] = new Rectangle(rectangles[i]);
        }
        
        for (int i = 0; i < rectangles.Length; i++) {
            Console.WriteLine($"Rectangle {i + 1}: {rectangles[i].ToString()}");
        }
    }
}