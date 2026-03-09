using Avalonia;
using Avalonia.Media;

namespace Kumo.Avalonia;

public enum GradientMappingMode
{
    RelativeToBoundingBox,
    Absolute,
}

public static class LinearGradientBrushExtension2
{
    extension(LinearGradientBrush brush)
    {
        public GradientMappingMode MappingMode
        {
            get => LinearGradientBrushExtension.GetMappingMode(brush);
            set => LinearGradientBrushExtension.SetMappingMode(brush, value);
        }
    }
}

public class LinearGradientBrushExtension
{
    public static readonly AttachedProperty<GradientMappingMode> MappingModeProperty =
        AvaloniaProperty.RegisterAttached<LinearGradientBrushExtension, LinearGradientBrush, GradientMappingMode>(
            "MappingMode",
            GradientMappingMode.RelativeToBoundingBox);

    static LinearGradientBrushExtension()
    {
        MappingModeProperty.Changed.AddClassHandler<LinearGradientBrush>((brush, args) =>
        {
            var mappingMode = args.GetNewValue<GradientMappingMode>();
            var unit = mappingMode == GradientMappingMode.Absolute
                ? RelativeUnit.Absolute
                : RelativeUnit.Relative;

            brush.StartPoint = new RelativePoint(brush.StartPoint.Point, unit);
            brush.EndPoint = new RelativePoint(brush.EndPoint.Point, unit);
        });
    }

    public static GradientMappingMode GetMappingMode(LinearGradientBrush brush) =>
        brush.GetValue(MappingModeProperty);

    public static void SetMappingMode(LinearGradientBrush brush, GradientMappingMode value) =>
        brush.SetValue(MappingModeProperty, value);
}
