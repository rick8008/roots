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


    public GameObject gota ;
    public GameObject nitro ;
    public GameObject lixo ;
    public GameObject fosil ;
    public GameObject formiga ;
    public GameObject nuvem ;
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
                    CurSpown.gameObject.name= "tale"+rowCur+"_"+colCur;
                }
                if(rowCur > 1 && rowCur <5){
                    CurSpown = Instantiate(tale1,gameObject.transform);
                    CurSpown.transform.position +=start - new Vector3(0.36f*10*colCur,0.36f*10*rowCur,0);
                    CurSpown.gameObject.name= "tale"+rowCur+"_"+colCur;
                }
                
                if(rowCur >= 5 && rowCur <6){
                    CurSpown = Instantiate(tale2,gameObject.transform);
                    CurSpown.transform.position +=start - new Vector3(0.36f*10*colCur,0.36f*10*rowCur,0);
                    CurSpown.gameObject.name= "tale"+rowCur+"_"+colCur;
                }
                if(rowCur >= 6 && rowCur <11){
                    CurSpown = Instantiate(tale3,gameObject.transform);
                    CurSpown.transform.position +=start - new Vector3(0.36f*10*colCur,0.36f*10*rowCur,0);
                     CurSpown.gameObject.name= "tale"+rowCur+"_"+colCur;
                }
                if(rowCur >=11 && rowCur <12){
                    CurSpown = Instantiate(tale4,gameObject.transform);
                    CurSpown.transform.position +=start - new Vector3(0.36f*10*colCur,0.36f*10*rowCur,0);
                     CurSpown.gameObject.name= "tale"+rowCur+"_"+colCur;
                }
                if(rowCur >= 12 && rowCur <18){
                    CurSpown = Instantiate(tale5,gameObject.transform);
                    CurSpown.transform.position +=start - new Vector3(0.36f*10*colCur,0.36f*10*rowCur,0);
                     CurSpown.gameObject.name= "tale"+rowCur+"_"+colCur;
                }
                 if(rowCur >= 18 && rowCur <19){
                    CurSpown = Instantiate(tale6,gameObject.transform);
                    CurSpown.transform.position +=start - new Vector3(0.36f*10*colCur,0.36f*10*rowCur,0);
                     CurSpown.gameObject.name= "tale"+rowCur+"_"+colCur;
                }
                if(rowCur >=19){
                    CurSpown = Instantiate(tale7,gameObject.transform);
                    CurSpown.transform.position +=start - new Vector3(0.36f*10*colCur,0.36f*10*rowCur,0);
                     CurSpown.gameObject.name= "tale"+rowCur+"_"+colCur;
                }
               

              
                colCur +=1;
            }
            while(colCur < colGoal);
            rowCur +=1;
        }
        while(rowCur <rowGoal);

        
        CurSpown.transform.position +=start - new Vector3(0.36f*10*1,0.36f*10*1,0);
        int numberBufs = Random.Range(40, 60);
        print(numberBufs);
        int startInt = 1;
        do{
            int colRand = Random.Range(1, 8);
            int rowRand = Random.Range(3, 19);
            int prop = Random.Range(1, 7);
           
            if(prop == 1){
                 if (GameObject.Find("tale"+rowRand+"_"+colRand).transform.childCount == 0){
                    CurSpown = Instantiate(gota,GameObject.Find("tale"+rowRand+"_"+colRand).transform);
                    CurSpown.transform.position += new Vector3(0,0,-0.4f);
                    startInt +=1;
                 }
                
            }
             if(prop == 2){
                if (GameObject.Find("tale"+rowRand+"_"+colRand).transform.childCount == 0){
                CurSpown = Instantiate(nitro,GameObject.Find("tale"+rowRand+"_"+colRand).transform);
                CurSpown.transform.position += new Vector3(0,0,-0.4f);
                startInt +=1;}
            }
             if(prop == 3){
                if (GameObject.Find("tale"+rowRand+"_"+colRand).transform.childCount == 0){
                CurSpown = Instantiate(lixo,GameObject.Find("tale"+rowRand+"_"+colRand).transform);
                CurSpown.transform.position += new Vector3(0,0,-0.4f);
                startInt +=1;}
           
            }
             if(prop == 4){
                if (GameObject.Find("tale"+rowRand+"_"+colRand).transform.childCount == 0){
                CurSpown = Instantiate(fosil,GameObject.Find("tale"+rowRand+"_"+colRand).transform);
                CurSpown.transform.position += new Vector3(0,0,-0.4f);
                startInt +=1;}
            }
             if(prop == 5){
                if (GameObject.Find("tale"+rowRand+"_"+colRand).transform.childCount == 0){
                CurSpown = Instantiate(formiga,GameObject.Find("tale"+rowRand+"_"+colRand).transform);
                CurSpown.transform.position += new Vector3(0,0,-0.4f);
                startInt +=1;}
            //    CurSpown = Instantiate(formiga,gameObject.transform);
            //    CurSpown.transform.position =start + new Vector3(0.36f*10*colRand,0.36f*10*rowRand,0);
            }
             if(prop == 6){
                if (GameObject.Find("tale"+rowRand+"_"+colRand).transform.childCount == 0){
                CurSpown = Instantiate(nuvem,GameObject.Find("tale"+rowRand+"_"+colRand).transform);
                CurSpown.transform.position += new Vector3(0,0,-0.4f);
                startInt +=1;}
            //    CurSpown = Instantiate(nuvem,gameObject.transform);
            //    CurSpown.transform.position =start + new Vector3(0.36f*10*colRand,0.36f*10*rowRand,0);
            }
            

        }
        while(startInt <numberBufs);
        //GameObject.Find("tale19_7").transform.position = new Vector3(-0.384f,-0.485f,0);


    }
}



