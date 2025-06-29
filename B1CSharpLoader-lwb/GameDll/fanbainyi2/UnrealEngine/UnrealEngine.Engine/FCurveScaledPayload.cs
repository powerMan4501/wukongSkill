using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.CurveScaledPayload", "Engine", UnrealModuleType.Engine)]
public struct FCurveScaledPayload
{
	private static bool Identifier_IsValid;

	private static int Identifier_Offset;

	[UProperty(Flags = (PropFlags)4503668346847252uL)]
	[UMetaPath("/Script/Engine.CurvePayload:Identifier")]
	public FAnimationCurveIdentifier Identifier;

	private static bool Factor_IsValid;

	private static int Factor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Engine.CurveScaledPayload:Factor")]
	public float Factor;

	private static bool Origin_IsValid;

	private static int Origin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Engine.CurveScaledPayload:Origin")]
	public float Origin;

	private static bool FCurveScaledPayload_IsValid;

	private static int FCurveScaledPayload_StructSize;

	public FCurveScaledPayload Copy()
	{
		return this;
	}

	public static FCurveScaledPayload FromNative(IntPtr nativeBuffer)
	{
		return new FCurveScaledPayload(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCurveScaledPayload value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCurveScaledPayload FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCurveScaledPayload(nativeBuffer + arrayIndex * FCurveScaledPayload_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCurveScaledPayload value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCurveScaledPayload_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCurveScaledPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CurveScaledPayload");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Factor_Offset), Factor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Origin_Offset), Origin);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(nativeStruct, Identifier_Offset), Identifier);
	}

	public FCurveScaledPayload(IntPtr nativeStruct)
	{
		if (!FCurveScaledPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CurveScaledPayload");
			Factor = 0f;
			Origin = 0f;
			Identifier = default(FAnimationCurveIdentifier);
		}
		else
		{
			Factor = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Factor_Offset));
			Origin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Origin_Offset));
			Identifier = FAnimationCurveIdentifier.FromNative(IntPtr.Add(nativeStruct, Identifier_Offset));
		}
	}

	static FCurveScaledPayload()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCurveScaledPayload)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCurveScaledPayload));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CurveScaledPayload");
		FCurveScaledPayload_StructSize = NativeReflection.GetStructSize(intPtr);
		Identifier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Identifier");
		Identifier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Identifier", Classes.FStructProperty);
		Factor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Factor");
		Factor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Factor", Classes.FFloatProperty);
		Origin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Origin");
		Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Origin", Classes.FFloatProperty);
		FCurveScaledPayload_IsValid = intPtr != IntPtr.Zero && Factor_IsValid && Origin_IsValid && Identifier_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CurveScaledPayload", FCurveScaledPayload_IsValid);
	}
}
