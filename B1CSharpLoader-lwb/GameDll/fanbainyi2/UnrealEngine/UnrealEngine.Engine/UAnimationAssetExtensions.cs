using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/Engine.AnimationAssetExtensions", "Engine", UnrealModuleType.Engine)]
public class UAnimationAssetExtensions : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetSkeleton_IsValid;

	private static IntPtr GetSkeleton_FunctionAddress;

	private static int GetSkeleton_ParamsSize;

	private static bool GetSkeleton_InAsset_IsValid;

	private static FFieldAddress GetSkeleton_InAsset_PropertyAddress;

	private static int GetSkeleton_InAsset_Offset;

	private static bool GetSkeleton_ReturnValue_IsValid;

	private static FFieldAddress GetSkeleton_ReturnValue_PropertyAddress;

	private static int GetSkeleton_ReturnValue_Offset;

	[UFunction(Flags = 872555521u)]
	[UMetaPath("/Script/Engine.AnimationAssetExtensions:GetSkeleton")]
	public unsafe static USkeleton GetSkeleton(UAnimationAsset InAsset)
	{
		if (!GetSkeleton_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationAssetExtensions:GetSkeleton");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSkeleton_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSkeleton_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(intPtr, GetSkeleton_InAsset_Offset), 0, GetSkeleton_InAsset_PropertyAddress.Address, InAsset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSkeleton_FunctionAddress, intPtr, GetSkeleton_ParamsSize);
		return UObjectMarshaler<USkeleton>.FromNative(IntPtr.Add(intPtr, GetSkeleton_ReturnValue_Offset), 0, GetSkeleton_ReturnValue_PropertyAddress.Address);
	}

	static UAnimationAssetExtensions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimationAssetExtensions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimationAssetExtensions));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.AnimationAssetExtensions");
		GetSkeleton_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSkeleton");
		GetSkeleton_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSkeleton_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSkeleton_InAsset_PropertyAddress, GetSkeleton_FunctionAddress, "InAsset");
		GetSkeleton_InAsset_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeleton_FunctionAddress, "InAsset");
		GetSkeleton_InAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeleton_FunctionAddress, "InAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSkeleton_ReturnValue_PropertyAddress, GetSkeleton_FunctionAddress, "ReturnValue");
		GetSkeleton_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeleton_FunctionAddress, "ReturnValue");
		GetSkeleton_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeleton_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSkeleton_IsValid = GetSkeleton_FunctionAddress != IntPtr.Zero && GetSkeleton_InAsset_IsValid && GetSkeleton_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationAssetExtensions:GetSkeleton", GetSkeleton_IsValid);
	}
}
