using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public GameObject Room1cam;
    public GameObject Room2cam;
    public GameObject Room3cam;
    public GameObject Room4cam;
    public GameObject Emailcam;
    public GameObject Maincam;

    public AK.Wwise.Event MainAudio;
    public AK.Wwise.Event Room1Audio;
    public AK.Wwise.Event Room2Audio;
    public AK.Wwise.Event Room3Audio;
    public AK.Wwise.Event Room4Audio;

    void Start()
    {
        MainAudio.Post(gameObject);
    }

    public void ActivatingRoom1Cam()
    { 
        Room1cam.SetActive(true);
        Room2cam.SetActive(false);
        Room3cam.SetActive(false);
        Room4cam.SetActive(false);
        Emailcam.SetActive(false);
        Maincam.SetActive(false);

        Room1Audio.Post(gameObject);

        Room2Audio.Stop(gameObject);
        Room3Audio.Stop(gameObject);
        Room4Audio.Stop(gameObject);
        MainAudio.Stop(gameObject);

    }

    public void ActivatingRoom2Cam()
    {
        Room2cam.SetActive(true);
        Room1cam.SetActive(false);
        Room3cam.SetActive(false);
        Room4cam.SetActive(false);
        Emailcam.SetActive(false);
        Maincam.SetActive(false);

        Room2Audio.Post(gameObject);

        Room1Audio.Stop(gameObject);
        Room3Audio.Stop(gameObject);
        Room4Audio.Stop(gameObject);
        MainAudio.Stop(gameObject);

    }

    public void ActivatingRoom3Cam()
    {
        Room3cam.SetActive(true);
        Room2cam.SetActive(false);
        Room1cam.SetActive(false);
        Room4cam.SetActive(false);
        Emailcam.SetActive(false);
        Maincam.SetActive(false);

        Room3Audio.Post(gameObject);

        Room1Audio.Stop(gameObject);
        Room2Audio.Stop(gameObject);
        Room4Audio.Stop(gameObject);
        MainAudio.Stop(gameObject);

    }

    public void ActivatingRoom4Cam()
    {
        Room4cam.SetActive(true);
        Room3cam.SetActive(false);
        Room2cam.SetActive(false);
        Room1cam.SetActive(false);
        Emailcam.SetActive(false);
        Maincam.SetActive(false);

        Room4Audio.Post(gameObject);

        Room1Audio.Stop(gameObject);
        Room2Audio.Stop(gameObject);
        Room3Audio.Stop(gameObject);
        MainAudio.Stop(gameObject);

    }

    public void ActivatingEmailCam()
    {
        Emailcam.SetActive(true);
        Room1cam.SetActive(false);
        Room2cam.SetActive(false);
        Room3cam.SetActive(false);
        Room4cam.SetActive(false);
        Maincam.SetActive(false);

        Room1Audio.Stop(gameObject);
        Room2Audio.Stop(gameObject);
        Room3Audio.Stop(gameObject);
        Room4Audio.Stop(gameObject);
        MainAudio.Stop(gameObject);
    }

    public void ActivatingMainCam()
    {
        Maincam.SetActive(true);
        Room1cam.SetActive(false);
        Room2cam.SetActive(false);
        Room3cam.SetActive(false);        
        Room4cam.SetActive(false);
        Emailcam.SetActive(false);

        MainAudio.Post(gameObject);

        Room1Audio.Stop(gameObject);
        Room2Audio.Stop(gameObject);
        Room3Audio.Stop(gameObject);
        Room4Audio.Stop(gameObject);

    }

}
