using System;
using System.Numerics;          //Mandatory

namespace MohawkGame2D;         // Change Namespace to 2D template

public class CharacterHead      // Change to public Class
{
    // Variables Here
    int HeadType = Random.Integer(2);
    Color SkinTone = Color.Yellow;

    public void Setup()
    {
        // Setup Array
        // Randomize Starting Head
    }

    public void Update() 
    {
        // Line Parameters. Create function for head variations
        Draw.LineSize = 1;
        Draw.LineColor = Color.Black;

    }
}
