using ImGuiNET;

namespace EZImGUILib.gui.controls
{
    public class Text : Control
    {
        public string text;
        
        public Text(string text)
        {
            this.text = text;
        }

        public override void render()
        {
            ImGui.Text(text);
        }
    }
}