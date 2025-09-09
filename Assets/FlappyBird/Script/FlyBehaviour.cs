using UnityEngine;
using UnityEngine.InputSystem;

public class FlyBehaviour : MonoBehaviour
{
    [SerializeField] private float velocity = 1.5f;
	[SerializeField] private float rotationSpeed = 10f;
    private Rigidbody2D rb;

	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	private void Update(){
		if (Mouse.current.leftButton.wasPressedThisFrame) 
		{
			rb.linearVelocity = Vector2.up * velocity;
		}
	}

	private void FixedUpdate()
	{
		transform.rotation = Quaternion.Euler(0, 0, rb.linearVelocity.y * rotationSpeed);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		GameManager.instance.GameOver();
	}
}
