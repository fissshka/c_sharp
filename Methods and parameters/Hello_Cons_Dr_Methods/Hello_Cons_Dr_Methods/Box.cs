using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Box
    {
        //1.  Implement public  auto-implement properties for start position (point position)
        //auto-implement properties for width and height of the box
        //and auto-implement properties for a symbol of a given set of valid characters (*, + ,.) to be used for the border 
        //and a message inside the box
        public int StartPosition { get; set; }
        public int BoxWidth { get; set; }
        public int BoxHeight { get; set; }
        public int BoxBorder { get; set; }
        public int Message { get; set; }
        //2.  Implement public Draw() method
        //to define start position, width and height, symbol, message  according to properties
        //Use Math.Min() and Math.Max() methods
        //Use draw() to draw the box with message
        public Box () 
        public Draw()
        {
            int x, y;
            int StartPosition = int.Parse(Console.ReadLine());
        
        }
        //3.  Implement private method draw() with parameters 
        //for start position, width and height, symbol, message
        //Change the message in the method to return the Box square
        //Use Console.SetCursorPosition() method
        //Trim the message if necessary


    }
}


/*
 * public class ConsoleRectangle
{
    private int hWidth;
    private int hHieght;
    private Point hLocation;
    private ConsoleColor hBorderColor;

    public ConsoleRectangle(int width, int hieght, Point location, ConsoleColor borderColor)
    {
        hWidth = width;
        hHieght = hieght;
        hLocation = location;
        hBorderColor = borderColor;
    }

    public Point Location
    {
        get { return hLocation; }
        set { hLocation = value; }
    }

    public int Width
    {
        get { return hWidth; }
        set { hWidth = value; }
    }

    public int Hieght
    {
        get { return hHieght; }
        set { hHieght = value; }
    }

    public ConsoleColor BorderColor
    {
        get { return hBorderColor; }
        set { hBorderColor = value; }
    }

    public void Darw()
    {
        string s = "╔";
        string space = "";
        string temp = "";
        for (int i = 0; i < Width; i++)
        {
            space += " ";
            s += "═";
        }

        for (int j = 0; j < Location.X ; j++)
            temp += " ";

        s += "╗" + "\n";

        for (int i = 0; i < Hieght; i++)
            s += temp + "║" + space + "║" + "\n";

        s += temp + "╚";
        for (int i = 0; i < Width; i++)
            s += "═";

        s += "╝" + "\n";

        Console.ForegroundColor = BorderColor;
        Console.CursorTop = hLocation.Y;
        Console.CursorLeft = hLocation.X;
        Console.Write(s);
        Console.ResetColor();
    }
}
https://stackoverflow.com/questions/6006618/how-to-draw-a-rectangle-in-console-application
*/
