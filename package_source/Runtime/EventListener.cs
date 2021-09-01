using UnityEngine;
using UnityEngine.Events;

namespace GalalHassan.EventsManager
{
    public class EventListener : MonoBehaviour
    {
        public GameEvent gameEvent;
        
        public UnityEvent<EventParameters> eventResponse = new UnityEvent<EventParameters>();

        private void OnEnable()
        {
            if (gameEvent == null) return;
                
            gameEvent.Register(this);
        }

        private void OnDisable()
        {
            if (gameEvent == null) return;
                
            gameEvent.Deregister(this);
        }

        private void OnDestroy()
        {
            if (gameEvent == null) return;
                
            gameEvent.Deregister(this);
        }
       
        public void EventRaised(EventParameters callerParameters)
        {
            eventResponse.Invoke(callerParameters);
        }
    }
}