using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{   private Rigidbody2D rb;
    public float speed;
    [SerializeField]
    private int life = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            rb.velocity = new Vector2(-speed,rb.velocity.y);
        }
        else if(Input.GetKey(KeyCode.D)){
            rb.velocity = new Vector2(speed,rb.velocity.y);
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "ceiling"){
            life--;
        }
    }
    private void OnBecameInvisible() {
        life = 0;
    }
}
