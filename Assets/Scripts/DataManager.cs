using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{

    public static DataManager Instance;

    public string inputUserName;
    public string highScoreUsername;
    public int highScore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadHighScore();
    }

    // json thingy
    [System.Serializable]
    class SaveData
    {
        public string highScoreUsername;
        public int highScore;
    }

    public void SaveHighScore()
    {
        SaveData data = new SaveData();
        data.highScoreUsername = highScoreUsername;
        data.highScore = highScore;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highScoreUsername = data.highScoreUsername;
            highScore = data.highScore;
        }
    }

}
