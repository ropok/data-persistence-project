using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textHighScore;
    // Start is called before the first frame update
    void Awake()
    {
        LoadHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadUsernameInput(string s)
    {
        DataManager.Instance.inputUserName = s;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    void LoadHighScore()
    {
        string username = DataManager.Instance.highScoreUsername;
        int highScore = DataManager.Instance.highScore;
        textHighScore.text = "High Score: " + username + " : " + highScore;
    }
}
