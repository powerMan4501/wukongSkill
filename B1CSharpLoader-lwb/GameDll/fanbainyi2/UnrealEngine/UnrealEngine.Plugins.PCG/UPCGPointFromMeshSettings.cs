using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGPointFromMeshSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGPointFromMeshSettings : UPCGSettings
{
	private static bool StaticMesh_IsValid;

	private static int StaticMesh_Offset;

	private static bool MeshPathAttributeName_IsValid;

	private static int MeshPathAttributeName_Offset;

	[UProperty(Flags = (PropFlags)7881299347898373uL)]
	[UMetaPath("/Script/PCG.PCGPointFromMeshSettings:StaticMesh")]
	public TSoftObject<UStaticMesh> StaticMesh
	{
		get
		{
			CheckDestroyed();
			if (!StaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFromMeshSettings:StaticMesh");
				return default(TSoftObject<UStaticMesh>);
			}
			return TSoftObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(base.Address, StaticMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFromMeshSettings:StaticMesh");
			}
			else
			{
				TSoftObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(base.Address, StaticMesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPointFromMeshSettings:MeshPathAttributeName")]
	public FName MeshPathAttributeName
	{
		get
		{
			CheckDestroyed();
			if (!MeshPathAttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFromMeshSettings:MeshPathAttributeName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, MeshPathAttributeName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MeshPathAttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFromMeshSettings:MeshPathAttributeName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, MeshPathAttributeName_Offset), value);
			}
		}
	}

	static UPCGPointFromMeshSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGPointFromMeshSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGPointFromMeshSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGPointFromMeshSettings");
		StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StaticMesh");
		StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StaticMesh", Classes.FSoftObjectProperty);
		MeshPathAttributeName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MeshPathAttributeName");
		MeshPathAttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MeshPathAttributeName", Classes.FNameProperty);
	}
}
