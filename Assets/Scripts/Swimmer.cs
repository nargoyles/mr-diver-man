using UnityEngine;
using System.Collections;

public class Swimmer : MonoBehaviour {

	Rigidbody2D rb;
    Animator anim;
    float speed = 2.5f;
 
    


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        Movement();

	}

	void Movement() {

        anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));

		if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
			rb.AddForce(new Vector2(0, 25 * speed));
        }

	    if (Input.GetAxisRaw("Horizontal") > 0)
        {
            rb.transform.Translate(Vector3.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);

        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            rb.transform.Translate(Vector3.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180);
        }

	}

	void OnCollisionEnter2D( Collision2D col) {
        // handle collision
        anim.Play("GettingHurt");
	}
}
