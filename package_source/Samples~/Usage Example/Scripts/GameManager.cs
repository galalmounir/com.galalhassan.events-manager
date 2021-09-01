using GalalHassan.EventsManager;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void Awake()
    {
        EventsManager.Init();
    }
    
    public void Start(){
        EventsManager.RaiseEvent("GameStarted", new EventParameters(4, gameObject));
    }

    public void OnGameStartedEvent(EventParameters parameters)
    {
        Debug.Log(parameters.InvokerInteger);
    }
}