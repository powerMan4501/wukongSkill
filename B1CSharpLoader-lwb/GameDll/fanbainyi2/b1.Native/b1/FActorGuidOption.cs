using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.ActorGuidOption", "b1", UnrealModuleType.Game)]
public struct FActorGuidOption
{
	private static bool DisplayName_IsValid;

	private static int DisplayName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/b1.ActorGuidOption:DisplayName")]
	public string DisplayName;

	private static bool ActorGuid_IsValid;

	private static int ActorGuid_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/b1.ActorGuidOption:ActorGuid")]
	public string ActorGuid;

	private static bool FActorGuidOption_IsValid;

	private static int FActorGuidOption_StructSize;

	public FActorGuidOption Copy()
	{
		return this;
	}

	public static FActorGuidOption FromNative(IntPtr nativeBuffer)
	{
		return new FActorGuidOption(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FActorGuidOption value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FActorGuidOption FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FActorGuidOption(nativeBuffer + arrayIndex * FActorGuidOption_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FActorGuidOption value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FActorGuidOption_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FActorGuidOption_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.ActorGuidOption");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DisplayName_Offset), DisplayName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ActorGuid_Offset), ActorGuid);
	}

	public FActorGuidOption(IntPtr nativeStruct)
	{
		if (!FActorGuidOption_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.ActorGuidOption");
			DisplayName = FStringMarshaler.DefaultString;
			ActorGuid = FStringMarshaler.DefaultString;
		}
		else
		{
			DisplayName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DisplayName_Offset));
			ActorGuid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ActorGuid_Offset));
		}
	}

	static FActorGuidOption()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FActorGuidOption)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FActorGuidOption));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.ActorGuidOption");
		FActorGuidOption_StructSize = NativeReflection.GetStructSize(intPtr);
		DisplayName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisplayName");
		DisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisplayName", Classes.FStrProperty);
		ActorGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorGuid");
		ActorGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorGuid", Classes.FStrProperty);
		FActorGuidOption_IsValid = intPtr != IntPtr.Zero && DisplayName_IsValid && ActorGuid_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.ActorGuidOption", FActorGuidOption_IsValid);
	}
}
