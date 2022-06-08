using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif 

public class MenuUIHandler : MonoBehaviour
{
    public TMP_Text TopText;
    public void Awake()
    {
        
        TopText.text = $"Best Score: {MainManager.GetBestName()}: {MainManager.GetBestScore()}";
    }
    public void StartNew()
    {
        TextInputManager.Instance.GetName();
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
