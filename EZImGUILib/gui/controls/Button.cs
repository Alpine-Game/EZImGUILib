using System;
using System.Numerics;
using ImGuiNET;

namespace EZImGUILib.gui.controls
{
    public class Button : Control
    {
        private string label;
        private Vector2 scale;

        public Button(string label)
        {
            this.label = label;
        }

        public Button(string label, Vector2 scale)
        {
            this.label = label;
            this.scale = scale;
        }

        public override void render()
        { //Typically, you do not want to call this function directly.
            if (scale != null)
            {
                if (ImGui.Button(label))
                {
                    onClick.Invoke(this, EventArgs.Empty);
                }
            }
            else
            {
                if (ImGui.Button(label, scale))
                {
                    onClick.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public EventHandler onClick;
    }
}