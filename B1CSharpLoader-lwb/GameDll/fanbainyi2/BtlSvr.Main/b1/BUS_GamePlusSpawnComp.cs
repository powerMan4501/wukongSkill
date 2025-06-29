using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_GamePlusSpawnComp")]
public class BUS_GamePlusSpawnComp : UActorEditCompBase
{
	private static bool GamePlusSpawnConfigList_IsValid;

	private static int GamePlusSpawnConfigList_Offset;

	private static FFieldAddress GamePlusSpawnConfigList_PropertyAddress;

	private TArrayReadWriteMarshaler<FGamePlusSpawnConfig> GamePlusSpawnConfigList_Marshaler;

	private static bool TaskStageId_IsValid;

	private static int TaskStageId_Offset;

	private static bool TaskStageStage_IsValid;

	private static int TaskStageStage_Offset;

	private static FFieldAddress TaskStageStage_PropertyAddress;

	private static bool CollectionCountMax_IsValid;

	private static int CollectionCountMax_Offset;

	[UProperty]
	[DisplayName("周目刷新配置")]
	[Category("GamePlusSpawnConfig")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_GamePlusSpawnComp:GamePlusSpawnConfigList")]
	public TArrayReadWrite<FGamePlusSpawnConfig> GamePlusSpawnConfigList
	{
		get
		{
			CheckDestroyed();
			if (!GamePlusSpawnConfigList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GamePlusSpawnComp:GamePlusSpawnConfigList");
				return null;
			}
			if (GamePlusSpawnConfigList_Marshaler == null)
			{
				GamePlusSpawnConfigList_Marshaler = new TArrayReadWriteMarshaler<FGamePlusSpawnConfig>(1, GamePlusSpawnConfigList_PropertyAddress, CachedMarshalingDelegates<FGamePlusSpawnConfig, FGamePlusSpawnConfig>.FromNative, CachedMarshalingDelegates<FGamePlusSpawnConfig, FGamePlusSpawnConfig>.ToNative);
			}
			return GamePlusSpawnConfigList_Marshaler.FromNative(IntPtr.Add(base.Address, GamePlusSpawnConfigList_Offset));
		}
	}

	[Category("GamePlusSpawnConfig")]
	[DisplayName("前置任务Id")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_GamePlusSpawnComp:TaskStageId")]
	public int TaskStageId
	{
		get
		{
			CheckDestroyed();
			if (!TaskStageId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GamePlusSpawnComp:TaskStageId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TaskStageId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TaskStageId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GamePlusSpawnComp:TaskStageId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TaskStageId_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("任务状态")]
	[Category("GamePlusSpawnConfig")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_GamePlusSpawnComp:TaskStageStage")]
	public ETaskCollectionState TaskStageStage
	{
		get
		{
			CheckDestroyed();
			if (!TaskStageStage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GamePlusSpawnComp:TaskStageStage");
				return ETaskCollectionState.Default;
			}
			return EnumMarshaler<ETaskCollectionState>.FromNative(IntPtr.Add(base.Address, TaskStageStage_Offset), 0, TaskStageStage_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TaskStageStage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GamePlusSpawnComp:TaskStageStage");
			}
			else
			{
				EnumMarshaler<ETaskCollectionState>.ToNative(IntPtr.Add(base.Address, TaskStageStage_Offset), 0, TaskStageStage_PropertyAddress.Address, value);
			}
		}
	}

	[Category("GamePlusSpawnConfig")]
	[DisplayName("可采集最大次数")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_GamePlusSpawnComp:CollectionCountMax")]
	public int CollectionCountMax
	{
		get
		{
			CheckDestroyed();
			if (!CollectionCountMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GamePlusSpawnComp:CollectionCountMax");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CollectionCountMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollectionCountMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GamePlusSpawnComp:CollectionCountMax");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CollectionCountMax_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_GamePlusSpawnData bUC_GamePlusSpawnData = RequireWritableData<BUC_GamePlusSpawnData>();
		bUC_GamePlusSpawnData.GamePlusSpawnConfigList = new List<GamePlusSpawnConfig>();
		foreach (FGamePlusSpawnConfig gamePlusSpawnConfig in GamePlusSpawnConfigList)
		{
			GamePlusSpawnConfig item = BGU_CollectionActorUtil.InitGamePlusSpawnConfig(gamePlusSpawnConfig);
			bUC_GamePlusSpawnData.GamePlusSpawnConfigList.Add(item);
		}
		bUC_GamePlusSpawnData.TaskStageId = TaskStageId;
		bUC_GamePlusSpawnData.TaskStageStage = (int)TaskStageStage;
		bUC_GamePlusSpawnData.CollectionCountMax = CollectionCountMax;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_GamePlusSpawnComp");
		NativeReflection.GetPropertyRef(ref GamePlusSpawnConfigList_PropertyAddress, unrealStruct, "GamePlusSpawnConfigList");
		GamePlusSpawnConfigList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GamePlusSpawnConfigList");
		GamePlusSpawnConfigList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GamePlusSpawnConfigList", Classes.FArrayProperty);
		TaskStageId_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TaskStageId");
		TaskStageId_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TaskStageId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref TaskStageStage_PropertyAddress, unrealStruct, "TaskStageStage");
		TaskStageStage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TaskStageStage");
		TaskStageStage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TaskStageStage", Classes.FEnumProperty);
		CollectionCountMax_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CollectionCountMax");
		CollectionCountMax_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CollectionCountMax", Classes.FIntProperty);
	}

	static BUS_GamePlusSpawnComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_GamePlusSpawnComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_GamePlusSpawnComp));
	}
}
