using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.ExponentialHeightFog", "Engine", UnrealModuleType.Engine)]
public class AExponentialHeightFog : AInfo
{
	private static bool Component_IsValid;

	private static int Component_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFog:Component")]
	public UExponentialHeightFogComponent Component
	{
		get
		{
			CheckDestroyed();
			if (!Component_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFog:Component");
				return null;
			}
			return UObjectMarshaler<UExponentialHeightFogComponent>.FromNative(IntPtr.Add(base.Address, Component_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Component_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFog:Component");
			}
			else
			{
				UObjectMarshaler<UExponentialHeightFogComponent>.ToNative(IntPtr.Add(base.Address, Component_Offset), value);
			}
		}
	}

	static AExponentialHeightFog()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AExponentialHeightFog)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AExponentialHeightFog));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.ExponentialHeightFog");
		Component_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Component");
		Component_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Component", Classes.FObjectProperty);
	}
}
