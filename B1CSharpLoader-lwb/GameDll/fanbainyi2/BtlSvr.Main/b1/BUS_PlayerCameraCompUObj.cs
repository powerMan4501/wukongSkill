using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_PlayerCameraCompUObj")]
public class BUS_PlayerCameraCompUObj : UActorCompBaseUObj
{
	private static bool OnSwitchCameraGroupTo_IsValid;

	private static IntPtr OnSwitchCameraGroupTo_FunctionAddress;

	private static int OnSwitchCameraGroupTo_ParamsSize;

	private static bool OnSwitchCameraGroupTo_TargetCameraGroupId_IsValid;

	private static int OnSwitchCameraGroupTo_TargetCameraGroupId_Offset;

	private static bool OnSwitchCameraGroupTo_Alpha_IsValid;

	private static int OnSwitchCameraGroupTo_Alpha_Offset;

	private static bool OnSwitchCameraGroupTo_BlendTime_IsValid;

	private static int OnSwitchCameraGroupTo_BlendTime_Offset;

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		UBGWCameraGroupVolumeManager uBGWCameraGroupVolumeManager = UBGWCameraGroupVolumeManager.Get(GetOwner());
		if (uBGWCameraGroupVolumeManager != null)
		{
			OnSwitchCameraGroupTo(uBGWCameraGroupVolumeManager.LastFrameTargetGroupId, 1f, 0.1f);
			uBGWCameraGroupVolumeManager.OnSwitchCameraGroupTo.Bind(this, B1GlobalFNames.OnSwitchCameraGroupTo);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		UBGWCameraGroupVolumeManager.Get(GetOwner())?.OnSwitchCameraGroupTo.Unbind(this, B1GlobalFNames.OnSwitchCameraGroupTo);
		base.OnEndPlay(EndPlayReason);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_PlayerCameraCompUObj:OnSwitchCameraGroupTo")]
	private void OnSwitchCameraGroupTo(int TargetCameraGroupId, float Alpha, float BlendTime)
	{
		if (TargetCameraGroupId < 0)
		{
			return;
		}
		APawn aPawn = Owner as APawn;
		if (aPawn != null)
		{
			APlayerController aPlayerController = aPawn.GetController() as APlayerController;
			if (aPlayerController != null)
			{
				BPS_EventCollectionCS.Get(aPlayerController)?.Evt_OnSwitchCameraGroupVolumeTo.Invoke(TargetCameraGroupId, Alpha, BlendTime);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_PlayerCameraCompUObj:OnSwitchCameraGroupTo")]
	private static void OnSwitchCameraGroupTo__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_PlayerCameraCompUObj bUS_PlayerCameraCompUObj = GCHelper.Find<BUS_PlayerCameraCompUObj>(obj);
		int targetCameraGroupId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnSwitchCameraGroupTo_TargetCameraGroupId_Offset));
		float alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OnSwitchCameraGroupTo_Alpha_Offset));
		float blendTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OnSwitchCameraGroupTo_BlendTime_Offset));
		bUS_PlayerCameraCompUObj.OnSwitchCameraGroupTo(targetCameraGroupId, alpha, blendTime);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_PlayerCameraCompUObj");
		OnSwitchCameraGroupTo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSwitchCameraGroupTo");
		OnSwitchCameraGroupTo_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSwitchCameraGroupTo_FunctionAddress);
		OnSwitchCameraGroupTo_TargetCameraGroupId_Offset = NativeReflection.GetPropertyOffset(OnSwitchCameraGroupTo_FunctionAddress, "TargetCameraGroupId");
		OnSwitchCameraGroupTo_TargetCameraGroupId_IsValid = NativeReflection.ValidatePropertyClass(OnSwitchCameraGroupTo_FunctionAddress, "TargetCameraGroupId", Classes.FIntProperty);
		OnSwitchCameraGroupTo_Alpha_Offset = NativeReflection.GetPropertyOffset(OnSwitchCameraGroupTo_FunctionAddress, "Alpha");
		OnSwitchCameraGroupTo_Alpha_IsValid = NativeReflection.ValidatePropertyClass(OnSwitchCameraGroupTo_FunctionAddress, "Alpha", Classes.FFloatProperty);
		OnSwitchCameraGroupTo_BlendTime_Offset = NativeReflection.GetPropertyOffset(OnSwitchCameraGroupTo_FunctionAddress, "BlendTime");
		OnSwitchCameraGroupTo_BlendTime_IsValid = NativeReflection.ValidatePropertyClass(OnSwitchCameraGroupTo_FunctionAddress, "BlendTime", Classes.FFloatProperty);
		OnSwitchCameraGroupTo_IsValid = OnSwitchCameraGroupTo_FunctionAddress != IntPtr.Zero && OnSwitchCameraGroupTo_TargetCameraGroupId_IsValid && OnSwitchCameraGroupTo_Alpha_IsValid && OnSwitchCameraGroupTo_BlendTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_PlayerCameraCompUObj:OnSwitchCameraGroupTo", OnSwitchCameraGroupTo_IsValid);
	}

	static BUS_PlayerCameraCompUObj()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_PlayerCameraCompUObj)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_PlayerCameraCompUObj));
	}
}
