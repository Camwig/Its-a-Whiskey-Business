using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialChangingScript : MonoBehaviour
{
    public GameObject[] activatingImages;
    public GameObject[] deactivatingImages;

    public void MoveToScene()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(0);

        for (int i = 0; i < activatingImages.Length; i++)
        {
            activatingImages[i].SetActive(true);
        }

        for (int i = 0; i < deactivatingImages.Length; i++)
        {
            deactivatingImages[i].SetActive(false);
        }
    }

    public void ActivatingScene()
    {
        for (int i = 0; i < activatingImages.Length; i++)
        {
            activatingImages[i].SetActive(true);
        }
    }

    public void DeactivatingScene()
    {
        for (int i = 0; i < deactivatingImages.Length; i++)
        {
            deactivatingImages[i].SetActive(false);
        }
    }
}