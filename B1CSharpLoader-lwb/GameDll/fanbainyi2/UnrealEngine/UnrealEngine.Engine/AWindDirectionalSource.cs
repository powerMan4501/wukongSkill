using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.WindDirectionalSource", "Engine", UnrealModuleType.Engine)]
public class AWindDirectionalSource : AInfo
{
	private static bool Component_IsValid;

	private static int Component_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.WindDirectionalSource:Component")]
	public UWindDirectionalSourceComponent Component
	{
		get
		{
			CheckDestroyed();
			if (!Component_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WindDirectionalSource:Component");
				return null;
			}
			return UObjectMarshaler<UWindDirectionalSourceComponent>.FromNative(IntPtr.Add(base.Address, Component_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Component_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WindDirectionalSource:Component");
			}
			else
			{
				UObjectMarshaler<UWindDirectionalSourceComponent>.ToNative(IntPtr.Add(base.Address, Component_Offset), value);
			}
		}
	}

	static AWindDirectionalSource()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AWindDirectionalSource)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AWindDirectionalSource));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.WindDirectionalSource");
		Component_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Component");
		Component_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Component", Classes.FObjectProperty);
	}
}
