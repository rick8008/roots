using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chooseplayer : MonoBehaviour
{
    public bool ischoosing;
    
    public int player1choice;
    public int player2choice;

    bool player1choose;
    bool player2choose;

    // Start is called before the first frame update
    void Start()
    {
        ischoosing = true;
        player1choice =0;
        player2choice =1;
        player1choose = false;
        player2choose = false;
        
        //só pra renderizar as bios
        movecursor();
    }

    // Update is called once per frame
    void Update()
    {

        //se ambos escolheram começa o jogo
        if (player1choose && player2choose)
        {ischoosing = false;};

        //controles de escolha de personagem

        if (!player1choose && Input.GetKeyDown("d")){
            if (player1choice <= 3){player1choice +=1;                
            } else {player1choice = 0;};
            movecursor();
        };
        if (!player1choose && Input.GetKeyDown("a")){
            if (player1choice >= 1){player1choice -=1;                
            } else {player1choice = 4;};
            movecursor();
        };
        if (!player1choose && Input.GetKeyDown("s")){
            player1choose = true;
             if (this.gameObject.name == "player1"){
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;};
        };
        if (!player2choose && Input.GetKeyDown("right")){
            if (player2choice <= 3){player2choice +=1;                
            } else {player2choice = 0;};
            movecursor();
        };
        if (!player2choose && Input.GetKeyDown("left")){
            if (player2choice >= 1){player2choice -=1;                
            } else {player2choice = 4;};
            movecursor();
        };
        if (!player2choose && Input.GetKeyDown("down")){
            player2choose = true;
             if (this.gameObject.name == "player2"){
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;};
        };

        //não renderizar caso esteja escolhendo personagem
        if (!ischoosing){
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;};
            
    }

// move character choice cursor and show bio
    void movecursor(){
        //move cursor
        if (this.gameObject.name == "player2"){
            this.transform.position = new Vector3(3f+player2choice*1.093f,39.91f,-20.73f);
        }
        if (this.gameObject.name == "player1"){
            this.transform.position = new Vector3(-9.52f+player1choice*1.093f,39.91f,-20.73f);
        }

        //show bios player 2
        if (this.gameObject.name == "player1aipimbio"){
            if (player2choice == 0){this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            } else {this.gameObject.GetComponent<SpriteRenderer>().enabled = false;};
        };

        if (this.gameObject.name == "player1cenourabio"){
            if (player2choice == 1){this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            } else {this.gameObject.GetComponent<SpriteRenderer>().enabled = false;};
        };

        if (this.gameObject.name == "player1gengibrebio"){
            if (player2choice == 2){this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            } else {this.gameObject.GetComponent<SpriteRenderer>().enabled = false;};
        };

        if (this.gameObject.name == "player1inhamebio"){
            if (player2choice == 3){this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            } else {this.gameObject.GetComponent<SpriteRenderer>().enabled = false;};
        };

        if (this.gameObject.name == "player1beterrababio"){
            if (player2choice == 4){this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            } else {this.gameObject.GetComponent<SpriteRenderer>().enabled = false;};
        };

        //show bios player 1

        if (this.gameObject.name == "player2aipimbio"){
            if (player1choice == 0){this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            } else {this.gameObject.GetComponent<SpriteRenderer>().enabled = false;};
        };

        if (this.gameObject.name == "player2cenourabio"){
            if (player1choice == 1){this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            } else {this.gameObject.GetComponent<SpriteRenderer>().enabled = false;};
        };

        if (this.gameObject.name == "player2gengibrebio"){
            if (player1choice == 2){this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            } else {this.gameObject.GetComponent<SpriteRenderer>().enabled = false;};
        };

        if (this.gameObject.name == "player2inhamebio"){
            if (player1choice == 3){this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            } else {this.gameObject.GetComponent<SpriteRenderer>().enabled = false;};
        };

        if (this.gameObject.name == "player2beterrababio"){
            if (player1choice == 4){this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            } else {this.gameObject.GetComponent<SpriteRenderer>().enabled = false;};
        };

    }

}
