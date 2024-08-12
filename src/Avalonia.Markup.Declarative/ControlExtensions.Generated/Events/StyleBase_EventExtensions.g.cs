using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Styling;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class StyleBaseEventsExtensions
{
    public static T OnOwnerChanged<T>(this T control, Action action) where T : StyleBase => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.OwnerChanged += h);
}

