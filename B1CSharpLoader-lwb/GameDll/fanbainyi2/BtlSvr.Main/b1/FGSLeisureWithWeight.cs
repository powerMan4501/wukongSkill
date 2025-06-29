using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.FGSLeisureWithWeight")]
public struct FGSLeisureWithWeight
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("B1|SpawnBulletInfo")]
	[USharpPath("/Script/b1-Managed.FGSLeisureWithWeight:LeisureReference")]
	public UAnimMontage LeisureReference;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("B1|SpawnBulletInfo")]
	[USharpPath("/Script/b1-Managed.FGSLeisureWithWeight:Weight")]
	public int Weight;

	private static int FGSLeisureWithWeight_StructSize;

	private static int FGSLeisureWithWeight_IsValid;

	private static bool LeisureReference_IsValid;

	private static int LeisureReference_Offset;

	private static bool Weight_IsValid;

	private static int Weight_Offset;

	public FGSLeisureWithWeight Copy()
	{
		return this;
	}

	public static FGSLeisureWithWeight FromNative(IntPtr nativeBuffer)
	{
		return new FGSLeisureWithWeight(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSLeisureWithWeight value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSLeisureWithWeight FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSLeisureWithWeight(IntPtr.Add(nativeBuffer, arrayIndex * FGSLeisureWithWeight_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSLeisureWithWeight value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSLeisureWithWeight_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSLeisureWithWeight_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSLeisureWithWeight");
			return;
		}
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, LeisureReference_Offset), LeisureReference);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Weight_Offset), Weight);
	}

	public FGSLeisureWithWeight(IntPtr nativeStruct)
	{
		if (FGSLeisureWithWeight_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSLeisureWithWeight");
			LeisureReference = null;
			Weight = 0;
		}
		else
		{
			LeisureReference = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, LeisureReference_Offset));
			Weight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Weight_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSLeisureWithWeight");
		FGSLeisureWithWeight_StructSize = NativeReflection.GetStructSize(intPtr);
		LeisureReference_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeisureReference");
		LeisureReference_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeisureReference", Classes.FObjectProperty);
		Weight_Offset = NativeReflection.GetPropertyOffset(intPtr, "Weight");
		Weight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Weight", Classes.FIntProperty);
		FGSLeisureWithWeight_IsValid = ((intPtr != IntPtr.Zero && LeisureReference_IsValid && Weight_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSLeisureWithWeight", (byte)FGSLeisureWithWeight_IsValid != 0);
	}

	static FGSLeisureWithWeight()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSLeisureWithWeight)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSLeisureWithWeight));
	}
}
