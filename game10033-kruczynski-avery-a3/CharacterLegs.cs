using System;
using System.Numerics;          //Mandatory

namespace MohawkGame2D;         // Change Namespace to 2D template

public class CharacterLegs      // Change to public Class
{
    // Variables Here
    int LegType = Random.Integer(2);
    Color PantColorPrimary;
    Color PantColorSecondary; 
    Color SkinTone = Color.ToneYellow;
    Color ArrowColor;
    int ArrowAnchorX = 300;
    int ArrowAnchorY = 600;
    int LeftArrowX;
    int LeftArrowY;
    int RightArrowX;
    int RightArrowY;
    // Line Count and Coords
    int LineCount = 0;
    int LineCoordX = 235;
    int LineCoordY = 630;
    public void Setup()
    {
        // Setup Array
        // Randomize Starting Legs
    }

    public void Update()
    {
        // Line Parameters. Create function for Leg variations
        DrawLegBase();
        DrawLegDetails();
        ArrowSetup();

    }
    void DrawLegBase()
    {
        // Remove outlines
        Draw.SetLineSize(0);
        Draw.SetFillColor(PantColorPrimary);

        // Waist, legs and feet
        Draw.Rectangle(230, 500, 140, 50);
        Draw.Rectangle(330, 500, 40, 250);
        Draw.Rectangle(230, 500, 40, 250);

        // Feet
        Draw.SetFillColor(Color.ShoeBlack);
        Draw.Rectangle(230, 700, 40, 50);
        Draw.Rectangle(330, 700, 40, 50);
        Draw.Triangle(180, 750, 230, 700, 230, 750);
        Draw.Triangle(420, 750, 370, 700, 370, 750);

        // Outlines
        Draw.SetLineSize(1);
        Draw.Line(180, 750, 270, 750);
        Draw.Line(180, 750, 230, 700);
        Draw.Line(230, 700, 230, 500);
        Draw.Line(230, 500, 370, 500);
        Draw.Line(370, 500, 370, 700);
        Draw.Line(370, 700, 420, 750);
        Draw.Line(420, 750, 330, 750);
        Draw.Line(330, 750, 330, 550);
        Draw.Line(330, 550, 270, 550);
        Draw.Line(270, 550, 270, 750);
        Draw.Line(270, 750, 180, 750);
        Draw.Line(230, 700, 270, 700);
        Draw.Line(330, 700, 370, 700);
    }
    void DrawLegDetails()
    {
        // If statement checking Leg value

        // Leg 1
        if (LegType == 0)
        {
            // PantsBrown
            PantColorPrimary = Color.PantsGray;
            DrawLegBase();
        }

        // Leg 2
        else if (LegType == 1)
        {
            // PantsGray
            PantColorPrimary = Color.PantsBrown;
            DrawLegBase();

            // Details
            Draw.SetFillColor(SkinTone);
            Draw.Rectangle(229, 620, 41, 81);
            Draw.Rectangle(329, 620, 41, 81);
        }
        // Leg 3
        else if (LegType == 2)
        {
            // Socks White, Shoes Black, SkinTone
            PantColorPrimary = Color.PantsGray;
            PantColorSecondary = Color.White;
            DrawLegBase();

            //Details

            // Skirt
            Draw.SetFillColor(PantColorPrimary);
            Draw.Triangle(300, 395, 170, 600, 430, 600);
            // Legs
            Draw.SetFillColor(SkinTone);
            Draw.Rectangle(229, 600, 41, 31);
            Draw.Rectangle(329, 600, 41, 31);
            // Socks
            Draw.SetFillColor(PantColorSecondary);
            Draw.Rectangle(229, 630, 41, 71);
            Draw.Rectangle(329, 630, 41, 71);

            // For loop drawing lines on socks
            for (LineCount = 0; LineCount < 8; LineCount++)
            {
                Draw.Line(LineCoordX - 140, LineCoordY, LineCoordX - 140, LineCoordY + 10);
                LineCoordX += 5;
            }
            LineCoordX = 335;
            LineCoordY = 630;
            for (LineCount = 7; LineCount < 14; LineCount++)
            {
                Draw.Line(LineCoordX, LineCoordY, LineCoordX, LineCoordY + 10);
                LineCoordX += 5;
            }


        }
    }

    // Copypaste void arrows from CharacterLeg.cs
    void ArrowSetup()
    {
        ArrowColor = Color.ArrowOFF;

        // Set Left Arrow origin
        LeftArrowX = ArrowAnchorX - 200;
        LeftArrowY = ArrowAnchorY - 10;

        // Draw Arrow Left
        Draw.SetLineSize(0);
        Draw.SetFillColor(ArrowColor);
        Draw.Rectangle(LeftArrowX + 30, LeftArrowY + 20, 30, 20);
        Draw.Triangle(LeftArrowX, LeftArrowY + 30, LeftArrowX + 30, LeftArrowY, LeftArrowX + 30, LeftArrowY + 60);
        // Draw outlines if i have time

        // Set Right Arrow origin

        RightArrowX = ArrowAnchorX + 140;
        RightArrowY = ArrowAnchorY - 10;

        // Draw Arrow Right
        Draw.SetLineSize(0);
        Draw.SetFillColor(ArrowColor);
        Draw.Rectangle(RightArrowX, RightArrowY + 20, +30, +20);
        Draw.Triangle(RightArrowX + 30, RightArrowY, RightArrowX + 60, RightArrowY + 30, RightArrowX + 30, RightArrowY + 60);

        // Loops values 0-2 if their value exceeds 2 or goes below 0
        if (LegType > 2)
        {
            LegType = 0;
        }
        else if (LegType < 0)
        {
            LegType = 2;
        }
        //for (LegType = 0; LegType < 2; LegType++)
        //{
        //    LegType = 2;
        //}
        //for (LegType = 2; LegType > 0; LegType++)
        //{
        //    LegType = 1;
        //}

        // Had an issue where IsMouseButtonDown caused problems by modifying values once every frame. Changed to IsMouseButtonPressed and issue was fixed
        if (Input.GetMouseX() >= LeftArrowX && Input.GetMouseX() <= LeftArrowX + 60 && Input.GetMouseY() >= LeftArrowY && Input.GetMouseY() <= LeftArrowY + 60 && Input.IsMouseButtonPressed(MouseButton.Left) == true)
        {
            LegType -= 1;
        }
        else if (Input.GetMouseX() >= RightArrowX && Input.GetMouseX() <= RightArrowX + 60 && Input.GetMouseY() >= RightArrowY && Input.GetMouseY() <= RightArrowY + 60 && Input.IsMouseButtonPressed(MouseButton.Left) == true)
        {
            LegType += 1;
        }

    }

}