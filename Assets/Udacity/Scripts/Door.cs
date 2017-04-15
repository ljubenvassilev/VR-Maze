using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    public bool locked = true;
    private bool opening = false;
    public AudioClip lockedClip;
    public AudioClip unlockedClip;
    
    void Update() {
        if (opening)
        {
            if (transform.position.y < 8f)
            {
                transform.Translate(0f, 2.5f * Time.deltaTime, 0f, Space.World);
            } else
            {
                opening = false;
            }
        }
        // If the door is opening and it is not fully raised
            // Animate the door raising up
    }

    public void OnDoorClicked() {

        if (locked)
        {
            AudioSource.PlayClipAtPoint(lockedClip, transform.position);
        } else
        {
            opening = true;
            AudioSource.PlayClipAtPoint(unlockedClip, transform.position);
        }
            
    }

    public void Unlock()
    {
        AudioSource.PlayClipAtPoint(lockedClip, transform.position);
        locked = false;
    }
}
