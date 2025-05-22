using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlgaeSubsystem : MonoBehaviour
{
    public int processorIndex;
    public int bargeIndex;

    public void ProcessorHit()
    {
        transform.GetChild(processorIndex).GetComponent<OptionManager>().CloseOptionPanel();
    }

    public void UndoProcessorHit()
    {
    }

    public void ProcessorMiss()
    {
        transform.GetChild(processorIndex).GetComponent<OptionManager>().CloseOptionPanel();
    }

    public void CloseAll()
    {
        transform.GetChild(bargeIndex).GetChild(0).GetChild(0).GetComponent<OptionManager>().CloseOptionPanel();
        transform.GetChild(bargeIndex).GetChild(0).GetChild(1).GetComponent<OptionManager>().CloseOptionPanel();
        transform.GetChild(bargeIndex).GetComponent<OptionManager>().CloseOptionPanel();
    
    }

    public void UndoProcessorMiss()
    {

    }

    public void RobotHit()
    {
        CloseAll();
    }

    public void UndoRobotHit()
    {
        // Implementation for UndoRobotHit
    }

    public void RobotMiss()
    {
        CloseAll();
    }

    public void UndoRobotMiss()
    {
        // Implementation for UndoRobotMiss
    }

    public void HumanHit()
    {
        CloseAll();
    }

    public void UndoHumanHit()
    {
        // Implementation for UndoHumanHit
    }

    public void HumanMiss()
    {
        CloseAll();
    }

    public void UndoHumanMiss()
    {
        // Implementation for UndoHumanMiss
    }
}
