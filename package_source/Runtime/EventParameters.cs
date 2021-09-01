using UnityEngine;

namespace GalalHassan.EventsManager
{
    public class EventParameters
    {
        public int InvokerInteger;
        public GameObject InvokerGameObject;
        
        public EventParameters(int integerEventValue = default, GameObject gameObjectEventValue = default)
        {
            InvokerInteger = integerEventValue;
            InvokerGameObject = gameObjectEventValue;
        }
    }
}