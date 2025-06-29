using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp")]
internal class BUS_DroppedItemManagerConfigComp : UActorEditCompBase
{
	private static bool DropItemID_IsValid;

	private static int DropItemID_Offset;

	private static bool DropTransform_IsValid;

	private static int DropTransform_Offset;

	private static bool SpawnDelayTime_IsValid;

	private static int SpawnDelayTime_Offset;

	private static bool PointRecorder_IsValid;

	private static int PointRecorder_Offset;

	private static bool DropUnit_IsValid;

	private static int DropUnit_Offset;

	private static bool DropSocket_IsValid;

	private static int DropSocket_Offset;

	private static bool bUseSocketRotation_IsValid;

	private static int bUseSocketRotation_Offset;

	private static FFieldAddress bUseSocketRotation_PropertyAddress;

	private static bool bUseSocketRotationAxisX_IsValid;

	private static int bUseSocketRotationAxisX_Offset;

	private static FFieldAddress bUseSocketRotationAxisX_PropertyAddress;

	private static bool bUseSocketRotationAxisY_IsValid;

	private static int bUseSocketRotationAxisY_Offset;

	private static FFieldAddress bUseSocketRotationAxisY_PropertyAddress;

	private static bool bUseSocketRotationAxisZ_IsValid;

	private static int bUseSocketRotationAxisZ_Offset;

	private static FFieldAddress bUseSocketRotationAxisZ_PropertyAddress;

	private static bool DropOffset_IsValid;

	private static int DropOffset_Offset;

	[Category("掉落物配置")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("掉落物ID")]
	[USharpPath("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:DropItemID")]
	public int DropItemID
	{
		get
		{
			CheckDestroyed();
			if (!DropItemID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:DropItemID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DropItemID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropItemID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:DropItemID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DropItemID_Offset), value);
			}
		}
	}

	[Category("掉落物配置")]
	[EditAnywhere]
	[DisplayName("掉落物默认位置")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:DropTransform")]
	public FTransform DropTransform
	{
		get
		{
			CheckDestroyed();
			if (!DropTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:DropTransform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, DropTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:DropTransform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, DropTransform_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("掉落物配置")]
	[DisplayName("掉落物生成延迟(ms)")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:SpawnDelayTime")]
	public float SpawnDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!SpawnDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:SpawnDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpawnDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:SpawnDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpawnDelayTime_Offset), value);
			}
		}
	}

	[Category("掉落物位置种点配置")]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("掉落可能位置点集")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:PointRecorder")]
	public TSoftObject<BGU_EQSPointRecorderActor> PointRecorder
	{
		get
		{
			CheckDestroyed();
			if (!PointRecorder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:PointRecorder");
				return default(TSoftObject<BGU_EQSPointRecorderActor>);
			}
			return TSoftObjectMarshaler<BGU_EQSPointRecorderActor>.FromNative(IntPtr.Add(base.Address, PointRecorder_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointRecorder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:PointRecorder");
			}
			else
			{
				TSoftObjectMarshaler<BGU_EQSPointRecorderActor>.ToNative(IntPtr.Add(base.Address, PointRecorder_Offset), value);
			}
		}
	}

	[Category("掉落物位置种点配置")]
	[DisplayName("掉落者")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:DropUnit")]
	public FGsActorGuidReference DropUnit
	{
		get
		{
			CheckDestroyed();
			if (!DropUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:DropUnit");
				return default(FGsActorGuidReference);
			}
			return FGsActorGuidReference.FromNative(IntPtr.Add(base.Address, DropUnit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:DropUnit");
			}
			else
			{
				FGsActorGuidReference.ToNative(IntPtr.Add(base.Address, DropUnit_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("掉落物位置种点配置")]
	[DisplayName("掉落Socket")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:DropSocket")]
	public FName DropSocket
	{
		get
		{
			CheckDestroyed();
			if (!DropSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:DropSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DropSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:DropSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DropSocket_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("掉落物位置种点配置")]
	[DisplayName("使用SocketRotation")]
	[USharpPath("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:bUseSocketRotation")]
	public bool bUseSocketRotation
	{
		get
		{
			CheckDestroyed();
			if (!bUseSocketRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:bUseSocketRotation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseSocketRotation_Offset), 0, bUseSocketRotation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseSocketRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:bUseSocketRotation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseSocketRotation_Offset), 0, bUseSocketRotation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("使用X轴Rotation")]
	[Category("掉落物位置种点配置")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:bUseSocketRotationAxisX")]
	public bool bUseSocketRotationAxisX
	{
		get
		{
			CheckDestroyed();
			if (!bUseSocketRotationAxisX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:bUseSocketRotationAxisX");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseSocketRotationAxisX_Offset), 0, bUseSocketRotationAxisX_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseSocketRotationAxisX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:bUseSocketRotationAxisX");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseSocketRotationAxisX_Offset), 0, bUseSocketRotationAxisX_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("掉落物位置种点配置")]
	[DisplayName("使用Y轴Rotation")]
	[USharpPath("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:bUseSocketRotationAxisY")]
	public bool bUseSocketRotationAxisY
	{
		get
		{
			CheckDestroyed();
			if (!bUseSocketRotationAxisY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:bUseSocketRotationAxisY");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseSocketRotationAxisY_Offset), 0, bUseSocketRotationAxisY_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseSocketRotationAxisY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:bUseSocketRotationAxisY");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseSocketRotationAxisY_Offset), 0, bUseSocketRotationAxisY_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("使用Z轴Rotation")]
	[UProperty]
	[Category("掉落物位置种点配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:bUseSocketRotationAxisZ")]
	public bool bUseSocketRotationAxisZ
	{
		get
		{
			CheckDestroyed();
			if (!bUseSocketRotationAxisZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:bUseSocketRotationAxisZ");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseSocketRotationAxisZ_Offset), 0, bUseSocketRotationAxisZ_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseSocketRotationAxisZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:bUseSocketRotationAxisZ");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseSocketRotationAxisZ_Offset), 0, bUseSocketRotationAxisZ_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("掉落Transform偏移量")]
	[Category("掉落物位置种点配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:DropOffset")]
	public FTransform DropOffset
	{
		get
		{
			CheckDestroyed();
			if (!DropOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:DropOffset");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, DropOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp:DropOffset");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, DropOffset_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_DroppedItemManagerData bUC_DroppedItemManagerData = RequireWritableData<b1.BUC_DroppedItemManagerData>();
		bUC_DroppedItemManagerData.DropTransform = DropTransform;
		bUC_DroppedItemManagerData.DropItemID = DropItemID;
		bUC_DroppedItemManagerData.SpawnDelayTime = SpawnDelayTime;
		bUC_DroppedItemManagerData.PointRecorder = PointRecorder;
		bUC_DroppedItemManagerData.DropUnitGuid = DropUnit.ActorGuid;
		bUC_DroppedItemManagerData.DropSocket = DropSocket;
		bUC_DroppedItemManagerData.bUseSocketRotation = bUseSocketRotation;
		bUC_DroppedItemManagerData.bUseSocketRotationAxisX = bUseSocketRotationAxisX;
		bUC_DroppedItemManagerData.bUseSocketRotationAxisY = bUseSocketRotationAxisY;
		bUC_DroppedItemManagerData.bUseSocketRotationAxisZ = bUseSocketRotationAxisZ;
		bUC_DroppedItemManagerData.DropOffset = DropOffset;
		bUC_DroppedItemManagerData.NeedSpawn = false;
		bUC_DroppedItemManagerData.DelayTime = 0f;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_DroppedItemManagerConfigComp");
		DropItemID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropItemID");
		DropItemID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropItemID", Classes.FIntProperty);
		DropTransform_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropTransform");
		DropTransform_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropTransform", Classes.FStructProperty);
		SpawnDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpawnDelayTime");
		SpawnDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpawnDelayTime", Classes.FFloatProperty);
		PointRecorder_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PointRecorder");
		PointRecorder_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PointRecorder", Classes.FSoftObjectProperty);
		DropUnit_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropUnit");
		DropUnit_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropUnit", Classes.FStructProperty);
		DropSocket_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropSocket");
		DropSocket_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropSocket", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref bUseSocketRotation_PropertyAddress, unrealStruct, "bUseSocketRotation");
		bUseSocketRotation_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bUseSocketRotation");
		bUseSocketRotation_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bUseSocketRotation", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseSocketRotationAxisX_PropertyAddress, unrealStruct, "bUseSocketRotationAxisX");
		bUseSocketRotationAxisX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bUseSocketRotationAxisX");
		bUseSocketRotationAxisX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bUseSocketRotationAxisX", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseSocketRotationAxisY_PropertyAddress, unrealStruct, "bUseSocketRotationAxisY");
		bUseSocketRotationAxisY_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bUseSocketRotationAxisY");
		bUseSocketRotationAxisY_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bUseSocketRotationAxisY", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseSocketRotationAxisZ_PropertyAddress, unrealStruct, "bUseSocketRotationAxisZ");
		bUseSocketRotationAxisZ_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bUseSocketRotationAxisZ");
		bUseSocketRotationAxisZ_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bUseSocketRotationAxisZ", Classes.FBoolProperty);
		DropOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropOffset");
		DropOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropOffset", Classes.FStructProperty);
	}

	static BUS_DroppedItemManagerConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_DroppedItemManagerConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_DroppedItemManagerConfigComp));
	}
}
