﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace imageDeCap
{
    public static class Utilities
    {
        public static bool IsWindows10()
        {
            var reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
            string productName = (string)reg.GetValue("ProductName");
            return productName.StartsWith("Windows 10");
        }

        public static void playSound(string soundName)
        {
            if (!imageDeCap.Preferences.DisableSoundEffects)
            {
                SoundPlayer sp = null;
                if (soundName.Contains("snip") && File.Exists(Preferences.SnipSoundPath))
                {
                    sp = new SoundPlayer(Preferences.SnipSoundPath);
                }
                else if(soundName.Contains("upload") && File.Exists(Preferences.UploadSoundPath))
                {
                    sp = new SoundPlayer(Preferences.UploadSoundPath);
                }
                else if (soundName.Contains("error") && File.Exists(Preferences.ErrorSoundPath))
                {
                    sp = new SoundPlayer(Preferences.ErrorSoundPath);
                }
                else
                {
                    string soundPath = "imageDeCap.Sounds." + soundName;
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Stream soundResource = assembly.GetManifestResourceStream(soundPath);
                    sp = new SoundPlayer(soundResource);
                }

                if(sp != null)
                {
                    sp.Play();
                }
            }
        }

    }
}
