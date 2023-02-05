using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapGenerator : MonoBehaviour
{
    public GameObject tale0 ;
    public GameObject tale1 ;
    public GameObject tale2 ;
    public GameObject tale3 ;
    public GameObject tale4 ;
    public GameObject tale5 ;
    public GameObject tale6 ;
    public GameObject tale7 ;
    //0.036
    // Start is called before the first frame update
    void Start()
    {
        int rowCur = 1;
        int rowGoal = 20;
        GameObject CurSpown = null;
        Vector3 start = new Vector3(0,0,0);
        do{
            int colCur = 1;
            int colGoal = 8;
            do{
                if(rowCur == 1){
                    CurSpown = Instantiate(tale0,gameObject.transform);
                    CurSpown.transform.position +=start - new Vector3(0.36f*10*colCur,0.36f*10*rowCur,0);
                }
                if(rowCur > 1 && rowCur <5){
                    CurSpown = Instantiate(tale1,gameObject.transform);
                    CurSpown.transform.position +=start - new Vector3(0.36f*10*colCur,0.36f*10*rowCur,0);
                }
                
                if(rowCur >= 5 && rowCur <6){
                    CurSpown = Instantiate(tale2,gameObject.transform);
                    CurSpown.transform.position +=start - new Vector3(0.36f*10*colCur,0.36f*10*rowCur,0);
                }
                if(rowCur >= 6 && rowCur <11){
                    CurSpown = Instantiate(tale3,gameObject.transform);
                    CurSpown.transform.position +=start - new Vector3(0.36f*10*colCur,0.36f*10*rowCur,0);
                }
                if(rowCur >=11 && rowCur <12){
                    CurSpown = Instantiate(tale4,gameObject.transform);
                    CurSpown.transform.position +=start - new Vector3(0.36f*10*colCur,0.36f*10*rowCur,0);
                }
                if(rowCur >= 12 && rowCur <18){
                    CurSpown = Instantiate(tale5,gameObject.transform);
                    CurSpown.transform.position +=start - new Vector3(0.36f*10*colCur,0.36f*10*rowCur,0);
                }
                 if(rowCur >= 18 && rowCur <19){
                    CurSpown = Instantiate(tale6,gameObject.transform);
                    CurSpown.transform.position +=start - new Vector3(0.36f*10*colCur,0.36f*10*rowCur,0);
                }
                if(rowCur >=19){
                    CurSpown = Instantiate(tale7,gameObject.transform);
                    CurSpown.transform.position +=start - new Vector3(0.36f*10*colCur,0.36f*10*rowCur,0);
                }
               
              
                colCur +=1;
            }
            while(colCur < colGoal);
            rowCur +=1;
        }
        while(rowCur <rowGoal);
    }
}



