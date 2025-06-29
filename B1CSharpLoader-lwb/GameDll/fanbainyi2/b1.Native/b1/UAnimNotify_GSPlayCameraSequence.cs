using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)809574560uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.AnimNotify_GSPlayCameraSequence", "b1", UnrealModuleType.Game)]
public class UAnimNotify_GSPlayCameraSequence : UAnimNotify
{
	private static bool WithCameraFilterPitchMin_IsValid;

	private static FFieldAddress WithCameraFilterPitchMin_PropertyAddress;

	private static int WithCameraFilterPitchMin_Offset;

	private static bool WithCameraFilterPitchMax_IsValid;

	private static FFieldAddress WithCameraFilterPitchMax_PropertyAddress;

	private static int WithCameraFilterPitchMax_Offset;

	private static bool WithCameraFilterYawMin_IsValid;

	private static FFieldAddress WithCameraFilterYawMin_PropertyAddress;

	private static int WithCameraFilterYawMin_Offset;

	private static bool WithCameraFilterYawMax_IsValid;

	private static FFieldAddress WithCameraFilterYawMax_PropertyAddress;

	private static int WithCameraFilterYawMax_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/b1.AnimNotify_GSPlayCameraSequence:bWithCameraFilterPitchMin")]
	public bool WithCameraFilterPitchMin
	{
		get
		{
			CheckDestroyed();
			if (!WithCameraFilterPitchMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotify_GSPlayCameraSequence:bWithCameraFilterPitchMin");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WithCameraFilterPitchMin_Offset), 0, WithCameraFilterPitchMin_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WithCameraFilterPitchMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotify_GSPlayCameraSequence:bWithCameraFilterPitchMin");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WithCameraFilterPitchMin_Offset), 0, WithCameraFilterPitchMin_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/b1.AnimNotify_GSPlayCameraSequence:bWithCameraFilterPitchMax")]
	public bool WithCameraFilterPitchMax
	{
		get
		{
			CheckDestroyed();
			if (!WithCameraFilterPitchMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotify_GSPlayCameraSequence:bWithCameraFilterPitchMax");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WithCameraFilterPitchMax_Offset), 0, WithCameraFilterPitchMax_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WithCameraFilterPitchMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotify_GSPlayCameraSequence:bWithCameraFilterPitchMax");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WithCameraFilterPitchMax_Offset), 0, WithCameraFilterPitchMax_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/b1.AnimNotify_GSPlayCameraSequence:bWithCameraFilterYawMin")]
	public bool WithCameraFilterYawMin
	{
		get
		{
			CheckDestroyed();
			if (!WithCameraFilterYawMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotify_GSPlayCameraSequence:bWithCameraFilterYawMin");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WithCameraFilterYawMin_Offset), 0, WithCameraFilterYawMin_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WithCameraFilterYawMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotify_GSPlayCameraSequence:bWithCameraFilterYawMin");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WithCameraFilterYawMin_Offset), 0, WithCameraFilterYawMin_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/b1.AnimNotify_GSPlayCameraSequence:bWithCameraFilterYawMax")]
	public bool WithCameraFilterYawMax
	{
		get
		{
			CheckDestroyed();
			if (!WithCameraFilterYawMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotify_GSPlayCameraSequence:bWithCameraFilterYawMax");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WithCameraFilterYawMax_Offset), 0, WithCameraFilterYawMax_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WithCameraFilterYawMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotify_GSPlayCameraSequence:bWithCameraFilterYawMax");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WithCameraFilterYawMax_Offset), 0, WithCameraFilterYawMax_PropertyAddress.Address, value);
			}
		}
	}

	static UAnimNotify_GSPlayCameraSequence()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotify_GSPlayCameraSequence)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotify_GSPlayCameraSequence));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.AnimNotify_GSPlayCameraSequence");
		NativeReflectionCached.GetPropertyRef(ref WithCameraFilterPitchMin_PropertyAddress, unrealStruct, "bWithCameraFilterPitchMin");
		WithCameraFilterPitchMin_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bWithCameraFilterPitchMin");
		WithCameraFilterPitchMin_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bWithCameraFilterPitchMin", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WithCameraFilterPitchMax_PropertyAddress, unrealStruct, "bWithCameraFilterPitchMax");
		WithCameraFilterPitchMax_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bWithCameraFilterPitchMax");
		WithCameraFilterPitchMax_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bWithCameraFilterPitchMax", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WithCameraFilterYawMin_PropertyAddress, unrealStruct, "bWithCameraFilterYawMin");
		WithCameraFilterYawMin_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bWithCameraFilterYawMin");
		WithCameraFilterYawMin_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bWithCameraFilterYawMin", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WithCameraFilterYawMax_PropertyAddress, unrealStruct, "bWithCameraFilterYawMax");
		WithCameraFilterYawMax_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bWithCameraFilterYawMax");
		WithCameraFilterYawMax_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bWithCameraFilterYawMax", Classes.FBoolProperty);
	}
}
