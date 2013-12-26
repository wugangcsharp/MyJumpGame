using UnityEngine;
using System.Collections;

public class PlayerAnimator : MonoBehaviour {
    Rigidbody2D _Rigidbody2D;
	// Use this for initialization
	void Start () {
        _Rigidbody2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    void OnCollisionEnter2D(Collision2D _Collision2D)
    {
        if (_Collision2D.collider.CompareTag("ground"))
        {
            _Rigidbody2D.AddForce(new Vector2(0, 280));
        }
    }
}
