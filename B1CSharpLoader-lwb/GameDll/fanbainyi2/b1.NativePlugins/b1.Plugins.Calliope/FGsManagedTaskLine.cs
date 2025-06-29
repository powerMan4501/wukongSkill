using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsManagedTaskLine", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsManagedTaskLine
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

	private static bool TaskLineID_IsValid;

	private static int TaskLineID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedTaskLine:TaskLineID")]
	public int TaskLineID;

	private static bool FGsManagedTaskLine_IsValid;

	private static int FGsManagedTaskLine_StructSize;

	public FGsManagedTaskLine Copy()
	{
		return this;
	}

	public static FGsManagedTaskLine FromNative(IntPtr nativeBuffer)
	{
		return new FGsManagedTaskLine(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsManagedTaskLine value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsManagedTaskLine FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsManagedTaskLine(nativeBuffer + arrayIndex * FGsManagedTaskLine_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsManagedTaskLine value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsManagedTaskLine_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsManagedTaskLine_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedTaskLine");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TaskLineID_Offset), TaskLineID);
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FGsManagedTaskLine(IntPtr nativeStruct)
	{
		if (!FGsManagedTaskLine_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedTaskLine");
			TaskLineID = 0;
			ParamType = EGsManagedParamType.None;
			ConfigGuid = default(Guid);
			AliasName = default(FName);
		}
		else
		{
			TaskLineID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TaskLineID_Offset));
			ParamType = EnumMarshaler<EGsManagedParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
		}
	}

	static FGsManagedTaskLine()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsManagedTaskLine)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsManagedTaskLine));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsManagedTaskLine");
		FGsManagedTaskLine_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		AliasName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AliasName");
		AliasName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AliasName", Classes.FNameProperty);
		TaskLineID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TaskLineID");
		TaskLineID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TaskLineID", Classes.FIntProperty);
		FGsManagedTaskLine_IsValid = intPtr != IntPtr.Zero && TaskLineID_IsValid && ParamType_IsValid && ConfigGuid_IsValid && AliasName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsManagedTaskLine", FGsManagedTaskLine_IsValid);
	}
}
