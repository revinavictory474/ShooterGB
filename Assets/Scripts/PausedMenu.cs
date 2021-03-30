using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PausedMenu : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;

    [Header("Pause")]
    [SerializeField] private Button back;
    [SerializeField] private Button setting;
    [SerializeField] private Button menu;
    [SerializeField] GameObject camera;
    [SerializeField] private GameObject infoPanel;
    [SerializeField] private GameObject mainPanel;
    bool isLock;
    public CanvasGroup WinImageBackground;
    public CanvasGroup ExitImageBackground;

    public bool pause = false;
    public bool sound = false;

    float m_Timer;
    public float fadeDuration = 1f;

    private void Awake()
    {
        back.onClick.AddListener(BackGame);
        setting.onClick.AddListener(ShowInfo);
        menu.onClick.AddListener(ShowMain);
    }

    private void Start()
    {
        pausePanel.SetActive(false);
        isLock = true;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            if (isLock)
            {
                PauseLevel();
            }
            else
            {
                BackGame();
            }
        }
    }
    public void BackGame()
    {
        SceneManager.GetActiveScene();
    }
    public void ShowInfo()
    {
        infoPanel.SetActive(true);
        pausePanel.SetActive(false);
    }
    public void ShowMain()
    {
        infoPanel.SetActive(false);
        mainPanel.SetActive(true);
    }

    public void PauseLevel()
    {
        pausePanel.SetActive(true);
        isLock = false;
        Time.timeScale = 0;
        //if(pause == true)
        //{
        //    pausePanel.SetActive(false);
        //    Time.timeScale = 1f;
        //    pause = false;
        //    return;
        //}
        //if(pause == false)
        //{
        //    pausePanel.SetActive(true);
        //    Time.timeScale = 1f;
        //    pause = true;
        //    return;
        //}
    }
}
