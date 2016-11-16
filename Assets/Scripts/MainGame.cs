using UnityEngine;
using System.Collections;

public class MainGame : MonoBehaviour {
	MainMachine mm = new MainMachine();

	void Start () {
		mm.Change( MainState.Instance );
	}
	
	// Update is called once per frame
	void Update () {
		mm.Update();
	}
}
