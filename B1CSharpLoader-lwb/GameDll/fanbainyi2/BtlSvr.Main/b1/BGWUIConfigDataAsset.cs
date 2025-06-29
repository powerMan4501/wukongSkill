using System;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset")]
public class BGWUIConfigDataAsset : UBGWDataAsset
{
	private static bool DropFirstShowDelayTime_IsValid;

	private static int DropFirstShowDelayTime_Offset;

	private static bool DropShowTime_IsValid;

	private static int DropShowTime_Offset;

	private static bool DropMinShowTime_IsValid;

	private static int DropMinShowTime_Offset;

	private static bool DropInFuncShowTime_IsValid;

	private static int DropInFuncShowTime_Offset;

	private static bool DropAdvanceShowTime_IsValid;

	private static int DropAdvanceShowTime_Offset;

	private static bool DropAdvanceMinShowTime_IsValid;

	private static int DropAdvanceMinShowTime_Offset;

	private static bool DropInFuncAdvanceShowTime_IsValid;

	private static int DropInFuncAdvanceShowTime_Offset;

	private static bool DropManualShowTime_IsValid;

	private static int DropManualShowTime_Offset;

	private static bool DropAdvanceJumpTime_IsValid;

	private static int DropAdvanceJumpTime_Offset;

	private static bool DropSpecialTipsShowTime_IsValid;

	private static int DropSpecialTipsShowTime_Offset;

	private static bool DropSpecialShowTime_IsValid;

	private static int DropSpecialShowTime_Offset;

	private static bool ExpShowTime_IsValid;

	private static int ExpShowTime_Offset;

	private static bool ExpMultiShowTime_IsValid;

	private static int ExpMultiShowTime_Offset;

	private static bool DropMuseumShowTime_IsValid;

	private static int DropMuseumShowTime_Offset;

	private static bool ShortcutActiveDelayTime_IsValid;

	private static int ShortcutActiveDelayTime_Offset;

	private static bool ShortcutDetailActiveDelayTime_IsValid;

	private static int ShortcutDetailActiveDelayTime_Offset;

	private static bool ShortcutItemNudge_IsValid;

	private static int ShortcutItemNudge_Offset;

	private static bool StToNrDelayTime_IsValid;

	private static int StToNrDelayTime_Offset;

	private static bool StToNrEasingTime_IsValid;

	private static int StToNrEasingTime_Offset;

	private static bool NrToStDelayTime_IsValid;

	private static int NrToStDelayTime_Offset;

	private static bool NrToStEasingTime_IsValid;

	private static int NrToStEasingTime_Offset;

	private static bool ShortcutSpellSort_IsValid;

	private static int ShortcutSpellSort_Offset;

	private static FFieldAddress ShortcutSpellSort_PropertyAddress;

	private TArrayReadWriteMarshaler<SpellType> ShortcutSpellSort_Marshaler;

	private static bool ShowProtectTime_IsValid;

	private static int ShowProtectTime_Offset;

	private static bool BattleMainFadeTime_IsValid;

	private static int BattleMainFadeTime_Offset;

	private static bool InSeqShowProtectTime_IsValid;

	private static int InSeqShowProtectTime_Offset;

	private static bool InSeqBattleMainFadeTime_IsValid;

	private static int InSeqBattleMainFadeTime_Offset;

	private static bool ActionMappingList_IsValid;

	private static int ActionMappingList_Offset;

	private static FFieldAddress ActionMappingList_PropertyAddress;

	private TArrayReadWriteMarshaler<string> ActionMappingList_Marshaler;

	private static bool ShortcutSpellAction_IsValid;

	private static int ShortcutSpellAction_Offset;

	private static bool ShortcutItemAction_IsValid;

	private static int ShortcutItemAction_Offset;

	private static bool HPLowPostProcessPercent_IsValid;

	private static int HPLowPostProcessPercent_Offset;

	private static bool HPLimitPostProcessPercent_IsValid;

	private static int HPLimitPostProcessPercent_Offset;

	private static bool HPLowPostProcessSliderFreq_IsValid;

	private static int HPLowPostProcessSliderFreq_Offset;

	private static bool HPLimitPostProcessSliderFreq_IsValid;

	private static int HPLimitPostProcessSliderFreq_Offset;

	private static bool HPLimitPostProcessAudioTime_IsValid;

	private static int HPLimitPostProcessAudioTime_Offset;

	private static bool HPPostProcessStopUIList_IsValid;

	private static int HPPostProcessStopUIList_Offset;

	private static FFieldAddress HPPostProcessStopUIList_PropertyAddress;

	private TArrayReadWriteMarshaler<EUIPageType> HPPostProcessStopUIList_Marshaler;

	private static bool StylePoseMPC_IsValid;

	private static int StylePoseMPC_Offset;

	private static bool ProgBaseTexSizeV1_IsValid;

	private static int ProgBaseTexSizeV1_Offset;

	private static bool ProgBaseTexSizeV2_IsValid;

	private static int ProgBaseTexSizeV2_Offset;

	private static bool ProgBaseTexSizeV3_IsValid;

	private static int ProgBaseTexSizeV3_Offset;

	private static bool ProgPercentSplite_IsValid;

	private static int ProgPercentSplite_Offset;

	private static bool DBBInputHPPre_IsValid;

	private static int DBBInputHPPre_Offset;

	private static bool HpDefaultMap_IsValid;

	private static int HpDefaultMap_Offset;

	private static FFieldAddress HpDefaultMap_PropertyAddress;

	private TMapReadWriteMarshaler<int, float> HpDefaultMap_Marshaler;

	private static bool ProcBarConfigMap_IsValid;

	private static int ProcBarConfigMap_Offset;

	private static FFieldAddress ProcBarConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<int, FProcBarConfig> ProcBarConfigMap_Marshaler;

	private static bool CloudMoveTipsDelayTime_IsValid;

	private static int CloudMoveTipsDelayTime_Offset;

	private static bool SeqSkipLongPressTime_IsValid;

	private static int SeqSkipLongPressTime_Offset;

	private static bool SeqSkipFadeTime_IsValid;

	private static int SeqSkipFadeTime_Offset;

	private static bool ProgLevelResIDList_IsValid;

	private static int ProgLevelResIDList_Offset;

	private static FFieldAddress ProgLevelResIDList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> ProgLevelResIDList_Marshaler;

	private static bool HideMouseCheckTime_IsValid;

	private static int HideMouseCheckTime_Offset;

	private static bool BasePixelHeight_IsValid;

	private static int BasePixelHeight_Offset;

	private static bool BaselineOffset_IsValid;

	private static int BaselineOffset_Offset;

	private static bool ConnectIconOffset_IsValid;

	private static int ConnectIconOffset_Offset;

	private static bool MenuSwitchStartTime_IsValid;

	private static int MenuSwitchStartTime_Offset;

	private static bool MenuSwitchCheckTime_IsValid;

	private static int MenuSwitchCheckTime_Offset;

	private static bool FirstSwitchThreshold_IsValid;

	private static int FirstSwitchThreshold_Offset;

	private static bool RepeatSwitchThreshold_IsValid;

	private static int RepeatSwitchThreshold_Offset;

	private static bool SelectedDelayTime_IsValid;

	private static int SelectedDelayTime_Offset;

	private static bool UIFXMPC_IsValid;

	private static int UIFXMPC_Offset;

	private static bool UIGlobalMPC_IsValid;

	private static int UIGlobalMPC_Offset;

	private static bool TeleportAKBPicSwitchDelayTime_IsValid;

	private static int TeleportAKBPicSwitchDelayTime_Offset;

	private static bool CastEnergyLevel_IsValid;

	private static int CastEnergyLevel_Offset;

	private static FFieldAddress CastEnergyLevel_PropertyAddress;

	private TArrayReadWriteMarshaler<float> CastEnergyLevel_Marshaler;

	private static bool AchieveTipsShowTime_IsValid;

	private static int AchieveTipsShowTime_Offset;

	private static bool TileItemConfig_IsValid;

	private static int TileItemConfig_Offset;

	private static FFieldAddress TileItemConfig_PropertyAddress;

	private TMapReadWriteMarshaler<ETileItemScene, FTileItemConfig> TileItemConfig_Marshaler;

	private static bool LoginNoticeIsCanSkip_IsValid;

	private static int LoginNoticeIsCanSkip_Offset;

	private static FFieldAddress LoginNoticeIsCanSkip_PropertyAddress;

	private static bool TalentAllResetLongPressTime_IsValid;

	private static int TalentAllResetLongPressTime_Offset;

	private static bool TalentTabResetLongPressTime_IsValid;

	private static int TalentTabResetLongPressTime_Offset;

	private static bool LegacyMouseAreaDelayCheckTime_IsValid;

	private static int LegacyMouseAreaDelayCheckTime_Offset;

	private static bool SliderDelayInputGap_IsValid;

	private static int SliderDelayInputGap_Offset;

	private static bool UseHoverSelected_IsValid;

	private static int UseHoverSelected_Offset;

	private static FFieldAddress UseHoverSelected_PropertyAddress;

	private static bool SettingHpConfig_IsValid;

	private static int SettingHpConfig_Offset;

	private static FFieldAddress SettingHpConfig_PropertyAddress;

	private TArrayReadWriteMarshaler<FSettingHpConfig> SettingHpConfig_Marshaler;

	private static bool InputTipsConfig_IsValid;

	private static int InputTipsConfig_Offset;

	private static FFieldAddress InputTipsConfig_PropertyAddress;

	private TMapReadWriteMarshaler<EUIPageType, FInputTipsLeftRightCfg> InputTipsConfig_Marshaler;

	private static bool DelaySkippableTime_IsValid;

	private static int DelaySkippableTime_Offset;

	private static bool MediaClampTimeMap_IsValid;

	private static int MediaClampTimeMap_Offset;

	private static FFieldAddress MediaClampTimeMap_PropertyAddress;

	private TMapReadWriteMarshaler<int, FVector2D> MediaClampTimeMap_Marshaler;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("掉落UI")]
	[DisplayName("初次显示掉落UI延迟显示时间")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:DropFirstShowDelayTime")]
	public float DropFirstShowDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!DropFirstShowDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropFirstShowDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DropFirstShowDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropFirstShowDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropFirstShowDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DropFirstShowDelayTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("掉落显示时间")]
	[Category("掉落UI|普通掉落")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:DropShowTime")]
	public float DropShowTime
	{
		get
		{
			CheckDestroyed();
			if (!DropShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropShowTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DropShowTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropShowTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DropShowTime_Offset), value);
			}
		}
	}

	[Category("掉落UI|普通掉落")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("掉落Min显示时间")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:DropMinShowTime")]
	public float DropMinShowTime
	{
		get
		{
			CheckDestroyed();
			if (!DropMinShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropMinShowTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DropMinShowTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropMinShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropMinShowTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DropMinShowTime_Offset), value);
			}
		}
	}

	[Category("掉落UI|普通掉落")]
	[DisplayName("掉落在功能界面时显示时间")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:DropInFuncShowTime")]
	public float DropInFuncShowTime
	{
		get
		{
			CheckDestroyed();
			if (!DropInFuncShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropInFuncShowTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DropInFuncShowTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropInFuncShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropInFuncShowTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DropInFuncShowTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("高级掉落显示时间")]
	[BlueprintReadWrite]
	[Category("掉落UI|高级掉落")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:DropAdvanceShowTime")]
	public float DropAdvanceShowTime
	{
		get
		{
			CheckDestroyed();
			if (!DropAdvanceShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropAdvanceShowTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DropAdvanceShowTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropAdvanceShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropAdvanceShowTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DropAdvanceShowTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("掉落UI|高级掉落")]
	[DisplayName("高级掉落Min显示时间")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:DropAdvanceMinShowTime")]
	public float DropAdvanceMinShowTime
	{
		get
		{
			CheckDestroyed();
			if (!DropAdvanceMinShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropAdvanceMinShowTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DropAdvanceMinShowTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropAdvanceMinShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropAdvanceMinShowTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DropAdvanceMinShowTime_Offset), value);
			}
		}
	}

	[DisplayName("高级掉落在功能界面时显示时间")]
	[BlueprintReadWrite]
	[Category("掉落UI|高级掉落")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:DropInFuncAdvanceShowTime")]
	public float DropInFuncAdvanceShowTime
	{
		get
		{
			CheckDestroyed();
			if (!DropInFuncAdvanceShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropInFuncAdvanceShowTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DropInFuncAdvanceShowTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropInFuncAdvanceShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropInFuncAdvanceShowTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DropInFuncAdvanceShowTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("掉落UI|高级掉落")]
	[DisplayName("游记掉落显示时间")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:DropManualShowTime")]
	public float DropManualShowTime
	{
		get
		{
			CheckDestroyed();
			if (!DropManualShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropManualShowTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DropManualShowTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropManualShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropManualShowTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DropManualShowTime_Offset), value);
			}
		}
	}

	[DisplayName("高级掉落长按跳转时间")]
	[Category("掉落UI|高级掉落")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:DropAdvanceJumpTime")]
	public float DropAdvanceJumpTime
	{
		get
		{
			CheckDestroyed();
			if (!DropAdvanceJumpTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropAdvanceJumpTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DropAdvanceJumpTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropAdvanceJumpTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropAdvanceJumpTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DropAdvanceJumpTime_Offset), value);
			}
		}
	}

	[Category("掉落UI|特殊掉落Tips")]
	[DisplayName("特殊掉落Tips显示时间")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:DropSpecialTipsShowTime")]
	public float DropSpecialTipsShowTime
	{
		get
		{
			CheckDestroyed();
			if (!DropSpecialTipsShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropSpecialTipsShowTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DropSpecialTipsShowTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropSpecialTipsShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropSpecialTipsShowTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DropSpecialTipsShowTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("特殊掉落显示时间")]
	[UProperty]
	[BlueprintReadWrite]
	[Category("掉落UI|特殊掉落")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:DropSpecialShowTime")]
	public float DropSpecialShowTime
	{
		get
		{
			CheckDestroyed();
			if (!DropSpecialShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropSpecialShowTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DropSpecialShowTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropSpecialShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropSpecialShowTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DropSpecialShowTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("掉落UI|经验条")]
	[DisplayName("经验条停留时间")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:ExpShowTime")]
	public float ExpShowTime
	{
		get
		{
			CheckDestroyed();
			if (!ExpShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ExpShowTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ExpShowTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExpShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ExpShowTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ExpShowTime_Offset), value);
			}
		}
	}

	[Category("掉落UI|经验条")]
	[DisplayName("连续经验条停留时间")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:ExpMultiShowTime")]
	public float ExpMultiShowTime
	{
		get
		{
			CheckDestroyed();
			if (!ExpMultiShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ExpMultiShowTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ExpMultiShowTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExpMultiShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ExpMultiShowTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ExpMultiShowTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("掉落UI|博物馆")]
	[DisplayName("博物馆掉落显示时间")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:DropMuseumShowTime")]
	public float DropMuseumShowTime
	{
		get
		{
			CheckDestroyed();
			if (!DropMuseumShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropMuseumShowTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DropMuseumShowTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropMuseumShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DropMuseumShowTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DropMuseumShowTime_Offset), value);
			}
		}
	}

	[DisplayName("组合键UI激活等待时间")]
	[Category("快捷栏UI")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:ShortcutActiveDelayTime")]
	public float ShortcutActiveDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!ShortcutActiveDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ShortcutActiveDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShortcutActiveDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShortcutActiveDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ShortcutActiveDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShortcutActiveDelayTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("快捷栏UI")]
	[DisplayName("组合键UI激活等待时间(详情)")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:ShortcutDetailActiveDelayTime")]
	public float ShortcutDetailActiveDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!ShortcutDetailActiveDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ShortcutDetailActiveDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShortcutDetailActiveDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShortcutDetailActiveDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ShortcutDetailActiveDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShortcutDetailActiveDelayTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("快捷栏UI")]
	[DisplayName("道具切换Nudge")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:ShortcutItemNudge")]
	public float ShortcutItemNudge
	{
		get
		{
			CheckDestroyed();
			if (!ShortcutItemNudge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ShortcutItemNudge");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShortcutItemNudge_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShortcutItemNudge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ShortcutItemNudge");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShortcutItemNudge_Offset), value);
			}
		}
	}

	[Category("快捷栏UI")]
	[DisplayName("St > Nr 延迟时间")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:StToNrDelayTime")]
	public float StToNrDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!StToNrDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:StToNrDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StToNrDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StToNrDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:StToNrDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StToNrDelayTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("快捷栏UI")]
	[DisplayName("St > Nr Easing时间")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:StToNrEasingTime")]
	public float StToNrEasingTime
	{
		get
		{
			CheckDestroyed();
			if (!StToNrEasingTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:StToNrEasingTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StToNrEasingTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StToNrEasingTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:StToNrEasingTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StToNrEasingTime_Offset), value);
			}
		}
	}

	[DisplayName("Nr > St 延迟时间")]
	[Category("快捷栏UI")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:NrToStDelayTime")]
	public float NrToStDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!NrToStDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:NrToStDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NrToStDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NrToStDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:NrToStDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NrToStDelayTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("快捷栏UI")]
	[DisplayName("Nr > St Easing时间")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:NrToStEasingTime")]
	public float NrToStEasingTime
	{
		get
		{
			CheckDestroyed();
			if (!NrToStEasingTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:NrToStEasingTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NrToStEasingTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NrToStEasingTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:NrToStEasingTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NrToStEasingTime_Offset), value);
			}
		}
	}

	[DisplayName("快捷栏法术排序")]
	[Category("快捷栏UI")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:ShortcutSpellSort")]
	public TArrayReadWrite<SpellType> ShortcutSpellSort
	{
		get
		{
			CheckDestroyed();
			if (!ShortcutSpellSort_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ShortcutSpellSort");
				return null;
			}
			if (ShortcutSpellSort_Marshaler == null)
			{
				ShortcutSpellSort_Marshaler = new TArrayReadWriteMarshaler<SpellType>(1, ShortcutSpellSort_PropertyAddress, CachedMarshalingDelegates<SpellType, EnumMarshaler<SpellType>>.FromNative, CachedMarshalingDelegates<SpellType, EnumMarshaler<SpellType>>.ToNative);
			}
			return ShortcutSpellSort_Marshaler.FromNative(IntPtr.Add(base.Address, ShortcutSpellSort_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("战斗主界面UI")]
	[DisplayName("进入隐藏状态的保护时间")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:ShowProtectTime")]
	public float ShowProtectTime
	{
		get
		{
			CheckDestroyed();
			if (!ShowProtectTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ShowProtectTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShowProtectTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShowProtectTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ShowProtectTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShowProtectTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("战斗主界面UI")]
	[DisplayName("显隐时间")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:BattleMainFadeTime")]
	public float BattleMainFadeTime
	{
		get
		{
			CheckDestroyed();
			if (!BattleMainFadeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:BattleMainFadeTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BattleMainFadeTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BattleMainFadeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:BattleMainFadeTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BattleMainFadeTime_Offset), value);
			}
		}
	}

	[Category("战斗主界面UI")]
	[DisplayName("进入隐藏状态的保护时间(Seq中)")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:InSeqShowProtectTime")]
	public float InSeqShowProtectTime
	{
		get
		{
			CheckDestroyed();
			if (!InSeqShowProtectTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:InSeqShowProtectTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InSeqShowProtectTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InSeqShowProtectTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:InSeqShowProtectTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InSeqShowProtectTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("战斗主界面UI")]
	[DisplayName("显隐时间(Seq中)")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:InSeqBattleMainFadeTime")]
	public float InSeqBattleMainFadeTime
	{
		get
		{
			CheckDestroyed();
			if (!InSeqBattleMainFadeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:InSeqBattleMainFadeTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InSeqBattleMainFadeTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InSeqBattleMainFadeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:InSeqBattleMainFadeTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InSeqBattleMainFadeTime_Offset), value);
			}
		}
	}

	[DisplayName("需要响应主界面显示的输入Action")]
	[Category("战斗主界面UI")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:ActionMappingList")]
	public TArrayReadWrite<string> ActionMappingList
	{
		get
		{
			CheckDestroyed();
			if (!ActionMappingList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ActionMappingList");
				return null;
			}
			if (ActionMappingList_Marshaler == null)
			{
				ActionMappingList_Marshaler = new TArrayReadWriteMarshaler<string>(1, ActionMappingList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return ActionMappingList_Marshaler.FromNative(IntPtr.Add(base.Address, ActionMappingList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("战斗主界面UI")]
	[DisplayName("激活法术快捷UI的输入Action")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:ShortcutSpellAction")]
	public string ShortcutSpellAction
	{
		get
		{
			CheckDestroyed();
			if (!ShortcutSpellAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ShortcutSpellAction");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, ShortcutSpellAction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShortcutSpellAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ShortcutSpellAction");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, ShortcutSpellAction_Offset), value);
			}
		}
	}

	[DisplayName("激活物品快捷UI的输入Action")]
	[Category("战斗主界面UI")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:ShortcutItemAction")]
	public string ShortcutItemAction
	{
		get
		{
			CheckDestroyed();
			if (!ShortcutItemAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ShortcutItemAction");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, ShortcutItemAction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShortcutItemAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ShortcutItemAction");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, ShortcutItemAction_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("战斗主界面UI|后处理")]
	[DisplayName("血量后处理血量百分比(Low)")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:HPLowPostProcessPercent")]
	public float HPLowPostProcessPercent
	{
		get
		{
			CheckDestroyed();
			if (!HPLowPostProcessPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:HPLowPostProcessPercent");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HPLowPostProcessPercent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HPLowPostProcessPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:HPLowPostProcessPercent");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HPLowPostProcessPercent_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("战斗主界面UI|后处理")]
	[DisplayName("血量后处理血量百分比(Limit)")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:HPLimitPostProcessPercent")]
	public float HPLimitPostProcessPercent
	{
		get
		{
			CheckDestroyed();
			if (!HPLimitPostProcessPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:HPLimitPostProcessPercent");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HPLimitPostProcessPercent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HPLimitPostProcessPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:HPLimitPostProcessPercent");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HPLimitPostProcessPercent_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("血量后处理(Low)SliderFreq")]
	[Category("战斗主界面UI|后处理")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:HPLowPostProcessSliderFreq")]
	public float HPLowPostProcessSliderFreq
	{
		get
		{
			CheckDestroyed();
			if (!HPLowPostProcessSliderFreq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:HPLowPostProcessSliderFreq");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HPLowPostProcessSliderFreq_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HPLowPostProcessSliderFreq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:HPLowPostProcessSliderFreq");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HPLowPostProcessSliderFreq_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("战斗主界面UI|后处理")]
	[DisplayName("血量后处理(Limit)SliderFreq")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:HPLimitPostProcessSliderFreq")]
	public float HPLimitPostProcessSliderFreq
	{
		get
		{
			CheckDestroyed();
			if (!HPLimitPostProcessSliderFreq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:HPLimitPostProcessSliderFreq");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HPLimitPostProcessSliderFreq_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HPLimitPostProcessSliderFreq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:HPLimitPostProcessSliderFreq");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HPLimitPostProcessSliderFreq_Offset), value);
			}
		}
	}

	[DisplayName("血量后处理(Limit)音效持续时间")]
	[Category("战斗主界面UI|后处理")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:HPLimitPostProcessAudioTime")]
	public float HPLimitPostProcessAudioTime
	{
		get
		{
			CheckDestroyed();
			if (!HPLimitPostProcessAudioTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:HPLimitPostProcessAudioTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HPLimitPostProcessAudioTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HPLimitPostProcessAudioTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:HPLimitPostProcessAudioTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HPLimitPostProcessAudioTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("战斗主界面UI|后处理")]
	[DisplayName("血量后处理效果UI屏蔽列表")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:HPPostProcessStopUIList")]
	public TArrayReadWrite<EUIPageType> HPPostProcessStopUIList
	{
		get
		{
			CheckDestroyed();
			if (!HPPostProcessStopUIList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:HPPostProcessStopUIList");
				return null;
			}
			if (HPPostProcessStopUIList_Marshaler == null)
			{
				HPPostProcessStopUIList_Marshaler = new TArrayReadWriteMarshaler<EUIPageType>(1, HPPostProcessStopUIList_PropertyAddress, CachedMarshalingDelegates<EUIPageType, EnumMarshaler<EUIPageType>>.FromNative, CachedMarshalingDelegates<EUIPageType, EnumMarshaler<EUIPageType>>.ToNative);
			}
			return HPPostProcessStopUIList_Marshaler.FromNative(IntPtr.Add(base.Address, HPPostProcessStopUIList_Offset));
		}
	}

	[DisplayName("架势MPC")]
	[Category("战斗主界面UI")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:StylePoseMPC")]
	public UMaterialParameterCollection StylePoseMPC
	{
		get
		{
			CheckDestroyed();
			if (!StylePoseMPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:StylePoseMPC");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, StylePoseMPC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StylePoseMPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:StylePoseMPC");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, StylePoseMPC_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("战斗主界面UI|架势")]
	[DisplayName("架势ProgBaseV1")]
	[Tooltip("1-3级棍势长度")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:ProgBaseTexSizeV1")]
	public float ProgBaseTexSizeV1
	{
		get
		{
			CheckDestroyed();
			if (!ProgBaseTexSizeV1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ProgBaseTexSizeV1");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ProgBaseTexSizeV1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProgBaseTexSizeV1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ProgBaseTexSizeV1");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ProgBaseTexSizeV1_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("战斗主界面UI|架势")]
	[DisplayName("架势ProgBaseV2")]
	[Tooltip("4级棍势长度")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:ProgBaseTexSizeV2")]
	public float ProgBaseTexSizeV2
	{
		get
		{
			CheckDestroyed();
			if (!ProgBaseTexSizeV2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ProgBaseTexSizeV2");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ProgBaseTexSizeV2_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProgBaseTexSizeV2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ProgBaseTexSizeV2");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ProgBaseTexSizeV2_Offset), value);
			}
		}
	}

	[Tooltip("5级棍势长度")]
	[DisplayName("架势ProgBaseV3")]
	[Category("战斗主界面UI|架势")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:ProgBaseTexSizeV3")]
	public float ProgBaseTexSizeV3
	{
		get
		{
			CheckDestroyed();
			if (!ProgBaseTexSizeV3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ProgBaseTexSizeV3");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ProgBaseTexSizeV3_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProgBaseTexSizeV3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ProgBaseTexSizeV3");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ProgBaseTexSizeV3_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("战斗主界面UI|架势")]
	[DisplayName("架势4段棍在5段棍中分割百分比")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:ProgPercentSplite")]
	public float ProgPercentSplite
	{
		get
		{
			CheckDestroyed();
			if (!ProgPercentSplite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ProgPercentSplite");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ProgPercentSplite_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProgPercentSplite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ProgPercentSplite");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ProgPercentSplite_Offset), value);
			}
		}
	}

	[DisplayName("显示喝药按键的血量百分比")]
	[Category("战斗主界面UI|PlayerBar")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:DBBInputHPPre")]
	public float DBBInputHPPre
	{
		get
		{
			CheckDestroyed();
			if (!DBBInputHPPre_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DBBInputHPPre");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DBBInputHPPre_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DBBInputHPPre_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DBBInputHPPre");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DBBInputHPPre_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("战斗主界面UI|血条配置")]
	[DisplayName("ResId/Hp映射表")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:HpDefaultMap")]
	public TMapReadWrite<int, float> HpDefaultMap
	{
		get
		{
			CheckDestroyed();
			if (!HpDefaultMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:HpDefaultMap");
				return null;
			}
			if (HpDefaultMap_Marshaler == null)
			{
				HpDefaultMap_Marshaler = new TMapReadWriteMarshaler<int, float>(1, HpDefaultMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return HpDefaultMap_Marshaler.FromNative(IntPtr.Add(base.Address, HpDefaultMap_Offset));
		}
	}

	[DisplayName("ResId/Config映射表")]
	[Category("战斗主界面UI|进度条配置")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:ProcBarConfigMap")]
	public TMapReadWrite<int, FProcBarConfig> ProcBarConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!ProcBarConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ProcBarConfigMap");
				return null;
			}
			if (ProcBarConfigMap_Marshaler == null)
			{
				ProcBarConfigMap_Marshaler = new TMapReadWriteMarshaler<int, FProcBarConfig>(1, ProcBarConfigMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FProcBarConfig, BlittableTypeMarshaler<FProcBarConfig>>.FromNative, CachedMarshalingDelegates<FProcBarConfig, BlittableTypeMarshaler<FProcBarConfig>>.ToNative);
			}
			return ProcBarConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, ProcBarConfigMap_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("战斗主界面UI")]
	[DisplayName("筋斗云提示延迟时间")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:CloudMoveTipsDelayTime")]
	public float CloudMoveTipsDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!CloudMoveTipsDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:CloudMoveTipsDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CloudMoveTipsDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudMoveTipsDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:CloudMoveTipsDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CloudMoveTipsDelayTime_Offset), value);
			}
		}
	}

	[DisplayName("长按跳过时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Seq跳过界面UI")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:SeqSkipLongPressTime")]
	public float SeqSkipLongPressTime
	{
		get
		{
			CheckDestroyed();
			if (!SeqSkipLongPressTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:SeqSkipLongPressTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SeqSkipLongPressTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SeqSkipLongPressTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:SeqSkipLongPressTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SeqSkipLongPressTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Seq跳过界面UI")]
	[DisplayName("隐藏时间")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:SeqSkipFadeTime")]
	public float SeqSkipFadeTime
	{
		get
		{
			CheckDestroyed();
			if (!SeqSkipFadeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:SeqSkipFadeTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SeqSkipFadeTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SeqSkipFadeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:SeqSkipFadeTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SeqSkipFadeTime_Offset), value);
			}
		}
	}

	[DisplayName("特殊能量进度条Level ResIDList")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("变身界面UI")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:ProgLevelResIDList")]
	public TArrayReadWrite<int> ProgLevelResIDList
	{
		get
		{
			CheckDestroyed();
			if (!ProgLevelResIDList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ProgLevelResIDList");
				return null;
			}
			if (ProgLevelResIDList_Marshaler == null)
			{
				ProgLevelResIDList_Marshaler = new TArrayReadWriteMarshaler<int>(1, ProgLevelResIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return ProgLevelResIDList_Marshaler.FromNative(IntPtr.Add(base.Address, ProgLevelResIDList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("弹窗UI")]
	[DisplayName("鼠标隐藏check时间")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:HideMouseCheckTime")]
	public float HideMouseCheckTime
	{
		get
		{
			CheckDestroyed();
			if (!HideMouseCheckTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:HideMouseCheckTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HideMouseCheckTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HideMouseCheckTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:HideMouseCheckTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HideMouseCheckTime_Offset), value);
			}
		}
	}

	[DisplayName("36号字体的基准像素高度")]
	[Category("富文本UI")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:BasePixelHeight")]
	public int BasePixelHeight
	{
		get
		{
			CheckDestroyed();
			if (!BasePixelHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:BasePixelHeight");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BasePixelHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BasePixelHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:BasePixelHeight");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BasePixelHeight_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("富文本UI")]
	[DisplayName("基于 Baseline 的偏移量")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:BaselineOffset")]
	public int BaselineOffset
	{
		get
		{
			CheckDestroyed();
			if (!BaselineOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:BaselineOffset");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BaselineOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaselineOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:BaselineOffset");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BaselineOffset_Offset), value);
			}
		}
	}

	[DisplayName("连接符号的偏移量")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("富文本UI")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:ConnectIconOffset")]
	public int ConnectIconOffset
	{
		get
		{
			CheckDestroyed();
			if (!ConnectIconOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ConnectIconOffset");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ConnectIconOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConnectIconOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:ConnectIconOffset");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ConnectIconOffset_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("菜单导航栏")]
	[DisplayName("菜单栏切换Start时间")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:MenuSwitchStartTime")]
	public float MenuSwitchStartTime
	{
		get
		{
			CheckDestroyed();
			if (!MenuSwitchStartTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:MenuSwitchStartTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MenuSwitchStartTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MenuSwitchStartTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:MenuSwitchStartTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MenuSwitchStartTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("菜单导航栏")]
	[DisplayName("菜单栏切换Check时间")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:MenuSwitchCheckTime")]
	public float MenuSwitchCheckTime
	{
		get
		{
			CheckDestroyed();
			if (!MenuSwitchCheckTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:MenuSwitchCheckTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MenuSwitchCheckTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MenuSwitchCheckTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:MenuSwitchCheckTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MenuSwitchCheckTime_Offset), value);
			}
		}
	}

	[DisplayName("一二级菜单初次交互时间")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("通用")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:FirstSwitchThreshold")]
	public float FirstSwitchThreshold
	{
		get
		{
			CheckDestroyed();
			if (!FirstSwitchThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:FirstSwitchThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FirstSwitchThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FirstSwitchThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:FirstSwitchThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FirstSwitchThreshold_Offset), value);
			}
		}
	}

	[DisplayName("一二级菜单长按连续交互时间")]
	[UProperty]
	[BlueprintReadWrite]
	[Category("通用")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:RepeatSwitchThreshold")]
	public float RepeatSwitchThreshold
	{
		get
		{
			CheckDestroyed();
			if (!RepeatSwitchThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:RepeatSwitchThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RepeatSwitchThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RepeatSwitchThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:RepeatSwitchThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RepeatSwitchThreshold_Offset), value);
			}
		}
	}

	[DisplayName("默认选中更新延迟")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("通用")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:SelectedDelayTime")]
	public float SelectedDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!SelectedDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:SelectedDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SelectedDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SelectedDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:SelectedDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SelectedDelayTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("通用")]
	[DisplayName("UIMPC")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:UIFXMPC")]
	public UMaterialParameterCollection UIFXMPC
	{
		get
		{
			CheckDestroyed();
			if (!UIFXMPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:UIFXMPC");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, UIFXMPC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UIFXMPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:UIFXMPC");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, UIFXMPC_Offset), value);
			}
		}
	}

	[DisplayName("UIGlobalMPC")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("通用")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:UIGlobalMPC")]
	public UMaterialParameterCollection UIGlobalMPC
	{
		get
		{
			CheckDestroyed();
			if (!UIGlobalMPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:UIGlobalMPC");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, UIGlobalMPC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UIGlobalMPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:UIGlobalMPC");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, UIGlobalMPC_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("复活点UI")]
	[DisplayName("传送UI延迟刷新AKBPicSwitch时间")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:TeleportAKBPicSwitchDelayTime")]
	public float TeleportAKBPicSwitchDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!TeleportAKBPicSwitchDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:TeleportAKBPicSwitchDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TeleportAKBPicSwitchDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TeleportAKBPicSwitchDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:TeleportAKBPicSwitchDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TeleportAKBPicSwitchDelayTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("人种袋详情")]
	[DisplayName("消耗能量等级（从大到小，最大3级）")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:CastEnergyLevel")]
	public TArrayReadWrite<float> CastEnergyLevel
	{
		get
		{
			CheckDestroyed();
			if (!CastEnergyLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:CastEnergyLevel");
				return null;
			}
			if (CastEnergyLevel_Marshaler == null)
			{
				CastEnergyLevel_Marshaler = new TArrayReadWriteMarshaler<float>(1, CastEnergyLevel_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return CastEnergyLevel_Marshaler.FromNative(IntPtr.Add(base.Address, CastEnergyLevel_Offset));
		}
	}

	[DisplayName("成就Tips显示时间")]
	[Category("成就UI|Tips")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:AchieveTipsShowTime")]
	public float AchieveTipsShowTime
	{
		get
		{
			CheckDestroyed();
			if (!AchieveTipsShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:AchieveTipsShowTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AchieveTipsShowTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AchieveTipsShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:AchieveTipsShowTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AchieveTipsShowTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("通用|Item配置")]
	[DisplayName("TileViewItem")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:TileItemConfig")]
	public TMapReadWrite<ETileItemScene, FTileItemConfig> TileItemConfig
	{
		get
		{
			CheckDestroyed();
			if (!TileItemConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:TileItemConfig");
				return null;
			}
			if (TileItemConfig_Marshaler == null)
			{
				TileItemConfig_Marshaler = new TMapReadWriteMarshaler<ETileItemScene, FTileItemConfig>(1, TileItemConfig_PropertyAddress, CachedMarshalingDelegates<ETileItemScene, EnumMarshaler<ETileItemScene>>.FromNative, CachedMarshalingDelegates<ETileItemScene, EnumMarshaler<ETileItemScene>>.ToNative, CachedMarshalingDelegates<FTileItemConfig, FTileItemConfig>.FromNative, CachedMarshalingDelegates<FTileItemConfig, FTileItemConfig>.ToNative);
			}
			return TileItemConfig_Marshaler.FromNative(IntPtr.Add(base.Address, TileItemConfig_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("登录提示")]
	[DisplayName("是否可以跳过")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:LoginNoticeIsCanSkip")]
	public bool LoginNoticeIsCanSkip
	{
		get
		{
			CheckDestroyed();
			if (!LoginNoticeIsCanSkip_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:LoginNoticeIsCanSkip");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LoginNoticeIsCanSkip_Offset), 0, LoginNoticeIsCanSkip_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LoginNoticeIsCanSkip_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:LoginNoticeIsCanSkip");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LoginNoticeIsCanSkip_Offset), 0, LoginNoticeIsCanSkip_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("天赋学习界面")]
	[DisplayName("长按全部洗点时间")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:TalentAllResetLongPressTime")]
	public float TalentAllResetLongPressTime
	{
		get
		{
			CheckDestroyed();
			if (!TalentAllResetLongPressTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:TalentAllResetLongPressTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TalentAllResetLongPressTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TalentAllResetLongPressTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:TalentAllResetLongPressTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TalentAllResetLongPressTime_Offset), value);
			}
		}
	}

	[DisplayName("长按页签洗点时间")]
	[Category("天赋学习界面")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:TalentTabResetLongPressTime")]
	public float TalentTabResetLongPressTime
	{
		get
		{
			CheckDestroyed();
			if (!TalentTabResetLongPressTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:TalentTabResetLongPressTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TalentTabResetLongPressTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TalentTabResetLongPressTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:TalentTabResetLongPressTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TalentTabResetLongPressTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("根器界面UI")]
	[DisplayName("鼠标区域延迟设置时间")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:LegacyMouseAreaDelayCheckTime")]
	public float LegacyMouseAreaDelayCheckTime
	{
		get
		{
			CheckDestroyed();
			if (!LegacyMouseAreaDelayCheckTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:LegacyMouseAreaDelayCheckTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LegacyMouseAreaDelayCheckTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LegacyMouseAreaDelayCheckTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:LegacyMouseAreaDelayCheckTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LegacyMouseAreaDelayCheckTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("通用")]
	[DisplayName("Slider摇杆输入间隔")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:SliderDelayInputGap")]
	public float SliderDelayInputGap
	{
		get
		{
			CheckDestroyed();
			if (!SliderDelayInputGap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:SliderDelayInputGap");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SliderDelayInputGap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SliderDelayInputGap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:SliderDelayInputGap");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SliderDelayInputGap_Offset), value);
			}
		}
	}

	[DisplayName("是否Hover时更新Detail")]
	[Category("武器锻造")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:UseHoverSelected")]
	public bool UseHoverSelected
	{
		get
		{
			CheckDestroyed();
			if (!UseHoverSelected_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:UseHoverSelected");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseHoverSelected_Offset), 0, UseHoverSelected_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseHoverSelected_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:UseHoverSelected");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseHoverSelected_Offset), 0, UseHoverSelected_PropertyAddress.Address, value);
			}
		}
	}

	[Category("低血量阈值提示")]
	[DisplayName("低血量阈值提示")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:SettingHpConfig")]
	public TArrayReadWrite<FSettingHpConfig> SettingHpConfig
	{
		get
		{
			CheckDestroyed();
			if (!SettingHpConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:SettingHpConfig");
				return null;
			}
			if (SettingHpConfig_Marshaler == null)
			{
				SettingHpConfig_Marshaler = new TArrayReadWriteMarshaler<FSettingHpConfig>(1, SettingHpConfig_PropertyAddress, CachedMarshalingDelegates<FSettingHpConfig, FSettingHpConfig>.FromNative, CachedMarshalingDelegates<FSettingHpConfig, FSettingHpConfig>.ToNative);
			}
			return SettingHpConfig_Marshaler.FromNative(IntPtr.Add(base.Address, SettingHpConfig_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("通用")]
	[DisplayName("底部输入提示配置")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:InputTipsConfig")]
	public TMapReadWrite<EUIPageType, FInputTipsLeftRightCfg> InputTipsConfig
	{
		get
		{
			CheckDestroyed();
			if (!InputTipsConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:InputTipsConfig");
				return null;
			}
			if (InputTipsConfig_Marshaler == null)
			{
				InputTipsConfig_Marshaler = new TMapReadWriteMarshaler<EUIPageType, FInputTipsLeftRightCfg>(1, InputTipsConfig_PropertyAddress, CachedMarshalingDelegates<EUIPageType, EnumMarshaler<EUIPageType>>.FromNative, CachedMarshalingDelegates<EUIPageType, EnumMarshaler<EUIPageType>>.ToNative, CachedMarshalingDelegates<FInputTipsLeftRightCfg, FInputTipsLeftRightCfg>.FromNative, CachedMarshalingDelegates<FInputTipsLeftRightCfg, FInputTipsLeftRightCfg>.ToNative);
			}
			return InputTipsConfig_Marshaler.FromNative(IntPtr.Add(base.Address, InputTipsConfig_Offset));
		}
	}

	[DisplayName("可跳过延迟时间")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("交互对话跳过")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:DelaySkippableTime")]
	public float DelaySkippableTime
	{
		get
		{
			CheckDestroyed();
			if (!DelaySkippableTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DelaySkippableTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DelaySkippableTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DelaySkippableTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:DelaySkippableTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DelaySkippableTime_Offset), value);
			}
		}
	}

	[DisplayName("视频开始时间")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("前尘影事")]
	[USharpPath("/Script/b1-Managed.BGWUIConfigDataAsset:MediaClampTimeMap")]
	public TMapReadWrite<int, FVector2D> MediaClampTimeMap
	{
		get
		{
			CheckDestroyed();
			if (!MediaClampTimeMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUIConfigDataAsset:MediaClampTimeMap");
				return null;
			}
			if (MediaClampTimeMap_Marshaler == null)
			{
				MediaClampTimeMap_Marshaler = new TMapReadWriteMarshaler<int, FVector2D>(1, MediaClampTimeMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative);
			}
			return MediaClampTimeMap_Marshaler.FromNative(IntPtr.Add(base.Address, MediaClampTimeMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWUIConfigDataAsset");
		DropFirstShowDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropFirstShowDelayTime");
		DropFirstShowDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropFirstShowDelayTime", Classes.FFloatProperty);
		DropShowTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropShowTime");
		DropShowTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropShowTime", Classes.FFloatProperty);
		DropMinShowTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropMinShowTime");
		DropMinShowTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropMinShowTime", Classes.FFloatProperty);
		DropInFuncShowTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropInFuncShowTime");
		DropInFuncShowTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropInFuncShowTime", Classes.FFloatProperty);
		DropAdvanceShowTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropAdvanceShowTime");
		DropAdvanceShowTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropAdvanceShowTime", Classes.FFloatProperty);
		DropAdvanceMinShowTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropAdvanceMinShowTime");
		DropAdvanceMinShowTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropAdvanceMinShowTime", Classes.FFloatProperty);
		DropInFuncAdvanceShowTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropInFuncAdvanceShowTime");
		DropInFuncAdvanceShowTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropInFuncAdvanceShowTime", Classes.FFloatProperty);
		DropManualShowTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropManualShowTime");
		DropManualShowTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropManualShowTime", Classes.FFloatProperty);
		DropAdvanceJumpTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropAdvanceJumpTime");
		DropAdvanceJumpTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropAdvanceJumpTime", Classes.FFloatProperty);
		DropSpecialTipsShowTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropSpecialTipsShowTime");
		DropSpecialTipsShowTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropSpecialTipsShowTime", Classes.FFloatProperty);
		DropSpecialShowTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropSpecialShowTime");
		DropSpecialShowTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropSpecialShowTime", Classes.FFloatProperty);
		ExpShowTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ExpShowTime");
		ExpShowTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ExpShowTime", Classes.FFloatProperty);
		ExpMultiShowTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ExpMultiShowTime");
		ExpMultiShowTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ExpMultiShowTime", Classes.FFloatProperty);
		DropMuseumShowTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropMuseumShowTime");
		DropMuseumShowTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropMuseumShowTime", Classes.FFloatProperty);
		ShortcutActiveDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ShortcutActiveDelayTime");
		ShortcutActiveDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ShortcutActiveDelayTime", Classes.FFloatProperty);
		ShortcutDetailActiveDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ShortcutDetailActiveDelayTime");
		ShortcutDetailActiveDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ShortcutDetailActiveDelayTime", Classes.FFloatProperty);
		ShortcutItemNudge_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ShortcutItemNudge");
		ShortcutItemNudge_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ShortcutItemNudge", Classes.FFloatProperty);
		StToNrDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StToNrDelayTime");
		StToNrDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StToNrDelayTime", Classes.FFloatProperty);
		StToNrEasingTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StToNrEasingTime");
		StToNrEasingTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StToNrEasingTime", Classes.FFloatProperty);
		NrToStDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NrToStDelayTime");
		NrToStDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NrToStDelayTime", Classes.FFloatProperty);
		NrToStEasingTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NrToStEasingTime");
		NrToStEasingTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NrToStEasingTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref ShortcutSpellSort_PropertyAddress, unrealStruct, "ShortcutSpellSort");
		ShortcutSpellSort_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ShortcutSpellSort");
		ShortcutSpellSort_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ShortcutSpellSort", Classes.FArrayProperty);
		ShowProtectTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ShowProtectTime");
		ShowProtectTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ShowProtectTime", Classes.FFloatProperty);
		BattleMainFadeTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BattleMainFadeTime");
		BattleMainFadeTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BattleMainFadeTime", Classes.FFloatProperty);
		InSeqShowProtectTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InSeqShowProtectTime");
		InSeqShowProtectTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InSeqShowProtectTime", Classes.FFloatProperty);
		InSeqBattleMainFadeTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InSeqBattleMainFadeTime");
		InSeqBattleMainFadeTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InSeqBattleMainFadeTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref ActionMappingList_PropertyAddress, unrealStruct, "ActionMappingList");
		ActionMappingList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ActionMappingList");
		ActionMappingList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ActionMappingList", Classes.FArrayProperty);
		ShortcutSpellAction_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ShortcutSpellAction");
		ShortcutSpellAction_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ShortcutSpellAction", Classes.FStrProperty);
		ShortcutItemAction_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ShortcutItemAction");
		ShortcutItemAction_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ShortcutItemAction", Classes.FStrProperty);
		HPLowPostProcessPercent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HPLowPostProcessPercent");
		HPLowPostProcessPercent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HPLowPostProcessPercent", Classes.FFloatProperty);
		HPLimitPostProcessPercent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HPLimitPostProcessPercent");
		HPLimitPostProcessPercent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HPLimitPostProcessPercent", Classes.FFloatProperty);
		HPLowPostProcessSliderFreq_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HPLowPostProcessSliderFreq");
		HPLowPostProcessSliderFreq_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HPLowPostProcessSliderFreq", Classes.FFloatProperty);
		HPLimitPostProcessSliderFreq_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HPLimitPostProcessSliderFreq");
		HPLimitPostProcessSliderFreq_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HPLimitPostProcessSliderFreq", Classes.FFloatProperty);
		HPLimitPostProcessAudioTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HPLimitPostProcessAudioTime");
		HPLimitPostProcessAudioTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HPLimitPostProcessAudioTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref HPPostProcessStopUIList_PropertyAddress, unrealStruct, "HPPostProcessStopUIList");
		HPPostProcessStopUIList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HPPostProcessStopUIList");
		HPPostProcessStopUIList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HPPostProcessStopUIList", Classes.FArrayProperty);
		StylePoseMPC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StylePoseMPC");
		StylePoseMPC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StylePoseMPC", Classes.FObjectProperty);
		ProgBaseTexSizeV1_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ProgBaseTexSizeV1");
		ProgBaseTexSizeV1_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ProgBaseTexSizeV1", Classes.FFloatProperty);
		ProgBaseTexSizeV2_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ProgBaseTexSizeV2");
		ProgBaseTexSizeV2_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ProgBaseTexSizeV2", Classes.FFloatProperty);
		ProgBaseTexSizeV3_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ProgBaseTexSizeV3");
		ProgBaseTexSizeV3_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ProgBaseTexSizeV3", Classes.FFloatProperty);
		ProgPercentSplite_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ProgPercentSplite");
		ProgPercentSplite_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ProgPercentSplite", Classes.FFloatProperty);
		DBBInputHPPre_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DBBInputHPPre");
		DBBInputHPPre_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DBBInputHPPre", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref HpDefaultMap_PropertyAddress, unrealStruct, "HpDefaultMap");
		HpDefaultMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HpDefaultMap");
		HpDefaultMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HpDefaultMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref ProcBarConfigMap_PropertyAddress, unrealStruct, "ProcBarConfigMap");
		ProcBarConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ProcBarConfigMap");
		ProcBarConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ProcBarConfigMap", Classes.FMapProperty);
		CloudMoveTipsDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CloudMoveTipsDelayTime");
		CloudMoveTipsDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CloudMoveTipsDelayTime", Classes.FFloatProperty);
		SeqSkipLongPressTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SeqSkipLongPressTime");
		SeqSkipLongPressTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SeqSkipLongPressTime", Classes.FFloatProperty);
		SeqSkipFadeTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SeqSkipFadeTime");
		SeqSkipFadeTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SeqSkipFadeTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref ProgLevelResIDList_PropertyAddress, unrealStruct, "ProgLevelResIDList");
		ProgLevelResIDList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ProgLevelResIDList");
		ProgLevelResIDList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ProgLevelResIDList", Classes.FArrayProperty);
		HideMouseCheckTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HideMouseCheckTime");
		HideMouseCheckTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HideMouseCheckTime", Classes.FFloatProperty);
		BasePixelHeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BasePixelHeight");
		BasePixelHeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BasePixelHeight", Classes.FIntProperty);
		BaselineOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BaselineOffset");
		BaselineOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BaselineOffset", Classes.FIntProperty);
		ConnectIconOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ConnectIconOffset");
		ConnectIconOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ConnectIconOffset", Classes.FIntProperty);
		MenuSwitchStartTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MenuSwitchStartTime");
		MenuSwitchStartTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MenuSwitchStartTime", Classes.FFloatProperty);
		MenuSwitchCheckTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MenuSwitchCheckTime");
		MenuSwitchCheckTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MenuSwitchCheckTime", Classes.FFloatProperty);
		FirstSwitchThreshold_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FirstSwitchThreshold");
		FirstSwitchThreshold_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FirstSwitchThreshold", Classes.FFloatProperty);
		RepeatSwitchThreshold_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RepeatSwitchThreshold");
		RepeatSwitchThreshold_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RepeatSwitchThreshold", Classes.FFloatProperty);
		SelectedDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SelectedDelayTime");
		SelectedDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SelectedDelayTime", Classes.FFloatProperty);
		UIFXMPC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UIFXMPC");
		UIFXMPC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UIFXMPC", Classes.FObjectProperty);
		UIGlobalMPC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UIGlobalMPC");
		UIGlobalMPC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UIGlobalMPC", Classes.FObjectProperty);
		TeleportAKBPicSwitchDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TeleportAKBPicSwitchDelayTime");
		TeleportAKBPicSwitchDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TeleportAKBPicSwitchDelayTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref CastEnergyLevel_PropertyAddress, unrealStruct, "CastEnergyLevel");
		CastEnergyLevel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CastEnergyLevel");
		CastEnergyLevel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CastEnergyLevel", Classes.FArrayProperty);
		AchieveTipsShowTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AchieveTipsShowTime");
		AchieveTipsShowTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AchieveTipsShowTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref TileItemConfig_PropertyAddress, unrealStruct, "TileItemConfig");
		TileItemConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TileItemConfig");
		TileItemConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TileItemConfig", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref LoginNoticeIsCanSkip_PropertyAddress, unrealStruct, "LoginNoticeIsCanSkip");
		LoginNoticeIsCanSkip_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LoginNoticeIsCanSkip");
		LoginNoticeIsCanSkip_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LoginNoticeIsCanSkip", Classes.FBoolProperty);
		TalentAllResetLongPressTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TalentAllResetLongPressTime");
		TalentAllResetLongPressTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TalentAllResetLongPressTime", Classes.FFloatProperty);
		TalentTabResetLongPressTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TalentTabResetLongPressTime");
		TalentTabResetLongPressTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TalentTabResetLongPressTime", Classes.FFloatProperty);
		LegacyMouseAreaDelayCheckTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LegacyMouseAreaDelayCheckTime");
		LegacyMouseAreaDelayCheckTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LegacyMouseAreaDelayCheckTime", Classes.FFloatProperty);
		SliderDelayInputGap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SliderDelayInputGap");
		SliderDelayInputGap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SliderDelayInputGap", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref UseHoverSelected_PropertyAddress, unrealStruct, "UseHoverSelected");
		UseHoverSelected_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseHoverSelected");
		UseHoverSelected_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseHoverSelected", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SettingHpConfig_PropertyAddress, unrealStruct, "SettingHpConfig");
		SettingHpConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SettingHpConfig");
		SettingHpConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SettingHpConfig", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref InputTipsConfig_PropertyAddress, unrealStruct, "InputTipsConfig");
		InputTipsConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InputTipsConfig");
		InputTipsConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InputTipsConfig", Classes.FMapProperty);
		DelaySkippableTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DelaySkippableTime");
		DelaySkippableTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DelaySkippableTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref MediaClampTimeMap_PropertyAddress, unrealStruct, "MediaClampTimeMap");
		MediaClampTimeMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MediaClampTimeMap");
		MediaClampTimeMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MediaClampTimeMap", Classes.FMapProperty);
	}

	static BGWUIConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWUIConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWUIConfigDataAsset));
	}
}
