using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    int target;
    public Text targetText;
    int runs;
    public Text runsText;
    int overs;
    int overballs;
    int remBalls;
    public Text remBallsText;
    public Text oversText;
    
    void Start()
    {
        target = Random.Range(35, 71);
        targetText.text = "Target :" + target;
        runs = 0;
        runsText.text = "Runs Scored :" + runs;
        remBalls = 30;
        remBallsText.text = "Remaining Balls :" + remBalls;
        overs = overballs = 0;
        oversText.text = "Over :" + overs + "." + overballs;
    }

    void Update()
    {
        
    }
}
