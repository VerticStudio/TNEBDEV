using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour {
    public Transform prefab;
    private IEnumerator coroutine;
    float pos;

    void Awake()
    {
        // - After 0 seconds, prints "Starting 0.0 seconds"
        // - After 0 seconds, prints "Coroutine started"
        // - After 2 seconds, prints "Coroutine ended: 2.0 seconds"
        print("Starting " + Time.time + " seconds");

        // Start function WaitAndPrint as a coroutine.

        coroutine = WaitAndPrint(4.0f);
        StartCoroutine(coroutine);

        print("Coroutine started");
        Instantiate(prefab, new Vector3(pos, -6, 0), Quaternion.identity);
        pos = Random.Range(-2.49F, 3.63F);
    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Instantiate(prefab, new Vector3(pos, -6, 0), Quaternion.identity);
        pos = Random.Range(-2.49F, 3.63F);
        coroutine = WaitAndPrint(4.0f);
        StartCoroutine(coroutine);
    }
}
