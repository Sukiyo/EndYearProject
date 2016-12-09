using UnityEngine;
using System.Collections;

public class PlateformDestroyer : MonoBehaviour {

    public GameObject plateformDestructionPoint;

	// Use this for initialization
	void Start () {

        plateformDestructionPoint = GameObject.Find("PlateformDestructionPoint");
	
	}
	
	// Update is called once per frame
	void Update () {
	   
       if (transform.position.x < plateformDestructionPoint.transform.position.x)
       {
            //Destroy(gameObject);
            gameObject.SetActive(false);
       }
	}
}
