using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsCalliopeNodeParam", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsCalliopeNodeParam
{
	private static bool NodeGuid_IsValid;

	private static int NodeGuid_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Calliope.GsCalliopeNodeParam:NodeGuid")]
	public FCalliopeGuid NodeGuid;

	private static bool FGsCalliopeNodeParam_IsValid;

	private static int FGsCalliopeNodeParam_StructSize;

	public FGsCalliopeNodeParam Copy()
	{
		return this;
	}

	public static FGsCalliopeNodeParam FromNative(IntPtr nativeBuffer)
	{
		return new FGsCalliopeNodeParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsCalliopeNodeParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsCalliopeNodeParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsCalliopeNodeParam(nativeBuffer + arrayIndex * FGsCalliopeNodeParam_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsCalliopeNodeParam value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsCalliopeNodeParam_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsCalliopeNodeParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsCalliopeNodeParam");
		}
		else
		{
			FCalliopeGuid.ToNative(IntPtr.Add(nativeStruct, NodeGuid_Offset), NodeGuid);
		}
	}

	public FGsCalliopeNodeParam(IntPtr nativeStruct)
	{
		if (!FGsCalliopeNodeParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsCalliopeNodeParam");
			NodeGuid = default(FCalliopeGuid);
		}
		else
		{
			NodeGuid = FCalliopeGuid.FromNative(IntPtr.Add(nativeStruct, NodeGuid_Offset));
		}
	}

	static FGsCalliopeNodeParam()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsCalliopeNodeParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsCalliopeNodeParam));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsCalliopeNodeParam");
		FGsCalliopeNodeParam_StructSize = NativeReflection.GetStructSize(intPtr);
		NodeGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NodeGuid");
		NodeGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NodeGuid", Classes.FStructProperty);
		FGsCalliopeNodeParam_IsValid = intPtr != IntPtr.Zero && NodeGuid_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsCalliopeNodeParam", FGsCalliopeNodeParam_IsValid);
	}
}
