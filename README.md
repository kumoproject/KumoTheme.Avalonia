# WinUI 1.8
1. Default 主题是 Dark，一般有 Default Light HighContrast 三大主题（资源字典），在 `<ResourceDictionary.ThemeDictionaries>` 下定义
2. WinUI 的窗口背景是 `SolidBackgroundFillColorBase`。即黑色主题下，窗口背景默认为 `#202020`。白色主题下，窗口背景默认为 `#F3F3F3`。

# 映射

* `dev/dll/DensityStyles/Compact.xaml` -> `Compact.axmal`
* WIP `dev/CommonStyles/Common_themeresources_any.xaml` -> `CommonAny.axmal`
* WIP `dev/CommonStyles/CornerRadius_themeresources.xaml` -> `CornerRadius.axmal`
* WIP `dev/CommonStyles/Button_themeresources.xaml` -> `Button.axmal`

# 必须的修改
`xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"` -> `xmlns="https://github.com/avaloniaui"`

`<Style>` -> `<ControlTheme x:Key="{x:Type Xxx}" ...>`

Avalonia 不支持 `HighContrast`，必须得引入 `xmlns:kumo="using:Kumo.Avalonia"` `x:Key="{x:Static kumo:KumoTheme.HighContrast}"`

> 注意从 github 直接复制文件过来可能附带隐藏的 BOM 头 `ef bb bf`，点击 row 后复制更安全