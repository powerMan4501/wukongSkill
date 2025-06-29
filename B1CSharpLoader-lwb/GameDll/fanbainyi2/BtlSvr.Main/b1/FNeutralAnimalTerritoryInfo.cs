using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.NeutralAnimalTerritoryInfo")]
public struct FNeutralAnimalTerritoryInfo
{
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[DisplayName("领地世界位置信息")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.NeutralAnimalTerritoryInfo:BoxTransform")]
	public FTransform BoxTransform;

	[DisplayName("预置生成点集")]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.NeutralAnimalTerritoryInfo:PresetSpawnPositions")]
	public List<FVector> PresetSpawnPositions;

	[DisplayName("BoxExtend")]
	[UProperty]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.NeutralAnimalTerritoryInfo:BoxExtend")]
	public FVector BoxExtend;

	[DisplayName("生物模板列表")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.NeutralAnimalTerritoryInfo:AnimalTemplates")]
	public List<FAnimalSpawnTemplate> AnimalTemplates;

	private static int NeutralAnimalTerritoryInfo_StructSize;

	private static int NeutralAnimalTerritoryInfo_IsValid;

	private static bool BoxTransform_IsValid;

	private static int BoxTransform_Offset;

	private static bool PresetSpawnPositions_IsValid;

	private static int PresetSpawnPositions_Offset;

	private static FFieldAddress PresetSpawnPositions_PropertyAddress;

	private static bool BoxExtend_IsValid;

	private static int BoxExtend_Offset;

	private static bool AnimalTemplates_IsValid;

	private static int AnimalTemplates_Offset;

	private static FFieldAddress AnimalTemplates_PropertyAddress;

	public FNeutralAnimalTerritoryInfo Copy()
	{
		FNeutralAnimalTerritoryInfo result = this;
		if (PresetSpawnPositions != null)
		{
			result.PresetSpawnPositions = new List<FVector>(PresetSpawnPositions);
		}
		if (AnimalTemplates != null)
		{
			result.AnimalTemplates = new List<FAnimalSpawnTemplate>(AnimalTemplates);
		}
		return result;
	}

	public static FNeutralAnimalTerritoryInfo FromNative(IntPtr nativeBuffer)
	{
		return new FNeutralAnimalTerritoryInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNeutralAnimalTerritoryInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNeutralAnimalTerritoryInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNeutralAnimalTerritoryInfo(IntPtr.Add(nativeBuffer, arrayIndex * NeutralAnimalTerritoryInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNeutralAnimalTerritoryInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * NeutralAnimalTerritoryInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (NeutralAnimalTerritoryInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.NeutralAnimalTerritoryInfo");
			return;
		}
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, BoxTransform_Offset), BoxTransform);
		new TArrayCopyMarshaler<FVector>(1, PresetSpawnPositions_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PresetSpawnPositions_Offset), PresetSpawnPositions);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, BoxExtend_Offset), BoxExtend);
		new TArrayCopyMarshaler<FAnimalSpawnTemplate>(1, AnimalTemplates_PropertyAddress, CachedMarshalingDelegates<FAnimalSpawnTemplate, FAnimalSpawnTemplate>.FromNative, CachedMarshalingDelegates<FAnimalSpawnTemplate, FAnimalSpawnTemplate>.ToNative).ToNative(IntPtr.Add(nativeStruct, AnimalTemplates_Offset), AnimalTemplates);
	}

	public FNeutralAnimalTerritoryInfo(IntPtr nativeStruct)
	{
		if (NeutralAnimalTerritoryInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.NeutralAnimalTerritoryInfo");
			BoxTransform = default(FTransform);
			PresetSpawnPositions = null;
			BoxExtend = default(FVector);
			AnimalTemplates = null;
		}
		else
		{
			BoxTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, BoxTransform_Offset));
			PresetSpawnPositions = new TArrayCopyMarshaler<FVector>(1, PresetSpawnPositions_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PresetSpawnPositions_Offset));
			BoxExtend = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, BoxExtend_Offset));
			AnimalTemplates = new TArrayCopyMarshaler<FAnimalSpawnTemplate>(1, AnimalTemplates_PropertyAddress, CachedMarshalingDelegates<FAnimalSpawnTemplate, FAnimalSpawnTemplate>.FromNative, CachedMarshalingDelegates<FAnimalSpawnTemplate, FAnimalSpawnTemplate>.ToNative).FromNative(IntPtr.Add(nativeStruct, AnimalTemplates_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.NeutralAnimalTerritoryInfo");
		NeutralAnimalTerritoryInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		BoxTransform_Offset = NativeReflection.GetPropertyOffset(intPtr, "BoxTransform");
		BoxTransform_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BoxTransform", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref PresetSpawnPositions_PropertyAddress, intPtr, "PresetSpawnPositions");
		PresetSpawnPositions_Offset = NativeReflection.GetPropertyOffset(intPtr, "PresetSpawnPositions");
		PresetSpawnPositions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PresetSpawnPositions", Classes.FArrayProperty);
		BoxExtend_Offset = NativeReflection.GetPropertyOffset(intPtr, "BoxExtend");
		BoxExtend_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BoxExtend", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref AnimalTemplates_PropertyAddress, intPtr, "AnimalTemplates");
		AnimalTemplates_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimalTemplates");
		AnimalTemplates_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimalTemplates", Classes.FArrayProperty);
		NeutralAnimalTerritoryInfo_IsValid = ((intPtr != IntPtr.Zero && BoxTransform_IsValid && PresetSpawnPositions_IsValid && BoxExtend_IsValid && AnimalTemplates_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.NeutralAnimalTerritoryInfo", (byte)NeutralAnimalTerritoryInfo_IsValid != 0);
	}

	static FNeutralAnimalTerritoryInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FNeutralAnimalTerritoryInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNeutralAnimalTerritoryInfo));
	}
}
