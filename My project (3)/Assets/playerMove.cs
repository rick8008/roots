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
    public int nuvem = 0;
    public int rootCounter = 2;
    public GameObject enemy = null;
    // Start is called before the first frame update
    void Start()
    {
        LastSpownd = Node;
        CurSpown = Instantiate(Node, Roots.transform); 
        CurSpown.transform.position  = CurSpown.transform.position+ new Vector3(0,-1,0);
        if(Player ==1){
            CurSpown.name = "PO_Root"+rootCounter.ToString();
        }else{
            CurSpown.name = "PT_Root"+rootCounter.ToString();
        }
        
        turnState = 1;
    }
    public void Voltar(int number){
        
        string name2 = CurSpown.name.Replace(rootCounter.ToString(),"")+((rootCounter-number));
        int prenunber = 0;
        do{
           string name = CurSpown.name.Replace(rootCounter.ToString(),"")+((rootCounter-prenunber)); 
            Destroy(GameObject.Find(name));
           prenunber +=1;
        }
        while(prenunber <= number ); 
        name2 = CurSpown.name.Replace(rootCounter.ToString(),"")+((rootCounter-number-1));
        rootCounter = rootCounter-number;
        LastSpownd = GameObject.Find(name2);
    
        Destroy(CurSpown);
        CurSpown = Instantiate(Node, Roots.transform); 
            if(Player ==1){
                CurSpown.name = "PO_Root"+rootCounter.ToString();
            }else{
                CurSpown.name = "PT_Root"+rootCounter.ToString();
            }
        CurSpown.transform.position  = LastSpownd.transform.GetChild(1).transform.position;
        CurSpown.transform.Rotate(LastSpownd.transform.GetChild(1).transform.eulerAngles); 
        //print();
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
           
            
            if(Input.GetKeyUp("joystick "+Player+" button 2") ){
                if(LogTerm > 0){
                    LogTerm = LogTerm-1;
                }
                if(LogTerm ==0){
                    movimentos = 0;
                }
                
                rootCounter = rootCounter +1;
                LastSpownd = CurSpown;
                LastSpownd.transform.localScale += new Vector3(0,movimentos,0);
                CurSpown = Instantiate(Node, Roots.transform); 
                    if(Player ==1){
                        CurSpown.name = "PO_Root"+rootCounter.ToString();
                    }else{
                        CurSpown.name = "PT_Root"+rootCounter.ToString();
                    }
                CurSpown.transform.position  = LastSpownd.transform.GetChild(1).transform.position;
                CurSpown.transform.Rotate(LastSpownd.transform.GetChild(1).transform.eulerAngles); 
                CurSpown.transform.localScale += new Vector3(0,movimentos,0);

            }   
            if(Input.GetKeyUp("joystick "+Player+" button 3") ){
                if(nuvem ==1){
                    if(enemy.GetComponent<playerMove>().imunity ==0){
                        enemy.GetComponent<playerMove>().movimentos = (float)-0.5;
                        enemy.GetComponent<playerMove>().LogTerm = (float)4.0;
                        nuvem =0;
                    }else{
                        enemy.GetComponent<playerMove>().imunity =0;
                    }
                   
                }
                if(formiga ==1){
                    if(enemy.GetComponent<playerMove>().imunity ==0){
                        enemy.GetComponent<playerMove>().Voltar(3) ;
                        formiga =0;
                     }else{
                        enemy.GetComponent<playerMove>().imunity =0;
                    }
                }
            }       
        }   
    }
}


