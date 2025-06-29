using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.FbxSceneImportFactory", "UnrealEd", UnrealModuleType.Engine)]
public class UFbxSceneImportFactory : USceneImportFactory
{
	private static bool SceneImportOptions_IsValid;

	private static int SceneImportOptions_Offset;

	private static bool SceneImportOptionsStaticMesh_IsValid;

	private static int SceneImportOptionsStaticMesh_Offset;

	private static bool SceneImportOptionsSkeletalMesh_IsValid;

	private static int SceneImportOptionsSkeletalMesh_Offset;

	[UProperty(Flags = (PropFlags)7881369141125636uL)]
	[UMetaPath("/Script/UnrealEd.FbxSceneImportFactory:SceneImportOptions")]
	public UFbxSceneImportOptions SceneImportOptions
	{
		get
		{
			CheckDestroyed();
			if (!SceneImportOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxSceneImportFactory:SceneImportOptions");
				return null;
			}
			return UObjectMarshaler<UFbxSceneImportOptions>.FromNative(IntPtr.Add(base.Address, SceneImportOptions_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneImportOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxSceneImportFactory:SceneImportOptions");
			}
			else
			{
				UObjectMarshaler<UFbxSceneImportOptions>.ToNative(IntPtr.Add(base.Address, SceneImportOptions_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141125636uL)]
	[UMetaPath("/Script/UnrealEd.FbxSceneImportFactory:SceneImportOptionsStaticMesh")]
	public UFbxSceneImportOptionsStaticMesh SceneImportOptionsStaticMesh
	{
		get
		{
			CheckDestroyed();
			if (!SceneImportOptionsStaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxSceneImportFactory:SceneImportOptionsStaticMesh");
				return null;
			}
			return UObjectMarshaler<UFbxSceneImportOptionsStaticMesh>.FromNative(IntPtr.Add(base.Address, SceneImportOptionsStaticMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneImportOptionsStaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxSceneImportFactory:SceneImportOptionsStaticMesh");
			}
			else
			{
				UObjectMarshaler<UFbxSceneImportOptionsStaticMesh>.ToNative(IntPtr.Add(base.Address, SceneImportOptionsStaticMesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141125636uL)]
	[UMetaPath("/Script/UnrealEd.FbxSceneImportFactory:SceneImportOptionsSkeletalMesh")]
	public UFbxSceneImportOptionsSkeletalMesh SceneImportOptionsSkeletalMesh
	{
		get
		{
			CheckDestroyed();
			if (!SceneImportOptionsSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxSceneImportFactory:SceneImportOptionsSkeletalMesh");
				return null;
			}
			return UObjectMarshaler<UFbxSceneImportOptionsSkeletalMesh>.FromNative(IntPtr.Add(base.Address, SceneImportOptionsSkeletalMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneImportOptionsSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxSceneImportFactory:SceneImportOptionsSkeletalMesh");
			}
			else
			{
				UObjectMarshaler<UFbxSceneImportOptionsSkeletalMesh>.ToNative(IntPtr.Add(base.Address, SceneImportOptionsSkeletalMesh_Offset), value);
			}
		}
	}

	static UFbxSceneImportFactory()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFbxSceneImportFactory)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFbxSceneImportFactory));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealEd.FbxSceneImportFactory");
		SceneImportOptions_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SceneImportOptions");
		SceneImportOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SceneImportOptions", Classes.FObjectProperty);
		SceneImportOptionsStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SceneImportOptionsStaticMesh");
		SceneImportOptionsStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SceneImportOptionsStaticMesh", Classes.FObjectProperty);
		SceneImportOptionsSkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SceneImportOptionsSkeletalMesh");
		SceneImportOptionsSkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SceneImportOptionsSkeletalMesh", Classes.FObjectProperty);
	}
}
