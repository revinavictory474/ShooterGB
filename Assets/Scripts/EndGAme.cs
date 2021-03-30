using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGAme : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public CanvasGroup exitImage;
    public CanvasGroup failImage;

    bool isPlayerExit;
    bool isPlayerFail;
    float _timer;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            isPlayerExit = true;
        }
    }

    public void FailPlayer()
    {
        isPlayerFail = true;
    }

    private void Update()
    {
        if (isPlayerExit)
        {
            EndLevel(exitImage, true);
        }
        else if (isPlayerFail)
        {
            EndLevel(failImage, true);
        }
    }

    void EndLevel(CanvasGroup imageCanvasGroup, bool doRestart)
    {
        _timer += Time.deltaTime;
        imageCanvasGroup.alpha = _timer / fadeDuration;

        if (_timer > fadeDuration + displayImageDuration)
        {
            if (doRestart)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                Application.Quit();
            }
        }
    }
}
