using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionManager : MonoBehaviour
{
    public string questionID;
    public string question;
    public bool isYes;
    public TMP_Text textQuestion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SaveQuestionAnswer(int value){
        if(isYes){
            PlayerPrefs.SetInt(questionID, value);            
        }else{
            PlayerPrefs.SetInt(questionID, value);
        }
        Debug.Log("questionID: "+questionID+" value: "+value);
    }

    public void GetData(string questionID){
        int result = PlayerPrefs.GetInt(questionID);
        Debug.Log("result: "+result);

        // int q1 = PlayerPrefs.GetInt("q1");
        // int q2 = PlayerPrefs.GetInt("q2");
        // int q10 = PlayerPrefs.GetInt("q10");

        // int sum = q1+q2+q10;
    }



    // Update is called once per frame
    void Update()
    {
        textQuestion.text = question;
    }
}
