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

    public VisualElement pausePanel;

    public Button resumeButton;
    public Button restartButton;

   [SerializeField] Field field;

    [SerializeField] private GameObject _field;

    private bool _canProtect;
    


    void Start()
    {
        RootButton();
        ButtonClickedAdd();
        _canProtect = true;

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
        protectButton.clicked += Protect;

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
    private void Protect()
    {
        if (!_canProtect) return;
        _canProtect = false;
        
            _field.SetActive(true);
            field.CurrentHealth = field.Health;
            protectButton.visible = false;
        
        StartCoroutine(Reload());

        
       

    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(15);
        _canProtect = true;
        protectButton.visible = true;
    }





}
