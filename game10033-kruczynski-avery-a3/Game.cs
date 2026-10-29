// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    /// 
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>        
        CharacterLegs CharacterLegs = new CharacterLegs();
        CharacterTorso CharacterShirt = new CharacterTorso();
        CharacterHead CharacterHead = new CharacterHead();

        //CharacterHead head = new CharacterHead();  // tells computer to allocate memory for the head and store it.
        public void Setup()
        {
            Window.SetTitle("Avery's Micro Character Creator");
            Window.SetSize(600, 800);

            CharacterLegs.Setup();
            CharacterShirt.Setup();
            CharacterHead.Setup();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.LightGray);

            CharacterLegs.Update();
            CharacterShirt.Update();
            CharacterHead.Update();

        }
    }

}
