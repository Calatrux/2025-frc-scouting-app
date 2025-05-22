using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using UnityEngine;

public interface IAction
{
    string GetName();
    char GetID();
    int GetTimePerformed();
    void PerformAction();
    void UndoAction();
}

public struct CoralScoredL1HitAction : IAction
{
    public static string name = "CoralScoredL1Hit";
    public static char id = 'A';
    public int timePerformed;
    public CoralSubsystem coral;

    public CoralScoredL1HitAction(int timePerformed, CoralSubsystem coral)
    {
        this.timePerformed = timePerformed;
        this.coral = coral;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        coral.ScoreL1Hit();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        coral.UndoScoreL1Hit();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct CoralScoredL1MissAction : IAction
{
    public static string name = "CoralScoredL1Miss";
    public static char id = 'B';
    public int timePerformed;
    public CoralSubsystem coral;

    public CoralScoredL1MissAction(int timePerformed, CoralSubsystem coral)
    {
        this.timePerformed = timePerformed;
        this.coral = coral;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        coral.ScoreL1Miss();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        coral.UndoScoreL1Miss();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct CoralScoredL2HitAction : IAction
{
    public static string name = "CoralScoredL2Hit";
    public static char id = 'C';
    public int timePerformed;
    public CoralSubsystem coral;

    public CoralScoredL2HitAction(int timePerformed, CoralSubsystem coral)
    {
        this.timePerformed = timePerformed;
        this.coral = coral;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        coral.ScoreL2Hit();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        coral.UndoScoreL2Hit();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct CoralScoredL2MissAction : IAction
{
    public static string name = "CoralScoredL2Miss";
    public static char id = 'D';
    public int timePerformed;
    public CoralSubsystem coral;

    public CoralScoredL2MissAction(int timePerformed, CoralSubsystem coral)
    {
        this.timePerformed = timePerformed;
        this.coral = coral;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        coral.ScoreL2Miss();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        coral.UndoScoreL2Miss();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct CoralScoredL3HitAction : IAction
{
    public static string name = "CoralScoredL3Hit";
    public static char id = 'E';
    public int timePerformed;
    public CoralSubsystem coral;

    public CoralScoredL3HitAction(int timePerformed, CoralSubsystem coral)
    {
        this.timePerformed = timePerformed;
        this.coral = coral;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        coral.ScoreL3Hit();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        coral.UndoScoreL3Hit();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct CoralScoredL3MissAction : IAction
{
    public static string name = "CoralScoredL3Miss";
    public static char id = 'F';
    public int timePerformed;
    public CoralSubsystem coral;

    public CoralScoredL3MissAction(int timePerformed, CoralSubsystem coral)
    {
        this.timePerformed = timePerformed;
        this.coral = coral;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        coral.ScoreL3Miss();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        coral.UndoScoreL3Miss();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct CoralScoredL4HitAction : IAction
{
    public static string name = "CoralScoredL4Hit";
    public static char id = 'G';
    public int timePerformed;
    public CoralSubsystem coral;

    public CoralScoredL4HitAction(int timePerformed, CoralSubsystem coral)
    {
        this.timePerformed = timePerformed;
        this.coral = coral;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        coral.ScoreL4Hit();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        coral.UndoScoreL4Hit();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct CoralScoredL4MissAction : IAction
{
    public static string name = "CoralScoredL4Miss";
    public static char id = 'H';
    public int timePerformed;
    public CoralSubsystem coral;

    public CoralScoredL4MissAction(int timePerformed, CoralSubsystem coral)
    {
        this.timePerformed = timePerformed;
        this.coral = coral;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        coral.ScoreL4Miss();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        coral.UndoScoreL4Miss();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct AlgaeNetRobotHitAction : IAction
{
    public static string name = "AlgaeNetRobotHit";
    public static char id = 'I';
    public int timePerformed;
    public AlgaeSubsystem algaeNet;

    public AlgaeNetRobotHitAction(int timePerformed, AlgaeSubsystem algaeNet)
    {
        this.timePerformed = timePerformed;
        this.algaeNet = algaeNet;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        algaeNet.RobotHit();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        algaeNet.UndoRobotHit();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct AlgaeNetRobotMissAction : IAction
{
    public static string name = "AlgaeNetRobotMiss";
    public static char id = 'J';
    public int timePerformed;
    public AlgaeSubsystem algaeNet;

    public AlgaeNetRobotMissAction(int timePerformed, AlgaeSubsystem algaeNet)
    {
        this.timePerformed = timePerformed;
        this.algaeNet = algaeNet;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        algaeNet.RobotMiss();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        algaeNet.UndoRobotMiss();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct AlgaeNetHumanHitAction : IAction
{
    public static string name = "AlgaeNetHumanHit";
    public static char id = 'K';
    public int timePerformed;
    public AlgaeSubsystem algaeNet;

    public AlgaeNetHumanHitAction(int timePerformed, AlgaeSubsystem algaeNet)
    {
        this.timePerformed = timePerformed;
        this.algaeNet = algaeNet;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        algaeNet.HumanHit();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        algaeNet.UndoHumanHit();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct AlgaeNetHumanMissAction : IAction
{
    public static string name = "AlgaeNetHumanMiss";
    public static char id = 'L';
    public int timePerformed;
    public AlgaeSubsystem algaeNet;

    public AlgaeNetHumanMissAction(int timePerformed, AlgaeSubsystem algaeNet)
    {
        this.timePerformed = timePerformed;
        this.algaeNet = algaeNet;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        algaeNet.HumanMiss();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        algaeNet.UndoHumanMiss();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct AlgaeProcessorHitAction : IAction
{
    public static string name = "AlgaeProcessorHit";
    public static char id = 'M';
    public int timePerformed;
    public AlgaeSubsystem algaeProcessor;

    public AlgaeProcessorHitAction(int timePerformed, AlgaeSubsystem algaeProcessor)
    {
        this.timePerformed = timePerformed;
        this.algaeProcessor = algaeProcessor;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        algaeProcessor.ProcessorHit();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        algaeProcessor.UndoProcessorHit();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct AlgaeProcessorMissAction : IAction
{
    public static string name = "AlgaeProcessorMiss";
    public static char id = 'N';
    public int timePerformed;
    public AlgaeSubsystem algaeProcessor;

    public AlgaeProcessorMissAction(int timePerformed, AlgaeSubsystem algaeProcessor)
    {
        this.timePerformed = timePerformed;
        this.algaeProcessor = algaeProcessor;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        algaeProcessor.ProcessorMiss();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        algaeProcessor.UndoProcessorMiss();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct CoralFieldIntakeAction : IAction
{
    public static string name = "CoralFieldIntake";
    public static char id = 'O';
    public int timePerformed;
    public IntakeSubsystem intake;

    public CoralFieldIntakeAction(int timePerformed, IntakeSubsystem intake)
    {
        this.timePerformed = timePerformed;
        this.intake = intake;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        intake.CoralFieldIntake();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        intake.UndoCoralFieldIntake();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct AlgaeFieldIntakeAction : IAction
{
    public static string name = "AlgaeFieldIntake";
    public static char id = 'P';
    public int timePerformed;
    public IntakeSubsystem intake;

    public AlgaeFieldIntakeAction(int timePerformed, IntakeSubsystem intake)
    {
        this.timePerformed = timePerformed;
        this.intake = intake;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        intake.AlgaeFieldIntake();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        intake.UndoAlgaeFieldIntake();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct SourceIntakeAction : IAction
{
    public static string name = "SourceIntake";
    public static char id = 'Q';
    public int timePerformed;
    public IntakeSubsystem intake;

    public SourceIntakeAction(int timePerformed, IntakeSubsystem intake)
    {
        this.timePerformed = timePerformed;
        this.intake = intake;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        intake.SourceIntake();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        intake.UndoSourceIntake();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct ReefIntakeAction : IAction
{
    public static string name = "ReefIntake";
    public static char id = 'R';
    public int timePerformed;
    public IntakeSubsystem intake;

    public ReefIntakeAction(int timePerformed, IntakeSubsystem intake)
    {
        this.timePerformed = timePerformed;
        this.intake = intake;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        intake.ReefIntake();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        intake.UndoReefIntake();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct StartRobotIncapAction : IAction
{
    public static string name = "StartRobotIncap";
    public static char id = 'S';
    public int timePerformed;
    public TimeBasedFlagSubsystem flags;

    public StartRobotIncapAction(int timePerformed, TimeBasedFlagSubsystem flags)
    {
        this.timePerformed = timePerformed;
        this.flags = flags;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        flags.StartRobotIncap();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        flags.UndoStartRobotIncap();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct EndRobotIncapAction : IAction
{
    public static string name = "EndRobotIncap";
    public static char id = 'T';
    public int timePerformed;
    public TimeBasedFlagSubsystem flags;

    public EndRobotIncapAction(int timePerformed, TimeBasedFlagSubsystem flags)
    {
        this.timePerformed = timePerformed;
        this.flags = flags;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        flags.EndRobotIncap();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        flags.UndoEndRobotIncap();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct StartDefensePlayedAction : IAction
{
    public static string name = "StartDefensePlayed";
    public static char id = 'U';
    public int timePerformed;
    public TimeBasedFlagSubsystem flags;

    public StartDefensePlayedAction(int timePerformed, TimeBasedFlagSubsystem flags)
    {
        this.timePerformed = timePerformed;
        this.flags = flags;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        flags.StartDefensePlayed();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        flags.UndoStartDefensePlayed();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct EndDefensePlayedAction : IAction
{
    public static string name = "EndDefensePlayed";
    public static char id = 'V';
    public int timePerformed;
    public TimeBasedFlagSubsystem flags;

    public EndDefensePlayedAction(int timePerformed, TimeBasedFlagSubsystem flags)
    {
        this.timePerformed = timePerformed;
        this.flags = flags;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        flags.EndDefensePlayed();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        flags.UndoEndDefensePlayed();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct StartDefenseEncounteredAction : IAction
{
    public static string name = "StartDefenseEncountered";
    public static char id = 'W';
    public int timePerformed;
    public TimeBasedFlagSubsystem flags;

    public StartDefenseEncounteredAction(int timePerformed, TimeBasedFlagSubsystem flags)
    {
        this.timePerformed = timePerformed;
        this.flags = flags;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        flags.StartDefenseEncountered();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        flags.UndoStartDefenseEncountered();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct EndDefenseEncounteredAction : IAction
{
    public static string name = "EndDefenseEncountered";
    public static char id = 'X';
    public int timePerformed;
    public TimeBasedFlagSubsystem flags;

    public EndDefenseEncounteredAction(int timePerformed, TimeBasedFlagSubsystem flags)
    {
        this.timePerformed = timePerformed;
        this.flags = flags;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        flags.EndDefenseEncountered();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        flags.UndoEndDefenseEncountered();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct StartShallowClimbAction : IAction
{
    public static string name = "StartShallowClimb";
    public static char id = 'Y';
    public int timePerformed;
    public EndgameSubsystem climb;

    public StartShallowClimbAction(int timePerformed, EndgameSubsystem climb)
    {
        this.timePerformed = timePerformed;
        this.climb = climb;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        climb.StartShallowClimb();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        climb.UndoStartShallowClimb();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct EndShallowClimbAction : IAction
{
    public static string name = "EndShallowClimb";
    public static char id = 'Z';
    public int timePerformed;
    public EndgameSubsystem climb;

    public EndShallowClimbAction(int timePerformed, EndgameSubsystem climb)
    {
        this.timePerformed = timePerformed;
        this.climb = climb;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        climb.EndShallowClimb();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        climb.UndoEndShallowClimb();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct FailShallowClimbAction : IAction
{
    public static string name = "FailShallowClimb";
    public static char id = '@';
    public int timePerformed;
    public EndgameSubsystem climb;

    public FailShallowClimbAction(int timePerformed, EndgameSubsystem climb)
    {
        this.timePerformed = timePerformed;
        this.climb = climb;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        climb.FailShallowClimb();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        climb.UndoFailShallowClimb();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct StartDeepClimbAction : IAction
{
    public static string name = "StartDeepClimb";
    public static char id = '#';
    public int timePerformed;
    public EndgameSubsystem climb;

    public StartDeepClimbAction(int timePerformed, EndgameSubsystem climb)
    {
        this.timePerformed = timePerformed;
        this.climb = climb;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        climb.StartDeepClimb();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        climb.UndoStartDeepClimb();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct EndDeepClimbAction : IAction
{
    public static string name = "EndDeepClimb";
    public static char id = '$';
    public int timePerformed;
    public EndgameSubsystem climb;

    public EndDeepClimbAction(int timePerformed, EndgameSubsystem climb)
    {
        this.timePerformed = timePerformed;
        this.climb = climb;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        climb.EndDeepClimb();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        climb.UndoEndDeepClimb();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct FailDeepClimbAction : IAction
{
    public static string name = "FailDeepClimb";
    public static char id = '%';
    public int timePerformed;
    public EndgameSubsystem climb;

    public FailDeepClimbAction(int timePerformed, EndgameSubsystem climb)
    {
        this.timePerformed = timePerformed;
        this.climb = climb;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        climb.FailDeepClimb();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        climb.UndoFailDeepClimb();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct ParkAction : IAction
{
    public static string name = "Park";
    public static char id = '^';
    public int timePerformed;
    public EndgameSubsystem endgame;

    public ParkAction(int timePerformed, EndgameSubsystem endgame)
    {
        this.timePerformed = timePerformed;
        this.endgame = endgame;
    }

    public void PerformAction()
    {
        Debug.Log(name + " at " + timePerformed);
        endgame.Park();
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
        endgame.UndoPark();
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}

public struct FlagMatchAction : IAction
{
    public static string name = "FlagMatch";
    public static char id = '&';
    public int timePerformed;
    public TimeBasedFlagSubsystem TimeBasedFlagSubsystem;

    public FlagMatchAction(int timePerformed, TimeBasedFlagSubsystem TimeBasedFlagSubsystem)
    {
        this.timePerformed = timePerformed;
        this.TimeBasedFlagSubsystem = TimeBasedFlagSubsystem;
    }

    public void PerformAction()
    {
        TimeBasedFlagSubsystem.Match();
        Debug.Log(name + " at " + timePerformed);
    }

    public void UndoAction()
    {
        Debug.Log("Undo " + name);
    }

    public string GetName() { return name; }
    public char GetID() { return id; }
    public int GetTimePerformed() { return timePerformed; }
}


