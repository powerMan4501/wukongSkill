using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsManagedInteractGroupID", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsManagedInteractGroupID
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

	private static bool InteractGroupID_IsValid;

	private static int InteractGroupID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedInteractGroupID:InteractGroupID")]
	public int InteractGroupID;

	private static bool FGsManagedInteractGroupID_IsValid;

	private static int FGsManagedInteractGroupID_StructSize;

	public FGsManagedInteractGroupID Copy()
	{
		return this;
	}

	public static FGsManagedInteractGroupID FromNative(IntPtr nativeBuffer)
	{
		return new FGsManagedInteractGroupID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsManagedInteractGroupID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsManagedInteractGroupID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsManagedInteractGroupID(nativeBuffer + arrayIndex * FGsManagedInteractGroupID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsManagedInteractGroupID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsManagedInteractGroupID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsManagedInteractGroupID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedInteractGroupID");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, InteractGroupID_Offset), InteractGroupID);
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FGsManagedInteractGroupID(IntPtr nativeStruct)
	{
		if (!FGsManagedInteractGroupID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedInteractGroupID");
			InteractGroupID = 0;
			ParamType = EGsManagedParamType.None;
			ConfigGuid = default(Guid);
			AliasName = default(FName);
		}
		else
		{
			InteractGroupID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, InteractGroupID_Offset));
			ParamType = EnumMarshaler<EGsManagedParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
		}
	}

	static FGsManagedInteractGroupID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsManagedInteractGroupID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsManagedInteractGroupID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsManagedInteractGroupID");
		FGsManagedInteractGroupID_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		AliasName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AliasName");
		AliasName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AliasName", Classes.FNameProperty);
		InteractGroupID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InteractGroupID");
		InteractGroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InteractGroupID", Classes.FIntProperty);
		FGsManagedInteractGroupID_IsValid = intPtr != IntPtr.Zero && InteractGroupID_IsValid && ParamType_IsValid && ConfigGuid_IsValid && AliasName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsManagedInteractGroupID", FGsManagedInteractGroupID_IsValid);
	}
}
