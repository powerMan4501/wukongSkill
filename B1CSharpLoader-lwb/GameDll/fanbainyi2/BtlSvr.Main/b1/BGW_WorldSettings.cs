using System;
using b1.BGW;
using b1.Plugins.AkAudio;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_WorldSettings")]
public class BGW_WorldSettings : ABGWWorldSettings
{
	private static bool DefaultGroupAIMgrConfigDataAsset_IsValid;

	private static int DefaultGroupAIMgrConfigDataAsset_Offset;

	private static bool DefaultGroupAIBattleHotZoneConfigDataAsset_IsValid;

	private static int DefaultGroupAIBattleHotZoneConfigDataAsset_Offset;

	private static bool DefaultEnvironmentSurfaceEffectID_IsValid;

	private static int DefaultEnvironmentSurfaceEffectID_Offset;

	private static bool DefaultWeatherType_IsValid;

	private static int DefaultWeatherType_Offset;

	private static FFieldAddress DefaultWeatherType_PropertyAddress;

	private static bool EnterLevelEvent_IsValid;

	private static int EnterLevelEvent_Offset;

	private static bool ExitLevelEvent_IsValid;

	private static int ExitLevelEvent_Offset;

	private static bool EnterLevelEventLocation_IsValid;

	private static int EnterLevelEventLocation_Offset;

	private static bool bShowListener_IsValid;

	private static int bShowListener_Offset;

	private static FFieldAddress bShowListener_PropertyAddress;

	private static bool bShowMaxAttentionRadius_IsValid;

	private static int bShowMaxAttentionRadius_Offset;

	private static FFieldAddress bShowMaxAttentionRadius_PropertyAddress;

	private static bool bShowObjectDirectionAxis_IsValid;

	private static int bShowObjectDirectionAxis_Offset;

	private static FFieldAddress bShowObjectDirectionAxis_PropertyAddress;

	private static bool AxisLength_IsValid;

	private static int AxisLength_Offset;

	private static bool GameObjectRefreshInterval_IsValid;

	private static int GameObjectRefreshInterval_Offset;

	private static bool ShowObjectRangeMeter_IsValid;

	private static int ShowObjectRangeMeter_Offset;

	private static bool RootQuestGraph_IsValid;

	private static int RootQuestGraph_Offset;

	private static bool QuestRunDelaySeconds_IsValid;

	private static int QuestRunDelaySeconds_Offset;

	private static bool PlayOnStartNiagaraPaths_IsValid;

	private static int PlayOnStartNiagaraPaths_Offset;

	private static FFieldAddress PlayOnStartNiagaraPaths_PropertyAddress;

	private TArrayReadWriteMarshaler<FDirectoryPath> PlayOnStartNiagaraPaths_Marshaler;

	private static bool NiagaraPlayLocation_IsValid;

	private static int NiagaraPlayLocation_Offset;

	private static bool CellPatitionInsatnceConfig_IsValid;

	private static int CellPatitionInsatnceConfig_Offset;

	private static FFieldAddress CellPatitionInsatnceConfig_PropertyAddress;

	private TMapReadWriteMarshaler<string, FGSCellPatitionInsatnceConfig> CellPatitionInsatnceConfig_Marshaler;

	private static bool TROCellPatitionLayerConfig_IsValid;

	private static int TROCellPatitionLayerConfig_Offset;

	private static FFieldAddress TROCellPatitionLayerConfig_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSTROConfig> TROCellPatitionLayerConfig_Marshaler;

	private static bool RepGraphCellPatitionLayerConfig_IsValid;

	private static int RepGraphCellPatitionLayerConfig_Offset;

	private static FFieldAddress RepGraphCellPatitionLayerConfig_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSRepGraphConfig> RepGraphCellPatitionLayerConfig_Marshaler;

	private static bool EnableLevelOverride_IsValid;

	private static int EnableLevelOverride_Offset;

	private static FFieldAddress EnableLevelOverride_PropertyAddress;

	private static bool TamerSettingConfigDataAsset_IsValid;

	private static int TamerSettingConfigDataAsset_Offset;

	private static bool OnLevelPreSave_IsValid;

	private static IntPtr OnLevelPreSave_FunctionAddress;

	private static int OnLevelPreSave_ParamsSize;

	private static bool OnLevelPreSave_Level_IsValid;

	private static int OnLevelPreSave_Level_Offset;

	private static bool OnLevelPreSave_World_IsValid;

	private static int OnLevelPreSave_World_Offset;

	private static bool ReceiveDestroyed_IsValid;

	private static IntPtr ReceiveDestroyed_FunctionAddress;

	private static int ReceiveDestroyed_ParamsSize;

	[Tooltip("如为空，则默认配置为BP_GroupAIConfig_Default")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GroupAI")]
	[DisplayName("默认群体AI管理器配置")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:DefaultGroupAIMgrConfigDataAsset")]
	public BGWGroupAIMgrConfigDataAsset DefaultGroupAIMgrConfigDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!DefaultGroupAIMgrConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:DefaultGroupAIMgrConfigDataAsset");
				return null;
			}
			return UObjectMarshaler<BGWGroupAIMgrConfigDataAsset>.FromNative(IntPtr.Add(base.Address, DefaultGroupAIMgrConfigDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultGroupAIMgrConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:DefaultGroupAIMgrConfigDataAsset");
			}
			else
			{
				UObjectMarshaler<BGWGroupAIMgrConfigDataAsset>.ToNative(IntPtr.Add(base.Address, DefaultGroupAIMgrConfigDataAsset_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("GroupAI")]
	[DisplayName("默认群体AI热区配置")]
	[Tooltip("如为空，则默认配置为BP_GroupAIHotZoneConfig_Default")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:DefaultGroupAIBattleHotZoneConfigDataAsset")]
	public BGWGroupAIBattleHotZoneConfigDataAsset DefaultGroupAIBattleHotZoneConfigDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!DefaultGroupAIBattleHotZoneConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:DefaultGroupAIBattleHotZoneConfigDataAsset");
				return null;
			}
			return UObjectMarshaler<BGWGroupAIBattleHotZoneConfigDataAsset>.FromNative(IntPtr.Add(base.Address, DefaultGroupAIBattleHotZoneConfigDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultGroupAIBattleHotZoneConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:DefaultGroupAIBattleHotZoneConfigDataAsset");
			}
			else
			{
				UObjectMarshaler<BGWGroupAIBattleHotZoneConfigDataAsset>.ToNative(IntPtr.Add(base.Address, DefaultGroupAIBattleHotZoneConfigDataAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("EnvAndWeather")]
	[DisplayName("默认环境效果ID")]
	[Tooltip("对应EnvironmentSurfaceEffect表格里的ID，该效果为没有Volume覆盖时的默认效果")]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:DefaultEnvironmentSurfaceEffectID")]
	public int DefaultEnvironmentSurfaceEffectID
	{
		get
		{
			CheckDestroyed();
			if (!DefaultEnvironmentSurfaceEffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:DefaultEnvironmentSurfaceEffectID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DefaultEnvironmentSurfaceEffectID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultEnvironmentSurfaceEffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:DefaultEnvironmentSurfaceEffectID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DefaultEnvironmentSurfaceEffectID_Offset), value);
			}
		}
	}

	[DisplayName("默认环境天气类型")]
	[Tooltip("天气类型：下雨，下雪etc")]
	[EditAnywhere]
	[Category("EnvAndWeather")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:DefaultWeatherType")]
	public EWeatherType DefaultWeatherType
	{
		get
		{
			CheckDestroyed();
			if (!DefaultWeatherType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:DefaultWeatherType");
				return EWeatherType.None;
			}
			return EnumMarshaler<EWeatherType>.FromNative(IntPtr.Add(base.Address, DefaultWeatherType_Offset), 0, DefaultWeatherType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DefaultWeatherType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:DefaultWeatherType");
			}
			else
			{
				EnumMarshaler<EWeatherType>.ToNative(IntPtr.Add(base.Address, DefaultWeatherType_Offset), 0, DefaultWeatherType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("进入关卡的Event")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Audio")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:EnterLevelEvent")]
	public UAkAudioEvent EnterLevelEvent
	{
		get
		{
			CheckDestroyed();
			if (!EnterLevelEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:EnterLevelEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, EnterLevelEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnterLevelEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:EnterLevelEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, EnterLevelEvent_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("退出关卡的Event")]
	[Category("Audio")]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:ExitLevelEvent")]
	public UAkAudioEvent ExitLevelEvent
	{
		get
		{
			CheckDestroyed();
			if (!ExitLevelEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:ExitLevelEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, ExitLevelEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExitLevelEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:ExitLevelEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, ExitLevelEvent_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("进入关卡Event的播放位置")]
	[UProperty]
	[Category("Audio")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:EnterLevelEventLocation")]
	public FVector EnterLevelEventLocation
	{
		get
		{
			CheckDestroyed();
			if (!EnterLevelEventLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:EnterLevelEventLocation");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, EnterLevelEventLocation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnterLevelEventLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:EnterLevelEventLocation");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, EnterLevelEventLocation_Offset), value);
			}
		}
	}

	[DisplayName("是否显示Listener")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Audio")]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:bShowListener")]
	public bool bShowListener
	{
		get
		{
			CheckDestroyed();
			if (!bShowListener_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:bShowListener");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bShowListener_Offset), 0, bShowListener_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bShowListener_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:bShowListener");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bShowListener_Offset), 0, bShowListener_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("Audio")]
	[DisplayName("是否显示衰减范围")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:bShowMaxAttentionRadius")]
	public bool bShowMaxAttentionRadius
	{
		get
		{
			CheckDestroyed();
			if (!bShowMaxAttentionRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:bShowMaxAttentionRadius");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bShowMaxAttentionRadius_Offset), 0, bShowMaxAttentionRadius_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bShowMaxAttentionRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:bShowMaxAttentionRadius");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bShowMaxAttentionRadius_Offset), 0, bShowMaxAttentionRadius_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("是否显示Object坐标轴")]
	[BlueprintReadWrite]
	[Category("Audio")]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:bShowObjectDirectionAxis")]
	public bool bShowObjectDirectionAxis
	{
		get
		{
			CheckDestroyed();
			if (!bShowObjectDirectionAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:bShowObjectDirectionAxis");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bShowObjectDirectionAxis_Offset), 0, bShowObjectDirectionAxis_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bShowObjectDirectionAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:bShowObjectDirectionAxis");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bShowObjectDirectionAxis_Offset), 0, bShowObjectDirectionAxis_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Audio")]
	[EditAnywhere]
	[DisplayName("坐标轴长度")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:AxisLength")]
	public float AxisLength
	{
		get
		{
			CheckDestroyed();
			if (!AxisLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:AxisLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AxisLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AxisLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:AxisLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AxisLength_Offset), value);
			}
		}
	}

	[DisplayName("调试信息刷新间隔(秒)")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, 0.1f)]
	[Category("Audio")]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:GameObjectRefreshInterval")]
	public float GameObjectRefreshInterval
	{
		get
		{
			CheckDestroyed();
			if (!GameObjectRefreshInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:GameObjectRefreshInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GameObjectRefreshInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GameObjectRefreshInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:GameObjectRefreshInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GameObjectRefreshInterval_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("最大显示范围(米)")]
	[UMeta(MDProp.ClampMin, 100f)]
	[Category("Audio")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:ShowObjectRangeMeter")]
	public float ShowObjectRangeMeter
	{
		get
		{
			CheckDestroyed();
			if (!ShowObjectRangeMeter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:ShowObjectRangeMeter");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShowObjectRangeMeter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShowObjectRangeMeter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:ShowObjectRangeMeter");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShowObjectRangeMeter_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Quest")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:RootQuestGraph")]
	public UCalliopeAsset RootQuestGraph
	{
		get
		{
			CheckDestroyed();
			if (!RootQuestGraph_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:RootQuestGraph");
				return null;
			}
			return UObjectMarshaler<UCalliopeAsset>.FromNative(IntPtr.Add(base.Address, RootQuestGraph_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RootQuestGraph_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:RootQuestGraph");
			}
			else
			{
				UObjectMarshaler<UCalliopeAsset>.ToNative(IntPtr.Add(base.Address, RootQuestGraph_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("Quest")]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:QuestRunDelaySeconds")]
	public float QuestRunDelaySeconds
	{
		get
		{
			CheckDestroyed();
			if (!QuestRunDelaySeconds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:QuestRunDelaySeconds");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, QuestRunDelaySeconds_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!QuestRunDelaySeconds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:QuestRunDelaySeconds");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, QuestRunDelaySeconds_Offset), value);
			}
		}
	}

	[UMeta(MDProp.RelativeToGameContentDir)]
	[Category("Niagara")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:PlayOnStartNiagaraPaths")]
	public TArrayReadWrite<FDirectoryPath> PlayOnStartNiagaraPaths
	{
		get
		{
			CheckDestroyed();
			if (!PlayOnStartNiagaraPaths_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:PlayOnStartNiagaraPaths");
				return null;
			}
			if (PlayOnStartNiagaraPaths_Marshaler == null)
			{
				PlayOnStartNiagaraPaths_Marshaler = new TArrayReadWriteMarshaler<FDirectoryPath>(1, PlayOnStartNiagaraPaths_PropertyAddress, CachedMarshalingDelegates<FDirectoryPath, FDirectoryPath>.FromNative, CachedMarshalingDelegates<FDirectoryPath, FDirectoryPath>.ToNative);
			}
			return PlayOnStartNiagaraPaths_Marshaler.FromNative(IntPtr.Add(base.Address, PlayOnStartNiagaraPaths_Offset));
		}
	}

	[Category("Niagara")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:NiagaraPlayLocation")]
	public FVector NiagaraPlayLocation
	{
		get
		{
			CheckDestroyed();
			if (!NiagaraPlayLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:NiagaraPlayLocation");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, NiagaraPlayLocation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NiagaraPlayLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:NiagaraPlayLocation");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, NiagaraPlayLocation_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("CellPatition")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:CellPatitionInsatnceConfig")]
	public TMapReadWrite<string, FGSCellPatitionInsatnceConfig> CellPatitionInsatnceConfig
	{
		get
		{
			CheckDestroyed();
			if (!CellPatitionInsatnceConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:CellPatitionInsatnceConfig");
				return null;
			}
			if (CellPatitionInsatnceConfig_Marshaler == null)
			{
				CellPatitionInsatnceConfig_Marshaler = new TMapReadWriteMarshaler<string, FGSCellPatitionInsatnceConfig>(1, CellPatitionInsatnceConfig_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FGSCellPatitionInsatnceConfig, BlittableTypeMarshaler<FGSCellPatitionInsatnceConfig>>.FromNative, CachedMarshalingDelegates<FGSCellPatitionInsatnceConfig, BlittableTypeMarshaler<FGSCellPatitionInsatnceConfig>>.ToNative);
			}
			return CellPatitionInsatnceConfig_Marshaler.FromNative(IntPtr.Add(base.Address, CellPatitionInsatnceConfig_Offset));
		}
	}

	[Category("CellPatition")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:TROCellPatitionLayerConfig")]
	public TArrayReadWrite<FGSTROConfig> TROCellPatitionLayerConfig
	{
		get
		{
			CheckDestroyed();
			if (!TROCellPatitionLayerConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:TROCellPatitionLayerConfig");
				return null;
			}
			if (TROCellPatitionLayerConfig_Marshaler == null)
			{
				TROCellPatitionLayerConfig_Marshaler = new TArrayReadWriteMarshaler<FGSTROConfig>(1, TROCellPatitionLayerConfig_PropertyAddress, CachedMarshalingDelegates<FGSTROConfig, FGSTROConfig>.FromNative, CachedMarshalingDelegates<FGSTROConfig, FGSTROConfig>.ToNative);
			}
			return TROCellPatitionLayerConfig_Marshaler.FromNative(IntPtr.Add(base.Address, TROCellPatitionLayerConfig_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("CellPatition")]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:RepGraphCellPatitionLayerConfig")]
	public TArrayReadWrite<FGSRepGraphConfig> RepGraphCellPatitionLayerConfig
	{
		get
		{
			CheckDestroyed();
			if (!RepGraphCellPatitionLayerConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:RepGraphCellPatitionLayerConfig");
				return null;
			}
			if (RepGraphCellPatitionLayerConfig_Marshaler == null)
			{
				RepGraphCellPatitionLayerConfig_Marshaler = new TArrayReadWriteMarshaler<FGSRepGraphConfig>(1, RepGraphCellPatitionLayerConfig_PropertyAddress, CachedMarshalingDelegates<FGSRepGraphConfig, FGSRepGraphConfig>.FromNative, CachedMarshalingDelegates<FGSRepGraphConfig, FGSRepGraphConfig>.ToNative);
			}
			return RepGraphCellPatitionLayerConfig_Marshaler.FromNative(IntPtr.Add(base.Address, RepGraphCellPatitionLayerConfig_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Tamer")]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:EnableLevelOverride")]
	public bool EnableLevelOverride
	{
		get
		{
			CheckDestroyed();
			if (!EnableLevelOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:EnableLevelOverride");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableLevelOverride_Offset), 0, EnableLevelOverride_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableLevelOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:EnableLevelOverride");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableLevelOverride_Offset), 0, EnableLevelOverride_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Tamer")]
	[UMeta(MDProp.EditCondition, "EnableLevelOverride")]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:TamerSettingConfigDataAsset")]
	public BGWTamerSettingConfigDataAsset TamerSettingConfigDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!TamerSettingConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:TamerSettingConfigDataAsset");
				return null;
			}
			return UObjectMarshaler<BGWTamerSettingConfigDataAsset>.FromNative(IntPtr.Add(base.Address, TamerSettingConfigDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TamerSettingConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_WorldSettings:TamerSettingConfigDataAsset");
			}
			else
			{
				UObjectMarshaler<BGWTamerSettingConfigDataAsset>.ToNative(IntPtr.Add(base.Address, TamerSettingConfigDataAsset_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		QuestRunDelaySeconds = 1f;
		bShowListener = false;
		bShowMaxAttentionRadius = false;
		bShowObjectDirectionAxis = true;
		GameObjectRefreshInterval = 1f;
		AxisLength = 100f;
		ShowObjectRangeMeter = 200f;
	}

	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:ReceiveDestroyed")]
	protected override void ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGW_WorldSettings:OnLevelPreSave")]
	private void OnLevelPreSave(ULevel Level, UWorld World)
	{
		BGW_QuickCookGenerator.StoreLevelActorsLoadList(Level, World);
		BUCircusBase[] allActorsOfClass = World.GetAllActorsOfClass<BUCircusBase>();
		for (int i = 0; i < allActorsOfClass.Length; i++)
		{
			allActorsOfClass[i].CollectRelativeTamerData();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_WorldSettings:OnLevelPreSave")]
	private static void OnLevelPreSave__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_WorldSettings bGW_WorldSettings = GCHelper.Find<BGW_WorldSettings>(obj);
		ULevel level = UObjectMarshaler<ULevel>.FromNative(IntPtr.Add(buffer, OnLevelPreSave_Level_Offset));
		UWorld world = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, OnLevelPreSave_World_Offset));
		bGW_WorldSettings.OnLevelPreSave(level, world);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_WorldSettings:ReceiveDestroyed")]
	private static void ReceiveDestroyed__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_WorldSettings bGW_WorldSettings = GCHelper.Find<BGW_WorldSettings>(obj);
		bGW_WorldSettings.ReceiveDestroyed_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_WorldSettings");
		DefaultGroupAIMgrConfigDataAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultGroupAIMgrConfigDataAsset");
		DefaultGroupAIMgrConfigDataAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultGroupAIMgrConfigDataAsset", Classes.FObjectProperty);
		DefaultGroupAIBattleHotZoneConfigDataAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultGroupAIBattleHotZoneConfigDataAsset");
		DefaultGroupAIBattleHotZoneConfigDataAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultGroupAIBattleHotZoneConfigDataAsset", Classes.FObjectProperty);
		DefaultEnvironmentSurfaceEffectID_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultEnvironmentSurfaceEffectID");
		DefaultEnvironmentSurfaceEffectID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultEnvironmentSurfaceEffectID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref DefaultWeatherType_PropertyAddress, intPtr, "DefaultWeatherType");
		DefaultWeatherType_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultWeatherType");
		DefaultWeatherType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultWeatherType", Classes.FEnumProperty);
		EnterLevelEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnterLevelEvent");
		EnterLevelEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnterLevelEvent", Classes.FObjectProperty);
		ExitLevelEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExitLevelEvent");
		ExitLevelEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExitLevelEvent", Classes.FObjectProperty);
		EnterLevelEventLocation_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnterLevelEventLocation");
		EnterLevelEventLocation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnterLevelEventLocation", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bShowListener_PropertyAddress, intPtr, "bShowListener");
		bShowListener_Offset = NativeReflection.GetPropertyOffset(intPtr, "bShowListener");
		bShowListener_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bShowListener", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bShowMaxAttentionRadius_PropertyAddress, intPtr, "bShowMaxAttentionRadius");
		bShowMaxAttentionRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "bShowMaxAttentionRadius");
		bShowMaxAttentionRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bShowMaxAttentionRadius", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bShowObjectDirectionAxis_PropertyAddress, intPtr, "bShowObjectDirectionAxis");
		bShowObjectDirectionAxis_Offset = NativeReflection.GetPropertyOffset(intPtr, "bShowObjectDirectionAxis");
		bShowObjectDirectionAxis_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bShowObjectDirectionAxis", Classes.FBoolProperty);
		AxisLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "AxisLength");
		AxisLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AxisLength", Classes.FFloatProperty);
		GameObjectRefreshInterval_Offset = NativeReflection.GetPropertyOffset(intPtr, "GameObjectRefreshInterval");
		GameObjectRefreshInterval_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GameObjectRefreshInterval", Classes.FFloatProperty);
		ShowObjectRangeMeter_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShowObjectRangeMeter");
		ShowObjectRangeMeter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShowObjectRangeMeter", Classes.FFloatProperty);
		RootQuestGraph_Offset = NativeReflection.GetPropertyOffset(intPtr, "RootQuestGraph");
		RootQuestGraph_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RootQuestGraph", Classes.FObjectProperty);
		QuestRunDelaySeconds_Offset = NativeReflection.GetPropertyOffset(intPtr, "QuestRunDelaySeconds");
		QuestRunDelaySeconds_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "QuestRunDelaySeconds", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref PlayOnStartNiagaraPaths_PropertyAddress, intPtr, "PlayOnStartNiagaraPaths");
		PlayOnStartNiagaraPaths_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayOnStartNiagaraPaths");
		PlayOnStartNiagaraPaths_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayOnStartNiagaraPaths", Classes.FArrayProperty);
		NiagaraPlayLocation_Offset = NativeReflection.GetPropertyOffset(intPtr, "NiagaraPlayLocation");
		NiagaraPlayLocation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NiagaraPlayLocation", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CellPatitionInsatnceConfig_PropertyAddress, intPtr, "CellPatitionInsatnceConfig");
		CellPatitionInsatnceConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "CellPatitionInsatnceConfig");
		CellPatitionInsatnceConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CellPatitionInsatnceConfig", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref TROCellPatitionLayerConfig_PropertyAddress, intPtr, "TROCellPatitionLayerConfig");
		TROCellPatitionLayerConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "TROCellPatitionLayerConfig");
		TROCellPatitionLayerConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TROCellPatitionLayerConfig", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref RepGraphCellPatitionLayerConfig_PropertyAddress, intPtr, "RepGraphCellPatitionLayerConfig");
		RepGraphCellPatitionLayerConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "RepGraphCellPatitionLayerConfig");
		RepGraphCellPatitionLayerConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RepGraphCellPatitionLayerConfig", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref EnableLevelOverride_PropertyAddress, intPtr, "EnableLevelOverride");
		EnableLevelOverride_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableLevelOverride");
		EnableLevelOverride_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableLevelOverride", Classes.FBoolProperty);
		TamerSettingConfigDataAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "TamerSettingConfigDataAsset");
		TamerSettingConfigDataAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TamerSettingConfigDataAsset", Classes.FObjectProperty);
		OnLevelPreSave_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnLevelPreSave");
		OnLevelPreSave_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLevelPreSave_FunctionAddress);
		OnLevelPreSave_Level_Offset = NativeReflection.GetPropertyOffset(OnLevelPreSave_FunctionAddress, "Level");
		OnLevelPreSave_Level_IsValid = NativeReflection.ValidatePropertyClass(OnLevelPreSave_FunctionAddress, "Level", Classes.FObjectProperty);
		OnLevelPreSave_World_Offset = NativeReflection.GetPropertyOffset(OnLevelPreSave_FunctionAddress, "World");
		OnLevelPreSave_World_IsValid = NativeReflection.ValidatePropertyClass(OnLevelPreSave_FunctionAddress, "World", Classes.FObjectProperty);
		OnLevelPreSave_IsValid = OnLevelPreSave_FunctionAddress != IntPtr.Zero && OnLevelPreSave_Level_IsValid && OnLevelPreSave_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_WorldSettings:OnLevelPreSave", OnLevelPreSave_IsValid);
		ReceiveDestroyed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveDestroyed");
		ReceiveDestroyed_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveDestroyed_FunctionAddress);
		ReceiveDestroyed_IsValid = ReceiveDestroyed_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_WorldSettings:ReceiveDestroyed", ReceiveDestroyed_IsValid);
	}

	static BGW_WorldSettings()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_WorldSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_WorldSettings));
	}
}
