using System;
using System.Numerics;          //Mandatory

namespace MohawkGame2D;         // Change Namespace to 2D template

public class CharacterHead      // Change to public Class
{
    // Variables Here
    int HeadType = Random.Integer(2);
    Color SkinTone = Color.ToneYellow;
    Color ArrowColor;
    int ArrowAnchorX = 300;
    int ArrowAnchorY = 240;
    int LeftArrowX;
    int LeftArrowY;
    int RightArrowX;
    int RightArrowY;

    public void Setup()
    {
        // Setup Array
        // Randomize Starting Head
    }

    public void Update() 
    {
        // Line Parameters. Create function for head variations
        DrawNeck();
        DrawHead();
        ArrowSetup();

    }
    void DrawNeck()
    {
        // Draw Base Neck

        // Remove outlines
        Draw.SetLineSize(0);
        Draw.SetFillColor(SkinTone);

        // Neck
        Draw.Triangle(310, 300, 320, 310, 310, 310);
        Draw.Triangle(290, 300, 280, 310, 290, 310);
        Draw.Square(290, 290, 20);

        // Outlines
        Draw.SetLineSize(1);
        Draw.Line(290, 290, 290, 300);
        Draw.Line(310, 290, 310, 300);
        Draw.Line(310, 300, 320, 310);
        Draw.Line(290, 300, 280, 310);
    }
    void DrawHead()
    {
        // If statement checking Head value 

        // Head 1
        if (HeadType == 0)
        {
            // Call Neck Function
            DrawNeck();

            // Draw Head
            Draw.Square(250, 190, 100);

        }

        // Head 2
        else if (HeadType == 1)
        {
            // Call Neck Function
            DrawNeck();

            // Draw Head
            Draw.Circle(300, 245, 50);
        }
        // Head 3
        else if (HeadType == 2)
        {

            // Call Neck Function
            DrawNeck();

            //Draw Head
            Draw.Capsule(300, 230, 300, 245, 50);
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
        if (HeadType > 2)
        {
            HeadType = 0;
        }
        else if (HeadType < 0)
        {
            HeadType = 2;
        }
        //for (HeadType = 0; HeadType < 2; HeadType++)
        //{
        //    HeadType = 2;
        //}
        //for (HeadType = 2; HeadType > 0; HeadType++)
        //{
        //    HeadType = 1;
        //}

        // Had an issue where IsMouseButtonDown caused problems by modifying values once every frame. Changed to IsMouseButtonPressed and issue was fixed
        if (Input.GetMouseX() >= LeftArrowX && Input.GetMouseX() <= LeftArrowX + 60 && Input.GetMouseY() >= LeftArrowY && Input.GetMouseY() <= LeftArrowY + 60 && Input.IsMouseButtonPressed(MouseButton.Left) == true)
        {
            HeadType -= 1;
        }
        else if (Input.GetMouseX() >= RightArrowX && Input.GetMouseX() <= RightArrowX + 60 && Input.GetMouseY() >= RightArrowY && Input.GetMouseY() <= RightArrowY + 60 && Input.IsMouseButtonPressed(MouseButton.Left) == true)
        {
            HeadType += 1;
        }

    }
}
