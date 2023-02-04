using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnCOntroller : MonoBehaviour
{
    public GameObject Player1 = null;
    public GameObject Player2 = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float p1Moves = Player1.GetComponent<playerMove>().movimentosRestantes ;
        
        float p2Moves = Player2.GetComponent<playerMove>().movimentosRestantes ;
        if(p1Moves ==0 && p2Moves ==0){
            Player1.GetComponent<playerMove>().turnState = 2;
            Player2.GetComponent<playerMove>().turnState = 2;
        }
        
    }
}
