using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBasedFlagSubsystem : MonoBehaviour
{
    public bool robotIncapacitated;
    public bool defensePlayed;
    public bool defenseEncountered;
    private Image image;

    [Header("Feedback")]
    public Color enabledColor;
    public Color playedNormalColor;
    public Color incapNormalColor;
    public Color encounteredNormalColor;

    public void StartRobotIncap()
    {
        robotIncapacitated = true;
        transform.GetChild(1).GetComponent<Image>().color = enabledColor;
    }

    public void UndoStartRobotIncap()
    {
        robotIncapacitated = false;
        transform.GetChild(1).GetComponent<Image>().color = incapNormalColor;
    }

    public void EndRobotIncap()
    {
        robotIncapacitated = false;
        transform.GetChild(1).GetComponent<Image>().color = incapNormalColor;
    }

    public void UndoEndRobotIncap()
    {
        robotIncapacitated = true;
        transform.GetChild(1).GetComponent<Image>().color = enabledColor;
    }
    
    public void StartDefensePlayed()
    {
        defensePlayed = true;
        transform.GetChild(0).GetComponent<Image>().color = enabledColor;
    }

    public void UndoStartDefensePlayed()
    {
        defensePlayed = false;
        transform.GetChild(0).GetComponent<Image>().color = playedNormalColor;
    }

    public void EndDefensePlayed()
    {
        defensePlayed = false;
        transform.GetChild(0).GetComponent<Image>().color = playedNormalColor;
    }

    public void UndoEndDefensePlayed()
    {
        defensePlayed = true;
        transform.GetChild(0).GetComponent<Image>().color = enabledColor;
    }

    public void StartDefenseEncountered()
    {
        defenseEncountered = true;
        transform.GetChild(2).GetComponent<Image>().color = enabledColor;
    }

    public void UndoStartDefenseEncountered()
    {
        defenseEncountered = false;
        transform.GetChild(2).GetComponent<Image>().color = encounteredNormalColor;
    }

    public void EndDefenseEncountered()
    {
        defenseEncountered = false;
        transform.GetChild(2).GetComponent<Image>().color = encounteredNormalColor;
    }   

    public void UndoEndDefenseEncountered()
    {
        defenseEncountered = true;
        transform.GetChild(2).GetComponent<Image>().color = enabledColor;
    }

    public void Match()
    {
        // Implementation for Match
    }
}
