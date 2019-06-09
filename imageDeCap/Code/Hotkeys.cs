﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imageDeCap
{
    public static class Hotkeys
    {
        static bool UploadPastebitHotkey = false;
        static bool CaptureVideoHotkey = false;
        static bool CaptureImageHotkey = false;

        public static void Update()
        {
            if (Program.hotkeysEnabled)
            {
                string hotkey = GetCurrentHotkey();

                if (Preferences.HotkeyText == hotkey)
                {
                    if (!UploadPastebitHotkey)
                        ScreenCapturer.UploadPastebinClipboard();
                    UploadPastebitHotkey = true;
                }
                else if (Preferences.HotkeyVideo == hotkey)
                {
                    if (!CaptureVideoHotkey)
                        ScreenCapturer.CaptureScreenRegion(true);
                    CaptureVideoHotkey = true;
                }
                else if (Preferences.HotkeyImage == hotkey)
                {
                    if (!CaptureImageHotkey)
                        ScreenCapturer.CaptureScreenRegion();
                    CaptureImageHotkey = true;
                }
                else
                {
                    // no recognized hotkey
                    UploadPastebitHotkey = false;
                    CaptureVideoHotkey = false;
                    CaptureImageHotkey = false;
                }
            }
        }


        public static string GetCurrentHotkey()
        {
            string textToPutInBox = "";
            int length = Enum.GetValues(typeof(System.Windows.Input.Key)).Length;

            for (int i = length; i-- > 0;)
            {
                if (Enum.IsDefined(typeof(System.Windows.Input.Key), i) && i != 0)
                {
                    bool isDown = System.Windows.Input.Keyboard.IsKeyDown((System.Windows.Input.Key)i);
                    if (isDown)
                    {
                        textToPutInBox += $"{((System.Windows.Input.Key)i).ToString()}+";
                    }
                }
            }

            if (textToPutInBox == null)
            {
                return "";
            }
            else if (textToPutInBox == "")
            {
                return "";
            }
            else
            {
                textToPutInBox = textToPutInBox.Replace("LeftAlt", "Alt");
                textToPutInBox = textToPutInBox.Replace("RightAlt", "Alt");

                textToPutInBox = textToPutInBox.Replace("LeftCtrl", "Ctrl");
                textToPutInBox = textToPutInBox.Replace("RightCtrl", "Ctrl");

                textToPutInBox = textToPutInBox.Replace("LeftShift", "Shift");
                textToPutInBox = textToPutInBox.Replace("RightShift", "Shift");

                textToPutInBox = textToPutInBox.Remove(textToPutInBox.Length - 1);
                textToPutInBox = textToPutInBox.Replace("Scroll", "ScrollLock");
                return textToPutInBox;
            }
        }
    }
}
