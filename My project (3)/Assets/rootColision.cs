using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rootColision : MonoBehaviour
{
    public GameObject player = null;
    public int ObjectType = 0;

    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if(col.gameObject.name.Contains("Root")){
            print("colide");
            player = col.gameObject.transform.parent.gameObject.transform.parent.gameObject;
            if(player){
            //escudo = 1
            if(ObjectType == 1){
                player.GetComponent<playerMove>().imunity = 1;
                Destroy(gameObject);
            }
            //agua = 2
            if(ObjectType == 2){
                player.GetComponent<playerMove>().movimentos = (float)0.5;
                player.GetComponent<playerMove>().LogTerm = (float)4.0;
                Destroy(gameObject);
            }
            if(ObjectType == 3){
                player.GetComponent<playerMove>().formiga = 1;
                player.GetComponent<playerMove>().nuvem = 0;
                Destroy(gameObject);
            }
            if(ObjectType == 5){
            player.GetComponent<playerMove>().Voltar(1);
            
            } 
            if(ObjectType == 6){
            player.GetComponent<playerMove>().Voltar(1);
                player.GetComponent<playerMove>().formiga = 0;
                player.GetComponent<playerMove>().nuvem = 1;
                Destroy(gameObject);
            } 
            }
            
        }
        
        
    }
    private void OnTriggerStay2D(Collider2D col)
    {
         if(col.gameObject.name.Contains("Root")){
            print("colide");
            if(ObjectType == 4){
                player.GetComponent<playerMove>().movimentos = (float) -0.25;
                player.GetComponent<playerMove>().LogTerm = (float)2.0;
            } 
         }
    }
}
