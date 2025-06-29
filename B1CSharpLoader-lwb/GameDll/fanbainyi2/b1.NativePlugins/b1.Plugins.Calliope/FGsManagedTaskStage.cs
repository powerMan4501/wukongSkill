using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsManagedTaskStage", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsManagedTaskStage
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

	private static bool TaskStage_IsValid;

	private static int TaskStage_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedTaskStage:TaskStage")]
	public int TaskStage;

	private static bool FGsManagedTaskStage_IsValid;

	private static int FGsManagedTaskStage_StructSize;

	public FGsManagedTaskStage Copy()
	{
		return this;
	}

	public static FGsManagedTaskStage FromNative(IntPtr nativeBuffer)
	{
		return new FGsManagedTaskStage(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsManagedTaskStage value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsManagedTaskStage FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsManagedTaskStage(nativeBuffer + arrayIndex * FGsManagedTaskStage_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsManagedTaskStage value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsManagedTaskStage_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsManagedTaskStage_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedTaskStage");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TaskStage_Offset), TaskStage);
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FGsManagedTaskStage(IntPtr nativeStruct)
	{
		if (!FGsManagedTaskStage_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedTaskStage");
			TaskStage = 0;
			ParamType = EGsManagedParamType.None;
			ConfigGuid = default(Guid);
			AliasName = default(FName);
		}
		else
		{
			TaskStage = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TaskStage_Offset));
			ParamType = EnumMarshaler<EGsManagedParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
		}
	}

	static FGsManagedTaskStage()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsManagedTaskStage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsManagedTaskStage));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsManagedTaskStage");
		FGsManagedTaskStage_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		AliasName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AliasName");
		AliasName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AliasName", Classes.FNameProperty);
		TaskStage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TaskStage");
		TaskStage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TaskStage", Classes.FIntProperty);
		FGsManagedTaskStage_IsValid = intPtr != IntPtr.Zero && TaskStage_IsValid && ParamType_IsValid && ConfigGuid_IsValid && AliasName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsManagedTaskStage", FGsManagedTaskStage_IsValid);
	}
}
