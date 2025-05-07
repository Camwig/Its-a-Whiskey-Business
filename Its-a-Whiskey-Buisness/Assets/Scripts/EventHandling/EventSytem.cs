using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Cameron Wiggan

//Creates an asset of this object
[CreateAssetMenu(menuName = "GameEvent")]

public class EventSytem : ScriptableObject
{
    //Contains a list of listeners that are waiting for this event to be invoked
    public List<EventListener> Listeners = new List<EventListener>();

    //Raise function loops through all the listeners and invokes them
    public void Raise(Component sender, object data)
    {
        for (int i=0; i < Listeners.Count;i++)
        {
            if (Listeners[i] != null)
            {
                Listeners[i].OnEventRaised(sender,data);
            }
        }
    }

    internal void Raise(Interactables interactables)
    {
        throw new NotImplementedException();
    }

    //Registers a listner into the event (adds listener to this events list of listeners)
    public void RegisterListener(EventListener listener)
    {
        if (!Listeners.Contains(listener))
            Listeners.Add(listener);
    } 
    
    //Unregisters a lister from the event (removes the listener from this list of listeners)
    public void UnRegisterListener(EventListener listener)
    {
        if (Listeners.Contains(listener))
            Listeners.Remove(listener);
    }
}
