using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsManagedIdleAMIdx", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsManagedIdleAMIdx
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

	private static bool IdleAMIdx_IsValid;

	private static int IdleAMIdx_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedIdleAMIdx:IdleAMIdx")]
	public int IdleAMIdx;

	private static bool FGsManagedIdleAMIdx_IsValid;

	private static int FGsManagedIdleAMIdx_StructSize;

	public FGsManagedIdleAMIdx Copy()
	{
		return this;
	}

	public static FGsManagedIdleAMIdx FromNative(IntPtr nativeBuffer)
	{
		return new FGsManagedIdleAMIdx(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsManagedIdleAMIdx value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsManagedIdleAMIdx FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsManagedIdleAMIdx(nativeBuffer + arrayIndex * FGsManagedIdleAMIdx_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsManagedIdleAMIdx value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsManagedIdleAMIdx_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsManagedIdleAMIdx_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedIdleAMIdx");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IdleAMIdx_Offset), IdleAMIdx);
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FGsManagedIdleAMIdx(IntPtr nativeStruct)
	{
		if (!FGsManagedIdleAMIdx_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedIdleAMIdx");
			IdleAMIdx = 0;
			ParamType = EGsManagedParamType.None;
			ConfigGuid = default(Guid);
			AliasName = default(FName);
		}
		else
		{
			IdleAMIdx = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IdleAMIdx_Offset));
			ParamType = EnumMarshaler<EGsManagedParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
		}
	}

	static FGsManagedIdleAMIdx()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsManagedIdleAMIdx)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsManagedIdleAMIdx));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsManagedIdleAMIdx");
		FGsManagedIdleAMIdx_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		AliasName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AliasName");
		AliasName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AliasName", Classes.FNameProperty);
		IdleAMIdx_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IdleAMIdx");
		IdleAMIdx_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IdleAMIdx", Classes.FIntProperty);
		FGsManagedIdleAMIdx_IsValid = intPtr != IntPtr.Zero && IdleAMIdx_IsValid && ParamType_IsValid && ConfigGuid_IsValid && AliasName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsManagedIdleAMIdx", FGsManagedIdleAMIdx_IsValid);
	}
}
