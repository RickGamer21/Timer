using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public int minute;
    public float second;
    public string scenceName;

    // Update is called once per frame
    void Update()
    {
        second -= Time.deltaTime;
        if (second <=0 )
        {
            minute -= 1;
            second += 59;
        }
        if (minute == 0)
        {
            EditorSceneManager.LoadScene(scenceName);
        }
        timerText.text = minute.ToString();
        timerText.text = second.ToString();
    }
}
