using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgPlayerController : MonoBehaviour
{
	public float speed;
	private Rigidbody rb;
	private int count;
	public Text CountText;
	public Text WinText;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText();
		WinText.text = "";

	}
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce(movement * speed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Pick Up"))
		{   
			other.gameObject.SetActive(false);
			count = count + 1;
			SetCountText();

		}

	}

	void SetCountText()
	{
		CountText.text = "Count:" + count.ToString();
		if (count >= 12)
		{
			WinText.text = "You win!";
		}
	}
}
//Destroy(other.gameObject);