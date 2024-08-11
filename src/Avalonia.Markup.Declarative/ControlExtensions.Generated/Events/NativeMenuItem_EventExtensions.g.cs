using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class NativeMenuItemEventsExtensions
{
    public static T OnClick<T>(this T control, Action action) where T : NativeMenuItem => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Click += h);
}

