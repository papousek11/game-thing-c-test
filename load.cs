using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using Raylib_cs;

namespace main;

class GameIni
{
    public int screenWidth = 1420;
    public int screenHeight = 720;
    public Vector2 cameraVector = new Vector2(0,0);
    public Camera2D camera = new Camera2D();
        
    public void IniLoading()
    {

        Raylib.SetConfigFlags(ConfigFlags.ResizableWindow); 
        
        
        

        Raylib.InitWindow(screenWidth,screenHeight,"game");
        camera.Offset = new Vector2(screenWidth / 2f, screenHeight / 2f);
        camera.Target = new Vector2(0,0);
        camera.Rotation = 0f;
        camera.Zoom = 1f;
        Raylib.SetTargetFPS(60); 
        
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