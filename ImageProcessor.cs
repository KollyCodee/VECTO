using System.Drawing;

public class ImageProcessor
{
    private ImageEffectPluginFramework pluginFramework = new ImageEffectPluginFramework();

    public ImageProcessor(string pluginAssemblyPath)
    {
        pluginFramework.LoadEffectsFromAssembly(pluginAssemblyPath);
    }

    public void ApplyEffects(Bitmap image, List<IImageEffect> effects)
    {
        foreach (var effect in effects)
        {
            var matchingEffect = pluginFramework.GetAvailableEffects().FirstOrDefault(e => e.Name == effect.Name);
            if (matchingEffect != null)
            {
                matchingEffect.ApplyEffect(image, effect.Parameters);
            }
        }
    }
}