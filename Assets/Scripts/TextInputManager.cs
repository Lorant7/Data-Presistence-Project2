using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextInputManager : MonoBehaviour
{
    public static TextInputManager Instance;
    public string Name;
    public int BestScore;

    public void Start()
    {
        Instance = this;
    }
    public void GetName()
    {
        TMP_Text t = gameObject.GetComponentInChildren<TMP_Text>();
        if (t != null)
        {
            Name = t.text;
        }
    }
}
