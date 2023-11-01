using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;

public interface IImageEffect
{
    string Name { get; }
    void ApplyEffect(Bitmap image, Dictionary<string, string> parameters);
}

public class ImageEffectPluginFramework
{
    private List<IImageEffect> availableEffects = new List<IImageEffect>();

    public void LoadEffectsFromAssembly(string assemblyPath)
    {
        Assembly assembly = Assembly.LoadFrom(assemblyPath);

        foreach (Type type in assembly.GetTypes())
        {
            if (typeof(IImageEffect).IsAssignableFrom(type) && !type.IsInterface)
            {
                IImageEffect effect = (IImageEffect)Activator.CreateInstance(type);
                availableEffects.Add(effect);
            }
        }
    }

    public List<IImageEffect> GetAvailableEffects()
    {
        return availableEffects;
    }
}