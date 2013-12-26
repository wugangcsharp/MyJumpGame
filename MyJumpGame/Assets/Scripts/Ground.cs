using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

    Transform m_transform;
    BoxCollider2D _boxCollider2D;
    void Awake()
    {
        m_transform = this.transform;
        _boxCollider2D = this.GetComponent<BoxCollider2D>();
    }
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Player.player.gameObject.transform.position.y - 0.650508f > m_transform.position.y)
        {
            _boxCollider2D.isTrigger = false;
        }
        else
        {
            _boxCollider2D.isTrigger = true;
        }
	}
}
