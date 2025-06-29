using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkWaapiFieldNames", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkWaapiFieldNames
{
	private static bool FieldName_IsValid;

	private static int FieldName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056277uL)]
	[UMetaPath("/Script/AkAudio.AkWaapiFieldNames:FieldName")]
	public string FieldName;

	private static bool FAkWaapiFieldNames_IsValid;

	private static int FAkWaapiFieldNames_StructSize;

	public FAkWaapiFieldNames Copy()
	{
		return this;
	}

	public static FAkWaapiFieldNames FromNative(IntPtr nativeBuffer)
	{
		return new FAkWaapiFieldNames(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkWaapiFieldNames value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkWaapiFieldNames FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkWaapiFieldNames(nativeBuffer + arrayIndex * FAkWaapiFieldNames_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkWaapiFieldNames value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkWaapiFieldNames_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkWaapiFieldNames_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkWaapiFieldNames");
		}
		else
		{
			FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, FieldName_Offset), FieldName);
		}
	}

	public FAkWaapiFieldNames(IntPtr nativeStruct)
	{
		if (!FAkWaapiFieldNames_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkWaapiFieldNames");
			FieldName = FStringMarshaler.DefaultString;
		}
		else
		{
			FieldName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, FieldName_Offset));
		}
	}

	static FAkWaapiFieldNames()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkWaapiFieldNames)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkWaapiFieldNames));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkWaapiFieldNames");
		FAkWaapiFieldNames_StructSize = NativeReflection.GetStructSize(intPtr);
		FieldName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FieldName");
		FieldName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FieldName", Classes.FStrProperty);
		FAkWaapiFieldNames_IsValid = intPtr != IntPtr.Zero && FieldName_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkWaapiFieldNames", FAkWaapiFieldNames_IsValid);
	}
}
