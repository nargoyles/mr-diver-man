using UnityEngine;
using System.Collections;

public class JFSwim : MonoBehaviour {

    private float speed = 105f;
    Animator anim;
    Rigidbody2D rb;
    float speedX;
    float speedY;

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("Movement", 1, Random.Range(1f, 3f));
    }
	
	// Update is called once per frame
	void Update () {


  	}

    void Movement()
    {
        speedX = Random.Range(-3, 4);
        speedY = Random.Range(-3, 4);
        anim.SetFloat("Speed", Mathf.Abs(speedX) + Mathf.Abs(speedY));
        rb.AddForce(new Vector2(speedX * speed, speedY * speed)); 
        Invoke("ResetSpeed", .4f);
    }

    void ResetSpeed ()
    {
        anim.SetFloat("Speed", 0);
    }
}
