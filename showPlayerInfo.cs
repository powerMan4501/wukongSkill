using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using b1;
using b1.Localization;
using B1UI.GSUI;
using BtlB1;
using BtlShare;
using CSharpModBase;
using GSE.GSUI;
using Newtonsoft.Json;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

#pragma warning disable CS8600, CS8602, CS8604 // 禁用 Unreal Engine API 相关的可空警告
#pragma warning disable CA1416 // 禁用平台兼容性警告（Timer 在线程池线程执行）

namespace MagicMod;

/// <summary>
/// 玩家信息展示系统
/// 在战斗界面上显示玩家和目标的详细属性信息
/// </summary>
public class ShowPlayerInfo
{
	/// <summary>
	/// 地表类型信息
	/// </summary>
	public struct SurfaceTypeInfo
	{
		public string Name;
		public int BuffId;
	}

	public static List<UTextBlock> BasicInfoVs = new List<UTextBlock>();
	public static DateTime lastUpdateTime = DateTime.MinValue;
	public static Timer? updateTimer;

	/// <summary>是否已有"已投递但还没在游戏线程执行完"的渲染任务（0/1，Interlocked 操作），用于去重防止回调堆积</summary>
	private static int _renderPending = 0;

	/// <summary>最近角色缓存：命中时直接复用，避免每 0.5s 都做一次球形查询</summary>
	private static BGUCharacterCS? _cachedNearestActor;
	private static DateTime _cachedNearestTime = DateTime.MinValue;
	private static FVector _cachedNearestPlayerPos = default;

	/// <summary>最近角色缓存有效期（秒）</summary>
	private const double NEAREST_CACHE_TTL_SECONDS = 1.0;

	/// <summary>玩家位移超过该距离（cm）则强制重算最近角色</summary>
	private const float NEAREST_CACHE_MOVE_THRESHOLD = 500f;


	private static UWorld? world;

	// UI 配置常量
	private const float UI_OPACITY = 0.7f;
	private const float FONT_SIZE_NORMAL = 42f;
	private const float FONT_SIZE_BOLD = 40f;
	private const float RENDER_INTERVAL_SECONDS = 0.1f;
	private const int UI_POSITION_X_BASE = -80;
	private const float UI_POSITION_Y_OFFSET = 550f;
	private const float ANCHOR_X = 0.98f;
	private const float ANCHOR_Y = 0.1f;
	private const float ALIGNMENT_X = 1.0f;
	private const float ALIGNMENT_Y = 0.14f;

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

	/// <summary>
	/// 标准字体配置
	/// </summary>
	public static readonly FSlateFontInfo FontInfo = new FSlateFontInfo
	{
		FontObject = UObject.LoadObject<UFont>(null, "/Game/00MainHZ/UI/Fonts/B1Font_Main.B1Font_Main"),
		Size = (int)FONT_SIZE_NORMAL
	};

	/// <summary>
	/// 加粗字体配置（用于重要属性）
	/// </summary>
	public static readonly FSlateFontInfo BoldFontInfo = new FSlateFontInfo
	{
		FontObject = UObject.LoadObject<UFont>(null, "/Game/00MainHZ/UI/Fonts/B1Font_Main.B1Font_Main"),
		Size = (int)FONT_SIZE_BOLD
	};

	/// <summary>
	/// 安全设置文本块内容
	/// </summary>
	public static void SetUTextBlockContent(UTextBlock textBlock, string content)
	{
		if (IsValidUObject(textBlock))
		{
			textBlock.SetText(FText.FromString(content));
		}
	}

	/// <summary>
	/// 仅在内容变化时更新文本块（避免不必要的 UI 刷新）
	/// </summary>
	public static void UpdateUTextBlockContentIfChanged(UTextBlock textBlock, string newText)
	{
		if (!IsValidUObject(textBlock)) return;

		var currentText = textBlock.GetText().ToString();
		if (currentText != newText)
		{
			textBlock.SetText(FText.FromString(newText));
		}
	}

	/// <summary>
	/// 设置文本块字体
	/// </summary>
	public static void SetUTextBlockFont(UTextBlock textBlock, FSlateFontInfo fontInfo)
	{
		if (IsValidUObject(textBlock))
		{
			textBlock.SetFont(fontInfo);
		}
	}

	/// <summary>
	/// 设置文本块样式（透明度和对齐方式）
	/// </summary>
	public static void SetUTextBlockStyle(UTextBlock? textBlock, float opacity, ETextJustify justify)
	{
		if (IsValidUObject(textBlock))
		{
			textBlock.SetJustification(justify);
			textBlock.SetOpacity(opacity);
		}
	}

	/// <summary>
	/// 需要特殊样式的属性集合（使用加粗字体）
	/// </summary>
	public static readonly HashSet<EBGUAttrFloat> SpecialAttributes = new HashSet<EBGUAttrFloat>
	{
		EBGUAttrFloat.Shield,
		EBGUAttrFloat.Atk,
		EBGUAttrFloat.DmgDef
	};


	private static DateTime lastRenderTime = DateTime.MinValue;
	private static readonly int BattleMainConID = (int)EUIPageID.BattleMainCon;

	public static readonly Dictionary<string, string> BasicAttributes = new Dictionary<string, string>
	{
		{ "self",  "当前角色(作者：勇士):" },

		{ "target",  "目标角色:" },
	};


	public static bool hasValueTextBlock()
	{

		UWorld World = GetWorld();
		if (World != null && GSUI.UIMgr.FindUIPage(World, BattleMainConID) is UIBattleMainCon obj)
		{
			UCanvasPanel MainCon = obj.GetFieldOrProperty<UCanvasPanel>("MainCon");
			// var MainCon = (UCanvasPanel)obj.GetType().GetProperty("MainCon").GetValue(obj);

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
		  					textBlock.GetText().Contains("角色:")) ?? false;
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
			// var MainCon = (UCanvasPanel)obj.GetType().GetProperty("MainCon").GetValue(obj);
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


	/// <summary>
	/// 初始化 UI 元素
	/// </summary>
	public static void InitItems(bool force = false)
	{

		var bGUPlayerCharacterCS = GetBGUPlayerCharacterCS();
		if (bGUPlayerCharacterCS == null) return;

		// 如果已经存在且不需要强制刷新，则直接返回
		if (!force && hasValueTextBlock()) return;

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

		}

		var World = GetWorld();
		if (!IsValidUObject(World)) return;
		if (GSUI.UIMgr.FindUIPage(World, BattleMainConID) is UIBattleMainCon obj)
		{
			var MainCon = obj.GetFieldOrProperty<UCanvasPanel>("MainCon");
			// var MainCon = (UCanvasPanel)obj.GetType().GetProperty("MainCon").GetValue(obj);
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
						Minimum = new FVector2D(ANCHOR_X, ANCHOR_Y),
						Maximum = new FVector2D(ANCHOR_X, ANCHOR_Y)
					});
					valueSlot.SetAlignment(new FVector2D(ALIGNMENT_X, ALIGNMENT_Y));
					valueSlot.SetPosition(new FVector2D(UI_POSITION_X_BASE, UI_POSITION_Y_OFFSET * i));
				}
			}
			RenderBasicInfo();
		}


	}
	/// <summary>
	/// 渲染基础信息到 UI
	/// </summary>
	public static void RenderBasicInfo()
	{


		var controlledPawn = GetControlledPawn();
		if (!IsValidActor(controlledPawn) || BasicInfoVs.Count == 0) return;

		// 缓存常用属性值，避免重复调用
		var playerAttrs = CachePlayerAttributes(controlledPawn);

		int index = 0;
		foreach (var attribute in BasicAttributes)
		{
			if (index >= BasicInfoVs.Count) break;

			UpdateAttributeDisplay(index, attribute.Key, attribute.Value, controlledPawn, playerAttrs);
			index++;
		}
	}

	/// <summary>
	/// 缓存玩家属性值，减少重复调用
	/// </summary>
	private static Dictionary<EBGUAttrFloat, float> CachePlayerAttributes(APawn pawn)
	{
		var cache = new Dictionary<EBGUAttrFloat, float>();

		// 缓存所有可能用到的属性
		var attrsToCache = new[] {
			EBGUAttrFloat.Shield, EBGUAttrFloat.Atk, EBGUAttrFloat.DmgDef,
			EBGUAttrFloat.CritRate, EBGUAttrFloat.CritMultiplier, EBGUAttrFloat.SkillSuperArmor, EBGUAttrFloat.DmgAddition,
			EBGUAttrFloat.Hp, EBGUAttrFloat.Mp, EBGUAttrFloat.Def,
			EBGUAttrFloat.FreezeDef, EBGUAttrFloat.BurnDef, EBGUAttrFloat.PoisonDef, EBGUAttrFloat.ThunderDef,
			EBGUAttrFloat.FreezeAtk, EBGUAttrFloat.BurnAtk, EBGUAttrFloat.PoisonAtk, EBGUAttrFloat.ThunderAtk,
			EBGUAttrFloat.CurEnergy, EBGUAttrFloat.TransEnergyMax, EBGUAttrFloat.FabaoEnergy,
			EBGUAttrFloat.VigorEnergy, EBGUAttrFloat.CommDropAddition, EBGUAttrFloat.Pevalue
		};

		foreach (var attr in attrsToCache)
		{
			cache[attr] = BGUFunctionLibraryCS.GetAttrValue(pawn, attr);
		}

		return cache;
	}

	/// <summary>
	/// 更新单个属性的显示
	/// </summary>
	private static void UpdateAttributeDisplay(int index, string type, string label,
		APawn pawn, Dictionary<EBGUAttrFloat, float> cachedAttrs)
	{
		switch (type)
		{
			case "self":
				var str = $"当前角色(作者：勇士):\n 护盾: {(int)cachedAttrs[EBGUAttrFloat.Shield]}, 攻击: {(int)cachedAttrs[EBGUAttrFloat.Atk]}, 减伤: {(int)(cachedAttrs[EBGUAttrFloat.DmgDef] / 100)}% \n" +
					$"暴击: {(int)(cachedAttrs[EBGUAttrFloat.CritRate] / 100)}%, 暴伤: {(int)(cachedAttrs[EBGUAttrFloat.CritMultiplier] / 100f + 130f)}%, 加伤: {(int)(cachedAttrs[EBGUAttrFloat.DmgAddition] / 100)}%, 霸体: {(int)cachedAttrs[EBGUAttrFloat.SkillSuperArmor]} \n" +
					$"生命：{(int)cachedAttrs[EBGUAttrFloat.Hp]},  法力：{(int)cachedAttrs[EBGUAttrFloat.Mp]}, 防御：{(int)cachedAttrs[EBGUAttrFloat.Def]} \n" +
					$"四灾抗性: 冰:{(int)cachedAttrs[EBGUAttrFloat.FreezeDef]}, 火:{(int)cachedAttrs[EBGUAttrFloat.BurnDef]},  毒:{(int)cachedAttrs[EBGUAttrFloat.PoisonDef]},  雷:{(int)cachedAttrs[EBGUAttrFloat.ThunderDef]} \n" +
					$"四灾攻击: 冰:{(int)cachedAttrs[EBGUAttrFloat.FreezeAtk]}, 火:{(int)cachedAttrs[EBGUAttrFloat.BurnAtk]},  毒:{(int)cachedAttrs[EBGUAttrFloat.PoisonAtk]},  雷:{(int)cachedAttrs[EBGUAttrFloat.ThunderAtk]} \n" +
					$"神力: {(int)cachedAttrs[EBGUAttrFloat.CurEnergy]},  法宝: {(int)cachedAttrs[EBGUAttrFloat.FabaoEnergy]},  精魄: {(int)cachedAttrs[EBGUAttrFloat.VigorEnergy]}, 掉宝: {Math.Min(100, (int)(cachedAttrs[EBGUAttrFloat.CommDropAddition] / 100))}% \n" +
						$"当前特效：{ActionExecutor.getCurrentElemtText()}， 棍势：{(int)cachedAttrs[EBGUAttrFloat.Pevalue]} \n";

				UpdateUTextBlockContentIfChanged(BasicInfoVs[index], str);
				break;
			case "target":
				UpdateTargetDisplay(index, pawn);
				break;
		}
	}




	/// <summary>
	/// 清空最近角色缓存（开关面板 / Mod 重载时调用，避免持有已销毁的 UObject）
	/// </summary>
	public static void ClearNearestActorCache()
	{
		_cachedNearestActor = null;
		_cachedNearestTime = DateTime.MinValue;
		_cachedNearestPlayerPos = default;
	}

	/// <summary>
	/// 获取最近角色（带缓存）。
	/// 命中条件：TTL 内 + 玩家位移未超阈值 + 缓存目标仍然有效。
	/// 脱战静止时把球形查询从 2Hz 降到约 1Hz，移动或目标死亡时仍能及时刷新。
	/// </summary>
	public static BGUCharacterCS? GetNearestActor(BGUCharacterCS player, float range = 3000)
	{
		if (!IsValidActor(player)) return null;

		var now = DateTime.Now;
		var playerPos = player.GetActorLocation();

		if (_cachedNearestActor != null && IsValidActor(_cachedNearestActor) &&
			(now - _cachedNearestTime).TotalSeconds < NEAREST_CACHE_TTL_SECONDS &&
			FVector.Distance(_cachedNearestPlayerPos, playerPos) < NEAREST_CACHE_MOVE_THRESHOLD)
		{
			return _cachedNearestActor;
		}

		_cachedNearestActor = FindNearestActor(player, playerPos, range);
		_cachedNearestTime = now;
		_cachedNearestPlayerPos = playerPos;
		return _cachedNearestActor;
	}

	/// <summary>兼容旧的无参调用：内部自行获取玩家角色</summary>
	public static BGUCharacterCS? GetNearestActor(float range = 3000)
	{
		var player = GetBGUPlayerCharacterCS();
		return player == null ? null : GetNearestActor(player, range);
	}

	/// <summary>
	/// 执行一次球形查询并挑出最近角色（仅缓存失效时走这里）
	/// </summary>
	private static BGUCharacterCS? FindNearestActor(BGUCharacterCS player, FVector playerPos, float range)
	{
		var characters = ModUtils.getMonsterByDistance(range);
		if (characters == null || characters.Count == 0) return null;

		// PathName 每次访问都会做 FString → string 封送，必须提到循环外，否则每个 actor 都白多一次字符串分配
		var playerPathName = player.PathName;

		BGUCharacterCS? nearest = null;
		float minDistSq = float.MaxValue;

		foreach (var character in characters)
		{
			if (!IsValidActor(character)) continue;

			// 跳过自己
			if (playerPathName == character.PathName) continue;

			// 软转换：ABGUCharacter 不一定是 BGUCharacterCS，硬转换会抛 InvalidCastException
			var candidate = character as BGUCharacterCS;
			if (candidate == null) continue;

			// 跳过已死亡单位（含尚未销毁的尸体）
			if (BGUFunctionLibraryCS.BGUIsUnitDead(candidate)) continue;

			// 用平方距离比较，省掉 N 次开方；同时复用已拿到的 playerPos，避免重复取玩家
			var loc = candidate.GetActorLocation();
			var dx = (float)(loc.X - playerPos.X);
			var dy = (float)(loc.Y - playerPos.Y);
			var dz = (float)(loc.Z - playerPos.Z);
			var distSq = dx * dx + dy * dy + dz * dz;

			if (distSq < minDistSq)
			{
				minDistSq = distSq;
				nearest = candidate;
			}
		}

		return nearest;
	}


	/// <summary>
	/// 更新目标角色显示
	/// </summary>
	private static void UpdateTargetDisplay(int index, APawn pawn)
	{
		if (pawn is not BGUCharacterCS player) return;

		AActor? targetActor = BGUFunctionLibraryCS.BGUGetTarget(player);
		var text = "\n 目标角色:";

		// if (targetActor == null || !IsValidActor(targetActor))
		// {
		// 	targetActor = GetNearestActor(player, 4000);
		// 	text = "\n 最近角色:";
		// }
		if (targetActor == null || !IsValidActor(targetActor))
		{
			UpdateUTextBlockContentIfChanged(BasicInfoVs[index], "\n 目标角色: 无");
			return;
		}

		var target = targetActor as BGUCharacterCS;
		if (target == null)
		{
			UpdateUTextBlockContentIfChanged(BasicInfoVs[index], "\n 目标角色: 无");
			return;
		}

		// 获取目标名称
		string targetName = GetCharacterDisplayName(target);

		// 自己算距离：走到"最近角色"分支说明 BGUGetTarget 为空，ModHelper.getTargetDistane() 会恒返回 0
		var distance = (int)FVector.Distance(player.GetActorLocation(), target.GetActorLocation());

		text = $"\n {text} {targetName}" + $"  距离：{distance}  \n";

		// 缓存目标属性
		var targetAttrs = new Dictionary<EBGUAttrFloat, float>();
		var attrsToCache = new[] {
			EBGUAttrFloat.Hp, EBGUAttrFloat.Atk, EBGUAttrFloat.DmgDef, EBGUAttrFloat.DmgAddition,
			EBGUAttrFloat.FreezeDef, EBGUAttrFloat.BurnDef, EBGUAttrFloat.PoisonDef, EBGUAttrFloat.ThunderDef,
			EBGUAttrFloat.FreezeAtk, EBGUAttrFloat.BurnAtk, EBGUAttrFloat.PoisonAtk, EBGUAttrFloat.ThunderAtk
		};

		foreach (var attr in attrsToCache)
		{
			targetAttrs[attr] = BGUFunctionLibraryCS.GetAttrValue(target, attr);
		}

		var teamID = target.GetTeamIDInCS();
		var playerTeamID = player.GetTeamIDInCS();
		var teamTxt = teamID == playerTeamID ? "友" : "敌";

		var dmgDef = (int)(targetAttrs[EBGUAttrFloat.DmgDef] / 100);
		var dmgAdd = (int)(targetAttrs[EBGUAttrFloat.DmgAddition] / 100);
		var dmgDefTxt = dmgDef != 0 ? $", 减伤:{dmgDef}% " : "";
		var dmgAddTxt = dmgAdd != 0 ? $", 加伤:{dmgAdd}% " : "";

		var finaltxt = $"{text}({teamTxt}) 生命: {(int)targetAttrs[EBGUAttrFloat.Hp]}, " +
			$"攻击: {(int)targetAttrs[EBGUAttrFloat.Atk]} {dmgDefTxt} {dmgAddTxt}\n" +
			$"四灾抗性: 冰:{(int)targetAttrs[EBGUAttrFloat.FreezeDef]}, 火:{(int)targetAttrs[EBGUAttrFloat.BurnDef]},  " +
			$"毒:{(int)targetAttrs[EBGUAttrFloat.PoisonDef]},  雷:{(int)targetAttrs[EBGUAttrFloat.ThunderDef]}\n" +
			$"四灾攻击: 冰:{(int)targetAttrs[EBGUAttrFloat.FreezeAtk]}, 火:{(int)targetAttrs[EBGUAttrFloat.BurnAtk]},  " +
			$"毒:{(int)targetAttrs[EBGUAttrFloat.PoisonAtk]},  雷:{(int)targetAttrs[EBGUAttrFloat.ThunderAtk]}\n";

		// 检查虫卵层数
		try
		{
			var buffData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(target);
			if (buffData != null)
			{
				var buffLayer = buffData.GetBuffLayer(18400);
				if (buffLayer > 0)
				{
					finaltxt += $"\n {buffLayer}层虫卵";
				}
			}
		}
		catch { /* buff数据可能不可用，忽略 */ }

		UpdateUTextBlockContentIfChanged(BasicInfoVs[index], finaltxt);
	}

	public static bool isTimerRunning = false;

	/// <summary>
	/// 富文本标签清理正则（与 GSLocalization 内部 AllRichRegex 一致）
	/// </summary>
	private static readonly Regex RichTagRegex = new Regex("<[^<>]+>|</>");

	/// <summary>
	/// 判断文本是否仍是未解析的本地化 key（含 .All 等变体后缀）
	/// </summary>
	private static readonly Regex LocalKeyRegex = new Regex(@"^UnitBattleInfoExtendDesc\.\d+\.UnitName(\.\w+)?$");

	// GSLocalization 存放中文的运行时本地字符串表
	private static readonly FName LocalStringTable = new FName("LocalRuntimeStringKVMapDesc");

	// 原生字符串表查不到时返回的哨兵文本（与 GSLocalization.missingFtext 一致），必须视为解析失败，
	// 否则它会被富文本正则整段吞掉变成空串
	private const string MissingEntry = "<MISSING STRING TABLE ENTRY>";

	/// <summary>
	/// 已解析的单位名称缓存（battleInfoExtendID -> 显示名），每个 ID 只解析一次
	/// </summary>
	private static readonly Dictionary<int, string> ResolvedNameCache = new Dictionary<int, string>();

	private static readonly HashSet<int> NameDiagLogged = new HashSet<int>();

	/// <summary>
	/// 获取角色显示名称（从游戏配置表读取）
	/// </summary>
	private static string GetCharacterDisplayName(BGUCharacterCS character)
	{
		try
		{
			if (character == null) return "";
			int battleInfoId = character.GetFinalBattleInfoExtendID();
			if (battleInfoId <= 0) return "";
			FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(battleInfoId);
			if (unitBattleInfoExtendDesc == null) return "";

			string name = ResolveUnitName(unitBattleInfoExtendDesc.UnitName, battleInfoId);
			// UnitName 为空且 override 表无对应项：把角色 PathName 作为占位名写入 unitNameOverride.json，
			// 方便事后根据 PathName 判断并改成正确名字
			if (string.IsNullOrEmpty(name))
				TryAutoRecordPathName(battleInfoId, character);
			return name;
		}
		catch
		{
			return "";
		}
	}

	/// <summary>
	/// 把本地化 key 解析为中文显示名。
	/// 先在当前线程尝试各种查表路径；全部失败时切到游戏线程重试
	/// （游戏自身血条的名字在游戏线程解析，原生字符串表查询在非游戏线程可能不可靠）。
	/// 解析成功按 ID 缓存；彻底失败时写一次诊断日志并返回空串
	/// </summary>
	private static string ResolveUnitName(string key, int battleInfoId)
	{
		// 用户自定义名字覆盖（unitNameOverride.json）：优先级最高，
		// 用于补全游戏配表中 UnitName 为空的单位，或纠正任意单位显示名
		string overrideName = GetNameOverride(battleInfoId);
		if (!string.IsNullOrEmpty(overrideName)) return overrideName;

		if (string.IsNullOrEmpty(key)) return "";
		// 根本不是本地化 key（如 mod 注入的原始中文）：去标签后直接返回
		if (!LocalKeyRegex.IsMatch(key))
			return RichTagRegex.Replace(key, "");

		lock (ResolvedNameCache)
		{
			if (ResolvedNameCache.TryGetValue(battleInfoId, out string cached)) return cached;
		}

		// 先在当前线程用游戏自带方法尝试（非权威：查不到就切游戏线程）
		string[] offCandidates = new string[2];
		string name = ResolveOnce(key, offCandidates, authoritative: false);
		string stage = name != null ? "off" : null;

		// 当前线程查不到（多为非游戏线程导致原生字符串表 miss）→ 切游戏线程重试，
		// 与游戏血条渲染名字所在线程一致
		string[] gtCandidates = null;
		bool gtExecuted = false;
		string gtError = null;
		if (name == null)
		{
			try
			{
				FThreading.RunOnGameThread(() =>
				{
					gtExecuted = true;
					gtCandidates = new string[2];
					name = ResolveOnce(key, gtCandidates, authoritative: true);
				});
			}
			catch (Exception ex)
			{
				gtError = ex.Message;
			}
			if (name != null) stage = "gt";
		}

		if (name == null)
		{
			// 解析失败不写缓存，下一帧会重试
			LogNameDiag(key, battleInfoId, offCandidates, gtExecuted, gtCandidates, gtError);
			return "";
		}

		if (name.Length > 0)
			Log.Debug($"[ShowPlayerInfo] 名字解析成功 ID={battleInfoId} stage={stage} name={name}");
		else
			Log.Debug($"[ShowPlayerInfo] 该单位数据无名字(游戏同样不显示) ID={battleInfoId} stage={stage}");
		lock (ResolvedNameCache)
		{
			ResolvedNameCache[battleInfoId] = name;
		}
		return name;
	}

	/// <summary>
	/// 用游戏自带路径解析名字，返回已去富文本标签的中文名；查不到返回 null。
	/// 每条路径的原始结果写入 candidates，供诊断日志使用
	/// </summary>
	private static string ResolveOnce(string key, string[] candidates, bool authoritative)
	{
		candidates[0] = SafeResolve(() => key.ToFText().ToString());   // 游戏血条同款路径
		string r = AcceptResult(candidates[0], key, authoritative);
		if (r != null) return r;

		candidates[1] = SafeResolve(() => FText.FromStringTable(LocalStringTable, key, EStringTableLoadingPolicy.FindOrLoad).ToString());   // 直查运行时本地表
		r = AcceptResult(candidates[1], key, authoritative);
		if (r != null) return r;

		return null;
	}

	/// <summary>
	/// 判断查表原始结果能否作为最终名字：排除 miss 哨兵、未解析 key、异常；
	/// 去富文本后非空即接受。authoritative=true（游戏线程）时，查到空串代表该单位
	/// 数据里本就无名字，作为最终结果接受（返回 ""），避免每帧重复跳游戏线程。
	/// 返回 null 表示未命中、应继续尝试其它路径/线程。
	/// </summary>
	private static string AcceptResult(string result, string key, bool authoritative)
	{
		if (result == null) return null;
		if (result == MissingEntry || result == key || LocalKeyRegex.IsMatch(result) || result.StartsWith("<EX:"))
			return null;
		string name = RichTagRegex.Replace(result, "");
		if (name.Length > 0) return name;
		return authoritative ? "" : null;
	}

	private static string SafeResolve(Func<string> f)
	{
		try { return f(); }
		catch (Exception ex) { return $"<EX:{ex.GetType().Name}>"; }
	}

	/// <summary>
	/// 所有解析路径均失败时写一次诊断日志（每个 ID 只写一次），
	/// 包含两个线程上每条查表路径的原始结果，便于一次定位环境原因
	/// </summary>
	private static void LogNameDiag(string key, int battleInfoId, string[] offCandidates,
		bool gtExecuted, string[] gtCandidates, string gtError)
	{
		lock (NameDiagLogged)
		{
			if (!NameDiagLogged.Add(battleInfoId)) return;
		}
		string gameThread = "unknown";
		try { gameThread = FThreading.IsInGameThread().ToString(); } catch { }
		string useLoc = "unknown";
		try
		{
			var f = typeof(GSLocalization).GetField("IsUseLocalization",
				System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
			useLoc = f?.GetValue(null)?.ToString() ?? "null";
		}
		catch { }
		Log.Error($"[ShowPlayerInfo] 名字解析失败 ID={battleInfoId} key={key} " +
			$"inGameThread={gameThread} thread={Thread.CurrentThread.ManagedThreadId} " +
			$"IsInit={GSLocalization.IsInit} IsUseLocalization={useLoc} " +
			$"off=[{offCandidates[0]}]|[{offCandidates[1]}] " +
			$"gtExecuted={gtExecuted} gtError={gtError ?? "none"} " +
			$"gt=[{gtCandidates?[0]}]|[{gtCandidates?[1]}]");
	}

	#region 自定义名字覆盖配置（unitNameOverride.json）

	/// <summary>
	/// 用户自定义单位名覆盖表（battleInfoId -> 显示名）。
	/// 从 CSharpLoader/Mods/MagicMod/unitNameOverride.json 读取，用于补全游戏配表中
	/// UnitName 为空的单位。JSON 格式: { "303001": "隼居士", "300801": "雪僵尸" }
	/// 修改后需重启游戏生效（与其它配置一致）
	/// </summary>
	private static Dictionary<int, string> _nameOverride;
	private static readonly object NameOverrideLock = new object();

	private static Dictionary<int, string> NameOverrideMap
	{
		get
		{
			if (_nameOverride != null) return _nameOverride;
			lock (NameOverrideLock)
			{
				if (_nameOverride == null) _nameOverride = LoadNameOverride();
			}
			return _nameOverride;
		}
	}

	private static string GetNameOverride(int battleInfoId)
	{
		return NameOverrideMap.TryGetValue(battleInfoId, out string n) ? n : null;
	}

	private static Dictionary<int, string> LoadNameOverride()
	{
		var dict = new Dictionary<int, string>();
		try
		{
			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
				Common.ModDir, "MagicMod", "unitNameOverride.json");
			if (!File.Exists(path))
			{
				Log.Info($"[ShowPlayerInfo] 未找到 unitNameOverride.json（可选配置），路径: {path}");
				return dict;
			}
			var raw = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(path));
			if (raw != null)
			{
				foreach (var kv in raw)
				{
					if (int.TryParse(kv.Key, out int id) && !string.IsNullOrEmpty(kv.Value))
						dict[id] = kv.Value;
				}
			}
			Log.Info($"[ShowPlayerInfo] unitNameOverride.json 加载成功，{dict.Count} 条自定义名字");
		}
		catch (Exception e)
		{
			Log.Error($"[ShowPlayerInfo] 读取 unitNameOverride.json 失败: {e.Message}");
		}
		return dict;
	}

	/// <summary>
	/// 已自动写入过 PathName 占位的 id（每次运行只写一次，避免重复 IO）
	/// </summary>
	private static readonly HashSet<int> AutoWrittenIds = new HashSet<int>();
	private static readonly object NameOverrideWriteLock = new object();

	/// <summary>
	/// 当单位 UnitName 为空且 unitNameOverride.json 无对应项时，把 battleInfoId -> 角色 PathName
	/// 写入配置文件作为占位，用户可据此判断真实名字后手动修改。
	/// 保留文件中已有条目；每个 id 每次运行最多写一次。
	/// </summary>
	private static void TryAutoRecordPathName(int battleInfoId, BGUCharacterCS character)
	{
		try
		{
			lock (AutoWrittenIds)
			{
				if (!AutoWrittenIds.Add(battleInfoId)) return;
			}
			// 已有自定义名字则不覆盖
			if (!string.IsNullOrEmpty(GetNameOverride(battleInfoId))) return;

			string pathName = "";
			try { pathName = character?.GetPathName() ?? ""; } catch { }
			if (string.IsNullOrEmpty(pathName)) return;

			string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
				Common.ModDir, "MagicMod", "unitNameOverride.json");

			lock (NameOverrideWriteLock)
			{
				// 读现有文件保留用户已有条目，合并后写回
				Dictionary<string, string> map = new Dictionary<string, string>();
				if (File.Exists(filePath))
				{
					var existing = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(filePath));
					if (existing != null) map = existing;
				}
				string idKey = battleInfoId.ToString();
				if (map.ContainsKey(idKey)) return; // 文件里已有（可能用户手填），不动
				map[idKey] = pathName;
				File.WriteAllText(filePath, JsonConvert.SerializeObject(map, Formatting.Indented));
			}
			Log.Info($"[ShowPlayerInfo] UnitName 为空，已写入 PathName 占位 ID={battleInfoId} path={pathName}");
		}
		catch (Exception e)
		{
			Log.Error($"[ShowPlayerInfo] 自动写入 unitNameOverride.json 失败 ID={battleInfoId}: {e.Message}");
		}
	}

	#endregion

	public static void StartUpdateTimer()
	{
		if (isTimerRunning) return;
		isTimerRunning = true;

		// 重新开面板时不复用旧的最近角色缓存
		ClearNearestActorCache();

		// 释放旧定时器
		updateTimer?.Dispose();

		// 先立即执行一次（同样走游戏线程投递，调用方不一定在游戏线程）
		var now = DateTime.Now;
		lastUpdateTime = now;
		PostRender();

		// 创建周期性定时器，每500ms自动触发。
		// 注意：RenderBasicInfo 会读写 UObject / Slate（UTextBlock.SetText、取属性、球形查询），
		// 绝不能在 Timer（线程池）线程里直接跑，这里只负责"投递"到游戏线程。
		updateTimer = new Timer(_ =>
		{
			var t = DateTime.Now;
			if ((t - lastUpdateTime).TotalSeconds < 0.5) return;
			lastUpdateTime = t;
			PostRender();
		}, null, 500, 500);
	}


	/// <summary>
	/// 投递一次渲染到游戏线程（异步，不阻塞调用线程）。
	/// RenderBasicInfo 内部会读写 UObject / Slate（UTextBlock.SetText、BGU 属性读取、球形查询），
	/// 跨线程调用会和游戏线程的 GC / Slate 抢锁，是本 Mod 卡死的主要来源，必须走游戏线程。
	/// </summary>
	private static void PostRender()
	{
		// 上一次投递还没执行完 → 跳过本次，避免回调堆积
		if (Interlocked.CompareExchange(ref _renderPending, 1, 0) != 0) return;
		try
		{
			FThreading.RunOnGameThreadAsync(RenderSafe);
		}
		catch (Exception ex)
		{
			Interlocked.Exchange(ref _renderPending, 0);
			Log.Error($"[ShowPlayerInfo] 投递渲染到游戏线程失败: {ex.Message}");
		}
	}

	private static void RenderSafe()
	{
		try
		{
			// 已停止（Mod 重载 / 关闭面板）就不再渲染
			if (!isTimerRunning || updateTimer == null) return;
			RenderBasicInfo();
		}
		catch (Exception ex)
		{
			Log.Error($"[ShowPlayerInfo] RenderBasicInfo error: {ex.Message}");
		}
		finally
		{
			Interlocked.Exchange(ref _renderPending, 0);
		}
	}

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


	/// <summary>
	/// 清除所有 UI 元素
	/// </summary>
	public static void ClearAllUI()
	{
		isTimerRunning = false;
		ClearNearestActorCache();
		if (updateTimer != null)
		{
			updateTimer?.Dispose();

		}
		updateTimer = null;
		var World = GetWorld();
		if (!IsValidUObject(World)) return;
		if (World != null && GSUI.UIMgr.FindUIPage(World, BattleMainConID) is UIBattleMainCon obj)
		{
			UCanvasPanel MainCon = obj.GetFieldOrProperty<UCanvasPanel>("MainCon");
			// var MainCon = (UCanvasPanel)obj.GetType().GetProperty("MainCon").GetValue(obj);
			if (!IsValidUObject(MainCon)) return;
			var children = MainCon.GetAllChildren();
			// BasicInfoVs.Count
			if (BasicInfoVs.Count > 0)
			{
				foreach (var item in BasicInfoVs)
				{
					if (IsValidUObject(item))
					{
						item.RemoveFromParent();
						MainCon.RemoveChild(item);
					}
				}
				BasicInfoVs.Clear();
			}

			if (children != null && children.Count > 0)
			{
				var textToRemove = new[] { "角色:" };
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
