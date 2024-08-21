#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SkewTransform_MarkupExtensions
{
//================= Properties ======================//
 // AngleXProperty

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.SkewTransform.AngleXProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.SkewTransform.AngleXProperty, ps, () => control.AngleX = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, IBinding binding)
   => control._set(Avalonia.Media.SkewTransform.AngleXProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.SkewTransform.AngleXProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.SkewTransform AngleX<TValue>(this Avalonia.Media.SkewTransform control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.SkewTransform.AngleXProperty, ps, () => control.AngleX = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // AngleYProperty

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.SkewTransform.AngleYProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.SkewTransform.AngleYProperty, ps, () => control.AngleY = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, IBinding binding)
   => control._set(Avalonia.Media.SkewTransform.AngleYProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.SkewTransform.AngleYProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.SkewTransform AngleY<TValue>(this Avalonia.Media.SkewTransform control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.SkewTransform.AngleYProperty, ps, () => control.AngleY = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//

}