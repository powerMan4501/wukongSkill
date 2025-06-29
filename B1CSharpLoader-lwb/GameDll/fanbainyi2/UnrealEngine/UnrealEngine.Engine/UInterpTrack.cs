using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)810033313uL, Config = "Engine")]
[UMetaPath("/Script/Engine.InterpTrack", "Engine", UnrealModuleType.Engine)]
public class UInterpTrack : UObject
{
	private static bool SubTracks_IsValid;

	private static FFieldAddress SubTracks_PropertyAddress;

	private static int SubTracks_Offset;

	private TArrayReadOnlyMarshaler<UInterpTrack> SubTracks_MarshalerCached;

	[UProperty(Flags = (PropFlags)5629499534213652uL)]
	[UMetaPath("/Script/Engine.InterpTrack:SubTracks")]
	public TArrayReadOnly<UInterpTrack> SubTracks
	{
		get
		{
			CheckDestroyed();
			if (!SubTracks_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpTrack:SubTracks");
				return null;
			}
			if (SubTracks_MarshalerCached == null)
			{
				SubTracks_MarshalerCached = new TArrayReadOnlyMarshaler<UInterpTrack>(1, SubTracks_PropertyAddress, CachedMarshalingDelegates<UInterpTrack, UObjectMarshaler<UInterpTrack>>.FromNative, CachedMarshalingDelegates<UInterpTrack, UObjectMarshaler<UInterpTrack>>.ToNative);
			}
			return SubTracks_MarshalerCached.FromNative(IntPtr.Add(base.Address, SubTracks_Offset));
		}
	}

	static UInterpTrack()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterpTrack)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterpTrack));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.InterpTrack");
		NativeReflectionCached.GetPropertyRef(ref SubTracks_PropertyAddress, unrealStruct, "SubTracks");
		SubTracks_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SubTracks");
		SubTracks_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SubTracks", Classes.FArrayProperty);
	}
}
