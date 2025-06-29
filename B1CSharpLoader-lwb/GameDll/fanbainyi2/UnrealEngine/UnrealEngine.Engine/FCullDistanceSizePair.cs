using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.CullDistanceSizePair", "Engine", UnrealModuleType.Engine)]
public struct FCullDistanceSizePair
{
	private static bool Size_IsValid;

	private static int Size_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.CullDistanceSizePair:Size")]
	public float Size;

	private static bool CullDistance_IsValid;

	private static int CullDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.CullDistanceSizePair:CullDistance")]
	public float CullDistance;

	private static bool FCullDistanceSizePair_IsValid;

	private static int FCullDistanceSizePair_StructSize;

	public FCullDistanceSizePair Copy()
	{
		return this;
	}

	public static FCullDistanceSizePair FromNative(IntPtr nativeBuffer)
	{
		return new FCullDistanceSizePair(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCullDistanceSizePair value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCullDistanceSizePair FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCullDistanceSizePair(nativeBuffer + arrayIndex * FCullDistanceSizePair_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCullDistanceSizePair value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCullDistanceSizePair_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCullDistanceSizePair_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CullDistanceSizePair");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Size_Offset), Size);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CullDistance_Offset), CullDistance);
	}

	public FCullDistanceSizePair(IntPtr nativeStruct)
	{
		if (!FCullDistanceSizePair_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CullDistanceSizePair");
			Size = 0f;
			CullDistance = 0f;
		}
		else
		{
			Size = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Size_Offset));
			CullDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CullDistance_Offset));
		}
	}

	static FCullDistanceSizePair()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCullDistanceSizePair)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCullDistanceSizePair));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CullDistanceSizePair");
		FCullDistanceSizePair_StructSize = NativeReflection.GetStructSize(intPtr);
		Size_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Size");
		Size_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Size", Classes.FFloatProperty);
		CullDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CullDistance");
		CullDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CullDistance", Classes.FFloatProperty);
		FCullDistanceSizePair_IsValid = intPtr != IntPtr.Zero && Size_IsValid && CullDistance_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CullDistanceSizePair", FCullDistanceSizePair_IsValid);
	}
}
