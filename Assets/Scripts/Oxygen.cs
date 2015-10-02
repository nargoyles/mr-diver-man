using UnityEngine;
using System.Collections;

public class Oxygen : MonoBehaviour {

    public float max_oxygen = 100f;
    public float cur_oxygen = 0f;
    private float oxygen;
    public GameObject oxygen_bar;
    public GameObject swimmer;

	// Use this for initialization
	void Start () {

        cur_oxygen = max_oxygen;
        InvokeRepeating("DecreaseOxygen", .1f, .1f);
	}
	
	// Update is called once per frame
	void Update () {

        if (cur_oxygen<=0)
        {
            swimmer.GetComponent<Animator>().Play("Dying");
        }
	}

    void DecreaseOxygen()
    {
        cur_oxygen -= .5f;
        oxygen = cur_oxygen / max_oxygen;
        oxygen_bar.transform.localScale = new Vector3(Mathf.Clamp(oxygen, 0f, 1f), oxygen_bar.transform.localScale.y, oxygen_bar.transform.localScale.z);
    }
}
