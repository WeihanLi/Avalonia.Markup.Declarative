using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class GeometryEventsExtensions
{
    public static T OnChanged<T>(this T control, Action action) where T : Geometry => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Changed += h);
}

