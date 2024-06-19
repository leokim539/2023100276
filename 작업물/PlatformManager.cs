using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public static PlatformManager Instance = null;
    public GameObject platform;
    public float spawnTime = 3f;

    void Start()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);
    }
    IEnumerator spawnPlatform(Vector3 spawnPos)
    {
        yield return new WaitForSeconds(spawnTime);
        Instantiate(platform, spawnPos, platform.transform.rotation);
    }
}
