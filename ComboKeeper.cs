using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using b1;
using BtlB1;
using BtlShare;
using CSharpModBase;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace ActionsMod
{
    /// <summary>连招窗口字典里单个 GroupID 条目的值拷贝（断开对游戏对象的引用）</summary>
    public class ComboWindowEntry
    {
        public int GroupID;
        public int MontageInstanceID;
        public uint NotifyUniqueID;
        /// <summary>窗口剩余时间（秒）</summary>
        public float TotalTime;
        public List<int> BlackList = new List<int>();
        public List<int> WhiteList = new List<int>();
    }

    /// <summary>一次连招状态的完整快照</summary>
    public class ComboSnapshot
    {
        public List<ComboWindowEntry> Windows = new List<ComboWindowEntry>();
        public bool InComboWindow;
        public bool Attacking;

        // 连招图（CCG）三件套：决定"下一段接什么"，即玩家感知的连招段数
        public object? Graph;
        public object? Node;
        public object? Instance;

        public bool IsComboSubIdle;
        public int TryConsumeGroupID;

        public bool HasCombo => Windows.Count > 0 || Node != null;
    }

    /// <summary>
    /// 连招状态保存 / 恢复。
    ///
    /// 背景：释放自定义 Magic（幻化变身 MagicallyChange）时，游戏会走
    /// StopAllMontages → Evt_UnitTryBreakSkill → SkillBreak → SolveLeaveSkillMontage()，
    /// 一次性清掉 EBGUUnitState.Attacking 与 EBGUUnitState.InComboWindow；
    /// 下一帧 BUS_PlayerInputActionComp.OnTick 调 BUC_ComboWindowData.UpdateWindowInfo()，
    /// 因为 bInComboWindow=false 直接 AttackWindowInfoDict.Clear()，连招窗口就没了；
    /// 之后 DoAttackLogic() 里"CCG 不在 Idle 且不在 Attacking"又会 OnComboGraphReset() 把连招图打回起点，
    /// 表现为"放完 magic 连招断了，要重新从第一段起手"。
    ///
    /// 官方 magic 技能不断连招是因为它们没有走这条打断链。本类用"施放前存档 → 施放后回灌"来对齐官方表现：
    ///   1. 窗口：用公开事件 Evt_TriggerComboWindow 逐条重写 AttackWindowInfoDict + 重新开 InComboWindow
    ///      （该事件内部就是 SetAttackWindowInfo + Evt_UnitStateTrigger(EnterComboWindow)，一次搞定两件事）
    ///   2. 段数：把连招图的 CurrentGraph / CurrentNode / CurrentInstance 原样写回
    ///   3. 兜底：把 Attacking 拉住一小段时间，避免 DoAttackLogic 里的 CCG 重置兜底再把刚写回的节点清掉
    ///
    /// 说明：BUC_ComboWindowData / BUC_ComboCacheData 是 internal，只能反射访问；
    /// BUC_ComboGraphData 与 AttackWindowInfo 是 public，可直接读。
    /// </summary>
    public static class ComboKeeper
    {
        private static ComboSnapshot? _snapshot;

        // ---- 反射句柄缓存（首次使用时解析，失败只告警一次）----
        private static FieldInfo? _fComboWindowData;
        private static FieldInfo? _fComboCacheData;
        private static FieldInfo? _fComboGraphData;
        private static FieldInfo? _fAttackWindowDict;
        private static FieldInfo? _fIsComboSubIdle;
        private static FieldInfo? _fTryConsumeGroupID;
        private static PropertyInfo? _pCurrentGraph;
        private static PropertyInfo? _pCurrentNode;
        private static PropertyInfo? _pCurrentInstance;
        private static bool _reflectFailed;

        public static ComboSnapshot? Current => _snapshot;

        /// <summary>抓取当前连招状态。返回是否抓到了有效内容（不在连招里时为 false）</summary>
        public static bool Save(BGUCharacterCS character)
        {
            if (character == null || character.IsNullOrDestroyed())
            {
                Log.Warn("[ActionsMod] combo_save：角色无效");
                return false;
            }

            if (!EnsureReflection())
            {
                return false;
            }

            var comp = ModHelper.FindActorCompByClass<BUS_PlayerInputActionComp>(character);
            if (comp == null)
            {
                Log.Warn("[ActionsMod] combo_save：未找到 BUS_PlayerInputActionComp");
                return false;
            }

            var snap = new ComboSnapshot();

            // 1) 连招窗口字典
            object? cwd = _fComboWindowData?.GetValue(comp);
            if (cwd != null)
            {
                var dict = _fAttackWindowDict?.GetValue(cwd) as IDictionary;
                if (dict != null)
                {
                    foreach (DictionaryEntry e in dict)
                    {
                        if (e.Value is AttackWindowInfo info)
                        {
                            snap.Windows.Add(new ComboWindowEntry
                            {
                                GroupID = Convert.ToInt32(e.Key),
                                MontageInstanceID = info.MontageInstanceID,
                                NotifyUniqueID = info.NotifyUniqueID,
                                TotalTime = info.TotalTime,
                                BlackList = info.BlackListComboSkillIDList != null
                                    ? new List<int>(info.BlackListComboSkillIDList) : new List<int>(),
                                WhiteList = info.WhiteListComboSkillIDList != null
                                    ? new List<int>(info.WhiteListComboSkillIDList) : new List<int>()
                            });
                        }
                    }
                }
            }

            // 2) 连招图（段数）
            object? cgd = _fComboGraphData?.GetValue(comp);
            if (cgd != null)
            {
                snap.Graph = _pCurrentGraph?.GetValue(cgd);
                snap.Node = _pCurrentNode?.GetValue(cgd);
                snap.Instance = _pCurrentInstance?.GetValue(cgd);
            }

            // 3) 连招缓存
            object? ccd = _fComboCacheData?.GetValue(comp);
            if (ccd != null)
            {
                snap.IsComboSubIdle = _fIsComboSubIdle?.GetValue(ccd) is bool b && b;
                snap.TryConsumeGroupID = _fTryConsumeGroupID?.GetValue(ccd) is int g ? g : 0;
            }

            // 4) 相关 UnitState
            BUC_UnitStateData? usd = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(character);
            if (usd != null)
            {
                snap.InComboWindow = usd.HasState(EBGUUnitState.InComboWindow);
                snap.Attacking = usd.HasState(EBGUUnitState.Attacking);
            }

            _snapshot = snap;
            Log.Info($"[ActionsMod] combo_save：窗口 {snap.Windows.Count} 个，连招图节点 {(snap.Node != null ? "已记录" : "无")}，"
                     + $"InComboWindow={snap.InComboWindow}，Attacking={snap.Attacking}");
            return snap.HasCombo;
        }

        /// <summary>
        /// 回灌上一次保存的连招状态。
        /// holdAttackSec：把 Attacking 拉住的时长（秒），用于盖过 DoAttackLogic 的 CCG 重置兜底；
        /// <=0 表示不补 Attacking（此时若已不在 Attacking，连招图仍会被兜底重置）。
        /// </summary>
        public static bool Restore(BGUCharacterCS character, float holdAttackSec = 2.5f)
        {
            var snap = _snapshot;
            if (snap == null)
            {
                Log.Warn("[ActionsMod] combo_restore：没有可恢复的连招快照（先执行 combo_save）");
                return false;
            }
            if (character == null || character.IsNullOrDestroyed())
            {
                Log.Warn("[ActionsMod] combo_restore：角色无效");
                return false;
            }
            if (!EnsureReflection())
            {
                return false;
            }

            var evt = BUS_EventCollectionCS.Get(character);
            if (evt == null)
            {
                Log.Warn("[ActionsMod] combo_restore：获取事件集合失败");
                return false;
            }

            // 1) 逐条重建连招窗口（事件内部会写 AttackWindowInfoDict + 开 InComboWindow）
            foreach (var w in snap.Windows)
            {
                float dur = w.TotalTime > 0.05f ? w.TotalTime : 0.15f;
                evt.Evt_TriggerComboWindow.Invoke(w.MontageInstanceID, w.NotifyUniqueID, w.GroupID, w.BlackList, w.WhiteList, dur);
            }

            // 2) 还原连招图：段数接回原来那个节点
            var comp = ModHelper.FindActorCompByClass<BUS_PlayerInputActionComp>(character);
            if (comp != null)
            {
                object? cgd = _fComboGraphData?.GetValue(comp);
                if (cgd != null && snap.Node != null)
                {
                    _pCurrentGraph?.SetValue(cgd, snap.Graph);
                    _pCurrentNode?.SetValue(cgd, snap.Node);
                    _pCurrentInstance?.SetValue(cgd, snap.Instance);
                }

                object? ccd = _fComboCacheData?.GetValue(comp);
                if (ccd != null)
                {
                    _fIsComboSubIdle?.SetValue(ccd, snap.IsComboSubIdle);
                    _fTryConsumeGroupID?.SetValue(ccd, snap.TryConsumeGroupID);
                }
            }

            // 3) 补 Attacking：DoAttackLogic 里 "CCG 不在 Idle && !Attacking" 会触发 OnComboGraphReset，
            //    不拉住的话刚写回的节点下一帧又被打回起点
            if (holdAttackSec > 0f)
            {
                BUC_UnitStateData? usd = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(character);
                if (usd != null && !usd.HasState(EBGUUnitState.Attacking))
                {
                    evt.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackStateBegin, holdAttackSec);
                }
            }

            Log.Info($"[ActionsMod] combo_restore：已回灌窗口 {snap.Windows.Count} 个 / 连招图节点 {(snap.Node != null ? "已还原" : "无")}"
                     + (holdAttackSec > 0f ? $"，Attacking 保持 {holdAttackSec:0.##}s" : ""));
            return true;
        }

        /// <summary>丢弃快照（切换战斗/读档等场景用）</summary>
        public static void Clear()
        {
            _snapshot = null;
        }

        private static bool EnsureReflection()
        {
            if (_fComboWindowData != null && _fComboGraphData != null) return true;
            if (_reflectFailed) return false;

            try
            {
                const BindingFlags inst = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance;
                Type compType = typeof(BUS_PlayerInputActionComp);

                _fComboWindowData = compType.GetField("ComboWindowData", BindingFlags.NonPublic | BindingFlags.Instance);
                _fComboCacheData = compType.GetField("ComboCacheData", BindingFlags.NonPublic | BindingFlags.Instance);
                _fComboGraphData = compType.GetField("ComboGraphData", BindingFlags.NonPublic | BindingFlags.Instance);

                // BUC_ComboWindowData / BUC_ComboCacheData 是 internal，拿不到 typeof，改从字段类型反查
                _fAttackWindowDict = _fComboWindowData?.FieldType.GetField("AttackWindowInfoDict", inst);
                _fIsComboSubIdle = _fComboCacheData?.FieldType.GetField("IsComboSubIdle", inst);
                _fTryConsumeGroupID = _fComboCacheData?.FieldType.GetField("TryConsumeAttackKeyGroupID", inst);

                // BUC_ComboGraphData 是 public
                Type graphType = typeof(BUC_ComboGraphData);
                _pCurrentGraph = graphType.GetProperty("CurrentGraph", inst);
                _pCurrentNode = graphType.GetProperty("CurrentNode", inst);
                _pCurrentInstance = graphType.GetProperty("CurrentInstance", inst);

                if (_fComboWindowData == null || _fAttackWindowDict == null || _pCurrentNode == null)
                {
                    _reflectFailed = true;
                    Log.Error("[ActionsMod] combo_save/restore：反射解析连招数据失败（游戏版本可能已变更字段）");
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                _reflectFailed = true;
                Log.Error($"[ActionsMod] combo_save/restore：反射初始化异常 {e.Message}");
                return false;
            }
        }
    }
}
