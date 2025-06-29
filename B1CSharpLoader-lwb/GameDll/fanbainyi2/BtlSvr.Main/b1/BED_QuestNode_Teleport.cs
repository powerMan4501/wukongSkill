using System;
using System.Text;
using b1.Plugins.AsyncLoadingScreen;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Teleport")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_Teleport")]
public class BED_QuestNode_Teleport : BED_QuestNode
{
	private static bool bTeleportToOtherLevel_IsValid;

	private static int bTeleportToOtherLevel_Offset;

	private static FFieldAddress bTeleportToOtherLevel_PropertyAddress;

	private static bool TargetLevelID_IsValid;

	private static int TargetLevelID_Offset;

	private static bool PointName_IsValid;

	private static int PointName_Offset;

	private static bool TargetRebirthPointId_IsValid;

	private static int TargetRebirthPointId_Offset;

	private static bool bDropTeleportPoint_IsValid;

	private static int bDropTeleportPoint_Offset;

	private static FFieldAddress bDropTeleportPoint_PropertyAddress;

	private static bool DroppedTeleportPointId_IsValid;

	private static int DroppedTeleportPointId_Offset;

	private static bool BeforeTeleportMontage_IsValid;

	private static int BeforeTeleportMontage_Offset;

	private static bool AfterTeleportMontage_IsValid;

	private static int AfterTeleportMontage_Offset;

	private static bool bSaveArchiveAfterTeleport_IsValid;

	private static int bSaveArchiveAfterTeleport_Offset;

	private static FFieldAddress bSaveArchiveAfterTeleport_PropertyAddress;

	private static bool ArchiveLabel_IsValid;

	private static int ArchiveLabel_Offset;

	private static bool bDontResetPlayerState_IsValid;

	private static int bDontResetPlayerState_Offset;

	private static FFieldAddress bDontResetPlayerState_PropertyAddress;

	private static bool LoadingScreenType_IsValid;

	private static int LoadingScreenType_Offset;

	private static FFieldAddress LoadingScreenType_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[Category("传送")]
	[DisplayName("是否跨关卡传送")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_Teleport:bTeleportToOtherLevel")]
	public bool bTeleportToOtherLevel
	{
		get
		{
			CheckDestroyed();
			if (!bTeleportToOtherLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:bTeleportToOtherLevel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bTeleportToOtherLevel_Offset), 0, bTeleportToOtherLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bTeleportToOtherLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:bTeleportToOtherLevel");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bTeleportToOtherLevel_Offset), 0, bTeleportToOtherLevel_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("目标关卡ID")]
	[Tooltip("需要勾选跨关卡传送")]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "bTeleportToOtherLevel")]
	[Category("传送")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_Teleport:TargetLevelID")]
	public int TargetLevelID
	{
		get
		{
			CheckDestroyed();
			if (!TargetLevelID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:TargetLevelID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TargetLevelID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetLevelID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:TargetLevelID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TargetLevelID_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("传送点ID")]
	[Tooltip("可缺省")]
	[Category("传送")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_Teleport:PointName")]
	public FName PointName
	{
		get
		{
			CheckDestroyed();
			if (!PointName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:PointName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, PointName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:PointName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, PointName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("目标复活点ID")]
	[Tooltip("必须配置")]
	[Category("传送")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_Teleport:TargetRebirthPointId")]
	public int TargetRebirthPointId
	{
		get
		{
			CheckDestroyed();
			if (!TargetRebirthPointId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:TargetRebirthPointId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TargetRebirthPointId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetRebirthPointId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:TargetRebirthPointId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TargetRebirthPointId_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("传送前")]
	[DisplayName("是否在当前位置放置新的传送点")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_Teleport:bDropTeleportPoint")]
	public bool bDropTeleportPoint
	{
		get
		{
			CheckDestroyed();
			if (!bDropTeleportPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:bDropTeleportPoint");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDropTeleportPoint_Offset), 0, bDropTeleportPoint_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDropTeleportPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:bDropTeleportPoint");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDropTeleportPoint_Offset), 0, bDropTeleportPoint_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("传送点标识")]
	[Category("传送前")]
	[UMeta(MDProp.EditCondition, "bDropTeleportPoint")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_Teleport:DroppedTeleportPointId")]
	public FName DroppedTeleportPointId
	{
		get
		{
			CheckDestroyed();
			if (!DroppedTeleportPointId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:DroppedTeleportPointId");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DroppedTeleportPointId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DroppedTeleportPointId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:DroppedTeleportPointId");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DroppedTeleportPointId_Offset), value);
			}
		}
	}

	[Category("传送前")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("传送前动画")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_Teleport:BeforeTeleportMontage")]
	public TSoftObject<UAnimMontage> BeforeTeleportMontage
	{
		get
		{
			CheckDestroyed();
			if (!BeforeTeleportMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:BeforeTeleportMontage");
				return default(TSoftObject<UAnimMontage>);
			}
			return TSoftObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, BeforeTeleportMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeforeTeleportMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:BeforeTeleportMontage");
			}
			else
			{
				TSoftObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, BeforeTeleportMontage_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("传送后动画")]
	[Category("传送后")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_Teleport:AfterTeleportMontage")]
	public TSoftObject<UAnimMontage> AfterTeleportMontage
	{
		get
		{
			CheckDestroyed();
			if (!AfterTeleportMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:AfterTeleportMontage");
				return default(TSoftObject<UAnimMontage>);
			}
			return TSoftObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AfterTeleportMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AfterTeleportMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:AfterTeleportMontage");
			}
			else
			{
				TSoftObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AfterTeleportMontage_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("传送后")]
	[BlueprintReadWrite]
	[DisplayName("传送后存档")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_Teleport:bSaveArchiveAfterTeleport")]
	public bool bSaveArchiveAfterTeleport
	{
		get
		{
			CheckDestroyed();
			if (!bSaveArchiveAfterTeleport_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:bSaveArchiveAfterTeleport");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSaveArchiveAfterTeleport_Offset), 0, bSaveArchiveAfterTeleport_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSaveArchiveAfterTeleport_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:bSaveArchiveAfterTeleport");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSaveArchiveAfterTeleport_Offset), 0, bSaveArchiveAfterTeleport_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("存档标记")]
	[Category("传送后")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "bSaveArchiveAfterTeleport")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_Teleport:ArchiveLabel")]
	public FName ArchiveLabel
	{
		get
		{
			CheckDestroyed();
			if (!ArchiveLabel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:ArchiveLabel");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ArchiveLabel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ArchiveLabel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:ArchiveLabel");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ArchiveLabel_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("传送")]
	[UMeta(MDProp.EditCondition, "bDontResetPlayerState")]
	[EditAnywhere]
	[UProperty]
	[DisplayName("不重置玩家状态")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_Teleport:bDontResetPlayerState")]
	public bool bDontResetPlayerState
	{
		get
		{
			CheckDestroyed();
			if (!bDontResetPlayerState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:bDontResetPlayerState");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDontResetPlayerState_Offset), 0, bDontResetPlayerState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDontResetPlayerState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:bDontResetPlayerState");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDontResetPlayerState_Offset), 0, bDontResetPlayerState_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("Loading Screen")]
	[DisplayName("传送Loading Screen类型")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_Teleport:LoadingScreenType")]
	public EGSLoadingScreenType LoadingScreenType
	{
		get
		{
			CheckDestroyed();
			if (!LoadingScreenType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:LoadingScreenType");
				return EGSLoadingScreenType.Unknown;
			}
			return EnumMarshaler<EGSLoadingScreenType>.FromNative(IntPtr.Add(base.Address, LoadingScreenType_Offset), 0, LoadingScreenType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LoadingScreenType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Teleport:LoadingScreenType");
			}
			else
			{
				EnumMarshaler<EGSLoadingScreenType>.ToNative(IntPtr.Add(base.Address, LoadingScreenType_Offset), 0, LoadingScreenType_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Gameplay");
		SetNodeStyle(ECalliopeNodeStyle.Default);
		bTeleportToOtherLevel = false;
		TargetLevelID = -1;
		TargetRebirthPointId = -1;
		bSaveArchiveAfterTeleport = true;
		LoadingScreenType = EGSLoadingScreenType.FullBlack;
		base.OutputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.Teleport;
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_Teleport:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (bTeleportToOtherLevel)
		{
			stringBuilder.AppendLine("跨关卡传送");
		}
		stringBuilder.Append("主角传送到[" + PointName.PlainName + "]传送点");
		if (TargetRebirthPointId > 0)
		{
			stringBuilder.AppendLine();
			stringBuilder.AppendLine($"传送到复活点：{TargetRebirthPointId}");
		}
		if (bDropTeleportPoint)
		{
			stringBuilder.AppendLine();
			stringBuilder.Append("放置一个传送点，传送点标识：" + DroppedTeleportPointId.PlainName);
		}
		if (bSaveArchiveAfterTeleport)
		{
			stringBuilder.AppendLine();
			stringBuilder.Append($"传送完成存档：存档标识{ArchiveLabel}");
		}
		return stringBuilder.ToString();
	}

	public override byte[] GetCustomData()
	{
		return new QuestCustom_Teleport
		{
			PointName = PointName.PlainName,
			IsDropTeleportPoint = bDropTeleportPoint,
			DroppedTeleportPointId = DroppedTeleportPointId.PlainName,
			BeforeTeleportMontagePath = ConvertSoftObj2NodeData(BeforeTeleportMontage),
			AfterTeleportMontagePath = ConvertSoftObj2NodeData(AfterTeleportMontage),
			IsTeleportToOtherLevel = bTeleportToOtherLevel,
			TargetLevelId = TargetLevelID,
			IsSaveArchiveAfterTeleport = bSaveArchiveAfterTeleport,
			ArchiveLabel = ArchiveLabel.PlainName,
			TargetRebirthPointId = TargetRebirthPointId,
			DontResetPlayerState = bDontResetPlayerState,
			LoadingScreenType = (int)LoadingScreenType
		}.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_Teleport:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_Teleport bED_QuestNode_Teleport = GCHelper.Find<BED_QuestNode_Teleport>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_Teleport.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_Teleport");
		NativeReflection.GetPropertyRef(ref bTeleportToOtherLevel_PropertyAddress, intPtr, "bTeleportToOtherLevel");
		bTeleportToOtherLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "bTeleportToOtherLevel");
		bTeleportToOtherLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bTeleportToOtherLevel", Classes.FBoolProperty);
		TargetLevelID_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetLevelID");
		TargetLevelID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetLevelID", Classes.FIntProperty);
		PointName_Offset = NativeReflection.GetPropertyOffset(intPtr, "PointName");
		PointName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PointName", Classes.FNameProperty);
		TargetRebirthPointId_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetRebirthPointId");
		TargetRebirthPointId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetRebirthPointId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bDropTeleportPoint_PropertyAddress, intPtr, "bDropTeleportPoint");
		bDropTeleportPoint_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDropTeleportPoint");
		bDropTeleportPoint_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDropTeleportPoint", Classes.FBoolProperty);
		DroppedTeleportPointId_Offset = NativeReflection.GetPropertyOffset(intPtr, "DroppedTeleportPointId");
		DroppedTeleportPointId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DroppedTeleportPointId", Classes.FNameProperty);
		BeforeTeleportMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeforeTeleportMontage");
		BeforeTeleportMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeforeTeleportMontage", Classes.FSoftObjectProperty);
		AfterTeleportMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "AfterTeleportMontage");
		AfterTeleportMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AfterTeleportMontage", Classes.FSoftObjectProperty);
		NativeReflection.GetPropertyRef(ref bSaveArchiveAfterTeleport_PropertyAddress, intPtr, "bSaveArchiveAfterTeleport");
		bSaveArchiveAfterTeleport_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSaveArchiveAfterTeleport");
		bSaveArchiveAfterTeleport_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSaveArchiveAfterTeleport", Classes.FBoolProperty);
		ArchiveLabel_Offset = NativeReflection.GetPropertyOffset(intPtr, "ArchiveLabel");
		ArchiveLabel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ArchiveLabel", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref bDontResetPlayerState_PropertyAddress, intPtr, "bDontResetPlayerState");
		bDontResetPlayerState_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDontResetPlayerState");
		bDontResetPlayerState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDontResetPlayerState", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref LoadingScreenType_PropertyAddress, intPtr, "LoadingScreenType");
		LoadingScreenType_Offset = NativeReflection.GetPropertyOffset(intPtr, "LoadingScreenType");
		LoadingScreenType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LoadingScreenType", Classes.FEnumProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_Teleport:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_Teleport()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_Teleport)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_Teleport));
	}
}
