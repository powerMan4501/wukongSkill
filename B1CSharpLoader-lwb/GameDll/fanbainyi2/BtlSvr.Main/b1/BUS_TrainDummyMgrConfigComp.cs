using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_TrainDummyMgrConfigComp")]
public class BUS_TrainDummyMgrConfigComp : UActorEditCompBase
{
	private static bool TrainDummyClass_IsValid;

	private static int TrainDummyClass_Offset;

	private static bool PlayerRoleDataConfigID_IsValid;

	private static int PlayerRoleDataConfigID_Offset;

	private static bool TrainDummyConfig_IsValid;

	private static int TrainDummyConfig_Offset;

	[BlueprintReadWrite]
	[Category("打桩配置")]
	[DisplayName("木桩单位")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_TrainDummyMgrConfigComp:TrainDummyClass")]
	public TSubclassOf<ABGUTamerBase> TrainDummyClass
	{
		get
		{
			CheckDestroyed();
			if (!TrainDummyClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TrainDummyMgrConfigComp:TrainDummyClass");
				return default(TSubclassOf<ABGUTamerBase>);
			}
			return TSubclassOfMarshaler<ABGUTamerBase>.FromNative(IntPtr.Add(base.Address, TrainDummyClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TrainDummyClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TrainDummyMgrConfigComp:TrainDummyClass");
			}
			else
			{
				TSubclassOfMarshaler<ABGUTamerBase>.ToNative(IntPtr.Add(base.Address, TrainDummyClass_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Tooltip("主角在开始后应用RoleDataConfigDesc中对应Group配置")]
	[DisplayName("主角预设配置GroupID")]
	[Category("打桩配置")]
	[USharpPath("/Script/b1-Managed.BUS_TrainDummyMgrConfigComp:PlayerRoleDataConfigID")]
	public int PlayerRoleDataConfigID
	{
		get
		{
			CheckDestroyed();
			if (!PlayerRoleDataConfigID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TrainDummyMgrConfigComp:PlayerRoleDataConfigID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PlayerRoleDataConfigID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerRoleDataConfigID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TrainDummyMgrConfigComp:PlayerRoleDataConfigID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PlayerRoleDataConfigID_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("打桩配置")]
	[EditAnywhere]
	[DisplayName("木桩配置")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_TrainDummyMgrConfigComp:TrainDummyConfig")]
	public BGWDataAsset_TrainDummyConfig TrainDummyConfig
	{
		get
		{
			CheckDestroyed();
			if (!TrainDummyConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TrainDummyMgrConfigComp:TrainDummyConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_TrainDummyConfig>.FromNative(IntPtr.Add(base.Address, TrainDummyConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TrainDummyConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TrainDummyMgrConfigComp:TrainDummyConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_TrainDummyConfig>.ToNative(IntPtr.Add(base.Address, TrainDummyConfig_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_TrainDummyMgrConfigData bUC_TrainDummyMgrConfigData = RequireWritableData<BUC_TrainDummyMgrConfigData>();
		bUC_TrainDummyMgrConfigData.TrainDummyClass = TrainDummyClass;
		bUC_TrainDummyMgrConfigData.PlayerRoleDataConfigID = PlayerRoleDataConfigID;
		if (!(TrainDummyConfig == null))
		{
			bUC_TrainDummyMgrConfigData.TrainDummyHPType = TrainDummyConfig.TrainDummyHPType;
			bUC_TrainDummyMgrConfigData.TrainDummyHPValue = ((TrainDummyConfig.TrainDummyHPType == EGSTrainDummyHPType.Infinite) ? int.MaxValue : TrainDummyConfig.TrainDummyHPValue);
			bUC_TrainDummyMgrConfigData.NeedCloseTrainDummyAI = TrainDummyConfig.NeedCloseTrainDummyAI;
			bUC_TrainDummyMgrConfigData.DPSCalTimeType = TrainDummyConfig.DPSCalTimeType;
			bUC_TrainDummyMgrConfigData.DPSCalTime = TrainDummyConfig.DPSCalTime;
			bUC_TrainDummyMgrConfigData.SpecialDamageTypeConfigList = TrainDummyConfig.SpecialDamageTypeConfigList.ToList();
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_TrainDummyMgrConfigComp");
		TrainDummyClass_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TrainDummyClass");
		TrainDummyClass_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TrainDummyClass", Classes.FClassProperty);
		PlayerRoleDataConfigID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlayerRoleDataConfigID");
		PlayerRoleDataConfigID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlayerRoleDataConfigID", Classes.FIntProperty);
		TrainDummyConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TrainDummyConfig");
		TrainDummyConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TrainDummyConfig", Classes.FObjectProperty);
	}

	static BUS_TrainDummyMgrConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_TrainDummyMgrConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_TrainDummyMgrConfigComp));
	}
}
