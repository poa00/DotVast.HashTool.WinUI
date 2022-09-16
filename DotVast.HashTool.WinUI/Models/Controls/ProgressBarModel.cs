namespace DotVast.HashTool.WinUI.Models.Controls;

public partial class ProgressBarModel : ObservableObject
{
    [ObservableProperty]
    private double _min;

    [ObservableProperty]
    private double _max;

    [ObservableProperty]
    private double _val;
}