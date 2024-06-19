using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject TpIn; 

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            Debug.Log("들어감 In");
           
            TPInMemory();
            Destroy(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    
    void TPInMemory()
    {
        Vector3 posIn;
        posIn = this.gameObject.transform.position;
        
        //Vector3 posIn = gameObject.transform.position;
        // if(GameObject.Find("TpIn"))//텔포가 있으면a
        // {
        //     Debug.Log("확인 In");
        //     Destroy(TpIn.gameObject);
        //     Instantiate(TpIn,transform.position,Quaternion.identity);
        // }

        Instantiate(TpIn,transform.position,Quaternion.identity);
        TpIn.transform.position = posIn;
        Debug.Log("확인불가 In");
        GameObject existingPrefab = GameObject.FindWithTag("Player");
        if (existingPrefab != null)// 기존 프리팹이 존재하면 제거
        {
            Destroy(existingPrefab);
        }
    }
}