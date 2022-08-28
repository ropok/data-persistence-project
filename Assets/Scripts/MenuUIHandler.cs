using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
        Debug.Log(DataManager.Instance.inputUserName);
    }
}
