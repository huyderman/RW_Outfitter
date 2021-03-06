﻿using System;
using System.Reflection;

namespace Outfitter
{

    [AttributeUsage(AttributeTargets.Method)]
    internal class DetourAttribute : Attribute
    {
        public readonly Type source;
        public BindingFlags bindingFlags;

        public DetourAttribute(Type source)
        {
            this.source = source;
        }
    }

}