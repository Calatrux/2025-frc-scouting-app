using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int currentTime;
    public TMP_Text timerText;
    public int matchLength = 150;
    public GameObject getQRButton;

    public void StartTimer()
    {
        StartCoroutine(KeepTime());
    }

    IEnumerator KeepTime()
    {
        yield return new WaitForSeconds(1);
        currentTime++;
        timerText.text = currentTime.ToString();
        print("Time: " + currentTime + " seconds");

        if (currentTime > matchLength)
        {
            print("Match Over");
            StopCoroutine(KeepTime());
            getQRButton.SetActive(true);
            yield return null;
        }

        StartCoroutine(KeepTime());
    }

}
