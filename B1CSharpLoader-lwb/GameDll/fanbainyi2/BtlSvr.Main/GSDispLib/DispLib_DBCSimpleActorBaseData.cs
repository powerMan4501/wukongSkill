using System;
using System.Collections.Generic;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintSpawnableComponent]
[UClass]
[USharpPath("/Script/b1-Managed.DispLib_DBCSimpleActorBaseData")]
public class DispLib_DBCSimpleActorBaseData : UBaseActorComp
{
	private bool InitOver;

	public bool isPause;

	public bool AtEndStage;

	public BUS_DispLibEventCollection.Del_Void Evt_DataInitFinish = delegate
	{
	};

	public BUS_DispLibEventCollection.Del_OneIntBool Evt_SetPause = delegate
	{
	};

	public BUS_DispLibEventCollection.Del_OneFloat Evt_OnEndStageStart = delegate
	{
	};

	private List<UNiagaraComponent> AllNiagaraComps = new List<UNiagaraComponent>();

	private float Duration;

	private float EndStageDuration;

	private float EndAtTime;

	private USceneComponent EmitterComp;

	private FVector EmitterStartPos;

	private USceneComponent TargetComp;

	private FVector TargetStartPos;

	public bool GetInitOver()
	{
		return InitOver;
	}

	public List<UNiagaraComponent> GetAllNiagaraComps()
	{
		return AllNiagaraComps;
	}

	private void OnEndStageStart(float _EndStageDuration)
	{
		AtEndStage = true;
		EndStageDuration = _EndStageDuration;
		EndAtTime += EndStageDuration;
		foreach (UNiagaraComponent allNiagaraComp in AllNiagaraComps)
		{
			if (!allNiagaraComp.IsNullOrDestroyed())
			{
				allNiagaraComp.SetVariableBool(BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxStop, InValue: true);
			}
		}
	}

	public float GetDuration()
	{
		return Duration;
	}

	public float GetEndStageDuration()
	{
		return EndStageDuration;
	}

	public float GetEndAtTime()
	{
		return EndAtTime;
	}

	public USceneComponent GetEmitterComp()
	{
		return EmitterComp;
	}

	public FVector GetEmitterStartPos()
	{
		return EmitterStartPos;
	}

	public USceneComponent GetTargetComp()
	{
		return TargetComp;
	}

	public FVector GetTargetStartPos()
	{
		return TargetStartPos;
	}

	public void Init(float _Duration, float _EndAtTime, USceneComponent _EmitterComp, FVector _EmitterStartPos, USceneComponent _TargetComp, FVector _TargetStartPos)
	{
		InitOver = false;
		Duration = _Duration;
		EndAtTime = _EndAtTime;
		EmitterComp = _EmitterComp;
		TargetComp = _TargetComp;
		EmitterStartPos = _EmitterStartPos;
		TargetStartPos = _TargetStartPos;
		AtEndStage = false;
		foreach (UActorComponent item in GetOwner().GetComponentsByClass(UClass.GetClass<UNiagaraComponent>()))
		{
			AllNiagaraComps.Add(item as UNiagaraComponent);
		}
		Evt_OnEndStageStart = (BUS_DispLibEventCollection.Del_OneFloat)Delegate.Combine(Evt_OnEndStageStart, new BUS_DispLibEventCollection.Del_OneFloat(OnEndStageStart));
		InitOver = true;
		Evt_DataInitFinish();
	}

	public void Reset()
	{
		InitOver = false;
		AtEndStage = false;
		EmitterComp = null;
		TargetComp = null;
		EmitterStartPos = default(FVector);
		TargetStartPos = default(FVector);
		AllNiagaraComps.Clear();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.DispLib_DBCSimpleActorBaseData");
	}

	static DispLib_DBCSimpleActorBaseData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DispLib_DBCSimpleActorBaseData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DispLib_DBCSimpleActorBaseData));
	}
}
