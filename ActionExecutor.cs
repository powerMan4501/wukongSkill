using System.Collections.Generic;
using System.Threading.Tasks;
using b1;
using CSharpModBase;

namespace PanelActionsMod
{
    /// <summary>
    /// 画板动作执行器：只实现画板用到的三类动作 ——
    /// AddItem（加物品/材料/丹药）、Trans（变身）、SpawnActor（召唤 Boss）。
    /// </summary>
    public static class ActionExecutor
    {
        /// <summary>执行一组动作（画板条目点击后调用）</summary>
        public static void DoActions(BGUPlayerCharacterCS? character, List<ActionConfig>? actions)
        {
            if (character == null || actions == null || actions.Count == 0) return;

            foreach (ActionConfig action in actions)
            {
                if (action == null) continue;

                int delay = action.Delay ?? 0;
                if (delay > 0)
                {
                    ActionConfig captured = action;
                    BGUPlayerCharacterCS? capturedChar = character;
                    _ = Task.Run(async () =>
                    {
                        await Task.Delay(delay);
                        Utils.TryRunOnGameThread(() => DoAction(capturedChar, captured));
                    });
                }
                else
                {
                    DoAction(character, action);
                }
            }
        }

        private static void DoAction(BGUPlayerCharacterCS? character, ActionConfig action)
        {
            if (character == null) return;

            switch (action.Type)
            {
                case ActionType.AddItem:
                {
                    int id = action.Value ?? 0;
                    if (id <= 0)
                    {
                        Log.Warn("[PanelActionsMod] AddItem 缺少物品 ID");
                        break;
                    }
                    int count = action.Count ?? 1;
                    if (count < 1) count = 1;
                    ModUtils.gain_item(id, count);
                    Log.Info($"[PanelActionsMod] 添加物品 ID={id} x{count}");
                    break;
                }

                case ActionType.AddItemRange:
                {
                    // Values = [起始ID, 结束ID]
                    if (action.Values == null || action.Values.Count < 2)
                    {
                        Log.Warn("[PanelActionsMod] AddItemRange 需要 Values=[起始ID, 结束ID]");
                        break;
                    }
                    int start = action.Values[0];
                    int end = action.Values[1];
                    if (end < start)
                    {
                        Log.Warn($"[PanelActionsMod] AddItemRange 区间无效: {start} ~ {end}");
                        break;
                    }
                    int count = action.Count ?? 1;
                    if (count < 1) count = 1;

                    List<int> ids = new List<int>();
                    for (int i = start; i <= end; i++) ids.Add(i);
                    int added = ModUtils.gain_items(ids, count);
                    Log.Info($"[PanelActionsMod] 批量添加物品 {start}~{end}，共 {added} 个 x{count}");
                    break;
                }

                case ActionType.Trans:
                {
                    int resId = action.Value ?? 0;
                    if (resId <= 0)
                    {
                        Log.Warn("[PanelActionsMod] Trans 缺少变身 ResID");
                        break;
                    }
                    ModUtils.doTrans(resId, 0);
                    Log.Info($"[PanelActionsMod] 变身 ResID={resId}");
                    break;
                }

                case ActionType.SpawnActor:
                {
                    if (string.IsNullOrEmpty(action.path))
                    {
                        Log.Warn("[PanelActionsMod] SpawnActor 缺少 path（资源路径）");
                        break;
                    }
                    bool isBoss = (action.Value ?? 0) > 0;
                    ModUtils.SpawnActor(action.path!, isBoss);
                    Log.Info($"[PanelActionsMod] 生成 {(isBoss ? "Boss" : "Actor")}: {action.path}");
                    if (isBoss)
                    {
                        // 召唤 Boss 后血条需等一拍才生成，调度两次「一次性」错开（非心跳/轮询）：
                        // 延迟 600ms 与 1600ms 各触发一次，覆盖不同血条生成时机。
                        ScheduleBossBarOffset(600);
                        ScheduleBossBarOffset(1600);
                    }
                    break;
                }

                case ActionType.BossBarOffset:
                {
                    int spacing = action.Value ?? BossBarOffsetAction.DefaultSpacing;
                    BossBarOffsetAction.Run(spacing);
                    break;
                }

                default:
                    Log.Warn($"[PanelActionsMod] 不支持的动作类型: {action.Type}");
                    break;
            }
        }

        /// <summary>
        /// 延迟 delayMs 后在游戏线程执行一次 Boss 血条错开（一次性，非持续轮询）。
        /// 用两次离散调度（见 SpawnActor 召唤 Boss 时）覆盖血条生成时机的不确定性。
        /// </summary>
        private static void ScheduleBossBarOffset(int delayMs)
        {
            _ = Task.Run(async () =>
            {
                await Task.Delay(delayMs);
                BossBarOffsetAction.Run();
            });
        }
    }
}
