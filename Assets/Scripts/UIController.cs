using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
   
    public Button pauseButton;
    public Button protectButton;

    public Button resumeButton;
    public Button restartButton;

    public VisualElement pausePanel;


    void Start()
    {
        RootButton();
        ButtonClickedAdd();
    }
    void Update()
    {

    }


    private void RootButton()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        pauseButton = root.Q<Button>("PauseButton");
        protectButton = root.Q<Button>("ProtectButton");
        resumeButton = root.Q<Button>("ResumeButton");
        restartButton = root.Q<Button>("RestartButton");
        pausePanel = root.Q<VisualElement>("PausePanel");
    }
    void ButtonClickedAdd()
    {
        pauseButton.clicked += PauseGame;
        resumeButton.clicked += ResumeGame;
        restartButton.clicked += RestartScene;
    }


    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

 
    private void OpenPausePanel()
    {
        pausePanel.visible = true;
    }
    private void ClosePausePanel()
    {
        pausePanel.visible = false;
    }


    private void PauseGame()
    {
        OpenPausePanel();
        Time.timeScale = 0;
    }
    private void ResumeGame()
    {
        ClosePausePanel();
        Time.timeScale = 1;
    }







}
