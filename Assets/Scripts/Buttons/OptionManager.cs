using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionManager : MonoBehaviour
{
    public GameObject optionPanel;
    public GameObject[] otherOptionPanels;

    public bool optionsOpen = false;
    public bool permanentlyOpen = false;

    public void ToggleOptions()
    {
        if (permanentlyOpen) optionsOpen = false;
        if (optionsOpen)
        {
            CloseOptionPanel();
            optionsOpen = false;
        }
        else
        {
            OpenOptionPanel();
            optionsOpen = true;
        }
    }

    public void OpenOptionPanel()
    {
        optionPanel.SetActive(true);
        optionsOpen = true;
        foreach (GameObject panel in otherOptionPanels)
        {
            panel.SetActive(false);
            panel.transform.parent.GetComponent<OptionManager>().optionsOpen = false;
        }
    }

    public void CloseOptionPanel()
    {
        optionPanel.SetActive(false);
        optionsOpen = false;
    }
}
