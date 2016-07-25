using UnityEngine;
using System.Collections.Generic;


public class control_player : MonoBehaviour
{

   
    public int score;


 
    void Start()
    {
        
    }

    

    void Update()
    {
    

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "star") {
            Destroy(col.gameObject);
            score++;
        }
    }
}