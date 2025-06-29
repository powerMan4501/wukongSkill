using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsSmartParam", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsSmartParam
{
	private static bool ConfigGuid_IsValid;

	private static int ConfigGuid_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/Calliope.GsSmartParam:ConfigGuid")]
	public Guid ConfigGuid;

	private static bool FGsSmartParam_IsValid;

	private static int FGsSmartParam_StructSize;

	public FGsSmartParam Copy()
	{
		return this;
	}

	public static FGsSmartParam FromNative(IntPtr nativeBuffer)
	{
		return new FGsSmartParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsSmartParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsSmartParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsSmartParam(nativeBuffer + arrayIndex * FGsSmartParam_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsSmartParam value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsSmartParam_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsSmartParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsSmartParam");
		}
		else
		{
			BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		}
	}

	public FGsSmartParam(IntPtr nativeStruct)
	{
		if (!FGsSmartParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsSmartParam");
			ConfigGuid = default(Guid);
		}
		else
		{
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
		}
	}

	static FGsSmartParam()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsSmartParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsSmartParam));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsSmartParam");
		FGsSmartParam_StructSize = NativeReflection.GetStructSize(intPtr);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		FGsSmartParam_IsValid = intPtr != IntPtr.Zero && ConfigGuid_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsSmartParam", FGsSmartParam_IsValid);
	}
}
