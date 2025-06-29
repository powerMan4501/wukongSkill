using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/b1.GSMontageCostInfoData", "b1", UnrealModuleType.Game)]
public struct FGSMontageCostInfoData
{
	private static bool StartMontage_IsValid;

	private static int StartMontage_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.GSMontageCostInfoData:StartMontage")]
	public UAnimMontage StartMontage;

	private static bool NextMontage_IsValid;

	private static int NextMontage_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.GSMontageCostInfoData:NextMontage")]
	public UAnimMontage NextMontage;

	private static bool CostValue_IsValid;

	private static int CostValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.GSMontageCostInfoData:CostValue")]
	public float CostValue;

	private static bool FGSMontageCostInfoData_IsValid;

	private static int FGSMontageCostInfoData_StructSize;

	public FGSMontageCostInfoData Copy()
	{
		return this;
	}

	public static FGSMontageCostInfoData FromNative(IntPtr nativeBuffer)
	{
		return new FGSMontageCostInfoData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSMontageCostInfoData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSMontageCostInfoData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSMontageCostInfoData(nativeBuffer + arrayIndex * FGSMontageCostInfoData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSMontageCostInfoData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSMontageCostInfoData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSMontageCostInfoData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSMontageCostInfoData");
			return;
		}
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, StartMontage_Offset), StartMontage);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, NextMontage_Offset), NextMontage);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CostValue_Offset), CostValue);
	}

	public FGSMontageCostInfoData(IntPtr nativeStruct)
	{
		if (!FGSMontageCostInfoData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSMontageCostInfoData");
			StartMontage = null;
			NextMontage = null;
			CostValue = 0f;
		}
		else
		{
			StartMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, StartMontage_Offset));
			NextMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, NextMontage_Offset));
			CostValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CostValue_Offset));
		}
	}

	static FGSMontageCostInfoData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSMontageCostInfoData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSMontageCostInfoData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.GSMontageCostInfoData");
		FGSMontageCostInfoData_StructSize = NativeReflection.GetStructSize(intPtr);
		StartMontage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StartMontage");
		StartMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StartMontage", Classes.FObjectProperty);
		NextMontage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NextMontage");
		NextMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NextMontage", Classes.FObjectProperty);
		CostValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CostValue");
		CostValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CostValue", Classes.FFloatProperty);
		FGSMontageCostInfoData_IsValid = intPtr != IntPtr.Zero && StartMontage_IsValid && NextMontage_IsValid && CostValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.GSMontageCostInfoData", FGSMontageCostInfoData_IsValid);
	}
}
