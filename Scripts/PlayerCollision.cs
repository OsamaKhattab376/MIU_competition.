using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;   

	// This function runs when we hit another object.
	
	void OnCollisionEnter (Collision collisionInfo)
	{
		
		if (collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;  
			FindObjectOfType<GameManager>().EndGame();
		}
	}

}
