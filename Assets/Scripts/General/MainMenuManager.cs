using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class MainMenuManager : MonoBehaviour
{
    public GameObject mainMenu;
    public Timer timer;
    public Text teamText;
    public Text matchText;
    public string team;
    public string match;

    public TMP_Text teamDisplay;
    public TMP_Text matchDisplay;

    public void Start()
    {
        Application.targetFrameRate = 14;
    }

    public void StartMatch()
    {
        if (!ValidationCheck())
        {
            print("Main Menu Data Not Valid!");
            return;
        }


        Debug.Log(teamText.text);
        Debug.Log(matchText.text);

        team = teamText.text;
        match = matchText.text;

        mainMenu.SetActive(false);
        timer.StartTimer();

        teamDisplay.text = team;
        matchDisplay.text = match;
    } 

    public bool ValidationCheck()
    {
        bool teamValid = false;
        bool matchValid = false;
        if (teamText.text.All(char.IsDigit) && teamText.text.Length >= 2)
        {
            teamValid = true;
        }

        if (teamText.text.All(char.IsDigit))
        {
            matchValid = true;
        }

        if (teamValid && matchValid)
        {
            return true;
        }

        return false;
    }

}
