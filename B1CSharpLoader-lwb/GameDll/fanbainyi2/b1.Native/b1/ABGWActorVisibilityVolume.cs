using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWActorVisibilityVolume", "b1", UnrealModuleType.Game)]
public class ABGWActorVisibilityVolume : AVolume
{
	private static bool AttachedActors_IsValid;

	private static FFieldAddress AttachedActors_PropertyAddress;

	private static int AttachedActors_Offset;

	private TArrayReadWriteMarshaler<AActor> AttachedActors_MarshalerCached;

	private static bool IsHide_IsValid;

	private static FFieldAddress IsHide_PropertyAddress;

	private static int IsHide_Offset;

	private static bool Disabled_IsValid;

	private static FFieldAddress Disabled_PropertyAddress;

	private static int Disabled_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/b1.BGWActorVisibilityVolume:AttachedActors")]
	public TArrayReadWrite<AActor> AttachedActors
	{
		get
		{
			CheckDestroyed();
			if (!AttachedActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWActorVisibilityVolume:AttachedActors");
				return null;
			}
			if (AttachedActors_MarshalerCached == null)
			{
				AttachedActors_MarshalerCached = new TArrayReadWriteMarshaler<AActor>(1, AttachedActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
			}
			return AttachedActors_MarshalerCached.FromNative(IntPtr.Add(base.Address, AttachedActors_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGWActorVisibilityVolume:IsHide")]
	public bool IsHide
	{
		get
		{
			CheckDestroyed();
			if (!IsHide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWActorVisibilityVolume:IsHide");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsHide_Offset), 0, IsHide_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsHide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWActorVisibilityVolume:IsHide");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsHide_Offset), 0, IsHide_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGWActorVisibilityVolume:bDisabled")]
	public bool Disabled
	{
		get
		{
			CheckDestroyed();
			if (!Disabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWActorVisibilityVolume:bDisabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Disabled_Offset), 0, Disabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Disabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWActorVisibilityVolume:bDisabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Disabled_Offset), 0, Disabled_PropertyAddress.Address, value);
			}
		}
	}

	static ABGWActorVisibilityVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGWActorVisibilityVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGWActorVisibilityVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BGWActorVisibilityVolume");
		NativeReflectionCached.GetPropertyRef(ref AttachedActors_PropertyAddress, unrealStruct, "AttachedActors");
		AttachedActors_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttachedActors");
		AttachedActors_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttachedActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsHide_PropertyAddress, unrealStruct, "IsHide");
		IsHide_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "IsHide");
		IsHide_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "IsHide", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Disabled_PropertyAddress, unrealStruct, "bDisabled");
		Disabled_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bDisabled");
		Disabled_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bDisabled", Classes.FBoolProperty);
	}
}
