using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.AttributePayload", "Engine", UnrealModuleType.Engine)]
public struct FAttributePayload
{
	private static bool Identifier_IsValid;

	private static int Identifier_Offset;

	[UProperty(Flags = (PropFlags)6755399441055764uL)]
	[UMetaPath("/Script/Engine.AttributePayload:Identifier")]
	public FAnimationAttributeIdentifier Identifier;

	private static bool FAttributePayload_IsValid;

	private static int FAttributePayload_StructSize;

	public FAttributePayload Copy()
	{
		return this;
	}

	public static FAttributePayload FromNative(IntPtr nativeBuffer)
	{
		return new FAttributePayload(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAttributePayload value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAttributePayload FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAttributePayload(nativeBuffer + arrayIndex * FAttributePayload_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAttributePayload value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAttributePayload_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAttributePayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AttributePayload");
		}
		else
		{
			FAnimationAttributeIdentifier.ToNative(IntPtr.Add(nativeStruct, Identifier_Offset), Identifier);
		}
	}

	public FAttributePayload(IntPtr nativeStruct)
	{
		if (!FAttributePayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AttributePayload");
			Identifier = default(FAnimationAttributeIdentifier);
		}
		else
		{
			Identifier = FAnimationAttributeIdentifier.FromNative(IntPtr.Add(nativeStruct, Identifier_Offset));
		}
	}

	static FAttributePayload()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAttributePayload)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAttributePayload));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AttributePayload");
		FAttributePayload_StructSize = NativeReflection.GetStructSize(intPtr);
		Identifier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Identifier");
		Identifier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Identifier", Classes.FStructProperty);
		FAttributePayload_IsValid = intPtr != IntPtr.Zero && Identifier_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AttributePayload", FAttributePayload_IsValid);
	}
}
