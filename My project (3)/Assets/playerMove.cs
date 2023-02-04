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
    public int turnState = 0;
    public int Player = 1;
    private Vector2 xVector = Vector2.zero;
    private Vector2 yVector = Vector2.zero;
    public float  LogTerm = 0;
    public float  movimentos = 0;
    public int imunity = 0;
    public int formiga = 0;
    private int rootCounter = 2;
    // Start is called before the first frame update
    void Start()
    {
        LastSpownd = Node;
        CurSpown = Instantiate(Node, Roots.transform); 
        CurSpown.transform.position  = CurSpown.transform.position+ new Vector3(0,-1,0);
        CurSpown.name = "Root"+rootCounter.ToString();
        turnState = 1;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(turnState == 1){
            
            float horizontalInput = Input.GetAxis ("P"+Player+"_Horizontal");
            float vertialInput = 1; 
            if(horizontalInput == 1 || horizontalInput == -1){
                vertialInput = 0;
            }
            
      
            float angle = Mathf.Atan2(horizontalInput, vertialInput) * Mathf.Rad2Deg; 
            CurSpown.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
           


            //CurSpown.transform.Rotate(new Vector3( 0,0, ang)); 
            
            if(Input.GetKeyUp("joystick "+Player+" button 2") ){
                if(LogTerm > 1){
                    LogTerm = LogTerm-1;
                }
                if(LogTerm ==0){
                    movimentos = 0;
                }
                
                rootCounter = rootCounter +1;
                LastSpownd.GetComponent<Collider2D>().enabled = false;
                LastSpownd = CurSpown ;
                LastSpownd.GetComponent<Collider2D>().enabled = true;
                LastSpownd.transform.localScale += new Vector3(0,movimentos,0);
                CurSpown = Instantiate(Node, Roots.transform); 
                CurSpown.name = "Root"+rootCounter;
                CurSpown.transform.position  = LastSpownd.transform.GetChild(1).transform.position;
                CurSpown.transform.Rotate(LastSpownd.transform.GetChild(1).transform.eulerAngles); 
              
                    
                    
                
                
            }
            
            
           
        }
        
        
    }
}


