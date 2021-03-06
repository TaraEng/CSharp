﻿namespace ConsoleApp.Classes
{
    public class Rectangle
    {
        //Fields, encapsulated with private and access through property
        private int width;
        private int height;

        //Default Constructor, created automatically when not defining any constructors.
        public Rectangle()
        {
        }

        //Constructor taking parameters
        public Rectangle(int h, int w, string color)
        {
            Height = h;
            Width = w;
            Color = color;
        }

        //Property for height with expression body
        public int Height
        {
            get => height;
            set => height = value;
        }

        //Property for width
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        //Automatic Property for color, without backing field
        public string Color { get; set; }

        //Method for calculating area of rectangle
        public int Area()
        {
            return Width * Height;
        }
    }
}