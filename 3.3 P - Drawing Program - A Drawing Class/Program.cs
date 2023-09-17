using System;
using SplashKitSDK;

namespace DrawingProgram
{
    public class Program
    {
        static void Main()
        {
            Drawing myDrawing = new Drawing();
            Window window = new Window("Drawing Class", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape s = new Shape();
                    s.X = SplashKit.MouseX();
                    s.Y = SplashKit.MouseY();
                    myDrawing.AddShapes(s);
                }
                if (SplashKit.KeyDown(KeyCode.SpaceKey))
                {
                    myDrawing.Background = SplashKit.RandomRGBColor(255);
                }
                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    myDrawing.SelectShapesAt(SplashKit.MousePosition());
                }
                if (SplashKit.KeyDown(KeyCode.BackspaceKey) || SplashKit.KeyDown(KeyCode.DeleteKey))
                {
                    foreach (Shape s in myDrawing.SelectedShapes)
                    {
                        myDrawing.RemoveShapes(s);
                    }
                }
                myDrawing.Draw();
                SplashKit.RefreshScreen();
            }
            while (!window.CloseRequested);
        }
    }
}
