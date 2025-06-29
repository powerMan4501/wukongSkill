using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)810553505uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundSubmixWithParentBase", "Engine", UnrealModuleType.Engine)]
public class USoundSubmixWithParentBase : USoundSubmixBase
{
	private static bool ParentSubmix_IsValid;

	private static int ParentSubmix_Offset;

	[UProperty(Flags = (PropFlags)7881369141248533uL)]
	[UMetaPath("/Script/Engine.SoundSubmixWithParentBase:ParentSubmix")]
	public USoundSubmixBase ParentSubmix
	{
		get
		{
			CheckDestroyed();
			if (!ParentSubmix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmixWithParentBase:ParentSubmix");
				return null;
			}
			return UObjectMarshaler<USoundSubmixBase>.FromNative(IntPtr.Add(base.Address, ParentSubmix_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParentSubmix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmixWithParentBase:ParentSubmix");
			}
			else
			{
				UObjectMarshaler<USoundSubmixBase>.ToNative(IntPtr.Add(base.Address, ParentSubmix_Offset), value);
			}
		}
	}

	static USoundSubmixWithParentBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USoundSubmixWithParentBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USoundSubmixWithParentBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.SoundSubmixWithParentBase");
		ParentSubmix_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ParentSubmix");
		ParentSubmix_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ParentSubmix", Classes.FObjectProperty);
	}
}
