using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using ImGuiNET;
using SFML.Graphics;

namespace EZImGUILib.gui
{
    public abstract class GUI
    {
        private string name;
        private Vector2 size;
        private bool showCloseButton = false;
        
        private bool open = true;

        private Dictionary<string, Control> components = new Dictionary<string, Control>();

        public GUI(string name)
        {
            this.name = name;
        }

        public GUI(string name, Vector2 size, bool showCloseButton)
        {
            this.name = name;
            this.size = size;
            this.showCloseButton = showCloseButton;

            components = new Dictionary<string, Control>();
        }
        
        public void render()
        {
            if (showCloseButton)
            {
                ImGui.Begin(name, ref open);
            }
            else
            {
                ImGui.Begin(name);
            }

            foreach (Control control in components.Values)
            {
                control.render();
            }
            
            ImGui.End();
        }

        public void addComponent(string name, Control newComponent)
        {
            components.Add(name, newComponent);
        }
    }
}