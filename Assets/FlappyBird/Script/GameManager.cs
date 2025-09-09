using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

	[SerializeField] private GameObject gameOverPanel;

	private void Awake()
	{
		instance = this;

		Time.timeScale = 1f;
	}

	public void GameOver()
	{
		gameOverPanel.SetActive(true);

		Time.timeScale = 0f;
	}

	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
