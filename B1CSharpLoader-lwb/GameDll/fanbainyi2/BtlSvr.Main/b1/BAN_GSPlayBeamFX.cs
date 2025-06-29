using System;
using System.Collections.Generic;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN Play Beam FX")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSPlayBeamFX")]
internal class BAN_GSPlayBeamFX : BAN_GSBase
{
	private static bool BeamFXSetting_IsValid;

	private static int BeamFXSetting_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool GetSoftReferences_IsValid;

	private static IntPtr GetSoftReferences_FunctionAddress;

	private static int GetSoftReferences_ParamsSize;

	private static bool GetSoftReferences_ReturnValue_IsValid;

	private static int GetSoftReferences_ReturnValue_Offset;

	private static FFieldAddress GetSoftReferences_ReturnValue_PropertyAddress;

	[Tooltip("Play Beam FX")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayBeamFX:BeamFXSetting")]
	public FGSBeamFXPlaySetting BeamFXSetting
	{
		get
		{
			CheckDestroyed();
			if (!BeamFXSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayBeamFX:BeamFXSetting");
				return default(FGSBeamFXPlaySetting);
			}
			return FGSBeamFXPlaySetting.FromNative(IntPtr.Add(base.Address, BeamFXSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeamFXSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayBeamFX:BeamFXSetting");
			}
			else
			{
				FGSBeamFXPlaySetting.ToNative(IntPtr.Add(base.Address, BeamFXSetting_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		FGSBeamFXPlaySetting beamFXSetting = new FGSBeamFXPlaySetting
		{
			Scale = FVector.OneVector,
			GSBeamTargetType = EBeamFXTargetActorType.CameraLockActor
		};
		BeamFXSetting = default(FGSBeamFXPlaySetting);
		BeamFXSetting = beamFXSetting;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSPlayBeamFX:GetSoftReferences")]
	protected override List<FSoftObjectPath> GetSoftReferences_Implementation()
	{
		List<FSoftObjectPath> list = new List<FSoftObjectPath>();
		if (!BeamFXSetting.BeamTemplate.IsNull)
		{
			list.Add(BeamFXSetting.BeamTemplate.ObjectPath);
		}
		return list;
	}

	public override void GetSoftReferencesCS(ref HashSet<FSoftObjectPath> SoftPathSet)
	{
		if (SoftPathSet == null)
		{
			SoftPathSet = new HashSet<FSoftObjectPath>();
		}
		if (!BeamFXSetting.BeamTemplate.IsNull)
		{
			SoftPathSet.Add(BeamFXSetting.BeamTemplate.ObjectPath);
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSPlayBeamFX:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		if (!(meshComp?.GetOwner() != null))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = meshComp.GetOwner() as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		TSoftObject<UNiagaraSystem> beamTemplate = BeamFXSetting.BeamTemplate;
		if (beamTemplate.IsNull)
		{
			return;
		}
		if (beamTemplate.Value == null)
		{
			if (base.isPreload)
			{
				return;
			}
			SyncLoadSoftPathObjAndAddPreloadedAsset<UAkAudioEvent>(BeamFXSetting.BeamTemplate.Path);
		}
		BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_PlayBeamFX.Invoke(BeamFXSetting);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSPlayBeamFX:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSPlayBeamFX bAN_GSPlayBeamFX = GCHelper.Find<b1.BAN_GSPlayBeamFX>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSPlayBeamFX.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSPlayBeamFX:GetSoftReferences")]
	private static void GetSoftReferences__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSPlayBeamFX bAN_GSPlayBeamFX = GCHelper.Find<b1.BAN_GSPlayBeamFX>(obj);
		TArrayCopyMarshaler<FSoftObjectPath> tArrayCopyMarshaler = new TArrayCopyMarshaler<FSoftObjectPath>(1, GetSoftReferences_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative);
		List<FSoftObjectPath> softReferences_Implementation = bAN_GSPlayBeamFX.GetSoftReferences_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetSoftReferences_ReturnValue_Offset), softReferences_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSPlayBeamFX");
		BeamFXSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeamFXSetting");
		BeamFXSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeamFXSetting", Classes.FStructProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSPlayBeamFX:GSNotifyCS", GSNotifyCS_IsValid);
		GetSoftReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSoftReferences");
		GetSoftReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSoftReferences_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetSoftReferences_ReturnValue_PropertyAddress, GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetSoftReferences_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSoftReferences_IsValid = GetSoftReferences_FunctionAddress != IntPtr.Zero && GetSoftReferences_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSPlayBeamFX:GetSoftReferences", GetSoftReferences_IsValid);
	}

	static BAN_GSPlayBeamFX()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSPlayBeamFX)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSPlayBeamFX));
	}
}
