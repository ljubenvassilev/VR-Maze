using UnityEngine;

public class RotateCoinBehaviour : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0f, 100*Time.deltaTime, 0f);
	}
}
