using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundClass", "Engine", UnrealModuleType.Engine)]
public class USoundClass : UObject
{
	private static bool Properties_IsValid;

	private static int Properties_Offset;

	private static bool ChildClasses_IsValid;

	private static FFieldAddress ChildClasses_PropertyAddress;

	private static int ChildClasses_Offset;

	private TArrayReadOnlyMarshaler<USoundClass> ChildClasses_MarshalerCached;

	private static bool PassiveSoundMixModifiers_IsValid;

	private static FFieldAddress PassiveSoundMixModifiers_PropertyAddress;

	private static int PassiveSoundMixModifiers_Offset;

	private TArrayReadOnlyMarshaler<FPassiveSoundMixModifier> PassiveSoundMixModifiers_MarshalerCached;

	private static bool ParentClass_IsValid;

	private static int ParentClass_Offset;

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/Engine.SoundClass:Properties")]
	public FSoundClassProperties Properties
	{
		get
		{
			CheckDestroyed();
			if (!Properties_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundClass:Properties");
				return default(FSoundClassProperties);
			}
			return FSoundClassProperties.FromNative(IntPtr.Add(base.Address, Properties_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Properties_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundClass:Properties");
			}
			else
			{
				FSoundClassProperties.ToNative(IntPtr.Add(base.Address, Properties_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213653uL)]
	[UMetaPath("/Script/Engine.SoundClass:ChildClasses")]
	public TArrayReadOnly<USoundClass> ChildClasses
	{
		get
		{
			CheckDestroyed();
			if (!ChildClasses_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundClass:ChildClasses");
				return null;
			}
			if (ChildClasses_MarshalerCached == null)
			{
				ChildClasses_MarshalerCached = new TArrayReadOnlyMarshaler<USoundClass>(1, ChildClasses_PropertyAddress, CachedMarshalingDelegates<USoundClass, UObjectMarshaler<USoundClass>>.FromNative, CachedMarshalingDelegates<USoundClass, UObjectMarshaler<USoundClass>>.ToNative);
			}
			return ChildClasses_MarshalerCached.FromNative(IntPtr.Add(base.Address, ChildClasses_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/Engine.SoundClass:PassiveSoundMixModifiers")]
	public TArrayReadOnly<FPassiveSoundMixModifier> PassiveSoundMixModifiers
	{
		get
		{
			CheckDestroyed();
			if (!PassiveSoundMixModifiers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundClass:PassiveSoundMixModifiers");
				return null;
			}
			if (PassiveSoundMixModifiers_MarshalerCached == null)
			{
				PassiveSoundMixModifiers_MarshalerCached = new TArrayReadOnlyMarshaler<FPassiveSoundMixModifier>(1, PassiveSoundMixModifiers_PropertyAddress, CachedMarshalingDelegates<FPassiveSoundMixModifier, FPassiveSoundMixModifier>.FromNative, CachedMarshalingDelegates<FPassiveSoundMixModifier, FPassiveSoundMixModifier>.ToNative);
			}
			return PassiveSoundMixModifiers_MarshalerCached.FromNative(IntPtr.Add(base.Address, PassiveSoundMixModifiers_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117460uL)]
	[UMetaPath("/Script/Engine.SoundClass:ParentClass")]
	public USoundClass ParentClass
	{
		get
		{
			CheckDestroyed();
			if (!ParentClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundClass:ParentClass");
				return null;
			}
			return UObjectMarshaler<USoundClass>.FromNative(IntPtr.Add(base.Address, ParentClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParentClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundClass:ParentClass");
			}
			else
			{
				UObjectMarshaler<USoundClass>.ToNative(IntPtr.Add(base.Address, ParentClass_Offset), value);
			}
		}
	}

	static USoundClass()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USoundClass)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USoundClass));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.SoundClass");
		Properties_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Properties");
		Properties_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Properties", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ChildClasses_PropertyAddress, unrealStruct, "ChildClasses");
		ChildClasses_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ChildClasses");
		ChildClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ChildClasses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref PassiveSoundMixModifiers_PropertyAddress, unrealStruct, "PassiveSoundMixModifiers");
		PassiveSoundMixModifiers_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PassiveSoundMixModifiers");
		PassiveSoundMixModifiers_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PassiveSoundMixModifiers", Classes.FArrayProperty);
		ParentClass_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ParentClass");
		ParentClass_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ParentClass", Classes.FObjectProperty);
	}
}
