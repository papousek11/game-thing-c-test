using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using Raylib_cs;

namespace main;

class GameIni
{
    public int screenWidth = 1280;
    public int screenHeight = 720;
    public Vector2 cameraVector = new Vector2(0,0);
    
        
    public void IniLoading()
    {

        
        
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
class LoadingVisual
{
    


    public void UpdateLoadBar()
    {
        
    }
}