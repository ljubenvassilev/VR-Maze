using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    public GameObject keyPoofPrefab;
    public Door door;

	void Update()
	{
        transform.Rotate(0f, 0f, 100 * Time.deltaTime);
    }

	public void OnKeyClicked()
	{
        Object.Instantiate(keyPoofPrefab, transform.position, Quaternion.Euler(-90f, 0f, 0f));
        door.Unlock();
        Destroy(this.gameObject);
    }
}
