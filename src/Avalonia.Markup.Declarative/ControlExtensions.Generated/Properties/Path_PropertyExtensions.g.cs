#nullable enable
using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Path = Avalonia.Controls.Shapes.Path;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PathExtensions
{
public static T Data<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Path
   => control._set(Avalonia.Controls.Shapes.Path.DataProperty, binding);
public static T Data<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Path
   => control._set(Avalonia.Controls.Shapes.Path.DataProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Data<T>(this T control, Func<Avalonia.Media.Geometry> func, Action<Avalonia.Media.Geometry>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Path
   => control._set(Avalonia.Controls.Shapes.Path.DataProperty, func, onChanged, expression);
public static T Data<T>(this T control, Avalonia.Media.Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Path
=> control._setEx(Avalonia.Controls.Shapes.Path.DataProperty, ps, () => control.Data = value, bindingMode, converter, bindingSource);
public static T Data<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Path
=> control._setEx(Avalonia.Controls.Shapes.Path.DataProperty, ps, () => control.Data = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

