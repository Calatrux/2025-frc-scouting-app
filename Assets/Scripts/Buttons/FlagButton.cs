using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlagButton : MonoBehaviour
{
    public Color enabledColor;
    public Color disabledColor;
    public bool matchFlagged = false;
    public bool flagEnabled = false;

    public void ToggleFlag()
    {
        flagEnabled = !flagEnabled;
        matchFlagged = !matchFlagged;
        if (flagEnabled)
        {
            GetComponent<Image>().color = enabledColor;
        }
        else
        {
            GetComponent<Image>().color = disabledColor;
        }
    }

    public void FlagMatch()
    {
        matchFlagged = true;
        GetComponent<OptionManager>().ToggleOptions();
    }
}
