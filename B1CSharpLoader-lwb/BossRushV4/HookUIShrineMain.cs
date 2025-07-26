using System;
using System.Collections.Generic;
using System.Reflection;
using b1;
using b1.Localization;
using B1UI;
using B1UI.GSUI;
using BtlB1;
using BtlShare;
using CommB1;
using GSE.GSUI;
using HarmonyLib;
using ResB1;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace BossRushV4;

[HarmonyPatch]
public class HookUIShrineMain
{
	private static MethodBase TargetMethod()
	{
		return AccessTools.Method("B1UI.GSUI.UIShrineMain:OnUIPageConstructImpl", (Type[])null, (Type[])null);
	}

	private static void Postfix(UIShrineMain __instance)
	{
		if (__instance == null)
		{
			return;
		}
		FMenuHelper<EShrineMenuTag> fieldOrPropertyValue = Utils.GetFieldOrPropertyValue<FMenuHelper<EShrineMenuTag>>("ShrineMenuHelper", __instance, BindingFlags.Instance | BindingFlags.NonPublic);
		if (fieldOrPropertyValue == null)
		{
			return;
		}
		FMenuHelper<ETeleportMenuTag> fieldOrPropertyValue2 = Utils.GetFieldOrPropertyValue<FMenuHelper<ETeleportMenuTag>>("TeleportMenuHelper", __instance, BindingFlags.Instance | BindingFlags.NonPublic);
		if (fieldOrPropertyValue2 != null)
		{
			DSShrineMain fieldOrPropertyValue3 = Utils.GetFieldOrPropertyValue<DSShrineMain>("DataStore", __instance, BindingFlags.Instance | BindingFlags.NonPublic);
			if (fieldOrPropertyValue3 != null)
			{
				InsertCustomBossIterationsMenu(fieldOrPropertyValue, fieldOrPropertyValue2, fieldOrPropertyValue3, __instance);
			}
		}
	}

	private static string GetRealBossName(FUStBossRushConfigDesc boss)
	{
		FText fText = FText.FromString(boss.LevelName);
		if (boss.UIwordID > 0)
		{
			fText = GSB1UIUtil.GetUIWordDescFText((EUIWordID)boss.UIwordID);
		}
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(boss.ExtendID);
		fText = ((unitBattleInfoExtendDesc != null) ? GSLocalization.ToFText(unitBattleInfoExtendDesc.UnitName) : null);
		if (fText == null)
		{
			if (boss.LevelName == "FuZiShu")
			{
				fText = FText.FromString("沙国王父子");
			}
			else if (boss.LevelName == "JRHKRF" || boss.LevelName == "LZ_JRHKRF")
			{
				fText = FText.FromString("急如火 快如风");
			}
			else if (boss.LevelName == "YLWWLY" || boss.LevelName == "LZ_YLWWLY")
			{
				fText = FText.FromString("云里雾 雾里云");
			}
			else if (boss.LevelName == "XGX" || boss.LevelName == "LZ_XGX")
			{
				fText = FText.FromString("兴拱掀 掀拱兴");
			}
			Console.WriteLine(" No Name " + boss.LevelName);
		}
		int num = 0;
		if (fText != null && !string.IsNullOrEmpty(fText.ToString()))
		{
			string key = (boss.LevelName.StartsWith("LZ") ? "心中的" : "") + fText.ToString();
			if (BossRushV4.DuplicateNameDict.ContainsKey(key))
			{
				BossRushV4.DuplicateNameDict[key]++;
			}
			else
			{
				BossRushV4.DuplicateNameDict.Add(key, 0);
			}
			num = BossRushV4.DuplicateNameDict[key];
		}
		return (boss.LevelName.StartsWith("LZ") ? "心中的" : "") + fText?.ToString() + ((num > 0) ? $"({num + 1})" : "");
	}

	private static void InsertCustomBossIterationsMenu(FMenuHelper<EShrineMenuTag> shrineMenuHelper, FMenuHelper<ETeleportMenuTag> teleportMenuHelper, DSShrineMain DataStore, UIShrineMain __instance)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		shrineMenuHelper.ClearLayout();
		shrineMenuHelper.Register(new FBtnRegisterInfo<EShrineMenuTag>
		{
			MenuBtnType = (EMenuBtnType)4,
			Name = FText.FromString("自定义连战"),
			Tips = FText.FromString("自定义连战"),
			BtnAction = delegate
			{
				InitBossListMenu(shrineMenuHelper, teleportMenuHelper, DataStore, __instance);
			},
			BtnHashCode = "Func_CustomBossIterations",
			SortId = 18,
			ParentBtnHash = $"Func_{16}"
		});
		Utils.InvokeMethod(typeof(UIShrineMain), __instance, "InitShrineMenu", new object[0], BindingFlags.Instance | BindingFlags.NonPublic);
	}

	private static void InitBossListMenu(FMenuHelper<EShrineMenuTag> shrineMenuHelper, FMenuHelper<ETeleportMenuTag> teleportMenuHelper, DSShrineMain DataStore, UIShrineMain __instance)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		if (BossRushV4.DuplicateNameDict != null)
		{
			BossRushV4.DuplicateNameDict.Clear();
		}
		teleportMenuHelper.ClearLayout();
		teleportMenuHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
		{
			MenuBtnType = (EMenuBtnType)4,
			Name = FText.FromString("前往自定义连战"),
			Tips = FText.FromString("前往自定义连战"),
			BtnAction = delegate
			{
				//IL_0131: Unknown result type (might be due to invalid IL or missing references)
				//IL_0136: Unknown result type (might be due to invalid IL or missing references)
				//IL_013e: Unknown result type (might be due to invalid IL or missing references)
				//IL_014f: Expected O, but got Unknown
				//IL_019e: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01af: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bc: Expected O, but got Unknown
				//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e1: Expected O, but got Unknown
				//IL_020a: Unknown result type (might be due to invalid IL or missing references)
				//IL_020f: Unknown result type (might be due to invalid IL or missing references)
				//IL_021b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0228: Expected O, but got Unknown
				//IL_022f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0234: Unknown result type (might be due to invalid IL or missing references)
				//IL_0240: Unknown result type (might be due to invalid IL or missing references)
				//IL_024d: Expected O, but got Unknown
				//IL_0273: Unknown result type (might be due to invalid IL or missing references)
				//IL_0278: Unknown result type (might be due to invalid IL or missing references)
				//IL_0284: Unknown result type (might be due to invalid IL or missing references)
				//IL_0291: Expected O, but got Unknown
				//IL_0298: Unknown result type (might be due to invalid IL or missing references)
				//IL_029d: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b6: Expected O, but got Unknown
				if (BossRushV4.Instance.IterationsList.Count < 2)
				{
					GSB1UIUtil.ShowConfirm(FText.FromString("提示"), FText.FromString("自定义连战至少需要2个妖物"), FText.FromString("确认"), (FText)null, false, (Func<DSConfirm, bool>)null, (Func<DSConfirm, bool>)null, 0, -1f, false);
				}
				else
				{
					TBBossIterationsDesc tBBossIterationsDesc = GameDBRuntime.GetTBBossIterationsDesc();
					if (tBBossIterationsDesc != null)
					{
						BossIterationsDesc bossIterationsDesc = GameDBRuntime.GetBossIterationsDesc(99);
						if (bossIterationsDesc == null)
						{
							Console.WriteLine(" !!!!!!! desc is null");
						}
						else
						{
							bossIterationsDesc.Id = 99;
							bossIterationsDesc.GroupName = "自定义连战";
							bossIterationsDesc.BossSuccessiveInfo.Clear();
							bossIterationsDesc.LimitTimeList.Clear();
							foreach (FUStBossRushConfigDesc iterations in BossRushV4.Instance.IterationsList)
							{
								Console.WriteLine(iterations.ID);
								bossIterationsDesc.BossSuccessiveInfo.Add(iterations.ID);
								bossIterationsDesc.LimitTimeList.Add(360);
							}
							bossIterationsDesc.UnlockInfo.Clear();
							for (int i = 0; i < BossRushV4.Instance.IterationsList.Count; i++)
							{
								bossIterationsDesc.UnlockInfo.Add(new BossUnlockConfig
								{
									UnlockCondition = (EBossUnlockCondition)1,
									UnlockId = 202201
								});
							}
							bossIterationsDesc.IterationsAward.Clear();
							if (BossRushV4.Instance.IterationsList.Count >= 6)
							{
								bossIterationsDesc.IterationsAward.Add(new ItemOne
								{
									Id = 3954,
									Num = 1
								});
								bossIterationsDesc.IterationsAward.Add(new ItemOne
								{
									Id = 3962,
									Num = 1
								});
							}
							else if (BossRushV4.Instance.IterationsList.Count >= 4)
							{
								bossIterationsDesc.IterationsAward.Add(new ItemOne
								{
									Id = 3953,
									Num = 2
								});
								bossIterationsDesc.IterationsAward.Add(new ItemOne
								{
									Id = 3961,
									Num = 2
								});
							}
							else if (BossRushV4.Instance.IterationsList.Count >= 2)
							{
								bossIterationsDesc.IterationsAward.Add(new ItemOne
								{
									Id = 3952,
									Num = 3
								});
								bossIterationsDesc.IterationsAward.Add(new ItemOne
								{
									Id = 3960,
									Num = 3
								});
							}
							bossIterationsDesc.LimitTime = 0;
							bossIterationsDesc.SortId = 99;
							bossIterationsDesc.LocalizationTag = 1;
							bossIterationsDesc.PictureId = 0;
							bossIterationsDesc.BattleEndBuff = 415;
							BossRushV4.Instance.CustomBossIterationConfig = new CustomBossIterationConfig
							{
								CustomBossIterationDesc = bossIterationsDesc
							};
							Utils.SaveConfig(BossRushV4.Instance.CustomBossIterationConfig);
							if (tBBossIterationsDesc.List != null && !tBBossIterationsDesc.List.Contains(bossIterationsDesc))
							{
								Console.WriteLine("Add Desc !!!");
								tBBossIterationsDesc.List.Add(bossIterationsDesc);
							}
							GSG.BattleLogicSvc.DoInteractBehaviour((EInteractUIBehavior)6, 0);
							GSG.RedPointMgr.RedPointRemove((RedPointType)21, 24);
							GSB1UIUtil.ShowBossIterations((UObject)Helper.GetWorld(), (EBossRushUIState)1);
						}
					}
				}
			},
			BtnHashCode = "Func_ToCustomBossIterations",
			SortId = 1,
			VisibleFunc = () => BossRushV4.Instance.IterationsList != null && BossRushV4.Instance.IterationsList.Count > 0
		});
		teleportMenuHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
		{
			MenuBtnType = (EMenuBtnType)4,
			Name = FText.FromString("已加入连战的列表"),
			Tips = FText.FromString("已加入连战的列表"),
			BtnHashCode = "Func_CustomBossIterations_IterationList",
			SortId = 1,
			VisibleFunc = () => BossRushV4.Instance.IterationsList.Count > 0
		});
		if (BossRushV4.Instance.IterationsList != null && BossRushV4.Instance.IterationsList.Count > 0)
		{
			for (int num = 0; num < BossRushV4.Instance.IterationsList.Count; num++)
			{
				int index = num;
				FUStBossRushConfigDesc boss = BossRushV4.Instance.IterationsList[num];
				string realBossName = GetRealBossName(boss);
				teleportMenuHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
				{
					MenuBtnType = (EMenuBtnType)4,
					Name = FText.FromString("移出 " + realBossName),
					Tips = FText.FromString("点击将 " + realBossName + " 移出自定义连战列表"),
					BtnAction = delegate
					{
						BossRushV4.Instance.IterationsList.RemoveAt(index);
						teleportMenuHelper.ResetFocus();
						GenAShrineMain.SetShrineType((EShrineType)0, "OnUIActionBack", (ChangeReason)null);
						InitBossListMenu(shrineMenuHelper, teleportMenuHelper, DataStore, __instance);
					},
					BtnHashCode = $"Func_IterationList_{boss.ID}",
					SortId = num,
					ParentBtnHash = "Func_CustomBossIterations_IterationList",
					VisibleFunc = () => BossRushV4.Instance.IterationsList.Contains(boss)
				});
			}
			if (BossRushV4.Instance.IterationsList.Count == 1)
			{
				teleportMenuHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
				{
					MenuBtnType = (EMenuBtnType)4,
					Name = FText.FromString("还需加入一个妖物才可开启连战"),
					Tips = FText.FromString("还需加入一个妖物才可开启连战"),
					BtnAction = delegate
					{
					},
					BtnHashCode = "Func_Tips_needAdd",
					SortId = 99999,
					ParentBtnHash = "Func_CustomBossIterations_IterationList",
					VisibleFunc = () => BossRushV4.Instance.IterationsList.Count == 1
				});
			}
		}
		teleportMenuHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
		{
			MenuBtnType = (EMenuBtnType)4,
			Name = FText.FromString("在下方列表里选择妖物加入连战"),
			Tips = FText.FromString("在下方列表里选择妖物加入连战"),
			BtnAction = delegate
			{
			},
			BtnHashCode = "Func_Tips_AddIteration",
			SortId = 2
		});
		Dictionary<int, FUStBossRushConfigDesc> tBFUStBossRushConfigDesc = GameDBRuntime.GetTBFUStBossRushConfigDesc();
		if (tBFUStBossRushConfigDesc != null)
		{
			Dictionary<int, List<FUStBossRushConfigDesc>> dictionary = new Dictionary<int, List<FUStBossRushConfigDesc>>();
			foreach (KeyValuePair<int, FUStBossRushConfigDesc> item in tBFUStBossRushConfigDesc)
			{
				if (BossRushV4.Instance.IterationsList != null && BossRushV4.Instance.IterationsList.Contains(item.Value))
				{
					continue;
				}
				if (!dictionary.ContainsKey(item.Value.LevelID))
				{
					dictionary.Add(item.Value.LevelID, new List<FUStBossRushConfigDesc> { item.Value });
					continue;
				}
				if (dictionary[item.Value.LevelID] == null)
				{
					dictionary[item.Value.LevelID] = new List<FUStBossRushConfigDesc>();
				}
				dictionary[item.Value.LevelID].Add(item.Value);
			}
			foreach (KeyValuePair<int, List<FUStBossRushConfigDesc>> item2 in dictionary)
			{
				LevelDesc levelDesc = GameDBRuntime.GetLevelDesc(item2.Key);
				if (levelDesc == null)
				{
					continue;
				}
				if (item2.Value != null && item2.Value.Count > 0)
				{
					teleportMenuHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
					{
						MenuBtnType = (EMenuBtnType)4,
						Name = GSLocalization.ToFText(levelDesc.Name),
						Tips = GSLocalization.ToFText(levelDesc.Name),
						BtnHashCode = $"Func_Level_{item2.Key}",
						SortId = item2.Key
					});
					foreach (FUStBossRushConfigDesc boss2 in item2.Value)
					{
						string realBossName2 = GetRealBossName(boss2);
						teleportMenuHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
						{
							MenuBtnType = (EMenuBtnType)4,
							Name = FText.FromString(realBossName2),
							Tips = FText.FromString("点击将 " + realBossName2 + "  加入自定义连战列表"),
							BtnAction = delegate
							{
								BossRushV4.Instance.IterationsList.Add(boss2);
								GenAShrineMain.SetShrineType((EShrineType)0, "OnUIActionBack", (ChangeReason)null);
								InitBossListMenu(shrineMenuHelper, teleportMenuHelper, DataStore, __instance);
							},
							BtnHashCode = $"Func_Boss_{boss2.ID}",
							SortId = boss2.ID,
							ParentBtnHash = $"Func_Level_{item2.Key}",
							VisibleFunc = () => !BossRushV4.Instance.IterationsList.Contains(boss2)
						});
					}
				}
				if (item2.Value.Count == 1)
				{
					teleportMenuHelper.Register(new FBtnRegisterInfo<ETeleportMenuTag>
					{
						MenuBtnType = (EMenuBtnType)4,
						Name = FText.FromString("作者：禽兽·云轩"),
						Tips = FText.FromString("作者：禽兽·云轩"),
						BtnAction = delegate
						{
							GSB1UIUtil.ShowConfirm(FText.FromString("作者"), FText.FromString("还想打作者？想挺美啊！"), FText.FromString("我错了"), (FText)null, false, (Func<DSConfirm, bool>)null, (Func<DSConfirm, bool>)null, 0, -1f, false);
						},
						BtnHashCode = $"Func_Boss_{item2.Key}_Author",
						SortId = 999999,
						ParentBtnHash = $"Func_Level_{item2.Key}"
					});
				}
			}
		}
		teleportMenuHelper.UpdateLayout();
		GenAShrineMain.SetShrineType((EShrineType)1, "ShowTeleportMenu", (ChangeReason)null);
		teleportMenuHelper.ResetFocus();
		UTextBlock uTextBlock = ((GSUIView)__instance).FindChildWidget("TxtSubName") as UTextBlock;
		if (uTextBlock != null)
		{
			uTextBlock.SetText(FText.FromString("自定义连战"));
		}
	}
}
