using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FieldSystemEngine.FieldSystemActor", "FieldSystemEngine", UnrealModuleType.Engine)]
public class AFieldSystemActor : AActor
{
	private static bool FieldSystemComponent_IsValid;

	private static int FieldSystemComponent_Offset;

	[UProperty(Flags = (PropFlags)7881369141772829uL)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemActor:FieldSystemComponent")]
	public UFieldSystemComponent FieldSystemComponent
	{
		get
		{
			CheckDestroyed();
			if (!FieldSystemComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.FieldSystemActor:FieldSystemComponent");
				return null;
			}
			return UObjectMarshaler<UFieldSystemComponent>.FromNative(IntPtr.Add(base.Address, FieldSystemComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FieldSystemComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.FieldSystemActor:FieldSystemComponent");
			}
			else
			{
				UObjectMarshaler<UFieldSystemComponent>.ToNative(IntPtr.Add(base.Address, FieldSystemComponent_Offset), value);
			}
		}
	}

	static AFieldSystemActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AFieldSystemActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AFieldSystemActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/FieldSystemEngine.FieldSystemActor");
		FieldSystemComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FieldSystemComponent");
		FieldSystemComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FieldSystemComponent", Classes.FObjectProperty);
	}
}
