using System;
using UnrealEngine.CinematicCamera;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUCameraRig_Crane")]
public class BGUCameraRig_Crane : ACameraRig_Crane, ICameraObj
{
	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	public ECameraType CameraType => ECameraType.Crane;

	[USharpPath("/Script/b1-Managed.BGUCameraRig_Crane:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
		BGS_EventCollectionCS.Get(this)?.Evt_RegisterCameraObj.Invoke(this);
	}

	[USharpPath("/Script/b1-Managed.BGUCameraRig_Crane:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		BGS_EventCollectionCS.Get(this)?.Evt_UnregisterCameraObj.Invoke(this);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUCameraRig_Crane:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCameraRig_Crane bGUCameraRig_Crane = GCHelper.Find<BGUCameraRig_Crane>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		bGUCameraRig_Crane.ReceiveEndPlay_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUCameraRig_Crane:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCameraRig_Crane bGUCameraRig_Crane = GCHelper.Find<BGUCameraRig_Crane>(obj);
		bGUCameraRig_Crane.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUCameraRig_Crane");
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUCameraRig_Crane:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUCameraRig_Crane:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}

	static BGUCameraRig_Crane()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUCameraRig_Crane)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUCameraRig_Crane));
	}
}
