using System;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUDebugNiaActor")]
public class BGUDebugNiaActor : BGUActorBaseCS
{
	private TStrongObjectPtr<UNiagaraSystem> mDebugNiaSys = new TStrongObjectPtr<UNiagaraSystem>();

	private TStrongObjectPtr<UNiagaraComponent> mAOTargetNiaComp = new TStrongObjectPtr<UNiagaraComponent>();

	private TStrongObjectPtr<USceneComponent> mRootComp = new TStrongObjectPtr<USceneComponent>();

	private UNiagaraSystem DebugNiaSys
	{
		get
		{
			return mDebugNiaSys.Get();
		}
		set
		{
			mDebugNiaSys.Set(value);
		}
	}

	private UNiagaraComponent DebugNiaComp
	{
		get
		{
			return mAOTargetNiaComp.Get();
		}
		set
		{
			mAOTargetNiaComp.Set(value);
		}
	}

	private USceneComponent RootComp
	{
		get
		{
			return mRootComp.Get();
		}
		set
		{
			mRootComp.Set(value);
		}
	}

	public void SetVisibility(bool Vis)
	{
		DebugNiaComp.SetVisibility(Vis);
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		RootComp = initializer.CreateDefaultSubobject<USceneComponent>(this, new FName("RootComp"));
	}

	public void UpdateDebugNiaParam(FVector StartPos, FVector EndPos, FLinearColor DebugLineColor, float DebugBeamUpRadians, float DebugBeamWidth)
	{
		if (DebugNiaSys == null)
		{
			DebugNiaSys = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UNiagaraSystem>("NiagaraSystem'/Game/00Main/BPLibrary/Debug/TargetDebugLine/NG_target_debug_line.NG_target_debug_line'", ELoadResourceType.AsyncLoadAndCache);
		}
		if (DebugNiaComp == null)
		{
			DebugNiaComp = UNiagaraFunctionLibrary.SpawnSystemAttached(DebugNiaSys, GetOwner().GetRootComponent(), FName.None, FVector.ZeroVector, FRotator.ZeroRotator, EAttachLocation.KeepWorldPosition, bAutoDestroy: true);
			DebugNiaComp.SetVisibility(bNewVisibility: false);
			if (DebugNiaComp == null)
			{
				return;
			}
		}
		DebugNiaComp.SetVectorParameter(B1GlobalFNames.BeamStart, StartPos);
		DebugNiaComp.SetVectorParameter(B1GlobalFNames.BeamEnd, EndPos);
		DebugNiaComp.SetColorParameter(B1GlobalFNames.BeamColor, DebugLineColor);
		DebugNiaComp.SetFloatParameter(B1GlobalFNames.BeamUpRadians, DebugBeamUpRadians);
		DebugNiaComp.SetFloatParameter(B1GlobalFNames.BeamWidth, DebugBeamWidth);
		DebugNiaComp.SetFloatParameter(B1GlobalFNames.BeamRightRadians, 0f);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		DebugNiaSys = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UNiagaraSystem>("NiagaraSystem'/Game/00Main/BPLibrary/Debug/TargetDebugLine/NG_target_debug_line.NG_target_debug_line'", ELoadResourceType.SyncLoadAndCache);
		DebugNiaComp = UNiagaraFunctionLibrary.SpawnSystemAttached(DebugNiaSys, RootComp, FName.None, FVector.ZeroVector, FRotator.ZeroRotator, EAttachLocation.KeepWorldPosition, bAutoDestroy: true);
		DebugNiaComp.SetVisibility(bNewVisibility: false);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_ActorBaseDataComp>(this, new FName("DebugNiaDataComp"));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUDebugNiaActor");
	}

	static BGUDebugNiaActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUDebugNiaActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUDebugNiaActor));
	}
}
