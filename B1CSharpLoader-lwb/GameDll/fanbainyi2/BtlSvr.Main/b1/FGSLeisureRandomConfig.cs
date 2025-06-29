using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.FGSLeisureRandomConfig")]
public struct FGSLeisureRandomConfig
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSLeisureRandomConfig:Weight")]
	public float Weight;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSLeisureRandomConfig:RandomAnim")]
	public UAnimMontage RandomAnim;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("CD Time After Play End")]
	[USharpPath("/Script/b1-Managed.FGSLeisureRandomConfig:CD_Time")]
	public float CD_Time;

	private static int FGSLeisureRandomConfig_StructSize;

	private static int FGSLeisureRandomConfig_IsValid;

	private static bool Weight_IsValid;

	private static int Weight_Offset;

	private static bool RandomAnim_IsValid;

	private static int RandomAnim_Offset;

	private static bool CD_Time_IsValid;

	private static int CD_Time_Offset;

	public FGSLeisureRandomConfig Copy()
	{
		return this;
	}

	public static FGSLeisureRandomConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGSLeisureRandomConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSLeisureRandomConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSLeisureRandomConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSLeisureRandomConfig(IntPtr.Add(nativeBuffer, arrayIndex * FGSLeisureRandomConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSLeisureRandomConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSLeisureRandomConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSLeisureRandomConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSLeisureRandomConfig");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Weight_Offset), Weight);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, RandomAnim_Offset), RandomAnim);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CD_Time_Offset), CD_Time);
	}

	public FGSLeisureRandomConfig(IntPtr nativeStruct)
	{
		if (FGSLeisureRandomConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSLeisureRandomConfig");
			Weight = 0f;
			RandomAnim = null;
			CD_Time = 0f;
		}
		else
		{
			Weight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Weight_Offset));
			RandomAnim = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, RandomAnim_Offset));
			CD_Time = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CD_Time_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSLeisureRandomConfig");
		FGSLeisureRandomConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Weight_Offset = NativeReflection.GetPropertyOffset(intPtr, "Weight");
		Weight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Weight", Classes.FFloatProperty);
		RandomAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "RandomAnim");
		RandomAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RandomAnim", Classes.FObjectProperty);
		CD_Time_Offset = NativeReflection.GetPropertyOffset(intPtr, "CD_Time");
		CD_Time_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CD_Time", Classes.FFloatProperty);
		FGSLeisureRandomConfig_IsValid = ((intPtr != IntPtr.Zero && Weight_IsValid && RandomAnim_IsValid && CD_Time_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSLeisureRandomConfig", (byte)FGSLeisureRandomConfig_IsValid != 0);
	}

	static FGSLeisureRandomConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSLeisureRandomConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSLeisureRandomConfig));
	}
}
