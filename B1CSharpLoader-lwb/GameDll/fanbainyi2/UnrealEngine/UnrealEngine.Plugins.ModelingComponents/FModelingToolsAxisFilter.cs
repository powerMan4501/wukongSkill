using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingComponents;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ModelingComponents.ModelingToolsAxisFilter", "ModelingComponents", UnrealModuleType.EnginePlugin)]
public struct FModelingToolsAxisFilter
{
	private static bool FModelingToolsAxisFilter_IsValid;

	private static int FModelingToolsAxisFilter_StructSize;

	public FModelingToolsAxisFilter Copy()
	{
		return this;
	}

	public static FModelingToolsAxisFilter FromNative(IntPtr nativeBuffer)
	{
		return new FModelingToolsAxisFilter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FModelingToolsAxisFilter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FModelingToolsAxisFilter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FModelingToolsAxisFilter(nativeBuffer + arrayIndex * FModelingToolsAxisFilter_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FModelingToolsAxisFilter value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FModelingToolsAxisFilter_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FModelingToolsAxisFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ModelingComponents.ModelingToolsAxisFilter");
		}
	}

	public FModelingToolsAxisFilter(IntPtr nativeStruct)
	{
		if (!FModelingToolsAxisFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ModelingComponents.ModelingToolsAxisFilter");
		}
	}

	static FModelingToolsAxisFilter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FModelingToolsAxisFilter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FModelingToolsAxisFilter));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ModelingComponents.ModelingToolsAxisFilter");
		FModelingToolsAxisFilter_StructSize = NativeReflection.GetStructSize(intPtr);
		FModelingToolsAxisFilter_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ModelingComponents.ModelingToolsAxisFilter", FModelingToolsAxisFilter_IsValid);
	}
}
