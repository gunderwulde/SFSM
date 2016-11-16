using UnityEngine;
using System.Collections;

public class MainState:BaseState<MainState,MainMachine>{
	public override void Start (MainMachine _base) {
		_base.m_Value = 0;
		Debug.Log(">>> MatchTestState.Start ");
	}

	public override void Update (MainMachine _base) {
		Debug.Log(">>> MatchTestState.Update " + _base.m_Value); 
		_base.m_Value++;
		if(_base.m_Value>100)
			_base.Change(null);
	}

	public override void End (MainMachine _base) {
		Debug.Log(">>> MatchTestState.End"); 
	}

}
