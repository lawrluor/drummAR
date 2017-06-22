using UnityEngine;


public class SnareCollision : MonoBehaviour {
    AudioSource SnareAudio;

    void Start()
    {
        SnareAudio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collision)
    {
        // activates on any part of the collision space
        /*foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }*/
        // checking impact magnitude
        // if (collision.relativeVelocity.magnitude > 2)
        SnareAudio.Play();
    }
}
