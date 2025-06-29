using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialParameterInfo", "Engine", UnrealModuleType.Engine)]
public struct FMaterialParameterInfo
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

	private static bool FMaterialParameterInfo_IsValid;

	private static int FMaterialParameterInfo_StructSize;

	public FMaterialParameterInfo Copy()
	{
		return this;
	}

	public static FMaterialParameterInfo FromNative(IntPtr nativeBuffer)
	{
		return new FMaterialParameterInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMaterialParameterInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMaterialParameterInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMaterialParameterInfo(nativeBuffer + arrayIndex * FMaterialParameterInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMaterialParameterInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMaterialParameterInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMaterialParameterInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MaterialParameterInfo");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		EnumMarshaler<EMaterialParameterAssociation>.ToNative(IntPtr.Add(nativeStruct, Association_Offset), 0, Association_PropertyAddress.Address, Association);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Index_Offset), Index);
	}

	public FMaterialParameterInfo(IntPtr nativeStruct)
	{
		if (!FMaterialParameterInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MaterialParameterInfo");
			Name = default(FName);
			Association = EMaterialParameterAssociation.LayerParameter;
			Index = 0;
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Association = EnumMarshaler<EMaterialParameterAssociation>.FromNative(IntPtr.Add(nativeStruct, Association_Offset), 0, Association_PropertyAddress.Address);
			Index = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Index_Offset));
		}
	}

	static FMaterialParameterInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMaterialParameterInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMaterialParameterInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.MaterialParameterInfo");
		FMaterialParameterInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Association_PropertyAddress, intPtr, "Association");
		Association_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Association");
		Association_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Association", Classes.FByteProperty);
		Index_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Index");
		Index_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Index", Classes.FIntProperty);
		FMaterialParameterInfo_IsValid = intPtr != IntPtr.Zero && Name_IsValid && Association_IsValid && Index_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.MaterialParameterInfo", FMaterialParameterInfo_IsValid);
	}
}
