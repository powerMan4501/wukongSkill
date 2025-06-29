using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.TressFX;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/TressFX.TressFXBindingAsset", "TressFX", UnrealModuleType.GamePlugin)]
public class UTressFXBindingAsset : UObject
{
	private static bool TressFXAsset_IsValid;

	private static int TressFXAsset_Offset;

	private static bool TargetSkeletalMesh_IsValid;

	private static int TargetSkeletalMesh_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/TressFX.TressFXBindingAsset:TressFXAsset")]
	public UTressFXAsset TressFXAsset
	{
		get
		{
			CheckDestroyed();
			if (!TressFXAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXBindingAsset:TressFXAsset");
				return null;
			}
			return UObjectMarshaler<UTressFXAsset>.FromNative(IntPtr.Add(base.Address, TressFXAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TressFXAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXBindingAsset:TressFXAsset");
			}
			else
			{
				UObjectMarshaler<UTressFXAsset>.ToNative(IntPtr.Add(base.Address, TressFXAsset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/TressFX.TressFXBindingAsset:TargetSkeletalMesh")]
	public USkeletalMesh TargetSkeletalMesh
	{
		get
		{
			CheckDestroyed();
			if (!TargetSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXBindingAsset:TargetSkeletalMesh");
				return null;
			}
			return UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(base.Address, TargetSkeletalMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXBindingAsset:TargetSkeletalMesh");
			}
			else
			{
				UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(base.Address, TargetSkeletalMesh_Offset), value);
			}
		}
	}

	static UTressFXBindingAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTressFXBindingAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTressFXBindingAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/TressFX.TressFXBindingAsset");
		TressFXAsset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TressFXAsset");
		TressFXAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TressFXAsset", Classes.FObjectProperty);
		TargetSkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TargetSkeletalMesh");
		TargetSkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TargetSkeletalMesh", Classes.FObjectProperty);
	}
}
