using UnityEngine;

public class PlayerMovement : MonoBehaviour {


	public Rigidbody rb;

	public float forwardForce = 2000f;	
	public float sidewaysForce = 500f;  
	public float JumpForce = 25f;  


	
	void FixedUpdate ()
	{
		
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey("d"))	
		{
			
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey("a"))  
		{
			
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey("w"))	
		{
			
			rb.AddForce(0, JumpForce* Time.deltaTime, 0, ForceMode.VelocityChange);
		}


		if (rb.position.y < -5f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
