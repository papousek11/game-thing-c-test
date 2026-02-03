using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using Raylib_cs;



namespace main;


class Suguma
{
   public int state;
   GameIni start = new GameIni();
   LoadFromMemory loadFromMemory = new LoadFromMemory();
    
    //
    static void Main(string[] args)
    {
       //int screenWidth = 1280;
       //int screenHeight = 720;

        
       
       
       GameIni start = new GameIni();
       DeltaTime timeUpdate = new DeltaTime();
       LoadFromMemory loadFromMemory = new LoadFromMemory();
       start.IniLoading();
       loadFromMemory.LoadTextures();
       timeUpdate.GameTickUpdate();
      
        
       //Vector2 mouse_position;

       

        

        
       /* while (!Raylib.WindowShouldClose())
        {
            
            
            
            switch (MainVariables.state)
            {   
                //render main loading screen
                case 1:

                    break;
            }
            
            /*mouse_position = Raylib.GetMousePosition();
            //mezi = mouse_position.ToString();
            
            
            
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
            

            
            

            
            //Raylib.IsMouseButtonPressed(MouseButton.Left)
           
           
        }
        */

      
        


    }
    public void Update(double DeltaTime)
    {
        if (!Raylib.WindowShouldClose())
        {

            Raylib.BeginMode2D(start.camera);
            Raylib.BeginDrawing();
            
            start.camera.Offset.X = Raylib.GetScreenWidth()/2;
            start.camera.Offset.Y = Raylib.GetScreenHeight()/2;



            

            Raylib.ClearBackground(Color.DarkBlue);
            Texture2D CurrentTexture = loadFromMemory.test_texture;


            Raylib.DrawTexturePro(loadFromMemory.test_texture, 
            new Rectangle(0,0,CurrentTexture.Width,CurrentTexture.Height),
            new Rectangle(0,0,CurrentTexture.Width*10,CurrentTexture.Height*10),
            new Vector2(CurrentTexture.Width,CurrentTexture.Height),0,Color.White );

            Raylib.EndMode2D();
            Raylib.EndDrawing();
        }
        else
        {
            Raylib.CloseWindow();
        }
    }
  
}
