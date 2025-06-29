using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.BGUMaterialParameterInfo", "UnrealExtent", UnrealModuleType.Game)]
public struct FBGUMaterialParameterInfo
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialParameterInfo:Name")]
	public FName Name;

	private static bool Association_IsValid;

	private static FFieldAddress Association_PropertyAddress;

	private static int Association_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialParameterInfo:Association")]
	public EMaterialParameterAssociation Association;

	private static bool Index_IsValid;

	private static int Index_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialParameterInfo:Index")]
	public int Index;

	private static bool LayerMaterial_IsValid;

	private static int LayerMaterial_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.BGUMaterialParameterInfo:LayerMaterial")]
	public UMaterialFunctionInterface LayerMaterial;

	private static bool BlendMaterial_IsValid;

	private static int BlendMaterial_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.BGUMaterialParameterInfo:BlendMaterial")]
	public UMaterialFunctionInterface BlendMaterial;

	private static bool FBGUMaterialParameterInfo_IsValid;

	private static int FBGUMaterialParameterInfo_StructSize;

	public FBGUMaterialParameterInfo Copy()
	{
		return this;
	}

	public static FBGUMaterialParameterInfo FromNative(IntPtr nativeBuffer)
	{
		return new FBGUMaterialParameterInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBGUMaterialParameterInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBGUMaterialParameterInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBGUMaterialParameterInfo(nativeBuffer + arrayIndex * FBGUMaterialParameterInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBGUMaterialParameterInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBGUMaterialParameterInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBGUMaterialParameterInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.BGUMaterialParameterInfo");
			return;
		}
		UObjectMarshaler<UMaterialFunctionInterface>.ToNative(IntPtr.Add(nativeStruct, LayerMaterial_Offset), LayerMaterial);
		UObjectMarshaler<UMaterialFunctionInterface>.ToNative(IntPtr.Add(nativeStruct, BlendMaterial_Offset), BlendMaterial);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		EnumMarshaler<EMaterialParameterAssociation>.ToNative(IntPtr.Add(nativeStruct, Association_Offset), 0, Association_PropertyAddress.Address, Association);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Index_Offset), Index);
	}

	public FBGUMaterialParameterInfo(IntPtr nativeStruct)
	{
		if (!FBGUMaterialParameterInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.BGUMaterialParameterInfo");
			LayerMaterial = null;
			BlendMaterial = null;
			Name = default(FName);
			Association = EMaterialParameterAssociation.LayerParameter;
			Index = 0;
		}
		else
		{
			LayerMaterial = UObjectMarshaler<UMaterialFunctionInterface>.FromNative(IntPtr.Add(nativeStruct, LayerMaterial_Offset));
			BlendMaterial = UObjectMarshaler<UMaterialFunctionInterface>.FromNative(IntPtr.Add(nativeStruct, BlendMaterial_Offset));
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Association = EnumMarshaler<EMaterialParameterAssociation>.FromNative(IntPtr.Add(nativeStruct, Association_Offset), 0, Association_PropertyAddress.Address);
			Index = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Index_Offset));
		}
	}

	static FBGUMaterialParameterInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBGUMaterialParameterInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBGUMaterialParameterInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.BGUMaterialParameterInfo");
		FBGUMaterialParameterInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Association_PropertyAddress, intPtr, "Association");
		Association_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Association");
		Association_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Association", Classes.FByteProperty);
		Index_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Index");
		Index_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Index", Classes.FIntProperty);
		LayerMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LayerMaterial");
		LayerMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LayerMaterial", Classes.FObjectProperty);
		BlendMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendMaterial");
		BlendMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendMaterial", Classes.FObjectProperty);
		FBGUMaterialParameterInfo_IsValid = intPtr != IntPtr.Zero && LayerMaterial_IsValid && BlendMaterial_IsValid && Name_IsValid && Association_IsValid && Index_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.BGUMaterialParameterInfo", FBGUMaterialParameterInfo_IsValid);
	}
}
