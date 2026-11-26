namespace Avalonia.Metal;

/// <summary>
/// Options for the Metal renderer on macOS.
/// </summary>
public class MetalOptions
{
    /// <summary>
    /// Gets or sets whether rendering should use the discrete GPU on Macs that have both an integrated
    /// and a discrete GPU. Defaults to <c>false</c>: the integrated GPU is used, so the discrete GPU
    /// isn't kept powered on just to draw the UI.
    /// </summary>
    /// <remarks>
    /// Has no effect on Macs with a single GPU, which includes all Apple silicon Macs.
    /// </remarks>
    public bool PreferDiscreteGpu { get; set; }
}
