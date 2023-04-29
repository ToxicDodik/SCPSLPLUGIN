using Exiled.API.Features;
using Exiled.Events.EventArgs.Map;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test2.Handlers
{
    internal class Map
    {
        CustomHint custom = new CustomHint();
        public void OnDecontaminating(DecontaminatingEventArgs ev)
        {
            string text = "Лёгкая зона закрыта";
            custom.Hint(text);
        }
        public async void OnGeneratorActivated(GeneratorActivatedEventArgs ev)
        {
            string text = "Генератор активирован";
            await custom.Hint(text);
        }
    }
}
