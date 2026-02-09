using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using Raylib_cs;



namespace main;


class Suguma
{
   public int screenWidth = 1280;
   public int screenHeight = 720;
   public int state;
   GameIni start = new GameIni();
   LoadFromMemory loadFromMemory = new LoadFromMemory();
   bool holder = true;
    

    static void Main(string[] args)
    {
        int screenWidth = 1280;
        int screenHeight = 720;

        Camera2D camera = new Camera2D();
        camera.Offset = new Vector2(screenWidth / 2f, screenHeight / 2f);
        camera.Target = new Vector2(0,0);
        camera.Rotation = 0f;
        camera.Zoom = 1f;


        Raylib.SetConfigFlags(ConfigFlags.ResizableWindow); 
        Raylib.InitWindow(screenWidth,screenHeight,"game");
        Raylib.SetTargetFPS(60);

        Image test = Raylib.LoadImage("tile_000.png");
        Texture2D CurrentTexture = Raylib.LoadTextureFromImage(test);


        while (!Raylib.WindowShouldClose())
        {
            camera.Offset.X = Raylib.GetScreenWidth()/2;
            camera.Offset.Y = Raylib.GetScreenHeight()/2;

            
            Raylib.BeginDrawing();
            Raylib.BeginMode2D(camera);
            Raylib.ClearBackground(Color.DarkBlue);

            //Raylib.DrawText("gfd",0,0,200,Color.White);
            Raylib.DrawTexture(CurrentTexture, 0, 0, Color.White);


            Raylib.EndMode2D();
            Raylib.EndDrawing();
            
        }
        Raylib.CloseWindow();



       /*
       

        

       
       GameIni start = new GameIni();
       DeltaTime timeUpdate = new DeltaTime();
       LoadFromMemory loadFromMemory = new LoadFromMemory();
       
        
       start.IniLoading();
       
       
       timeUpdate.GameTickUpdate();
        
        
        
        
        
        loadFromMemory.LoadTextures();
      
        
       //Vector2 mouse_position;

       

        

        
        while ()
        {
                
                
                
                //

                
                

                
            
            




                

            
                

                //
                /*Raylib.DrawTexturePro(CurrentTexture, 
                new Rectangle(0,0,CurrentTexture.Width,CurrentTexture.Height),
                new Rectangle(0,0,CurrentTexture.Width,CurrentTexture.Height),
                new Vector2(CurrentTexture.Width/2,CurrentTexture.Height/2),0,Color.White );

                //
                Raylib.EndDrawing();
                
            
            
            
            
           
           
        }
        Raylib.CloseWindow();*/

      
        


    }
    /*public void Update(double DeltaTime)
    {
        
        
                
                
            
        
       
    }*/
  
}
