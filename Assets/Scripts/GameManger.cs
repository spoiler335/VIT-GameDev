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
    int wickets;
    public Text wicketsText;
    public bool isSpin = false;
    public Button spinBtn;
    public Button fastBtn;

    public Button var1;
    public Button var2;
    public Button var3;
    public Button var4;
    public Button var5;
    public Button var6;

    float prob0;
    float prob1;
    float prob2;
    float prob4;
    float prob6;

    public Text bowlingText;
    int temprun;
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
        wickets = 5;
        wicketsText.text = "Wickets Remaining :" + wickets;
        bowlingText.text = "Select Bowling Option";
        spinBtn.gameObject.SetActive(true);
        fastBtn.gameObject.SetActive(true);
        var1.gameObject.SetActive(false);
        var2.gameObject.SetActive(false);
        var3.gameObject.SetActive(false);
        var4.gameObject.SetActive(false);
        var5.gameObject.SetActive(false);
        var6.gameObject.SetActive(false);
        
    }

    void Update()
    {
        bowl();
        bat();
    }

    void bowl()
    {
        
    }

    void bat()
    {
        
    }

    public void onCLickSpin()
    {
        isSpin = true;
        bowlingText.text = "Select Variation";
        spinBtn.gameObject.SetActive(false);
        fastBtn.gameObject.SetActive(false);
        var1.gameObject.SetActive(true);
        var2.gameObject.SetActive(true);
        var3.gameObject.SetActive(true);
        var4.gameObject.SetActive(true);
        var5.gameObject.SetActive(true);
        var6.gameObject.SetActive(true);
    }

    public void onCLickFast()
    {
        isSpin = false;
        bowlingText.text = "Select Variation";
        spinBtn.gameObject.SetActive(false);
        fastBtn.gameObject.SetActive(false);
        var1.gameObject.SetActive(true);
        var2.gameObject.SetActive(true);
        var3.gameObject.SetActive(true);
        var4.gameObject.SetActive(true);
        var5.gameObject.SetActive(true);
        var6.gameObject.SetActive(true);
    }

    public void variation1()
    {
        if(isSpin)
        {
            prob0 = Random.Range(0.9f,1f);
            prob1 = Random.Range(0.8f,0.86f);
            prob2 = Random.Range(0.7f,0.8f);
            prob4 = Random.Range(0.6f,0.7f);
            prob6 = Random.Range(0.5f,0.65f);
        }
        else
        {
            prob0 = Random.Range(0.9f, 1f);
            prob1 = Random.Range(0.8f, 0.86f);
            prob2 = Random.Range(0.7f, 0.8f);
            prob4 = Random.Range(0.5f, 0.6f);
            prob6 = Random.Range(0.4f, 0.5f);
        }
    }

    public void hit0()
    {
        temprun = 0;
    }

    public void hit1()
    {
        temprun = 1;
    }

    public void hit2()
    {
        temprun = 2;
    }

    public void hit4()
    {
        temprun = 4;
    }

    public void hit6()
    {
        temprun = 6;
    }

}
