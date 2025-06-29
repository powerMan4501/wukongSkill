using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.RadialForceActor", "Engine", UnrealModuleType.Engine)]
public class ARadialForceActor : ARigidBodyBase
{
	private static bool ForceComponent_IsValid;

	private static int ForceComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.RadialForceActor:ForceComponent")]
	public URadialForceComponent ForceComponent
	{
		get
		{
			CheckDestroyed();
			if (!ForceComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RadialForceActor:ForceComponent");
				return null;
			}
			return UObjectMarshaler<URadialForceComponent>.FromNative(IntPtr.Add(base.Address, ForceComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RadialForceActor:ForceComponent");
			}
			else
			{
				UObjectMarshaler<URadialForceComponent>.ToNative(IntPtr.Add(base.Address, ForceComponent_Offset), value);
			}
		}
	}

	static ARadialForceActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ARadialForceActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ARadialForceActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.RadialForceActor");
		ForceComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ForceComponent");
		ForceComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ForceComponent", Classes.FObjectProperty);
	}
}
