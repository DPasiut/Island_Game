using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
	/*
	bool doorIsOpen = false;
	float doorTimer = 0.0f;
	public float doorOpenTime = 3.0f;
	public AudioClip doorOpenSound;
	public AudioClip doorShutSound;
	*/
	GameObject currentDoor;

    // Start is called before the first frame update
    void Start(){    
    }


    void Update(){   
	RaycastHit hit; 
	if(Physics.Raycast (transform.position, transform.forward, out hit, 3)) {
		if(hit.collider.gameObject.tag=="playerDoor"){
			currentDoor = hit.collider.gameObject;
			currentDoor.SendMessage("DoorCheck");
		}
	}
    }


    // Update is called once per frame
/*
    void Update(){   
	if(doorIsOpen){
		doorTimer += Time.deltaTime;

		if(doorTimer > doorOpenTime){
			Door(doorShutSound,false,"doorshut",currentDoor);
			doorTimer = 0.0f;
		}
	} 
    }
*/

/*
    void OnControllerColliderHit(ControllerColliderHit hit){
	
	if(hit.gameObject.tag == "playerDoor" && doorIsOpen == false){
		currentDoor = hit.gameObject;
		Door(doorOpenSound,true,"dooropen",currentDoor);
	}
    }
*/
/*
    void OpenDoor(GameObject door){
	doorIsOpen = true;
	door.GetComponent<AudioSource>().PlayOneShot(doorOpenSound);
	door.transform.parent.GetComponent<Animation>().Play("dooropen");
    }

    void ShutDoor(GameObject door){
	doorIsOpen = false;
	door.GetComponent<AudioSource>().PlayOneShot(doorShutSound);
	door.transform.parent.GetComponent<Animation>().Play("doorshut");
    }

    void Door(AudioClip aClip, bool openCheck, string animName, GameObject thisDoor){
	doorIsOpen = openCheck;
	thisDoor.GetComponent<AudioSource>().PlayOneShot(aClip);
	thisDoor.transform.parent.GetComponent<Animation>().Play(animName);
    }
*/
}//end of class
