using Hints;
using UnityEngine;

namespace Test2.Handlers
{
    internal class ColorHintEffect : HintEffect
    {
        private Color color;
        private float duration;

        public ColorHintEffect(Color color, float duration)
        {
            this.color = color;
            this.duration = duration;
        }
    }
}