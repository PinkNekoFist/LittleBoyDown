using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] floor;
    [SerializeField]
    private float SpownTime,st;
    void Start()
    {
        st = SpownTime;
    }

    // Update is called once per frame
    void Update()
    {
        st -= Time.deltaTime;
        if(st <= 0){
            Spown();
            st = SpownTime;
        }
        if(movement.life == 0)
        {
            SceneManager.LoadScene(2);
            movement.life = 3;
        }
    }
    public void Spown(){
        Instantiate(floor[Random.Range(0,3)],new Vector2(Random.Range(-8f,8f),transform.position.y),Quaternion.identity);
    } 
}
