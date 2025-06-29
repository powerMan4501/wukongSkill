using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.BracketPayload", "Engine", UnrealModuleType.Engine)]
public struct FBracketPayload
{
	private static bool Description_IsValid;

	private static int Description_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/Engine.BracketPayload:Description")]
	public string Description;

	private static bool FBracketPayload_IsValid;

	private static int FBracketPayload_StructSize;

	public FBracketPayload Copy()
	{
		return this;
	}

	public static FBracketPayload FromNative(IntPtr nativeBuffer)
	{
		return new FBracketPayload(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBracketPayload value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBracketPayload FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBracketPayload(nativeBuffer + arrayIndex * FBracketPayload_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBracketPayload value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBracketPayload_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBracketPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.BracketPayload");
		}
		else
		{
			FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Description_Offset), Description);
		}
	}

	public FBracketPayload(IntPtr nativeStruct)
	{
		if (!FBracketPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.BracketPayload");
			Description = FStringMarshaler.DefaultString;
		}
		else
		{
			Description = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Description_Offset));
		}
	}

	static FBracketPayload()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBracketPayload)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBracketPayload));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.BracketPayload");
		FBracketPayload_StructSize = NativeReflection.GetStructSize(intPtr);
		Description_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Description");
		Description_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Description", Classes.FStrProperty);
		FBracketPayload_IsValid = intPtr != IntPtr.Zero && Description_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.BracketPayload", FBracketPayload_IsValid);
	}
}
