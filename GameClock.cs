using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using Raylib_cs;
using System.Diagnostics;

namespace main;


class DeltaTime
{

    Stopwatch tick = Stopwatch.StartNew();
    double lastTime;
    

    public DeltaTime()
    {
        this.lastTime = tick.Elapsed.TotalSeconds;
    }
    
    


    public void GameTickUpdate()
    {
        while (true)
        {
            double TimeRN = tick.Elapsed.TotalSeconds;
            double DeltaTime = TimeRN - lastTime;
            lastTime = TimeRN;
            //MainMethod.Update(DeltaTime);
        }
    }
}