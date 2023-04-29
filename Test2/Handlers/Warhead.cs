using Exiled.API.Features;
using Exiled.Events.EventArgs.Warhead;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test2.Handlers
{
    internal class Warhead : MonoBehaviour
    {
        CustomHint custom = new CustomHint();
        public void OnDetonated()
        {
            string text = "Альфа боеголвка была взорвана";
            custom.Hint(text);
        }

        public void OnStarting(StartingEventArgs ev)
        {
            string text = "Альва боеголовка была запущена";

            custom.Hint(text);
          
        }

        public void OnStopping(StoppingEventArgs ev)
        {
            string text = "Альва боеголовка была отменена";
            custom.Hint(text);

        }
        public void OnChangingLeverStatus(ChangingLeverStatusEventArgs ev)
        {
            Log.Info(ev.CurrentState);
            string text = "ev";;
            custom.Hint(text);
        }


    }
}