using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CoralSubsystem : MonoBehaviour
{
   public int currentLevelID = 0;
   public ActionManager actionManager;
   public void ScoreCoral(int id) // id = level
   {
      if (currentLevelID == id)
      {
         switch(id) 
         {
            case 4:
               actionManager.CoralScoredL4HitAction();
               break;
            case 3:
               actionManager.CoralScoredL3HitAction();
               break;
            case 2:
               actionManager.CoralScoredL2HitAction();
               break;
            case 1:
               actionManager.CoralScoredL1HitAction();
               break;
         }
      } else
      {
         currentLevelID = id;
         
         for (int i = 4; i > 0; i--)
         {
            if (id == i)
            {
               transform.GetChild(1).transform.GetChild(4 - id).GetChild(1).GetComponent<TMP_Text>().text = "Hit";
            }else
            {
               transform.GetChild(1).transform.GetChild(4 - i).GetChild(1).GetComponent<TMP_Text>().text = "L" + i;
            }
         }
      }
   }

   public void CloseAll()
   {
      currentLevelID = 0;
      for (int i = 0; i < 4; i++)
      {
         transform.GetChild(1).transform.GetChild(i).GetChild(1).GetComponent<TMP_Text>().text = "L" + (4-i);
         transform.GetChild(1).transform.GetChild(i).GetComponent<OptionManager>().CloseOptionPanel();
      }
      GetComponent<OptionManager>().CloseOptionPanel();
   }

   public void Cancel()
   {
      currentLevelID = 0;
      for (int i = 0; i < 4; i++)
      {
         transform.GetChild(1).transform.GetChild(i).GetChild(1).GetComponent<TMP_Text>().text = "L" + (4-i);
         transform.GetChild(1).transform.GetChild(i).GetComponent<OptionManager>().CloseOptionPanel();
      }
   }

   public void ScoreL1Hit()
   {
      CloseAll();
   }

   public void UndoScoreL1Hit()
   {
      // Implementation for UndoScoreL1Hit
   }

   public void ScoreL1Miss()
   {
      CloseAll();
   }

   public void UndoScoreL1Miss()
   {
      // Implementation for UndoScoreL1Miss
   }

   public void ScoreL2Hit()
   {
      CloseAll();
   }

   public void UndoScoreL2Hit()
   {
      // Implementation for UndoScoreL2Hit
   }

   public void ScoreL2Miss()
   {
      CloseAll();
   }

   public void UndoScoreL2Miss()
   {
      // Implementation for UndoScoreL2Miss
   }

   public void ScoreL3Hit()
   {
      CloseAll();
   }

   public void UndoScoreL3Hit()
   {
      // Implementation for UndoScoreL3Hit
   }

   public void ScoreL3Miss()
   {
      CloseAll();
   }

   public void UndoScoreL3Miss()
   {
      // Implementation for UndoScoreL3Miss
   }

   public void ScoreL4Hit()
   {
      CloseAll();
   }

   public void UndoScoreL4Hit()
   {
      // Implementation for UndoScoreL4Hit
   }

   public void ScoreL4Miss()
   {
      CloseAll();
   }

   public void UndoScoreL4Miss()
   {
      // Implementation for UndoScoreL4Miss
   }
}
