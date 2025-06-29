using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.BGWOnlineSessionContext", "b1", UnrealModuleType.Game)]
public struct FBGWOnlineSessionContext
{
	private static bool SearchResults_IsValid;

	private static FFieldAddress SearchResults_PropertyAddress;

	private static int SearchResults_Offset;

	[UProperty(Flags = (PropFlags)4503599627371028uL)]
	[UMetaPath("/Script/b1.BGWOnlineSessionContext:SearchResults")]
	public List<FBGWSessionSearchResult> SearchResults;

	private static bool FBGWOnlineSessionContext_IsValid;

	private static int FBGWOnlineSessionContext_StructSize;

	public FBGWOnlineSessionContext Copy()
	{
		FBGWOnlineSessionContext result = this;
		if (SearchResults != null)
		{
			result.SearchResults = new List<FBGWSessionSearchResult>(SearchResults);
		}
		return result;
	}

	public static FBGWOnlineSessionContext FromNative(IntPtr nativeBuffer)
	{
		return new FBGWOnlineSessionContext(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBGWOnlineSessionContext value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBGWOnlineSessionContext FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBGWOnlineSessionContext(nativeBuffer + arrayIndex * FBGWOnlineSessionContext_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBGWOnlineSessionContext value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBGWOnlineSessionContext_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBGWOnlineSessionContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.BGWOnlineSessionContext");
		}
		else
		{
			new TArrayCopyMarshaler<FBGWSessionSearchResult>(1, SearchResults_PropertyAddress, CachedMarshalingDelegates<FBGWSessionSearchResult, FBGWSessionSearchResult>.FromNative, CachedMarshalingDelegates<FBGWSessionSearchResult, FBGWSessionSearchResult>.ToNative).ToNative(IntPtr.Add(nativeStruct, SearchResults_Offset), SearchResults);
		}
	}

	public FBGWOnlineSessionContext(IntPtr nativeStruct)
	{
		if (!FBGWOnlineSessionContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.BGWOnlineSessionContext");
			SearchResults = null;
		}
		else
		{
			SearchResults = new TArrayCopyMarshaler<FBGWSessionSearchResult>(1, SearchResults_PropertyAddress, CachedMarshalingDelegates<FBGWSessionSearchResult, FBGWSessionSearchResult>.FromNative, CachedMarshalingDelegates<FBGWSessionSearchResult, FBGWSessionSearchResult>.ToNative).FromNative(IntPtr.Add(nativeStruct, SearchResults_Offset));
		}
	}

	static FBGWOnlineSessionContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBGWOnlineSessionContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBGWOnlineSessionContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.BGWOnlineSessionContext");
		FBGWOnlineSessionContext_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SearchResults_PropertyAddress, intPtr, "SearchResults");
		SearchResults_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SearchResults");
		SearchResults_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SearchResults", Classes.FArrayProperty);
		FBGWOnlineSessionContext_IsValid = intPtr != IntPtr.Zero && SearchResults_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.BGWOnlineSessionContext", FBGWOnlineSessionContext_IsValid);
	}
}
