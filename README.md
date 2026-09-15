# WinUI 1.8
1. Default 主题是 Dark，一般有 Default Light HighContrast 三大主题（资源字典），在 `<ResourceDictionary.ThemeDictionaries>` 下定义
2. WinUI 的窗口背景是 `SolidBackgroundFillColorBase`。即黑色主题下，窗口背景默认为 `#202020`。白色主题下，窗口背景默认为 `#F3F3F3`。

# 映射

https://github.com/microsoft/microsoft-ui-xaml/tree/winui3/release/1.8.5/src/controls/dev/CommonStyles

* `dev/dll/DensityStyles/Compact.xaml` -> `Compact.axmal`
* WIP `dev/CommonStyles/CornerRadius_themeresources.xaml` -> `CornerRadius.axmal`
* WIP `dev/CommonStyles/Common_themeresources.xaml` -> `Common.axmal`
* WIP `dev/CommonStyles/Common_themeresources_any.xaml` -> `CommonAny.axmal`
* WIP `dev/CommonStyles/Button_themeresources.xaml` -> `Button.axmal`

# 必须的修改
`xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"` -> `xmlns="https://github.com/avaloniaui"`

`<Style>` -> `<ControlTheme x:Key="{x:Type Xxx}" ...>`

Avalonia 不支持 `HighContrast`，必须得引入 `xmlns:kumo="using:Kumo.Avalonia"` `x:Key="{x:Static kumo:KumoTheme.HighContrast}"`

> 注意从 github 直接复制文件过来可能附带隐藏的 BOM 头 `ef bb bf`，点击 row 后复制更安全

# 为啥想要这个

出发点是，能在 windows 7 上运行的还在维护的 gui，除了 web 类，只有 avalonia 了。

dotnet 在 win7 上 aot 运行得很好。

fluent avalonia 也不耐，但是总是觉得卡卡的。 想要手搓一个对齐 winui 的 ui，保持风格一致

不过既然是win7了，也许 https://github.com/Splitwirez/aero-theme-for-avalonia 就已经足够，做一个纯 win 7 风格的应用

加之不再想写 xaml，想要一个对齐 https://github.com/microsoft/microsoft-ui-reactor 的 dsl

俩个东西，不论是 ai 帮忙还是手搓感觉都是 massive work。

不过既然都 ai 了

https://github.com/fsprojects/Avalonia.FuncUI

也是可以考虑的，唯一顾虑是 fsharp 仍旧 aot 警告？https://github.com/fsharp/fslang-suggestions/issues/919

fsharp 的维护越来越少了，为了避免警告，jit 也是可以考虑的，因为现在我接受了 Updater 帮助安装 dotnet 运行时的结构，那个安装器就算了不喜欢包一层。

或者自定义的那个 bootstrap 安装器，也无需 Updater（可以仅用于升级不负责装 runtime？）

算下来的话、自己去搞一个工具，除非足够简单，否则直接去用现成的似乎更划算。更能够专注于业务。
