using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class EndgameSubsystem : MonoBehaviour
{
    public ActionManager actionManager;

    public enum ClimbState { NotStarted, Started, Ended, Failed }
    public ClimbState shallowClimbState = ClimbState.NotStarted;
    public ClimbState deepClimbState = ClimbState.NotStarted;

    [Header("Objects")]
    public GameObject parkOptions;
    public GameObject startEndShallow;
    public GameObject startEndDeep;
    public GameObject failShallow;
    public GameObject failDeep;

    [Header("Feedback")]
    public Color normalClimbColor;
    public Color enabledClimbColor;
    public Color normalFailColor; 
    public Color enabledFailColor;

    public void Park()
    {
        parkOptions.GetComponent<OptionManager>().ToggleOptions();
    }

    public void UndoPark()
    {
    }

    public void StartShallowClimb()
    {
        startEndShallow.transform.GetChild(1).GetComponent<TMP_Text>().text = "End";
        shallowClimbState = ClimbState.Started;
        startEndShallow.GetComponent<Image>().color = enabledClimbColor;
    }

    public void UndoStartShallowClimb()
    {
        if (shallowClimbState == ClimbState.Started)
        {
            shallowClimbState = ClimbState.NotStarted;
            startEndShallow.transform.GetChild(1).GetComponent<TMP_Text>().text = "Start";
            startEndShallow.GetComponent<Image>().color = normalClimbColor;
        }
    }

    public void EndShallowClimb()
    {
        if (shallowClimbState == ClimbState.Started)
        {
            startEndShallow.transform.GetChild(1).GetComponent<TMP_Text>().text = "Done";
            shallowClimbState = ClimbState.Ended;
        }
    }

    public void UndoEndShallowClimb()
    {
        if (shallowClimbState == ClimbState.Ended)
        {
            shallowClimbState = ClimbState.Started;
            startEndShallow.transform.GetChild(1).GetComponent<TMP_Text>().text = "End";
        }
    }

    public void FailShallowClimb()
    {
        if (shallowClimbState == ClimbState.Started)
        {
            shallowClimbState = ClimbState.Failed;
            failShallow.GetComponent<Image>().color = enabledFailColor;
        }
    }

    public void UndoFailShallowClimb()
    {
        if (shallowClimbState == ClimbState.Failed)
        {
            shallowClimbState = ClimbState.Started;
            failShallow.GetComponent<Image>().color = normalFailColor;
        }
    }

    public void StartDeepClimb()
    {
        startEndDeep.transform.GetChild(1).GetComponent<TMP_Text>().text = "End";
        deepClimbState = ClimbState.Started;
        startEndDeep.GetComponent<Image>().color = enabledClimbColor;
    }

    public void UndoStartDeepClimb()
    {
        if (deepClimbState == ClimbState.Started)
        {
            deepClimbState = ClimbState.NotStarted;
            startEndDeep.transform.GetChild(1).GetComponent<TMP_Text>().text = "Start";
            startEndDeep.GetComponent<Image>().color = normalClimbColor;
        }
    }

    public void EndDeepClimb()
    {
        if (deepClimbState == ClimbState.Started)
        {
            startEndDeep.transform.GetChild(1).GetComponent<TMP_Text>().text = "Done";
            deepClimbState = ClimbState.Ended;
        }
    }

    public void UndoEndDeepClimb()
    {
        if (deepClimbState == ClimbState.Ended)
        {
            deepClimbState = ClimbState.Started;
            startEndDeep.transform.GetChild(1).GetComponent<TMP_Text>().text = "End";
        }
    }

    public void FailDeepClimb()
    {
        if (deepClimbState == ClimbState.Started)
        {
            deepClimbState = ClimbState.Failed;
            failDeep.GetComponent<Image>().color = enabledFailColor;
        }
    }

    public void UndoFailDeepClimb()
    {
        if (deepClimbState == ClimbState.Failed)
        {
            deepClimbState = ClimbState.Started;
            failDeep.GetComponent<Image>().color = normalFailColor;
        }
    }
}
