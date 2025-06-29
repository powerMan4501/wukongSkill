using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.CachedActivityIntentReceivedParamCS", "UnrealExtent", UnrealModuleType.Game)]
public struct FCachedActivityIntentReceivedParamCS
{
	private static bool UserId_IsValid;

	private static int UserId_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/UnrealExtent.CachedActivityIntentReceivedParamCS:UserId")]
	public string UserId;

	private static bool ActivityId_IsValid;

	private static int ActivityId_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/UnrealExtent.CachedActivityIntentReceivedParamCS:ActivityId")]
	public string ActivityId;

	private static bool SessionId_IsValid;

	private static int SessionId_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/UnrealExtent.CachedActivityIntentReceivedParamCS:SessionId")]
	public string SessionId;

	private static bool FCachedActivityIntentReceivedParamCS_IsValid;

	private static int FCachedActivityIntentReceivedParamCS_StructSize;

	public FCachedActivityIntentReceivedParamCS Copy()
	{
		return this;
	}

	public static FCachedActivityIntentReceivedParamCS FromNative(IntPtr nativeBuffer)
	{
		return new FCachedActivityIntentReceivedParamCS(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCachedActivityIntentReceivedParamCS value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCachedActivityIntentReceivedParamCS FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCachedActivityIntentReceivedParamCS(nativeBuffer + arrayIndex * FCachedActivityIntentReceivedParamCS_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCachedActivityIntentReceivedParamCS value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCachedActivityIntentReceivedParamCS_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCachedActivityIntentReceivedParamCS_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.CachedActivityIntentReceivedParamCS");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, UserId_Offset), UserId);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ActivityId_Offset), ActivityId);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, SessionId_Offset), SessionId);
	}

	public FCachedActivityIntentReceivedParamCS(IntPtr nativeStruct)
	{
		if (!FCachedActivityIntentReceivedParamCS_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.CachedActivityIntentReceivedParamCS");
			UserId = FStringMarshaler.DefaultString;
			ActivityId = FStringMarshaler.DefaultString;
			SessionId = FStringMarshaler.DefaultString;
		}
		else
		{
			UserId = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, UserId_Offset));
			ActivityId = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ActivityId_Offset));
			SessionId = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, SessionId_Offset));
		}
	}

	static FCachedActivityIntentReceivedParamCS()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCachedActivityIntentReceivedParamCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCachedActivityIntentReceivedParamCS));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.CachedActivityIntentReceivedParamCS");
		FCachedActivityIntentReceivedParamCS_StructSize = NativeReflection.GetStructSize(intPtr);
		UserId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UserId");
		UserId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UserId", Classes.FStrProperty);
		ActivityId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActivityId");
		ActivityId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActivityId", Classes.FStrProperty);
		SessionId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SessionId");
		SessionId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SessionId", Classes.FStrProperty);
		FCachedActivityIntentReceivedParamCS_IsValid = intPtr != IntPtr.Zero && UserId_IsValid && ActivityId_IsValid && SessionId_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.CachedActivityIntentReceivedParamCS", FCachedActivityIntentReceivedParamCS_IsValid);
	}
}
