using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System.Collections.Generic;

namespace Game01Drawing
{
    public class Game
    {

        public void GameMain()
        {
            // Create a Window
            var window = new GameWindow(new VideoMode(1280,720), "Drawing Test");
            
            var allObjs = new List<Drawable>();

            var rect = new RectangleShape(new Vector2f(300, 200));
            rect.Position = new Vector2f(100, 100);
            rect.OutlineThickness = 2;
            rect.OutlineColor = Color.White;
            rect.FillColor = Color.Blue;
            allObjs.Add(rect);

            var circle = new CircleShape(100);
            circle.Position = new Vector2f(500, 100);
            circle.OutlineThickness = 2;
            circle.OutlineColor = Color.White;
            circle.FillColor = Color.Green;
            allObjs.Add(circle);

            var polygon = new ConvexShape(3);
            polygon.SetPoint(0, new Vector2f(100, 0));
            polygon.SetPoint(1, new Vector2f(0, 200));
            polygon.SetPoint(2, new Vector2f(200, 200));
            polygon.Position = new Vector2f(800, 100);
            polygon.OutlineThickness = 2;
            polygon.OutlineColor = Color.White;
            polygon.FillColor = Color.Red;
            allObjs.Add(polygon);

            var texturePuppy = new Texture("Puppy.jpg");
            var puppy = new Sprite(texturePuppy);
            allObjs.Add(puppy);

            window.RunGameLoop(allObjs);

        }

        

    }
}