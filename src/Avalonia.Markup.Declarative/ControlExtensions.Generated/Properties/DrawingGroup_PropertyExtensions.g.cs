#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using DrawingGroup = Avalonia.Media.DrawingGroup;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DrawingGroupExtensions
{
public static Avalonia.Media.DrawingGroup Opacity(this Avalonia.Media.DrawingGroup control, IBinding binding)
   => control._set(Avalonia.Media.DrawingGroup.OpacityProperty, binding);
public static Avalonia.Media.DrawingGroup Opacity(this Avalonia.Media.DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.DrawingGroup.OpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.DrawingGroup Opacity(this Avalonia.Media.DrawingGroup control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.DrawingGroup.OpacityProperty, func, onChanged, expression);
public static Avalonia.Media.DrawingGroup Opacity(this Avalonia.Media.DrawingGroup control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DrawingGroup.OpacityProperty, ps, () => control.Opacity = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.DrawingGroup Opacity<TValue>(this Avalonia.Media.DrawingGroup control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DrawingGroup.OpacityProperty, ps, () => control.Opacity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Media.DrawingGroup Transform(this Avalonia.Media.DrawingGroup control, IBinding binding)
   => control._set(Avalonia.Media.DrawingGroup.TransformProperty, binding);
public static Avalonia.Media.DrawingGroup Transform(this Avalonia.Media.DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.DrawingGroup.TransformProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.DrawingGroup Transform(this Avalonia.Media.DrawingGroup control, Func<Avalonia.Media.Transform> func, Action<Avalonia.Media.Transform>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.DrawingGroup.TransformProperty, func, onChanged, expression);
public static Avalonia.Media.DrawingGroup Transform(this Avalonia.Media.DrawingGroup control, Avalonia.Media.Transform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DrawingGroup.TransformProperty, ps, () => control.Transform = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.DrawingGroup Transform<TValue>(this Avalonia.Media.DrawingGroup control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Transform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DrawingGroup.TransformProperty, ps, () => control.Transform = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Media.DrawingGroup ClipGeometry(this Avalonia.Media.DrawingGroup control, IBinding binding)
   => control._set(Avalonia.Media.DrawingGroup.ClipGeometryProperty, binding);
public static Avalonia.Media.DrawingGroup ClipGeometry(this Avalonia.Media.DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.DrawingGroup.ClipGeometryProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.DrawingGroup ClipGeometry(this Avalonia.Media.DrawingGroup control, Func<Avalonia.Media.Geometry> func, Action<Avalonia.Media.Geometry>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.DrawingGroup.ClipGeometryProperty, func, onChanged, expression);
public static Avalonia.Media.DrawingGroup ClipGeometry(this Avalonia.Media.DrawingGroup control, Avalonia.Media.Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DrawingGroup.ClipGeometryProperty, ps, () => control.ClipGeometry = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.DrawingGroup ClipGeometry<TValue>(this Avalonia.Media.DrawingGroup control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DrawingGroup.ClipGeometryProperty, ps, () => control.ClipGeometry = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Media.DrawingGroup OpacityMask(this Avalonia.Media.DrawingGroup control, IBinding binding)
   => control._set(Avalonia.Media.DrawingGroup.OpacityMaskProperty, binding);
public static Avalonia.Media.DrawingGroup OpacityMask(this Avalonia.Media.DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.DrawingGroup.OpacityMaskProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.DrawingGroup OpacityMask(this Avalonia.Media.DrawingGroup control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.DrawingGroup.OpacityMaskProperty, func, onChanged, expression);
public static Avalonia.Media.DrawingGroup OpacityMask(this Avalonia.Media.DrawingGroup control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DrawingGroup.OpacityMaskProperty, ps, () => control.OpacityMask = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.DrawingGroup OpacityMask<TValue>(this Avalonia.Media.DrawingGroup control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DrawingGroup.OpacityMaskProperty, ps, () => control.OpacityMask = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Media.DrawingGroup Children(this Avalonia.Media.DrawingGroup control, IBinding binding)
   => control._set(Avalonia.Media.DrawingGroup.ChildrenProperty, binding);
public static Avalonia.Media.DrawingGroup Children(this Avalonia.Media.DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.DrawingGroup.ChildrenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.DrawingGroup Children(this Avalonia.Media.DrawingGroup control, Func<Avalonia.Media.DrawingCollection> func, Action<Avalonia.Media.DrawingCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.DrawingGroup.ChildrenProperty, func, onChanged, expression);
public static Avalonia.Media.DrawingGroup Children(this Avalonia.Media.DrawingGroup control, Avalonia.Media.DrawingCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DrawingGroup.ChildrenProperty, ps, () => control.Children = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.DrawingGroup Children<TValue>(this Avalonia.Media.DrawingGroup control, TValue value, FuncValueConverter<TValue, Avalonia.Media.DrawingCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DrawingGroup.ChildrenProperty, ps, () => control.Children = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

