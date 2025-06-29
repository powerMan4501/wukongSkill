using System;
using b1.GSMUI;

namespace b1;

public class GSDestructEvent : IGSMUIDestruct
{
	public event Action Evt_DestructEvent;

	public void GSOnDestruct()
	{
		this.Evt_DestructEvent?.Invoke();
		this.Evt_DestructEvent = null;
	}
}
