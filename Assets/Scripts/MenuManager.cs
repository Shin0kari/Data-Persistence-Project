using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;
    public TMP_InputField playerNameInput;

    private void Start()
    {
        bestScoreText.text = GameManager.Instance.GetBestScoreText();
    }

    public void StartGame()
    {
        string playerName = playerNameInput.text;
        GameManager.Instance.CurrentPlayerName = playerName;
        Debug.Log("CurrentPlayerName: " + GameManager.Instance.CurrentPlayerName);
        SceneManager.LoadScene(1);
    }
}
