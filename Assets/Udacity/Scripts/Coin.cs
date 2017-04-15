using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    public GameObject coinPoofPrefab;
    
    public void OnCoinClicked() {
        Object.Instantiate(coinPoofPrefab, transform.position, Quaternion.Euler(-90f, 0f, 0f));
        Destroy(this.gameObject);
    }

}
