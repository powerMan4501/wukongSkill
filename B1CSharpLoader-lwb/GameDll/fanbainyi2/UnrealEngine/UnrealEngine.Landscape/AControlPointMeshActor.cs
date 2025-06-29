using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Landscape.ControlPointMeshActor", "Landscape", UnrealModuleType.Engine)]
public class AControlPointMeshActor : AActor
{
	private static bool ControlPointMeshComponent_IsValid;

	private static int ControlPointMeshComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Landscape.ControlPointMeshActor:ControlPointMeshComponent")]
	public UControlPointMeshComponent ControlPointMeshComponent
	{
		get
		{
			CheckDestroyed();
			if (!ControlPointMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.ControlPointMeshActor:ControlPointMeshComponent");
				return null;
			}
			return UObjectMarshaler<UControlPointMeshComponent>.FromNative(IntPtr.Add(base.Address, ControlPointMeshComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ControlPointMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.ControlPointMeshActor:ControlPointMeshComponent");
			}
			else
			{
				UObjectMarshaler<UControlPointMeshComponent>.ToNative(IntPtr.Add(base.Address, ControlPointMeshComponent_Offset), value);
			}
		}
	}

	static AControlPointMeshActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AControlPointMeshActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AControlPointMeshActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Landscape.ControlPointMeshActor");
		ControlPointMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ControlPointMeshComponent");
		ControlPointMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ControlPointMeshComponent", Classes.FObjectProperty);
	}
}
