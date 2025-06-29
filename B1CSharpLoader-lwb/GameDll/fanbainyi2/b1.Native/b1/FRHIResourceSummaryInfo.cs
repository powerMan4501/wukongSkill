using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.RHIResourceSummaryInfo", "b1", UnrealModuleType.Game)]
public struct FRHIResourceSummaryInfo
{
	private static bool VRAMAllocation_IsValid;

	private static int VRAMAllocation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.RHIResourceSummaryInfo:VRAMAllocation")]
	public float VRAMAllocation;

	private static bool Percentage_IsValid;

	private static int Percentage_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.RHIResourceSummaryInfo:Percentage")]
	public float Percentage;

	private static bool FRHIResourceSummaryInfo_IsValid;

	private static int FRHIResourceSummaryInfo_StructSize;

	public FRHIResourceSummaryInfo Copy()
	{
		return this;
	}

	public static FRHIResourceSummaryInfo FromNative(IntPtr nativeBuffer)
	{
		return new FRHIResourceSummaryInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRHIResourceSummaryInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRHIResourceSummaryInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRHIResourceSummaryInfo(nativeBuffer + arrayIndex * FRHIResourceSummaryInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRHIResourceSummaryInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRHIResourceSummaryInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRHIResourceSummaryInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.RHIResourceSummaryInfo");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VRAMAllocation_Offset), VRAMAllocation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Percentage_Offset), Percentage);
	}

	public FRHIResourceSummaryInfo(IntPtr nativeStruct)
	{
		if (!FRHIResourceSummaryInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.RHIResourceSummaryInfo");
			VRAMAllocation = 0f;
			Percentage = 0f;
		}
		else
		{
			VRAMAllocation = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VRAMAllocation_Offset));
			Percentage = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Percentage_Offset));
		}
	}

	static FRHIResourceSummaryInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRHIResourceSummaryInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRHIResourceSummaryInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.RHIResourceSummaryInfo");
		FRHIResourceSummaryInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		VRAMAllocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VRAMAllocation");
		VRAMAllocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VRAMAllocation", Classes.FFloatProperty);
		Percentage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Percentage");
		Percentage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Percentage", Classes.FFloatProperty);
		FRHIResourceSummaryInfo_IsValid = intPtr != IntPtr.Zero && VRAMAllocation_IsValid && Percentage_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.RHIResourceSummaryInfo", FRHIResourceSummaryInfo_IsValid);
	}
}
