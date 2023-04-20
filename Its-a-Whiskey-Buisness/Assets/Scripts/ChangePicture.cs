using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePicture : MonoBehaviour
{
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;
    public GameObject image6;
    public GameObject image7;
    public GameObject image8;
    public GameObject Button;

    public GameObject currentImage;
    public GameObject NextImage;

    public int Imagenum;

    public Animator Changeimage;

    private int clickCount = 0;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            IfButtonClicked();
        }
    }

    private void Start()
    {
        Button.SetActive(false);

       StartCoroutine(OpenButton());
        
    }
    IEnumerator OpenButton()
    {
     yield return new WaitForSeconds(3f);

     Button.SetActive(true);
    }
    public void IfButtonClicked()
    {
         clickCount++;

        Button.SetActive(false);
        StartCoroutine(ChangeImage());

        if (clickCount > 7)
        {
           Button.SetActive(false);
            clickCount = 0;
            return;
        }      
    }

    IEnumerator ChangeImage()
    {
        Changeimage.SetTrigger("Start");
        yield return new WaitForSeconds(3f);
        Imagenum = Imagenum + 1;
        Button.SetActive(true);
    }

    public void ActivateImage2()
    {
            image1.SetActive(false);

    }
    public void ActivateImage3()
    {
  
            image2.SetActive(false);
 
    }
    public void ActivateImage4()
    {

            image3.SetActive(false);
 

    }
    public void ActivateImage5()
    {
            image4.SetActive(false);

    }
    public void ActivateImage6()
    {
            image5.SetActive(false);

    }
    public void ActivateImage7()
    {
            image6.SetActive(false);
    }
    public void ActivateImage8()
    {
       
            image7.SetActive(false);
        
    }

    public void DeactivatingScene()
    {
        currentImage.SetActive(false);
    }

}
