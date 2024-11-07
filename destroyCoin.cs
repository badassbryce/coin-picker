using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCoin : MonoBehaviour
{
    public float respawnTime = 2f;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other){

        if(other.CompareTag("Player")){
            scoremanager.Instance.AddScore(1);

            Destroy(this.gameObject);

            
        }
        
    }
    
}
