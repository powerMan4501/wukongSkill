using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.CurveRenamedPayload", "Engine", UnrealModuleType.Engine)]
public struct FCurveRenamedPayload
{
	private static bool Identifier_IsValid;

	private static int Identifier_Offset;

	[UProperty(Flags = (PropFlags)4503668346847252uL)]
	[UMetaPath("/Script/Engine.CurvePayload:Identifier")]
	public FAnimationCurveIdentifier Identifier;

	private static bool NewIdentifier_IsValid;

	private static int NewIdentifier_Offset;

	[UProperty(Flags = (PropFlags)4503668346847252uL)]
	[UMetaPath("/Script/Engine.CurveRenamedPayload:NewIdentifier")]
	public FAnimationCurveIdentifier NewIdentifier;

	private static bool FCurveRenamedPayload_IsValid;

	private static int FCurveRenamedPayload_StructSize;

	public FCurveRenamedPayload Copy()
	{
		return this;
	}

	public static FCurveRenamedPayload FromNative(IntPtr nativeBuffer)
	{
		return new FCurveRenamedPayload(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCurveRenamedPayload value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCurveRenamedPayload FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCurveRenamedPayload(nativeBuffer + arrayIndex * FCurveRenamedPayload_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCurveRenamedPayload value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCurveRenamedPayload_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCurveRenamedPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CurveRenamedPayload");
			return;
		}
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(nativeStruct, NewIdentifier_Offset), NewIdentifier);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(nativeStruct, Identifier_Offset), Identifier);
	}

	public FCurveRenamedPayload(IntPtr nativeStruct)
	{
		if (!FCurveRenamedPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CurveRenamedPayload");
			NewIdentifier = default(FAnimationCurveIdentifier);
			Identifier = default(FAnimationCurveIdentifier);
		}
		else
		{
			NewIdentifier = FAnimationCurveIdentifier.FromNative(IntPtr.Add(nativeStruct, NewIdentifier_Offset));
			Identifier = FAnimationCurveIdentifier.FromNative(IntPtr.Add(nativeStruct, Identifier_Offset));
		}
	}

	static FCurveRenamedPayload()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCurveRenamedPayload)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCurveRenamedPayload));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CurveRenamedPayload");
		FCurveRenamedPayload_StructSize = NativeReflection.GetStructSize(intPtr);
		Identifier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Identifier");
		Identifier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Identifier", Classes.FStructProperty);
		NewIdentifier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NewIdentifier");
		NewIdentifier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NewIdentifier", Classes.FStructProperty);
		FCurveRenamedPayload_IsValid = intPtr != IntPtr.Zero && NewIdentifier_IsValid && Identifier_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CurveRenamedPayload", FCurveRenamedPayload_IsValid);
	}
}
