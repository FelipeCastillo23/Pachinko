using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public Button startButton;
    public Button optionButton;
    public Button quitButton;
    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        startButton = root.Q<Button>("StartBtn");
        optionButton = root.Q<Button>("OptionsBtn");
        quitButton = root.Q<Button>("QuitBtn");

        startButton.clicked += StartBtnPressed;
        optionButton.clicked += OptionBtnPressed;
        quitButton.clicked += QuitBtnPressed;
    }


    void StartBtnPressed()
    {
        SceneManager.LoadScene("Game");
    }

    void OptionBtnPressed()
    {
        Debug.Log("Option Button Pressed");
    }

    void QuitBtnPressed()
    {
        Debug.Log("Quit Button Pressed");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
