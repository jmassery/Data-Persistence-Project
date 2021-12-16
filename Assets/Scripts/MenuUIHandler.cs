using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

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
}
