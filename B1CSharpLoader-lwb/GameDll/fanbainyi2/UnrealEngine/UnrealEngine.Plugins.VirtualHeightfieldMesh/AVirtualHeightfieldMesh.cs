using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.VirtualHeightfieldMesh;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/VirtualHeightfieldMesh.VirtualHeightfieldMesh", "VirtualHeightfieldMesh", UnrealModuleType.EnginePlugin)]
public class AVirtualHeightfieldMesh : AActor
{
	private static bool VirtualHeightfieldMeshComponent_IsValid;

	private static int VirtualHeightfieldMeshComponent_Offset;

	[UProperty(Flags = (PropFlags)20266268117041693uL)]
	[UMetaPath("/Script/VirtualHeightfieldMesh.VirtualHeightfieldMesh:VirtualHeightfieldMeshComponent")]
	public UVirtualHeightfieldMeshComponent VirtualHeightfieldMeshComponent
	{
		get
		{
			CheckDestroyed();
			if (!VirtualHeightfieldMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VirtualHeightfieldMesh.VirtualHeightfieldMesh:VirtualHeightfieldMeshComponent");
				return null;
			}
			return UObjectMarshaler<UVirtualHeightfieldMeshComponent>.FromNative(IntPtr.Add(base.Address, VirtualHeightfieldMeshComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VirtualHeightfieldMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VirtualHeightfieldMesh.VirtualHeightfieldMesh:VirtualHeightfieldMeshComponent");
			}
			else
			{
				UObjectMarshaler<UVirtualHeightfieldMeshComponent>.ToNative(IntPtr.Add(base.Address, VirtualHeightfieldMeshComponent_Offset), value);
			}
		}
	}

	static AVirtualHeightfieldMesh()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AVirtualHeightfieldMesh)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AVirtualHeightfieldMesh));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/VirtualHeightfieldMesh.VirtualHeightfieldMesh");
		VirtualHeightfieldMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VirtualHeightfieldMeshComponent");
		VirtualHeightfieldMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VirtualHeightfieldMeshComponent", Classes.FObjectProperty);
	}
}
