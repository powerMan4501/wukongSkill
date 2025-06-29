using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.BlueprintSearchResult", "b1", UnrealModuleType.Game)]
public struct FBlueprintSearchResult
{
	private static bool ServerName_IsValid;

	private static int ServerName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/b1.BlueprintSearchResult:ServerName")]
	public string ServerName;

	private static bool IsInProgress_IsValid;

	private static FFieldAddress IsInProgress_PropertyAddress;

	private static int IsInProgress_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/b1.BlueprintSearchResult:bIsInProgress")]
	public bool IsInProgress;

	private static bool MapName_IsValid;

	private static int MapName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/b1.BlueprintSearchResult:MapName")]
	public string MapName;

	private static bool PingInMs_IsValid;

	private static int PingInMs_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/b1.BlueprintSearchResult:PingInMs")]
	public int PingInMs;

	private static bool CurrentPlayers_IsValid;

	private static int CurrentPlayers_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/b1.BlueprintSearchResult:CurrentPlayers")]
	public int CurrentPlayers;

	private static bool MaxPlayers_IsValid;

	private static int MaxPlayers_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/b1.BlueprintSearchResult:MaxPlayers")]
	public int MaxPlayers;

	private static bool HostPlayerName_IsValid;

	private static int HostPlayerName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/b1.BlueprintSearchResult:HostPlayerName")]
	public string HostPlayerName;

	private static bool MessageDigest_IsValid;

	private static int MessageDigest_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/b1.BlueprintSearchResult:MessageDigest")]
	public string MessageDigest;

	private static bool FBlueprintSearchResult_IsValid;

	private static int FBlueprintSearchResult_StructSize;

	public FBlueprintSearchResult Copy()
	{
		return this;
	}

	public static FBlueprintSearchResult FromNative(IntPtr nativeBuffer)
	{
		return new FBlueprintSearchResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBlueprintSearchResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBlueprintSearchResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBlueprintSearchResult(nativeBuffer + arrayIndex * FBlueprintSearchResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBlueprintSearchResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBlueprintSearchResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBlueprintSearchResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.BlueprintSearchResult");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ServerName_Offset), ServerName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsInProgress_Offset), 0, IsInProgress_PropertyAddress.Address, IsInProgress);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, MapName_Offset), MapName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PingInMs_Offset), PingInMs);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CurrentPlayers_Offset), CurrentPlayers);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxPlayers_Offset), MaxPlayers);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, HostPlayerName_Offset), HostPlayerName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, MessageDigest_Offset), MessageDigest);
	}

	public FBlueprintSearchResult(IntPtr nativeStruct)
	{
		if (!FBlueprintSearchResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.BlueprintSearchResult");
			ServerName = FStringMarshaler.DefaultString;
			IsInProgress = false;
			MapName = FStringMarshaler.DefaultString;
			PingInMs = 0;
			CurrentPlayers = 0;
			MaxPlayers = 0;
			HostPlayerName = FStringMarshaler.DefaultString;
			MessageDigest = FStringMarshaler.DefaultString;
		}
		else
		{
			ServerName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ServerName_Offset));
			IsInProgress = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsInProgress_Offset), 0, IsInProgress_PropertyAddress.Address);
			MapName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, MapName_Offset));
			PingInMs = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PingInMs_Offset));
			CurrentPlayers = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CurrentPlayers_Offset));
			MaxPlayers = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxPlayers_Offset));
			HostPlayerName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, HostPlayerName_Offset));
			MessageDigest = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, MessageDigest_Offset));
		}
	}

	static FBlueprintSearchResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBlueprintSearchResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBlueprintSearchResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.BlueprintSearchResult");
		FBlueprintSearchResult_StructSize = NativeReflection.GetStructSize(intPtr);
		ServerName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ServerName");
		ServerName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ServerName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsInProgress_PropertyAddress, intPtr, "bIsInProgress");
		IsInProgress_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsInProgress");
		IsInProgress_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsInProgress", Classes.FBoolProperty);
		MapName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MapName");
		MapName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MapName", Classes.FStrProperty);
		PingInMs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PingInMs");
		PingInMs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PingInMs", Classes.FIntProperty);
		CurrentPlayers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentPlayers");
		CurrentPlayers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentPlayers", Classes.FIntProperty);
		MaxPlayers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxPlayers");
		MaxPlayers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxPlayers", Classes.FIntProperty);
		HostPlayerName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HostPlayerName");
		HostPlayerName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HostPlayerName", Classes.FStrProperty);
		MessageDigest_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MessageDigest");
		MessageDigest_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MessageDigest", Classes.FStrProperty);
		FBlueprintSearchResult_IsValid = intPtr != IntPtr.Zero && ServerName_IsValid && IsInProgress_IsValid && MapName_IsValid && PingInMs_IsValid && CurrentPlayers_IsValid && MaxPlayers_IsValid && HostPlayerName_IsValid && MessageDigest_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.BlueprintSearchResult", FBlueprintSearchResult_IsValid);
	}
}
