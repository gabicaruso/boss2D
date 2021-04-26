using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataform : MonoBehaviour
{

    public float jumpForce = 10f;

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.relativeVelocity.y <= 0f)
		{
			Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
			if (rb != null)
			{
                rb.AddForce(Vector3.up * 600f);
			}
		}
	}

}
