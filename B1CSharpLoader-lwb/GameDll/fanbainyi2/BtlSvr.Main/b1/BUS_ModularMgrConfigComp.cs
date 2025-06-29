using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ModularMgrConfigComp")]
public class BUS_ModularMgrConfigComp : UActorEditCompBase
{
	private static bool ModularFolderPath_IsValid;

	private static int ModularFolderPath_Offset;

	private static bool ModularActorTemplate_IsValid;

	private static int ModularActorTemplate_Offset;

	private static bool ContextTamerActor_IsValid;

	private static int ContextTamerActor_Offset;

	private static bool bAutoAttachModularActors_IsValid;

	private static int bAutoAttachModularActors_Offset;

	private static FFieldAddress bAutoAttachModularActors_PropertyAddress;

	private static bool bNeedsCopyPose_IsValid;

	private static int bNeedsCopyPose_Offset;

	private static FFieldAddress bNeedsCopyPose_PropertyAddress;

	private static bool ModularActorSpawnInnerRange_IsValid;

	private static int ModularActorSpawnInnerRange_Offset;

	private static bool ModularActorSpawnOuterRange_IsValid;

	private static int ModularActorSpawnOuterRange_Offset;

	private static bool bAutoSnapToGround_IsValid;

	private static int bAutoSnapToGround_Offset;

	private static FFieldAddress bAutoSnapToGround_PropertyAddress;

	private static bool bUseRandomLocationZ_IsValid;

	private static int bUseRandomLocationZ_Offset;

	private static FFieldAddress bUseRandomLocationZ_PropertyAddress;

	private static bool bUseRandomRotation_IsValid;

	private static int bUseRandomRotation_Offset;

	private static FFieldAddress bUseRandomRotation_PropertyAddress;

	private static bool bDestroyAfterOwnerDeath_IsValid;

	private static int bDestroyAfterOwnerDeath_Offset;

	private static FFieldAddress bDestroyAfterOwnerDeath_PropertyAddress;

	private static bool BreakDownProjectileMap_IsValid;

	private static int BreakDownProjectileMap_Offset;

	private static FFieldAddress BreakDownProjectileMap_PropertyAddress;

	private TMapReadWriteMarshaler<FName, int> BreakDownProjectileMap_Marshaler;

	[EditAnywhere]
	[Category("Modular Manager Config")]
	[Tooltip("模块化部件文件夹路径")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ModularMgrConfigComp:ModularFolderPath")]
	public string ModularFolderPath
	{
		get
		{
			CheckDestroyed();
			if (!ModularFolderPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:ModularFolderPath");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, ModularFolderPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ModularFolderPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:ModularFolderPath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, ModularFolderPath_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Modular Manager Config")]
	[Tooltip("模块化Actor模板")]
	[USharpPath("/Script/b1-Managed.BUS_ModularMgrConfigComp:ModularActorTemplate")]
	public TSubclassOf<AActor> ModularActorTemplate
	{
		get
		{
			CheckDestroyed();
			if (!ModularActorTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:ModularActorTemplate");
				return default(TSubclassOf<AActor>);
			}
			return TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, ModularActorTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ModularActorTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:ModularActorTemplate");
			}
			else
			{
				TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, ModularActorTemplate_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Modular Manager Config")]
	[Tooltip("用于模块化的Spawner")]
	[USharpPath("/Script/b1-Managed.BUS_ModularMgrConfigComp:ContextTamerActor")]
	public BUTamerActor ContextTamerActor
	{
		get
		{
			CheckDestroyed();
			if (!ContextTamerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:ContextTamerActor");
				return null;
			}
			return UObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(base.Address, ContextTamerActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ContextTamerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:ContextTamerActor");
			}
			else
			{
				UObjectMarshaler<BUTamerActor>.ToNative(IntPtr.Add(base.Address, ContextTamerActor_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Modular Manager Config")]
	[Tooltip("是否开启模块化部件自动吸附")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ModularMgrConfigComp:bAutoAttachModularActors")]
	public bool bAutoAttachModularActors
	{
		get
		{
			CheckDestroyed();
			if (!bAutoAttachModularActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:bAutoAttachModularActors");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAutoAttachModularActors_Offset), 0, bAutoAttachModularActors_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAutoAttachModularActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:bAutoAttachModularActors");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAutoAttachModularActors_Offset), 0, bAutoAttachModularActors_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Modular Manager Config")]
	[UProperty]
	[Tooltip("是否启用拷贝形态，仅当模块化部位为SkeletonMesh且有动画时再开启")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ModularMgrConfigComp:bNeedsCopyPose")]
	public bool bNeedsCopyPose
	{
		get
		{
			CheckDestroyed();
			if (!bNeedsCopyPose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:bNeedsCopyPose");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bNeedsCopyPose_Offset), 0, bNeedsCopyPose_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bNeedsCopyPose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:bNeedsCopyPose");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bNeedsCopyPose_Offset), 0, bNeedsCopyPose_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("模块化部件生成内圈范围")]
	[Category("Modular Actor Config")]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "!bAutoAttachModularActors")]
	[USharpPath("/Script/b1-Managed.BUS_ModularMgrConfigComp:ModularActorSpawnInnerRange")]
	public float ModularActorSpawnInnerRange
	{
		get
		{
			CheckDestroyed();
			if (!ModularActorSpawnInnerRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:ModularActorSpawnInnerRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ModularActorSpawnInnerRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ModularActorSpawnInnerRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:ModularActorSpawnInnerRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ModularActorSpawnInnerRange_Offset), value);
			}
		}
	}

	[Tooltip("模块化部件生成外圈范围")]
	[Category("Modular Actor Config")]
	[UMeta(MDProp.EditCondition, "!bAutoAttachModularActors")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ModularMgrConfigComp:ModularActorSpawnOuterRange")]
	public float ModularActorSpawnOuterRange
	{
		get
		{
			CheckDestroyed();
			if (!ModularActorSpawnOuterRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:ModularActorSpawnOuterRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ModularActorSpawnOuterRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ModularActorSpawnOuterRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:ModularActorSpawnOuterRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ModularActorSpawnOuterRange_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "!bAutoAttachModularActors")]
	[Category("Modular Actor Config")]
	[Tooltip("是否自动吸附地面，如勾选此项，bUseRandomLocationZ将无效")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ModularMgrConfigComp:bAutoSnapToGround")]
	public bool bAutoSnapToGround
	{
		get
		{
			CheckDestroyed();
			if (!bAutoSnapToGround_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:bAutoSnapToGround");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAutoSnapToGround_Offset), 0, bAutoSnapToGround_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAutoSnapToGround_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:bAutoSnapToGround");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAutoSnapToGround_Offset), 0, bAutoSnapToGround_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Modular Actor Config")]
	[UMeta(MDProp.EditCondition, "!bAutoAttachModularActors")]
	[EditAnywhere]
	[Tooltip("使用高于上下文Actor的随机Z值或上下文Actor的Z值")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ModularMgrConfigComp:bUseRandomLocationZ")]
	public bool bUseRandomLocationZ
	{
		get
		{
			CheckDestroyed();
			if (!bUseRandomLocationZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:bUseRandomLocationZ");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseRandomLocationZ_Offset), 0, bUseRandomLocationZ_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseRandomLocationZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:bUseRandomLocationZ");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseRandomLocationZ_Offset), 0, bUseRandomLocationZ_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "!bAutoAttachModularActors")]
	[Tooltip("使用随机旋转")]
	[Category("Modular Actor Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ModularMgrConfigComp:bUseRandomRotation")]
	public bool bUseRandomRotation
	{
		get
		{
			CheckDestroyed();
			if (!bUseRandomRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:bUseRandomRotation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseRandomRotation_Offset), 0, bUseRandomRotation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseRandomRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:bUseRandomRotation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseRandomRotation_Offset), 0, bUseRandomRotation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Tooltip("是否本体死亡后自动销毁")]
	[Category("Modular Actor Config")]
	[USharpPath("/Script/b1-Managed.BUS_ModularMgrConfigComp:bDestroyAfterOwnerDeath")]
	public bool bDestroyAfterOwnerDeath
	{
		get
		{
			CheckDestroyed();
			if (!bDestroyAfterOwnerDeath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:bDestroyAfterOwnerDeath");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDestroyAfterOwnerDeath_Offset), 0, bDestroyAfterOwnerDeath_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDestroyAfterOwnerDeath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:bDestroyAfterOwnerDeath");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDestroyAfterOwnerDeath_Offset), 0, bDestroyAfterOwnerDeath_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("散架后生成子弹映射列表，从Modular名字映射到ProjectileID")]
	[EditAnywhere]
	[Category("Modular Actor Config")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ModularMgrConfigComp:BreakDownProjectileMap")]
	public TMapReadWrite<FName, int> BreakDownProjectileMap
	{
		get
		{
			CheckDestroyed();
			if (!BreakDownProjectileMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ModularMgrConfigComp:BreakDownProjectileMap");
				return null;
			}
			if (BreakDownProjectileMap_Marshaler == null)
			{
				BreakDownProjectileMap_Marshaler = new TMapReadWriteMarshaler<FName, int>(1, BreakDownProjectileMap_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return BreakDownProjectileMap_Marshaler.FromNative(IntPtr.Add(base.Address, BreakDownProjectileMap_Offset));
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_ModularMgrData bUC_ModularMgrData = RequireWritableData<b1.BUC_ModularMgrData>();
		Dictionary<FName, int> dictionary = new Dictionary<FName, int>();
		foreach (KeyValuePair<FName, int> item in BreakDownProjectileMap)
		{
			dictionary.Add(item.Key, item.Value);
		}
		bUC_ModularMgrData.CopyBPDataToData(ContextTamerActor, bAutoAttachModularActors, bAutoSnapToGround, bDestroyAfterOwnerDeath, bNeedsCopyPose, dictionary);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_ModularMgrConfigComp");
		ModularFolderPath_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ModularFolderPath");
		ModularFolderPath_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ModularFolderPath", Classes.FStrProperty);
		ModularActorTemplate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ModularActorTemplate");
		ModularActorTemplate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ModularActorTemplate", Classes.FClassProperty);
		ContextTamerActor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ContextTamerActor");
		ContextTamerActor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ContextTamerActor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bAutoAttachModularActors_PropertyAddress, unrealStruct, "bAutoAttachModularActors");
		bAutoAttachModularActors_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bAutoAttachModularActors");
		bAutoAttachModularActors_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bAutoAttachModularActors", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bNeedsCopyPose_PropertyAddress, unrealStruct, "bNeedsCopyPose");
		bNeedsCopyPose_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bNeedsCopyPose");
		bNeedsCopyPose_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bNeedsCopyPose", Classes.FBoolProperty);
		ModularActorSpawnInnerRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ModularActorSpawnInnerRange");
		ModularActorSpawnInnerRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ModularActorSpawnInnerRange", Classes.FFloatProperty);
		ModularActorSpawnOuterRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ModularActorSpawnOuterRange");
		ModularActorSpawnOuterRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ModularActorSpawnOuterRange", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bAutoSnapToGround_PropertyAddress, unrealStruct, "bAutoSnapToGround");
		bAutoSnapToGround_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bAutoSnapToGround");
		bAutoSnapToGround_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bAutoSnapToGround", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseRandomLocationZ_PropertyAddress, unrealStruct, "bUseRandomLocationZ");
		bUseRandomLocationZ_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bUseRandomLocationZ");
		bUseRandomLocationZ_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bUseRandomLocationZ", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseRandomRotation_PropertyAddress, unrealStruct, "bUseRandomRotation");
		bUseRandomRotation_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bUseRandomRotation");
		bUseRandomRotation_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bUseRandomRotation", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDestroyAfterOwnerDeath_PropertyAddress, unrealStruct, "bDestroyAfterOwnerDeath");
		bDestroyAfterOwnerDeath_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bDestroyAfterOwnerDeath");
		bDestroyAfterOwnerDeath_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bDestroyAfterOwnerDeath", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BreakDownProjectileMap_PropertyAddress, unrealStruct, "BreakDownProjectileMap");
		BreakDownProjectileMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BreakDownProjectileMap");
		BreakDownProjectileMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BreakDownProjectileMap", Classes.FMapProperty);
	}

	static BUS_ModularMgrConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ModularMgrConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ModularMgrConfigComp));
	}
}
