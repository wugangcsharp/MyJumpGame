using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public static Player player ;
    Transform m_transform;
	AudioSource m_audioSource;

    /// <summary>
    /// 移动速度
    /// </summary>
    public float moveSpeed;

	public AudioClip m_audioClip;

    Rigidbody2D _rigidbody2d;

    void Awake()
    {
        
        player = GetComponent<Player>();
        _rigidbody2d = this.GetComponent<Rigidbody2D>();
        m_transform = this.transform;
		m_audioSource = this.audio;
    }

    void Start()
    {

    }

    
    void Update()
    {
        m_transform.Translate(Input.acceleration.x * Time.deltaTime * moveSpeed, 0, 0);
    }

    void OnCollisionEnter2D(Collision2D _collider2d)
    {
        if (_collider2d.collider.CompareTag("ground"))
        {
            //如果撞到地板，则施加一个向上的力
            _rigidbody2d.AddForce(new Vector2(0, 200));
			m_audioSource.PlayOneShot(m_audioClip);
        }
    }
}
