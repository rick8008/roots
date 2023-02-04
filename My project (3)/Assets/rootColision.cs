using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rootColision : MonoBehaviour
{
    public GameObject player = null;
    public int ObjectType = 0;

    void OnCollisionEnter2D(Collision2D col)
    {
        player = col.gameObject.transform.parent.gameObject.transform.parent.gameObject;
        //escudo = 1
        if(ObjectType == 1){
            player.GetComponent<playerMove>().imunity = 1;
        }
        //agua = 2
        if(ObjectType == 2){
            player.GetComponent<playerMove>().movimentos = 4;
            player.GetComponent<playerMove>().LogTerm = 2;
        }
        Debug.Log(col.gameObject.transform.parent.gameObject.transform.parent.gameObject.name);
         Destroy(gameObject);
       
        
    }
}
