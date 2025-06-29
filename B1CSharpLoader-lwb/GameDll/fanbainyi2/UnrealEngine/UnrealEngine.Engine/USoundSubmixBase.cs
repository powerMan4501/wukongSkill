using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)810553505uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundSubmixBase", "Engine", UnrealModuleType.Engine)]
public class USoundSubmixBase : UObject
{
	private static bool AutoDisable_IsValid;

	private static FFieldAddress AutoDisable_PropertyAddress;

	private static int AutoDisable_Offset;

	private static bool AutoDisableTime_IsValid;

	private static int AutoDisableTime_Offset;

	private static bool ChildSubmixes_IsValid;

	private static FFieldAddress ChildSubmixes_PropertyAddress;

	private static int ChildSubmixes_Offset;

	private TArrayReadOnlyMarshaler<USoundSubmixBase> ChildSubmixes_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SoundSubmixBase:bAutoDisable")]
	public bool AutoDisable
	{
		get
		{
			CheckDestroyed();
			if (!AutoDisable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmixBase:bAutoDisable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoDisable_Offset), 0, AutoDisable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoDisable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmixBase:bAutoDisable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoDisable_Offset), 0, AutoDisable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundSubmixBase:AutoDisableTime")]
	public float AutoDisableTime
	{
		get
		{
			CheckDestroyed();
			if (!AutoDisableTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmixBase:AutoDisableTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AutoDisableTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoDisableTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmixBase:AutoDisableTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AutoDisableTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534344725uL)]
	[UMetaPath("/Script/Engine.SoundSubmixBase:ChildSubmixes")]
	public TArrayReadOnly<USoundSubmixBase> ChildSubmixes
	{
		get
		{
			CheckDestroyed();
			if (!ChildSubmixes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmixBase:ChildSubmixes");
				return null;
			}
			if (ChildSubmixes_MarshalerCached == null)
			{
				ChildSubmixes_MarshalerCached = new TArrayReadOnlyMarshaler<USoundSubmixBase>(1, ChildSubmixes_PropertyAddress, CachedMarshalingDelegates<USoundSubmixBase, UObjectMarshaler<USoundSubmixBase>>.FromNative, CachedMarshalingDelegates<USoundSubmixBase, UObjectMarshaler<USoundSubmixBase>>.ToNative);
			}
			return ChildSubmixes_MarshalerCached.FromNative(IntPtr.Add(base.Address, ChildSubmixes_Offset));
		}
	}

	static USoundSubmixBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USoundSubmixBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USoundSubmixBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.SoundSubmixBase");
		NativeReflectionCached.GetPropertyRef(ref AutoDisable_PropertyAddress, unrealStruct, "bAutoDisable");
		AutoDisable_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAutoDisable");
		AutoDisable_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAutoDisable", Classes.FBoolProperty);
		AutoDisableTime_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AutoDisableTime");
		AutoDisableTime_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AutoDisableTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ChildSubmixes_PropertyAddress, unrealStruct, "ChildSubmixes");
		ChildSubmixes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ChildSubmixes");
		ChildSubmixes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ChildSubmixes", Classes.FArrayProperty);
	}
}
