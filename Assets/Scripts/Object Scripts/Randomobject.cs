using System.Collections;
using UnityEngine;

public class RandomObject : MonoBehaviour
{
    public GameObject[] under_objs;
    public GameObject[] on_objs;
    public float spawnInterval;

    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    IEnumerator SpawnObject()
    {
        while (GameManager.Gamestart)
        {
        
            int ran = Random.Range(0, under_objs.Length);
            GameObject randomObj = under_objs[ran];
            Instantiate(randomObj, new Vector3(15, -1.5f, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);

        }
    }
}
