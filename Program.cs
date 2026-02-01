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
       GameIni start = new GameIni();
       start.IniLoading();


        
        Vector2 mouse_position;
        Image test = Raylib.LoadImage("tile_000.png");
        Texture2D test_texture = Raylib.LoadTextureFromImage(test);
       

        

        
        while (!Raylib.WindowShouldClose())
        {

            
            mouse_position = Raylib.GetMousePosition();
            //mezi = mouse_position.ToString();
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.DarkBlue);
            Raylib.DrawTexturePro(test_texture, new Rectangle(0,0,test_texture.Width,test_texture.Height),
            new Rectangle(100,100,test_texture.Width*1,test_texture.Height*1),new Vector2(test_texture.Width,test_texture.Height),0,Color.White );
            Raylib.DrawTexturePro(test_texture, new Rectangle(0,0,test_texture.Width,test_texture.Height),
            new Rectangle(118,109,test_texture.Width*1,test_texture.Height*1),new Vector2(test_texture.Width,test_texture.Height),0,Color.White );
            Raylib.DrawTexturePro(test_texture, new Rectangle(0,0,test_texture.Width,test_texture.Height),
            new Rectangle(136,118,test_texture.Width*1,test_texture.Height*1),new Vector2(test_texture.Width,test_texture.Height),0,Color.White );
            //Raylib.DrawText("gfd",100,100,80,Color.White);

            
            

            Raylib.EndDrawing();
            //Raylib.IsMouseButtonPressed(MouseButton.Left)
           
        }

        Raylib.CloseWindow();


    }

  
}
