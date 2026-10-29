using Raylib_cs;
using System;
using System.Numerics;          //Mandatory

namespace MohawkGame2D;         // Change Namespace to 2D template

public class CharacterTorso      // Change to public Class
{
    // Variables Here

    // Left Arrow Position
    // Right Arrow Position
    int TorsoType = Random.Integer(2);
    Color ShirtColor;
    Color SkinTone = Color.Yellow;

    public void Setup()
    {
        // Setup Array
        // Randomize Starting Torso
        // Setup Arrows
    }

    public void Update()
    {
        // Line Parameters. Create function for torso variations

    }

    void DrawTorsoBase()
    {
        // Draw Base Torso

        // Remove outlines
        Draw.SetLineSize(0);
        Draw.SetFillColor(ShirtColor);

        // Torso Outline
        Draw.Rectangle(230, 330, 140, 170);
        Draw.Rectangle(240, 310, 120, 140);
        Draw.Triangle(240, 310, 200, 330, 240, 330);
        Draw.Triangle(360, 310, 360, 330, 400, 330);

        // Arms
        Draw.Rectangle(200, 330, 30, 160);
        Draw.Rectangle(370, 330, 30, 160);

        // Hands
        Draw.SetLineColor(Color.Black);
        Draw.SetLineSize(1);
        Draw.SetFillColor(SkinTone);
        Draw.Rectangle(195, 490, 40, 30);
        Draw.Rectangle(365, 490, 40, 30);

        // Outlines

        //Shirt Top + Shoulders
        Draw.Line(240, 310, 360, 310);
        Draw.Line(240, 310, 200, 330);
        Draw.Line(360, 310, 400, 330);

        // Left Arm
        Draw.Line(200, 330, 200, 490);
        Draw.Line(230, 355, 230, 490);
        Draw.Line(200, 490, 230, 490);

        // Right Arm
        Draw.Line(400, 330, 400, 490);
        Draw.Line(370, 355, 370, 490);
        Draw.Line(370, 490, 400, 490);

        // Shirt Bottom
        Draw.Line(235, 500, 365, 500);
    }
    void DrawTorsoDetails()
    {
        // If statement checking torso value 

        // Torso 1
        if (TorsoType == 0)
        {
            ShirtColor = Color.Blue;
            // Define ShirtColor and SkinTone
            
            // Call Torso Function
            DrawTorsoBase();

            // Sleeve Cuffs
            Draw.SetLineSize(1);
            Draw.SetFillColor(Color.Magenta);
            Draw.Rectangle(200, 480, 30, 10);
            Draw.Rectangle(370, 480, 30, 10);
        }

        // Torso 2
        else if (TorsoType == 1)
        {

        }
        // Torso 3
        else if (TorsoType == 2)
        {

        }
    }

    void Arrows()
    {
        // Draw Arrow Left
        // if mouseposition on arrow && mouseclick == down TorsoType -1

        // Draw Arrow Right
        // if mouseposition on arrow && mouseclick == down TorsoType +1
    }

}