using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.CurveFlagsChangedPayload", "Engine", UnrealModuleType.Engine)]
public struct FCurveFlagsChangedPayload
{
	private static bool Identifier_IsValid;

	private static int Identifier_Offset;

	[UProperty(Flags = (PropFlags)4503668346847252uL)]
	[UMetaPath("/Script/Engine.CurvePayload:Identifier")]
	public FAnimationCurveIdentifier Identifier;

	private static bool OldFlags_IsValid;

	private static int OldFlags_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Engine.CurveFlagsChangedPayload:OldFlags")]
	public int OldFlags;

	private static bool FCurveFlagsChangedPayload_IsValid;

	private static int FCurveFlagsChangedPayload_StructSize;

	public FCurveFlagsChangedPayload Copy()
	{
		return this;
	}

	public static FCurveFlagsChangedPayload FromNative(IntPtr nativeBuffer)
	{
		return new FCurveFlagsChangedPayload(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCurveFlagsChangedPayload value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCurveFlagsChangedPayload FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCurveFlagsChangedPayload(nativeBuffer + arrayIndex * FCurveFlagsChangedPayload_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCurveFlagsChangedPayload value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCurveFlagsChangedPayload_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCurveFlagsChangedPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CurveFlagsChangedPayload");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OldFlags_Offset), OldFlags);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(nativeStruct, Identifier_Offset), Identifier);
	}

	public FCurveFlagsChangedPayload(IntPtr nativeStruct)
	{
		if (!FCurveFlagsChangedPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CurveFlagsChangedPayload");
			OldFlags = 0;
			Identifier = default(FAnimationCurveIdentifier);
		}
		else
		{
			OldFlags = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OldFlags_Offset));
			Identifier = FAnimationCurveIdentifier.FromNative(IntPtr.Add(nativeStruct, Identifier_Offset));
		}
	}

	static FCurveFlagsChangedPayload()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCurveFlagsChangedPayload)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCurveFlagsChangedPayload));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CurveFlagsChangedPayload");
		FCurveFlagsChangedPayload_StructSize = NativeReflection.GetStructSize(intPtr);
		Identifier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Identifier");
		Identifier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Identifier", Classes.FStructProperty);
		OldFlags_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OldFlags");
		OldFlags_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OldFlags", Classes.FIntProperty);
		FCurveFlagsChangedPayload_IsValid = intPtr != IntPtr.Zero && OldFlags_IsValid && Identifier_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CurveFlagsChangedPayload", FCurveFlagsChangedPayload_IsValid);
	}
}
