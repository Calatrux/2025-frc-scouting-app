using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmMenu : MonoBehaviour
{
    public GameObject confirmMenu;
    public MainMenuManager mainMenuManager;
    public SCOUNManager sCOUNManager;
    public InputField confirmTeamText;
    public InputField confirmMatchText;
    public void populateFields()
    {
        confirmTeamText.text = mainMenuManager.teamText.text;
        print((confirmTeamText.text, mainMenuManager.teamText.text));
        confirmMatchText.text = mainMenuManager.matchText.text;
    }

    public void OpenConfirmMenu()
    {
        confirmMenu.SetActive(true);
        populateFields();
    }

    public void CloseConfirmMenu()
    {
        confirmMenu.SetActive(false);
        sCOUNManager.generateQR();
    }

    public string GetInfoSCOUN()
    {
        return confirmTeamText.text + "." + confirmMatchText.text + ".";
    }

    public string getFormattedSCOUN()
    {
        return confirmTeamText.text + " : " + confirmMatchText.text;
    }

}
