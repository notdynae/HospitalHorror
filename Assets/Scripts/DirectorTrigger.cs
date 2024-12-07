using UnityEngine;
using UnityEngine.Playables;

public class DirectorTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider c) {
        GetComponent<PlayableDirector>().Play();
        // gameObject.SetActive(false);
    }
}
