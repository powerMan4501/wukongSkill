using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.CurvePayload", "Engine", UnrealModuleType.Engine)]
public struct FCurvePayload
{
	private static bool Identifier_IsValid;

	private static int Identifier_Offset;

	[UProperty(Flags = (PropFlags)4503668346847252uL)]
	[UMetaPath("/Script/Engine.CurvePayload:Identifier")]
	public FAnimationCurveIdentifier Identifier;

	private static bool FCurvePayload_IsValid;

	private static int FCurvePayload_StructSize;

	public FCurvePayload Copy()
	{
		return this;
	}

	public static FCurvePayload FromNative(IntPtr nativeBuffer)
	{
		return new FCurvePayload(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCurvePayload value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCurvePayload FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCurvePayload(nativeBuffer + arrayIndex * FCurvePayload_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCurvePayload value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCurvePayload_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCurvePayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CurvePayload");
		}
		else
		{
			FAnimationCurveIdentifier.ToNative(IntPtr.Add(nativeStruct, Identifier_Offset), Identifier);
		}
	}

	public FCurvePayload(IntPtr nativeStruct)
	{
		if (!FCurvePayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CurvePayload");
			Identifier = default(FAnimationCurveIdentifier);
		}
		else
		{
			Identifier = FAnimationCurveIdentifier.FromNative(IntPtr.Add(nativeStruct, Identifier_Offset));
		}
	}

	static FCurvePayload()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCurvePayload)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCurvePayload));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CurvePayload");
		FCurvePayload_StructSize = NativeReflection.GetStructSize(intPtr);
		Identifier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Identifier");
		Identifier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Identifier", Classes.FStructProperty);
		FCurvePayload_IsValid = intPtr != IntPtr.Zero && Identifier_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CurvePayload", FCurvePayload_IsValid);
	}
}
