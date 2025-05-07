using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//Cameron Wiggan

//Sets up a class object based on the UnityEvent System
[System.Serializable]
public class CustomGameEvent : UnityEvent<Component, object> {}

public class EventListener : MonoBehaviour
{
    //Initialises the approipriate eventsystem event
    public EventSytem gameEvent;

    //Also initialises a version of the custom game event (Appropriate function to be invoked)
    public CustomGameEvent response;

    //When the evnt listener script is enabled it registers this listener to the appropriate event
    private void OnEnable()
    {
        gameEvent.RegisterListener(this);
    }

    //When the evnt listener script is disabled it unregisters this listener from the appropriate event
    private void OnDisable()
    {
        gameEvent.UnRegisterListener(this);
    }

    //Invokes the response of the appropriate function
    public void OnEventRaised(Component sender,object data)
    {
        response.Invoke(sender,data);
    }
}
