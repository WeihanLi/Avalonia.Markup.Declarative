#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Avalonia.Media;
using ComboBox = Avalonia.Controls.ComboBox;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ComboBoxExtensions
{
public static T IsDropDownOpen<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.IsDropDownOpenProperty, binding);
public static T IsDropDownOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.IsDropDownOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsDropDownOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.IsDropDownOpenProperty, func, onChanged, expression);
public static T IsDropDownOpen<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ComboBox
=> control._setEx(Avalonia.Controls.ComboBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = value, bindingMode, converter, bindingSource);
public static T IsDropDownOpen<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ComboBox
=> control._setEx(Avalonia.Controls.ComboBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxDropDownHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty, binding);
public static T MaxDropDownHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxDropDownHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty, func, onChanged, expression);
public static T MaxDropDownHeight<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ComboBox
=> control._setEx(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = value, bindingMode, converter, bindingSource);
public static T MaxDropDownHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ComboBox
=> control._setEx(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlaceholderText<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.PlaceholderTextProperty, binding);
public static T PlaceholderText<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.PlaceholderTextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PlaceholderText<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.PlaceholderTextProperty, func, onChanged, expression);
public static T PlaceholderText<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ComboBox
=> control._setEx(Avalonia.Controls.ComboBox.PlaceholderTextProperty, ps, () => control.PlaceholderText = value, bindingMode, converter, bindingSource);
public static T PlaceholderText<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ComboBox
=> control._setEx(Avalonia.Controls.ComboBox.PlaceholderTextProperty, ps, () => control.PlaceholderText = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlaceholderForeground<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty, binding);
public static T PlaceholderForeground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PlaceholderForeground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty, func, onChanged, expression);
public static T PlaceholderForeground<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ComboBox
=> control._setEx(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty, ps, () => control.PlaceholderForeground = value, bindingMode, converter, bindingSource);
public static T PlaceholderForeground<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ComboBox
=> control._setEx(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty, ps, () => control.PlaceholderForeground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty, binding);
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty, func, onChanged, expression);
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ComboBox
=> control._setEx(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static T HorizontalContentAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ComboBox
=> control._setEx(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty, binding);
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty, func, onChanged, expression);
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ComboBox
=> control._setEx(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static T VerticalContentAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ComboBox
=> control._setEx(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionBoxItemTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty, binding);
public static T SelectionBoxItemTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionBoxItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ComboBox
   => control._set(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty, func, onChanged, expression);
public static T SelectionBoxItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ComboBox
=> control._setEx(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty, ps, () => control.SelectionBoxItemTemplate = value, bindingMode, converter, bindingSource);
public static T SelectionBoxItemTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ComboBox
=> control._setEx(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty, ps, () => control.SelectionBoxItemTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

