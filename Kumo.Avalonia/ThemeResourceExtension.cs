using Avalonia.Metadata;

[assembly: XmlnsDefinition("https://github.com/avaloniaui", "Avalonia.Markup.Xaml.MarkupExtensions")]

#pragma warning disable IDE0130 // 命名空间与文件夹结构不匹配
namespace Avalonia.Markup.Xaml.MarkupExtensions;

public class ThemeResourceExtension : DynamicResourceExtension
{
    public ThemeResourceExtension() { }
    public ThemeResourceExtension(string resourceKey) : base(resourceKey) { }
}
