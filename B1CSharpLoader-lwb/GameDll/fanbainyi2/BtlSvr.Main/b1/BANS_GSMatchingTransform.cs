using System;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Matching Transform")]
[USharpPath("/Script/b1-Managed.BANS_GSMatchingTransform")]
public class BANS_GSMatchingTransform : BANS_GSBase
{
	private static bool IsNeedForceMatchingInEnd_IsValid;

	private static int IsNeedForceMatchingInEnd_Offset;

	private static FFieldAddress IsNeedForceMatchingInEnd_PropertyAddress;

	private static bool IsUseSceneItemToMatchingTransfrom_IsValid;

	private static int IsUseSceneItemToMatchingTransfrom_Offset;

	private static FFieldAddress IsUseSceneItemToMatchingTransfrom_PropertyAddress;

	private static bool NeedFindSceneItem_IsValid;

	private static int NeedFindSceneItem_Offset;

	private static FFieldAddress NeedFindSceneItem_PropertyAddress;

	private static bool SceneActorTags_IsValid;

	private static int SceneActorTags_Offset;

	private static FFieldAddress SceneActorTags_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> SceneActorTags_Marshaler;

	private static bool MinDistance_IsValid;

	private static int MinDistance_Offset;

	private static bool MaxDistance_IsValid;

	private static int MaxDistance_Offset;

	private static bool FindSceneItemWay_IsValid;

	private static int FindSceneItemWay_Offset;

	private static FFieldAddress FindSceneItemWay_PropertyAddress;

	private static bool Angle_IsValid;

	private static int Angle_Offset;

	private static bool NeedRemoveCurrentCatch_IsValid;

	private static int NeedRemoveCurrentCatch_Offset;

	private static FFieldAddress NeedRemoveCurrentCatch_PropertyAddress;

	private static bool ExtraTransform_IsValid;

	private static int ExtraTransform_Offset;

	private static bool IsRotatorToItem_IsValid;

	private static int IsRotatorToItem_Offset;

	private static FFieldAddress IsRotatorToItem_PropertyAddress;

	private static bool EnableBow_IsValid;

	private static int EnableBow_Offset;

	private static FFieldAddress EnableBow_PropertyAddress;

	private static bool EnableZAxisMove_IsValid;

	private static int EnableZAxisMove_Offset;

	private static FFieldAddress EnableZAxisMove_PropertyAddress;

	private static bool IgnoreLocation_IsValid;

	private static int IgnoreLocation_Offset;

	private static FFieldAddress IgnoreLocation_PropertyAddress;

	private static bool IgnoreRotation_IsValid;

	private static int IgnoreRotation_Offset;

	private static FFieldAddress IgnoreRotation_PropertyAddress;

	private static bool EnableDrawDebug_IsValid;

	private static int EnableDrawDebug_Offset;

	private static FFieldAddress EnableDrawDebug_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("结束时强制对位")]
	[USharpPath("/Script/b1-Managed.BANS_GSMatchingTransform:IsNeedForceMatchingInEnd")]
	public bool IsNeedForceMatchingInEnd
	{
		get
		{
			CheckDestroyed();
			if (!IsNeedForceMatchingInEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:IsNeedForceMatchingInEnd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsNeedForceMatchingInEnd_Offset), 0, IsNeedForceMatchingInEnd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsNeedForceMatchingInEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:IsNeedForceMatchingInEnd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsNeedForceMatchingInEnd_Offset), 0, IsNeedForceMatchingInEnd_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("得提前TryFindSceneItem并且缓存好")]
	[DisplayName("使用缓存的SceneItem的位置信息去对位")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSMatchingTransform:IsUseSceneItemToMatchingTransfrom")]
	public bool IsUseSceneItemToMatchingTransfrom
	{
		get
		{
			CheckDestroyed();
			if (!IsUseSceneItemToMatchingTransfrom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:IsUseSceneItemToMatchingTransfrom");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsUseSceneItemToMatchingTransfrom_Offset), 0, IsUseSceneItemToMatchingTransfrom_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsUseSceneItemToMatchingTransfrom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:IsUseSceneItemToMatchingTransfrom");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsUseSceneItemToMatchingTransfrom_Offset), 0, IsUseSceneItemToMatchingTransfrom_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("是否需要重新找SceneItem")]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "IsUseSceneItemToMatchingTransfrom")]
	[USharpPath("/Script/b1-Managed.BANS_GSMatchingTransform:NeedFindSceneItem")]
	public bool NeedFindSceneItem
	{
		get
		{
			CheckDestroyed();
			if (!NeedFindSceneItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:NeedFindSceneItem");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedFindSceneItem_Offset), 0, NeedFindSceneItem_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedFindSceneItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:NeedFindSceneItem");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedFindSceneItem_Offset), 0, NeedFindSceneItem_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "NeedFindSceneItem && IsUseSceneItemToMatchingTransfrom")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSMatchingTransform:SceneActorTags")]
	public TArrayReadWrite<FName> SceneActorTags
	{
		get
		{
			CheckDestroyed();
			if (!SceneActorTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:SceneActorTags");
				return null;
			}
			if (SceneActorTags_Marshaler == null)
			{
				SceneActorTags_Marshaler = new TArrayReadWriteMarshaler<FName>(1, SceneActorTags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return SceneActorTags_Marshaler.FromNative(IntPtr.Add(base.Address, SceneActorTags_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "NeedFindSceneItem && IsUseSceneItemToMatchingTransfrom")]
	[USharpPath("/Script/b1-Managed.BANS_GSMatchingTransform:MinDistance")]
	public float MinDistance
	{
		get
		{
			CheckDestroyed();
			if (!MinDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:MinDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:MinDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinDistance_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "NeedFindSceneItem && IsUseSceneItemToMatchingTransfrom")]
	[USharpPath("/Script/b1-Managed.BANS_GSMatchingTransform:MaxDistance")]
	public float MaxDistance
	{
		get
		{
			CheckDestroyed();
			if (!MaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:MaxDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:MaxDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxDistance_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "NeedFindSceneItem && IsUseSceneItemToMatchingTransfrom")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSMatchingTransform:FindSceneItemWay")]
	public EFindSceneItemWay FindSceneItemWay
	{
		get
		{
			CheckDestroyed();
			if (!FindSceneItemWay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:FindSceneItemWay");
				return EFindSceneItemWay.FindNearest;
			}
			return EnumMarshaler<EFindSceneItemWay>.FromNative(IntPtr.Add(base.Address, FindSceneItemWay_Offset), 0, FindSceneItemWay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FindSceneItemWay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:FindSceneItemWay");
			}
			else
			{
				EnumMarshaler<EFindSceneItemWay>.ToNative(IntPtr.Add(base.Address, FindSceneItemWay_Offset), 0, FindSceneItemWay_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("【角度外】对比夹角")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "NeedFindSceneItem && IsUseSceneItemToMatchingTransfrom && FindSceneItemWay != FindSceneItemWay::ClosestOutsideTheAngle && FindSceneItemWay != FindSceneItemWay::FarthestOutsideTheAngle")]
	[USharpPath("/Script/b1-Managed.BANS_GSMatchingTransform:Angle")]
	public float Angle
	{
		get
		{
			CheckDestroyed();
			if (!Angle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:Angle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Angle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Angle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:Angle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Angle_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("重新查找前，清空当前已经缓存了的SceneItem")]
	[UMeta(MDProp.EditCondition, "NeedFindSceneItem && IsUseSceneItemToMatchingTransfrom")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSMatchingTransform:NeedRemoveCurrentCatch")]
	public bool NeedRemoveCurrentCatch
	{
		get
		{
			CheckDestroyed();
			if (!NeedRemoveCurrentCatch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:NeedRemoveCurrentCatch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedRemoveCurrentCatch_Offset), 0, NeedRemoveCurrentCatch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedRemoveCurrentCatch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:NeedRemoveCurrentCatch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedRemoveCurrentCatch_Offset), 0, NeedRemoveCurrentCatch_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("使用指定的世界绝对位置信息去对位")]
	[UMeta(MDProp.EditCondition, "!IsUseSceneItemToMatchingTransfrom")]
	[USharpPath("/Script/b1-Managed.BANS_GSMatchingTransform:ExtraTransform")]
	public FTransform ExtraTransform
	{
		get
		{
			CheckDestroyed();
			if (!ExtraTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:ExtraTransform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, ExtraTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExtraTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:ExtraTransform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, ExtraTransform_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("是否转向SceneItem")]
	[Tooltip("不勾选，则朝向用的是SceneItem的朝向")]
	[UMeta(MDProp.EditCondition, "IsUseSceneItemToMatchingTransfrom")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSMatchingTransform:IsRotatorToItem")]
	public bool IsRotatorToItem
	{
		get
		{
			CheckDestroyed();
			if (!IsRotatorToItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:IsRotatorToItem");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsRotatorToItem_Offset), 0, IsRotatorToItem_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsRotatorToItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:IsRotatorToItem");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsRotatorToItem_Offset), 0, IsRotatorToItem_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("是否贴地")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSMatchingTransform:EnableBow")]
	public bool EnableBow
	{
		get
		{
			CheckDestroyed();
			if (!EnableBow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:EnableBow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableBow_Offset), 0, EnableBow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableBow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:EnableBow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableBow_Offset), 0, EnableBow_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("是否开启Z轴位移（需要设置FlyMode）")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSMatchingTransform:EnableZAxisMove")]
	public bool EnableZAxisMove
	{
		get
		{
			CheckDestroyed();
			if (!EnableZAxisMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:EnableZAxisMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableZAxisMove_Offset), 0, EnableZAxisMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableZAxisMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:EnableZAxisMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableZAxisMove_Offset), 0, EnableZAxisMove_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "!IgnoreRotation")]
	[DisplayName("忽略Location插值（强制Set到目标点时也会忽略）")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSMatchingTransform:IgnoreLocation")]
	public bool IgnoreLocation
	{
		get
		{
			CheckDestroyed();
			if (!IgnoreLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:IgnoreLocation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IgnoreLocation_Offset), 0, IgnoreLocation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IgnoreLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:IgnoreLocation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IgnoreLocation_Offset), 0, IgnoreLocation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "!IgnoreLocation")]
	[DisplayName("忽略Rotation插值（强制Set到目标点时也会忽略）")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSMatchingTransform:IgnoreRotation")]
	public bool IgnoreRotation
	{
		get
		{
			CheckDestroyed();
			if (!IgnoreRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:IgnoreRotation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IgnoreRotation_Offset), 0, IgnoreRotation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IgnoreRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:IgnoreRotation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IgnoreRotation_Offset), 0, IgnoreRotation_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("开始时可视化展示对位点信息")]
	[DisplayName("开启DebugDraw")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSMatchingTransform:EnableDrawDebug")]
	public bool EnableDrawDebug
	{
		get
		{
			CheckDestroyed();
			if (!EnableDrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:EnableDrawDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDrawDebug_Offset), 0, EnableDrawDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMatchingTransform:EnableDrawDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDrawDebug_Offset), 0, EnableDrawDebug_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		IsNeedForceMatchingInEnd = true;
		IsUseSceneItemToMatchingTransfrom = true;
		NeedFindSceneItem = false;
		EnableZAxisMove = false;
		IgnoreLocation = false;
		IgnoreRotation = false;
		IsRotatorToItem = false;
		EnableBow = true;
		EnableDrawDebug = false;
		UBGUFunctionLibraryForCS.BGUGetIsEditor();
	}

	private bool FindAndEnsureSceneItemValid(FUStGSNotifyParam NotifyParam, out AActor OutSceneItemCatch, bool bCanBeginTryFindSceneItem = true)
	{
		OutSceneItemCatch = null;
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			if (NeedFindSceneItem && bCanBeginTryFindSceneItem)
			{
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					BGUFunctionLibraryCS.LogBattleInfo(bGUCharacterCS, EBattleInfoType.TryFindSceneItem, "<character>" + bGUCharacterCS?.GetName() + "</><action>=============================MatchingTransform里重新找SceneItem开始=============================</>");
				}
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_TryCatchSceneItemByTag.Invoke(SceneActorTags.ToList(), FindSceneItemWay, NeedRemoveCurrentCatch, MinDistance, MaxDistance, NotifyParam.FromInstanceID, -1f, Angle, EnableDrawDebug);
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					BGUFunctionLibraryCS.LogBattleInfo(bGUCharacterCS, EBattleInfoType.TryFindSceneItem, "<character>" + bGUCharacterCS?.GetName() + "</><action>=============================MatchingTransform里重新找SceneItem结束=============================</>");
				}
			}
			BUC_SceneItemData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(bGUCharacterCS);
			if (readOnlyData != null)
			{
				bool flag = false;
				AActor catchedSceneItemByAMID = readOnlyData.GetCatchedSceneItemByAMID(NotifyParam.FromInstanceID);
				if (catchedSceneItemByAMID != null)
				{
					if (SceneActorTags.Count > 0)
					{
						foreach (FName item in SceneActorTags.ToList())
						{
							if (readOnlyData.SceneItemCatch.ActorHasTag(item))
							{
								OutSceneItemCatch = readOnlyData.SceneItemCatch;
								flag = true;
								break;
							}
						}
					}
					else
					{
						OutSceneItemCatch = catchedSceneItemByAMID;
						flag = true;
					}
				}
				if (!flag)
				{
					if (readOnlyData.SceneItemCatch != null)
					{
						if (SceneActorTags.Count > 0)
						{
							foreach (FName item2 in SceneActorTags.ToList())
							{
								if (readOnlyData.SceneItemCatch.ActorHasTag(item2))
								{
									OutSceneItemCatch = readOnlyData.SceneItemCatch;
									flag = true;
									break;
								}
							}
						}
						else
						{
							OutSceneItemCatch = readOnlyData.SceneItemCatch;
							flag = true;
						}
					}
					else if (SceneActorTags.Count == 0)
					{
						return false;
					}
				}
				if (!flag)
				{
					if (DebugConfig.IsOpenBattleInfoTool)
					{
						BGUFunctionLibraryCS.LogBattleInfo(bGUCharacterCS, EBattleInfoType.TryFindSceneItem, "<character>" + bGUCharacterCS?.GetName() + "</><action>=============================MatchingTransform里重新找SceneItem开始=============================</>");
					}
					BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_TryCatchSceneItemByTag.Invoke(SceneActorTags.ToList(), FindSceneItemWay, NeedRemoveCurrentCatch: true, MinDistance, MaxDistance, NotifyParam.FromInstanceID, -1f, Angle, EnableDrawDebug);
					if (DebugConfig.IsOpenBattleInfoTool)
					{
						BGUFunctionLibraryCS.LogBattleInfo(bGUCharacterCS, EBattleInfoType.TryFindSceneItem, "<character>" + bGUCharacterCS?.GetName() + "</><action>=============================MatchingTransform里重新找SceneItem结束=============================</>");
					}
					if (readOnlyData.SceneItemCatch != null)
					{
						foreach (FName item3 in SceneActorTags.ToList())
						{
							if (readOnlyData.SceneItemCatch.ActorHasTag(item3))
							{
								OutSceneItemCatch = readOnlyData.SceneItemCatch;
								return true;
							}
						}
					}
				}
				return flag;
			}
		}
		return false;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSMatchingTransform:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (IgnoreRotation && IgnoreLocation)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
		bool flag = false;
		if (IsUseSceneItemToMatchingTransfrom)
		{
			if (BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(bGUCharacterCS) != null && FindAndEnsureSceneItemValid(NotifyParam, out var OutSceneItemCatch))
			{
				flag = true;
				if (BGU_DataUtil.GetReadOnlyData<BUC_SceneItemCommData>(OutSceneItemCatch) != null)
				{
					FTransform fTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(OutSceneItemCatch);
					FVector finalLocation = GetFinalLocation(bGUCharacterCS, fTransform.GetLocation());
					FRotator targetRot = fTransform.GetRotation().Rotator();
					if (IsRotatorToItem)
					{
						targetRot = (fTransform.GetLocation() - NotifyParam.owner.GetActorLocation()).Rotation();
					}
					bUS_GSEventCollection.Evt_InterpolationMove.Invoke(finalLocation, targetRot, TotalDuration, EnableZAxisMove, IgnoreLocation, IgnoreRotation, ForceUpdate: false);
					bUS_GSEventCollection.Evt_OnSceneItemMatchTransformBegin.Invoke(OutSceneItemCatch, NotifyParam.FromInstanceID, NotifyParam.UniqueID);
					if (EnableDrawDebug)
					{
						USystemLibrary.DrawDebugSphere(bGUCharacterCS, finalLocation, 100f, 20, FLinearColor.Yellow, 20f, 10f);
						USystemLibrary.DrawDebugArrow(bGUCharacterCS, finalLocation, finalLocation + new FVector(0.0, 0.0, 500.0), 30f, FLinearColor.Red, 20f, 20f);
						USystemLibrary.DrawDebugArrow(bGUCharacterCS, finalLocation, finalLocation + targetRot.Vector().GetSafeNormal() * 500.0, 30f, FLinearColor.Green, 20f, 20f);
					}
				}
				else
				{
					BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_TryCatchSceneItemByTag.Invoke(SceneActorTags.ToList(), FindSceneItemWay, NeedRemoveCurrentCatch, MinDistance, MaxDistance, NotifyParam.FromInstanceID, -1f, Angle, EnableDrawDebug);
				}
			}
			if (!flag)
			{
				return;
			}
		}
		if (!flag)
		{
			FVector finalLocation2 = GetFinalLocation(bGUCharacterCS, ExtraTransform.GetLocation());
			FRotator targetRot2 = ExtraTransform.GetRotation().Rotator();
			bUS_GSEventCollection.Evt_InterpolationMove.Invoke(finalLocation2, targetRot2, TotalDuration, EnableZAxisMove, IgnoreLocation, IgnoreRotation, ForceUpdate: false);
			if (EnableDrawDebug)
			{
				USystemLibrary.DrawDebugSphere(bGUCharacterCS, finalLocation2, 100f, 20, FLinearColor.Yellow, 20f, 10f);
				USystemLibrary.DrawDebugArrow(bGUCharacterCS, finalLocation2, finalLocation2 + new FVector(0.0, 0.0, 500.0), 30f, FLinearColor.Red, 20f, 20f);
				USystemLibrary.DrawDebugArrow(bGUCharacterCS, finalLocation2, finalLocation2 + targetRot2.Vector().GetSafeNormal() * 500.0, 30f, FLinearColor.Green, 20f, 20f);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSMatchingTransform:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_OnSceneItemMatchTransformEnd.Invoke(NotifyParam.FromInstanceID, NotifyParam.UniqueID, IsNeedForceMatchingInEnd, EnableBow);
		}
	}

	private FVector GetFinalLocation(BGUCharacterCS CharacterCS, FVector InTargetLocation)
	{
		FVector result = InTargetLocation;
		if (EnableBow)
		{
			UCapsuleComponent uCapsuleComponent = CharacterCS.GetRootComponent() as UCapsuleComponent;
			if (uCapsuleComponent == null)
			{
				return result;
			}
			float scaledCapsuleHalfHeight = uCapsuleComponent.GetScaledCapsuleHalfHeight();
			float scaledCapsuleHalfHeight2 = uCapsuleComponent.GetScaledCapsuleHalfHeight();
			float num = 2.4f;
			FVector start = InTargetLocation + FVector.UpVector * scaledCapsuleHalfHeight * 2.0;
			FVector end = InTargetLocation - FVector.UpVector * scaledCapsuleHalfHeight * 2.0;
			if (UGSE_TraceFuncLib.CharacterCapsuleTraceSingleByProfile(this, start, end, scaledCapsuleHalfHeight2, scaledCapsuleHalfHeight, B1GlobalFNames.Pawn, bTraceComplex: false, CharacterCS, out var OutHitLocation))
			{
				result = OutHitLocation + num;
			}
		}
		return result;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSMatchingTransform:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSMatchingTransform bANS_GSMatchingTransform = GCHelper.Find<BANS_GSMatchingTransform>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSMatchingTransform.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSMatchingTransform:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSMatchingTransform bANS_GSMatchingTransform = GCHelper.Find<BANS_GSMatchingTransform>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSMatchingTransform.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSMatchingTransform");
		NativeReflection.GetPropertyRef(ref IsNeedForceMatchingInEnd_PropertyAddress, intPtr, "IsNeedForceMatchingInEnd");
		IsNeedForceMatchingInEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsNeedForceMatchingInEnd");
		IsNeedForceMatchingInEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsNeedForceMatchingInEnd", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsUseSceneItemToMatchingTransfrom_PropertyAddress, intPtr, "IsUseSceneItemToMatchingTransfrom");
		IsUseSceneItemToMatchingTransfrom_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsUseSceneItemToMatchingTransfrom");
		IsUseSceneItemToMatchingTransfrom_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsUseSceneItemToMatchingTransfrom", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref NeedFindSceneItem_PropertyAddress, intPtr, "NeedFindSceneItem");
		NeedFindSceneItem_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedFindSceneItem");
		NeedFindSceneItem_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedFindSceneItem", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SceneActorTags_PropertyAddress, intPtr, "SceneActorTags");
		SceneActorTags_Offset = NativeReflection.GetPropertyOffset(intPtr, "SceneActorTags");
		SceneActorTags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SceneActorTags", Classes.FArrayProperty);
		MinDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinDistance");
		MinDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinDistance", Classes.FFloatProperty);
		MaxDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxDistance");
		MaxDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxDistance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref FindSceneItemWay_PropertyAddress, intPtr, "FindSceneItemWay");
		FindSceneItemWay_Offset = NativeReflection.GetPropertyOffset(intPtr, "FindSceneItemWay");
		FindSceneItemWay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FindSceneItemWay", Classes.FEnumProperty);
		Angle_Offset = NativeReflection.GetPropertyOffset(intPtr, "Angle");
		Angle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Angle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref NeedRemoveCurrentCatch_PropertyAddress, intPtr, "NeedRemoveCurrentCatch");
		NeedRemoveCurrentCatch_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedRemoveCurrentCatch");
		NeedRemoveCurrentCatch_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedRemoveCurrentCatch", Classes.FBoolProperty);
		ExtraTransform_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExtraTransform");
		ExtraTransform_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExtraTransform", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref IsRotatorToItem_PropertyAddress, intPtr, "IsRotatorToItem");
		IsRotatorToItem_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsRotatorToItem");
		IsRotatorToItem_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsRotatorToItem", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableBow_PropertyAddress, intPtr, "EnableBow");
		EnableBow_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableBow");
		EnableBow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableBow", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableZAxisMove_PropertyAddress, intPtr, "EnableZAxisMove");
		EnableZAxisMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableZAxisMove");
		EnableZAxisMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableZAxisMove", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IgnoreLocation_PropertyAddress, intPtr, "IgnoreLocation");
		IgnoreLocation_Offset = NativeReflection.GetPropertyOffset(intPtr, "IgnoreLocation");
		IgnoreLocation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IgnoreLocation", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IgnoreRotation_PropertyAddress, intPtr, "IgnoreRotation");
		IgnoreRotation_Offset = NativeReflection.GetPropertyOffset(intPtr, "IgnoreRotation");
		IgnoreRotation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IgnoreRotation", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableDrawDebug_PropertyAddress, intPtr, "EnableDrawDebug");
		EnableDrawDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableDrawDebug");
		EnableDrawDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableDrawDebug", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSMatchingTransform:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSMatchingTransform:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSMatchingTransform()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BANS_GSMatchingTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BANS_GSMatchingTransform));
	}
}
