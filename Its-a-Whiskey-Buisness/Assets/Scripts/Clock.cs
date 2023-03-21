using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Clock : MonoBehaviour
{
    //Listen Im sorry but Im going to fuck with your code
    //I will highlight what I changed.

    private float timeDuration = 9f * 60f;
    private float timer;

    private bool holder = true;

    [SerializeField]
    private TextMeshProUGUI TextTimer;

    //--------------------------
    float hours;
    float minutes;
    //--------------------------

    // Start is called before the first frame update
    void Start()
    {
        hours = 0f;
        minutes = 0f;
        Timer();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer += Time.deltaTime;

            UpdateTimer(timer);
        }
        else if (timer > 60)
            Flash();
    }

    private void Timer()
    {
        if (holder == true)
        {
            timer = timeDuration;
            holder = false;
        }
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
    }
    private void UpdateTimer(float time)
    {

        if(timeDuration < 10f * 60f)
        {
            //float hours = Mathf.FloorToInt(time / 60);
            //float minutes = Mathf.FloorToInt(time % 60);
            hours = Mathf.FloorToInt(time / 60);
            minutes = Mathf.FloorToInt(time % 60);
            string currentTime = string.Format("{00:00} {1:00}", hours, minutes);
            TextTimer.text = currentTime;
        }

        else if (timeDuration > 11f * 60f)
        {
            Debug.Log("Time reached test");
        }
    }

    private void Flash()
    {
        Debug.Log("Time reached test");
    }

    //--------------------------
    public Vector2 ReturnTime()
    {
        Vector2 this_time = new Vector2(hours, minutes);
        return this_time;
    }
    //--------------------------
}
