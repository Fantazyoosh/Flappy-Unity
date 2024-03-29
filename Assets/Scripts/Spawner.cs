using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   

    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight =  1f;

public void Spawn()
{
    GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
    pipes.transform.position += Vector3.up *  Random.Range(minHeight, maxHeight);
}




public void OnEnable(){
    InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
}
public void OnDisable()
{
    CancelInvoke(nameof(Spawn));

}


}
 