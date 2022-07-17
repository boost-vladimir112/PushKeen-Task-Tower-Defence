using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]
public class UIController : MonoBehaviour
{
   
    public Button pauseButton;
    public VisualElement pausePanel;

    public Button protectButton;
    public VisualElement inactiveButton;

    public Label timer;

    public Button resumeButton;
    public Button restartButton;

    

    [SerializeField] Field field;

    [SerializeField] private GameObject _field;

    private bool _canProtect;

    private float _reload = 15;

    
    


    void Start()
    {
        RootButton();
        ButtonClickedAdd();
        _canProtect = true;
    }
    private void Update()
    {
        if(!_canProtect)
        {
            Timer();
        }
    }

    private void RootButton()
    {
        var _root = GetComponent<UIDocument>().rootVisualElement;
        pauseButton = _root.Q<Button>("PauseButton");
        protectButton = _root.Q<Button>("ProtectButton");
        resumeButton = _root.Q<Button>("ResumeButton");
        restartButton = _root.Q<Button>("RestartButton");
        pausePanel = _root.Q<VisualElement>("PausePanel");
        inactiveButton = _root.Q<VisualElement>("InActiveButton");
        timer = _root.Q<Label>("Timer");
        
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
        inactiveButton.visible = true;
        timer.visible = true;
           
        StartCoroutine(Reload());
    }
    void Timer()
    {

        timer.text = _reload.ToString();
        _reload -= Time.deltaTime;
        timer.text = "0:" + Mathf.Round(_reload).ToString();
    }
    IEnumerator Reload()
    {
        yield return new WaitForSeconds(_reload);
        _canProtect = true;
        protectButton.visible = true;
        inactiveButton.visible = false;
        timer.visible = false;
        _reload = 15;
    }





}
