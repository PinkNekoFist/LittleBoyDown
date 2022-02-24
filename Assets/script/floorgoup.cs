using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorgoup : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float UpSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector2(0,UpSpeed)*Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "ceiling"){
            Debug.Log("ouo");
            Destroy(this.gameObject);
        }
    }
}
