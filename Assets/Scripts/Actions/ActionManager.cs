using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{
    public Dictionary<int, IAction> actions = new Dictionary<int, IAction>();
    [Header("Subsystems")]
    public CoralSubsystem coral;
    public AlgaeSubsystem algae;
    public IntakeSubsystem intake;
    public TimeBasedFlagSubsystem flag;
    public EndgameSubsystem endgame;
    public GameObject exclamationPopup;
    public GameObject undoPopup;
    
    public Timer timer;
    public GameObject popupPrefab;
    bool canPerformAction = true;

    public void CreateAction(IAction action, string actionName)
    {
        if (!canPerformAction){
            GameObject exclamation = Instantiate(exclamationPopup, transform);
            exclamation.GetComponent<PopupController>().Activate("!");
            print("Too Soon!");
            return;
        }

        if (flag.defensePlayed)
        {
            IAction endDefensePlayed = new EndDefensePlayedAction(timer.currentTime, flag);
            endDefensePlayed.PerformAction();
            actions.Add(actions.Count, endDefensePlayed);
        }

        if (flag.robotIncapacitated)
        {
            IAction endRobotIncap = new EndRobotIncapAction(timer.currentTime, flag);
            endRobotIncap.PerformAction();
            actions.Add(actions.Count, endRobotIncap);
        }

        action.PerformAction();
        actions.Add(actions.Count, action);
        GameObject popup = Instantiate(popupPrefab, transform);
        popup.GetComponent<PopupController>().Activate(actionName);

        StartCoroutine(ActionBuffer());
    }

    public void UndoLastAction()
    {
        if (actions.Count == 0) return;

        if (!canPerformAction){
            GameObject exclamation = Instantiate(exclamationPopup, transform);
            exclamation.GetComponent<PopupController>().Activate("!");
            print("Too Soon!");
            return;
        }

        GameObject popup = Instantiate(undoPopup, transform);
        popup.GetComponent<PopupController>().Activate("Undo " + actions[actions.Count - 1].GetName());

        actions[actions.Count - 1].UndoAction();
        actions.Remove(actions.Count - 1);

        StartCoroutine(ActionBuffer());
    }

    public void CoralScoredL1HitAction() { CreateAction(new CoralScoredL1HitAction(timer.currentTime, coral), "Coral Scored L1 Hit"); }
    public void CoralScoredL1MissAction() { CreateAction(new CoralScoredL1MissAction(timer.currentTime, coral), "Coral Scored L1 Miss"); }
    public void CoralScoredL2HitAction() { CreateAction(new CoralScoredL2HitAction(timer.currentTime, coral), "Coral Scored L2 Hit"); }
    public void CoralScoredL2MissAction() { CreateAction(new CoralScoredL2MissAction(timer.currentTime, coral), "Coral Scored L2 Miss"); }
    public void CoralScoredL3HitAction() { CreateAction(new CoralScoredL3HitAction(timer.currentTime, coral), "Coral Scored L3 Hit"); }
    public void CoralScoredL3MissAction() { CreateAction(new CoralScoredL3MissAction(timer.currentTime, coral), "Coral Scored L3 Miss"); }
    public void CoralScoredL4HitAction() { CreateAction(new CoralScoredL4HitAction(timer.currentTime, coral), "Coral Scored L4 Hit"); }
    public void CoralScoredL4MissAction() { CreateAction(new CoralScoredL4MissAction(timer.currentTime, coral), "Coral Scored L4 Miss"); }

    public void AlgaeNetRobotHitAction() { CreateAction(new AlgaeNetRobotHitAction(timer.currentTime, algae), "Algae Net Robot Hit"); }
    public void AlgaeNetRobotMissAction() { CreateAction(new AlgaeNetRobotMissAction(timer.currentTime, algae), "Algae Net Robot Miss"); }
    public void AlgaeNetHumanHitAction() { CreateAction(new AlgaeNetHumanHitAction(timer.currentTime, algae), "Algae Net Human Hit"); }
    public void AlgaeNetHumanMissAction() { CreateAction(new AlgaeNetHumanMissAction(timer.currentTime, algae), "Algae Net Human Miss"); }
    public void AlgaeProcessorHitAction() { CreateAction(new AlgaeProcessorHitAction(timer.currentTime, algae), "Algae Processor Hit"); }
    public void AlgaeProcessorMissAction() { CreateAction(new AlgaeProcessorMissAction(timer.currentTime, algae), "Algae Processor Miss"); }

    public void CoralFieldIntakeAction() { CreateAction(new CoralFieldIntakeAction(timer.currentTime, intake), "Coral Field Intake"); }
    public void AlgaeFieldIntakeAction() { CreateAction(new AlgaeFieldIntakeAction(timer.currentTime, intake), "Algae Field Intake"); }
    public void SourceIntakeAction() { CreateAction(new SourceIntakeAction(timer.currentTime, intake), "Source Intake"); }
    public void ReefIntakeAction() { CreateAction(new ReefIntakeAction(timer.currentTime, intake), "Reef Intake"); }

    public void ToggleRobotIncapAction() { if (!flag.robotIncapacitated) CreateAction(new StartRobotIncapAction(timer.currentTime, flag), "Start Robot Incap"); else { CreateAction(new EndRobotIncapAction(timer.currentTime, flag), "End Robot Incap"); } }
    public void ToggleDefensePlayedAction() { if (!flag.defensePlayed) CreateAction(new StartDefensePlayedAction(timer.currentTime, flag), "Start Defense Played"); else { CreateAction(new EndDefensePlayedAction(timer.currentTime, flag), "End Defense Played"); } }
    public void ToggleDefenseEncounteredAction() { if (!flag.defenseEncountered) CreateAction(new StartDefenseEncounteredAction(timer.currentTime, flag), "Start Defense Encountered"); else { CreateAction(new EndDefenseEncounteredAction(timer.currentTime, flag), "End Defense Encountered"); } }

    public void ToggleShallowClimbAction() {if (endgame.shallowClimbState == EndgameSubsystem.ClimbState.NotStarted) {CreateAction(new StartShallowClimbAction(timer.currentTime, endgame), "Start Shallow Climb"); }else if (endgame.shallowClimbState == EndgameSubsystem.ClimbState.Started){ CreateAction(new EndShallowClimbAction(timer.currentTime, endgame), "End Shallow Climb");}}

    public void ToggleDeepClimbAction() { if (endgame.deepClimbState == EndgameSubsystem.ClimbState.NotStarted){CreateAction(new StartDeepClimbAction(timer.currentTime, endgame), "Start Deep Climb");} else if (endgame.deepClimbState == EndgameSubsystem.ClimbState.Started){ CreateAction(new EndDeepClimbAction(timer.currentTime, endgame), "End Deep Climb");}}

    public void FailShallowClimbAction() { CreateAction(new FailShallowClimbAction(timer.currentTime, endgame), "Fail Shallow Climb"); }
    public void FailDeepClimbAction() { CreateAction(new FailDeepClimbAction(timer.currentTime, endgame), "Fail Deep Climb"); }

    public void ParkAction() { CreateAction(new ParkAction(timer.currentTime, endgame), "Park"); }
    public void FlagMatchAction() { CreateAction(new FlagMatchAction(timer.currentTime, flag), "Flag Match"); }

    IEnumerator ActionBuffer()
    {
        canPerformAction = false;
        yield return new WaitForSeconds(1f);
        canPerformAction = true;
    }

}
