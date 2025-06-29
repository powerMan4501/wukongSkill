using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GameplayCameras;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GameplayCameras.MatineeCameraShakeFunctionLibrary", "GameplayCameras", UnrealModuleType.EnginePlugin)]
public class UMatineeCameraShakeFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool Conv_MatineeCameraShake_IsValid;

	private static IntPtr Conv_MatineeCameraShake_FunctionAddress;

	private static int Conv_MatineeCameraShake_ParamsSize;

	private static bool Conv_MatineeCameraShake_CameraShake_IsValid;

	private static FFieldAddress Conv_MatineeCameraShake_CameraShake_PropertyAddress;

	private static int Conv_MatineeCameraShake_CameraShake_Offset;

	private static bool Conv_MatineeCameraShake_ReturnValue_IsValid;

	private static FFieldAddress Conv_MatineeCameraShake_ReturnValue_PropertyAddress;

	private static int Conv_MatineeCameraShake_ReturnValue_Offset;

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GameplayCameras.MatineeCameraShakeFunctionLibrary:Conv_MatineeCameraShake")]
	public unsafe static UMatineeCameraShake Conv_MatineeCameraShake(UCameraShakeBase CameraShake)
	{
		if (!Conv_MatineeCameraShake_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayCameras.MatineeCameraShakeFunctionLibrary:Conv_MatineeCameraShake");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_MatineeCameraShake_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_MatineeCameraShake_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCameraShakeBase>.ToNative(IntPtr.Add(intPtr, Conv_MatineeCameraShake_CameraShake_Offset), 0, Conv_MatineeCameraShake_CameraShake_PropertyAddress.Address, CameraShake);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_MatineeCameraShake_FunctionAddress, intPtr, Conv_MatineeCameraShake_ParamsSize);
		return UObjectMarshaler<UMatineeCameraShake>.FromNative(IntPtr.Add(intPtr, Conv_MatineeCameraShake_ReturnValue_Offset), 0, Conv_MatineeCameraShake_ReturnValue_PropertyAddress.Address);
	}

	static UMatineeCameraShakeFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMatineeCameraShakeFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMatineeCameraShakeFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GameplayCameras.MatineeCameraShakeFunctionLibrary");
		Conv_MatineeCameraShake_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_MatineeCameraShake");
		Conv_MatineeCameraShake_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_MatineeCameraShake_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_MatineeCameraShake_CameraShake_PropertyAddress, Conv_MatineeCameraShake_FunctionAddress, "CameraShake");
		Conv_MatineeCameraShake_CameraShake_Offset = NativeReflectionCached.GetPropertyOffset(Conv_MatineeCameraShake_FunctionAddress, "CameraShake");
		Conv_MatineeCameraShake_CameraShake_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_MatineeCameraShake_FunctionAddress, "CameraShake", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_MatineeCameraShake_ReturnValue_PropertyAddress, Conv_MatineeCameraShake_FunctionAddress, "ReturnValue");
		Conv_MatineeCameraShake_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_MatineeCameraShake_FunctionAddress, "ReturnValue");
		Conv_MatineeCameraShake_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_MatineeCameraShake_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Conv_MatineeCameraShake_IsValid = Conv_MatineeCameraShake_FunctionAddress != IntPtr.Zero && Conv_MatineeCameraShake_CameraShake_IsValid && Conv_MatineeCameraShake_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayCameras.MatineeCameraShakeFunctionLibrary:Conv_MatineeCameraShake", Conv_MatineeCameraShake_IsValid);
	}
}
