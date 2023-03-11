using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float time;
    public GameObject pipes;
    public float height;
    public BirdFlying birdFlying;
    void Start()
    {
        StartCoroutine(SpawnObject(time));
        
    }

    void Update()
    {
        
    }
    public IEnumerator SpawnObject(float time) {
        while(!birdFlying.isDead){
            yield return new WaitForSeconds(time);
            Instantiate(pipes,new Vector3(3,Random.Range((-height+0.7f),(height+0.7f)),0), Quaternion.identity);  
        }
        
    }
}
