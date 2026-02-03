using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using Raylib_cs;



namespace main;


class Suguma
{
   public int state;

    
    //
    static void Main(string[] args)
    {
       GameIni start = new GameIni();
       start.IniLoading();
       LoadFromMemory loadFromMemory = new LoadFromMemory();
       loadFromMemory.LoadTextures();
       Suguma MainVariables = new Suguma();
       DeltaTime timeUpdate = new DeltaTime();
       timeUpdate.GameTickUpdate();
    
        
        Vector2 mouse_position;

       

        

        
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
            
            Raylib.BeginMode2D(start.camera);
            
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

            
            

            
            //Raylib.IsMouseButtonPressed(MouseButton.Left)
           
           
        }
        */

      
        


    }
    public void Update(double DeltaTime)
    {
        if (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.DarkBlue);
            Raylib.EndDrawing();
        }
        else
        {
            Raylib.CloseWindow();
        }
    }
  
}
