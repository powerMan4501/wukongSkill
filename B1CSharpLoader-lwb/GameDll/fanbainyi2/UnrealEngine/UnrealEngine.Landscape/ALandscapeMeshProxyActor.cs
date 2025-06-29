using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Landscape.LandscapeMeshProxyActor", "Landscape", UnrealModuleType.Engine)]
public class ALandscapeMeshProxyActor : AActor
{
	private static bool LandscapeMeshProxyComponent_IsValid;

	private static int LandscapeMeshProxyComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Landscape.LandscapeMeshProxyActor:LandscapeMeshProxyComponent")]
	public ULandscapeMeshProxyComponent LandscapeMeshProxyComponent
	{
		get
		{
			CheckDestroyed();
			if (!LandscapeMeshProxyComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeMeshProxyActor:LandscapeMeshProxyComponent");
				return null;
			}
			return UObjectMarshaler<ULandscapeMeshProxyComponent>.FromNative(IntPtr.Add(base.Address, LandscapeMeshProxyComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandscapeMeshProxyComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeMeshProxyActor:LandscapeMeshProxyComponent");
			}
			else
			{
				UObjectMarshaler<ULandscapeMeshProxyComponent>.ToNative(IntPtr.Add(base.Address, LandscapeMeshProxyComponent_Offset), value);
			}
		}
	}

	static ALandscapeMeshProxyActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ALandscapeMeshProxyActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ALandscapeMeshProxyActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Landscape.LandscapeMeshProxyActor");
		LandscapeMeshProxyComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LandscapeMeshProxyComponent");
		LandscapeMeshProxyComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LandscapeMeshProxyComponent", Classes.FObjectProperty);
	}
}
