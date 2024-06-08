using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
	public GameObject pipe;
	public float spawn_rate = 1;
	private float timer = 0;
	
    void Start()
    {
			spawn_pipe();
    }

    // Update is called once per frame
    void Update()
    {
		if (timer < spawn_rate) {
			timer += Time.deltaTime;
		} else {
			spawn_pipe();
			timer = 0;
		}
    }

	void spawn_pipe() {
		Instantiate(pipe, transform.position, transform.rotation);
	}
}
