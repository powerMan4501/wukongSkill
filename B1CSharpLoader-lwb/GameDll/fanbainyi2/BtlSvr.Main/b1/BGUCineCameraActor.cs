using System;
using UnrealEngine.CinematicCamera;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUCineCameraActor")]
public class BGUCineCameraActor : ACineCameraActor, ICameraObj
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

	public ECameraType CameraType => ECameraType.Cine;

	[USharpPath("/Script/b1-Managed.BGUCineCameraActor:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
		BGS_EventCollectionCS.Get(this)?.Evt_RegisterCameraObj.Invoke(this);
	}

	[USharpPath("/Script/b1-Managed.BGUCineCameraActor:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		BGS_EventCollectionCS.Get(this)?.Evt_UnregisterCameraObj.Invoke(this);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUCineCameraActor:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCineCameraActor bGUCineCameraActor = GCHelper.Find<BGUCineCameraActor>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		bGUCineCameraActor.ReceiveEndPlay_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUCineCameraActor:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCineCameraActor bGUCineCameraActor = GCHelper.Find<BGUCineCameraActor>(obj);
		bGUCineCameraActor.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUCineCameraActor");
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUCineCameraActor:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUCineCameraActor:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}

	static BGUCineCameraActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUCineCameraActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUCineCameraActor));
	}
}
