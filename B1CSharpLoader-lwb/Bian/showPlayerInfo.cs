using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using b1;
using B1UI.GSUI;
using BtlB1;
using BtlShare;
using CSharpModBase;
using GSE.GSUI;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace bian;

public class ShowPlayerInfo
{

	public struct SurfaceTypeInfo
	{
		public string Name;
		public int BuffId;
	}
	public static Dictionary<int, string> buffDict = new Dictionary<int, string>
				{
					{BuffElementIds.Thunder, "雷"},
					{BuffElementIds.Ice, "冰"},
					{BuffElementIds.Fire, "火"},
					{BuffElementIds.Poison, "毒"}
				};

	public interface ISurfaceTypeInfo
	{
		string Name { get; set; }
		int BuffId { get; set; }
	}

	public static Dictionary<ESceneItemSurfaceType, SurfaceTypeInfo> SurfaceTypeDict = new Dictionary<ESceneItemSurfaceType, SurfaceTypeInfo>
{
	{ESceneItemSurfaceType.DefaultSurface, new SurfaceTypeInfo { Name = "无", BuffId = 0}},
	{ESceneItemSurfaceType.GrassSurface, new SurfaceTypeInfo { Name = "草地", BuffId = 777666004}},
	{ESceneItemSurfaceType.WaterSurface, new SurfaceTypeInfo { Name = "水中", BuffId = 777666001}},
	{ESceneItemSurfaceType.CloudSurface, new SurfaceTypeInfo { Name = "云", BuffId = 777666004}},
	{ESceneItemSurfaceType.StoneSurface, new SurfaceTypeInfo { Name = "石头", BuffId = 777666004}},
	{ESceneItemSurfaceType.MudSurface, new SurfaceTypeInfo { Name = "泥地", BuffId = 777666001}},
	{ESceneItemSurfaceType.SoilSurface, new SurfaceTypeInfo { Name = "土壤", BuffId = 777666004}},
	{ESceneItemSurfaceType.WoodSurface, new SurfaceTypeInfo { Name = "木头", BuffId = 777666004}},
	{ESceneItemSurfaceType.HfmsoftSandSurface, new SurfaceTypeInfo { Name = "软沙", BuffId = 777666004}},
	{ESceneItemSurfaceType.GlideSandSurface, new SurfaceTypeInfo { Name = "滑沙", BuffId = 777666004}},
	{ESceneItemSurfaceType.SnowSurface, new SurfaceTypeInfo { Name = "雪地", BuffId = 777666002}},
	{ESceneItemSurfaceType.IceSurface, new SurfaceTypeInfo { Name = "冰面", BuffId = 777666002}},
	{ESceneItemSurfaceType.LavaSurface, new SurfaceTypeInfo { Name = "岩浆", BuffId = 777666003}},
	{ESceneItemSurfaceType.YinSurface, new SurfaceTypeInfo { Name = "阴", BuffId = 777666004}},
	{ESceneItemSurfaceType.YangSurface, new SurfaceTypeInfo { Name = "阳", BuffId = 777666004}},
	{ESceneItemSurfaceType.BloodSurface, new SurfaceTypeInfo { Name = "血池", BuffId = 777666001}},
	{ESceneItemSurfaceType.GlideSnow, new SurfaceTypeInfo { Name = "滑雪", BuffId = 777666002}},
	{ESceneItemSurfaceType.GlideIce, new SurfaceTypeInfo { Name = "滑冰", BuffId = 777666002}},
	{ESceneItemSurfaceType.BajieMud, new SurfaceTypeInfo { Name = "泥浆", BuffId = 777666001}},
	{ESceneItemSurfaceType.CricketBody, new SurfaceTypeInfo { Name = "蟋蟀背", BuffId = 0}},
	{ESceneItemSurfaceType.EnumMax, new SurfaceTypeInfo { Name = "最大值", BuffId = 0}}
};
	public static List<UTextBlock> BasicInfoVs = new List<UTextBlock>();

	public static Dictionary<EBGUAttrFloat, string> BasicAttributes = new Dictionary<EBGUAttrFloat, string>
	{
		{ EBGUAttrFloat.Shield,  "护盾:" },
		{ EBGUAttrFloat.CritRate, "暴击:" },
		{ EBGUAttrFloat.Hp,  "生命:" },
		{ EBGUAttrFloat.FreezeDef,  "四灾抗性:" },
		{ EBGUAttrFloat.FreezeAtk,  "四灾攻击:" },
		{ EBGUAttrFloat.CurEnergy,  "神力:" },
		{ EBGUAttrFloat.EnumMax,  "当前buff:" },
		{ EBGUAttrFloat.None,  "目标角色:" },
	};

	private static UWorld? world;

	public static UWorld? GetWorld()
	{
		if (world == null || !world.IsValidLowLevel() || world.IsPendingKill)
		{
			world = GCHelper.FindRef(FGlobals.GWorld)?.Managed as UWorld;
		}
		return world;
	}

	public static bool IsValidActor(AActor? actor)
	{
		return actor != null && actor.IsValidLowLevel() && !actor.IsPendingKill && !actor.IsActorBeingDestroyed();
	}

	public static bool IsValidUObject(UObject? uobj)
	{
		return uobj != null && uobj.IsValidLowLevel() && !uobj.IsPendingKill;
	}

	public static FSlateFontInfo FontInfo = new FSlateFontInfo
	{
		FontObject = UObject.LoadObject<UFont>(null, "/Game/00MainHZ/UI/Fonts/B1Font_Main.B1Font_Main"),
		Size = 34
	};
	// 添加特殊属性字体样式
	public static FSlateFontInfo BoldFontInfo = new FSlateFontInfo
	{
		FontObject = UObject.LoadObject<UFont>(null, "/Game/00MainHZ/UI/Fonts/B1Font_Main.B1Font_Main"),
		Size = 42
	};

	public static void SetUTextBlockContent(UTextBlock textBlock, string content)
	{
		if (IsValidUObject(textBlock))
		{
			textBlock.SetText(FText.FromString(content));
		}
	}

	public static void UpdateUTextBlockContentIfChanged(UTextBlock textBlock, string newText)
	{
		if (IsValidUObject(textBlock))
		{
			string text = textBlock.GetText().ToString();
			if (text != newText)
			{
				textBlock.SetText(FText.FromString(newText));
			}
		}
	}

	public static void SetUTextBlockFont(UTextBlock textBlock, FSlateFontInfo fontInfo)
	{
		if (IsValidUObject(textBlock))
		{
			textBlock.SetFont(fontInfo);
		}
	}

	public static void SetUTextBlockStyle(UTextBlock? textBlock, float opacity, ETextJustify justify)
	{
		if (IsValidUObject(textBlock))
		{
			textBlock.SetJustification(justify);
			textBlock.SetOpacity(opacity);
		}
	}

	// 添加需要特殊样式的属性集合
	public static readonly HashSet<EBGUAttrFloat> SpecialAttributes = new HashSet<EBGUAttrFloat>
{
	EBGUAttrFloat.Shield,
	EBGUAttrFloat.Atk,
	EBGUAttrFloat.DmgDef
};


	private static Timer? updateTimer;
	private static int BattleMainConID = (int)EUIPageID.BattleMainCon;


	public static bool hasValueTextBlock()
	{

		UWorld World = GetWorld();
		if (World != null && GSUI.UIMgr.FindUIPage(World, BattleMainConID) is UIBattleMainCon obj)
		{
			UCanvasPanel MainCon = obj.GetFieldOrProperty<UCanvasPanel>("MainCon");
			if (!IsValidUObject(MainCon))
			{
				return false;
			}
			var children = MainCon.GetAllChildren();
			if (children != null && children.Count > 0)
			{
				var isHas = children?.Any(child =>
		  					child is UTextBlock textBlock &&
		  					textBlock != null &&
		  					textBlock.GetText().Contains("护盾")) ?? false;
				return isHas;
			}
		}
		return false;

	}
	public static UTextBlock? getValueTextBlock(string str)
	{

		UWorld World = GetWorld();
		if (World != null && GSUI.UIMgr.FindUIPage(World, BattleMainConID) is UIBattleMainCon obj)
		{
			UCanvasPanel MainCon = obj.GetFieldOrProperty<UCanvasPanel>("MainCon");
			if (!IsValidUObject(MainCon))
			{
				return null;
			}
			var children = MainCon.GetAllChildren();
			if (children != null && children.Count > 0)
			{

				return (UTextBlock)children.FirstOrDefault(child =>
							 child is UTextBlock textBlock &&
							 textBlock != null &&
							 textBlock.GetText().Contains(str));

			}
		}
		return null;

	}



	public static void InitItems(bool force = false)
	{

		BGUPlayerCharacterCS bGUPlayerCharacterCS = GetBGUPlayerCharacterCS();
		if (bGUPlayerCharacterCS == null)
		{
			return;
		}
		if (hasValueTextBlock())
		{
			if (!force) return;
			return;
		}

		foreach (var attribute in BasicAttributes)
		{
			UTextBlock valueBlock = getValueTextBlock(attribute.Value);
			if (valueBlock == null)
			{
				valueBlock = UObject.NewObject<UTextBlock>();
			}
			int index = BasicAttributes.Keys.ToList().IndexOf(attribute.Key);
			if (index >= 0)
			{
				if (index < BasicInfoVs.Count)
				{
					BasicInfoVs[index] = valueBlock;
				}
				else
				{
					BasicInfoVs.Add(valueBlock);
				}
			}
			SetUTextBlockFont(valueBlock, FontInfo);
			SetUTextBlockStyle(valueBlock, 0.6f, ETextJustify.Right);
			// valueBlock.SetAutoWrapText(true);  // 启用自动换行
			// 优化后的特殊样式设置
			UpdateUTextBlockContentIfChanged(valueBlock, attribute.Value);
			if (SpecialAttributes.Contains(attribute.Key))
			{
				SetUTextBlockFont(valueBlock, BoldFontInfo);
			}
		}

		var World = GetWorld();
		if (!IsValidUObject(World)) return;
		if (GSUI.UIMgr.FindUIPage(World, BattleMainConID) is UIBattleMainCon obj)
		{
			var MainCon = obj.GetFieldOrProperty<UCanvasPanel>("MainCon");
			if (!IsValidUObject(MainCon))
				return;
			if (BasicInfoVs == null || BasicInfoVs.Count == 0) return;
			for (int i = 0; i < BasicAttributes.Count; i++)
			{
				UCanvasPanelSlot valueSlot = MainCon.AddChild(BasicInfoVs[i]) as UCanvasPanelSlot;
				if (valueSlot == null) return;
				if (IsValidUObject(valueSlot))
				{
					valueSlot.SetAnchors(new FAnchors
					{
						Minimum = new FVector2D(0.25, 0.1),
						Maximum = new FVector2D(0.25, 0.1)
					});
					valueSlot.SetAlignment(new FVector2D(0.25, 0.14));
					valueSlot.SetPosition(new FVector2D(80, 65f * i));
				}
			}
			RenderBasicInfo();
		}


	}
	private static DateTime lastRenderTime = DateTime.MinValue;

	public static void RenderBasicInfo()
	{
		// 检查距离上次执行时间
		if ((DateTime.Now - lastRenderTime).TotalSeconds < 0.2)
		{
			return;
		}
		lastRenderTime = DateTime.Now;
		APawn controlledPawn = GetControlledPawn();
		if (!IsValidActor(controlledPawn) || BasicInfoVs.Count == 0) return;
		int index = 0;
		foreach (var attribute in BasicAttributes)
		{
			if (index >= BasicInfoVs.Count) break;

			var value = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, attribute.Key);
			if (attribute.Key == EBGUAttrFloat.Shield)
			{

				// 护盾/伤害减免
				float DmgDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.DmgDef);
				float Shield = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.Shield);
				float Atk = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.Atk);
				UpdateUTextBlockContentIfChanged(BasicInfoVs[index], $"护盾: {(int)Shield}, 攻击: {(int)Atk}, 减伤: {(int)DmgDef / 100}%");
			}
			else if (attribute.Key == EBGUAttrFloat.CritRate)
			{
				// 暴击/暴伤
				float CritMultiplier = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.CritMultiplier);
				float SkillSuperArmor = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.SkillSuperArmor);
				// 攻击/伤害加成
				float DmgAddition = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.DmgAddition);
				UpdateUTextBlockContentIfChanged(BasicInfoVs[index], $"暴击: {(int)value / 100}%, 暴伤: {(int)CritMultiplier / 100f + 130f}%, 加伤: {(int)DmgAddition / 100}%, 技能霸体: {(int)SkillSuperArmor}");
			}
			else if (attribute.Key == EBGUAttrFloat.Hp)
			{
				// 生命/法力
				float Mp = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.Mp);
				float def = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.Def);
				UpdateUTextBlockContentIfChanged(BasicInfoVs[index], $"生命：{(int)value},  法力：{(int)Mp}, 防御：{(int)def}");
			}
			else if (attribute.Key == EBGUAttrFloat.FreezeDef)
			{
				// 抗性
				float FreezeDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.FreezeDef);
				float BurnDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.BurnDef);
				float PoisonDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.PoisonDef);
				float ThunderDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.ThunderDef);
				UpdateUTextBlockContentIfChanged(BasicInfoVs[index], $"四灾抗性: 冰:{(int)FreezeDef}, 火:{(int)BurnDef},  毒:{(int)PoisonDef},  雷:{(int)ThunderDef}");
			}
			else if (attribute.Key == EBGUAttrFloat.FreezeAtk)
			{
				// 抗性
				float FreezeDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.FreezeAtk);
				float BurnDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.BurnAtk);
				float PoisonDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.PoisonAtk);
				float ThunderDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.ThunderAtk);
				UpdateUTextBlockContentIfChanged(BasicInfoVs[index], $"四灾攻击: 冰:{(int)FreezeDef}, 火:{(int)BurnDef},  毒:{(int)PoisonDef},  雷:{(int)ThunderDef}");
			}
			else if (attribute.Key == EBGUAttrFloat.CurEnergy)
			{
				// 抗性
				float TransEnergyMax = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.TransEnergyMax);
				float FabaoEnergy = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.FabaoEnergy);
				float VigorEnergy = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.VigorEnergy);
				float CommDropAddition = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.CommDropAddition);
				int dropAdd = (int)CommDropAddition / 100 > 100 ? 100 : (int)CommDropAddition / 100;
				UpdateUTextBlockContentIfChanged(BasicInfoVs[index], $"神力: {(int)value},  法宝: {(int)FabaoEnergy},  精魄: {(int)VigorEnergy}, 掉宝: {dropAdd}%");
			}

			else if (attribute.Key == EBGUAttrFloat.EnumMax && controlledPawn != null)
			{
				string currentBuff = buffDict.FirstOrDefault(kvp => BGUFunctionLibraryCS.BGUHasBuffByID(controlledPawn, kvp.Key)).Value;
				var buffText = !string.IsNullOrEmpty(currentBuff) ? $"当前buff: {currentBuff}" : "当前buff: 无";
				var aCharacter = controlledPawn;
				if (aCharacter != null)
				{

					var MovementData = BGU_DataUtil.GetReadOnlyData<IBUC_MovementData, BUC_MovementData>(controlledPawn);
					if (MovementData != null)
					{
						var EnvironmentInteractionMgrData = BGU_DataUtil.GetReadOnlyData<BUC_EnvironmentInteractionMgrData>(controlledPawn);
						if (EnvironmentInteractionMgrData != null)
						{
							EnvironmentInteractionMgrData.bNearGround = MovementData.CanUseSurfaceTypeFromMovementComp();
							var curItem = SurfaceTypeDict.FirstOrDefault(kvp => kvp.Key == EnvironmentInteractionMgrData.LastResultSurfaceType).Value;
							string SurfaceTypeStr = curItem.Name;
							// var buffId = curItem.BuffId;
							// if (buffId != 0 && !BGUFunctionLibraryCS.BGUHasBuffByID(controlledPawn, buffId))
							// {
							//     BGUFunctionLibraryCS.BGUAddBuff(controlledPawn, controlledPawn, buffId, EBuffSourceType.GM, 3000);
							// }
							buffText += $";   地形: {SurfaceTypeStr}";
						}
					}
				}
				float Pevalue = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.Pevalue);
				buffText += $";  棍势: {(int)Pevalue}";
				if (Helper.auto_attack)
				{
					buffText += $"\n 已开启自动雷击 \n ";
				}
				else
				{
					buffText += $"\n 已关闭自动雷击 \n ";
				}
				UpdateUTextBlockContentIfChanged(BasicInfoVs[index], buffText);
			}

			else if (attribute.Key == EBGUAttrFloat.None)
			{
				var target = BGUFunctionLibraryCS.BGUGetTarget(controlledPawn) as BGUCharacterCS;


				var text = "\n 目标角色:";
				if (target == null)
				{
					target = Helper.GetNearestActor(4000);
					text = "\n 最近角色:";
				}
				if (target != null)
				{
					// 生命/法力
					float Hp = BGUFunctionLibraryCS.GetAttrValue(target, EBGUAttrFloat.Hp);
					float Atk = BGUFunctionLibraryCS.GetAttrValue(target, EBGUAttrFloat.Atk);
					float DmgDef = BGUFunctionLibraryCS.GetAttrValue(target, EBGUAttrFloat.DmgDef);
					var teamID = target.GetTeamIDInCS();
					var player = Helper.GetBGUPlayerCharacterCS();
					var playerTeamID = player.GetTeamIDInCS();
					var teamTxt = teamID == playerTeamID ? "友" : "敌";
					var distanceNum = player.GetDistanceTo(target);
					BGW_UIEventCollection.Get(target)?.Evt_UI_InitTopBarUI(ECSExtension.ToEntity(target));
					// 攻击/伤害加成
					float DmgAddition = BGUFunctionLibraryCS.GetAttrValue(target, EBGUAttrFloat.DmgAddition);


					float FreezeDef = BGUFunctionLibraryCS.GetAttrValue(target, EBGUAttrFloat.FreezeDef);
					float BurnDef = BGUFunctionLibraryCS.GetAttrValue(target, EBGUAttrFloat.BurnDef);
					float PoisonDef = BGUFunctionLibraryCS.GetAttrValue(target, EBGUAttrFloat.PoisonDef);
					float ThunderDef = BGUFunctionLibraryCS.GetAttrValue(target, EBGUAttrFloat.ThunderDef);



					float FreezeATK = BGUFunctionLibraryCS.GetAttrValue(target, EBGUAttrFloat.FreezeAtk);
					float BurnATK = BGUFunctionLibraryCS.GetAttrValue(target, EBGUAttrFloat.BurnAtk);
					float PoisonATK = BGUFunctionLibraryCS.GetAttrValue(target, EBGUAttrFloat.PoisonAtk);
					float ThunderATK = BGUFunctionLibraryCS.GetAttrValue(target, EBGUAttrFloat.ThunderAtk);

					var DmgDefTxt = DmgDef != 0 ? $", 减伤:{(int)DmgDef / 100}%, " : "";
					var DmgAdditionTxt = DmgAddition != 0 ? $", 加伤:{(int)DmgAddition / 100}%, " : "";
					// 18400
					BUC_BuffData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(target);

					var finaltxt = $"{text}({teamTxt})生命:{(int)Hp}, 攻击:{(int)Atk} {DmgDefTxt} {DmgAdditionTxt} \n 四灾抗性: 冰:{(int)FreezeDef}, 火:{(int)BurnDef},  毒:{(int)PoisonDef},  雷:{(int)ThunderDef} \n 四灾攻击: 冰:{(int)FreezeATK}, 火:{(int)BurnATK},  毒:{(int)PoisonATK},  雷:{(int)ThunderATK}";
					if (readOnlyData != null)
					{
						int buffLayer = readOnlyData.GetBuffLayer(18400);
						if (buffLayer > 0)
						{
							finaltxt += $"\n {buffLayer}层虫卵";
						}
					}

					UpdateUTextBlockContentIfChanged(BasicInfoVs[index], finaltxt);
				}
				else
				{
					UpdateUTextBlockContentIfChanged(BasicInfoVs[index], "\n 目标角色: 无");
				}
			}
			index++;
		}
	}

	// private static void StartUpdateTimer(TimerComp timerComp)
	// {

	// 	// 如果已有定时器在运行，先停止它
	// 	if (updateTimer != null)
	// 	{
	// 		updateTimer.Dispose();
	// 		updateTimer = null;
	// 	}

	// 	// 创建新的定时器，每1秒执行一次
	// 	updateTimer = new Timer(_ =>
	// 	{
	// 		if (timerComp != null)
	// 		{
	// 			if (timerComp.InitDone())
	// 			{
	// 				timerComp.RenderBasicInfo();
	// 			}
	// 		}
	// 	}, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
	// }

	public static APawn? GetControlledPawn()
	{
		UWorld uWorld = GetWorld();
		if (!IsValidUObject(uWorld))
		{
			return null;
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)uWorld);
		if (!IsValidActor(firstLocalPlayerController))
		{
			return null;
		}
		return firstLocalPlayerController.GetControlledPawn();
	}
	public static BGUPlayerCharacterCS? GetBGUPlayerCharacterCS()
	{
		APawn controlledPawn = GetControlledPawn();
		if (!IsValidActor(controlledPawn))
		{
			return null;
		}
		return controlledPawn as BGUPlayerCharacterCS;
	}


	public static void ClearAllUI()
	{
		// 清理定时器
		if (updateTimer != null)
		{
			updateTimer.Dispose();
			updateTimer = null;
		}
		var World = GetWorld();
		if (!IsValidUObject(World)) return;
		if (World != null && GSUI.UIMgr.FindUIPage(World, BattleMainConID) is UIBattleMainCon obj)
		{
			UCanvasPanel MainCon = obj.GetFieldOrProperty<UCanvasPanel>("MainCon");
			var children = MainCon.GetAllChildren();
			// BasicInfoVs.Count
			if (BasicInfoVs.Count > 0)
			{
				foreach (var item in BasicInfoVs)
				{
					item.RemoveFromParent();
					MainCon.RemoveChild(item);
				}
				BasicInfoVs.Clear();
			}

			if (children != null && children.Count > 0)
			{
				var textToRemove = new[] { "护盾:", "暴击：", "生命：", "四灾抗性:", "四灾攻击:", "神力:", "当前buff:", "角色:" };
				foreach (var child in children)
				{
					if (child is UTextBlock textBlock && textToRemove.Any(text => textBlock.GetText().Contains(text)))
					{
						child.RemoveFromParent();
						MainCon.RemoveChild(child);
					}
				}
			}
		}
	}




	~ShowPlayerInfo()
	{
		ClearAllUI();
	}

	public void Dispose()
	{
		ClearAllUI();
		GC.SuppressFinalize(this);
	}

}
