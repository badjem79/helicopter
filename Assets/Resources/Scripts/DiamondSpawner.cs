using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondSpawner : MonoBehaviour
{
    public GameObject[] prefabs;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnDiamonds());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnDiamonds() {
		while (true) {

			// number of diamonds we could spawn vertically
			int diamondsThisRow = Random.Range(1, 2);

			// instantiate all diamonds in this row separated by some random amount of space
			for (int i = 0; i < diamondsThisRow; i++) {
				Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(30, Random.Range(-10, 10), 10), Quaternion.identity);
			}

			// pause 5-10 seconds until the next diamonds spawns
			yield return new WaitForSeconds(Random.Range(5, 10));
		}
	}
}
