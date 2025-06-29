using System;
using System.Runtime.CompilerServices;
using UnrealEngine.CinematicCamera;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEngineExtent;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GSEngineExtent.GSECameraRig_Rail", "GSEngineExtent", UnrealModuleType.GamePlugin)]
public class AGSECameraRig_Rail : ACameraRig_Rail
{
	private static bool GetSplineLength_IsValid;

	private static IntPtr GetSplineLength_FunctionAddress;

	private static int GetSplineLength_ParamsSize;

	private static bool GetSplineLength_ReturnValue_IsValid;

	private static FFieldAddress GetSplineLength_ReturnValue_PropertyAddress;

	private static int GetSplineLength_ReturnValue_Offset;

	[UFunction(Flags = 67372033u)]
	[UMetaPath("/Script/GSEngineExtent.GSECameraRig_Rail:GetSplineLength")]
	public unsafe float GetSplineLength()
	{
		CheckDestroyed();
		if (!GetSplineLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSECameraRig_Rail:GetSplineLength");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSplineLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSplineLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSplineLength_FunctionAddress, intPtr, GetSplineLength_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetSplineLength_ReturnValue_Offset), 0, GetSplineLength_ReturnValue_PropertyAddress.Address);
	}

	static AGSECameraRig_Rail()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGSECameraRig_Rail)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGSECameraRig_Rail));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/GSEngineExtent.GSECameraRig_Rail");
		GetSplineLength_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSplineLength");
		GetSplineLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSplineLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSplineLength_ReturnValue_PropertyAddress, GetSplineLength_FunctionAddress, "ReturnValue");
		GetSplineLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSplineLength_FunctionAddress, "ReturnValue");
		GetSplineLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSplineLength_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetSplineLength_IsValid = GetSplineLength_FunctionAddress != IntPtr.Zero && GetSplineLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSECameraRig_Rail:GetSplineLength", GetSplineLength_IsValid);
	}
}
