using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OyunKontrolcu: MonoBehaviour
{ 
    public UnityEngine.UI.Text zamanText,balonsayisiText ,degisenyazi;
    public GameObject patlama;
    public float zamanSayaci = 120;
    int patlayanBalon=0;
    void Start()
    {
        balonsayisiText.text="Balon:" + patlayanBalon;
        
    }

    // Update is called once per frame
    void Update(){
        if(zamanSayaci > 0){
           zamanSayaci -=Time.deltaTime;
           zamanText.text="Sure:" + (int)zamanSayaci;
           }
    
        else{
            GameObject[] go =GameObject.FindGameObjectsWithTag("balon");
            for(int i=0; i<go.Length; i++){
                Instantiate(patlama, go [i].transform.position,go [i].transform.rotation);
                Destroy(go [i]); 
                degisenyazi.text="Oyun Bitti";
            }
        }
    }
    public void BalonEkle(){
        patlayanBalon+= 1;
        balonsayisiText.text="Balon:"+patlayanBalon;
    }

}

