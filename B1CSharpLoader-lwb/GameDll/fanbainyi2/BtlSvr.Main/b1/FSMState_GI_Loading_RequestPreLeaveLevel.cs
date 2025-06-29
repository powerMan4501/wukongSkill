using System;

namespace b1;

public class FSMState_GI_Loading_RequestPreLeaveLevel : FSMState_GI_LoadingBase
{
	public override void OnEnter()
	{
		throw new NotImplementedException();
	}

	public override int OnTick(float Delta)
	{
		return 100;
	}

	public override void OnExit()
	{
	}
}
