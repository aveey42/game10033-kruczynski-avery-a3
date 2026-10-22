using System;
using System.Numerics;          //Mandatory

namespace MohawkGame2D;         // Change Namespace to 2D template

public class CharacterHead      // Change to public Class
{
    // Variables Here
    int HeadType = 1;

    public void Setup()
    {
        // Randomize Starting Head
        


    }

    public void Update() 
    {
        // Line Parameters. Since Head is simple, they can stay this way. Depending on the type of head used, we have to make them from various shapes, them remove outlines. Since this is a standard circle, this will be unnecessary
        Draw.LineSize = 1;
        Draw.LineColor = Color.Black;

    }
}
