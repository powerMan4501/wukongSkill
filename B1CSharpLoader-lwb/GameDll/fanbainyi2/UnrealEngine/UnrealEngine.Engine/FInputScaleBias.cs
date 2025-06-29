using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.InputScaleBias", "Engine", UnrealModuleType.Engine)]
public struct FInputScaleBias
{
	private static bool Scale_IsValid;

	private static int Scale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputScaleBias:Scale")]
	public float Scale;

	private static bool Bias_IsValid;

	private static int Bias_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputScaleBias:Bias")]
	public float Bias;

	private static bool FInputScaleBias_IsValid;

	private static int FInputScaleBias_StructSize;

	public FInputScaleBias Copy()
	{
		return this;
	}

	public static FInputScaleBias FromNative(IntPtr nativeBuffer)
	{
		return new FInputScaleBias(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputScaleBias value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputScaleBias FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputScaleBias(nativeBuffer + arrayIndex * FInputScaleBias_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputScaleBias value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInputScaleBias_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInputScaleBias_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputScaleBias");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Bias_Offset), Bias);
	}

	public FInputScaleBias(IntPtr nativeStruct)
	{
		if (!FInputScaleBias_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputScaleBias");
			Scale = 0f;
			Bias = 0f;
		}
		else
		{
			Scale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
			Bias = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Bias_Offset));
		}
	}

	static FInputScaleBias()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInputScaleBias)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputScaleBias));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.InputScaleBias");
		FInputScaleBias_StructSize = NativeReflection.GetStructSize(intPtr);
		Scale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Scale", Classes.FFloatProperty);
		Bias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Bias");
		Bias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Bias", Classes.FFloatProperty);
		FInputScaleBias_IsValid = intPtr != IntPtr.Zero && Scale_IsValid && Bias_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.InputScaleBias", FInputScaleBias_IsValid);
	}
}
