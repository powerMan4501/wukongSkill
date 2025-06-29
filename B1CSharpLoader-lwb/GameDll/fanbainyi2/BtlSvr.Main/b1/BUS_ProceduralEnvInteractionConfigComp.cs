using System;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ProceduralEnvInteractionConfigComp")]
public class BUS_ProceduralEnvInteractionConfigComp : UActorEditCompBase
{
	private static bool bEnableDecal_IsValid;

	private static int bEnableDecal_Offset;

	private static FFieldAddress bEnableDecal_PropertyAddress;

	private static bool bEnableMesh_IsValid;

	private static int bEnableMesh_Offset;

	private static FFieldAddress bEnableMesh_PropertyAddress;

	private static bool WorldSize_IsValid;

	private static int WorldSize_Offset;

	private static bool SceneItemSurfaceType_IsValid;

	private static int SceneItemSurfaceType_Offset;

	private static FFieldAddress SceneItemSurfaceType_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ProceduralEnvInteractionConfigComp:bEnableDecal")]
	public bool bEnableDecal
	{
		get
		{
			CheckDestroyed();
			if (!bEnableDecal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProceduralEnvInteractionConfigComp:bEnableDecal");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableDecal_Offset), 0, bEnableDecal_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableDecal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProceduralEnvInteractionConfigComp:bEnableDecal");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableDecal_Offset), 0, bEnableDecal_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ProceduralEnvInteractionConfigComp:bEnableMesh")]
	public bool bEnableMesh
	{
		get
		{
			CheckDestroyed();
			if (!bEnableMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProceduralEnvInteractionConfigComp:bEnableMesh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableMesh_Offset), 0, bEnableMesh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProceduralEnvInteractionConfigComp:bEnableMesh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableMesh_Offset), 0, bEnableMesh_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("贴花大小")]
	[UMeta(MDProp.EditCondition, "bEnableDecal")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProceduralEnvInteractionConfigComp:WorldSize")]
	public FVector2D WorldSize
	{
		get
		{
			CheckDestroyed();
			if (!WorldSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProceduralEnvInteractionConfigComp:WorldSize");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, WorldSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WorldSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProceduralEnvInteractionConfigComp:WorldSize");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, WorldSize_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ProceduralEnvInteractionConfigComp:SceneItemSurfaceType")]
	public ESceneItemSurfaceType SceneItemSurfaceType
	{
		get
		{
			CheckDestroyed();
			if (!SceneItemSurfaceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProceduralEnvInteractionConfigComp:SceneItemSurfaceType");
				return ESceneItemSurfaceType.DefaultSurface;
			}
			return EnumMarshaler<ESceneItemSurfaceType>.FromNative(IntPtr.Add(base.Address, SceneItemSurfaceType_Offset), 0, SceneItemSurfaceType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SceneItemSurfaceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProceduralEnvInteractionConfigComp:SceneItemSurfaceType");
			}
			else
			{
				EnumMarshaler<ESceneItemSurfaceType>.ToNative(IntPtr.Add(base.Address, SceneItemSurfaceType_Offset), 0, SceneItemSurfaceType_PropertyAddress.Address, value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_ProceduralEnvInteractionData bUC_ProceduralEnvInteractionData = RequireWritableData<b1.BUC_ProceduralEnvInteractionData>();
		bUC_ProceduralEnvInteractionData.bEnableDecal = bEnableDecal;
		bUC_ProceduralEnvInteractionData.bEnableMesh = bEnableMesh;
		bUC_ProceduralEnvInteractionData.WorldSize = WorldSize;
		bUC_ProceduralEnvInteractionData.DefaultSceneItemSurfaceType = SceneItemSurfaceType;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_ProceduralEnvInteractionConfigComp");
		NativeReflection.GetPropertyRef(ref bEnableDecal_PropertyAddress, unrealStruct, "bEnableDecal");
		bEnableDecal_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableDecal");
		bEnableDecal_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableDecal", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableMesh_PropertyAddress, unrealStruct, "bEnableMesh");
		bEnableMesh_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableMesh");
		bEnableMesh_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableMesh", Classes.FBoolProperty);
		WorldSize_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WorldSize");
		WorldSize_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WorldSize", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SceneItemSurfaceType_PropertyAddress, unrealStruct, "SceneItemSurfaceType");
		SceneItemSurfaceType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SceneItemSurfaceType");
		SceneItemSurfaceType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SceneItemSurfaceType", Classes.FEnumProperty);
	}

	static BUS_ProceduralEnvInteractionConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ProceduralEnvInteractionConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ProceduralEnvInteractionConfigComp));
	}
}
