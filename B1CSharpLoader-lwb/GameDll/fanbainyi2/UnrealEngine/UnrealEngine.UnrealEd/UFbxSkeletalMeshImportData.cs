using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UClass(Flags = (ClassFlags)1883771044uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.FbxSkeletalMeshImportData", "UnrealEd", UnrealModuleType.Engine)]
public class UFbxSkeletalMeshImportData : UFbxMeshImportData
{
	private static bool VertexColorImportOption_IsValid;

	private static FFieldAddress VertexColorImportOption_PropertyAddress;

	private static int VertexColorImportOption_Offset;

	private static bool VertexOverrideColor_IsValid;

	private static int VertexOverrideColor_Offset;

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/UnrealEd.FbxSkeletalMeshImportData:VertexColorImportOption")]
	public EVertexColorImportOption VertexColorImportOption
	{
		get
		{
			CheckDestroyed();
			if (!VertexColorImportOption_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxSkeletalMeshImportData:VertexColorImportOption");
				return EVertexColorImportOption.Replace;
			}
			return EnumMarshaler<EVertexColorImportOption>.FromNative(IntPtr.Add(base.Address, VertexColorImportOption_Offset), 0, VertexColorImportOption_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VertexColorImportOption_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxSkeletalMeshImportData:VertexColorImportOption");
			}
			else
			{
				EnumMarshaler<EVertexColorImportOption>.ToNative(IntPtr.Add(base.Address, VertexColorImportOption_Offset), 0, VertexColorImportOption_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/UnrealEd.FbxSkeletalMeshImportData:VertexOverrideColor")]
	public FColor VertexOverrideColor
	{
		get
		{
			CheckDestroyed();
			if (!VertexOverrideColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxSkeletalMeshImportData:VertexOverrideColor");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, VertexOverrideColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VertexOverrideColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxSkeletalMeshImportData:VertexOverrideColor");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, VertexOverrideColor_Offset), value);
			}
		}
	}

	static UFbxSkeletalMeshImportData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFbxSkeletalMeshImportData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFbxSkeletalMeshImportData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealEd.FbxSkeletalMeshImportData");
		NativeReflectionCached.GetPropertyRef(ref VertexColorImportOption_PropertyAddress, unrealStruct, "VertexColorImportOption");
		VertexColorImportOption_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VertexColorImportOption");
		VertexColorImportOption_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VertexColorImportOption", Classes.FByteProperty);
		VertexOverrideColor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VertexOverrideColor");
		VertexOverrideColor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VertexOverrideColor", Classes.FStructProperty);
	}
}
