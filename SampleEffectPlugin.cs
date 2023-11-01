using System.Drawing;

public class SampleImageEffectPlugin : IImageEffect
{
    public string Name => "SampleEffect";

    public void ApplyEffect(Bitmap image, Dictionary<string, string> parameters)
    {
        // Implement your image effect logic here.
        // You can access the image and apply various transformations.
    }
}