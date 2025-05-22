using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntakeSubsystem : MonoBehaviour
{
    public GameObject algaeOptions;
    public GameObject coralOptions;

    public void CoralFieldIntake()
    {
        coralOptions.GetComponent<OptionManager>().CloseOptionPanel();
    }

    public void UndoCoralFieldIntake()
    {
        // Implementation for UndoCoralFieldIntake
    }

    public void AlgaeFieldIntake()
    {
        algaeOptions.GetComponent<OptionManager>().CloseOptionPanel();
    }

    public void UndoAlgaeFieldIntake()
    {
        // Implementation for UndoAlgaeFieldIntake
    }

    public void SourceIntake()
    {
        coralOptions.GetComponent<OptionManager>().CloseOptionPanel();
    }

    public void UndoSourceIntake()
    {
        // Implementation for UndoSourceIntake
    }

    public void ReefIntake()
    {
        algaeOptions.GetComponent<OptionManager>().CloseOptionPanel();
    }

    public void UndoReefIntake()
    {
        // Implementation for UndoReefIntake
    }
}
