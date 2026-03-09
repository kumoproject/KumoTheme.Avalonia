using Avalonia.Metadata;
using Avalonia.Styling;

[assembly: XmlnsDefinition("https://github.com/avaloniaui", "Avalonia")]

#pragma warning disable IDE0130 // 命名空间与文件夹结构不匹配
namespace Avalonia;

internal static class VariantTheme
{
    public static readonly ThemeVariant HighContrast = new(nameof(HighContrast), ThemeVariant.Light);
}
