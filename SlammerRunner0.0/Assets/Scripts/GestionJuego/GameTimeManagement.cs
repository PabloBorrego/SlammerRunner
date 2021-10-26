using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTimeManagement : MonoBehaviour
{
    public float pauseTime = 5f;

    public void StartPause()
    {
        StartCoroutine(freezeTiempoCaptura(this.pauseTime));
    }

    public IEnumerator freezeTiempoCaptura(float pauseTIme)
    {
        Debug.Log("Inside PauseGame()");
        Time.timeScale = 0f;
        float pauseEndTime = Time.realtimeSinceStartup + pauseTime;
        while (Time.realtimeSinceStartup < pauseEndTime)
        {
            yield return 0;
        }
        Time.timeScale = 1f;
        Debug.Log("Done with my pause");
        PauseEnded();
    }

    private void PauseEnded()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
