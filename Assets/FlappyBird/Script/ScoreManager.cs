using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private TextMeshProUGUI highscore;

    private int currentScore;

	private void Awake()
	{
		instance = this;
	}

	private void Start()
	{
		score.text = currentScore.ToString();

		highscore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
		UpdateHighscore();
	}

	private void UpdateHighscore()
	{
		if(currentScore > PlayerPrefs.GetInt("Highscore", 0))
		{
			PlayerPrefs.SetInt("Highscore", currentScore);
			highscore.text = currentScore.ToString();
		}
	}

	public void UpdateScore()
	{
		currentScore++;
		score.text = currentScore.ToString();
		UpdateHighscore();
	}
}
