using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class General : MonoBehaviour
{
    public FlagButton matchFlagButton;
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }

    public string GetFlag()
    {
        if (matchFlagButton.matchFlagged) return "!";
        return "";
    }
}
