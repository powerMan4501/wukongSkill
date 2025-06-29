using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.TressFX;

[UClass(Flags = (ClassFlags)810549408uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/TressFX.TressFXMeshImportOptions", "TressFX", UnrealModuleType.GamePlugin)]
public class UTressFXMeshImportOptions : UObject
{
	private static bool Skeleton_IsValid;

	private static int Skeleton_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXMeshImportOptions:Skeleton")]
	public USkeletalMesh Skeleton
	{
		get
		{
			CheckDestroyed();
			if (!Skeleton_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXMeshImportOptions:Skeleton");
				return null;
			}
			return UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(base.Address, Skeleton_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Skeleton_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXMeshImportOptions:Skeleton");
			}
			else
			{
				UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(base.Address, Skeleton_Offset), value);
			}
		}
	}

	static UTressFXMeshImportOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTressFXMeshImportOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTressFXMeshImportOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/TressFX.TressFXMeshImportOptions");
		Skeleton_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Skeleton");
		Skeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Skeleton", Classes.FObjectProperty);
	}
}
