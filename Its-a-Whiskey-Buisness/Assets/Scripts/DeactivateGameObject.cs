using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class DeactivateGameObject : MonoBehaviour
{
    public GameObject[] objectsToDeactivate;

    private void Start()
    {
        DeactivateObjects();
    }

    public void DeactivateObjects()
    {
        for (int i = 0; i < objectsToDeactivate.Length; i++)
        {
            objectsToDeactivate[i].SetActive(false);
        }
    }
}
