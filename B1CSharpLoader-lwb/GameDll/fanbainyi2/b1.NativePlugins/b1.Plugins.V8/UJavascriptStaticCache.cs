using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/V8.JavascriptStaticCache", "V8", UnrealModuleType.GamePlugin)]
public class UJavascriptStaticCache : UObject
{
	private static bool Isolates_IsValid;

	private static FFieldAddress Isolates_PropertyAddress;

	private static int Isolates_Offset;

	private TArrayReadOnlyMarshaler<UJavascriptIsolate> Isolates_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627436565uL)]
	[UMetaPath("/Script/V8.JavascriptStaticCache:Isolates")]
	protected TArrayReadOnly<UJavascriptIsolate> Isolates
	{
		get
		{
			CheckDestroyed();
			if (!Isolates_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/V8.JavascriptStaticCache:Isolates");
				return null;
			}
			if (Isolates_MarshalerCached == null)
			{
				Isolates_MarshalerCached = new TArrayReadOnlyMarshaler<UJavascriptIsolate>(1, Isolates_PropertyAddress, CachedMarshalingDelegates<UJavascriptIsolate, UObjectMarshaler<UJavascriptIsolate>>.FromNative, CachedMarshalingDelegates<UJavascriptIsolate, UObjectMarshaler<UJavascriptIsolate>>.ToNative);
			}
			return Isolates_MarshalerCached.FromNative(IntPtr.Add(base.Address, Isolates_Offset));
		}
	}

	static UJavascriptStaticCache()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptStaticCache)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptStaticCache));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/V8.JavascriptStaticCache");
		NativeReflectionCached.GetPropertyRef(ref Isolates_PropertyAddress, unrealStruct, "Isolates");
		Isolates_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Isolates");
		Isolates_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Isolates", Classes.FArrayProperty);
	}
}
