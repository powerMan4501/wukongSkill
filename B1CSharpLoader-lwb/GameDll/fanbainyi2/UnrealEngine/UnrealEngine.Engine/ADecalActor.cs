using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.DecalActor", "Engine", UnrealModuleType.Engine)]
public class ADecalActor : AActor
{
	private static bool Decal_IsValid;

	private static int Decal_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.DecalActor:Decal")]
	public UDecalComponent Decal
	{
		get
		{
			CheckDestroyed();
			if (!Decal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalActor:Decal");
				return null;
			}
			return UObjectMarshaler<UDecalComponent>.FromNative(IntPtr.Add(base.Address, Decal_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Decal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalActor:Decal");
			}
			else
			{
				UObjectMarshaler<UDecalComponent>.ToNative(IntPtr.Add(base.Address, Decal_Offset), value);
			}
		}
	}

	static ADecalActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ADecalActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ADecalActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.DecalActor");
		Decal_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Decal");
		Decal_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Decal", Classes.FObjectProperty);
	}
}
