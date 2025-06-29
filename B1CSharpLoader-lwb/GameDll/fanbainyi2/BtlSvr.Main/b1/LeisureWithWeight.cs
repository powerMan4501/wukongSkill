using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.LeisureWithWeight")]
public struct LeisureWithWeight
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.LeisureWithWeight:LeisureReference")]
	public UAnimMontage LeisureReference;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.LeisureWithWeight:Weight")]
	public int Weight;

	private static int LeisureWithWeight_StructSize;

	private static int LeisureWithWeight_IsValid;

	private static bool LeisureReference_IsValid;

	private static int LeisureReference_Offset;

	private static bool Weight_IsValid;

	private static int Weight_Offset;

	public LeisureWithWeight Copy()
	{
		return this;
	}

	public static LeisureWithWeight FromNative(IntPtr nativeBuffer)
	{
		return new LeisureWithWeight(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, LeisureWithWeight value)
	{
		value.ToNative(nativeBuffer);
	}

	public static LeisureWithWeight FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new LeisureWithWeight(IntPtr.Add(nativeBuffer, arrayIndex * LeisureWithWeight_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, LeisureWithWeight value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * LeisureWithWeight_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (LeisureWithWeight_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.LeisureWithWeight");
			return;
		}
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, LeisureReference_Offset), LeisureReference);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Weight_Offset), Weight);
	}

	public LeisureWithWeight(IntPtr nativeStruct)
	{
		if (LeisureWithWeight_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.LeisureWithWeight");
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
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.LeisureWithWeight");
		LeisureWithWeight_StructSize = NativeReflection.GetStructSize(intPtr);
		LeisureReference_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeisureReference");
		LeisureReference_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeisureReference", Classes.FObjectProperty);
		Weight_Offset = NativeReflection.GetPropertyOffset(intPtr, "Weight");
		Weight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Weight", Classes.FIntProperty);
		LeisureWithWeight_IsValid = ((intPtr != IntPtr.Zero && LeisureReference_IsValid && Weight_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.LeisureWithWeight", (byte)LeisureWithWeight_IsValid != 0);
	}

	static LeisureWithWeight()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(LeisureWithWeight)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(LeisureWithWeight));
	}
}
