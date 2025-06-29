using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_AutoResetGISCVarMgr")]
public class BGW_AutoResetGISCVarMgr : GameInstanceSystemBaseUObj
{
	public List<GISCvar> CvarToBeReset = new List<GISCvar>();

	public override bool bTickEnabled => true;

	public override void OnInit()
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		bGW_EventCollection.Evt_RegisterAutoResetGISCVar = (Action<GISCvar>)Delegate.Combine(bGW_EventCollection.Evt_RegisterAutoResetGISCVar, new Action<GISCvar>(RegisterAutoResetGISCVar));
	}

	protected void RegisterAutoResetGISCVar(GISCvar Cvar)
	{
		CvarToBeReset.Add(Cvar);
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		for (int num = CvarToBeReset.Count - 1; num >= 0; num--)
		{
			GISCvar gISCvar = CvarToBeReset[num];
			gISCvar.ResetFrameCounter--;
			if (gISCvar.ResetFrameCounter <= 0)
			{
				gISCvar.RelatedGameInstObj.ResetCvar(gISCvar.Name);
				CvarToBeReset.RemoveAt(num);
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_AutoResetGISCVarMgr");
	}

	static BGW_AutoResetGISCVarMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_AutoResetGISCVarMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_AutoResetGISCVarMgr));
	}
}
