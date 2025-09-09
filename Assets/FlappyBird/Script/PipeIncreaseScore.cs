using Unity.VisualScripting;
using UnityEngine;

public class PipeIncreaseScore : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.CompareTag("Player")){
			ScoreManager.instance.UpdateScore();
		}
	}
}
