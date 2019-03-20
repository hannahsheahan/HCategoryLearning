﻿using UnityEngine; using System; using System.Collections; using System.Collections.Generic;  [System.Serializable] public class TrialData {     /// <summary>     /// This script contains all the data (formatted) to be saved per trial.     /// This is a simplified, general purpose version for creating different behavioural experiments in Unity.     /// Author: Hannah Sheahan     /// Date: 31/10/2018     /// </summary>      // Static per trial data     public int trialNumber = 0;     public List<int> trialListIndex = new List<int>();      // which trial attempt     public string mapName;      // questions and answers     public string trialAnswer;     public string trialQuestion;     public string trialStimulus;
    public string[] trialPossibleAnswers;      // trial configuration times     public float preDisplayCueTime;     public float displayCueTime;     public float goCueDelay;     public float minDwellAtReward;           public float displayMessageTime;         public float errorDwellTime;     public float goalHitPauseTime;     public float finalGoalHitPauseTime;     public float pausePriorFeedbackTime;     public float feedbackFlashDuration;      // trial response events     public float trialScore;
    public float maxResponseTime;     public List<float> responseTime = new List<float>();     public List<string> responseChoice = new List<string>();     public List<bool> choiceCorrect = new List<bool>();      // trial error flags     public List<bool> FLAG_trialTimeout = new List<bool>();             public List<bool> FLAG_trialError = new List<bool>();     public List<bool> FLAG_dataWritingError = new List<bool>();
    public List<bool> FLAG_fullScreenModeError = new List<bool>(); }  