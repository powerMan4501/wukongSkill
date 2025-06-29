using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN Spawn Ghost")]
[USharpPath("/Script/b1-Managed.BAN_GSGhost")]
internal class BAN_GSGhost : BAN_GSBase
{
	private static bool GhostSettings_IsValid;

	private static int GhostSettings_Offset;

	private static bool MontageToMapTo_IsValid;

	private static int MontageToMapTo_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[Category("Ghost Settings")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSGhost:GhostSettings")]
	public BGWDataAsset_GhostActorSetting GhostSettings
	{
		get
		{
			CheckDestroyed();
			if (!GhostSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSGhost:GhostSettings");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_GhostActorSetting>.FromNative(IntPtr.Add(base.Address, GhostSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GhostSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSGhost:GhostSettings");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_GhostActorSetting>.ToNative(IntPtr.Add(base.Address, GhostSettings_Offset), value);
			}
		}
	}

	[Category("Ghost Settings")]
	[UProperty]
	[EditAnywhere]
	[Tooltip("将当前播放的动画映射为该montage，对于非精准闪避的动画想复用之前为精准闪避bake的一套SM时作为残影时，可配置该montage")]
	[USharpPath("/Script/b1-Managed.BAN_GSGhost:MontageToMapTo")]
	public UAnimMontage MontageToMapTo
	{
		get
		{
			CheckDestroyed();
			if (!MontageToMapTo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSGhost:MontageToMapTo");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, MontageToMapTo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MontageToMapTo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSGhost:MontageToMapTo");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, MontageToMapTo_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSGhost:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor aActor = NotifyParam.MeshComp?.GetOwner();
		if (aActor != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
			if (bUS_GSEventCollection != null && GhostSettings != null)
			{
				bUS_GSEventCollection.Evt_SpawnGhostActor.Invoke(GhostSettings.PathName, default(FEffectInstReq), MontageToMapTo);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSGhost:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSGhost bAN_GSGhost = GCHelper.Find<b1.BAN_GSGhost>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSGhost.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSGhost");
		GhostSettings_Offset = NativeReflection.GetPropertyOffset(intPtr, "GhostSettings");
		GhostSettings_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GhostSettings", Classes.FObjectProperty);
		MontageToMapTo_Offset = NativeReflection.GetPropertyOffset(intPtr, "MontageToMapTo");
		MontageToMapTo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MontageToMapTo", Classes.FObjectProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSGhost:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSGhost()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSGhost)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSGhost));
	}
}
