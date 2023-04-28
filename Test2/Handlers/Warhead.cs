using Exiled.API.Features;
using Exiled.Events.EventArgs.Warhead;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Enums;
using static Utils.Networking.HintReaderWriter;
using Hints;
using UnityEngine;

namespace Test2.Handlers
{
    
    internal class Warhead
    {
        public void OnDetonated()
        {

            Log.Info("The Alpha Warhead has detonated!");
        }

        public void OnStarting(StartingEventArgs ev)
        {

           
            ev.Player.ReferenceHub.hints.Show(new TextHint($"<color=#aabbcc00>текст будет невидимым</color>"));
                
               
          
            
            Log.Info("Альва боеголовка была запущена");
        }

        public void OnStopping(StoppingEventArgs ev)
        {
           
            Log.Info("Альва боеголовка была отменена");
            
          
        }
        public void OnChangingLeverStatus(ChangingLeverStatusEventArgs ev) {
            Log.Info(ev.CurrentState);
        }
    
    }
  
}
