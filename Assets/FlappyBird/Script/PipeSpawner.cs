using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float heightRange = 0.45f;
    [SerializeField] private GameObject pipe;

    private float timer;

	private void Start()
	{
		SpawnPipe();
	}

	private void Update()
	{
		timer += Time.deltaTime;
		if(timer > maxTime)
		{
			timer = 0;
			SpawnPipe();
		}
	}

	private void SpawnPipe()
	{
		Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));
		GameObject newPipe = Instantiate(pipe, spawnPos, Quaternion.identity);

		Destroy(newPipe, 10f);
	}
}
