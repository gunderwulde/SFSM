using UnityEngine;
using System.Collections;

public class RootState<TRootState>{
	public virtual void Start 	(TRootState _base) { }
	public virtual void Update 	(TRootState _base) { }
	public virtual void End 	(TRootState _base) { }
}

public class BaseState<TBaseSate,TBaseMachine>:RootState<TBaseMachine> where TBaseSate:RootState<TBaseMachine>, new() {
	static TBaseSate _Instance;
	public static TBaseSate Instance{ get{ if(_Instance==null) _Instance= new TBaseSate(); return _Instance; } }
}