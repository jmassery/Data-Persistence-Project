using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerName;

    public void StartGame()
    {
        string name = playerName.text;
        if (string.IsNullOrWhiteSpace(name))
        {
            GameManager.Instance.currentPlayer = "No Name";
        }
        else
        {
            GameManager.Instance.currentPlayer = playerName.text;
        }

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
