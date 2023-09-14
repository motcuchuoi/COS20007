using System;
using System.Security.Cryptography.X509Certificates;
using SplashKitSDK;

namespace ShapeDrawer
{
  public class Program
  {
    public static void Main()
    {
      Window window = new Window("Shape Drawer", 800, 600);
      Shape myShape = new Shape();
      do
      {
        SplashKit.ProcessEvents();
        SplashKit.ClearScreen();

        if (SplashKit.MouseClicked(MouseButton.LeftButton))
        {
          myShape.X = SplashKit.MouseX();
          myShape.Y = SplashKit.MouseY();
        }

        if (SplashKit.KeyTyped(KeyCode.SpaceKey))
        {
          if (myShape.IsAt(SplashKit.MousePostion()))
          {
            myShape.Color = SplashKit.RandomRGBColor(255);
          }
        }
        myShape.Draw();
        SplashKit.RefreshScreen();
      }
      while (!window.CloseRequested);
    }
  }        
}     
