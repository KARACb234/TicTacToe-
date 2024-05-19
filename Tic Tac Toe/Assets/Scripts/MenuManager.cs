using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject aboutMeCanvas;
    [SerializeField]
    private GameObject mainCanvas;
    [SerializeField]
    private GameObject statisticsCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Exit()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void OpenAboutMePanel()
    {
        aboutMeCanvas.SetActive(true);
        mainCanvas.SetActive(false);
    }
    public void OpenStatisticsPanel()
    {
        statisticsCanvas.SetActive(true);
        mainCanvas.SetActive(false);
    }
}
