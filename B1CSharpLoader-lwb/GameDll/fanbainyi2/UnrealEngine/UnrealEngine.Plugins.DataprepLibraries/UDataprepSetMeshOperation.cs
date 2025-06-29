using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.DataprepCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepLibraries.DataprepSetMeshOperation", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public class UDataprepSetMeshOperation : UDataprepOperation
{
	private static bool StaticMesh_IsValid;

	private static int StaticMesh_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSetMeshOperation:StaticMesh")]
	public UStaticMesh StaticMesh
	{
		get
		{
			CheckDestroyed();
			if (!StaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetMeshOperation:StaticMesh");
				return null;
			}
			return UObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(base.Address, StaticMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetMeshOperation:StaticMesh");
			}
			else
			{
				UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(base.Address, StaticMesh_Offset), value);
			}
		}
	}

	static UDataprepSetMeshOperation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepSetMeshOperation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepSetMeshOperation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DataprepLibraries.DataprepSetMeshOperation");
		StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StaticMesh");
		StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StaticMesh", Classes.FObjectProperty);
	}
}
