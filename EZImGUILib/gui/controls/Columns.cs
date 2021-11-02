using System;
using System.Collections.Generic;
using ImGuiNET;

namespace EZImGUILib.gui.controls
{
    public class Columns : Control
    {
        private String id;
        
        private Dictionary<int, Control> columns;

        public Columns(string id, params Column[] column)
        {
            columns = new Dictionary<int, Control>();
            this.id = id;

            for (int i = 0; i < column.Length; i++)
            {
                columns.Add(i, column[i]);
            }
        }

        public override void render()
        {
            ImGui.BeginChild("columns " + id);
            ImGui.Columns(columns.Count);
            foreach (Column column in columns.Values)
            {
                column.render();
                ImGui.NextColumn();
            }
            ImGui.EndChild();
        }

        public void addColumn(Column column)
        {
            columns.Add(columns.Count + 1, column);
        }
    }
}