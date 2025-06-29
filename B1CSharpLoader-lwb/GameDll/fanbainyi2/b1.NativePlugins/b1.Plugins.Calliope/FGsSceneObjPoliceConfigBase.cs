using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsSceneObjPoliceConfigBase", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsSceneObjPoliceConfigBase
{
	private static bool ConfigGuid_IsValid;

	private static int ConfigGuid_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsSceneObjPoliceConfigBase:ConfigGuid")]
	public Guid ConfigGuid;

	private static bool FGsSceneObjPoliceConfigBase_IsValid;

	private static int FGsSceneObjPoliceConfigBase_StructSize;

	public FGsSceneObjPoliceConfigBase Copy()
	{
		return this;
	}

	public static FGsSceneObjPoliceConfigBase FromNative(IntPtr nativeBuffer)
	{
		return new FGsSceneObjPoliceConfigBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsSceneObjPoliceConfigBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsSceneObjPoliceConfigBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsSceneObjPoliceConfigBase(nativeBuffer + arrayIndex * FGsSceneObjPoliceConfigBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsSceneObjPoliceConfigBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsSceneObjPoliceConfigBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsSceneObjPoliceConfigBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsSceneObjPoliceConfigBase");
		}
		else
		{
			BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		}
	}

	public FGsSceneObjPoliceConfigBase(IntPtr nativeStruct)
	{
		if (!FGsSceneObjPoliceConfigBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsSceneObjPoliceConfigBase");
			ConfigGuid = default(Guid);
		}
		else
		{
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
		}
	}

	static FGsSceneObjPoliceConfigBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsSceneObjPoliceConfigBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsSceneObjPoliceConfigBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsSceneObjPoliceConfigBase");
		FGsSceneObjPoliceConfigBase_StructSize = NativeReflection.GetStructSize(intPtr);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		FGsSceneObjPoliceConfigBase_IsValid = intPtr != IntPtr.Zero && ConfigGuid_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsSceneObjPoliceConfigBase", FGsSceneObjPoliceConfigBase_IsValid);
	}
}
