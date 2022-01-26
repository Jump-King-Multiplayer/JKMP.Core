using System;
using System.Collections.Generic;
using System.Linq;
using BehaviorTree;
using HarmonyLib;
using JKMP.Core.Logging;
using JumpKing;
using JumpKing.Controller;
using JumpKing.GameManager;
using JumpKing.PauseMenu;
using JumpKing.PauseMenu.BT;
using JumpKing.Util;
using Microsoft.Xna.Framework;

namespace JKMP.Core.UI
{
    public class PluginsMenu : AdvancedMenuSelector
    {
        private const int Width = Game1.WIDTH;
        private const int Height = Game1.HEIGHT;

        private static GuiFormat pluginsGuiFormat = new()
        {
            margin = new GuiSpacing { left = 16, right = 8, top = 16, bottom = 16 },
            padding = new GuiSpacing { left = 16, right = 16, top = 16, bottom = 16 },
            anchor = Vector2.Zero,
            element_margin = 8,
            all_padding = 16,
            anchor_bounds = new Rectangle(0, 0, Width / 2, Height),
        };

        public static readonly GuiFormat PluginOptionsGuiFormat = new()
        {
            margin = new GuiSpacing { left = 8, right = 16, top = 16, bottom = 16 },
            padding = new GuiSpacing { left = 16, right = 16, top = 16, bottom = 16 },
            anchor = Vector2.Zero,
            element_margin = 8,
            all_padding = 16,
            anchor_bounds = new Rectangle(Width / 2, 0, Width / 2, Height),
        };

        private readonly List<IBTnode> pluginMenus = new();
        private readonly PluginLoadOrderMenu pluginLoadOrderMenu;

        public PluginsMenu() : base(pluginsGuiFormat, autoSize: false)
        {
            pluginLoadOrderMenu = new();
        }

        public override void Draw()
        {
            base.Draw();

            if (last_result != BTresult.Running)
                return;
            
            string bottomMessage = "Press escape or backspace to close the menu";
            var textSize = JKContentManager.Font.MenuFontSmall.MeasureString(bottomMessage);
            TextHelper.DrawString(JKContentManager.Font.MenuFontSmall, bottomMessage, new Vector2(Width / 2, Height - 30), Color.White,
                new Vector2(0.5f, 1));
        }

        public override void AddChild(IMenuItem menuItem)
        {
            pluginMenus.Add((IBTnode)menuItem);
        }

        public override void AddChild<T>(T menuItem)
        {
            pluginMenus.Add(menuItem);
        }

        protected override void OnDirty()
        {
            var newChildren = new List<IBTnode>();

            // Add plugins title
            newChildren.Add(new TextInfo("Plugins", Color.White));
            
            // Add plugin menus
            foreach (var menu in pluginMenus)
            {
                newChildren.Add(menu);
            }

            // Add core options
            newChildren.Add(new TextInfo("Core options", Color.White));
            newChildren.Add(new TextButton("Load order", pluginLoadOrderMenu, JKContentManager.Font.MenuFontSmall, Color.LightGray));

            // Set children
            Traverse.Create(this).Field<IBTnode[]>("m_children").Value = newChildren.ToArray();
            
            base.OnDirty();
        }
    }
}