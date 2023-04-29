using Exiled.API.Features;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace Test2.Handlers
{
    internal class CustomHint : MonoBehaviour
    {

        public async Task Hint(string text)
        {
            List<string> alphaTags = new List<string>()
            {
                "<alpha=#FF>",
                "<alpha=#CC>",
                "<alpha=#AA>",
                "<alpha=#88>",
                "<alpha=#66>",
                "<alpha=#44>",
                "<alpha=#22>",
                "<alpha=#00>"
            };
        
            
            if (!string.IsNullOrEmpty(text))
            {
                for (int i = 0; i < alphaTags.Count; i++)
                {
                    
                    Exiled.API.Features.Map.ShowHint($"{alphaTags[i]}{text}", 40);
                    Log.Info(i + alphaTags[i]);
                    await Task.Delay(200);
                }
            }
        }
    }
}