﻿using System;

namespace L2dotNET.GameService.Plugins
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PluginAttribute : Attribute
    {
        public string PluginName;
        public string Description;
        public string PluginVersion;
        public string Author;
    }
}