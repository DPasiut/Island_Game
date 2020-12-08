using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Inventory : MonoBehaviour
{
    public static int charge = 0;
    public AudioClip collectSound;
    public Text textHints;

    // Zapałki
    bool haveMatches = false;
    public RawImage  matchHudGUI ;

    // HUD
    public Texture2D[] hudCharge;
    public RawImage chargeHudGUI;

    // Generator
    public Texture2D[] meterCharge;
    public Renderer meter;


    void Start(){
        charge = 0;
    }

    void Update(){
        
    }
    
void MatchPickup(){
    haveMatches = true;
    AudioSource.PlayClipAtPoint(collectSound, transform.position);
    matchHudGUI.enabled = true;

}
void OnControllerColliderHit(ControllerColliderHit col){
    if(col.gameObject.name == "campfire"){
	 if(haveMatches){
            LightFire(col.gameObject);
        }/*else{
            textHints.SendMessage("ShowHint", "Mógłbym rozpalić ognisko do wezwania pomocy. \nTylko czym...");
        }*/
    }
}

void LightFire(GameObject campfire){
	ParticleSystem[] fireEmitters;
	fireEmitters = campfire.GetComponentsInChildren<ParticleSystem>();
	foreach(ParticleSystem emitter in fireEmitters){
    		emitter.Play();
	}
	campfire.GetComponent<AudioSource>().Play();
	matchHudGUI.enabled=false;
	haveMatches=false;
}
    

    void CellPickup(){
	HUDon();
	AudioSource.PlayClipAtPoint(collectSound, transform.position);
	charge++;
	chargeHudGUI.texture = hudCharge[charge];
	meter.material.mainTexture = meterCharge[charge];
    }

    void HUDon(){
    	if(!chargeHudGUI.enabled){
        	chargeHudGUI.enabled = true;
	}
    }

 

}//END CLASS
