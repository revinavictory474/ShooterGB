using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MaiMenu : MonoBehaviour
{
    [SerializeField] public GameObject mainPanel;
    [SerializeField] public GameObject infoPanel;
    [SerializeField] public GameObject musicManager;

    [Header("Main")]
    [SerializeField] private Button startGame;
    [SerializeField] private Button setting;
    [SerializeField] private Button quit;

    [Header("Setting")]
    [SerializeField] private Button back;
    [SerializeField] private Toggle muteToggle;

    private bool isMute;

    private void Awake()
    {
        startGame.onClick.AddListener(StartGame);
        setting.onClick.AddListener(ShowInfo);
        quit.onClick.AddListener(QuitGame);
        back.onClick.AddListener(ShowMain);
        muteToggle.onValueChanged.AddListener(Mute);
        DontDestroyOnLoad(musicManager);
    }

    private void Mute(bool mute)
    {
        isMute = mute;
    }
    public void StartGame()
    {
        SceneManager.LoadScene("MyGames");
    }
    public void ShowInfo()
    {
        infoPanel.SetActive(true);
        mainPanel.SetActive(false);
    }
    public void ShowMain()
    {
        infoPanel.SetActive(false);
        mainPanel.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
