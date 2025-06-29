using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEArteries;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSEArteries.GSArteriesStackRule", "GSEArteries", UnrealModuleType.GamePlugin)]
public struct FGSArteriesStackRule
{
	private static bool StackParam_IsValid;

	private static int StackParam_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/GSEArteries.GSArteriesStackRule:StackParam")]
	public FGSArteriesStackParam StackParam;

	private static bool MinTotalNumber_IsValid;

	private static int MinTotalNumber_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEArteries.GSArteriesStackRule:MinTotalNumber")]
	public int MinTotalNumber;

	private static bool MaxTotalNumber_IsValid;

	private static int MaxTotalNumber_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEArteries.GSArteriesStackRule:MaxTotalNumber")]
	public int MaxTotalNumber;

	private static bool FGSArteriesStackRule_IsValid;

	private static int FGSArteriesStackRule_StructSize;

	public FGSArteriesStackRule Copy()
	{
		return this;
	}

	public static FGSArteriesStackRule FromNative(IntPtr nativeBuffer)
	{
		return new FGSArteriesStackRule(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSArteriesStackRule value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSArteriesStackRule FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSArteriesStackRule(nativeBuffer + arrayIndex * FGSArteriesStackRule_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSArteriesStackRule value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSArteriesStackRule_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSArteriesStackRule_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEArteries.GSArteriesStackRule");
			return;
		}
		FGSArteriesStackParam.ToNative(IntPtr.Add(nativeStruct, StackParam_Offset), StackParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MinTotalNumber_Offset), MinTotalNumber);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxTotalNumber_Offset), MaxTotalNumber);
	}

	public FGSArteriesStackRule(IntPtr nativeStruct)
	{
		if (!FGSArteriesStackRule_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEArteries.GSArteriesStackRule");
			StackParam = default(FGSArteriesStackParam);
			MinTotalNumber = 0;
			MaxTotalNumber = 0;
		}
		else
		{
			StackParam = FGSArteriesStackParam.FromNative(IntPtr.Add(nativeStruct, StackParam_Offset));
			MinTotalNumber = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MinTotalNumber_Offset));
			MaxTotalNumber = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxTotalNumber_Offset));
		}
	}

	static FGSArteriesStackRule()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSArteriesStackRule)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSArteriesStackRule));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSEArteries.GSArteriesStackRule");
		FGSArteriesStackRule_StructSize = NativeReflection.GetStructSize(intPtr);
		StackParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StackParam");
		StackParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StackParam", Classes.FStructProperty);
		MinTotalNumber_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinTotalNumber");
		MinTotalNumber_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinTotalNumber", Classes.FIntProperty);
		MaxTotalNumber_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxTotalNumber");
		MaxTotalNumber_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxTotalNumber", Classes.FIntProperty);
		FGSArteriesStackRule_IsValid = intPtr != IntPtr.Zero && StackParam_IsValid && MinTotalNumber_IsValid && MaxTotalNumber_IsValid;
		NativeReflection.LogStructIsValid("/Script/GSEArteries.GSArteriesStackRule", FGSArteriesStackRule_IsValid);
	}
}
