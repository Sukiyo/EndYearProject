using UnityEngine;
using System.Collections;

public class PlateformGenerater : MonoBehaviour {

    public GameObject thePlateform;
    public Transform generationPoint;
    public float distanceBetween;

    private float plateformWidth;

    public float distanceBetweenMin;
    public float distanceBetweenMax;

    public ObjectPooler theObjectPool;

	// Use this for initialization
	void Start () {
        plateformWidth = thePlateform.GetComponent<BoxCollider2D>().size.x;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < generationPoint.position.x)
        {
            distanceBetween = Random.Range (distanceBetweenMin,distanceBetweenMax);

            transform.position = new Vector3(transform.position.x + plateformWidth + distanceBetween, transform.position.y, transform.position.z);

            //Instantiate(thePlateform, transform.position, transform.rotation);
            GameObject newPlateform = theObjectPool.GetPooledObject();

            newPlateform.transform.position = transform.position;
            newPlateform.transform.rotation = transform.rotation;
            newPlateform.SetActive (true);


        }
	
	}
}
