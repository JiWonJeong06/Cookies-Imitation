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
            int OnUnder = Random.Range(0,2);

            if(OnUnder == 0) {
            int ran = Random.Range(0, under_objs.Length);
            GameObject randomObj = under_objs[ran];
            Instantiate(randomObj, new Vector3(15, -1.5f, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
            }

            else if (OnUnder == 1) {
                int ran = Random.Range(0, on_objs.Length);
                GameObject randomObj = on_objs[ran];
                Instantiate(randomObj, new Vector3(15, -0.25f, 0), Quaternion.identity);
                yield return new WaitForSeconds(spawnInterval);
            }
        }
    }
}
