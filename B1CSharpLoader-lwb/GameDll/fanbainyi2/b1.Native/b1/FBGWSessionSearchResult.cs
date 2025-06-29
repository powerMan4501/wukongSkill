using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.BGWSessionSearchResult", "b1", UnrealModuleType.Game)]
public struct FBGWSessionSearchResult
{
	private static bool OwningUserId_IsValid;

	private static int OwningUserId_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/b1.BGWSessionSearchResult:OwningUserId")]
	public string OwningUserId;

	private static bool SessionId_IsValid;

	private static int SessionId_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/b1.BGWSessionSearchResult:SessionId")]
	public string SessionId;

	private static bool OwningUserName_IsValid;

	private static int OwningUserName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/b1.BGWSessionSearchResult:OwningUserName")]
	public string OwningUserName;

	private static bool MaxPlayerCount_IsValid;

	private static int MaxPlayerCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/b1.BGWSessionSearchResult:MaxPlayerCount")]
	public int MaxPlayerCount;

	private static bool AvaiablePlayercount_IsValid;

	private static int AvaiablePlayercount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/b1.BGWSessionSearchResult:AvaiablePlayercount")]
	public int AvaiablePlayercount;

	private static bool FBGWSessionSearchResult_IsValid;

	private static int FBGWSessionSearchResult_StructSize;

	public FBGWSessionSearchResult Copy()
	{
		return this;
	}

	public static FBGWSessionSearchResult FromNative(IntPtr nativeBuffer)
	{
		return new FBGWSessionSearchResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBGWSessionSearchResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBGWSessionSearchResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBGWSessionSearchResult(nativeBuffer + arrayIndex * FBGWSessionSearchResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBGWSessionSearchResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBGWSessionSearchResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBGWSessionSearchResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.BGWSessionSearchResult");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, OwningUserId_Offset), OwningUserId);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, SessionId_Offset), SessionId);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, OwningUserName_Offset), OwningUserName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxPlayerCount_Offset), MaxPlayerCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, AvaiablePlayercount_Offset), AvaiablePlayercount);
	}

	public FBGWSessionSearchResult(IntPtr nativeStruct)
	{
		if (!FBGWSessionSearchResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.BGWSessionSearchResult");
			OwningUserId = FStringMarshaler.DefaultString;
			SessionId = FStringMarshaler.DefaultString;
			OwningUserName = FStringMarshaler.DefaultString;
			MaxPlayerCount = 0;
			AvaiablePlayercount = 0;
		}
		else
		{
			OwningUserId = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, OwningUserId_Offset));
			SessionId = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, SessionId_Offset));
			OwningUserName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, OwningUserName_Offset));
			MaxPlayerCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxPlayerCount_Offset));
			AvaiablePlayercount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, AvaiablePlayercount_Offset));
		}
	}

	static FBGWSessionSearchResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBGWSessionSearchResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBGWSessionSearchResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.BGWSessionSearchResult");
		FBGWSessionSearchResult_StructSize = NativeReflection.GetStructSize(intPtr);
		OwningUserId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OwningUserId");
		OwningUserId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OwningUserId", Classes.FStrProperty);
		SessionId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SessionId");
		SessionId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SessionId", Classes.FStrProperty);
		OwningUserName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OwningUserName");
		OwningUserName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OwningUserName", Classes.FStrProperty);
		MaxPlayerCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxPlayerCount");
		MaxPlayerCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxPlayerCount", Classes.FIntProperty);
		AvaiablePlayercount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AvaiablePlayercount");
		AvaiablePlayercount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AvaiablePlayercount", Classes.FIntProperty);
		FBGWSessionSearchResult_IsValid = intPtr != IntPtr.Zero && OwningUserId_IsValid && SessionId_IsValid && OwningUserName_IsValid && MaxPlayerCount_IsValid && AvaiablePlayercount_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.BGWSessionSearchResult", FBGWSessionSearchResult_IsValid);
	}
}
