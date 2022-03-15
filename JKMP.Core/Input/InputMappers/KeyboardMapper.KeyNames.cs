using System;
using JKMP.Core.Windows;
using Microsoft.Xna.Framework.Input;

namespace JKMP.Core.Input.InputMappers
{
    internal partial class KeyboardMapper
    {
        private static string? GetKeyName(Keys key)
        {
            return key switch
            {
                Keys.Back => "backspace",
                Keys.Tab => "tab",
                Keys.Enter => "enter",
                Keys.CapsLock => "capslock",
                Keys.Escape => "escape",
                Keys.Space => "space",
                Keys.PageUp => "pageup",
                Keys.PageDown => "pagedown",
                Keys.End => "end",
                Keys.Home => "home",
                Keys.Left => "left",
                Keys.Up => "up",
                Keys.Right => "right",
                Keys.Down => "down",
                Keys.Select => "select",
                Keys.Execute => "execute",
                Keys.PrintScreen => "printscreen",
                Keys.Insert => "insert",
                Keys.Delete => "delete",
                Keys.Pause => "pause",
                Keys.D0 => "0",
                Keys.D1 => "1",
                Keys.D2 => "2",
                Keys.D3 => "3",
                Keys.D4 => "4",
                Keys.D5 => "5",
                Keys.D6 => "6",
                Keys.D7 => "7",
                Keys.D8 => "8",
                Keys.D9 => "9",
                Keys.A => "a",
                Keys.B => "b",
                Keys.C => "c",
                Keys.D => "d",
                Keys.E => "e",
                Keys.F => "f",
                Keys.G => "g",
                Keys.H => "h",
                Keys.I => "i",
                Keys.J => "j",
                Keys.K => "k",
                Keys.L => "l",
                Keys.M => "m",
                Keys.N => "n",
                Keys.O => "o",
                Keys.P => "p",
                Keys.Q => "q",
                Keys.R => "r",
                Keys.S => "s",
                Keys.T => "t",
                Keys.U => "u",
                Keys.V => "v",
                Keys.W => "w",
                Keys.X => "x",
                Keys.Y => "y",
                Keys.Z => "z",
                Keys.LeftWindows => "leftwin",
                Keys.RightWindows => "rightwin",
                Keys.Apps => "apps",
                Keys.NumPad0 => "numpad0",
                Keys.NumPad1 => "numpad1",
                Keys.NumPad2 => "numpad2",
                Keys.NumPad3 => "numpad3",
                Keys.NumPad4 => "numpad4",
                Keys.NumPad5 => "numpad5",
                Keys.NumPad6 => "numpad6",
                Keys.NumPad7 => "numpad7",
                Keys.NumPad8 => "numpad8",
                Keys.NumPad9 => "numpad9",
                Keys.Multiply => "multiply",
                Keys.Add => "numpadplus",
                Keys.Separator => "numpadseparator",
                Keys.Subtract => "numpadminus",
                Keys.Decimal => "numpadcomma",
                Keys.Divide => "numpaddivide",
                Keys.F1 => "f1",
                Keys.F2 => "f2",
                Keys.F3 => "f3",
                Keys.F4 => "f4",
                Keys.F5 => "f5",
                Keys.F6 => "f6",
                Keys.F7 => "f7",
                Keys.F8 => "f8",
                Keys.F9 => "f9",
                Keys.F10 => "f10",
                Keys.F11 => "f11",
                Keys.F12 => "f12",
                Keys.NumLock => "numlock",
                Keys.Scroll => "scrolllock",
                Keys.LeftShift => "leftshift",
                Keys.RightShift => "rightshift",
                Keys.LeftControl => "leftcontrol",
                Keys.RightControl => "rightcontrol",
                Keys.LeftAlt => "leftalt",
                Keys.RightAlt => "rightalt",
                Keys.OemPlus => "plus",
                Keys.OemComma => "comma",
                Keys.OemMinus => "minus",
                Keys.OemPeriod => "period",
                Keys.OemTilde => "oemtilde",
                Keys.OemPipe => "oempipe",
                Keys.OemQuotes => "oemquotes",
                Keys.OemBackslash => "oembackslash",
                Keys.OemCloseBrackets => "oemclosebrackets",
                Keys.OemOpenBrackets => "oemopenbrackets",
                Keys.OemQuestion => "oemquestionmark",
                Keys.OemSemicolon => "oemsemicolon",
                _ => null,
            };
        }

        public string? GetKeyDisplayName(in string keyName)
        {
            return keyName switch
            {
                "backspace" => "Backspace",
                "tab" => "Tab",
                "enter" => "Enter",
                "capslock" => "Caps lock",
                "escape" => "Escape",
                "space" => "Space",
                "pageup" => "Page up",
                "pagedown" => "Page down",
                "end" => "End",
                "home" => "Home",
                "left" => "Left",
                "up" => "Up",
                "right" => "Right",
                "down" => "Down",
                "select" => "Select",
                "printscreen" => "Printscreen",
                "insert" => "Insert",
                "delete" => "Delete",
                "leftwindows" => "LWin",
                "rightwindows" => "RWin",
                "apps" => "Alt gr",
                "numpad0" => "Numpad 0",
                "numpad1" => "Numpad 1",
                "numpad2" => "Numpad 2",
                "numpad3" => "Numpad 3",
                "numpad4" => "Numpad 4",
                "numpad5" => "Numpad 5",
                "numpad6" => "Numpad 6",
                "numpad7" => "Numpad 7",
                "numpad8" => "Numpad 8",
                "numpad9" => "Numpad 9",
                "numlock" => "Num lock",
                "scroll" => "Scroll lock",
                "leftshift" => "LShift",
                "rightshift" => "RShift",
                "leftcontrol" => "LCtrl",
                "rightcontrol" => "RCtrl",
                "leftalt" => "LAlt",
                "rightalt" => "RAlt",
                "pause" => "Pause",
                _ => KeyMapReversed.ContainsKey(keyName) ? WinNative.GetKeyName(KeyMapReversed[keyName]) : null
            };
        }
    }
}