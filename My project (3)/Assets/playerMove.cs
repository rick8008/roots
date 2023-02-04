using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public GameObject StartNode = null;
    public GameObject Roots= null;
    public GameObject Node= null;
    private GameObject LastSpownd = null;
    private GameObject CurSpown = null;
    public int State = 0;
    public int Player = 1;
    private Vector2 xVector = Vector2.zero;
    private Vector2 yVector = Vector2.zero;
    private int LogTerm = 0;
    private int movimentos = 3;
    private int movimentosRestantes = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if(State == 0){
            movimentosRestantes = movimentos;
            LastSpownd = Node;
            CurSpown = Instantiate(Node, Roots.transform); 
            CurSpown.transform.position  = CurSpown.transform.position+ new Vector3(0,-1,0);
            State = 1;
        }
        if(State == 1){
            
            float horizontalInput = Input.GetAxis ("P"+Player+"_Horizontal");
            float vertialInput = 1; 
            if(horizontalInput == 1 || horizontalInput == -1){
                vertialInput = 0;
            }
            
      
            float angle = Mathf.Atan2(horizontalInput, vertialInput) * Mathf.Rad2Deg; 
            CurSpown.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
           


            //CurSpown.transform.Rotate(new Vector3( 0,0, ang)); 
            
            if(Input.GetKeyUp("joystick "+Player+" button 2") && movimentosRestantes > 0){
                
                if(movimentosRestantes != 0){
                    LastSpownd=CurSpown ;
                    CurSpown = Instantiate(Node, Roots.transform); 
                    CurSpown.transform.position  = LastSpownd.transform.GetChild(1).transform.position;
                    CurSpown.transform.Rotate(LastSpownd.transform.GetChild(1).transform.eulerAngles); 
                    movimentosRestantes = movimentosRestantes-1;
                }
                
            }
            if(movimentosRestantes ==0){
                State = 2;
            }
            
           
        }
        if(State == 2){
            if(LogTerm ==0){
                movimentos = 3;
            }
            movimentosRestantes = movimentos;
            State = 1;
        }
        
    }
}


