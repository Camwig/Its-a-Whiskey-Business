using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public Animator transition;

    public float transitionTime = 0f;

   // public LevelLoader new_loader;

    //public int SceneID;

    public GameObject cam1;
    public GameObject cam2;

    public GameObject pauseButton;
    public GameObject pauseButton2;

    public void MoveToScene()
    {
        StartCoroutine(LoadLevel(1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        cam1.SetActive(true);
        cam2.SetActive(false);

        pauseButton.SetActive(true);
        pauseButton2.SetActive(false);

    }

}
