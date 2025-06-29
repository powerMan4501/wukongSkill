using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.CinematicCamera;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/CinematicCamera.CineCameraActor", "CinematicCamera", UnrealModuleType.Engine)]
public class ACineCameraActor : ACameraActor
{
	private static bool LookatTrackingSettings_IsValid;

	private static int LookatTrackingSettings_Offset;

	private static bool GetCineCameraComponent_IsValid;

	private static IntPtr GetCineCameraComponent_FunctionAddress;

	private static int GetCineCameraComponent_ParamsSize;

	private static bool GetCineCameraComponent_ReturnValue_IsValid;

	private static FFieldAddress GetCineCameraComponent_ReturnValue_PropertyAddress;

	private static int GetCineCameraComponent_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/CinematicCamera.CineCameraActor:LookatTrackingSettings")]
	public FCameraLookatTrackingSettings LookatTrackingSettings
	{
		get
		{
			CheckDestroyed();
			if (!LookatTrackingSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CineCameraActor:LookatTrackingSettings");
				return default(FCameraLookatTrackingSettings);
			}
			return FCameraLookatTrackingSettings.FromNative(IntPtr.Add(base.Address, LookatTrackingSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LookatTrackingSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CineCameraActor:LookatTrackingSettings");
			}
			else
			{
				FCameraLookatTrackingSettings.ToNative(IntPtr.Add(base.Address, LookatTrackingSettings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/CinematicCamera.CineCameraActor:GetCineCameraComponent")]
	public unsafe UCineCameraComponent GetCineCameraComponent()
	{
		CheckDestroyed();
		if (!GetCineCameraComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicCamera.CineCameraActor:GetCineCameraComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCineCameraComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCineCameraComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCineCameraComponent_FunctionAddress, intPtr, GetCineCameraComponent_ParamsSize);
		return UObjectMarshaler<UCineCameraComponent>.FromNative(IntPtr.Add(intPtr, GetCineCameraComponent_ReturnValue_Offset), 0, GetCineCameraComponent_ReturnValue_PropertyAddress.Address);
	}

	static ACineCameraActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACineCameraActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACineCameraActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/CinematicCamera.CineCameraActor");
		LookatTrackingSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LookatTrackingSettings");
		LookatTrackingSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LookatTrackingSettings", Classes.FStructProperty);
		GetCineCameraComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCineCameraComponent");
		GetCineCameraComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCineCameraComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCineCameraComponent_ReturnValue_PropertyAddress, GetCineCameraComponent_FunctionAddress, "ReturnValue");
		GetCineCameraComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCineCameraComponent_FunctionAddress, "ReturnValue");
		GetCineCameraComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCineCameraComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCineCameraComponent_IsValid = GetCineCameraComponent_FunctionAddress != IntPtr.Zero && GetCineCameraComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicCamera.CineCameraActor:GetCineCameraComponent", GetCineCameraComponent_IsValid);
	}
}
