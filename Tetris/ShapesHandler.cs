using System;

namespace Tetris
{
    static class ShapesHandler
    {
        private static Shape[] shapesArray;
        private static Shape NextShape;
        
        // static constructor : No need to manually initialize
        static ShapesHandler()
        {
            // Create shapes add into the array.
            shapesArray = new Shape[]
                {
                    new Shape {
                        id = 0,
                        Width = 2,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 1, 1 },
                            { 1, 1 }
                        }
                    },
                    new Shape {
                        id =1,
                        Width = 1,
                        Height = 4,
                        Dots = new int[,]
                        {
                            { 1 },
                            { 1 },
                            { 1 },
                            { 1 }
                        }
                    },
                    new Shape {
                        id=2,
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 0, 1, 0 },
                            { 1, 1, 1 }
                        }
                    },
                    new Shape {
                        id=3,
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 0, 0, 1 },
                            { 1, 1, 1 }
                        }
                    },
                    new Shape {
                        id=4,
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 1, 0, 0 },
                            { 1, 1, 1 }
                        }
                    },
                    new Shape {
                        id=5,
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 1, 1, 0 },
                            { 0, 1, 1 }
                        }
                    },
                    new Shape {
                        id=6,
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 0, 1, 1 },
                            { 1, 1, 0 }
                        }
                    }
                };
            NextShape = shapesArray[new Random().Next(shapesArray.Length)];
        }
        // Get a shape form the array in a random basis
        public static Shape GetRandomShape()
        {
            Shape shape = NextShape;
            do
            {
                NextShape = shapesArray[new Random().Next(shapesArray.Length)];
            } while (shape.id == NextShape.id);
            return shape;
        }
    }
}
