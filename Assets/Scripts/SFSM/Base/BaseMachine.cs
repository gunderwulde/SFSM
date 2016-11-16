using UnityEngine;

public class BaseMachine<TBaseMachine> {
	TBaseMachine			m_data; 
	RootState<TBaseMachine> m_current;

	public BaseMachine(){
		m_data = (TBaseMachine)System.Convert.ChangeType( this, typeof(TBaseMachine) ); 
	}
	
	public void Change(RootState<TBaseMachine> newState){
		if(m_current!=null) m_current.End(m_data);
		m_current = newState;
		if(m_current!=null) m_current.Start(m_data);
	}

	public void Update(){
		if(m_current!=null) m_current.Update(m_data);
	}
}
