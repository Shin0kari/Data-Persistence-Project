using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public string CurrentPlayerName;
    public int BestScore;
    public string BestPlayerName;

    private const string BestScoreKey = "BestScore";
    private const string BestPlayerKey = "BestPlayer";

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadData();
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt(BestScoreKey, BestScore);
        PlayerPrefs.SetString(BestPlayerKey, BestPlayerName);
        PlayerPrefs.Save();
    }

    public void LoadData()
    {
        BestScore = PlayerPrefs.GetInt(BestScoreKey, 0);
        BestPlayerName = PlayerPrefs.GetString(BestPlayerKey, "Name");
    }

    public string GetBestScoreText()
    {
        return $"Best Score : {BestPlayerName} : {BestScore}";
    }

    public void ResetData() {
        BestScore = 0;
        BestPlayerName = "Name";
        SaveData();
        Debug.Log("Set o point to Name.");
        Debug.Log(GetBestScoreText());
    }
}
