using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/DatasmithContent.DatasmithReimportOptions", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public struct FDatasmithReimportOptions
{
	private static bool UpdateActors_IsValid;

	private static FFieldAddress UpdateActors_PropertyAddress;

	private static int UpdateActors_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithReimportOptions:bUpdateActors")]
	public bool UpdateActors;

	private static bool RespawnDeletedActors_IsValid;

	private static FFieldAddress RespawnDeletedActors_PropertyAddress;

	private static int RespawnDeletedActors_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithReimportOptions:bRespawnDeletedActors")]
	public bool RespawnDeletedActors;

	private static bool FDatasmithReimportOptions_IsValid;

	private static int FDatasmithReimportOptions_StructSize;

	public FDatasmithReimportOptions Copy()
	{
		return this;
	}

	public static FDatasmithReimportOptions FromNative(IntPtr nativeBuffer)
	{
		return new FDatasmithReimportOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDatasmithReimportOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDatasmithReimportOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDatasmithReimportOptions(nativeBuffer + arrayIndex * FDatasmithReimportOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDatasmithReimportOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDatasmithReimportOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDatasmithReimportOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DatasmithContent.DatasmithReimportOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UpdateActors_Offset), 0, UpdateActors_PropertyAddress.Address, UpdateActors);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RespawnDeletedActors_Offset), 0, RespawnDeletedActors_PropertyAddress.Address, RespawnDeletedActors);
	}

	public FDatasmithReimportOptions(IntPtr nativeStruct)
	{
		if (!FDatasmithReimportOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DatasmithContent.DatasmithReimportOptions");
			UpdateActors = false;
			RespawnDeletedActors = false;
		}
		else
		{
			UpdateActors = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UpdateActors_Offset), 0, UpdateActors_PropertyAddress.Address);
			RespawnDeletedActors = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RespawnDeletedActors_Offset), 0, RespawnDeletedActors_PropertyAddress.Address);
		}
	}

	static FDatasmithReimportOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDatasmithReimportOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDatasmithReimportOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DatasmithContent.DatasmithReimportOptions");
		FDatasmithReimportOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref UpdateActors_PropertyAddress, intPtr, "bUpdateActors");
		UpdateActors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUpdateActors");
		UpdateActors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUpdateActors", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RespawnDeletedActors_PropertyAddress, intPtr, "bRespawnDeletedActors");
		RespawnDeletedActors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRespawnDeletedActors");
		RespawnDeletedActors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRespawnDeletedActors", Classes.FBoolProperty);
		FDatasmithReimportOptions_IsValid = intPtr != IntPtr.Zero && UpdateActors_IsValid && RespawnDeletedActors_IsValid;
		NativeReflection.LogStructIsValid("/Script/DatasmithContent.DatasmithReimportOptions", FDatasmithReimportOptions_IsValid);
	}
}
