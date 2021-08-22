using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text nameText;
   
    

    public void StartGame()
    {
        MenuManager.Instance.playerName = nameText.text;
        SceneManager.LoadScene("main");
    }
}
