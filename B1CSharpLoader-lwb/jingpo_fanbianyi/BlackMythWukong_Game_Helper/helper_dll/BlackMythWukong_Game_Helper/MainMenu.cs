using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using b1;
using b1.BGW;
using b1.Localization;
using b1.UI;
using B1UI;
using B1UI.GSUI;
using BtlB1;
using CommB1;
using Google.Protobuf.Collections;
using GSE.GSICore.Event;
using GSE.GSUI;
using HarmonyLib;
using Newtonsoft.Json;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace BlackMythWukong_Game_Helper;

public class MainMenu
{
	[HarmonyPatch]
	public class Hook_UIEditionAward_OnChangeActiveItem
	{
		private static MethodBase TargetMethod()
		{
			return AccessTools.Method("B1UI.GSUI.UIEditionAward:OnChangeActiveItem", (Type[])null, (Type[])null);
		}

		[HarmonyPatch]
		private static bool Prefix(UIEditionAward __instance, ChangeReason Reason, DSRoleItem OldValue, DSRoleItem NewValue)
		{
			if (NewValue == null)
			{
				return true;
			}
			URichTextBlock fieldOrProperty = __instance.GetFieldOrProperty<URichTextBlock>("TxtItemName");
			UTextBlock fieldOrProperty2 = __instance.GetFieldOrProperty<UTextBlock>("TxtTips");
			ItemDesc itemDesc = GameDBRuntime.GetItemDesc(NewValue.ItemId);
			if (itemDesc != null && fieldOrProperty2 != null)
			{
				fieldOrProperty.SetText(GSLocalization.ToFText(itemDesc.Name) + GSLocalization.ToFText($"({NewValue.Num})"));
				fieldOrProperty2.SetText(GSLocalization.ToFText("每日领取奖励"));
			}
			return false;
		}
	}

	[HarmonyPatch]
	public class Hook_UIEditionAward_OnLongPressFinishEvent
	{
		private static MethodBase TargetMethod()
		{
			return AccessTools.Method("B1UI.GSUI.UIEditionAward:OnLongPressFinishEvent", (Type[])null, (Type[])null);
		}

		[HarmonyPatch]
		private static bool Prefix(UIEditionAward __instance)
		{
			if (GlobalObjectMgr.IEditionAward <= 0)
			{
				GlobalObjectMgr.IEditionAward = 0;
				GSB1UIUtil.ShowConfirm(null, FText.FromString("今日次数已用完"), FText.FromString("确定"), null, ShowCancel: false);
				return false;
			}
			Console.WriteLine("领取成功");
			GlobalObjectMgr.IEditionAward--;
			return true;
		}
	}

	private UIShrineMain _ShrineMain;

	private APawn _apawn;

	private UWorld _world;

	private FMenuHelper<EShrineMenuTag> _fMenuHelper;

	private FMenuHelper<ETeleportMenuTag> _teleportHelper;

	private static MainMenu _Instance;

	private MainMenu()
	{
	}

	public static MainMenu Get()
	{
		if (_Instance == null)
		{
			_Instance = new MainMenu();
		}
		return _Instance;
	}

	public void OpenMainMenu()
	{
		PlayerGm.Init();
		MethodByKey.Get().Init();
		LoadEditionAward();
		GlobalObjectMgr.Get<PlayerGm>().Not();
		_apawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GSG.Context).GetControlledPawn();
		_world = _apawn.World;
		BGUPlayerCharacterCS bGUPlayerCharacterCS = _apawn as BGUPlayerCharacterCS;
		if (_world == null || (UObject)(object)bGUPlayerCharacterCS == null)
		{
			Console.WriteLine(1);
			return;
		}
		_ShrineMain = GSUI.UIMgr.FindUIPage((UObject)(object)bGUPlayerCharacterCS, 7) as UIShrineMain;
		if (_ShrineMain == null)
		{
			BGUFunctionLibraryManaged.BGUSwitchPage(_world, EUIPageID.ShrineMain);
		}
		_ShrineMain = GSUI.UIMgr.FindUIPage((UObject)(object)bGUPlayerCharacterCS, 7) as UIShrineMain;
		if (_ShrineMain == null)
		{
			Console.WriteLine(2);
			return;
		}
		FieldInfo field = typeof(UIShrineMain).GetField("ShrineMenuHelper", BindingFlags.Instance | BindingFlags.NonPublic);
		if (field == null || !(field.GetValue(_ShrineMain) is FMenuHelper<EShrineMenuTag> fMenuHelper))
		{
			Console.WriteLine(3);
			return;
		}
		FieldInfo field2 = typeof(UIShrineMain).GetField("TeleportMenuHelper", BindingFlags.Instance | BindingFlags.NonPublic);
		if (field2 == null || !(field2.GetValue(_ShrineMain) is FMenuHelper<ETeleportMenuTag> teleportHelper))
		{
			Console.WriteLine(4);
			return;
		}
		_fMenuHelper = fMenuHelper;
		_teleportHelper = teleportHelper;
		InitMenu();
		_fMenuHelper.ClearLayout();
		RegistAllMenu();
		_fMenuHelper.UpdateLayout();
	}

	private void InitMenu()
	{
		if (_ShrineMain != null)
		{
			FieldInfo field = typeof(UIShrineMain).GetField("TxtMainName", BindingFlags.Instance | BindingFlags.NonPublic);
			if (field != null && field.GetValue(_ShrineMain) is UTextBlock uTextBlock)
			{
				FText text = FText.FromName(new FName("作者：浪漫 QQ：923289638"));
				FSlateFontInfo font = uTextBlock.Font;
				font.Size = 50;
				uTextBlock.SetFont(font);
				uTextBlock.SetText(text);
				uTextBlock.SetColorAndOpacity(new FSlateColor
				{
					SpecifiedColor = new FLinearColor(FColor.FromHex("#FFA55F"))
				});
			}
		}
	}

	private void RegistAllMenu()
	{
		RestMenu(_fMenuHelper, _world);
		ShortcutsMenu(_fMenuHelper);
		DefaultMenu(_fMenuHelper);
		GMMenu(_fMenuHelper);
		ChuanSongMenu(_fMenuHelper);
		SummonMenu(_fMenuHelper);
		GMMethodMenu(_fMenuHelper);
		HelpMenu(_fMenuHelper);
	}

	private void RestMenu(FMenuHelper<EShrineMenuTag> helper, UWorld world)
	{
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Rest,
			Name = FText.FromString("调息"),
			Tips = FText.FromString("调息"),
			BtnAction = delegate
			{
				FieldInfo field = typeof(UIShrineMain).GetField("AnimRest", BindingFlags.Instance | BindingFlags.NonPublic);
				if (!(field == null))
				{
					object value = field.GetValue(_ShrineMain);
					UWidgetAnimation uWidgetAnimation = (UWidgetAnimation)((value is UWidgetAnimation) ? value : null);
					if (!(uWidgetAnimation == null))
					{
						UUserWidget rootUserWidget = _ShrineMain.GetRootUserWidget();
						((BUI_Widget)(object)((rootUserWidget is BUI_Widget) ? rootUserWidget : null)).PlayWidgetAnimation(uWidgetAnimation);
						FieldInfo field2 = typeof(UIShrineMain).GetField("RootCon", BindingFlags.Instance | BindingFlags.NonPublic);
						if (!(field2 == null))
						{
							object value2 = field2.GetValue(_ShrineMain);
							UWidget uWidget = (UWidget)((value2 is UWidget) ? value2 : null);
							if (!(uWidget == null))
							{
								uWidget.SetVisibility(ESlateVisibility.HitTestInvisible);
								GSB1UIUtil.BlockUIInput(world, IsBlock: true);
								_ShrineMain.SetBlockInput(EBlockInputReason.Manual, Value: true);
								BGW_EventCollection.Get(world).Evt_BlockWidgetNavigation(bBlock: true, EBlockNavReason.ShrineReset);
								GSIEventSequence gSIEventSequence = new GSIEventSequence();
								gSIEventSequence.AddEvent(new GSIEventDelayExec(1.5f, delegate
								{
									GSG.BattleLogicSvc.RebirthPointRest();
									helper.UpdateBtnState();
								}));
								_ShrineMain.AddUIEventSeq(gSIEventSequence);
								if (GSG.GamePlayer.RedPointHelper.IsRedPointExist((RedPointType)21, 22))
								{
									GSG.RedPointMgr.RedPointRemove((RedPointType)21, 22);
								}
							}
						}
					}
				}
			},
			RedPointFunc = () => GSG.GamePlayer.RedPointHelper.IsRedPointExist((RedPointType)21, 22),
			BtnHashCode = "Func_UnlockTiaoxi",
			SortId = 0,
			ParentBtnHash = "Func_SystemUnlock"
		});
	}

	private void ShortcutsMenu(FMenuHelper<EShrineMenuTag> helper)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("快捷功能"),
			Tips = FText.FromString("热键不够用怎么办"),
			BtnHashCode = "Func_Shortcuts",
			SortId = 1
		});
		List<KeyHook> list = GlobalObjectMgr.Get<TB_KeyHook>().List_.Where((KeyHook a) => (int)a.HookKey == 0).ToList();
		for (int num = 0; num < list.Count; num++)
		{
			string text = list[num].Name;
			Name name = GlobalObjectMgr.Get<NameCN>().CN(list[num].Method);
			string value = name.Value;
			if (text == list[num].Method && value != null)
			{
				text = value;
			}
			string method = list[num].Method;
			text = text + "(" + Is(method) + ")";
			helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
			{
				MenuBtnType = EMenuBtnType.Func,
				BtnActionType = (EMenuBtnActionType)6,
				Name = FText.FromString(text),
				Tips = FText.FromString(text),
				BtnAction = delegate
				{
					MethodByKey.TryInvokeLocalMethod(method);
				},
				BtnHashCode = $"Func_Shortcuts{num + 1}",
				SortId = num + 1,
				ParentBtnHash = "Func_Shortcuts"
			});
		}
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("快捷键功能"),
			Tips = FText.FromString("拥有快捷按键的功能"),
			BtnAction = delegate
			{
				IsKey();
			},
			BtnHashCode = $"Func_Shortcuts{95}",
			SortId = 98,
			ParentBtnHash = "Func_Shortcuts"
		});
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("怪物增强(血量加倍)"),
			Tips = FText.FromString("怪物增强(血量加倍)"),
			BtnAction = delegate
			{
				HPJiabei();
			},
			BtnHashCode = $"Func_Shortcuts{94}",
			SortId = 99,
			ParentBtnHash = "Func_Shortcuts"
		});
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("丹药大圣模式"),
			Tips = FText.FromString("使用丹药直接进入打算模式"),
			BtnAction = delegate
			{
				UseDanYaoToDs();
			},
			BtnHashCode = $"Func_Shortcuts{96}",
			SortId = 99,
			ParentBtnHash = "Func_Shortcuts"
		});
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("添加丹药"),
			Tips = FText.FromString("添加丹药"),
			BtnAction = delegate
			{
				AddItem_B();
			},
			BtnHashCode = $"Func_Shortcuts{97}",
			SortId = 99,
			ParentBtnHash = "Func_Shortcuts"
		});
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("添加材料"),
			Tips = FText.FromString("添加材料"),
			BtnAction = delegate
			{
				AddItem_A();
			},
			BtnHashCode = $"Func_Shortcuts{98}",
			SortId = 99,
			ParentBtnHash = "Func_Shortcuts"
		});
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("自定义添加物品"),
			Tips = FText.FromString("自定义添加物品"),
			BtnAction = delegate
			{
				AddItem();
			},
			BtnHashCode = $"Func_Shortcuts{99}",
			SortId = 99,
			ParentBtnHash = "Func_Shortcuts"
		});
	}

	private void HPJiabei()
	{
		_teleportHelper.ClearLayout();
		AttrBool att = GlobalObjectMgr.Get<AttrBool>();
		_teleportHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
		{
			MenuBtnType = EMenuBtnType.Teleport,
			BtnHashCode = $"Func_Shortcuts94{0}",
			ParentBtnHash = $"Func_Shortcuts{94}",
			Name = FText.FromString($"怪物血量当前倍数[{att.HpMaxMu}]"),
			Tips = FText.FromString($"怪物血量当前倍数[{att.HpMaxMu}]"),
			SortId = 0,
			BtnAction = delegate
			{
			}
		});
		for (int num = 1; num <= 10; num++)
		{
			int id = num;
			string text = $"血量倍数[×{id}]";
			if ((float)id == att.HpMaxMu)
			{
				text += "√选定";
			}
			_teleportHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
			{
				MenuBtnType = EMenuBtnType.Teleport,
				BtnHashCode = $"Func_Shortcuts94{num + 1}",
				ParentBtnHash = $"Func_Shortcuts{94}",
				Name = FText.FromString(text),
				Tips = FText.FromString(text),
				SortId = 1,
				BtnAction = delegate
				{
					att.HpMaxMu = id;
				}
			});
		}
		for (int num2 = 2; num2 <= 10; num2++)
		{
			int id2 = num2 * 10;
			string text2 = $"血量倍数[×{id2}]";
			if ((float)id2 == att.HpMaxMu)
			{
				text2 += "√选定";
			}
			_teleportHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
			{
				MenuBtnType = EMenuBtnType.Teleport,
				BtnHashCode = $"Func_Shortcuts94{num2 + 10}",
				ParentBtnHash = $"Func_Shortcuts{94}",
				Name = FText.FromString(text2),
				Tips = FText.FromString(text2),
				SortId = 1,
				BtnAction = delegate
				{
					att.HpMaxMu = id2;
				}
			});
		}
		_teleportHelper.UpdateLayout();
		GenAShrineMain.SetShrineType(EShrineType.Teleport, "ShowTeleportMenu");
	}

	private void UseDanYaoToDs()
	{
		_teleportHelper.ClearLayout();
		List<ItemDesc> list = ((IEnumerable<ItemDesc>)GameDBRuntime.GetTBItemDesc().List).Where((ItemDesc a) => 2204 < a.Id && a.Id < 2255).ToList();
		AttrBool att = GlobalObjectMgr.Get<AttrBool>();
		_teleportHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
		{
			MenuBtnType = EMenuBtnType.Teleport,
			BtnHashCode = $"Func_Shortcuts96{0}",
			ParentBtnHash = $"Func_Shortcuts{96}",
			Name = FText.FromString((att.Trans2DaSheng ? "大圣模式已开启" : "大圣模式已关闭").ToString()),
			Tips = FText.FromString("大圣模式持续时间" + att.Duration),
			SortId = 0,
			BtnAction = delegate
			{
				att.Trans2DaSheng = !att.Trans2DaSheng;
			}
		});
		for (int num = 0; num < list.Count; num++)
		{
			int id = list[num].Id;
			ItemDesc itemDesc = GameDBRuntime.GetItemDesc(id);
			if (itemDesc != null)
			{
				string text = GSLocalization.ToFText(itemDesc.Name)?.ToString() + $"({id})";
				if (id == att.InDsModItemID)
				{
					text += "√选定";
				}
				_teleportHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
				{
					MenuBtnType = EMenuBtnType.Teleport,
					BtnHashCode = $"Func_Shortcuts96{num + 1}",
					ParentBtnHash = $"Func_Shortcuts{96}",
					Name = FText.FromString(text),
					Tips = FText.FromString(text),
					SortId = 1,
					BtnAction = delegate
					{
						att.InDsModItemID = id;
					}
				});
			}
		}
		_teleportHelper.UpdateLayout();
		GenAShrineMain.SetShrineType(EShrineType.Teleport, "ShowTeleportMenu");
	}

	public static void ChuanSongMenu(FMenuHelper<EShrineMenuTag> helper)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("传送"),
			Tips = FText.FromString("传送"),
			BtnHashCode = "Func_chuansong",
			SortId = 9
		});
		for (int i = 1; i < 110; i++)
		{
			int id = 0;
			string text = "";
			GMMonsterTeleportDesc gMMonsterTeleportDesc = GameDBRuntime.GetGMMonsterTeleportDesc(i);
			id = gMMonsterTeleportDesc.Id;
			text = gMMonsterTeleportDesc.Name;
			helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
			{
				MenuBtnType = EMenuBtnType.Func,
				BtnActionType = (EMenuBtnActionType)6,
				Name = FText.FromString(text),
				Tips = FText.FromString(text),
				BtnAction = delegate
				{
					SuperCharacter.MonsterTeleport(id);
				},
				BtnHashCode = $"Func_chuansong_{i}",
				SortId = i + 1,
				ParentBtnHash = "Func_chuansong"
			});
		}
	}

	private void IsKey()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		List<KeyHook> list = GlobalObjectMgr.Get<TB_KeyHook>().List_.Where((KeyHook a) => (int)a.HookKey > 0).ToList();
		_teleportHelper.ClearLayout();
		for (int num = 0; num < list.Count; num++)
		{
			string text = (((int)list[num].HookKey == 0) ? "(无)" : ((object)list[num].HookKey/*cast due to .constrained prefix*/).ToString());
			string name = list[num].Name;
			string value = GlobalObjectMgr.Get<NameCN>().CN(list[num].Method).Value;
			name = ((!(name == list[num].Method)) ? (name + "-快捷键-" + text) : ((value != null) ? (value + "-快捷键-" + text) : (name + "-快捷键-" + text)));
			string method = list[num].Method;
			_teleportHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
			{
				MenuBtnType = EMenuBtnType.Teleport,
				BtnHashCode = $"Func_Shortcuts95{num}",
				ParentBtnHash = $"Func_Shortcuts{95}",
				Name = FText.FromString(name),
				Tips = FText.FromString(name),
				SortId = 1,
				BtnAction = delegate
				{
					MethodByKey.TryInvokeLocalMethod(method);
				}
			});
		}
		_teleportHelper.UpdateLayout();
		GenAShrineMain.SetShrineType(EShrineType.Teleport, "ShowTeleportMenu");
	}

	private void GMMethodMenu(FMenuHelper<EShrineMenuTag> helper)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("游戏管理员功能"),
			Tips = FText.FromString("GM命令"),
			BtnHashCode = "Func_GM",
			SortId = 1
		});
		List<GMMethod> list = GlobalObjectMgr.Get<TB_GMMethod>().List;
		for (int i = 0; i < list.Count; i++)
		{
			string text = list[i].Name;
			if (text == list[i].Method)
			{
				string value = GlobalObjectMgr.Get<NameCN>().CN(list[i].Method).Value;
				if (value != null)
				{
					text = value;
				}
			}
			string method = list[i].Method;
			List<string> args = list[i].Parameters;
			helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
			{
				MenuBtnType = EMenuBtnType.Func,
				BtnActionType = (EMenuBtnActionType)6,
				Name = FText.FromString(text),
				Tips = FText.FromString(text),
				BtnAction = delegate
				{
					PlayerGm.TryInvokeLocalMethod(method, args);
					GlobalObjectMgr.Get<PlayerGm>().Commit();
				},
				BtnHashCode = $"Func_GM{i + 1}",
				SortId = i + 1,
				ParentBtnHash = "Func_GM"
			});
		}
	}

	private void DefaultMenu(FMenuHelper<EShrineMenuTag> helper)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("游戏自带功能"),
			Tips = FText.FromString("游戏自带功能"),
			BtnHashCode = "Func_systeam",
			SortId = 1
		});
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("法术整备"),
			Tips = FText.FromString("法术整备"),
			BtnAction = delegate
			{
				GSG.BattleLogicSvc.DoInteractBehaviour(EInteractUIBehavior.UIShrineToSubFunc);
				GSG.RedPointMgr.RedPointRemove((RedPointType)21, 13);
				GSG.DStoreSvc.GetDStoreLearnTalent().SetShowType(TalentShowType.SpellConfig);
				BGW_CharacterViewMgr.Get(GSG.Context).ToggleCharacterView(bSwitchOn: true, CharacterViewType.SHOP);
				GenARoleMain.SwitchTab(ERoleUIType.Practice, "InitShrineMenu");
				GenAGPage.ShowPage(29, "InitShrineMenu");
				GenARoleMain.SwitchShowTab(NewIsShowTab: false, "InitShrineMenu");
				GSB1UIUtil.ActiveBlackOut(IsActive: false);
			},
			BtnHashCode = $"Func_systeam{1}",
			SortId = 1,
			ParentBtnHash = "Func_systeam"
		});
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("天赋重修"),
			Tips = FText.FromString("天赋重修"),
			BtnAction = delegate
			{
				GSG.DStoreSvc.GetDStoreLearnTalent().SetShowType(TalentShowType.ResetTalent);
				BGW_CharacterViewMgr.Get(GSG.Context).ToggleCharacterView(bSwitchOn: true, CharacterViewType.SHOP);
				GenARoleMain.SetRoleUIGroup(ERoleUIGroup.Talent, "InitShrineMenu");
				GenARoleMain.SwitchTab(ERoleUIType.Practice, "InitShrineMenu");
				GenAGPage.ShowPage(29, "InitShrineMenu");
				GSB1UIUtil.ActiveBlackOut(IsActive: false);
				GSG.RedPointMgr.RedPointRemove((RedPointType)21, 15);
			},
			BtnHashCode = $"Func_systeam{2}",
			SortId = 1,
			ParentBtnHash = "Func_systeam"
		});
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("泡制"),
			Tips = FText.FromString("泡制"),
			BtnAction = delegate
			{
				GSG.RedPointMgr.RedPointRemove((RedPointType)21, 10);
				BGW_CharacterViewMgr.Get(GSG.Context).ToggleCharacterView(bSwitchOn: true, CharacterViewType.SHOP);
				GenAGPage.ShowPage(41, "InitShrineMenu");
				GSB1UIUtil.ActiveBlackOut(IsActive: false);
			},
			BtnHashCode = $"Func_systeam{3}",
			SortId = 1,
			ParentBtnHash = "Func_systeam"
		});
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("兵器铸造"),
			Tips = FText.FromString("兵器铸造"),
			BtnAction = delegate
			{
				GSG.BattleLogicSvc.DoInteractBehaviour(EInteractUIBehavior.UIShrineToSubFunc);
				GSG.RedPointMgr.RedPointRemove((RedPointType)21, 2);
				BGW_CharacterViewMgr.Get(GSG.Context).ToggleCharacterView(bSwitchOn: true);
				GenARoleMain.SetSelectedEquipPos((EquipPosition)5, "InitShrineMenu");
				GenAGPage.ShowPage(46, "InitShrineMenu");
				GSB1UIUtil.ActiveBlackOut(IsActive: false);
			},
			BtnHashCode = $"Func_systeam{4}",
			SortId = 1,
			ParentBtnHash = "Func_systeam"
		});
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("披挂升阶"),
			Tips = FText.FromString("披挂升阶"),
			BtnAction = delegate
			{
				GSG.RedPointMgr.RedPointRemove((RedPointType)21, 8);
				GSB1UIUtil.OpenEquipBuild(8, GSG.Context);
			},
			BtnHashCode = $"Func_systeam{5}",
			SortId = 1,
			ParentBtnHash = "Func_systeam"
		});
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("披挂铸造"),
			Tips = FText.FromString("披挂铸造"),
			BtnAction = delegate
			{
				GSG.BattleLogicSvc.DoInteractBehaviour(EInteractUIBehavior.UIShrineToSubFunc);
				GSG.RedPointMgr.RedPointRemove((RedPointType)21, 11);
				BGW_CharacterViewMgr.Get(GSG.Context).ToggleCharacterView(bSwitchOn: true, CharacterViewType.SHOP);
				GenAGPage.ShowPage(26, "InitShrineMenu");
				GSB1UIUtil.ActiveBlackOut(IsActive: false);
			},
			BtnHashCode = $"Func_systeam{6}",
			SortId = 1,
			ParentBtnHash = "Func_systeam"
		});
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("测试专用"),
			Tips = FText.FromString("测试专用"),
			BtnAction = delegate
			{
				Award();
			},
			BtnHashCode = $"Func_systeam{7}",
			SortId = 1,
			ParentBtnHash = "Func_systeam"
		});
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("挑战"),
			Tips = FText.FromString("挑战"),
			BtnHashCode = "Func_tiaozhan",
			SortId = 1
		});
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("连战"),
			Tips = FText.FromString("连战"),
			BtnAction = delegate
			{
				GSG.BattleLogicSvc.DoInteractBehaviour(EInteractUIBehavior.UIShrineToSubFunc);
				GSG.RedPointMgr.RedPointRemove((RedPointType)21, 24);
				GSB1UIUtil.ShowBossIterations(GSG.Context);
			},
			BtnHashCode = $"Func_tiaozhan_{1}",
			SortId = 1,
			ParentBtnHash = "Func_tiaozhan"
		});
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("复战"),
			Tips = FText.FromString("复战"),
			BtnAction = delegate
			{
				GSG.BattleLogicSvc.DoInteractBehaviour(EInteractUIBehavior.UIShrineToSubFunc);
				GSG.RedPointMgr.RedPointRemove((RedPointType)21, 23);
				GSB1UIUtil.ShowBossReChallenge(GSG.Context);
			},
			BtnHashCode = $"Func_tiaozhan_{2}",
			SortId = 2,
			ParentBtnHash = "Func_tiaozhan"
		});
	}

	private void GMMenu(FMenuHelper<EShrineMenuTag> helper)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("菜单（GM）"),
			Tips = FText.FromString("菜单（GM）"),
			BtnAction = delegate
			{
				BGUFunctionLibraryManaged.BGUSwitchPage(MyUtils.GetWorld(), EUIPageID.MiniGM);
			},
			BtnHashCode = "Fun_GMUI",
			SortId = 2,
			ParentBtnHash = "Func_GMUI"
		});
	}

	private void SummonMenu(FMenuHelper<EShrineMenuTag> helper)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("召唤"),
			Tips = FText.FromString("召唤游戏内的怪物"),
			BtnHashCode = "Func_Summon",
			SortId = 2
		});
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("召唤挑战版Boss"),
			Tips = FText.FromString("Boss"),
			BtnAction = delegate
			{
				SummonTZ();
			},
			BtnHashCode = $"Func_Summon{0}",
			SortId = 1,
			ParentBtnHash = "Func_Summon"
		});
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("召唤Boss"),
			Tips = FText.FromString("Boss"),
			BtnAction = delegate
			{
				SummonBoss();
			},
			BtnHashCode = $"Func_Summon{1}",
			SortId = 1,
			ParentBtnHash = "Func_Summon"
		});
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("召唤小兵"),
			Tips = FText.FromString("小兵"),
			BtnAction = delegate
			{
				SummonXB();
			},
			BtnHashCode = $"Func_Summon{2}",
			SortId = 1,
			ParentBtnHash = "Func_Summon"
		});
	}

	private void SummonTZ()
	{
		List<FUStBossRushConfigDesc> list = GameDBRuntime.GetTBFUStBossRushConfigDesc().Values.ToList();
		_teleportHelper.ClearLayout();
		for (int i = 0; i < list.Count(); i++)
		{
			int iD = list[i].ID;
			string levelName = list[i].LevelName;
			if (list[i].TamerPath.Count >= 1)
			{
				string path = list[i].TamerPath[0].ToString();
				_teleportHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
				{
					MenuBtnType = EMenuBtnType.Teleport,
					BtnHashCode = $"Func_Summon1{i}",
					ParentBtnHash = $"Func_Summon{1}",
					Name = FText.FromString(levelName + $"[{iD}]"),
					Tips = FText.FromString(levelName),
					SortId = 0,
					BtnAction = delegate
					{
						SuperCharacter.OnSummonBossByAssetPath(path);
					}
				});
			}
		}
		_teleportHelper.UpdateLayout();
		GenAShrineMain.SetShrineType(EShrineType.Teleport, "ShowTeleportMenu");
	}

	private void SummonBoss()
	{
		List<BossInfoA> list = GlobalObjectMgr.Get<TB_BossInfoA>().list;
		List<BossInfoA> list2 = list.Where((BossInfoA a) => a.Boss).ToList();
		_teleportHelper.ClearLayout();
		for (int num = 0; num < list2.Count(); num++)
		{
			string bossName = list2[num].BossName;
			int bossID = list2[num].BossID;
			string path = list2[num].AssetPath;
			_teleportHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
			{
				MenuBtnType = EMenuBtnType.Teleport,
				BtnHashCode = $"Func_Summon1{num}",
				ParentBtnHash = $"Func_Summon{1}",
				Name = FText.FromString(bossName + $"[{bossID}]"),
				Tips = FText.FromString(bossName),
				SortId = 0,
				BtnAction = delegate
				{
					SuperCharacter.OnSummonBossByAssetPath(path);
				}
			});
		}
		_teleportHelper.UpdateLayout();
		GenAShrineMain.SetShrineType(EShrineType.Teleport, "ShowTeleportMenu");
	}

	private void SummonXB()
	{
		_teleportHelper.ClearLayout();
		List<BossInfoA> list = GlobalObjectMgr.Get<TB_BossInfoA>().list;
		List<BossInfoA> list2 = list.Where((BossInfoA a) => !a.Boss).ToList();
		_teleportHelper.ClearLayout();
		for (int num = 0; num < list2.Count(); num++)
		{
			string bossName = list2[num].BossName;
			int bossID = list2[num].BossID;
			string path = list2[num].AssetPath;
			_teleportHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
			{
				MenuBtnType = EMenuBtnType.Teleport,
				BtnHashCode = $"Func_Summon2{num}",
				ParentBtnHash = $"Func_Summon{2}",
				Name = FText.FromString(bossName + $"[{bossID}]"),
				Tips = FText.FromString(bossName),
				SortId = 0,
				BtnAction = delegate
				{
					SuperCharacter.OnSummonBossByAssetPath(path);
				}
			});
		}
		_teleportHelper.UpdateLayout();
		GenAShrineMain.SetShrineType(EShrineType.Teleport, "ShowTeleportMenu");
	}

	private void Award()
	{
		_teleportHelper.ClearLayout();
		_teleportHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
		{
			MenuBtnType = EMenuBtnType.Teleport,
			BtnHashCode = $"Func_systeam7{1}",
			ParentBtnHash = $"Func_systeam{7}",
			Name = FText.FromString($"每日领取奖励{GlobalObjectMgr.IEditionAward}"),
			Tips = FText.FromString("每日领取奖励"),
			SortId = 0,
			BtnAction = delegate
			{
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_0048: Invalid comparison between Unknown and I4
				if (GlobalObjectMgr.IEditionAward > 0)
				{
					for (int num = GSG.GamePlayer.Bag.Info.EditionAwardList.Count - 1; num >= 0; num--)
					{
						if ((int)GSG.GamePlayer.Bag.Info.EditionAwardList[num] == 1)
						{
							GSG.GamePlayer.Bag.Info.EditionAwardList.RemoveAt(ChangeReason.None, num);
						}
					}
				}
				RepeatedField<ItemOne> awardList = GameDBRuntime.GetEditionAwardDesc(1).AwardList;
				awardList.Clear();
				awardList.AddRange((IEnumerable<ItemOne>)GlobalObjectMgr.Get<EditionAward>().list);
				GenAGPage.ShowPage(78, "InitShrineMenu");
				if (GSUI.UIMgr.FindUIPage(GSG.Context, 78) is UIEditionAward obj)
				{
					FieldInfo field = typeof(UIEditionAward).GetField("DataStore", BindingFlags.Instance | BindingFlags.NonPublic);
					if (!(field == null))
					{
						DSEditionAward dSEditionAward = field.GetValue(obj) as DSEditionAward;
						if (dSEditionAward != null)
						{
						}
					}
				}
			}
		});
		_teleportHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
		{
			MenuBtnType = EMenuBtnType.Teleport,
			BtnHashCode = $"Func_systeam7{2}",
			ParentBtnHash = $"Func_systeam{7}",
			Name = FText.FromString("测试2"),
			Tips = FText.FromString("测试2"),
			SortId = 0,
			BtnAction = delegate
			{
				GSG.BattleLogicSvc.DoInteractBehaviour(EInteractUIBehavior.UIShrineToSubFunc);
				GSG.RedPointMgr.RedPointRemove((RedPointType)21, 11);
				BGW_CharacterViewMgr.Get(GSG.Context).ToggleCharacterView(bSwitchOn: true, CharacterViewType.SHOP);
				GenAGPage.ShowPage(26, "InitShrineMenu");
				GSB1UIUtil.ActiveBlackOut(IsActive: false);
			}
		});
		_teleportHelper.UpdateLayout();
		GenAShrineMain.SetShrineType(EShrineType.Teleport, "ShowTeleportMenu");
	}

	private void AddItem_A()
	{
		_teleportHelper.ClearLayout();
		List<ItemDesc> list = ((IEnumerable<ItemDesc>)GameDBRuntime.GetTBItemDesc().List).Where((ItemDesc a) => 3201 <= a.Id && a.Id <= 3962).ToList();
		for (int num = 0; num < list.Count; num++)
		{
			int id = list[num].Id;
			int num2 = list[num].CarryMax;
			ItemDesc itemDesc = GameDBRuntime.GetItemDesc(id);
			if (itemDesc != null)
			{
				string str = GSLocalization.ToFText(itemDesc.Name)?.ToString() + $"({num2})";
				_teleportHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
				{
					MenuBtnType = EMenuBtnType.Teleport,
					BtnHashCode = $"Func_Shortcuts98{num + 1}",
					ParentBtnHash = $"Func_Shortcuts{98}",
					Name = FText.FromString(str),
					Tips = FText.FromString(str),
					SortId = 0,
					BtnAction = delegate
					{
						PlayerGm.TryInvokeLocalMethod("AddItem", new List<string>
						{
							id.ToString(),
							num2.ToString()
						});
						GlobalObjectMgr.Get<PlayerGm>().Commit();
					}
				});
			}
		}
		_teleportHelper.UpdateLayout();
		GenAShrineMain.SetShrineType(EShrineType.Teleport, "ShowTeleportMenu");
	}

	private void AddItem_B()
	{
		_teleportHelper.ClearLayout();
		List<ItemDesc> list = ((IEnumerable<ItemDesc>)GameDBRuntime.GetTBItemDesc().List).Where((ItemDesc a) => 2204 < a.Id && a.Id < 2255).ToList();
		for (int num = 0; num < list.Count; num++)
		{
			int id = list[num].Id;
			int num2 = list[num].CarryMax;
			ItemDesc itemDesc = GameDBRuntime.GetItemDesc(id);
			if (itemDesc != null)
			{
				string str = GSLocalization.ToFText(itemDesc.Name)?.ToString() + $"({num2})";
				_teleportHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
				{
					MenuBtnType = EMenuBtnType.Teleport,
					BtnHashCode = $"Func_Shortcuts98{num + 1}",
					ParentBtnHash = $"Func_Shortcuts{98}",
					Name = FText.FromString(str),
					Tips = FText.FromString(str),
					SortId = 0,
					BtnAction = delegate
					{
						PlayerGm.TryInvokeLocalMethod("AddItem", new List<string>
						{
							id.ToString(),
							num2.ToString()
						});
						GlobalObjectMgr.Get<PlayerGm>().Commit();
					}
				});
			}
		}
		_teleportHelper.UpdateLayout();
		GenAShrineMain.SetShrineType(EShrineType.Teleport, "ShowTeleportMenu");
	}

	private void AddItem()
	{
		GlobalObjectMgr.Get<TB_AddItem>().Init();
		_teleportHelper.ClearLayout();
		List<ItemOne> list = GlobalObjectMgr.Get<TB_AddItem>().list;
		for (int i = 0; i < list.Count; i++)
		{
			int id = list[i].Id;
			int num = list[i].Num;
			ItemDesc itemDesc = GameDBRuntime.GetItemDesc(id);
			if (itemDesc != null)
			{
				string str = GSLocalization.ToFText(itemDesc.Name)?.ToString() + $"({num})";
				FText tips = GSLocalization.ToFText(itemDesc.EffectDesc);
				_teleportHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
				{
					MenuBtnType = EMenuBtnType.Teleport,
					BtnHashCode = $"Func_Shortcuts99{i + 1}",
					ParentBtnHash = $"Func_Shortcuts{99}",
					Name = FText.FromString(str),
					Tips = tips,
					SortId = 0,
					BtnAction = delegate
					{
						PlayerGm.TryInvokeLocalMethod("AddItem", new List<string>
						{
							id.ToString(),
							num.ToString()
						});
						GlobalObjectMgr.Get<PlayerGm>().Commit();
					}
				});
			}
		}
		_teleportHelper.UpdateLayout();
		GenAShrineMain.SetShrineType(EShrineType.Teleport, "ShowTeleportMenu");
	}

	private string Is(string method)
	{
		AttrBool attrBool = GlobalObjectMgr.Get<AttrBool>();
		bool flag = false;
		switch (method)
		{
		default:
		{
			string text = "";
			break;
		}
		case "OnGSLockSpellRebirth":
			flag = attrBool.LockSpellRebirth;
			break;
		case "OnGSSetSpeed":
			flag = attrBool.LockSpeed;
			break;
		case "OnGSPreciseDodge":
			flag = attrBool.LockPrecise && attrBool.LockPreciseType == 0;
			break;
		case "OnGSPreciseGP":
			flag = attrBool.LockPrecise && attrBool.LockPreciseType == 1;
			break;
		case "OnGSPreciseHMQ":
			flag = attrBool.LockPrecise && attrBool.LockPreciseType == 2;
			break;
		case "OnGsKuaiSuXuLi":
			flag = attrBool.LockKuaiSuXuLi > 1;
			break;
		}
		return (flag ? "开启" : "关闭").ToString();
	}

	public void HelpMenu(FMenuHelper<EShrineMenuTag> helper)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = EMenuBtnType.Func,
			BtnActionType = (EMenuBtnActionType)6,
			Name = FText.FromString("使用说明和介绍"),
			Tips = FText.FromString("作者：浪漫(QQ.923289638)"),
			BtnAction = delegate
			{
				GSB1UIUtil.ShowConfirm(null, FText.FromString("所有菜单功能都可以通过配置文件来实现\n可以通过本MOD查询提供的GM命令."), FText.FromString("明白"), null, ShowCancel: false);
			},
			BtnHashCode = "Func_UnlockAuthor",
			SortId = 99
		});
	}

	private void LoadEditionAward()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		EditionAward editionAward = GlobalObjectMgr.Get<EditionAward>();
		string modEditionAwardPath = GlobalObjectMgr.ModEditionAwardPath;
		if (!File.Exists(modEditionAwardPath))
		{
			editionAward.list.AddRange(new List<ItemOne>
			{
				new ItemOne
				{
					Id = 1002,
					Num = 999999
				},
				new ItemOne
				{
					Id = 1006,
					Num = 999
				}
			});
			string value = JsonConvert.SerializeObject(editionAward, Formatting.Indented);
			StreamWriter streamWriter = new StreamWriter(File.Open(modEditionAwardPath, FileMode.Create));
			streamWriter.WriteLine(value);
			streamWriter.Close();
			Console.WriteLine("创建" + modEditionAwardPath + "配置文件");
		}
		else
		{
			string value2 = File.ReadAllText(modEditionAwardPath);
			EditionAward editionAward2 = JsonConvert.DeserializeObject<EditionAward>(value2);
			editionAward.list.Clear();
			editionAward.list.AddRange(editionAward2.list);
			Console.WriteLine("读取" + modEditionAwardPath + "配置文件");
		}
	}
}
