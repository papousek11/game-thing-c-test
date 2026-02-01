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
            start.cameraVector.X = start.cameraVector.X + 0.1f;
            start.cameraVector.Y = 200;
            Console.WriteLine(start.cameraVector.X);
            start.camera.Offset.X = Raylib.GetScreenWidth()/2f;
            start.camera.Offset.Y = Raylib.GetScreenHeight()/2f;

            //start.camera.Target.X = Raylib.GetScreenCenter().X/2;
            //start.camera.Target.Y = Raylib.GetScreenCenter().Y/2;
            mouse_position = Raylib.GetMousePosition();
            //mezi = mouse_position.ToString();
            Raylib.BeginDrawing();
            Raylib.BeginMode2D(start.camera);
            Raylib.ClearBackground(Color.DarkBlue);
            Raylib.DrawTexturePro(loadFromMemory.test_texture, 
            new Rectangle(0,0,loadFromMemory.test_texture.Width,loadFromMemory.test_texture.Height),
            new Rectangle(0,0,loadFromMemory.test_texture.Width*1,loadFromMemory.test_texture.Height*1),
            new Vector2(loadFromMemory.test_texture.Width,loadFromMemory.test_texture.Height),0,Color.White );

            Raylib.DrawTexturePro(loadFromMemory.test_texture,
            new Rectangle(0,0,loadFromMemory.test_texture.Width,loadFromMemory.test_texture.Height),
            new Rectangle(18,9,loadFromMemory.test_texture.Width*1,loadFromMemory.test_texture.Height*1),
            new Vector2(loadFromMemory.test_texture.Width,loadFromMemory.test_texture.Height),0,Color.White );

            Raylib.DrawTexturePro(loadFromMemory.test_texture,
            new Rectangle(0,0,loadFromMemory.test_texture.Width,loadFromMemory.test_texture.Height),
            new Rectangle(36,18,loadFromMemory.test_texture.Width*1,loadFromMemory.test_texture.Height*1),
            new Vector2(loadFromMemory.test_texture.Width,loadFromMemory.test_texture.Height),0,Color.White );
            //Raylib.DrawText("gfd",100,100,80,Color.White);
            Raylib.EndMode2D();

            
            

            Raylib.EndDrawing();
            //Raylib.IsMouseButtonPressed(MouseButton.Left)
           
        }

        Raylib.CloseWindow();


    }

  
}
