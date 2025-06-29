using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[UMetaPath("/Script/Engine.InterpData", "Engine", UnrealModuleType.Engine)]
public class UInterpData : UObject
{
	private static bool InterpLength_IsValid;

	private static int InterpLength_Offset;

	private static bool InterpGroups_IsValid;

	private static FFieldAddress InterpGroups_PropertyAddress;

	private static int InterpGroups_Offset;

	private TArrayReadOnlyMarshaler<UInterpGroup> InterpGroups_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/Engine.InterpData:InterpLength")]
	public float InterpLength
	{
		get
		{
			CheckDestroyed();
			if (!InterpLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpData:InterpLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InterpLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InterpLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpData:InterpLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InterpLength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213660uL)]
	[UMetaPath("/Script/Engine.InterpData:InterpGroups")]
	public TArrayReadOnly<UInterpGroup> InterpGroups
	{
		get
		{
			CheckDestroyed();
			if (!InterpGroups_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InterpData:InterpGroups");
				return null;
			}
			if (InterpGroups_MarshalerCached == null)
			{
				InterpGroups_MarshalerCached = new TArrayReadOnlyMarshaler<UInterpGroup>(1, InterpGroups_PropertyAddress, CachedMarshalingDelegates<UInterpGroup, UObjectMarshaler<UInterpGroup>>.FromNative, CachedMarshalingDelegates<UInterpGroup, UObjectMarshaler<UInterpGroup>>.ToNative);
			}
			return InterpGroups_MarshalerCached.FromNative(IntPtr.Add(base.Address, InterpGroups_Offset));
		}
	}

	static UInterpData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterpData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterpData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.InterpData");
		InterpLength_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InterpLength");
		InterpLength_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InterpLength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InterpGroups_PropertyAddress, unrealStruct, "InterpGroups");
		InterpGroups_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InterpGroups");
		InterpGroups_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InterpGroups", Classes.FArrayProperty);
	}
}
