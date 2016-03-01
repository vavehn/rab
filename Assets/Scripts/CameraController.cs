using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject playerdemerde;

    public GameObject Sol;

    private Vector3 offset;
	
	void Start () {
        	offset = transform.position - playerdemerde.transform.position;        
	}
	
	
	void LateUpdate () {
        	transform.position = playerdemerde.transform.position + offset * 1.1;
	}
}
