using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class DestroyPlatform : MonoBehaviour
{
    Rigidbody rigidbody;
    public float destroyTime;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlatformManager.Instance.StartCoroutine("spawnPlatform", 
                new Vector3(transform.position.x, transform.position.y, transform.position.z));
            Destroy(this.gameObject, destroyTime);
        }
    }
    void FallPlatform()
    {
        rigidbody.isKinematic = false;
    }
}

