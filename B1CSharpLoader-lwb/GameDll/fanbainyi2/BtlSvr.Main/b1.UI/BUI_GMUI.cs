using System;
using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_GMUI")]
internal class BUI_GMUI : BUI_Widget
{
	private List<b1.UI.GMCharaterConfig> ConfigList = new List<b1.UI.GMCharaterConfig>();

	private Dictionary<string, FOnButtonClickedEvent.Signature> BtnDic = new Dictionary<string, FOnButtonClickedEvent.Signature>();

	private Dictionary<string, FOnCheckBoxComponentStateChanged.Signature> CheckDic = new Dictionary<string, FOnCheckBoxComponentStateChanged.Signature>();

	private Dictionary<string, FOnFloatValueChangedEvent.Signature> SliderDic = new Dictionary<string, FOnFloatValueChangedEvent.Signature>();

	private Dictionary<string, string> EdtDic = new Dictionary<string, string>();

	private UUserWidget CharacterConfig;

	private const string CHARACTERCONFIG = "BP_UI_GMSettingCharacterConfig";

	private UScrollBox ConfigListBox;

	private UScrollBox BtnListBox;

	private UScrollBox CheckListBox;

	private UScrollBox SliderListBox;

	private UScrollBox EditableListBox;

	private const string NAMETEXT = "NameText";

	private const string CURVALUE = "CurValue";

	private const string EDITABLENAMETEXT = "EditableNameText";

	private const string EDITABLEVALUE = "EditableValue";

	private UButton Config_ConfirmBtn;

	private const string CONFIRMBTN_NAME = "ConfirmBtn";

	private const string SCRBOX_CONFIG = "ScrBox_Config";

	private const string SCRBOX_BTN = "ScrBox_Btn";

	private const string SCRBOX_CHECK = "ScrBox_Check";

	private const string SCRBOX_SLIDER = "ScrBox_Slider";

	private const string SCRBOX_EDIT = "ScrBox_Edit";

	private const string BTNTEMP_BTNNAME = "GMBtn";

	private const string BTNTEMP_TXTNAME = "GMBtnTxt";

	private const string OPTEMP_TXTWIDGETNAME = "BP_UI_GMSettingBase";

	private const string OPTEMP_TXTNAME = "OPtionName";

	private const string OPTEMP_CURVALUENAME = "CurValueText";

	private const string OPTEMP_CHECKWIDGETNAME = "BP_UI_OP_Check";

	private const string OPTEMP_CHECKNAME = "OPCheck";

	private const string OPTEMP_SLIDERWIDGETNAME = "BP_UI_OP_Slider";

	private const string OPTEMP_SLIDERNAME = "OPSlider";

	private const string OPTEMP_EDITABLEWIDGETNAME = "BP_UI_OP_Editable";

	private const string OPTEMP_EDITNAME = "OPEditableText";

	private const string OPTEMP_EDITBTNNAME = "OPButton";

	private UEditableTextBox CamInfo_EditableText;

	private UButton GetCamInfo_Btn;

	private const string EDITABLE_CAMINFO_TEXT = "CamInfo";

	private const string GETCAMINFO_BTNNAME = "GetCamInfo";

	private const string configboxName_Pre = "BP_UI_Character_ShowGroup_C_";

	private static bool ConfigTemp_IsValid;

	private static int ConfigTemp_Offset;

	private static bool BtnTemp_IsValid;

	private static int BtnTemp_Offset;

	private static bool CheckTemp_IsValid;

	private static int CheckTemp_Offset;

	private static bool SliderTemp_IsValid;

	private static int SliderTemp_Offset;

	private static bool EditableTemp_IsValid;

	private static int EditableTemp_Offset;

	private static bool OnSetInvisible_IsValid;

	private static IntPtr OnSetInvisible_FunctionAddress;

	private static int OnSetInvisible_ParamsSize;

	private static bool OnSetInvisible_isChecked_IsValid;

	private static int OnSetInvisible_isChecked_Offset;

	private static FFieldAddress OnSetInvisible_isChecked_PropertyAddress;

	private static bool OnClickDoFullHP_IsValid;

	private static IntPtr OnClickDoFullHP_FunctionAddress;

	private static int OnClickDoFullHP_ParamsSize;

	private static bool OnClickDoFullMP_IsValid;

	private static IntPtr OnClickDoFullMP_FunctionAddress;

	private static int OnClickDoFullMP_ParamsSize;

	private static bool OnClickDoLockHP_IsValid;

	private static IntPtr OnClickDoLockHP_FunctionAddress;

	private static int OnClickDoLockHP_ParamsSize;

	private static bool OnChangeDoLockHP2_IsValid;

	private static IntPtr OnChangeDoLockHP2_FunctionAddress;

	private static int OnChangeDoLockHP2_ParamsSize;

	private static bool OnChangeDoLockHP2_isChecked_IsValid;

	private static int OnChangeDoLockHP2_isChecked_Offset;

	private static FFieldAddress OnChangeDoLockHP2_isChecked_PropertyAddress;

	private static bool OnChangeDoToggleUI_IsValid;

	private static IntPtr OnChangeDoToggleUI_FunctionAddress;

	private static int OnChangeDoToggleUI_ParamsSize;

	private static bool OnChangeDoToggleUI_isChecked_IsValid;

	private static int OnChangeDoToggleUI_isChecked_Offset;

	private static FFieldAddress OnChangeDoToggleUI_isChecked_PropertyAddress;

	private static bool OnToggleAllEnemyAI_IsValid;

	private static IntPtr OnToggleAllEnemyAI_FunctionAddress;

	private static int OnToggleAllEnemyAI_ParamsSize;

	private static bool OnToggleAllEnemyAI_isChecked_IsValid;

	private static int OnToggleAllEnemyAI_isChecked_Offset;

	private static FFieldAddress OnToggleAllEnemyAI_isChecked_PropertyAddress;

	private static bool OnCancelAllEnemyCD_IsValid;

	private static IntPtr OnCancelAllEnemyCD_FunctionAddress;

	private static int OnCancelAllEnemyCD_ParamsSize;

	private static bool OnCancelAllEnemyCD_bCancel_IsValid;

	private static int OnCancelAllEnemyCD_bCancel_Offset;

	private static FFieldAddress OnCancelAllEnemyCD_bCancel_PropertyAddress;

	private static bool OnClickDoSetConfigs_IsValid;

	private static IntPtr OnClickDoSetConfigs_FunctionAddress;

	private static int OnClickDoSetConfigs_ParamsSize;

	private static bool OnClickDoInvincible_IsValid;

	private static IntPtr OnClickDoInvincible_FunctionAddress;

	private static int OnClickDoInvincible_ParamsSize;

	private static bool OnClickKillAllEnemy_IsValid;

	private static IntPtr OnClickKillAllEnemy_FunctionAddress;

	private static int OnClickKillAllEnemy_ParamsSize;

	private static bool OnClickDoAddBuff100_IsValid;

	private static IntPtr OnClickDoAddBuff100_FunctionAddress;

	private static int OnClickDoAddBuff100_ParamsSize;

	private static bool OnChangeDoInvincible_IsValid;

	private static IntPtr OnChangeDoInvincible_FunctionAddress;

	private static int OnChangeDoInvincible_ParamsSize;

	private static bool OnChangeDoInvincible_isChecked_IsValid;

	private static int OnChangeDoInvincible_isChecked_Offset;

	private static FFieldAddress OnChangeDoInvincible_isChecked_PropertyAddress;

	private static bool OnChangeDoLockStamina_IsValid;

	private static IntPtr OnChangeDoLockStamina_FunctionAddress;

	private static int OnChangeDoLockStamina_ParamsSize;

	private static bool OnChangeDoLockStamina_isChecked_IsValid;

	private static int OnChangeDoLockStamina_isChecked_Offset;

	private static FFieldAddress OnChangeDoLockStamina_isChecked_PropertyAddress;

	private static bool OnChangeDoLockEnemyHP_IsValid;

	private static IntPtr OnChangeDoLockEnemyHP_FunctionAddress;

	private static int OnChangeDoLockEnemyHP_ParamsSize;

	private static bool OnChangeDoLockEnemyHP_isChecked_IsValid;

	private static int OnChangeDoLockEnemyHP_isChecked_Offset;

	private static FFieldAddress OnChangeDoLockEnemyHP_isChecked_PropertyAddress;

	private static bool OnClick999BloodBottle_IsValid;

	private static IntPtr OnClick999BloodBottle_FunctionAddress;

	private static int OnClick999BloodBottle_ParamsSize;

	private static bool OnClickDoRemoveAllBuff_IsValid;

	private static IntPtr OnClickDoRemoveAllBuff_FunctionAddress;

	private static int OnClickDoRemoveAllBuff_ParamsSize;

	private static bool OnClickFullBloodBottle_IsValid;

	private static IntPtr OnClickFullBloodBottle_FunctionAddress;

	private static int OnClickFullBloodBottle_ParamsSize;

	private static bool OnChangeDoEnableEnemyBar_IsValid;

	private static IntPtr OnChangeDoEnableEnemyBar_FunctionAddress;

	private static int OnChangeDoEnableEnemyBar_ParamsSize;

	private static bool OnChangeDoEnableEnemyBar_isChecked_IsValid;

	private static int OnChangeDoEnableEnemyBar_isChecked_Offset;

	private static FFieldAddress OnChangeDoEnableEnemyBar_isChecked_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:ConfigTemp")]
	public TSubclassOf<UUserWidget> ConfigTemp
	{
		get
		{
			CheckDestroyed();
			if (!ConfigTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMUI:ConfigTemp");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, ConfigTemp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConfigTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMUI:ConfigTemp");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, ConfigTemp_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:BtnTemp")]
	public TSubclassOf<UUserWidget> BtnTemp
	{
		get
		{
			CheckDestroyed();
			if (!BtnTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMUI:BtnTemp");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, BtnTemp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BtnTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMUI:BtnTemp");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, BtnTemp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:CheckTemp")]
	public TSubclassOf<UUserWidget> CheckTemp
	{
		get
		{
			CheckDestroyed();
			if (!CheckTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMUI:CheckTemp");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, CheckTemp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CheckTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMUI:CheckTemp");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, CheckTemp_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:SliderTemp")]
	public TSubclassOf<UUserWidget> SliderTemp
	{
		get
		{
			CheckDestroyed();
			if (!SliderTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMUI:SliderTemp");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, SliderTemp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SliderTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMUI:SliderTemp");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, SliderTemp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:EditableTemp")]
	public TSubclassOf<UUserWidget> EditableTemp
	{
		get
		{
			CheckDestroyed();
			if (!EditableTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMUI:EditableTemp");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, EditableTemp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EditableTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMUI:EditableTemp");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, EditableTemp_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		CharacterConfig = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("BP_UI_GMSettingCharacterConfig")) as UUserWidget;
		ConfigListBox = UGSE_UMGFuncLib.GetWidgetFromName(CharacterConfig, new FName("ScrBox_Config")) as UScrollBox;
		Config_ConfirmBtn = UGSE_UMGFuncLib.GetWidgetFromName(CharacterConfig, new FName("ConfirmBtn")) as UButton;
		Config_ConfirmBtn.OnClicked.Bind(OnClickDoSetConfigs);
		BtnListBox = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("ScrBox_Btn")) as UScrollBox;
		CheckListBox = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("ScrBox_Check")) as UScrollBox;
		EditableListBox = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("ScrBox_Edit")) as UScrollBox;
		CamInfo_EditableText = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("CamInfo")) as UEditableTextBox;
		GetCamInfo_Btn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("GetCamInfo")) as UButton;
		GetCamInfo_Btn.OnClicked.Bind(OnClickGetCamInfo);
		if (BtnDic.ContainsKey("回满血"))
		{
			return;
		}
		if (!BtnDic.ContainsKey("回满血"))
		{
			BtnDic.Add("回满血", OnClickDoFullHP);
		}
		if (!BtnDic.ContainsKey("回满蓝"))
		{
			BtnDic.Add("回满蓝", OnClickDoFullMP);
		}
		if (!BtnDic.ContainsKey("回满血瓶"))
		{
			BtnDic.Add("回满血瓶", OnClickFullBloodBottle);
		}
		if (!BtnDic.ContainsKey("999血瓶"))
		{
			BtnDic.Add("999血瓶", OnClick999BloodBottle);
		}
		if (!BtnDic.ContainsKey("移除所有Buff"))
		{
			BtnDic.Add("移除所有Buff", OnClickDoRemoveAllBuff);
		}
		if (!BtnDic.ContainsKey("Buff100"))
		{
			BtnDic.Add("Buff100", OnClickDoAddBuff100);
		}
		if (!BtnDic.ContainsKey("秒杀所有怪物"))
		{
			BtnDic.Add("秒杀所有怪物", OnClickKillAllEnemy);
		}
		foreach (KeyValuePair<string, FOnButtonClickedEvent.Signature> item5 in BtnDic)
		{
			AddInitBtnToScrBox(BtnListBox, item5.Key, item5.Value);
		}
		if (!CheckDic.ContainsKey("清所有怪物CD"))
		{
			CheckDic.Add("清所有怪物CD", OnCancelAllEnemyCD);
		}
		if (!CheckDic.ContainsKey("无敌"))
		{
			CheckDic.Add("无敌", OnChangeDoInvincible);
		}
		if (!CheckDic.ContainsKey("锁血"))
		{
			CheckDic.Add("锁血", OnChangeDoLockHP2);
		}
		if (!CheckDic.ContainsKey("锁体力"))
		{
			CheckDic.Add("锁体力", OnChangeDoLockStamina);
		}
		if (!CheckDic.ContainsKey("隐身"))
		{
			CheckDic.Add("隐身", OnSetInvisible);
		}
		if (!CheckDic.ContainsKey("锁全场怪物血"))
		{
			CheckDic.Add("锁全场怪物血", OnChangeDoLockEnemyHP);
		}
		if (!CheckDic.ContainsKey("暂停所有怪物AI"))
		{
			CheckDic.Add("暂停所有怪物AI", OnToggleAllEnemyAI);
		}
		if (!CheckDic.ContainsKey("显示战斗UI"))
		{
			CheckDic.Add("显示战斗UI", OnChangeDoToggleUI);
		}
		if (!CheckDic.ContainsKey("允许显示小怪血条"))
		{
			CheckDic.Add("允许显示小怪血条", OnChangeDoEnableEnemyBar);
		}
		foreach (KeyValuePair<string, FOnCheckBoxComponentStateChanged.Signature> item6 in CheckDic)
		{
			AddInitOPCheckToScrBox(CheckListBox, item6.Key, item6.Value);
		}
		if (!EdtDic.ContainsKey("主角速度"))
		{
			EdtDic.Add("主角速度", "b.ChangeCharacterSpd");
		}
		if (!EdtDic.ContainsKey("敌人速度"))
		{
			EdtDic.Add("敌人速度", "b.ChangeEnemySpd");
		}
		if (!EdtDic.ContainsKey("全局速度"))
		{
			EdtDic.Add("全局速度", "b.ChangeGlobalSpd");
		}
		if (!EdtDic.ContainsKey("相机远近"))
		{
			EdtDic.Add("相机远近", "b.SetCamArmMode");
		}
		foreach (KeyValuePair<string, string> item7 in EdtDic)
		{
			AddInitOPEditableToScrBox(EditableListBox, item7.Key, item7.Value);
		}
		b1.UI.GMCharaterConfig item = new b1.UI.GMCharaterConfig(EBGUAttrFloat.Hp, EBGUAttrFloat.HpMaxBase, "当前最大HP值", "修改最大HP值");
		ConfigList.Add(item);
		b1.UI.GMCharaterConfig item2 = new b1.UI.GMCharaterConfig(EBGUAttrFloat.Mp, EBGUAttrFloat.MpMaxBase, "当前最大MP值", "修改最大MP值");
		ConfigList.Add(item2);
		b1.UI.GMCharaterConfig item3 = new b1.UI.GMCharaterConfig(EBGUAttrFloat.Atk, EBGUAttrFloat.AtkBase, "当前基础攻击", "修改基础攻击");
		ConfigList.Add(item3);
		b1.UI.GMCharaterConfig item4 = new b1.UI.GMCharaterConfig(EBGUAttrFloat.BloodBottomNumMax, EBGUAttrFloat.BloodBottomNumMaxBase, "当前血瓶上限", "修改血瓶上限");
		ConfigList.Add(item4);
		for (int i = 0; i < ConfigList.Count; i++)
		{
			b1.UI.GMCharaterConfig gMCharaterConfig = ConfigList[i];
			gMCharaterConfig.SetWidgetInstanceName(AddInitConfigToScrBox(ConfigListBox, gMCharaterConfig));
			ConfigList[i] = gMCharaterConfig;
		}
		BUC_LogData.IsUsedGM = true;
	}

	private void AddToDic()
	{
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:OnClickDoFullHP")]
	public void OnClickDoFullHP()
	{
		USystemLibrary.ExecuteConsoleCommand(this, "b.fullHP", null);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:OnClickDoFullMP")]
	public void OnClickDoFullMP()
	{
		USystemLibrary.ExecuteConsoleCommand(this, "b.fullMP", null);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:OnClickFullBloodBottle")]
	public void OnClickFullBloodBottle()
	{
		USystemLibrary.ExecuteConsoleCommand(this, "b.FullBloodBottle", null);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:OnClick999BloodBottle")]
	public void OnClick999BloodBottle()
	{
		USystemLibrary.ExecuteConsoleCommand(this, "b.SetBloodBottle 999", null);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:OnClickDoLockHP")]
	public void OnClickDoLockHP()
	{
		USystemLibrary.ExecuteConsoleCommand(this, "b.LockHP", null);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:OnClickDoInvincible")]
	public void OnClickDoInvincible()
	{
		USystemLibrary.ExecuteConsoleCommand(this, "b.HyperMuteki", null);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:OnClickDoAddBuff100")]
	public void OnClickDoAddBuff100()
	{
		USystemLibrary.ExecuteConsoleCommand(this, "b.AddBuff 100", null);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:OnClickKillAllEnemy")]
	public void OnClickKillAllEnemy()
	{
		USystemLibrary.ExecuteConsoleCommand(this, "b.KillAllEnemy", null);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:OnClickDoRemoveAllBuff")]
	public void OnClickDoRemoveAllBuff()
	{
		USystemLibrary.ExecuteConsoleCommand(this, "b.RemoveAllBuff", null);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:OnChangeDoToggleUI")]
	public void OnChangeDoToggleUI(bool isChecked)
	{
		if (isChecked)
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.showBattleUI 1", null);
		}
		else
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.showBattleUI 2", null);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:OnChangeDoEnableEnemyBar")]
	public void OnChangeDoEnableEnemyBar(bool isChecked)
	{
		if (isChecked)
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.EnableEnemyBar true", null);
		}
		else
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.EnableEnemyBar false", null);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:OnChangeDoInvincible")]
	public void OnChangeDoInvincible(bool isChecked)
	{
		if (isChecked)
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.Invincible", null);
		}
		else
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.UnInvincible", null);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:OnChangeDoLockHP2")]
	public void OnChangeDoLockHP2(bool isChecked)
	{
		if (isChecked)
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.LockHP", null);
		}
		else
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.UnlockHP", null);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:OnChangeDoLockStamina")]
	public void OnChangeDoLockStamina(bool isChecked)
	{
		if (isChecked)
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.LockStamina", null);
		}
		else
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.UnLockStamina", null);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:OnSetInvisible")]
	public void OnSetInvisible(bool isChecked)
	{
		if (isChecked)
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.Invisible", null);
		}
		else
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.UnInvisible", null);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:OnChangeDoLockEnemyHP")]
	public void OnChangeDoLockEnemyHP(bool isChecked)
	{
		if (isChecked)
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.LockEnemyHP", null);
		}
		else
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.UnLockEnemyHP", null);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:OnCancelAllEnemyCD")]
	public void OnCancelAllEnemyCD(bool bCancel)
	{
		if (bCancel)
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.CancelEnemyCD true", null);
		}
		else
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.CancelEnemyCD false", null);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:OnToggleAllEnemyAI")]
	public void OnToggleAllEnemyAI(bool isChecked)
	{
		if (isChecked)
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.ToggleAllEnemyAI true", null);
		}
		else
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.ToggleAllEnemyAI false", null);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMUI:OnClickDoSetConfigs")]
	public void OnClickDoSetConfigs()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController == null)
		{
			return;
		}
		ACharacter aCharacter = firstLocalPlayerController.GetControlledPawn() as ACharacter;
		if (aCharacter.IsNullOrDestroyed())
		{
			return;
		}
		for (int i = 0; i < ConfigList.Count; i++)
		{
			string widgetInstanceName = ConfigList[i].widgetInstanceName;
			UUserWidget widget = UGSE_UMGFuncLib.GetWidgetFromName(CharacterConfig, new FName(widgetInstanceName)) as UUserWidget;
			UTextBlock uTextBlock = UGSE_UMGFuncLib.GetWidgetFromName(widget, new FName("CurValue")) as UTextBlock;
			UEditableTextBox uEditableTextBox = UGSE_UMGFuncLib.GetWidgetFromName(widget, new FName("EditableValue")) as UEditableTextBox;
			if (float.TryParse((uEditableTextBox != null) ? uEditableTextBox.GetText() : "", out var result))
			{
				if (ConfigList[i].configAttrFloatBase != EBGUAttrFloat.None)
				{
					BUS_EventCollectionCS.Get(aCharacter).Evt_SetAttrFloat.Invoke(ConfigList[i].configAttrFloatBase, result);
					BUS_EventCollectionCS.Get(aCharacter).Evt_SetAttrFloat.Invoke(ConfigList[i].configAttrFloatFinal, result);
					uTextBlock?.SetText(FText.FromString(uEditableTextBox.GetText()));
				}
				else
				{
					uTextBlock?.SetText(FText.FromString("Error"));
				}
			}
		}
	}

	private void OnClickGetCamInfo()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (!(firstLocalPlayerController == null))
		{
			FVector cameraLocation = firstLocalPlayerController.PlayerCameraManager.GetCameraLocation();
			FRotator cameraRotation = firstLocalPlayerController.PlayerCameraManager.GetCameraRotation();
			string text = string.Format(UGameplayStatics.GetCurrentLevelName(firstLocalPlayerController) + "\n({0},{1},{2})({3},{4},{5})", cameraLocation.X.ToString(), cameraLocation.Y.ToString(), cameraLocation.Z.ToString(), cameraRotation.Roll.ToString(), cameraRotation.Pitch.ToString(), cameraRotation.Yaw.ToString());
			CamInfo_EditableText?.SetText(FText.FromString(text));
			UGSE_EngineFuncLib.CopyToClipBoard(text);
		}
	}

	private void AddInitBtnToScrBox(UScrollBox scrBox, string btnName, FOnButtonClickedEvent.Signature evnt)
	{
		if (!(scrBox == null) && evnt != null && !(BtnTemp == null))
		{
			UUserWidget uUserWidget = UGSE_UMGFuncLib.CreateUserWidgetWithClass(this, BtnTemp.Value);
			(UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("GMBtn")) as UButton).OnClicked.Bind(evnt);
			(UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("GMBtnTxt")) as UTextBlock).SetText(FText.FromString(btnName));
			scrBox.AddChild(uUserWidget);
		}
	}

	private void AddInitOPCheckToScrBox(UScrollBox scrBox, string opName, FOnCheckBoxComponentStateChanged.Signature evnt)
	{
		if (!(scrBox == null) && evnt != null && !(CheckTemp == null))
		{
			UUserWidget uUserWidget = UGSE_UMGFuncLib.CreateUserWidgetWithClass(this, CheckTemp.Value);
			(UGSE_UMGFuncLib.GetWidgetFromName(UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("BP_UI_GMSettingBase")) as UUserWidget, new FName("OPtionName")) as UTextBlock).SetText(FText.FromString(opName));
			(UGSE_UMGFuncLib.GetWidgetFromName(UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("BP_UI_OP_Check")) as UUserWidget, new FName("OPCheck")) as UCheckBox).OnCheckStateChanged.Bind(evnt);
			scrBox.AddChild(uUserWidget);
		}
	}

	private void AddInitOPEditableToScrBox(UScrollBox scrBox, string opName, string gmcommand_Pre)
	{
		if (!(scrBox == null) && gmcommand_Pre != null && !(EditableTemp == null))
		{
			UUserWidget uUserWidget = UGSE_UMGFuncLib.CreateUserWidgetWithClass(this, EditableTemp.Value);
			(UGSE_UMGFuncLib.GetWidgetFromName(UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("BP_UI_GMSettingBase")) as UUserWidget, new FName("OPtionName")) as UTextBlock).SetText(FText.FromString(opName));
			b1.UI.BUI_GM_OP_Editable obj = UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("BP_UI_OP_Editable")) as b1.UI.BUI_GM_OP_Editable;
			obj.GMCommand_Pre = gmcommand_Pre;
			obj.Init();
			scrBox.AddChild(uUserWidget);
		}
	}

	private string AddInitConfigToScrBox(UScrollBox scrBox, b1.UI.GMCharaterConfig config)
	{
		if (scrBox == null)
		{
			return "";
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController == null)
		{
			return "";
		}
		ACharacter aCharacter = firstLocalPlayerController.GetControlledPawn() as ACharacter;
		if (aCharacter.IsNullOrDestroyed())
		{
			return "";
		}
		UUserWidget uUserWidget = UGSE_UMGFuncLib.CreateUserWidgetWithClass(this, ConfigTemp.Value);
		(UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("NameText")) as UTextBlock).SetText(FText.FromString(config.name + ":"));
		UTextBlock uTextBlock = UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("CurValue")) as UTextBlock;
		if (config.configAttrFloatBase != EBGUAttrFloat.None)
		{
			uTextBlock.SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(aCharacter, config.configAttrFloatBase).ToString()));
		}
		else
		{
			uTextBlock.SetText(FText.FromString("Error"));
		}
		(UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("EditableNameText")) as UTextBlock).SetText(FText.FromString(config.editableName + ":"));
		UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("EditableValue"));
		scrBox.AddChild(uUserWidget);
		return uUserWidget.GetName();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMUI:OnSetInvisible")]
	private static void OnSetInvisible__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMUI bUI_GMUI = GCHelper.Find<b1.UI.BUI_GMUI>(obj);
		bool isChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnSetInvisible_isChecked_Offset), 0, OnSetInvisible_isChecked_PropertyAddress.Address);
		bUI_GMUI.OnSetInvisible(isChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMUI:OnClickDoFullHP")]
	private static void OnClickDoFullHP__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMUI bUI_GMUI = GCHelper.Find<b1.UI.BUI_GMUI>(obj);
		bUI_GMUI.OnClickDoFullHP();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMUI:OnClickDoFullMP")]
	private static void OnClickDoFullMP__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMUI bUI_GMUI = GCHelper.Find<b1.UI.BUI_GMUI>(obj);
		bUI_GMUI.OnClickDoFullMP();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMUI:OnClickDoLockHP")]
	private static void OnClickDoLockHP__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMUI bUI_GMUI = GCHelper.Find<b1.UI.BUI_GMUI>(obj);
		bUI_GMUI.OnClickDoLockHP();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMUI:OnChangeDoLockHP2")]
	private static void OnChangeDoLockHP2__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMUI bUI_GMUI = GCHelper.Find<b1.UI.BUI_GMUI>(obj);
		bool isChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnChangeDoLockHP2_isChecked_Offset), 0, OnChangeDoLockHP2_isChecked_PropertyAddress.Address);
		bUI_GMUI.OnChangeDoLockHP2(isChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMUI:OnChangeDoToggleUI")]
	private static void OnChangeDoToggleUI__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMUI bUI_GMUI = GCHelper.Find<b1.UI.BUI_GMUI>(obj);
		bool isChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnChangeDoToggleUI_isChecked_Offset), 0, OnChangeDoToggleUI_isChecked_PropertyAddress.Address);
		bUI_GMUI.OnChangeDoToggleUI(isChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMUI:OnToggleAllEnemyAI")]
	private static void OnToggleAllEnemyAI__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMUI bUI_GMUI = GCHelper.Find<b1.UI.BUI_GMUI>(obj);
		bool isChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnToggleAllEnemyAI_isChecked_Offset), 0, OnToggleAllEnemyAI_isChecked_PropertyAddress.Address);
		bUI_GMUI.OnToggleAllEnemyAI(isChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMUI:OnCancelAllEnemyCD")]
	private static void OnCancelAllEnemyCD__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMUI bUI_GMUI = GCHelper.Find<b1.UI.BUI_GMUI>(obj);
		bool bCancel = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnCancelAllEnemyCD_bCancel_Offset), 0, OnCancelAllEnemyCD_bCancel_PropertyAddress.Address);
		bUI_GMUI.OnCancelAllEnemyCD(bCancel);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMUI:OnClickDoSetConfigs")]
	private static void OnClickDoSetConfigs__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMUI bUI_GMUI = GCHelper.Find<b1.UI.BUI_GMUI>(obj);
		bUI_GMUI.OnClickDoSetConfigs();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMUI:OnClickDoInvincible")]
	private static void OnClickDoInvincible__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMUI bUI_GMUI = GCHelper.Find<b1.UI.BUI_GMUI>(obj);
		bUI_GMUI.OnClickDoInvincible();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMUI:OnClickKillAllEnemy")]
	private static void OnClickKillAllEnemy__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMUI bUI_GMUI = GCHelper.Find<b1.UI.BUI_GMUI>(obj);
		bUI_GMUI.OnClickKillAllEnemy();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMUI:OnClickDoAddBuff100")]
	private static void OnClickDoAddBuff100__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMUI bUI_GMUI = GCHelper.Find<b1.UI.BUI_GMUI>(obj);
		bUI_GMUI.OnClickDoAddBuff100();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMUI:OnChangeDoInvincible")]
	private static void OnChangeDoInvincible__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMUI bUI_GMUI = GCHelper.Find<b1.UI.BUI_GMUI>(obj);
		bool isChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnChangeDoInvincible_isChecked_Offset), 0, OnChangeDoInvincible_isChecked_PropertyAddress.Address);
		bUI_GMUI.OnChangeDoInvincible(isChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMUI:OnChangeDoLockStamina")]
	private static void OnChangeDoLockStamina__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMUI bUI_GMUI = GCHelper.Find<b1.UI.BUI_GMUI>(obj);
		bool isChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnChangeDoLockStamina_isChecked_Offset), 0, OnChangeDoLockStamina_isChecked_PropertyAddress.Address);
		bUI_GMUI.OnChangeDoLockStamina(isChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMUI:OnChangeDoLockEnemyHP")]
	private static void OnChangeDoLockEnemyHP__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMUI bUI_GMUI = GCHelper.Find<b1.UI.BUI_GMUI>(obj);
		bool isChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnChangeDoLockEnemyHP_isChecked_Offset), 0, OnChangeDoLockEnemyHP_isChecked_PropertyAddress.Address);
		bUI_GMUI.OnChangeDoLockEnemyHP(isChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMUI:OnClick999BloodBottle")]
	private static void OnClick999BloodBottle__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMUI bUI_GMUI = GCHelper.Find<b1.UI.BUI_GMUI>(obj);
		bUI_GMUI.OnClick999BloodBottle();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMUI:OnClickDoRemoveAllBuff")]
	private static void OnClickDoRemoveAllBuff__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMUI bUI_GMUI = GCHelper.Find<b1.UI.BUI_GMUI>(obj);
		bUI_GMUI.OnClickDoRemoveAllBuff();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMUI:OnClickFullBloodBottle")]
	private static void OnClickFullBloodBottle__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMUI bUI_GMUI = GCHelper.Find<b1.UI.BUI_GMUI>(obj);
		bUI_GMUI.OnClickFullBloodBottle();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMUI:OnChangeDoEnableEnemyBar")]
	private static void OnChangeDoEnableEnemyBar__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMUI bUI_GMUI = GCHelper.Find<b1.UI.BUI_GMUI>(obj);
		bool isChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnChangeDoEnableEnemyBar_isChecked_Offset), 0, OnChangeDoEnableEnemyBar_isChecked_PropertyAddress.Address);
		bUI_GMUI.OnChangeDoEnableEnemyBar(isChecked);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_GMUI");
		ConfigTemp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConfigTemp");
		ConfigTemp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConfigTemp", Classes.FClassProperty);
		BtnTemp_Offset = NativeReflection.GetPropertyOffset(intPtr, "BtnTemp");
		BtnTemp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BtnTemp", Classes.FClassProperty);
		CheckTemp_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckTemp");
		CheckTemp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckTemp", Classes.FClassProperty);
		SliderTemp_Offset = NativeReflection.GetPropertyOffset(intPtr, "SliderTemp");
		SliderTemp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SliderTemp", Classes.FClassProperty);
		EditableTemp_Offset = NativeReflection.GetPropertyOffset(intPtr, "EditableTemp");
		EditableTemp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EditableTemp", Classes.FClassProperty);
		OnSetInvisible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnSetInvisible");
		OnSetInvisible_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSetInvisible_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnSetInvisible_isChecked_PropertyAddress, OnSetInvisible_FunctionAddress, "isChecked");
		OnSetInvisible_isChecked_Offset = NativeReflection.GetPropertyOffset(OnSetInvisible_FunctionAddress, "isChecked");
		OnSetInvisible_isChecked_IsValid = NativeReflection.ValidatePropertyClass(OnSetInvisible_FunctionAddress, "isChecked", Classes.FBoolProperty);
		OnSetInvisible_IsValid = OnSetInvisible_FunctionAddress != IntPtr.Zero && OnSetInvisible_isChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMUI:OnSetInvisible", OnSetInvisible_IsValid);
		OnClickDoFullHP_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnClickDoFullHP");
		OnClickDoFullHP_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickDoFullHP_FunctionAddress);
		OnClickDoFullHP_IsValid = OnClickDoFullHP_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMUI:OnClickDoFullHP", OnClickDoFullHP_IsValid);
		OnClickDoFullMP_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnClickDoFullMP");
		OnClickDoFullMP_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickDoFullMP_FunctionAddress);
		OnClickDoFullMP_IsValid = OnClickDoFullMP_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMUI:OnClickDoFullMP", OnClickDoFullMP_IsValid);
		OnClickDoLockHP_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnClickDoLockHP");
		OnClickDoLockHP_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickDoLockHP_FunctionAddress);
		OnClickDoLockHP_IsValid = OnClickDoLockHP_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMUI:OnClickDoLockHP", OnClickDoLockHP_IsValid);
		OnChangeDoLockHP2_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnChangeDoLockHP2");
		OnChangeDoLockHP2_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChangeDoLockHP2_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnChangeDoLockHP2_isChecked_PropertyAddress, OnChangeDoLockHP2_FunctionAddress, "isChecked");
		OnChangeDoLockHP2_isChecked_Offset = NativeReflection.GetPropertyOffset(OnChangeDoLockHP2_FunctionAddress, "isChecked");
		OnChangeDoLockHP2_isChecked_IsValid = NativeReflection.ValidatePropertyClass(OnChangeDoLockHP2_FunctionAddress, "isChecked", Classes.FBoolProperty);
		OnChangeDoLockHP2_IsValid = OnChangeDoLockHP2_FunctionAddress != IntPtr.Zero && OnChangeDoLockHP2_isChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMUI:OnChangeDoLockHP2", OnChangeDoLockHP2_IsValid);
		OnChangeDoToggleUI_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnChangeDoToggleUI");
		OnChangeDoToggleUI_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChangeDoToggleUI_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnChangeDoToggleUI_isChecked_PropertyAddress, OnChangeDoToggleUI_FunctionAddress, "isChecked");
		OnChangeDoToggleUI_isChecked_Offset = NativeReflection.GetPropertyOffset(OnChangeDoToggleUI_FunctionAddress, "isChecked");
		OnChangeDoToggleUI_isChecked_IsValid = NativeReflection.ValidatePropertyClass(OnChangeDoToggleUI_FunctionAddress, "isChecked", Classes.FBoolProperty);
		OnChangeDoToggleUI_IsValid = OnChangeDoToggleUI_FunctionAddress != IntPtr.Zero && OnChangeDoToggleUI_isChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMUI:OnChangeDoToggleUI", OnChangeDoToggleUI_IsValid);
		OnToggleAllEnemyAI_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnToggleAllEnemyAI");
		OnToggleAllEnemyAI_ParamsSize = NativeReflection.GetFunctionParamsSize(OnToggleAllEnemyAI_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnToggleAllEnemyAI_isChecked_PropertyAddress, OnToggleAllEnemyAI_FunctionAddress, "isChecked");
		OnToggleAllEnemyAI_isChecked_Offset = NativeReflection.GetPropertyOffset(OnToggleAllEnemyAI_FunctionAddress, "isChecked");
		OnToggleAllEnemyAI_isChecked_IsValid = NativeReflection.ValidatePropertyClass(OnToggleAllEnemyAI_FunctionAddress, "isChecked", Classes.FBoolProperty);
		OnToggleAllEnemyAI_IsValid = OnToggleAllEnemyAI_FunctionAddress != IntPtr.Zero && OnToggleAllEnemyAI_isChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMUI:OnToggleAllEnemyAI", OnToggleAllEnemyAI_IsValid);
		OnCancelAllEnemyCD_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnCancelAllEnemyCD");
		OnCancelAllEnemyCD_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCancelAllEnemyCD_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnCancelAllEnemyCD_bCancel_PropertyAddress, OnCancelAllEnemyCD_FunctionAddress, "bCancel");
		OnCancelAllEnemyCD_bCancel_Offset = NativeReflection.GetPropertyOffset(OnCancelAllEnemyCD_FunctionAddress, "bCancel");
		OnCancelAllEnemyCD_bCancel_IsValid = NativeReflection.ValidatePropertyClass(OnCancelAllEnemyCD_FunctionAddress, "bCancel", Classes.FBoolProperty);
		OnCancelAllEnemyCD_IsValid = OnCancelAllEnemyCD_FunctionAddress != IntPtr.Zero && OnCancelAllEnemyCD_bCancel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMUI:OnCancelAllEnemyCD", OnCancelAllEnemyCD_IsValid);
		OnClickDoSetConfigs_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnClickDoSetConfigs");
		OnClickDoSetConfigs_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickDoSetConfigs_FunctionAddress);
		OnClickDoSetConfigs_IsValid = OnClickDoSetConfigs_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMUI:OnClickDoSetConfigs", OnClickDoSetConfigs_IsValid);
		OnClickDoInvincible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnClickDoInvincible");
		OnClickDoInvincible_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickDoInvincible_FunctionAddress);
		OnClickDoInvincible_IsValid = OnClickDoInvincible_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMUI:OnClickDoInvincible", OnClickDoInvincible_IsValid);
		OnClickKillAllEnemy_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnClickKillAllEnemy");
		OnClickKillAllEnemy_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickKillAllEnemy_FunctionAddress);
		OnClickKillAllEnemy_IsValid = OnClickKillAllEnemy_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMUI:OnClickKillAllEnemy", OnClickKillAllEnemy_IsValid);
		OnClickDoAddBuff100_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnClickDoAddBuff100");
		OnClickDoAddBuff100_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickDoAddBuff100_FunctionAddress);
		OnClickDoAddBuff100_IsValid = OnClickDoAddBuff100_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMUI:OnClickDoAddBuff100", OnClickDoAddBuff100_IsValid);
		OnChangeDoInvincible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnChangeDoInvincible");
		OnChangeDoInvincible_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChangeDoInvincible_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnChangeDoInvincible_isChecked_PropertyAddress, OnChangeDoInvincible_FunctionAddress, "isChecked");
		OnChangeDoInvincible_isChecked_Offset = NativeReflection.GetPropertyOffset(OnChangeDoInvincible_FunctionAddress, "isChecked");
		OnChangeDoInvincible_isChecked_IsValid = NativeReflection.ValidatePropertyClass(OnChangeDoInvincible_FunctionAddress, "isChecked", Classes.FBoolProperty);
		OnChangeDoInvincible_IsValid = OnChangeDoInvincible_FunctionAddress != IntPtr.Zero && OnChangeDoInvincible_isChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMUI:OnChangeDoInvincible", OnChangeDoInvincible_IsValid);
		OnChangeDoLockStamina_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnChangeDoLockStamina");
		OnChangeDoLockStamina_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChangeDoLockStamina_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnChangeDoLockStamina_isChecked_PropertyAddress, OnChangeDoLockStamina_FunctionAddress, "isChecked");
		OnChangeDoLockStamina_isChecked_Offset = NativeReflection.GetPropertyOffset(OnChangeDoLockStamina_FunctionAddress, "isChecked");
		OnChangeDoLockStamina_isChecked_IsValid = NativeReflection.ValidatePropertyClass(OnChangeDoLockStamina_FunctionAddress, "isChecked", Classes.FBoolProperty);
		OnChangeDoLockStamina_IsValid = OnChangeDoLockStamina_FunctionAddress != IntPtr.Zero && OnChangeDoLockStamina_isChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMUI:OnChangeDoLockStamina", OnChangeDoLockStamina_IsValid);
		OnChangeDoLockEnemyHP_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnChangeDoLockEnemyHP");
		OnChangeDoLockEnemyHP_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChangeDoLockEnemyHP_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnChangeDoLockEnemyHP_isChecked_PropertyAddress, OnChangeDoLockEnemyHP_FunctionAddress, "isChecked");
		OnChangeDoLockEnemyHP_isChecked_Offset = NativeReflection.GetPropertyOffset(OnChangeDoLockEnemyHP_FunctionAddress, "isChecked");
		OnChangeDoLockEnemyHP_isChecked_IsValid = NativeReflection.ValidatePropertyClass(OnChangeDoLockEnemyHP_FunctionAddress, "isChecked", Classes.FBoolProperty);
		OnChangeDoLockEnemyHP_IsValid = OnChangeDoLockEnemyHP_FunctionAddress != IntPtr.Zero && OnChangeDoLockEnemyHP_isChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMUI:OnChangeDoLockEnemyHP", OnChangeDoLockEnemyHP_IsValid);
		OnClick999BloodBottle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnClick999BloodBottle");
		OnClick999BloodBottle_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClick999BloodBottle_FunctionAddress);
		OnClick999BloodBottle_IsValid = OnClick999BloodBottle_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMUI:OnClick999BloodBottle", OnClick999BloodBottle_IsValid);
		OnClickDoRemoveAllBuff_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnClickDoRemoveAllBuff");
		OnClickDoRemoveAllBuff_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickDoRemoveAllBuff_FunctionAddress);
		OnClickDoRemoveAllBuff_IsValid = OnClickDoRemoveAllBuff_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMUI:OnClickDoRemoveAllBuff", OnClickDoRemoveAllBuff_IsValid);
		OnClickFullBloodBottle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnClickFullBloodBottle");
		OnClickFullBloodBottle_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickFullBloodBottle_FunctionAddress);
		OnClickFullBloodBottle_IsValid = OnClickFullBloodBottle_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMUI:OnClickFullBloodBottle", OnClickFullBloodBottle_IsValid);
		OnChangeDoEnableEnemyBar_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnChangeDoEnableEnemyBar");
		OnChangeDoEnableEnemyBar_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChangeDoEnableEnemyBar_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnChangeDoEnableEnemyBar_isChecked_PropertyAddress, OnChangeDoEnableEnemyBar_FunctionAddress, "isChecked");
		OnChangeDoEnableEnemyBar_isChecked_Offset = NativeReflection.GetPropertyOffset(OnChangeDoEnableEnemyBar_FunctionAddress, "isChecked");
		OnChangeDoEnableEnemyBar_isChecked_IsValid = NativeReflection.ValidatePropertyClass(OnChangeDoEnableEnemyBar_FunctionAddress, "isChecked", Classes.FBoolProperty);
		OnChangeDoEnableEnemyBar_IsValid = OnChangeDoEnableEnemyBar_FunctionAddress != IntPtr.Zero && OnChangeDoEnableEnemyBar_isChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMUI:OnChangeDoEnableEnemyBar", OnChangeDoEnableEnemyBar_IsValid);
	}

	static BUI_GMUI()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_GMUI)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_GMUI));
	}
}
