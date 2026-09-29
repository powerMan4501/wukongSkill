#nullable disable
using System;
using System.Collections.Generic;
using b1;
using b1.EventDelDefine;
using CSharpModBase;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace MagicMod
{
    /// <summary>
    /// 把一套"表现"（DBC / Niagara / 材质曲线）绑到动画上：
    /// 动画开始播 → 亮起，动画结束 / 被打断 → 熄灭。
    ///
    /// 典型用途：把棍光接到【蓄力】上。蓄力循环动画是
    ///   /Game/00Main/Animation/Player/Wukong/AM/Attack/Xuli/AM_Wukong_xuli_loop
    ///   AM_Wukong_xuli_B_loop_0 / AM_wukong_qiang_xuli_b_loop_0（立棍 / 戳棍 系）
    /// 所以 path 填关键字 "xuli" 就能三系通吃。
    ///
    /// 走的是 BUS_EventCollectionCS.Evt_PlayMontageCallback（和 StaffTrailHelper 同一套回调）。
    ///
    /// ===== JSON 用法 =====
    ///   { "Type": "BindMontageFX",
    ///     "path": "xuli",                                  // 动画路径关键字（小写匹配）
    ///     "FXList": [ { "path": "BGWDataAsset_B1DBC'/Game/.../DBC_XuLi_Baofa_2.DBC_XuLi_Baofa_2'" } ],
    ///     "MatSetting": [ "BGWDataAsset_BuffSetCurveValueToMeshConfig'/Game/.../DA_Xxx.DA_Xxx'" ] }
    ///
    ///   { "Type": "BindMontageFXStop" }                    // 解绑并熄灭
    /// </summary>
    public static class MontageFxBinder
    {
        private class Binding
        {
            public string Keyword = "";
            public BuffDispLiteConfig Cfg;
        }

        private static readonly List<Binding> _bindings = new List<Binding>();
        private static readonly object _lock = new object();
        private static BGUCharacterCS _boundCharacter;
        private static Del_PlayMontageCallback _handler;

        /// <summary>绑定：动画路径含 keyword（小写）时自动播/停 cfg。</summary>
        public static void Bind(BGUCharacterCS chr, string keyword, BuffDispLiteConfig cfg)
        {
            if (chr == null || chr.IsNullOrDestroyed() || cfg == null) return;
            keyword = (keyword ?? "").ToLowerInvariant();
            if (string.IsNullOrEmpty(keyword)) keyword = "xuli";

            lock (_lock)
            {
                // 受控角色变了（换关 / 变身 / 重载）→ 重新订阅到新角色，否则旧角色销毁后永远收不到回调
                if (_boundCharacter != null &&
                    (_boundCharacter.IsNullOrDestroyed() || !ReferenceEquals(_boundCharacter, chr)))
                {
                    UnbindAll();
                }

                if (_boundCharacter == null)
                {
                    _boundCharacter = chr;
                    _handler = new Del_PlayMontageCallback(OnMontageCallback);
                    BUS_EventCollectionCS.Get(chr).Evt_PlayMontageCallback += _handler;
                }

                // 同一 keyword 去重：之前每次绑定都无脑 Add，按 N 次键就有 N 条，
                // 动画一开始会连播 N 遍 DBC / 材质曲线（"越叠越亮"），列表还无限增长
                _bindings.RemoveAll(b => b != null && b.Keyword == keyword);
                _bindings.Add(new Binding { Keyword = keyword, Cfg = cfg });
            }
            Log.Info($"[MontageFX] 已绑定：动画含 '{keyword}' → DBC×{cfg.EnterFX.Count} 材质曲线×{cfg.MaterialSetting.Count}");
        }

        /// <summary>解绑全部并熄灭。</summary>
        public static void UnbindAll()
        {
            lock (_lock)
            {
                if (_boundCharacter != null && _handler != null)
                {
                    try { BUS_EventCollectionCS.Get(_boundCharacter).Evt_PlayMontageCallback -= _handler; }
                    catch { }
                    try { BuffDispLite.Stop(_boundCharacter); } catch { }
                }
                _bindings.Clear();
                _boundCharacter = null;
                _handler = null;
            }
            Log.Info("[MontageFX] 已解绑全部");
        }

        private static void OnMontageCallback(EMontageBindReason reason, UAnimMontage montage, EMontageCallbackState state)
        {
            if (montage == null || montage.IsNullOrDestroyed()) return;
            string path = (montage.PathName ?? "").ToLowerInvariant();
            if (string.IsNullOrEmpty(path)) return;

            bool started = state == EMontageCallbackState.OnStarted;
            bool ended = state == EMontageCallbackState.OnCompleted
                      || state == EMontageCallbackState.OnInterrupted
                      || state == EMontageCallbackState.OnPlayFailed;
            if (!started && !ended) return;

            List<Binding> snapshot;
            lock (_lock)
            {
                if (_bindings.Count == 0) return;
                snapshot = new List<Binding>(_bindings);
            }

            foreach (var b in snapshot)
            {
                if (path.IndexOf(b.Keyword, StringComparison.OrdinalIgnoreCase) < 0) continue;
                if (started)
                {
                    Log.Info($"[MontageFX] 动画开始 '{montage.PathName}' → 亮起");
                    BuffDispLite.Play(_boundCharacter, b.Cfg);
                }
                else if (ended)
                {
                    Log.Info($"[MontageFX] 动画结束 '{montage.PathName}' → 熄灭");
                    BuffDispLite.Stop(_boundCharacter);
                }
            }
        }
    }
}
