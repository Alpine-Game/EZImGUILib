using System;
using System.Numerics;
using ImGuiNET;

namespace EZImGUILib.gui.controls
{
    public class Checkbox : Control
    {
        private string text;

        public bool value;

        public Checkbox(string text)
        {
            this.text = text;
            this.value = false;
        }

        public Checkbox(string text, ref bool value)
        {
            this.text = text;
            this.value = value;
        }

        public override void render()
        {
            if (ImGui.Checkbox(text, ref value))
            {
                onUpdate.Invoke(this, EventArgs.Empty);
            }
        }

        public EventHandler onUpdate;
    }
}