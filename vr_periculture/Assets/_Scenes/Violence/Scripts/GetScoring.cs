using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScoring : MonoBehaviour
{
    public int correctAns {get; set;}
    private int totalRisks, wrongAns;
    private void Awake()
    {
        totalRisks = 7;
        correctAns = wrongAns = 0;
    }
    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
            CalculateScore();
    }

    public void CalculateScore()
    {
        wrongAns = totalRisks - correctAns;
        //Debug.Log("totalCorrectAnswers: " + correctAns);
        //Debug.Log("totalWrongAnswers: " + wrongAns);
    }
}
