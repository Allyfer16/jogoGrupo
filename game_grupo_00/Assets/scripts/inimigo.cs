using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour


{
    public float velocidade;
public GameObject protagonista;

private Vector3 posicaogato;
private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        posicaogato = protagonista.transform.position;
        sprite = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       if(posicaogato.x < this.transform.position.x)
       {
           Andar(false);
       } 
       else if (posicaogato.x > this.transform.position.x)
       {
           Andar(true);
       }
       posicaogato = protagonista.transform.position;
    }


public void Andar(bool andandoparafrente){
    if (andandoparafrente)
    {
        sprite.flipX = false;
        Vector3 pos = this.transform.position;
        pos.x += velocidade;
        this.transform.position = pos;
    }
    else{
        Vector3 pos = this.transform.position;
        pos.x -= velocidade;
        this.transform.position = pos;
    }
}

}