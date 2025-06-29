using System;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_TransStyleStickCS")]
public class BI_TransStyleStickCS : BI_TransStyleCS
{
	private BI_StickLevelCS StickLevel;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		StickLevel = FindChildWidget("BI_TransStyleBase") as BI_StickLevelCS;
		StickLevel.ShowType = EStickLevelShowType.Trans;
	}

	public override void OnShowState(bool IsShow)
	{
		StickLevel.OnShowState(IsShow);
		if (IsShow)
		{
			PotentialEnergyData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_PotentialEnergyData>(B1ActorTag.CurPlayerActor);
			StickLevel.OnPELimitNormalChange(PotentialEnergyData.PELimit_Normal, PotentialEnergyData.PELimit_Normal);
		}
	}

	protected override void OnBindPevalueChange(int AttrId, float OldValue, float NewValue)
	{
	}

	protected override void OnPevalueChange(EBGUAttrFloat EBGUAttrFloat, float OldValue, float NewValue)
	{
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_TransStyleStickCS");
	}

	static BI_TransStyleStickCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_TransStyleStickCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_TransStyleStickCS));
	}
}
