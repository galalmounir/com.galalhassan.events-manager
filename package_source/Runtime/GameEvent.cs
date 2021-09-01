using System.Collections.Generic;
using UnityEngine;

namespace GalalHassan.EventsManager
{
    [CreateAssetMenu(menuName = "Events/Game Event")]
    public class GameEvent : ScriptableObject
    {
        public List<EventListener> eventListeners = new List<EventListener>();
        
        public void Raise(EventParameters parameters)
        {
            foreach (var eventListener in eventListeners)
            {
                eventListener.EventRaised(parameters);
            }
        }
        
        public void Register(EventListener listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void Deregister(EventListener listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }
}