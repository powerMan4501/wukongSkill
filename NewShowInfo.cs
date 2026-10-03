using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using b1;
using b1.Localization;
using B1UI.GSUI;
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
/// 玩家信息展示系统（事件驱动重构版）
///
/// 与原 showPlayerInfo.cs 的区别：
/// 1. 不再 500ms 全量轮询拉取属性；改为订阅玩家/目标的 BUC_AttrContainer.OnSetIdxValue
///    （即游戏内 BUI_EnemyBar / BUI_BossBar 用的同一套机制），属性变化只是置一个脏标记，
///    渲染只在"脏"时发生 —— 没有变化就完全不碰 UObject / Slate。
/// 2. 目标名字只在"目标切换"时解析一次（缓存到 _lastTargetName），不再每帧解析，
///    从而彻底去掉 FText.FromStringTable(key, FindOrLoad) 的同步资源加载（原卡死主因）。
/// 3. 去掉 FThreading.RunOnGameThread 同步阻塞调用；所有 UObject / Slate 访问都收敛到游戏线程的 RenderSafe。
/// </summary>
public class NewShowInfo
{
	// UI 元素
	public static List<UTextBlock> BasicInfoVs = new List<UTextBlock>();

	// 脏消费调度用的低频定时器（只负责"有变化时再渲染"，本身不拉数据）
	public static Timer? updateTimer;
	public static bool isTimerRunning = false;

	/// <summary>是否已有"已投递但还没在游戏线程执行完"的渲染任务（Interlocked 去重，防回调堆积）</summary>
	private static int _renderPending = 0;

	/// <summary>脏标记：self / target 属性是否有变化待刷新</summary>
	private static volatile bool _selfDirty = true;
	private static volatile bool _targetDirty = true;
	/// <summary>需要在游戏线程检测"目标是否切换"的请求（由低频 Timer 置位，RenderSafe 在游戏线程执行）</summary>
	private static volatile bool _needSwitchCheck = true;
	/// <summary>目标名字是否需要在下次渲染时重新解析（仅切换时为真）</summary>
	private static volatile bool _targetNameDirty = true;

	/// <summary>已订阅属性事件的单位（用于切换/变身时退订旧订阅，避免泄漏与野指针回调）</summary>
	private static BGUCharacterCS? _subscribedSelfActor;
	private static BGUCharacterCS? _subscribedTargetActor;

	/// <summary>属性变更回调（必须是稳定引用，才能正确退订）</summary>
	private static readonly Action<int, float, float> _onSelfAttrChanged = (_, _, _) => { _selfDirty = true; };
	private static readonly Action<int, float, float> _onTargetAttrChanged = (_, _, _) => { _targetDirty = true; };

	/// <summary>目标名字缓存：切换目标时才解析一次写入这里</summary>
	private static string _lastTargetName = "";

	// UI 配置常量
	private const float UI_OPACITY = 0.7f;
	private const float FONT_SIZE_NORMAL = 42f;
	private const float FONT_SIZE_BOLD = 40f;
	private const int PROBE_INTERVAL_MS = 150; // 仅做"脏检测 + 目标切换探测"，不拉属性
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
	private static UWorld? world;

	public static bool IsValidActor(AActor? actor)
	{
		return actor != null && actor.IsValidLowLevel() && !actor.IsPendingKill && !actor.IsActorBeingDestroyed();
	}

	public static bool IsValidUObject(UObject? uobj)
	{
		return uobj != null && uobj.IsValidLowLevel() && !uobj.IsPendingKill;
	}

	public static readonly FSlateFontInfo FontInfo = new FSlateFontInfo
	{
		FontObject = UObject.LoadObject<UFont>(null, "/Game/00MainHZ/UI/Fonts/B1Font_Main.B1Font_Main"),
		Size = (int)FONT_SIZE_NORMAL
	};

	public static readonly FSlateFontInfo BoldFontInfo = new FSlateFontInfo
	{
		FontObject = UObject.LoadObject<UFont>(null, "/Game/00MainHZ/UI/Fonts/B1Font_Main.B1Font_Main"),
		Size = (int)FONT_SIZE_BOLD
	};

	public static void SetUTextBlockContent(UTextBlock textBlock, string content)
	{
		if (IsValidUObject(textBlock))
		{
			textBlock.SetText(FText.FromString(content));
		}
	}

	/// <summary>仅在内容变化时更新文本块（避免无意义的 Slate 刷新）</summary>
	public static void UpdateUTextBlockContentIfChanged(UTextBlock textBlock, string newText)
	{
		if (!IsValidUObject(textBlock)) return;
		var currentText = textBlock.GetText().ToString();
		if (currentText != newText)
		{
			textBlock.SetText(FText.FromString(newText));
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
			if (!IsValidUObject(MainCon)) return false;
			var children = MainCon.GetAllChildren();
			if (children != null && children.Count > 0)
			{
				return children?.Any(child =>
					child is UTextBlock textBlock &&
					textBlock != null &&
					textBlock.GetText().Contains("角色:")) ?? false;
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
			if (!IsValidUObject(MainCon)) return null;
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
	/// 初始化 UI 元素（只负责往 BattleMainCon 上挂 TextBlock，不做属性订阅/轮询）
	/// </summary>
	public static void InitItems(bool force = false)
	{
		var bGUPlayerCharacterCS = GetBGUPlayerCharacterCS();
		if (bGUPlayerCharacterCS == null) return;

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
					BasicInfoVs[index] = valueBlock;
				else
					BasicInfoVs.Add(valueBlock);
			}
			SetUTextBlockFont(valueBlock, FontInfo);
			SetUTextBlockStyle(valueBlock, 0.6f, ETextJustify.Right);
			UpdateUTextBlockContentIfChanged(valueBlock, attribute.Value);
		}

		var World = GetWorld();
		if (!IsValidUObject(World)) return;
		if (GSUI.UIMgr.FindUIPage(World, BattleMainConID) is UIBattleMainCon obj)
		{
			var MainCon = obj.GetFieldOrProperty<UCanvasPanel>("MainCon");
			if (!IsValidUObject(MainCon)) return;
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
		}
	}

	#region 渲染（仅在游戏线程执行，且只在脏时真正读取属性）

	/// <summary>在游戏线程执行的真正渲染。只有脏标记为真才读属性，否则直接返回。</summary>
	private static void RenderSafe()
	{
		try
		{
			if (!isTimerRunning || updateTimer == null) return;

			// 确保 self 订阅正确（处理变身/切换 controlled pawn）
			var player = GetBGUPlayerCharacterCS();
			EnsureSelfSubscribed(player);

			// 在游戏线程安全地检测目标是否切换（切换时退订旧/订阅新，并标记名字待解析）
			DetectTargetSwitch(player);

			bool needRender = _selfDirty || _targetDirty;
			if (!needRender) return;

			var controlledPawn = GetControlledPawn();
			if (!IsValidActor(controlledPawn) || BasicInfoVs.Count == 0) return;

			if (_selfDirty)
			{
				RenderSelf(controlledPawn);
				_selfDirty = false;
			}
			if (_targetDirty)
			{
				RenderTarget(player);
				_targetDirty = false;
			}
		}
		catch (Exception ex)
		{
			Log.Error($"[NewShowInfo] Render error: {ex.Message}");
		}
		finally
		{
			Interlocked.Exchange(ref _renderPending, 0);
		}
	}

	private static void RenderSelf(APawn pawn)
	{
		int index = 0;
		foreach (var attribute in BasicAttributes)
		{
			if (index >= BasicInfoVs.Count) break;
			if (attribute.Key == "self")
			{
				var attrs = CachePlayerAttributes(pawn);
				var str = $"当前角色(作者：勇士):\n 护盾: {(int)attrs[EBGUAttrFloat.Shield]}, 攻击: {(int)attrs[EBGUAttrFloat.Atk]}, 减伤: {(int)(attrs[EBGUAttrFloat.DmgDef] / 100)}% \n" +
					$"暴击: {(int)(attrs[EBGUAttrFloat.CritRate] / 100)}%, 暴伤: {(int)(attrs[EBGUAttrFloat.CritMultiplier] / 100f + 130f)}%, 加伤: {(int)(attrs[EBGUAttrFloat.DmgAddition] / 100)}%, 霸体: {(int)attrs[EBGUAttrFloat.SkillSuperArmor]} \n" +
					$"生命：{(int)attrs[EBGUAttrFloat.Hp]},  法力：{(int)attrs[EBGUAttrFloat.Mp]}, 防御：{(int)attrs[EBGUAttrFloat.Def]} \n" +
					$"四灾抗性: 冰:{(int)attrs[EBGUAttrFloat.FreezeDef]}, 火:{(int)attrs[EBGUAttrFloat.BurnDef]},  毒:{(int)attrs[EBGUAttrFloat.PoisonDef]},  雷:{(int)attrs[EBGUAttrFloat.ThunderDef]} \n" +
					$"四灾攻击: 冰:{(int)attrs[EBGUAttrFloat.FreezeAtk]}, 火:{(int)attrs[EBGUAttrFloat.BurnAtk]},  毒:{(int)attrs[EBGUAttrFloat.PoisonAtk]},  雷:{(int)attrs[EBGUAttrFloat.ThunderAtk]} \n" +
					$"神力: {(int)attrs[EBGUAttrFloat.CurEnergy]},  法宝: {(int)attrs[EBGUAttrFloat.FabaoEnergy]},  精魄: {(int)attrs[EBGUAttrFloat.VigorEnergy]}, 掉宝: {Math.Min(100, (int)(attrs[EBGUAttrFloat.CommDropAddition] / 100))}% \n" +
					$"当前特效：{ActionExecutor.getCurrentElemtText()}， 棍势：{(int)attrs[EBGUAttrFloat.Pevalue]} \n";
				UpdateUTextBlockContentIfChanged(BasicInfoVs[index], str);
			}
			index++;
		}
	}

	private static void RenderTarget(BGUCharacterCS? player)
	{
		int index = BasicAttributes.Keys.ToList().IndexOf("target");
		if (index < 0 || index >= BasicInfoVs.Count) return;

		AActor? targetActor = (player != null) ? BGUFunctionLibraryCS.BGUGetTarget(player) : null;
		if (targetActor == null || !IsValidActor(targetActor))
		{
			_targetNameDirty = false;
			UpdateUTextBlockContentIfChanged(BasicInfoVs[index], "\n 目标角色: 无");
			return;
		}

		var target = targetActor as BGUCharacterCS;
		if (target == null)
		{
			_targetNameDirty = false;
			UpdateUTextBlockContentIfChanged(BasicInfoVs[index], "\n 目标角色: 无");
			return;
		}

		// 名字仅在"目标切换"时解析一次（见 DetectTargetSwitch：切换会置 _targetNameDirty）
		if (_targetNameDirty)
		{
			_lastTargetName = GetCharacterDisplayName(target);
			_targetNameDirty = false;
		}
		var targetName = _lastTargetName;

		var distance = (int)FVector.Distance(player!.GetActorLocation(), target.GetActorLocation());
		var text = $"\n 目标角色: {targetName}  距离：{distance}  \n";

		var targetAttrs = new Dictionary<EBGUAttrFloat, float>();
		var attrsToCache = new[] {
			EBGUAttrFloat.Hp, EBGUAttrFloat.Atk, EBGUAttrFloat.DmgDef, EBGUAttrFloat.DmgAddition,
			EBGUAttrFloat.FreezeDef, EBGUAttrFloat.BurnDef, EBGUAttrFloat.PoisonDef, EBGUAttrFloat.ThunderDef,
			EBGUAttrFloat.FreezeAtk, EBGUAttrFloat.BurnAtk, EBGUAttrFloat.PoisonAtk, EBGUAttrFloat.ThunderAtk
		};
		foreach (var attr in attrsToCache)
			targetAttrs[attr] = BGUFunctionLibraryCS.GetAttrValue(target, attr);

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

		try
		{
			var buffData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(target);
			if (buffData != null)
			{
				var buffLayer = buffData.GetBuffLayer(18400);
				if (buffLayer > 0)
					finaltxt += $"\n {buffLayer}层虫卵";
			}
		}
		catch { /* buff数据可能不可用，忽略 */ }

		UpdateUTextBlockContentIfChanged(BasicInfoVs[index], finaltxt);
	}

	/// <summary>缓存玩家属性值（仅 RenderSelf 调用，且只在 self 脏时）</summary>
	private static Dictionary<EBGUAttrFloat, float> CachePlayerAttributes(APawn pawn)
	{
		var cache = new Dictionary<EBGUAttrFloat, float>();
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
			cache[attr] = BGUFunctionLibraryCS.GetAttrValue(pawn, attr);
		return cache;
	}

	#endregion

	#region 属性事件订阅（事件驱动核心）

	private static void SubscribeAttr(BGUCharacterCS? unit, Action<int, float, float> handler)
	{
		if (!IsValidActor(unit)) return;
		try
		{
			BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(unit)?.BindOneValueChanged(handler);
		}
		catch (Exception ex)
		{
			Log.Error($"[NewShowInfo] 订阅属性事件失败: {ex.Message}");
		}
	}

	private static void UnsubscribeAttr(BGUCharacterCS? unit, Action<int, float, float> handler)
	{
		if (unit == null) return;
		try
		{
			BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(unit)?.UnBindOneValueChanged(handler);
		}
		catch { /* 单位可能已销毁，忽略 */ }
	}

	/// <summary>确保 self 订阅绑定到当前玩家（变身/切换时重新订阅）</summary>
	private static void EnsureSelfSubscribed(BGUCharacterCS? player)
	{
		if (player == _subscribedSelfActor) return;
		UnsubscribeAttr(_subscribedSelfActor, _onSelfAttrChanged);
		_subscribedSelfActor = player;
		SubscribeAttr(player, _onSelfAttrChanged);
		_selfDirty = true;
	}

	/// <summary>在游戏线程检测目标是否切换；切换则退订旧目标、订阅新目标，并标记名字待解析</summary>
	private static void DetectTargetSwitch(BGUCharacterCS? player)
	{
		_needSwitchCheck = false;
		if (player == null) return;

		var tgt = BGUFunctionLibraryCS.BGUGetTarget(player) as BGUCharacterCS;
		if (tgt == _subscribedTargetActor) return; // 无变化（含都为 null）

		// 退订旧目标
		UnsubscribeAttr(_subscribedTargetActor, _onTargetAttrChanged);
		_subscribedTargetActor = tgt;
		_targetNameDirty = true; // 切换目标 → 名字需要重新解析一次

		if (tgt != null && IsValidActor(tgt))
		{
			SubscribeAttr(tgt, _onTargetAttrChanged);
			_targetDirty = true;
		}
	}

	#endregion

	#region 目标名字解析（仅切换时调用一次）

	private static readonly Regex RichTagRegex = new Regex("<[^<>]+>|</>");
	private static readonly Regex LocalKeyRegex = new Regex(@"^UnitBattleInfoExtendDesc\.\d+\.UnitName(\.\w+)?$");
	private static readonly FName LocalStringTable = new FName("LocalRuntimeStringKVMapDesc");
	private const string MissingEntry = "<MISSING STRING TABLE ENTRY>";

	private static readonly Dictionary<int, string> _nameCache = new Dictionary<int, string>();
	private static readonly object NameCacheLock = new object();

	private static string GetCharacterDisplayName(BGUCharacterCS character)
	{
		try
		{
			if (character == null) return "";
			int battleInfoId = character.GetFinalBattleInfoExtendID();
			if (battleInfoId <= 0) return "";

			lock (NameCacheLock)
			{
				if (_nameCache.TryGetValue(battleInfoId, out var cached)) return cached;
			}

			FUStUnitBattleInfoExtendDesc desc = BGW_GameDB.GetUnitBattleInfoExtendDesc(battleInfoId);
			string name = (desc != null) ? ResolveUnitDisplayName(desc.UnitName, battleInfoId) : "";
			if (string.IsNullOrEmpty(name))
				TryAutoRecordPathName(battleInfoId, character);

			lock (NameCacheLock)
			{
				_nameCache[battleInfoId] = name;
			}
			return name;
		}
		catch
		{
			return "";
		}
	}

	/// <summary>
	/// 解析单位显示名（在游戏线程执行，仅目标切换时调用一次）。
	/// 去掉了原版的 RunOnGameThread 同步阻塞与每帧重复解析；FindOrLoad 仅作为兜底且只发生一次。
	/// </summary>
	private static string ResolveUnitDisplayName(string key, int battleInfoId)
	{
		string overrideName = GetNameOverride(battleInfoId);
		if (!string.IsNullOrEmpty(overrideName)) return overrideName;
		if (string.IsNullOrEmpty(key)) return "";
		if (!LocalKeyRegex.IsMatch(key)) return RichTagRegex.Replace(key, "");

		// 1) 游戏血条同款路径
		try
		{
			var s = key.ToFText().ToString();
			if (AcceptResult(s, key)) return RichTagRegex.Replace(s, "");
		}
		catch { }

		// 2) 直查运行时本地表（兜底，仅在切换时发生一次，风险可控）
		try
		{
			var s = FText.FromStringTable(LocalStringTable, key, EStringTableLoadingPolicy.FindOrLoad).ToString();
			if (AcceptResult(s, key)) return RichTagRegex.Replace(s, "");
		}
		catch { }

		return "";
	}

	private static bool AcceptResult(string? result, string key)
	{
		if (result == null) return false;
		if (result == MissingEntry || result == key || LocalKeyRegex.IsMatch(result) || result.StartsWith("<EX:"))
			return false;
		return RichTagRegex.Replace(result, "").Length > 0;
	}

	#endregion

	#region 自定义名字覆盖配置（unitNameOverride.json）

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

	private static string? GetNameOverride(int battleInfoId)
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
				Log.Info($"[NewShowInfo] 未找到 unitNameOverride.json（可选配置），路径: {path}");
				return dict;
			}
			var raw = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(path));
			if (raw != null)
			{
				foreach (var kv in raw)
					if (int.TryParse(kv.Key, out int id) && !string.IsNullOrEmpty(kv.Value))
						dict[id] = kv.Value;
			}
			Log.Info($"[NewShowInfo] unitNameOverride.json 加载成功，{dict.Count} 条自定义名字");
		}
		catch (Exception e)
		{
			Log.Error($"[NewShowInfo] 读取 unitNameOverride.json 失败: {e.Message}");
		}
		return dict;
	}

	private static readonly HashSet<int> AutoWrittenIds = new HashSet<int>();
	private static readonly object NameOverrideWriteLock = new object();

	private static void TryAutoRecordPathName(int battleInfoId, BGUCharacterCS character)
	{
		try
		{
			lock (AutoWrittenIds)
			{
				if (!AutoWrittenIds.Add(battleInfoId)) return;
			}
			if (!string.IsNullOrEmpty(GetNameOverride(battleInfoId))) return;

			string pathName = "";
			try { pathName = character?.GetPathName() ?? ""; } catch { }
			if (string.IsNullOrEmpty(pathName)) return;

			string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
				Common.ModDir, "MagicMod", "unitNameOverride.json");

			lock (NameOverrideWriteLock)
			{
				Dictionary<string, string> map = new Dictionary<string, string>();
				if (File.Exists(filePath))
				{
					var existing = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(filePath));
					if (existing != null) map = existing;
				}
				string idKey = battleInfoId.ToString();
				if (map.ContainsKey(idKey)) return;
				map[idKey] = pathName;
				File.WriteAllText(filePath, JsonConvert.SerializeObject(map, Formatting.Indented));
			}
			Log.Info($"[NewShowInfo] UnitName 为空，已写入 PathName 占位 ID={battleInfoId} path={pathName}");
		}
		catch (Exception e)
		{
			Log.Error($"[NewShowInfo] 自动写入 unitNameOverride.json 失败 ID={battleInfoId}: {e.Message}");
		}
	}

	#endregion

	#region 启动 / 停止

	public static void StartUpdateTimer()
	{
		if (isTimerRunning) return;
		isTimerRunning = true;

		// 重新开面板时重置订阅与脏标记
		_subscribedSelfActor = null;
		_subscribedTargetActor = null;
		_selfDirty = true;
		_targetDirty = true;
		_targetNameDirty = true;
		_needSwitchCheck = true;

		// 立即渲染首屏
		PostRender();

		updateTimer?.Dispose();
		// 低频调度器：仅做"脏检测 + 目标切换探测"，不拉属性。
		// 真正读属性发生在 RenderSafe 且只在脏时。
		updateTimer = new Timer(_ =>
		{
			if (!isTimerRunning) return;
			// 任何属性变化或需要检测切换 → 投递一次渲染（PostRender 内部会再判断脏，避免无谓入队）
			_needSwitchCheck = true;
			PostRender();
		}, null, PROBE_INTERVAL_MS, PROBE_INTERVAL_MS);
	}

	/// <summary>
	/// 投递一次渲染到游戏线程（异步）。RenderSafe 内部会判断脏，不脏直接返回，
	/// 因此没有属性变化时不产生任何 UObject / Slate 访问。
	/// </summary>
	private static void PostRender()
	{
		if (!_selfDirty && !_targetDirty && !_needSwitchCheck) return;
		if (Interlocked.CompareExchange(ref _renderPending, 1, 0) != 0) return;
		try
		{
			FThreading.RunOnGameThreadAsync(RenderSafe);
		}
		catch (Exception ex)
		{
			Interlocked.Exchange(ref _renderPending, 0);
			Log.Error($"[NewShowInfo] 投递渲染到游戏线程失败: {ex.Message}");
		}
	}

	#endregion

	public static APawn? GetControlledPawn()
	{
		UWorld uWorld = GetWorld();
		if (!IsValidUObject(uWorld)) return null;
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)uWorld);
		if (!IsValidActor(firstLocalPlayerController)) return null;
		return firstLocalPlayerController.GetControlledPawn();
	}

	public static BGUPlayerCharacterCS? GetBGUPlayerCharacterCS()
	{
		APawn controlledPawn = GetControlledPawn();
		if (!IsValidActor(controlledPawn)) return null;
		return controlledPawn as BGUPlayerCharacterCS;
	}

	/// <summary>
	/// 清除所有 UI 与订阅（关闭面板 / Mod 重载时务必调用，退订属性事件防止野指针回调）
	/// </summary>
	public static void ClearAllUI()
	{
		isTimerRunning = false;

		// 退订属性事件（关键：若不退订，单位属性变化时仍会回调到已卸载/无效的委托）
		UnsubscribeAttr(_subscribedSelfActor, _onSelfAttrChanged);
		UnsubscribeAttr(_subscribedTargetActor, _onTargetAttrChanged);
		_subscribedSelfActor = null;
		_subscribedTargetActor = null;

		_selfDirty = false;
		_targetDirty = false;
		_targetNameDirty = false;
		_needSwitchCheck = false;

		if (updateTimer != null)
		{
			updateTimer.Dispose();
		}
		updateTimer = null;

		var World = GetWorld();
		if (!IsValidUObject(World)) return;
		if (World != null && GSUI.UIMgr.FindUIPage(World, BattleMainConID) is UIBattleMainCon obj)
		{
			UCanvasPanel MainCon = obj.GetFieldOrProperty<UCanvasPanel>("MainCon");
			if (!IsValidUObject(MainCon)) return;

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

			var children = MainCon.GetAllChildren();
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

	~NewShowInfo()
	{
		ClearAllUI();
	}

	public void Dispose()
	{
		ClearAllUI();
		GC.SuppressFinalize(this);
	}
}
