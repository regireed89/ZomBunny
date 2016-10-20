using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour

{
	public int Score;
	// Use this for initialization
	void Start () 
	{
		Debug.Log (Score);
	}

	// Update is called once per frame
	void Update () 
	{
		Bleh ();
	}

	public void Bleh()
	{
		Score++;
	}
}