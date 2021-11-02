using System.Collections.Generic;

namespace EZImGUILib.gui.controls
{
    public class Column : Control
    {
        private Dictionary<string, Control> items;

        public Column()
        {
            items = new Dictionary<string, Control>();
        }

        public void addControl(string id, Control control)
        {
            items.Add(id, control);
        }

        public override void render()
        {
            foreach (Control control in items.Values)
            {
                control.render();
            }
        }
    }
}