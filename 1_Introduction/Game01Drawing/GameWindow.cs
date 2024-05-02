using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game01Drawing
{
    public class GameWindow : RenderWindow
    {
        public GameWindow(VideoMode mode, string title) : base(mode, title)
        {
            this.Closed += WindowClosed;
        }

        private static void WindowClosed(object? sender, System.EventArgs e)
        {
            var window = (RenderWindow)sender!;
            window.Close();
        }

        public void RunGameLoop(List<Drawable> allObjs)
        {
            while (this.IsOpen) // Event loop
            {
                this.DispatchEvents();
                this.Clear(new Color(255, 200, 225)); // Background Color

                foreach (var obj in allObjs)
                {
                    this.Draw(obj);
                }

                //window.Draw(rect);
                //window.Draw(circle);

                //window.Draw(polygon);
                //window.Draw(puppy);

                this.Display();
            }
        }
    }

    


}
