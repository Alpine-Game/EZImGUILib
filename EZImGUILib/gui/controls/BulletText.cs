using EZImGUILib.gui;
using ImGuiNET;

namespace EZImGUILib.gui.controls
{
    public class BulletText : Control
    {
        private string text;
        public BulletText(string text)
        {
            this.text = text;
        }

        public override void render()
        {
            ImGui.BulletText(text);
        }
    }
}