using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsManagedStreamingLevel", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsManagedStreamingLevel
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

	private static bool PersistentLevelName_IsValid;

	private static int PersistentLevelName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedStreamingLevel:PersistentLevelName")]
	public FName PersistentLevelName;

	private static bool StreamingLevelName_IsValid;

	private static int StreamingLevelName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedStreamingLevel:StreamingLevelName")]
	public FName StreamingLevelName;

	private static bool State_IsValid;

	private static FFieldAddress State_PropertyAddress;

	private static int State_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedStreamingLevel:State")]
	public EGsStreamingLevelState State;

	private static bool FGsManagedStreamingLevel_IsValid;

	private static int FGsManagedStreamingLevel_StructSize;

	public FGsManagedStreamingLevel Copy()
	{
		return this;
	}

	public static FGsManagedStreamingLevel FromNative(IntPtr nativeBuffer)
	{
		return new FGsManagedStreamingLevel(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsManagedStreamingLevel value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsManagedStreamingLevel FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsManagedStreamingLevel(nativeBuffer + arrayIndex * FGsManagedStreamingLevel_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsManagedStreamingLevel value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsManagedStreamingLevel_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsManagedStreamingLevel_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedStreamingLevel");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, PersistentLevelName_Offset), PersistentLevelName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, StreamingLevelName_Offset), StreamingLevelName);
		EnumMarshaler<EGsStreamingLevelState>.ToNative(IntPtr.Add(nativeStruct, State_Offset), 0, State_PropertyAddress.Address, State);
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FGsManagedStreamingLevel(IntPtr nativeStruct)
	{
		if (!FGsManagedStreamingLevel_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedStreamingLevel");
			PersistentLevelName = default(FName);
			StreamingLevelName = default(FName);
			State = EGsStreamingLevelState.LoadedAndShown;
			ParamType = EGsManagedParamType.None;
			ConfigGuid = default(Guid);
			AliasName = default(FName);
		}
		else
		{
			PersistentLevelName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, PersistentLevelName_Offset));
			StreamingLevelName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, StreamingLevelName_Offset));
			State = EnumMarshaler<EGsStreamingLevelState>.FromNative(IntPtr.Add(nativeStruct, State_Offset), 0, State_PropertyAddress.Address);
			ParamType = EnumMarshaler<EGsManagedParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
		}
	}

	static FGsManagedStreamingLevel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsManagedStreamingLevel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsManagedStreamingLevel));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsManagedStreamingLevel");
		FGsManagedStreamingLevel_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		AliasName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AliasName");
		AliasName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AliasName", Classes.FNameProperty);
		PersistentLevelName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PersistentLevelName");
		PersistentLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PersistentLevelName", Classes.FNameProperty);
		StreamingLevelName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StreamingLevelName");
		StreamingLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StreamingLevelName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref State_PropertyAddress, intPtr, "State");
		State_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "State");
		State_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "State", Classes.FEnumProperty);
		FGsManagedStreamingLevel_IsValid = intPtr != IntPtr.Zero && PersistentLevelName_IsValid && StreamingLevelName_IsValid && State_IsValid && ParamType_IsValid && ConfigGuid_IsValid && AliasName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsManagedStreamingLevel", FGsManagedStreamingLevel_IsValid);
	}
}
