using System;
using System.Collections.Generic;
using b1.UI;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

[BlueprintType]
[UClass]
[Blueprintable]
[USharpPath("/Script/b1-Managed.BUI_Startup")]
public class BUI_Startup : BUI_Widget
{
	private static readonly FName ComboBox_LevelList_Name;

	private static readonly FName InputText_CMD_Name;

	private static readonly FName DynamicEntryBox_GM_Name;

	private static readonly FName CheckBox_ApplyByDefault_Name;

	private static readonly FName CheckBox_NeverShowStartupUI_Name;

	private static readonly FName Button_OpenLevel_Name;

	private static readonly FName TextBlock_CommandName_Name;

	private static readonly FName CheckBox_Command_Name;

	private static bool OnSetInvisible_IsValid;

	private static IntPtr OnSetInvisible_FunctionAddress;

	private static int OnSetInvisible_ParamsSize;

	private static bool OnSetInvisible_bChecked_IsValid;

	private static int OnSetInvisible_bChecked_Offset;

	private static FFieldAddress OnSetInvisible_bChecked_PropertyAddress;

	private static bool OnChangeDoVSync_IsValid;

	private static IntPtr OnChangeDoVSync_FunctionAddress;

	private static int OnChangeDoVSync_ParamsSize;

	private static bool OnChangeDoVSync_bChecked_IsValid;

	private static int OnChangeDoVSync_bChecked_Offset;

	private static FFieldAddress OnChangeDoVSync_bChecked_PropertyAddress;

	private static bool OnClick_OpenLevel_IsValid;

	private static IntPtr OnClick_OpenLevel_FunctionAddress;

	private static int OnClick_OpenLevel_ParamsSize;

	private static bool OnChangeDoLockHP2_IsValid;

	private static IntPtr OnChangeDoLockHP2_FunctionAddress;

	private static int OnChangeDoLockHP2_ParamsSize;

	private static bool OnChangeDoLockHP2_bChecked_IsValid;

	private static int OnChangeDoLockHP2_bChecked_Offset;

	private static FFieldAddress OnChangeDoLockHP2_bChecked_PropertyAddress;

	private static bool OnToggleAllEnemyAI_IsValid;

	private static IntPtr OnToggleAllEnemyAI_FunctionAddress;

	private static int OnToggleAllEnemyAI_ParamsSize;

	private static bool OnToggleAllEnemyAI_bChecked_IsValid;

	private static int OnToggleAllEnemyAI_bChecked_Offset;

	private static FFieldAddress OnToggleAllEnemyAI_bChecked_PropertyAddress;

	private static bool OnChangeDoToggleUI_IsValid;

	private static IntPtr OnChangeDoToggleUI_FunctionAddress;

	private static int OnChangeDoToggleUI_ParamsSize;

	private static bool OnChangeDoToggleUI_bChecked_IsValid;

	private static int OnChangeDoToggleUI_bChecked_Offset;

	private static FFieldAddress OnChangeDoToggleUI_bChecked_PropertyAddress;

	private static bool OnCancelAllEnemyCD_IsValid;

	private static IntPtr OnCancelAllEnemyCD_FunctionAddress;

	private static int OnCancelAllEnemyCD_ParamsSize;

	private static bool OnCancelAllEnemyCD_bChecked_IsValid;

	private static int OnCancelAllEnemyCD_bChecked_Offset;

	private static FFieldAddress OnCancelAllEnemyCD_bChecked_PropertyAddress;

	private static bool OnCMDTextCommitted_IsValid;

	private static IntPtr OnCMDTextCommitted_FunctionAddress;

	private static int OnCMDTextCommitted_ParamsSize;

	private static bool OnCMDTextCommitted_Text_IsValid;

	private static int OnCMDTextCommitted_Text_Offset;

	private static FFieldAddress OnCMDTextCommitted_Text_PropertyAddress;

	private static bool OnCMDTextCommitted_CommitMethod_IsValid;

	private static int OnCMDTextCommitted_CommitMethod_Offset;

	private static FFieldAddress OnCMDTextCommitted_CommitMethod_PropertyAddress;

	private static bool OnChangeDoLock60FPS_IsValid;

	private static IntPtr OnChangeDoLock60FPS_FunctionAddress;

	private static int OnChangeDoLock60FPS_ParamsSize;

	private static bool OnChangeDoLock60FPS_bChecked_IsValid;

	private static int OnChangeDoLock60FPS_bChecked_Offset;

	private static FFieldAddress OnChangeDoLock60FPS_bChecked_PropertyAddress;

	private static bool OnChangeDoInvincible_IsValid;

	private static IntPtr OnChangeDoInvincible_FunctionAddress;

	private static int OnChangeDoInvincible_ParamsSize;

	private static bool OnChangeDoInvincible_bChecked_IsValid;

	private static int OnChangeDoInvincible_bChecked_Offset;

	private static FFieldAddress OnChangeDoInvincible_bChecked_PropertyAddress;

	private static bool OnChangeDoLockStamina_IsValid;

	private static IntPtr OnChangeDoLockStamina_FunctionAddress;

	private static int OnChangeDoLockStamina_ParamsSize;

	private static bool OnChangeDoLockStamina_bChecked_IsValid;

	private static int OnChangeDoLockStamina_bChecked_Offset;

	private static FFieldAddress OnChangeDoLockStamina_bChecked_PropertyAddress;

	private static bool OnChangeDoLockEnemyHP_IsValid;

	private static IntPtr OnChangeDoLockEnemyHP_FunctionAddress;

	private static int OnChangeDoLockEnemyHP_ParamsSize;

	private static bool OnChangeDoLockEnemyHP_bChecked_IsValid;

	private static int OnChangeDoLockEnemyHP_bChecked_Offset;

	private static FFieldAddress OnChangeDoLockEnemyHP_bChecked_PropertyAddress;

	private static bool OnChangeApplyByDefault_IsValid;

	private static IntPtr OnChangeApplyByDefault_FunctionAddress;

	private static int OnChangeApplyByDefault_ParamsSize;

	private static bool OnChangeApplyByDefault_bChecked_IsValid;

	private static int OnChangeApplyByDefault_bChecked_Offset;

	private static FFieldAddress OnChangeApplyByDefault_bChecked_PropertyAddress;

	private static bool OnLevelSelectionChanged_IsValid;

	private static IntPtr OnLevelSelectionChanged_FunctionAddress;

	private static int OnLevelSelectionChanged_ParamsSize;

	private static bool OnLevelSelectionChanged_SelectedItem_IsValid;

	private static int OnLevelSelectionChanged_SelectedItem_Offset;

	private static FFieldAddress OnLevelSelectionChanged_SelectedItem_PropertyAddress;

	private static bool OnLevelSelectionChanged_SelectionType_IsValid;

	private static int OnLevelSelectionChanged_SelectionType_Offset;

	private static FFieldAddress OnLevelSelectionChanged_SelectionType_PropertyAddress;

	private static bool OnChangeDoEnableEnemyBar_IsValid;

	private static IntPtr OnChangeDoEnableEnemyBar_FunctionAddress;

	private static int OnChangeDoEnableEnemyBar_ParamsSize;

	private static bool OnChangeDoEnableEnemyBar_bChecked_IsValid;

	private static int OnChangeDoEnableEnemyBar_bChecked_Offset;

	private static FFieldAddress OnChangeDoEnableEnemyBar_bChecked_PropertyAddress;

	private static bool OnChangeNeverShowStartupUI_IsValid;

	private static IntPtr OnChangeNeverShowStartupUI_FunctionAddress;

	private static int OnChangeNeverShowStartupUI_ParamsSize;

	private static bool OnChangeNeverShowStartupUI_bChecked_IsValid;

	private static int OnChangeNeverShowStartupUI_bChecked_Offset;

	private static FFieldAddress OnChangeNeverShowStartupUI_bChecked_PropertyAddress;

	private UComboBoxString ComboBox_LevelList { get; set; }

	private UMultiLineEditableTextBox InputText_CMD { get; set; }

	private UDynamicEntryBox DynamicEntryBox_GM { get; set; }

	private UCheckBox CheckBox_ApplyByDefault { get; set; }

	private UCheckBox CheckBox_NeverShowStartupUI { get; set; }

	private UButton Button_OpenLevel { get; set; }

	private UTextBlock TextBlock_CommandName { get; set; }

	private UCheckBox CheckBox_Command { get; set; }

	public string SelectedLevel { get; set; }

	public string DefaultCommands { get; set; }

	public Dictionary<EGMCommandType, FGMCommand> GMCommandDictionary { get; } = new Dictionary<EGMCommandType, FGMCommand>();

	public bool bApplyConfigurationByDefault { get; set; }

	public bool bNeverShowStartup { get; set; }

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		bApplyConfigurationByDefault = true;
		FGMCommand fGMCommand = new FGMCommand
		{
			CommandType = EGMCommandType.CancelEnemyCD,
			CommandName = "清所有怪物CD",
			CheckSignature = OnCancelAllEnemyCD,
			Func_GetCommand = (bool bEnable) => (!bEnable) ? "b.CancelEnemyCD false" : "b.CancelEnemyCD true"
		};
		FGMCommand fGMCommand2 = new FGMCommand
		{
			CommandType = EGMCommandType.Invincible,
			CommandName = "无敌",
			CheckSignature = OnChangeDoInvincible,
			Func_GetCommand = (bool bEnable) => (!bEnable) ? "b.UnInvincible" : "b.Invincible"
		};
		FGMCommand fGMCommand3 = new FGMCommand
		{
			CommandType = EGMCommandType.LockHP,
			CommandName = "锁血",
			CheckSignature = OnChangeDoLockHP2,
			Func_GetCommand = (bool bEnable) => (!bEnable) ? "b.UnlockHP" : "b.LockHP"
		};
		FGMCommand fGMCommand4 = new FGMCommand
		{
			CommandType = EGMCommandType.LockStamina,
			CommandName = "锁体力",
			CheckSignature = OnChangeDoLockStamina,
			Func_GetCommand = (bool bEnable) => (!bEnable) ? "b.UnLockStamina" : "b.LockStamina"
		};
		FGMCommand fGMCommand5 = new FGMCommand
		{
			CommandType = EGMCommandType.Invisible,
			CommandName = "隐身",
			CheckSignature = OnSetInvisible,
			Func_GetCommand = (bool bEnable) => (!bEnable) ? "b.UnInvisible" : "b.Invisible"
		};
		FGMCommand fGMCommand6 = new FGMCommand
		{
			CommandType = EGMCommandType.LockEnemyHP,
			CommandName = "锁全场怪物血",
			CheckSignature = OnChangeDoLockEnemyHP,
			Func_GetCommand = (bool bEnable) => (!bEnable) ? "b.UnLockEnemyHP" : "b.LockEnemyHP"
		};
		FGMCommand fGMCommand7 = new FGMCommand
		{
			CommandType = EGMCommandType.ToggleAllEnemyAI,
			CommandName = "暂停所有怪物AI",
			CheckSignature = OnToggleAllEnemyAI,
			Func_GetCommand = (bool bEnable) => (!bEnable) ? "b.ToggleAllEnemyAI false" : "b.ToggleAllEnemyAI true"
		};
		FGMCommand fGMCommand8 = new FGMCommand
		{
			CommandType = EGMCommandType.ShowBattleUI,
			CommandName = "显示战斗UI",
			CheckSignature = OnChangeDoToggleUI,
			Func_GetCommand = (bool bEnable) => (!bEnable) ? "b.showBattleUI 2" : "b.showBattleUI 1"
		};
		FGMCommand fGMCommand9 = new FGMCommand
		{
			CommandType = EGMCommandType.EnableEnemyBar,
			CommandName = "允许显示小怪血条",
			CheckSignature = OnChangeDoEnableEnemyBar,
			Func_GetCommand = (bool bEnable) => (!bEnable) ? "b.EnableEnemyBar false" : "b.EnableEnemyBar true"
		};
		FGMCommand fGMCommand10 = new FGMCommand
		{
			CommandType = EGMCommandType.Lock60FPS,
			CommandName = "锁60帧",
			CheckSignature = OnChangeDoLock60FPS,
			Func_GetCommand = (bool bEnable) => (!bEnable) ? "t.MaxFPS 0" : "t.MaxFPS 60"
		};
		FGMCommand fGMCommand11 = new FGMCommand
		{
			CommandType = EGMCommandType.VSync,
			CommandName = "垂直同步",
			CheckSignature = OnChangeDoVSync,
			Func_GetCommand = (bool bEnable) => (!bEnable) ? "r.VSync 0" : "r.VSync 1"
		};
		GMCommandDictionary.Clear();
		GMCommandDictionary.Add(fGMCommand.CommandType, fGMCommand);
		GMCommandDictionary.Add(fGMCommand2.CommandType, fGMCommand2);
		GMCommandDictionary.Add(fGMCommand3.CommandType, fGMCommand3);
		GMCommandDictionary.Add(fGMCommand4.CommandType, fGMCommand4);
		GMCommandDictionary.Add(fGMCommand5.CommandType, fGMCommand5);
		GMCommandDictionary.Add(fGMCommand6.CommandType, fGMCommand6);
		GMCommandDictionary.Add(fGMCommand7.CommandType, fGMCommand7);
		GMCommandDictionary.Add(fGMCommand8.CommandType, fGMCommand8);
		GMCommandDictionary.Add(fGMCommand9.CommandType, fGMCommand9);
		GMCommandDictionary.Add(fGMCommand10.CommandType, fGMCommand10);
		GMCommandDictionary.Add(fGMCommand11.CommandType, fGMCommand11);
	}

	protected override void OnUIInitialized()
	{
		base.OnUIInitialized();
		SelectedLevel = UB1Util.GetStartLevelName();
		if (UB1Util.GetStartCommandList(out var OutStartCommandList) > 0)
		{
			DefaultCommands = string.Join("\n", OutStartCommandList);
		}
		if (UB1Util.GetGMCommandList(out var OutGMCommandList) > 0)
		{
			foreach (byte key in OutGMCommandList.Keys)
			{
				GMCommandDictionary[(EGMCommandType)key].bEnable = true;
			}
		}
		ComboBox_LevelList = FindChildWidget(ComboBox_LevelList_Name) as UComboBoxString;
		InputText_CMD = FindChildWidget(InputText_CMD_Name) as UMultiLineEditableTextBox;
		DynamicEntryBox_GM = FindChildWidget(DynamicEntryBox_GM_Name) as UDynamicEntryBox;
		CheckBox_ApplyByDefault = FindChildWidget(CheckBox_ApplyByDefault_Name) as UCheckBox;
		CheckBox_NeverShowStartupUI = FindChildWidget(CheckBox_NeverShowStartupUI_Name) as UCheckBox;
		Button_OpenLevel = FindChildWidget(Button_OpenLevel_Name) as UButton;
		if (UB1Util.GetAvailableMaps(out var OutAvailableMaps) > 0)
		{
			foreach (string item in OutAvailableMaps)
			{
				ComboBox_LevelList.AddOption(item);
				if (SelectedLevel == item)
				{
					ComboBox_LevelList.SetSelectedOption(item);
				}
			}
		}
		ComboBox_LevelList.OnSelectionChanged.Bind(OnLevelSelectionChanged);
		InputText_CMD.SetText(FText.FromString(DefaultCommands));
		InputText_CMD.OnTextCommitted.Bind(OnCMDTextCommitted);
		foreach (FGMCommand value in GMCommandDictionary.Values)
		{
			AddGMCommandToDynamicEntryBox(DynamicEntryBox_GM, value);
		}
		CheckBox_ApplyByDefault.SetIsChecked(bApplyConfigurationByDefault);
		CheckBox_ApplyByDefault.OnCheckStateChanged.Bind(OnChangeApplyByDefault);
		CheckBox_NeverShowStartupUI.OnCheckStateChanged.Bind(OnChangeNeverShowStartupUI);
		Button_OpenLevel.OnClicked.Bind(OnClick_OpenLevel);
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
	}

	private void AddGMCommandToDynamicEntryBox(UDynamicEntryBox Deb, FGMCommand GMCommand)
	{
		UUserWidget widget = Deb.BP_CreateEntry();
		TextBlock_CommandName = UGSE_UMGFuncLib.GetWidgetFromName(widget, TextBlock_CommandName_Name) as UTextBlock;
		CheckBox_Command = UGSE_UMGFuncLib.GetWidgetFromName(widget, CheckBox_Command_Name) as UCheckBox;
		if (!(TextBlock_CommandName == null) && !(CheckBox_Command == null))
		{
			TextBlock_CommandName.SetText(FText.FromString(GMCommand.CommandName));
			if (GMCommand.bEnable)
			{
				CheckBox_Command.SetIsChecked(InIsChecked: true);
			}
			CheckBox_Command.OnCheckStateChanged.Bind(GMCommand.CheckSignature);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_Startup:OnLevelSelectionChanged")]
	public void OnLevelSelectionChanged(string SelectedItem, ESelectInfo SelectionType)
	{
		if (SelectionType == ESelectInfo.OnMouseClick || SelectionType == ESelectInfo.Direct)
		{
			SelectedLevel = SelectedItem;
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_Startup:OnCMDTextCommitted")]
	public void OnCMDTextCommitted(FText Text, ETextCommit CommitMethod)
	{
		if (CommitMethod == ETextCommit.OnUserMovedFocus)
		{
			DefaultCommands = Text.ToString();
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_Startup:OnChangeApplyByDefault")]
	public void OnChangeApplyByDefault(bool bChecked)
	{
		bApplyConfigurationByDefault = bChecked;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_Startup:OnChangeNeverShowStartupUI")]
	public void OnChangeNeverShowStartupUI(bool bChecked)
	{
		bNeverShowStartup = bChecked;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_Startup:OnClick_OpenLevel")]
	public void OnClick_OpenLevel()
	{
		if (!string.IsNullOrEmpty(SelectedLevel))
		{
			UB1Util.SetStartLevelName(SelectedLevel);
		}
		UB1Util.SetNeverShowStartupUI(bNeverShowStartup);
		List<string> list = new List<string>();
		if (!string.IsNullOrEmpty(DefaultCommands))
		{
			list.AddRange(DefaultCommands.Split('\n'));
		}
		UB1Util.SetStartCommandList(list);
		Dictionary<byte, string> dictionary = new Dictionary<byte, string>();
		foreach (FGMCommand value in GMCommandDictionary.Values)
		{
			if (value.bEnable)
			{
				dictionary.Add((byte)value.CommandType, value.GetCommand());
			}
		}
		UB1Util.SetGMCommandList(dictionary);
		if (bApplyConfigurationByDefault)
		{
			UB1Util.SaveGameUserSettings();
		}
		if (!string.IsNullOrEmpty(SelectedLevel))
		{
			USystemLibrary.ExecuteConsoleCommand(this, "Travel " + SelectedLevel, null);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_Startup:OnChangeDoToggleUI")]
	public void OnChangeDoToggleUI(bool bChecked)
	{
		GMCommandDictionary[EGMCommandType.ShowBattleUI].bEnable = bChecked;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_Startup:OnChangeDoEnableEnemyBar")]
	public void OnChangeDoEnableEnemyBar(bool bChecked)
	{
		GMCommandDictionary[EGMCommandType.EnableEnemyBar].bEnable = bChecked;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_Startup:OnChangeDoLock60FPS")]
	public void OnChangeDoLock60FPS(bool bChecked)
	{
		GMCommandDictionary[EGMCommandType.Lock60FPS].bEnable = bChecked;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_Startup:OnChangeDoVSync")]
	public void OnChangeDoVSync(bool bChecked)
	{
		GMCommandDictionary[EGMCommandType.VSync].bEnable = bChecked;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_Startup:OnChangeDoInvincible")]
	public void OnChangeDoInvincible(bool bChecked)
	{
		GMCommandDictionary[EGMCommandType.Invincible].bEnable = bChecked;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_Startup:OnChangeDoLockHP2")]
	public void OnChangeDoLockHP2(bool bChecked)
	{
		GMCommandDictionary[EGMCommandType.LockHP].bEnable = bChecked;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_Startup:OnChangeDoLockStamina")]
	public void OnChangeDoLockStamina(bool bChecked)
	{
		GMCommandDictionary[EGMCommandType.LockStamina].bEnable = bChecked;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_Startup:OnSetInvisible")]
	public void OnSetInvisible(bool bChecked)
	{
		GMCommandDictionary[EGMCommandType.Invisible].bEnable = bChecked;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_Startup:OnChangeDoLockEnemyHP")]
	public void OnChangeDoLockEnemyHP(bool bChecked)
	{
		GMCommandDictionary[EGMCommandType.LockEnemyHP].bEnable = bChecked;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_Startup:OnCancelAllEnemyCD")]
	public void OnCancelAllEnemyCD(bool bChecked)
	{
		GMCommandDictionary[EGMCommandType.CancelEnemyCD].bEnable = bChecked;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_Startup:OnToggleAllEnemyAI")]
	public void OnToggleAllEnemyAI(bool bChecked)
	{
		GMCommandDictionary[EGMCommandType.ToggleAllEnemyAI].bEnable = bChecked;
	}

	static BUI_Startup()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_Startup)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_Startup));
		ComboBox_LevelList_Name = B1GlobalFNames.ComboBox_LevelList;
		InputText_CMD_Name = B1GlobalFNames.InputText_CMD;
		DynamicEntryBox_GM_Name = B1GlobalFNames.DynamicEntryBox_GM;
		CheckBox_ApplyByDefault_Name = B1GlobalFNames.CheckBox_ApplyByDefault;
		CheckBox_NeverShowStartupUI_Name = B1GlobalFNames.CheckBox_NeverShowStartupUI;
		Button_OpenLevel_Name = B1GlobalFNames.Button_OpenLevel;
		TextBlock_CommandName_Name = B1GlobalFNames.TextBlock_CommandName;
		CheckBox_Command_Name = B1GlobalFNames.CheckBox_Command;
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Startup:OnSetInvisible")]
	private static void OnSetInvisible__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Startup bUI_Startup = GCHelper.Find<BUI_Startup>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnSetInvisible_bChecked_Offset), 0, OnSetInvisible_bChecked_PropertyAddress.Address);
		bUI_Startup.OnSetInvisible(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Startup:OnChangeDoVSync")]
	private static void OnChangeDoVSync__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Startup bUI_Startup = GCHelper.Find<BUI_Startup>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnChangeDoVSync_bChecked_Offset), 0, OnChangeDoVSync_bChecked_PropertyAddress.Address);
		bUI_Startup.OnChangeDoVSync(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Startup:OnClick_OpenLevel")]
	private static void OnClick_OpenLevel__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Startup bUI_Startup = GCHelper.Find<BUI_Startup>(obj);
		bUI_Startup.OnClick_OpenLevel();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Startup:OnChangeDoLockHP2")]
	private static void OnChangeDoLockHP2__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Startup bUI_Startup = GCHelper.Find<BUI_Startup>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnChangeDoLockHP2_bChecked_Offset), 0, OnChangeDoLockHP2_bChecked_PropertyAddress.Address);
		bUI_Startup.OnChangeDoLockHP2(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Startup:OnToggleAllEnemyAI")]
	private static void OnToggleAllEnemyAI__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Startup bUI_Startup = GCHelper.Find<BUI_Startup>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnToggleAllEnemyAI_bChecked_Offset), 0, OnToggleAllEnemyAI_bChecked_PropertyAddress.Address);
		bUI_Startup.OnToggleAllEnemyAI(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Startup:OnChangeDoToggleUI")]
	private static void OnChangeDoToggleUI__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Startup bUI_Startup = GCHelper.Find<BUI_Startup>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnChangeDoToggleUI_bChecked_Offset), 0, OnChangeDoToggleUI_bChecked_PropertyAddress.Address);
		bUI_Startup.OnChangeDoToggleUI(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Startup:OnCancelAllEnemyCD")]
	private static void OnCancelAllEnemyCD__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Startup bUI_Startup = GCHelper.Find<BUI_Startup>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnCancelAllEnemyCD_bChecked_Offset), 0, OnCancelAllEnemyCD_bChecked_PropertyAddress.Address);
		bUI_Startup.OnCancelAllEnemyCD(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Startup:OnCMDTextCommitted")]
	private static void OnCMDTextCommitted__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Startup bUI_Startup = GCHelper.Find<BUI_Startup>(obj);
		FText text = FTextMarshaler.FromNative(IntPtr.Add(buffer, OnCMDTextCommitted_Text_Offset));
		ETextCommit commitMethod = EnumMarshaler<ETextCommit>.FromNative(IntPtr.Add(buffer, OnCMDTextCommitted_CommitMethod_Offset), 0, OnCMDTextCommitted_CommitMethod_PropertyAddress.Address);
		bUI_Startup.OnCMDTextCommitted(text, commitMethod);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Startup:OnChangeDoLock60FPS")]
	private static void OnChangeDoLock60FPS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Startup bUI_Startup = GCHelper.Find<BUI_Startup>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnChangeDoLock60FPS_bChecked_Offset), 0, OnChangeDoLock60FPS_bChecked_PropertyAddress.Address);
		bUI_Startup.OnChangeDoLock60FPS(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Startup:OnChangeDoInvincible")]
	private static void OnChangeDoInvincible__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Startup bUI_Startup = GCHelper.Find<BUI_Startup>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnChangeDoInvincible_bChecked_Offset), 0, OnChangeDoInvincible_bChecked_PropertyAddress.Address);
		bUI_Startup.OnChangeDoInvincible(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Startup:OnChangeDoLockStamina")]
	private static void OnChangeDoLockStamina__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Startup bUI_Startup = GCHelper.Find<BUI_Startup>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnChangeDoLockStamina_bChecked_Offset), 0, OnChangeDoLockStamina_bChecked_PropertyAddress.Address);
		bUI_Startup.OnChangeDoLockStamina(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Startup:OnChangeDoLockEnemyHP")]
	private static void OnChangeDoLockEnemyHP__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Startup bUI_Startup = GCHelper.Find<BUI_Startup>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnChangeDoLockEnemyHP_bChecked_Offset), 0, OnChangeDoLockEnemyHP_bChecked_PropertyAddress.Address);
		bUI_Startup.OnChangeDoLockEnemyHP(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Startup:OnChangeApplyByDefault")]
	private static void OnChangeApplyByDefault__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Startup bUI_Startup = GCHelper.Find<BUI_Startup>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnChangeApplyByDefault_bChecked_Offset), 0, OnChangeApplyByDefault_bChecked_PropertyAddress.Address);
		bUI_Startup.OnChangeApplyByDefault(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Startup:OnLevelSelectionChanged")]
	private static void OnLevelSelectionChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Startup bUI_Startup = GCHelper.Find<BUI_Startup>(obj);
		string selectedItem = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnLevelSelectionChanged_SelectedItem_Offset));
		ESelectInfo selectionType = EnumMarshaler<ESelectInfo>.FromNative(IntPtr.Add(buffer, OnLevelSelectionChanged_SelectionType_Offset), 0, OnLevelSelectionChanged_SelectionType_PropertyAddress.Address);
		bUI_Startup.OnLevelSelectionChanged(selectedItem, selectionType);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Startup:OnChangeDoEnableEnemyBar")]
	private static void OnChangeDoEnableEnemyBar__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Startup bUI_Startup = GCHelper.Find<BUI_Startup>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnChangeDoEnableEnemyBar_bChecked_Offset), 0, OnChangeDoEnableEnemyBar_bChecked_PropertyAddress.Address);
		bUI_Startup.OnChangeDoEnableEnemyBar(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Startup:OnChangeNeverShowStartupUI")]
	private static void OnChangeNeverShowStartupUI__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Startup bUI_Startup = GCHelper.Find<BUI_Startup>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnChangeNeverShowStartupUI_bChecked_Offset), 0, OnChangeNeverShowStartupUI_bChecked_PropertyAddress.Address);
		bUI_Startup.OnChangeNeverShowStartupUI(bChecked);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_Startup");
		OnSetInvisible_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSetInvisible");
		OnSetInvisible_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSetInvisible_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnSetInvisible_bChecked_PropertyAddress, OnSetInvisible_FunctionAddress, "bChecked");
		OnSetInvisible_bChecked_Offset = NativeReflection.GetPropertyOffset(OnSetInvisible_FunctionAddress, "bChecked");
		OnSetInvisible_bChecked_IsValid = NativeReflection.ValidatePropertyClass(OnSetInvisible_FunctionAddress, "bChecked", Classes.FBoolProperty);
		OnSetInvisible_IsValid = OnSetInvisible_FunctionAddress != IntPtr.Zero && OnSetInvisible_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Startup:OnSetInvisible", OnSetInvisible_IsValid);
		OnChangeDoVSync_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnChangeDoVSync");
		OnChangeDoVSync_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChangeDoVSync_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnChangeDoVSync_bChecked_PropertyAddress, OnChangeDoVSync_FunctionAddress, "bChecked");
		OnChangeDoVSync_bChecked_Offset = NativeReflection.GetPropertyOffset(OnChangeDoVSync_FunctionAddress, "bChecked");
		OnChangeDoVSync_bChecked_IsValid = NativeReflection.ValidatePropertyClass(OnChangeDoVSync_FunctionAddress, "bChecked", Classes.FBoolProperty);
		OnChangeDoVSync_IsValid = OnChangeDoVSync_FunctionAddress != IntPtr.Zero && OnChangeDoVSync_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Startup:OnChangeDoVSync", OnChangeDoVSync_IsValid);
		OnClick_OpenLevel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnClick_OpenLevel");
		OnClick_OpenLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClick_OpenLevel_FunctionAddress);
		OnClick_OpenLevel_IsValid = OnClick_OpenLevel_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Startup:OnClick_OpenLevel", OnClick_OpenLevel_IsValid);
		OnChangeDoLockHP2_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnChangeDoLockHP2");
		OnChangeDoLockHP2_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChangeDoLockHP2_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnChangeDoLockHP2_bChecked_PropertyAddress, OnChangeDoLockHP2_FunctionAddress, "bChecked");
		OnChangeDoLockHP2_bChecked_Offset = NativeReflection.GetPropertyOffset(OnChangeDoLockHP2_FunctionAddress, "bChecked");
		OnChangeDoLockHP2_bChecked_IsValid = NativeReflection.ValidatePropertyClass(OnChangeDoLockHP2_FunctionAddress, "bChecked", Classes.FBoolProperty);
		OnChangeDoLockHP2_IsValid = OnChangeDoLockHP2_FunctionAddress != IntPtr.Zero && OnChangeDoLockHP2_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Startup:OnChangeDoLockHP2", OnChangeDoLockHP2_IsValid);
		OnToggleAllEnemyAI_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnToggleAllEnemyAI");
		OnToggleAllEnemyAI_ParamsSize = NativeReflection.GetFunctionParamsSize(OnToggleAllEnemyAI_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnToggleAllEnemyAI_bChecked_PropertyAddress, OnToggleAllEnemyAI_FunctionAddress, "bChecked");
		OnToggleAllEnemyAI_bChecked_Offset = NativeReflection.GetPropertyOffset(OnToggleAllEnemyAI_FunctionAddress, "bChecked");
		OnToggleAllEnemyAI_bChecked_IsValid = NativeReflection.ValidatePropertyClass(OnToggleAllEnemyAI_FunctionAddress, "bChecked", Classes.FBoolProperty);
		OnToggleAllEnemyAI_IsValid = OnToggleAllEnemyAI_FunctionAddress != IntPtr.Zero && OnToggleAllEnemyAI_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Startup:OnToggleAllEnemyAI", OnToggleAllEnemyAI_IsValid);
		OnChangeDoToggleUI_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnChangeDoToggleUI");
		OnChangeDoToggleUI_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChangeDoToggleUI_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnChangeDoToggleUI_bChecked_PropertyAddress, OnChangeDoToggleUI_FunctionAddress, "bChecked");
		OnChangeDoToggleUI_bChecked_Offset = NativeReflection.GetPropertyOffset(OnChangeDoToggleUI_FunctionAddress, "bChecked");
		OnChangeDoToggleUI_bChecked_IsValid = NativeReflection.ValidatePropertyClass(OnChangeDoToggleUI_FunctionAddress, "bChecked", Classes.FBoolProperty);
		OnChangeDoToggleUI_IsValid = OnChangeDoToggleUI_FunctionAddress != IntPtr.Zero && OnChangeDoToggleUI_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Startup:OnChangeDoToggleUI", OnChangeDoToggleUI_IsValid);
		OnCancelAllEnemyCD_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCancelAllEnemyCD");
		OnCancelAllEnemyCD_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCancelAllEnemyCD_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnCancelAllEnemyCD_bChecked_PropertyAddress, OnCancelAllEnemyCD_FunctionAddress, "bChecked");
		OnCancelAllEnemyCD_bChecked_Offset = NativeReflection.GetPropertyOffset(OnCancelAllEnemyCD_FunctionAddress, "bChecked");
		OnCancelAllEnemyCD_bChecked_IsValid = NativeReflection.ValidatePropertyClass(OnCancelAllEnemyCD_FunctionAddress, "bChecked", Classes.FBoolProperty);
		OnCancelAllEnemyCD_IsValid = OnCancelAllEnemyCD_FunctionAddress != IntPtr.Zero && OnCancelAllEnemyCD_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Startup:OnCancelAllEnemyCD", OnCancelAllEnemyCD_IsValid);
		OnCMDTextCommitted_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCMDTextCommitted");
		OnCMDTextCommitted_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCMDTextCommitted_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnCMDTextCommitted_Text_PropertyAddress, OnCMDTextCommitted_FunctionAddress, "Text");
		OnCMDTextCommitted_Text_Offset = NativeReflection.GetPropertyOffset(OnCMDTextCommitted_FunctionAddress, "Text");
		OnCMDTextCommitted_Text_IsValid = NativeReflection.ValidatePropertyClass(OnCMDTextCommitted_FunctionAddress, "Text", Classes.FTextProperty);
		NativeReflection.GetPropertyRef(ref OnCMDTextCommitted_CommitMethod_PropertyAddress, OnCMDTextCommitted_FunctionAddress, "CommitMethod");
		OnCMDTextCommitted_CommitMethod_Offset = NativeReflection.GetPropertyOffset(OnCMDTextCommitted_FunctionAddress, "CommitMethod");
		OnCMDTextCommitted_CommitMethod_IsValid = NativeReflection.ValidatePropertyClass(OnCMDTextCommitted_FunctionAddress, "CommitMethod", Classes.FEnumProperty);
		OnCMDTextCommitted_IsValid = OnCMDTextCommitted_FunctionAddress != IntPtr.Zero && OnCMDTextCommitted_Text_IsValid && OnCMDTextCommitted_CommitMethod_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Startup:OnCMDTextCommitted", OnCMDTextCommitted_IsValid);
		OnChangeDoLock60FPS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnChangeDoLock60FPS");
		OnChangeDoLock60FPS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChangeDoLock60FPS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnChangeDoLock60FPS_bChecked_PropertyAddress, OnChangeDoLock60FPS_FunctionAddress, "bChecked");
		OnChangeDoLock60FPS_bChecked_Offset = NativeReflection.GetPropertyOffset(OnChangeDoLock60FPS_FunctionAddress, "bChecked");
		OnChangeDoLock60FPS_bChecked_IsValid = NativeReflection.ValidatePropertyClass(OnChangeDoLock60FPS_FunctionAddress, "bChecked", Classes.FBoolProperty);
		OnChangeDoLock60FPS_IsValid = OnChangeDoLock60FPS_FunctionAddress != IntPtr.Zero && OnChangeDoLock60FPS_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Startup:OnChangeDoLock60FPS", OnChangeDoLock60FPS_IsValid);
		OnChangeDoInvincible_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnChangeDoInvincible");
		OnChangeDoInvincible_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChangeDoInvincible_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnChangeDoInvincible_bChecked_PropertyAddress, OnChangeDoInvincible_FunctionAddress, "bChecked");
		OnChangeDoInvincible_bChecked_Offset = NativeReflection.GetPropertyOffset(OnChangeDoInvincible_FunctionAddress, "bChecked");
		OnChangeDoInvincible_bChecked_IsValid = NativeReflection.ValidatePropertyClass(OnChangeDoInvincible_FunctionAddress, "bChecked", Classes.FBoolProperty);
		OnChangeDoInvincible_IsValid = OnChangeDoInvincible_FunctionAddress != IntPtr.Zero && OnChangeDoInvincible_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Startup:OnChangeDoInvincible", OnChangeDoInvincible_IsValid);
		OnChangeDoLockStamina_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnChangeDoLockStamina");
		OnChangeDoLockStamina_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChangeDoLockStamina_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnChangeDoLockStamina_bChecked_PropertyAddress, OnChangeDoLockStamina_FunctionAddress, "bChecked");
		OnChangeDoLockStamina_bChecked_Offset = NativeReflection.GetPropertyOffset(OnChangeDoLockStamina_FunctionAddress, "bChecked");
		OnChangeDoLockStamina_bChecked_IsValid = NativeReflection.ValidatePropertyClass(OnChangeDoLockStamina_FunctionAddress, "bChecked", Classes.FBoolProperty);
		OnChangeDoLockStamina_IsValid = OnChangeDoLockStamina_FunctionAddress != IntPtr.Zero && OnChangeDoLockStamina_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Startup:OnChangeDoLockStamina", OnChangeDoLockStamina_IsValid);
		OnChangeDoLockEnemyHP_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnChangeDoLockEnemyHP");
		OnChangeDoLockEnemyHP_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChangeDoLockEnemyHP_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnChangeDoLockEnemyHP_bChecked_PropertyAddress, OnChangeDoLockEnemyHP_FunctionAddress, "bChecked");
		OnChangeDoLockEnemyHP_bChecked_Offset = NativeReflection.GetPropertyOffset(OnChangeDoLockEnemyHP_FunctionAddress, "bChecked");
		OnChangeDoLockEnemyHP_bChecked_IsValid = NativeReflection.ValidatePropertyClass(OnChangeDoLockEnemyHP_FunctionAddress, "bChecked", Classes.FBoolProperty);
		OnChangeDoLockEnemyHP_IsValid = OnChangeDoLockEnemyHP_FunctionAddress != IntPtr.Zero && OnChangeDoLockEnemyHP_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Startup:OnChangeDoLockEnemyHP", OnChangeDoLockEnemyHP_IsValid);
		OnChangeApplyByDefault_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnChangeApplyByDefault");
		OnChangeApplyByDefault_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChangeApplyByDefault_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnChangeApplyByDefault_bChecked_PropertyAddress, OnChangeApplyByDefault_FunctionAddress, "bChecked");
		OnChangeApplyByDefault_bChecked_Offset = NativeReflection.GetPropertyOffset(OnChangeApplyByDefault_FunctionAddress, "bChecked");
		OnChangeApplyByDefault_bChecked_IsValid = NativeReflection.ValidatePropertyClass(OnChangeApplyByDefault_FunctionAddress, "bChecked", Classes.FBoolProperty);
		OnChangeApplyByDefault_IsValid = OnChangeApplyByDefault_FunctionAddress != IntPtr.Zero && OnChangeApplyByDefault_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Startup:OnChangeApplyByDefault", OnChangeApplyByDefault_IsValid);
		OnLevelSelectionChanged_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnLevelSelectionChanged");
		OnLevelSelectionChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLevelSelectionChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnLevelSelectionChanged_SelectedItem_PropertyAddress, OnLevelSelectionChanged_FunctionAddress, "SelectedItem");
		OnLevelSelectionChanged_SelectedItem_Offset = NativeReflection.GetPropertyOffset(OnLevelSelectionChanged_FunctionAddress, "SelectedItem");
		OnLevelSelectionChanged_SelectedItem_IsValid = NativeReflection.ValidatePropertyClass(OnLevelSelectionChanged_FunctionAddress, "SelectedItem", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnLevelSelectionChanged_SelectionType_PropertyAddress, OnLevelSelectionChanged_FunctionAddress, "SelectionType");
		OnLevelSelectionChanged_SelectionType_Offset = NativeReflection.GetPropertyOffset(OnLevelSelectionChanged_FunctionAddress, "SelectionType");
		OnLevelSelectionChanged_SelectionType_IsValid = NativeReflection.ValidatePropertyClass(OnLevelSelectionChanged_FunctionAddress, "SelectionType", Classes.FEnumProperty);
		OnLevelSelectionChanged_IsValid = OnLevelSelectionChanged_FunctionAddress != IntPtr.Zero && OnLevelSelectionChanged_SelectedItem_IsValid && OnLevelSelectionChanged_SelectionType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Startup:OnLevelSelectionChanged", OnLevelSelectionChanged_IsValid);
		OnChangeDoEnableEnemyBar_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnChangeDoEnableEnemyBar");
		OnChangeDoEnableEnemyBar_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChangeDoEnableEnemyBar_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnChangeDoEnableEnemyBar_bChecked_PropertyAddress, OnChangeDoEnableEnemyBar_FunctionAddress, "bChecked");
		OnChangeDoEnableEnemyBar_bChecked_Offset = NativeReflection.GetPropertyOffset(OnChangeDoEnableEnemyBar_FunctionAddress, "bChecked");
		OnChangeDoEnableEnemyBar_bChecked_IsValid = NativeReflection.ValidatePropertyClass(OnChangeDoEnableEnemyBar_FunctionAddress, "bChecked", Classes.FBoolProperty);
		OnChangeDoEnableEnemyBar_IsValid = OnChangeDoEnableEnemyBar_FunctionAddress != IntPtr.Zero && OnChangeDoEnableEnemyBar_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Startup:OnChangeDoEnableEnemyBar", OnChangeDoEnableEnemyBar_IsValid);
		OnChangeNeverShowStartupUI_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnChangeNeverShowStartupUI");
		OnChangeNeverShowStartupUI_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChangeNeverShowStartupUI_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnChangeNeverShowStartupUI_bChecked_PropertyAddress, OnChangeNeverShowStartupUI_FunctionAddress, "bChecked");
		OnChangeNeverShowStartupUI_bChecked_Offset = NativeReflection.GetPropertyOffset(OnChangeNeverShowStartupUI_FunctionAddress, "bChecked");
		OnChangeNeverShowStartupUI_bChecked_IsValid = NativeReflection.ValidatePropertyClass(OnChangeNeverShowStartupUI_FunctionAddress, "bChecked", Classes.FBoolProperty);
		OnChangeNeverShowStartupUI_IsValid = OnChangeNeverShowStartupUI_FunctionAddress != IntPtr.Zero && OnChangeNeverShowStartupUI_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Startup:OnChangeNeverShowStartupUI", OnChangeNeverShowStartupUI_IsValid);
	}
}
