using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_EnvironmentItemStateMachineData
{
	public bool bEnableBoxOverlapping;

	public ETriggerUnitFilter TriggerUnitFilter;

	public float TriggerRange;

	public bool bCanTriggerRepeatedly;

	public int SpecifiedResID;

	public List<int> ResIDBlackList;

	public bool bHasTriggered;

	private TStrongObjectPtr<AActor> mBeginOverlapActor = new TStrongObjectPtr<AActor>();

	private TStrongObjectPtr<AActor> mRealEndOverlapActor = new TStrongObjectPtr<AActor>();

	private TStrongObjectPtr<AActor> mSwitchFromActor = new TStrongObjectPtr<AActor>();

	private TStrongObjectPtr<AActor> mSwitchToActor = new TStrongObjectPtr<AActor>();

	public AActor BeginOverlapActor
	{
		get
		{
			return mBeginOverlapActor.Get();
		}
		set
		{
			mBeginOverlapActor.Set(value);
		}
	}

	public AActor RealEndOverlapActor
	{
		get
		{
			return mRealEndOverlapActor.Get();
		}
		set
		{
			mRealEndOverlapActor.Set(value);
		}
	}

	public AActor SwitchFromActor
	{
		get
		{
			return mSwitchFromActor.Get();
		}
		set
		{
			mSwitchFromActor.Set(value);
		}
	}

	public AActor SwitchToActor
	{
		get
		{
			return mSwitchToActor.Get();
		}
		set
		{
			mSwitchToActor.Set(value);
		}
	}

	public void CopyBPDataToData(bool InEnableBoxOverlapping, ETriggerUnitFilter InTriggerUnitFilter, float InTriggerRange, bool InCanTriggerRepeatedly, int InSpecifiedResID, List<int> InResIDBlackList)
	{
		bEnableBoxOverlapping = InEnableBoxOverlapping;
		TriggerUnitFilter = InTriggerUnitFilter;
		TriggerRange = InTriggerRange;
		bCanTriggerRepeatedly = InCanTriggerRepeatedly;
		SpecifiedResID = InSpecifiedResID;
		ResIDBlackList = InResIDBlackList;
	}
}
