using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AlembicLibrary;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AlembicLibrary.AbcMaterialSettings", "AlembicLibrary", UnrealModuleType.EnginePlugin)]
public struct FAbcMaterialSettings
{
	private static bool CreateMaterials_IsValid;

	private static FFieldAddress CreateMaterials_PropertyAddress;

	private static int CreateMaterials_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcMaterialSettings:bCreateMaterials")]
	public bool CreateMaterials;

	private static bool FindMaterials_IsValid;

	private static FFieldAddress FindMaterials_PropertyAddress;

	private static int FindMaterials_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcMaterialSettings:bFindMaterials")]
	public bool FindMaterials;

	private static bool FAbcMaterialSettings_IsValid;

	private static int FAbcMaterialSettings_StructSize;

	public FAbcMaterialSettings Copy()
	{
		return this;
	}

	public static FAbcMaterialSettings FromNative(IntPtr nativeBuffer)
	{
		return new FAbcMaterialSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAbcMaterialSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAbcMaterialSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAbcMaterialSettings(nativeBuffer + arrayIndex * FAbcMaterialSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAbcMaterialSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAbcMaterialSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAbcMaterialSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AlembicLibrary.AbcMaterialSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CreateMaterials_Offset), 0, CreateMaterials_PropertyAddress.Address, CreateMaterials);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FindMaterials_Offset), 0, FindMaterials_PropertyAddress.Address, FindMaterials);
	}

	public FAbcMaterialSettings(IntPtr nativeStruct)
	{
		if (!FAbcMaterialSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AlembicLibrary.AbcMaterialSettings");
			CreateMaterials = false;
			FindMaterials = false;
		}
		else
		{
			CreateMaterials = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CreateMaterials_Offset), 0, CreateMaterials_PropertyAddress.Address);
			FindMaterials = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FindMaterials_Offset), 0, FindMaterials_PropertyAddress.Address);
		}
	}

	static FAbcMaterialSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAbcMaterialSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAbcMaterialSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AlembicLibrary.AbcMaterialSettings");
		FAbcMaterialSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref CreateMaterials_PropertyAddress, intPtr, "bCreateMaterials");
		CreateMaterials_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCreateMaterials");
		CreateMaterials_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCreateMaterials", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FindMaterials_PropertyAddress, intPtr, "bFindMaterials");
		FindMaterials_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFindMaterials");
		FindMaterials_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFindMaterials", Classes.FBoolProperty);
		FAbcMaterialSettings_IsValid = intPtr != IntPtr.Zero && CreateMaterials_IsValid && FindMaterials_IsValid;
		NativeReflection.LogStructIsValid("/Script/AlembicLibrary.AbcMaterialSettings", FAbcMaterialSettings_IsValid);
	}
}
