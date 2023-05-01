using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentRoom : MonoBehaviour
{
    //This is used to track the current state the player is in
    //i.e. what room they are currently in

    //Enumerator for the type of room the player occupies
    enum ThisRoom { Main_Room,Room1,Room2,Room3,Room4,Email};
    ThisRoom curr_room;

    //Function to set the room we are occupying
    public void SetRoom(int new_room)
    {
        curr_room = (ThisRoom)new_room;
    }

    //Returns the ThisRoom state
    public int GetRoom()
    {
        return (int)curr_room;
    }
}
