using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using Raylib_cs;

namespace main;

class GameIni
{
    public int screenWidth = 400;
    public int screenHeight = 400;
    public Vector2 cameraVector = new Vector2(200,200);
    public void IniLoading()
    {

        Raylib.SetConfigFlags(ConfigFlags.ResizableWindow); 
        
        
        

        Raylib.InitWindow(screenWidth,screenHeight,"game");

        
        
        Camera2D camera = new Camera2D
        {
            Offset = new Vector2(screenWidth / 2f, screenHeight / 2f),
            Target = cameraVector,
            Rotation = 0f,
            Zoom = 1f
        };
    }

}
class LoadFromMemory
{
    public Image test = Raylib.LoadImage("tile_000.png");
    public Texture2D test_texture; 
    public void LoadTextures()
    {
        test_texture = Raylib.LoadTextureFromImage(test);
    }
}