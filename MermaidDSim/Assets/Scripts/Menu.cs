using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Menu : MonoBehaviour
{
    [Header("Screens")]
    public GameObject titleScreen;
    public GameObject settingsScreen;
    public GameObject creditsScreen;
    public GameObject loadGameScreen;

    [Header("Title Screen")]
    public Button newGameBtn;
    public Button loadGameBtn;
    public Button archiveBtn;
    public Button settingsBtn;
    public Button creditsBtn;
    public Button exitGameBtn;

    [Header("Setting Screen")]
    public Button sfxBtn;
    public Button musicBtn;
    //put in audio slider here

    //[Header("Credits Screen")]

    [Header("Load Game Screen")]
    public Button saveFilesBtn;
    public Button charactersBtn;
    public Button dialogBtn;
    public Button backBtn;
    public GameObject saveFileScreen;
    //public Button settingsBtn;
    // public Button filesBtn;

    void SetScreen(GameObject screen)
    {
        titleScreen.SetActive(false);
        settingsScreen.SetActive(false);
        creditsScreen.SetActive(false);
        loadGameScreen.SetActive(false);

        screen.SetActive(true);
    }

    // Goes to TitleScreen
    public void OnBackButton()
    {
        SetScreen(titleScreen);
    }

    //Goes to LoadGame Screen
    public void OnBack2Button()
    {
        SetScreen(loadGameScreen);
    }

    public void OnLoadGameButton()
    {
        SetScreen(loadGameScreen);
    }

    public void OnSettingsButton()
    {
        SetScreen(settingsScreen);
    }

    public void OnCreditsButton()
    {
        SetScreen(creditsScreen);
    }
}
