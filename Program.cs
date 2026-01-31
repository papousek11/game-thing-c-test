using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using Raylib_cs;



namespace main;


class Suguma
{
   

    
    //
    static void Main(string[] args)
    {
       



        //Vector2 tlacitko1_1 = new Vector2(10,350);
      



        Vector2 mouse_position;
       


       

        

        Raylib.InitWindow(400,400,"game");
        while (!Raylib.WindowShouldClose())
        {

            
            mouse_position = Raylib.GetMousePosition();
            //mezi = mouse_position.ToString();
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.DarkBlue);
           

            
            

            Raylib.EndDrawing();
            //Raylib.IsMouseButtonPressed(MouseButton.Left)
           
        }

        Raylib.CloseWindow();


    }

  
}
