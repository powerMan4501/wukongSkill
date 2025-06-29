using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.LandmassEditor;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/LandmassEditor.LandmassBlueprintFunctionLibrary", "LandmassEditor", UnrealModuleType.EnginePlugin)]
public class ULandmassBlueprintFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetCursorWorldRay_IsValid;

	private static IntPtr GetCursorWorldRay_FunctionAddress;

	private static int GetCursorWorldRay_ParamsSize;

	private static bool GetCursorWorldRay_CameraLocation_IsValid;

	private static FFieldAddress GetCursorWorldRay_CameraLocation_PropertyAddress;

	private static int GetCursorWorldRay_CameraLocation_Offset;

	private static bool GetCursorWorldRay_RayOrigin_IsValid;

	private static FFieldAddress GetCursorWorldRay_RayOrigin_PropertyAddress;

	private static int GetCursorWorldRay_RayOrigin_Offset;

	private static bool GetCursorWorldRay_RayDirection_IsValid;

	private static FFieldAddress GetCursorWorldRay_RayDirection_PropertyAddress;

	private static int GetCursorWorldRay_RayDirection_Offset;

	private static bool GetCursorWorldRay_ReturnValue_IsValid;

	private static FFieldAddress GetCursorWorldRay_ReturnValue_PropertyAddress;

	private static int GetCursorWorldRay_ReturnValue_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/LandmassEditor.LandmassBlueprintFunctionLibrary:GetCursorWorldRay")]
	public unsafe static bool GetCursorWorldRay(out FVector CameraLocation, out FVector RayOrigin, out FVector RayDirection)
	{
		if (!GetCursorWorldRay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LandmassEditor.LandmassBlueprintFunctionLibrary:GetCursorWorldRay");
			CameraLocation = default(FVector);
			RayOrigin = default(FVector);
			RayDirection = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCursorWorldRay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCursorWorldRay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCursorWorldRay_FunctionAddress, intPtr, GetCursorWorldRay_ParamsSize);
		CameraLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetCursorWorldRay_CameraLocation_Offset), 0, GetCursorWorldRay_CameraLocation_PropertyAddress.Address);
		RayOrigin = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetCursorWorldRay_RayOrigin_Offset), 0, GetCursorWorldRay_RayOrigin_PropertyAddress.Address);
		RayDirection = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetCursorWorldRay_RayDirection_Offset), 0, GetCursorWorldRay_RayDirection_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCursorWorldRay_ReturnValue_Offset), 0, GetCursorWorldRay_ReturnValue_PropertyAddress.Address);
	}

	static ULandmassBlueprintFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULandmassBlueprintFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULandmassBlueprintFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/LandmassEditor.LandmassBlueprintFunctionLibrary");
		GetCursorWorldRay_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCursorWorldRay");
		GetCursorWorldRay_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCursorWorldRay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCursorWorldRay_CameraLocation_PropertyAddress, GetCursorWorldRay_FunctionAddress, "CameraLocation");
		GetCursorWorldRay_CameraLocation_Offset = NativeReflectionCached.GetPropertyOffset(GetCursorWorldRay_FunctionAddress, "CameraLocation");
		GetCursorWorldRay_CameraLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCursorWorldRay_FunctionAddress, "CameraLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCursorWorldRay_RayOrigin_PropertyAddress, GetCursorWorldRay_FunctionAddress, "RayOrigin");
		GetCursorWorldRay_RayOrigin_Offset = NativeReflectionCached.GetPropertyOffset(GetCursorWorldRay_FunctionAddress, "RayOrigin");
		GetCursorWorldRay_RayOrigin_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCursorWorldRay_FunctionAddress, "RayOrigin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCursorWorldRay_RayDirection_PropertyAddress, GetCursorWorldRay_FunctionAddress, "RayDirection");
		GetCursorWorldRay_RayDirection_Offset = NativeReflectionCached.GetPropertyOffset(GetCursorWorldRay_FunctionAddress, "RayDirection");
		GetCursorWorldRay_RayDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCursorWorldRay_FunctionAddress, "RayDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCursorWorldRay_ReturnValue_PropertyAddress, GetCursorWorldRay_FunctionAddress, "ReturnValue");
		GetCursorWorldRay_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCursorWorldRay_FunctionAddress, "ReturnValue");
		GetCursorWorldRay_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCursorWorldRay_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCursorWorldRay_IsValid = GetCursorWorldRay_FunctionAddress != IntPtr.Zero && GetCursorWorldRay_CameraLocation_IsValid && GetCursorWorldRay_RayOrigin_IsValid && GetCursorWorldRay_RayDirection_IsValid && GetCursorWorldRay_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LandmassEditor.LandmassBlueprintFunctionLibrary:GetCursorWorldRay", GetCursorWorldRay_IsValid);
	}
}
