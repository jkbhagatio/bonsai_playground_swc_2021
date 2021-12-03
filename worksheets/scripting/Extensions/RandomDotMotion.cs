using Bonsai;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using Bonsai.Shaders;
using OpenTK;

[Combinator]
[Description("Creates and updates the state of a random dot kinematogram.")]
[WorkflowElementCategory(ElementCategory.Transform)]
public class RandomDotMotion
{
    [Description("The number of dots in the random dot kinematogram.")]
    public int DotCount { get; set; }

    [Range(-Math.PI, Math.PI)]
    [TypeConverter("BonVision.DegreeConverter, BonVision")]
    [Editor(DesignTypes.SliderEditor, DesignTypes.UITypeEditor)]

    [Description("The direction of movement for coherent dots.")]
    public float Direction { get; set; }

    [Range(0, 1)]
    [Editor(DesignTypes.SliderEditor, DesignTypes.UITypeEditor)]
    [Description("The proportion of dots which move together in the coherent direction.")]
    public float Coherence { get; set; }

    [Description("The number of frames that elapse before a dot disappears and reappears.")]
    public int DotLifetime { get; set; }

    [Description("The speed of each dot.")]
    public float Speed { get; set; }

    public IObservable<Vector2[]> Process(IObservable<FrameEvent> source)
    {
        return Observable.Defer(() =>
        {
            var random = new Random();
            Vector2[] previous = null;
            return source.Select(value =>
            {
                var current = new Vector2[DotCount];
                for (int i = 0; i < current.Length; i++)
                {
                    do
                    {
                        // take points uniformly distributed in the unit circle
                        current[i].X = (float)random.NextDouble() * 2 - 1;
                        current[i].Y = (float)random.NextDouble() * 2 - 1;
                    } while (current[i].LengthSquared > 1);
                }
                previous = current;
                return current;
            });
        });
    }
}
