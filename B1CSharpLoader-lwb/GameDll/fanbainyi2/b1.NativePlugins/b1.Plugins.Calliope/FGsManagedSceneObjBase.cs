using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsManagedSceneObjBase", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsManagedSceneObjBase
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

	private static bool ActorGuid_IsValid;

	private static int ActorGuid_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/Calliope.GsManagedSceneObjBase:ActorGuid")]
	public string ActorGuid;

	private static bool NeedStateManaged_IsValid;

	private static FFieldAddress NeedStateManaged_PropertyAddress;

	private static int NeedStateManaged_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedSceneObjBase:bNeedStateManaged")]
	public bool NeedStateManaged;

	private static bool FGsManagedSceneObjBase_IsValid;

	private static int FGsManagedSceneObjBase_StructSize;

	public FGsManagedSceneObjBase Copy()
	{
		return this;
	}

	public static FGsManagedSceneObjBase FromNative(IntPtr nativeBuffer)
	{
		return new FGsManagedSceneObjBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsManagedSceneObjBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsManagedSceneObjBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsManagedSceneObjBase(nativeBuffer + arrayIndex * FGsManagedSceneObjBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsManagedSceneObjBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsManagedSceneObjBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsManagedSceneObjBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedSceneObjBase");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ActorGuid_Offset), ActorGuid);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NeedStateManaged_Offset), 0, NeedStateManaged_PropertyAddress.Address, NeedStateManaged);
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FGsManagedSceneObjBase(IntPtr nativeStruct)
	{
		if (!FGsManagedSceneObjBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedSceneObjBase");
			ActorGuid = FStringMarshaler.DefaultString;
			NeedStateManaged = false;
			ParamType = EGsManagedParamType.None;
			ConfigGuid = default(Guid);
			AliasName = default(FName);
		}
		else
		{
			ActorGuid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ActorGuid_Offset));
			NeedStateManaged = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, NeedStateManaged_Offset), 0, NeedStateManaged_PropertyAddress.Address);
			ParamType = EnumMarshaler<EGsManagedParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
		}
	}

	static FGsManagedSceneObjBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsManagedSceneObjBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsManagedSceneObjBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsManagedSceneObjBase");
		FGsManagedSceneObjBase_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		AliasName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AliasName");
		AliasName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AliasName", Classes.FNameProperty);
		ActorGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorGuid");
		ActorGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorGuid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref NeedStateManaged_PropertyAddress, intPtr, "bNeedStateManaged");
		NeedStateManaged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNeedStateManaged");
		NeedStateManaged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNeedStateManaged", Classes.FBoolProperty);
		FGsManagedSceneObjBase_IsValid = intPtr != IntPtr.Zero && ActorGuid_IsValid && NeedStateManaged_IsValid && ParamType_IsValid && ConfigGuid_IsValid && AliasName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsManagedSceneObjBase", FGsManagedSceneObjBase_IsValid);
	}
}
