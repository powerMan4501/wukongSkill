using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp")]
public class BUS_TaskStageCollectionConfigComp : UActorEditCompBase
{
	private static bool CD_IsValid;

	private static int CD_Offset;

	private static bool FinishCD_IsValid;

	private static int FinishCD_Offset;

	private static bool TaskStageId_IsValid;

	private static int TaskStageId_Offset;

	private static bool TaskStageStage_IsValid;

	private static int TaskStageStage_Offset;

	private static FFieldAddress TaskStageStage_PropertyAddress;

	private static bool CanDestoryTaskFinish_IsValid;

	private static int CanDestoryTaskFinish_Offset;

	private static FFieldAddress CanDestoryTaskFinish_PropertyAddress;

	private static bool DropID_IsValid;

	private static int DropID_Offset;

	private static bool CollectionDropTemplete_IsValid;

	private static int CollectionDropTemplete_Offset;

	private static bool CollectionDropTemplete_TaskFinish_IsValid;

	private static int CollectionDropTemplete_TaskFinish_Offset;

	private static bool CollectionFXSpawnCompTag_IsValid;

	private static int CollectionFXSpawnCompTag_Offset;

	private static bool DestoryDelayTime_IsValid;

	private static int DestoryDelayTime_Offset;

	private static bool CacheDBC_IsValid;

	private static int CacheDBC_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Config")]
	[DisplayName("初始CD")]
	[USharpPath("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:CD")]
	public int CD
	{
		get
		{
			CheckDestroyed();
			if (!CD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:CD");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:CD");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CD_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Config")]
	[DisplayName("任务达成后CD")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:FinishCD")]
	public int FinishCD
	{
		get
		{
			CheckDestroyed();
			if (!FinishCD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:FinishCD");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, FinishCD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FinishCD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:FinishCD");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, FinishCD_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Config")]
	[DisplayName("任务id")]
	[USharpPath("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:TaskStageId")]
	public int TaskStageId
	{
		get
		{
			CheckDestroyed();
			if (!TaskStageId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:TaskStageId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TaskStageId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TaskStageId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:TaskStageId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TaskStageId_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Config")]
	[EditAnywhere]
	[DisplayName("任务状态")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:TaskStageStage")]
	public ETaskCollectionState TaskStageStage
	{
		get
		{
			CheckDestroyed();
			if (!TaskStageStage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:TaskStageStage");
				return ETaskCollectionState.Default;
			}
			return EnumMarshaler<ETaskCollectionState>.FromNative(IntPtr.Add(base.Address, TaskStageStage_Offset), 0, TaskStageStage_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TaskStageStage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:TaskStageStage");
			}
			else
			{
				EnumMarshaler<ETaskCollectionState>.ToNative(IntPtr.Add(base.Address, TaskStageStage_Offset), 0, TaskStageStage_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("完成任务后再采集消失")]
	[Category("Config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:CanDestoryTaskFinish")]
	public bool CanDestoryTaskFinish
	{
		get
		{
			CheckDestroyed();
			if (!CanDestoryTaskFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:CanDestoryTaskFinish");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanDestoryTaskFinish_Offset), 0, CanDestoryTaskFinish_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanDestoryTaskFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:CanDestoryTaskFinish");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanDestoryTaskFinish_Offset), 0, CanDestoryTaskFinish_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("掉落ID")]
	[Category("Config")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:DropID")]
	public int DropID
	{
		get
		{
			CheckDestroyed();
			if (!DropID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:DropID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DropID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:DropID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DropID_Offset), value);
			}
		}
	}

	[DisplayName("采集掉落模板")]
	[Category("Config")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:CollectionDropTemplete")]
	public UBGWDropItemTemplete CollectionDropTemplete
	{
		get
		{
			CheckDestroyed();
			if (!CollectionDropTemplete_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:CollectionDropTemplete");
				return null;
			}
			return UObjectMarshaler<UBGWDropItemTemplete>.FromNative(IntPtr.Add(base.Address, CollectionDropTemplete_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollectionDropTemplete_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:CollectionDropTemplete");
			}
			else
			{
				UObjectMarshaler<UBGWDropItemTemplete>.ToNative(IntPtr.Add(base.Address, CollectionDropTemplete_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Config")]
	[DisplayName("完成任务时采集掉落模板")]
	[USharpPath("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:CollectionDropTemplete_TaskFinish")]
	public UBGWDropItemTemplete CollectionDropTemplete_TaskFinish
	{
		get
		{
			CheckDestroyed();
			if (!CollectionDropTemplete_TaskFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:CollectionDropTemplete_TaskFinish");
				return null;
			}
			return UObjectMarshaler<UBGWDropItemTemplete>.FromNative(IntPtr.Add(base.Address, CollectionDropTemplete_TaskFinish_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollectionDropTemplete_TaskFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:CollectionDropTemplete_TaskFinish");
			}
			else
			{
				UObjectMarshaler<UBGWDropItemTemplete>.ToNative(IntPtr.Add(base.Address, CollectionDropTemplete_TaskFinish_Offset), value);
			}
		}
	}

	[DisplayName("采集特效挂点Tag")]
	[Category("Config")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:CollectionFXSpawnCompTag")]
	public FName CollectionFXSpawnCompTag
	{
		get
		{
			CheckDestroyed();
			if (!CollectionFXSpawnCompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:CollectionFXSpawnCompTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CollectionFXSpawnCompTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollectionFXSpawnCompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:CollectionFXSpawnCompTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CollectionFXSpawnCompTag_Offset), value);
			}
		}
	}

	[Category("Config")]
	[DisplayName("延迟销毁时间")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:DestoryDelayTime")]
	public float DestoryDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!DestoryDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:DestoryDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DestoryDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestoryDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:DestoryDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DestoryDelayTime_Offset), value);
			}
		}
	}

	[Category("Config")]
	[DisplayName("销毁时播放DBC")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:CacheDBC")]
	public BGWDataAsset_B1DBC CacheDBC
	{
		get
		{
			CheckDestroyed();
			if (!CacheDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:CacheDBC");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_B1DBC>.FromNative(IntPtr.Add(base.Address, CacheDBC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CacheDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp:CacheDBC");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_B1DBC>.ToNative(IntPtr.Add(base.Address, CacheDBC_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_TaskCollectionData bUC_TaskCollectionData = RequireWritableData<BUC_TaskCollectionData>();
		if (bUC_TaskCollectionData != null)
		{
			bUC_TaskCollectionData.CD = CD;
			bUC_TaskCollectionData.FinishCD = FinishCD;
			bUC_TaskCollectionData.TaskStageId = TaskStageId;
			bUC_TaskCollectionData.TaskStageStage = (int)TaskStageStage;
			bUC_TaskCollectionData.CanDestoryTaskFinish = CanDestoryTaskFinish;
			bUC_TaskCollectionData.DropID = DropID;
			bUC_TaskCollectionData.CollectionDropTemplete = CollectionDropTemplete;
			bUC_TaskCollectionData.CollectionDropTemplete_TaskFinish = CollectionDropTemplete_TaskFinish;
			bUC_TaskCollectionData.CollectionFXSpawnCompTag = CollectionFXSpawnCompTag;
			bUC_TaskCollectionData.DestoryDelayTime = DestoryDelayTime;
			bUC_TaskCollectionData.CacheDBC = CacheDBC;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_TaskStageCollectionConfigComp");
		CD_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CD");
		CD_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CD", Classes.FIntProperty);
		FinishCD_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FinishCD");
		FinishCD_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FinishCD", Classes.FIntProperty);
		TaskStageId_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TaskStageId");
		TaskStageId_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TaskStageId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref TaskStageStage_PropertyAddress, unrealStruct, "TaskStageStage");
		TaskStageStage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TaskStageStage");
		TaskStageStage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TaskStageStage", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CanDestoryTaskFinish_PropertyAddress, unrealStruct, "CanDestoryTaskFinish");
		CanDestoryTaskFinish_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CanDestoryTaskFinish");
		CanDestoryTaskFinish_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CanDestoryTaskFinish", Classes.FBoolProperty);
		DropID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropID");
		DropID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropID", Classes.FIntProperty);
		CollectionDropTemplete_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CollectionDropTemplete");
		CollectionDropTemplete_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CollectionDropTemplete", Classes.FObjectProperty);
		CollectionDropTemplete_TaskFinish_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CollectionDropTemplete_TaskFinish");
		CollectionDropTemplete_TaskFinish_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CollectionDropTemplete_TaskFinish", Classes.FObjectProperty);
		CollectionFXSpawnCompTag_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CollectionFXSpawnCompTag");
		CollectionFXSpawnCompTag_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CollectionFXSpawnCompTag", Classes.FNameProperty);
		DestoryDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DestoryDelayTime");
		DestoryDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DestoryDelayTime", Classes.FFloatProperty);
		CacheDBC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CacheDBC");
		CacheDBC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CacheDBC", Classes.FObjectProperty);
	}

	static BUS_TaskStageCollectionConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_TaskStageCollectionConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_TaskStageCollectionConfigComp));
	}
}
