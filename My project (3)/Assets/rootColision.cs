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
            player.GetComponent<playerMove>().movimentos = (float)0.5;
            player.GetComponent<playerMove>().LogTerm = (float)2.0;
        }
         if(ObjectType == 3){
            player.GetComponent<playerMove>().formiga = 1;
        }
        Debug.Log(col.gameObject.transform.parent.gameObject.transform.parent.gameObject.name);
        Destroy(gameObject);
       
        
    }
}
