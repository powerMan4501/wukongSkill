using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UClass(Flags = (ClassFlags)820510884uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Landscape.LandscapeSplinesComponent", "Landscape", UnrealModuleType.Engine)]
public class ULandscapeSplinesComponent : UPrimitiveComponent
{
	private static bool GetSplineMeshComponents_IsValid;

	private static IntPtr GetSplineMeshComponents_FunctionAddress;

	private static int GetSplineMeshComponents_ParamsSize;

	private static bool GetSplineMeshComponents_ReturnValue_IsValid;

	private static FFieldAddress GetSplineMeshComponents_ReturnValue_PropertyAddress;

	private static int GetSplineMeshComponents_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Landscape.LandscapeSplinesComponent:GetSplineMeshComponents")]
	public unsafe List<USplineMeshComponent> GetSplineMeshComponents()
	{
		CheckDestroyed();
		if (!GetSplineMeshComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeSplinesComponent:GetSplineMeshComponents");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSplineMeshComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSplineMeshComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSplineMeshComponents_FunctionAddress, intPtr, GetSplineMeshComponents_ParamsSize);
		List<USplineMeshComponent> result = new TArrayCopyMarshaler<USplineMeshComponent>(1, GetSplineMeshComponents_ReturnValue_PropertyAddress, CachedMarshalingDelegates<USplineMeshComponent, UObjectMarshaler<USplineMeshComponent>>.FromNative, CachedMarshalingDelegates<USplineMeshComponent, UObjectMarshaler<USplineMeshComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSplineMeshComponents_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSplineMeshComponents_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static ULandscapeSplinesComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULandscapeSplinesComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULandscapeSplinesComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Landscape.LandscapeSplinesComponent");
		GetSplineMeshComponents_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSplineMeshComponents");
		GetSplineMeshComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSplineMeshComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSplineMeshComponents_ReturnValue_PropertyAddress, GetSplineMeshComponents_FunctionAddress, "ReturnValue");
		GetSplineMeshComponents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSplineMeshComponents_FunctionAddress, "ReturnValue");
		GetSplineMeshComponents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSplineMeshComponents_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSplineMeshComponents_IsValid = GetSplineMeshComponents_FunctionAddress != IntPtr.Zero && GetSplineMeshComponents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Landscape.LandscapeSplinesComponent:GetSplineMeshComponents", GetSplineMeshComponents_IsValid);
	}
}
