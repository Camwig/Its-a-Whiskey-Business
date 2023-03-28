using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentRoom : MonoBehaviour
{
    enum ThisRoom { Main_Room,Room1,Room2,Room3,Room4,Email};
    ThisRoom curr_room;

    public void SetRoom(int new_room)
    {
        curr_room = (ThisRoom)new_room;
    }

    public int GetRoom()
    {
        return (int)curr_room;
    }
}
