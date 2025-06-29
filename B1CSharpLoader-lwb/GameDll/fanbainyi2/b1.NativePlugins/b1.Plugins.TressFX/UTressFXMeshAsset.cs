using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.TressFX;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/TressFX.TressFXMeshAsset", "TressFX", UnrealModuleType.GamePlugin)]
public class UTressFXMeshAsset : UObject, IInterface_AssetUserData, IInterface
{
	private static bool CollisionMeshBoxMargin_IsValid;

	private static int CollisionMeshBoxMargin_Offset;

	private static bool NumGridOffset_IsValid;

	private static int NumGridOffset_Offset;

	private static bool SDFCollisionMargin_IsValid;

	private static int SDFCollisionMargin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXMeshAsset:CollisionMeshBoxMargin")]
	public float CollisionMeshBoxMargin
	{
		get
		{
			CheckDestroyed();
			if (!CollisionMeshBoxMargin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXMeshAsset:CollisionMeshBoxMargin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CollisionMeshBoxMargin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollisionMeshBoxMargin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXMeshAsset:CollisionMeshBoxMargin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CollisionMeshBoxMargin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXMeshAsset:NumGridOffset")]
	public int NumGridOffset
	{
		get
		{
			CheckDestroyed();
			if (!NumGridOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXMeshAsset:NumGridOffset");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumGridOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumGridOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXMeshAsset:NumGridOffset");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumGridOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXMeshAsset:SDFCollisionMargin")]
	public float SDFCollisionMargin
	{
		get
		{
			CheckDestroyed();
			if (!SDFCollisionMargin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXMeshAsset:SDFCollisionMargin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SDFCollisionMargin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SDFCollisionMargin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXMeshAsset:SDFCollisionMargin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SDFCollisionMargin_Offset), value);
			}
		}
	}

	static UTressFXMeshAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTressFXMeshAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTressFXMeshAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/TressFX.TressFXMeshAsset");
		CollisionMeshBoxMargin_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CollisionMeshBoxMargin");
		CollisionMeshBoxMargin_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CollisionMeshBoxMargin", Classes.FFloatProperty);
		NumGridOffset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NumGridOffset");
		NumGridOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NumGridOffset", Classes.FIntProperty);
		SDFCollisionMargin_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SDFCollisionMargin");
		SDFCollisionMargin_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SDFCollisionMargin", Classes.FFloatProperty);
	}
}
