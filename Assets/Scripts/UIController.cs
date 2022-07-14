using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]
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
        var _root = GetComponent<UIDocument>().rootVisualElement;
        pauseButton = _root.Q<Button>("PauseButton");
        protectButton = _root.Q<Button>("ProtectButton");
        resumeButton = _root.Q<Button>("ResumeButton");
        restartButton = _root.Q<Button>("RestartButton");
        pausePanel = _root.Q<VisualElement>("PausePanel");
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
        Time.timeScale = 1;
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
