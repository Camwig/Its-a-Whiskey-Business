using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLogo : MonoBehaviour
{

    public int SceneID;


    public GameObject movie;

    void Start()
    {
        StartCoroutine(streamVideo(1));
    }

    private IEnumerator streamVideo(int video)
    {
      
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene(SceneID);
    }
}

