#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Styling;
using MenuFlyout = Avalonia.Controls.MenuFlyout;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class MenuFlyoutExtensions
{
public static T ItemsSource<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuFlyout
   => control._set(Avalonia.Controls.MenuFlyout.ItemsSourceProperty, binding);
public static T ItemsSource<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuFlyout
   => control._set(Avalonia.Controls.MenuFlyout.ItemsSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemsSource<T>(this T control, Func<System.Collections.IEnumerable> func, Action<System.Collections.IEnumerable>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MenuFlyout
   => control._set(Avalonia.Controls.MenuFlyout.ItemsSourceProperty, func, onChanged, expression);
public static T ItemsSource<T>(this T control, System.Collections.IEnumerable value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuFlyout
=> control._setEx(Avalonia.Controls.MenuFlyout.ItemsSourceProperty, ps, () => control.ItemsSource = value, bindingMode, converter, bindingSource);
public static T ItemsSource<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.IEnumerable> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuFlyout
=> control._setEx(Avalonia.Controls.MenuFlyout.ItemsSourceProperty, ps, () => control.ItemsSource = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuFlyout
   => control._set(Avalonia.Controls.MenuFlyout.ItemTemplateProperty, binding);
public static T ItemTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuFlyout
   => control._set(Avalonia.Controls.MenuFlyout.ItemTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MenuFlyout
   => control._set(Avalonia.Controls.MenuFlyout.ItemTemplateProperty, func, onChanged, expression);
public static T ItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuFlyout
=> control._setEx(Avalonia.Controls.MenuFlyout.ItemTemplateProperty, ps, () => control.ItemTemplate = value, bindingMode, converter, bindingSource);
public static T ItemTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuFlyout
=> control._setEx(Avalonia.Controls.MenuFlyout.ItemTemplateProperty, ps, () => control.ItemTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemContainerTheme<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuFlyout
   => control._set(Avalonia.Controls.MenuFlyout.ItemContainerThemeProperty, binding);
public static T ItemContainerTheme<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuFlyout
   => control._set(Avalonia.Controls.MenuFlyout.ItemContainerThemeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemContainerTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme> func, Action<Avalonia.Styling.ControlTheme>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MenuFlyout
   => control._set(Avalonia.Controls.MenuFlyout.ItemContainerThemeProperty, func, onChanged, expression);
public static T ItemContainerTheme<T>(this T control, Avalonia.Styling.ControlTheme value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuFlyout
=> control._setEx(Avalonia.Controls.MenuFlyout.ItemContainerThemeProperty, ps, () => control.ItemContainerTheme = value, bindingMode, converter, bindingSource);
public static T ItemContainerTheme<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Styling.ControlTheme> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuFlyout
=> control._setEx(Avalonia.Controls.MenuFlyout.ItemContainerThemeProperty, ps, () => control.ItemContainerTheme = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FlyoutPresenterTheme<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuFlyout
   => control._set(Avalonia.Controls.MenuFlyout.FlyoutPresenterThemeProperty, binding);
public static T FlyoutPresenterTheme<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuFlyout
   => control._set(Avalonia.Controls.MenuFlyout.FlyoutPresenterThemeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FlyoutPresenterTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme> func, Action<Avalonia.Styling.ControlTheme>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MenuFlyout
   => control._set(Avalonia.Controls.MenuFlyout.FlyoutPresenterThemeProperty, func, onChanged, expression);
public static T FlyoutPresenterTheme<T>(this T control, Avalonia.Styling.ControlTheme value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuFlyout
=> control._setEx(Avalonia.Controls.MenuFlyout.FlyoutPresenterThemeProperty, ps, () => control.FlyoutPresenterTheme = value, bindingMode, converter, bindingSource);
public static T FlyoutPresenterTheme<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Styling.ControlTheme> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuFlyout
=> control._setEx(Avalonia.Controls.MenuFlyout.FlyoutPresenterThemeProperty, ps, () => control.FlyoutPresenterTheme = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

