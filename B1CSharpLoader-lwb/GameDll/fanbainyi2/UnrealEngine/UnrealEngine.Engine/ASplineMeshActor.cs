using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.SplineMeshActor", "Engine", UnrealModuleType.Engine)]
public class ASplineMeshActor : AActor
{
	private static bool SplineMeshComponent_IsValid;

	private static int SplineMeshComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.SplineMeshActor:SplineMeshComponent")]
	public USplineMeshComponent SplineMeshComponent
	{
		get
		{
			CheckDestroyed();
			if (!SplineMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SplineMeshActor:SplineMeshComponent");
				return null;
			}
			return UObjectMarshaler<USplineMeshComponent>.FromNative(IntPtr.Add(base.Address, SplineMeshComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SplineMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SplineMeshActor:SplineMeshComponent");
			}
			else
			{
				UObjectMarshaler<USplineMeshComponent>.ToNative(IntPtr.Add(base.Address, SplineMeshComponent_Offset), value);
			}
		}
	}

	static ASplineMeshActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ASplineMeshActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ASplineMeshActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.SplineMeshActor");
		SplineMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SplineMeshComponent");
		SplineMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SplineMeshComponent", Classes.FObjectProperty);
	}
}
