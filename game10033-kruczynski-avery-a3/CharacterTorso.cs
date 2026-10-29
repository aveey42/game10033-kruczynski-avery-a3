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
    Color ShirtColorPrimary;
    Color ShirtColorSecondary;
    Color SkinTone = Color.ToneYellow;
    Color ArrowColor;
    int ArrowAnchorX = 300;
    int ArrowAnchorY = 400;
    int LeftArrowX;
    int LeftArrowY;
    int RightArrowX;
    int RightArrowY;

    // Line/Stripe Count and Coords
    int LineCount = 0;
    int LineCoordX = 240;
    int LineCoordY = 470;
    int StripeCoordX = 199;
    int StripeCoordY = 340;
    int StripeCount = 0;


    public void Setup()
    {
        // Setup Array
        // Randomize Starting Torso
        // Setup Arrows
    }

    public void Update()
    {
        // Line Parameters. Create function for torso variations
        DrawTorsoBase();
        DrawTorsoDetails();
        ArrowSetup();
        
    }

    void DrawTorsoBase()
    {
        // Draw Base Torso

        // Remove outlines
        Draw.SetLineSize(0);
        Draw.SetFillColor(ShirtColorPrimary);

        // Torso
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

            // Define ShirtColor
            ShirtColorPrimary = Color.ShirtBlue;
            ShirtColorSecondary = Color.ShirtPink;

            // Call Torso Function
            DrawTorsoBase();

            // Sleeve Cuffs
            Draw.SetLineSize(1);
            Draw.SetFillColor(ShirtColorSecondary);
            Draw.Rectangle(199, 480, 31, 11);
            Draw.Rectangle(369, 480, 31, 11);

            // Collar
            Draw.SetLineSize(0);
            Draw.SetFillColor(SkinTone);
            Draw.Triangle(280, 310, 320, 310, 300, 330);
            Draw.SetLineSize(1);
            Draw.Line(300, 330, 280, 310);
            Draw.Line(300, 330, 320, 310);
        }

        // Torso 2
        else if (TorsoType == 1)
        {
            // Define ShirtColor
            ShirtColorPrimary = Color.AdamShirtAdamShirt;

            // Call Torso Function
            DrawTorsoBase();

            // Draw Sleeves
            Draw.SetLineSize(1);
            Draw.SetFillColor(SkinTone);
            Draw.Rectangle(369, 355, 31, 136);
            Draw.Rectangle(199, 355, 31, 136);

            // Might add collar variants later on, this one would be an ellipse
            // Collar
            Draw.SetLineSize(0);
            Draw.SetFillColor(SkinTone);
            Draw.Triangle(280, 310, 320, 310, 300, 330);
            Draw.SetLineSize(1);
            Draw.Line(300, 330, 280, 310);
            Draw.Line(300, 330, 320, 310);

        }

        // Torso 3
        else if (TorsoType == 2)
        {
            // Define ShirtColor
            LineCount = 0;
            StripeCount = 0;
            ShirtColorPrimary = Color.ShirtGreen;
            ShirtColorSecondary = Color.ShirtLime;

            // Call Torso Function
            DrawTorsoBase();

            // For loop to draw the stripes
            for (StripeCount = 0; StripeCount < 3; StripeCount++)
            {
                Draw.SetLineSize(0);
                Draw.SetFillColor(ShirtColorSecondary);
                Draw.Rectangle(StripeCoordX, StripeCoordY, 201, 30);
                StripeCoordY += 30;
            }

            // For loop drawing lines on the bottom of the sweater
            for (LineCount = 0; LineCount < 13; LineCount++)
            {
                Draw.SetLineSize(1);
                Draw.Line(LineCoordX, LineCoordY, LineCoordX, LineCoordY + 30);
                LineCoordX += 10;
            }

            // Collar
            Draw.SetLineSize(0);
            Draw.SetFillColor(SkinTone);
            Draw.Triangle(270, 310, 330, 310, 300, 340);
            Draw.SetLineSize(1);
            Draw.Line(300, 340, 270, 310);
            Draw.Line(300, 340, 330, 310);
            Draw.Line(320, 310, 330, 310);
            Draw.Line(270, 310, 280, 310);

            // Redraw shirt outlines
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
    }

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
        Draw.Triangle(LeftArrowX, LeftArrowY +30, LeftArrowX +30, LeftArrowY, LeftArrowX +30, LeftArrowY + 60);
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
        if (TorsoType > 2)
        {
            TorsoType = 0;
        }
        else if (TorsoType < 0)
        {
            TorsoType = 2;
        }

        //for (TorsoType = 0; TorsoType < 2;)
        //{
        //    TorsoType = 2;
        //}
        //for (TorsoType = 3; TorsoType > 0;)
        //{
        //    TorsoType = 0;
        //}

        // Add if statement that changes arrow colors when mouse overs over them
        //if (Input.GetMouseX() >= LeftArrowX && Input.GetMouseX() <= LeftArrowX + 60 && Input.GetMouseY() >= LeftArrowY && Input.GetMouseY() <= LeftArrowY + 60)
        //{
        //    ArrowColor = Color.ArrowON;
        //}
        //else if (Input.GetMouseX() >= RightArrowX && Input.GetMouseX() <= RightArrowX + 60 && Input.GetMouseY() >= RightArrowY && Input.GetMouseY() <= RightArrowY + 60)
        //{
        //    ArrowColor = Color.ArrowON;
        //}
        //else
        //{
        //    ArrowColor = Color.ArrowOFF;
        //}

        // Had an issue where IsMouseButtonDown caused problems by modifying values once every frame. Changed to IsMouseButtonPressed and issue was fixed
        if (Input.GetMouseX() >= LeftArrowX && Input.GetMouseX() <= LeftArrowX +60 && Input.GetMouseY() >= LeftArrowY && Input.GetMouseY() <= LeftArrowY + 60 && Input.IsMouseButtonPressed(MouseButton.Left) == true)
        {
            TorsoType -= 1;
        }
        else if (Input.GetMouseX() >= RightArrowX && Input.GetMouseX() <= RightArrowX + 60 && Input.GetMouseY() >= RightArrowY && Input.GetMouseY() <= RightArrowY + 60 && Input.IsMouseButtonPressed(MouseButton.Left) == true)
        {
            TorsoType += 1;
        }

    }

}