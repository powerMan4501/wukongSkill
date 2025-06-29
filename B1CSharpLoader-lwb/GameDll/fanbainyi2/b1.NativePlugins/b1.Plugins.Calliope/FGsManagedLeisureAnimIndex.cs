using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsManagedLeisureAnimIndex", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsManagedLeisureAnimIndex
{
	private static bool ParamType_IsValid;

	private static FFieldAddress ParamType_PropertyAddress;

	private static int ParamType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsManagedParamBase:ParamType")]
	public EGsManagedParamType ParamType;

	private static bool ConfigGuid_IsValid;

	private static int ConfigGuid_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsManagedParamBase:ConfigGuid")]
	public Guid ConfigGuid;

	private static bool AliasName_IsValid;

	private static int AliasName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedParamBase:AliasName")]
	public FName AliasName;

	private static bool LeisureAnimIndex_IsValid;

	private static int LeisureAnimIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedLeisureAnimIndex:LeisureAnimIndex")]
	public int LeisureAnimIndex;

	private static bool FGsManagedLeisureAnimIndex_IsValid;

	private static int FGsManagedLeisureAnimIndex_StructSize;

	public FGsManagedLeisureAnimIndex Copy()
	{
		return this;
	}

	public static FGsManagedLeisureAnimIndex FromNative(IntPtr nativeBuffer)
	{
		return new FGsManagedLeisureAnimIndex(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsManagedLeisureAnimIndex value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsManagedLeisureAnimIndex FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsManagedLeisureAnimIndex(nativeBuffer + arrayIndex * FGsManagedLeisureAnimIndex_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsManagedLeisureAnimIndex value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsManagedLeisureAnimIndex_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsManagedLeisureAnimIndex_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedLeisureAnimIndex");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LeisureAnimIndex_Offset), LeisureAnimIndex);
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FGsManagedLeisureAnimIndex(IntPtr nativeStruct)
	{
		if (!FGsManagedLeisureAnimIndex_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedLeisureAnimIndex");
			LeisureAnimIndex = 0;
			ParamType = EGsManagedParamType.None;
			ConfigGuid = default(Guid);
			AliasName = default(FName);
		}
		else
		{
			LeisureAnimIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LeisureAnimIndex_Offset));
			ParamType = EnumMarshaler<EGsManagedParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
		}
	}

	static FGsManagedLeisureAnimIndex()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsManagedLeisureAnimIndex)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsManagedLeisureAnimIndex));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsManagedLeisureAnimIndex");
		FGsManagedLeisureAnimIndex_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		AliasName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AliasName");
		AliasName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AliasName", Classes.FNameProperty);
		LeisureAnimIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LeisureAnimIndex");
		LeisureAnimIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LeisureAnimIndex", Classes.FIntProperty);
		FGsManagedLeisureAnimIndex_IsValid = intPtr != IntPtr.Zero && LeisureAnimIndex_IsValid && ParamType_IsValid && ConfigGuid_IsValid && AliasName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsManagedLeisureAnimIndex", FGsManagedLeisureAnimIndex_IsValid);
	}
}
