using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810033312uL, Config = "Engine")]
[UMetaPath("/Script/Engine.InterpGroup", "Engine", UnrealModuleType.Engine)]
public class UInterpGroup : UObject
{
	private static bool InterpTracks_IsValid;

	private static FFieldAddress InterpTracks_PropertyAddress;

	private static int InterpTracks_Offset;

	private TArrayReadOnlyMarshaler<UInterpTrack> InterpTracks_MarshalerCached;

	[UProperty(Flags = (PropFlags)5629499534213660uL)]
	[UMetaPath("/Script/Engine.InterpGroup:InterpTracks")]
	public TArrayReadOnly<UInterpTrack> InterpTracks
	{
		get
		{
			CheckDestroyed();
			if (!InterpTracks_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpGroup:InterpTracks");
				return null;
			}
			if (InterpTracks_MarshalerCached == null)
			{
				InterpTracks_MarshalerCached = new TArrayReadOnlyMarshaler<UInterpTrack>(1, InterpTracks_PropertyAddress, CachedMarshalingDelegates<UInterpTrack, UObjectMarshaler<UInterpTrack>>.FromNative, CachedMarshalingDelegates<UInterpTrack, UObjectMarshaler<UInterpTrack>>.ToNative);
			}
			return InterpTracks_MarshalerCached.FromNative(IntPtr.Add(base.Address, InterpTracks_Offset));
		}
	}

	static UInterpGroup()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterpGroup)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterpGroup));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.InterpGroup");
		NativeReflectionCached.GetPropertyRef(ref InterpTracks_PropertyAddress, unrealStruct, "InterpTracks");
		InterpTracks_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InterpTracks");
		InterpTracks_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InterpTracks", Classes.FArrayProperty);
	}
}
