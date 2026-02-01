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
       LoadFromMemory loadFromMemory = new LoadFromMemory();
       loadFromMemory.LoadTextures();

        
        Vector2 mouse_position;

       

        

        
        while (!Raylib.WindowShouldClose())
        {

            
            mouse_position = Raylib.GetMousePosition();
            //mezi = mouse_position.ToString();
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.DarkBlue);
            Raylib.DrawTexturePro(loadFromMemory.test_texture, 
            new Rectangle(0,0,loadFromMemory.test_texture.Width,loadFromMemory.test_texture.Height),
            new Rectangle(100,100,loadFromMemory.test_texture.Width*1,loadFromMemory.test_texture.Height*1),
            new Vector2(loadFromMemory.test_texture.Width,loadFromMemory.test_texture.Height),0,Color.White );

            Raylib.DrawTexturePro(loadFromMemory.test_texture,
            new Rectangle(0,0,loadFromMemory.test_texture.Width,loadFromMemory.test_texture.Height),
            new Rectangle(118,109,loadFromMemory.test_texture.Width*1,loadFromMemory.test_texture.Height*1),
            new Vector2(loadFromMemory.test_texture.Width,loadFromMemory.test_texture.Height),0,Color.White );

            Raylib.DrawTexturePro(loadFromMemory.test_texture,
            new Rectangle(0,0,loadFromMemory.test_texture.Width,loadFromMemory.test_texture.Height),
            new Rectangle(136,118,loadFromMemory.test_texture.Width*1,loadFromMemory.test_texture.Height*1),
            new Vector2(loadFromMemory.test_texture.Width,loadFromMemory.test_texture.Height),0,Color.White );
            //Raylib.DrawText("gfd",100,100,80,Color.White);

            
            

            Raylib.EndDrawing();
            //Raylib.IsMouseButtonPressed(MouseButton.Left)
           
        }

        Raylib.CloseWindow();


    }

  
}
