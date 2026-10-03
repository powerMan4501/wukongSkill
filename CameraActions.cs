using System;
using System.Threading;
using System.Threading.Tasks;
using b1;
using CSharpModBase;
using Diana.Common;
using ResB1;

namespace ActionsMod
{
    /// <summary>
    /// 镜头调节（ActionType.SetCamera / ResetCamera）。
    ///
    /// 背景（为什么不是直接改配表）：
    /// 玩家镜头参数在 FUStPlayerCameraDesc（按 ResID + CamID 索引）里，由 BUS_PlayerCameraCompImpl
    /// 在「镜头 ID 变化」时读表写入 CameraState，之后每帧按 CameraState 驱动 SpringArm。
    /// 直接改 SpringArm.TargetArmLength 会在下一帧被镜头系统覆盖回去，所以这里走游戏自己的通道：
    ///   BUS_EventCollectionCS.Evt_SetPlayerCameraParam（改 PlayerCamera 那套：臂长/高度/FOV/俯仰）
    ///   Evt_SetStraightCameraParam / Evt_SetGiantCameraParam（改锁定镜头臂长）
    /// 也就是控制台 b.Camera.SetTableParam.* 走的同一条路。
    ///
    /// 两个必须处理的点：
    /// 1) 镜头 ID 一切换（走→跑→跳、进出锁定、换镜头组）就会重新读表，把我们的覆盖值冲掉。
    ///    所以覆盖期间用一个低频定时器（默认 100ms）持续重发，直到 Duration 到期或 ResetCamera。
    /// 2) 还原要还原成「表里的值」而不是 0：覆盖前按当前 CamID 取一次 FUStPlayerCameraDesc 存基线。
    ///
    /// 不依赖 Harmony（本机 EnableJit=0），全部走事件 + Timer。
    /// </summary>
    internal static class CameraActions
    {
        private const int DefaultTickMs = 100;
        private const int MinTickMs = 16;
        private const int MaxTickMs = 1000;

        /// <summary>表缺失时的兜底基线（悟空默认镜头的常见量级），避免还原时把镜头压成 0</summary>
        private const float FallbackArmLength = 550f;
        private const float FallbackArmLengthSpeed = 3f;
        private const float FallbackFov = 80f;
        private const float FallbackPitchMin = -50f;
        private const float FallbackPitchMax = 45f;
        private const float FallbackMeshZOffsetLimit = 320f;

        private const int WukongResId = 10;

        /// <summary>一次覆盖要写进去的目标值（null = 不动这一项）</summary>
        private sealed class CamTarget
        {
            public float? ArmLength;
            public float? ArmLengthSpeed;
            public float? Height;
            public float? SocketOffsetZ;
            public float? Fov;
            public float? PitchMin;
            public float? PitchMax;
            public float? MeshZOffsetLimit;
            public float? StraightArmLength;
            public float? GiantArmLength;

            public bool IsEmpty =>
                !ArmLength.HasValue && !ArmLengthSpeed.HasValue && !Height.HasValue && !SocketOffsetZ.HasValue
                && !Fov.HasValue && !PitchMin.HasValue && !PitchMax.HasValue && !MeshZOffsetLimit.HasValue
                && !StraightArmLength.HasValue && !GiantArmLength.HasValue;
        }

        /// <summary>覆盖前的表内基线（用于还原）</summary>
        private sealed class CamBaseline
        {
            public float ArmLengthDefault = FallbackArmLength;
            public float ArmLengthSpeed = FallbackArmLengthSpeed;
            public float ArmLocationZ;
            public float ArmSocketOffsetZ;
            public float Fov = FallbackFov;
            public float PitchMin = FallbackPitchMin;
            public float PitchMax = FallbackPitchMax;
            public float MeshZOffsetLimit = FallbackMeshZOffsetLimit;
            public float? StraightArmLength;
            public float? GiantArmLength;
            public bool HasPlayerDesc;
        }

        private static readonly object _lock = new object();
        private static Timer? _keepTimer;
        private static CamTarget? _target;
        private static CamBaseline? _baseline;
        private static int _tickMs = DefaultTickMs;
        private static bool _active;
        private static bool _logged;

        // ============================== 对外入口 ==============================

        /// <summary>SetCamera：按动作参数覆盖镜头（Duration&gt;0 时到期自动还原）</summary>
        public static void SetCamera(BGUPlayerCharacterCS character, ActionConfig action)
        {
            int camId, groupId, lockCamId;
            CamBaseline baseline = BuildBaseline(character, out camId, out groupId, out lockCamId);
            int resId = character.GetResID();

            // Probe：只打印当前镜头组 / 镜头 ID / 表内数值，方便对着调参
            if (ReadBool(action, "Probe"))
            {
                Log.Info($"[ActionsMod] 镜头探测：ResID={resId} 镜头组={groupId} 当前镜头ID={camId} 锁定镜头ID={lockCamId}"
                    + $"\n  表内基线 ArmLengthDefault={baseline.ArmLengthDefault} ArmRelativeLocationZ={baseline.ArmLocationZ}"
                    + $" ArmSocketOffsetZ={baseline.ArmSocketOffsetZ} FOV={baseline.Fov}"
                    + $" Pitch=[{baseline.PitchMin},{baseline.PitchMax}] ArmLengthSpeed={baseline.ArmLengthSpeed}"
                    + $" MeshZOffsetLimit={baseline.MeshZOffsetLimit}"
                    + $" 锁定臂长={Fmt(baseline.StraightArmLength)} 大体型臂长={Fmt(baseline.GiantArmLength)}"
                    + (baseline.HasPlayerDesc ? "" : "\n  （当前 ResID+CamID 在 FUStPlayerCameraDesc 里没有条目，用的是兜底基线）"));
                if (!HasAnyParam(action)) return;
            }

            CamTarget target = BuildTarget(action, baseline);
            if (target.IsEmpty)
            {
                Log.Warn("[ActionsMod] SetCamera 没有任何有效参数（ArmLength/Height/Fov/... 至少给一个）");
                return;
            }

            int duration = action.Duration ?? 0;
            int tickMs = (int)ReadFloat(action, "TickMs", DefaultTickMs).GetValueOrDefault(DefaultTickMs);
            tickMs = Math.Max(MinTickMs, Math.Min(MaxTickMs, tickMs));

            lock (_lock)
            {
                _baseline = baseline;
                _target = target;
                _tickMs = tickMs;
                _active = true;
                _logged = false;
                StartTimerLocked();
            }

            ApplyOverride(character, target);
            LogCamera("SetCamera", character, target, duration, tickMs);

            if (duration > 0)
            {
                _ = Task.Run(async () =>
                {
                    await ActionExecutor.WaitForGameTime(duration / 1000f);
                    Utils.TryRunOnGameThread(() =>
                    {
                        var player = ModHelper.GetCharacter();
                        if (player != null) Restore(player);
                        else StopAll();
                    });
                });
            }
        }

        /// <summary>ResetCamera：立刻还原为表内值并停止维持</summary>
        public static void ResetCamera(BGUPlayerCharacterCS character, ActionConfig action)
        {
            Restore(character);
        }

        /// <summary>还原（供 ResetCamera / Duration 到期 / Mod 卸载调用）</summary>
        public static void Restore(BGUPlayerCharacterCS? character)
        {
            CamTarget? target;
            CamBaseline? baseline;
            lock (_lock)
            {
                _active = false;
                StopTimerLocked();
                target = _target;
                baseline = _baseline;
                _target = null;
                _baseline = null;
            }

            if (character == null || target == null || baseline == null) return;
            ApplyBaseline(character, target, baseline);
            Log.Info("[ActionsMod] ResetCamera：镜头已还原为表内值");
        }

        /// <summary>Mod 卸载时调用：只停定时器，不在卸载路径上再动游戏对象</summary>
        public static void Shutdown()
        {
            StopAll();
        }

        // ============================== 覆盖 / 还原 ==============================

        private static void ApplyOverride(BGUPlayerCharacterCS character, CamTarget t)
        {
            var evt = BUS_EventCollectionCS.Get(character);
            if (evt == null) return;

            if (t.ArmLength.HasValue) evt.Evt_SetPlayerCameraParam.Invoke(EPlayerCameraTableParamType.ArmLengthDefault, t.ArmLength.Value);
            if (t.ArmLengthSpeed.HasValue) evt.Evt_SetPlayerCameraParam.Invoke(EPlayerCameraTableParamType.ArmLengthSpeed, t.ArmLengthSpeed.Value);
            if (t.Height.HasValue) evt.Evt_SetPlayerCameraParam.Invoke(EPlayerCameraTableParamType.ArmRelativeLocationZ, t.Height.Value);
            if (t.SocketOffsetZ.HasValue) evt.Evt_SetPlayerCameraParam.Invoke(EPlayerCameraTableParamType.ArmSocketOffsetZ, t.SocketOffsetZ.Value);
            if (t.Fov.HasValue) evt.Evt_SetPlayerCameraParam.Invoke(EPlayerCameraTableParamType.Fov, t.Fov.Value);
            if (t.PitchMin.HasValue) evt.Evt_SetPlayerCameraParam.Invoke(EPlayerCameraTableParamType.PitchMin, t.PitchMin.Value);
            if (t.PitchMax.HasValue) evt.Evt_SetPlayerCameraParam.Invoke(EPlayerCameraTableParamType.PitchMax, t.PitchMax.Value);
            if (t.MeshZOffsetLimit.HasValue) evt.Evt_SetPlayerCameraParam.Invoke(EPlayerCameraTableParamType.MeshZOffsetLimit, t.MeshZOffsetLimit.Value);
            if (t.StraightArmLength.HasValue) evt.Evt_SetStraightCameraParam.Invoke(EStraightCameraTableParamType.ArmLength, t.StraightArmLength.Value);
            if (t.GiantArmLength.HasValue) evt.Evt_SetGiantCameraParam.Invoke(EGiantCameraTableParamType.ArmLength, t.GiantArmLength.Value);
        }

        /// <summary>只还原本次真正改过的项（用表内基线值写回）</summary>
        private static void ApplyBaseline(BGUPlayerCharacterCS character, CamTarget t, CamBaseline b)
        {
            var evt = BUS_EventCollectionCS.Get(character);
            if (evt == null) return;

            if (t.ArmLength.HasValue) evt.Evt_SetPlayerCameraParam.Invoke(EPlayerCameraTableParamType.ArmLengthDefault, b.ArmLengthDefault);
            if (t.ArmLengthSpeed.HasValue) evt.Evt_SetPlayerCameraParam.Invoke(EPlayerCameraTableParamType.ArmLengthSpeed, b.ArmLengthSpeed);
            if (t.Height.HasValue) evt.Evt_SetPlayerCameraParam.Invoke(EPlayerCameraTableParamType.ArmRelativeLocationZ, b.ArmLocationZ);
            if (t.SocketOffsetZ.HasValue) evt.Evt_SetPlayerCameraParam.Invoke(EPlayerCameraTableParamType.ArmSocketOffsetZ, b.ArmSocketOffsetZ);
            if (t.Fov.HasValue) evt.Evt_SetPlayerCameraParam.Invoke(EPlayerCameraTableParamType.Fov, b.Fov);
            if (t.PitchMin.HasValue) evt.Evt_SetPlayerCameraParam.Invoke(EPlayerCameraTableParamType.PitchMin, b.PitchMin);
            if (t.PitchMax.HasValue) evt.Evt_SetPlayerCameraParam.Invoke(EPlayerCameraTableParamType.PitchMax, b.PitchMax);
            if (t.MeshZOffsetLimit.HasValue) evt.Evt_SetPlayerCameraParam.Invoke(EPlayerCameraTableParamType.MeshZOffsetLimit, b.MeshZOffsetLimit);
            if (t.StraightArmLength.HasValue && b.StraightArmLength.HasValue)
                evt.Evt_SetStraightCameraParam.Invoke(EStraightCameraTableParamType.ArmLength, b.StraightArmLength.Value);
            if (t.GiantArmLength.HasValue && b.GiantArmLength.HasValue)
                evt.Evt_SetGiantCameraParam.Invoke(EGiantCameraTableParamType.ArmLength, b.GiantArmLength.Value);
        }

        // ============================== 目标 / 基线 ==============================

        private static CamTarget BuildTarget(ActionConfig action, CamBaseline b)
        {
            var t = new CamTarget();

            // 臂长：绝对值优先，其次是相对表内值的增量
            float? arm = ReadFloat(action, "ArmLength");
            float? armAdd = ReadFloat(action, "ArmLengthAdd");
            if (arm.HasValue) t.ArmLength = arm.Value;
            else if (armAdd.HasValue) t.ArmLength = b.ArmLengthDefault + armAdd.Value;

            // 挂点高度（ArmRelativeLocationZ）
            float? height = ReadFloat(action, "Height");
            float? heightAdd = ReadFloat(action, "HeightAdd");
            if (height.HasValue) t.Height = height.Value;
            else if (heightAdd.HasValue) t.Height = b.ArmLocationZ + heightAdd.Value;

            // 插槽偏移 Z（ArmSocketOffsetZ）
            float? socketZ = ReadFloat(action, "SocketOffsetZ");
            float? socketZAdd = ReadFloat(action, "SocketOffsetZAdd");
            if (socketZ.HasValue) t.SocketOffsetZ = socketZ.Value;
            else if (socketZAdd.HasValue) t.SocketOffsetZ = b.ArmSocketOffsetZ + socketZAdd.Value;

            t.ArmLengthSpeed = ReadFloat(action, "LerpSpeed");
            t.Fov = ReadFloat(action, "Fov");
            t.PitchMin = ReadFloat(action, "PitchMin");
            t.PitchMax = ReadFloat(action, "PitchMax");
            t.MeshZOffsetLimit = ReadFloat(action, "MeshZOffsetLimit");
            t.StraightArmLength = ReadFloat(action, "StraightArmLength");
            t.GiantArmLength = ReadFloat(action, "GiantArmLength");
            return t;
        }

        /// <summary>
        /// 取当前镜头 ID（自由 / 锁定 / 镜头组），并按「配表值」构建还原基线。
        /// 用 var 接 BGW_GameDB 的返回值——这几个 Desc 类型在 ProtobufDB 程序集里，本工程不直接引用其类型名。
        /// </summary>
        private static CamBaseline BuildBaseline(BGUPlayerCharacterCS character, out int camId, out int groupId, out int lockCamId)
        {
            camId = 0;
            groupId = -1;
            lockCamId = 0;

            var camData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PlayerCameraData, BUC_PlayerCameraData>(character);
            if (camData != null)
            {
                camId = camData.GetCurrentFreeCameraID();
                groupId = camData.GetCurrentCameraGroupID();
                lockCamId = camData.GetCurrentLockCameraID();
            }

            int resId = character.GetResID();
            var desc = BGW_GameDB.GetPlayerCameraDesc(resId, camId);
            if (desc == null && resId != WukongResId)
            {
                desc = BGW_GameDB.GetPlayerCameraDesc(WukongResId, camId);
            }

            var b = new CamBaseline();
            if (desc != null)
            {
                b.HasPlayerDesc = true;
                b.ArmLengthDefault = desc.ArmLengthDefault;
                b.ArmLengthSpeed = desc.ArmLengthSpeed;
                b.ArmLocationZ = desc.ArmRelativeLocationZ;
                b.ArmSocketOffsetZ = desc.ArmSocketOffsetZ;
                b.Fov = desc.FOV;
                b.PitchMin = desc.MinPitch;
                b.PitchMax = desc.MaxPitch;
                b.MeshZOffsetLimit = desc.MeshZOffsetLimit;
            }
            else
            {
                Log.Warn($"[ActionsMod] SetCamera：当前 ResID={character.GetResID()} + CamID 在 FUStPlayerCameraDesc 里没有条目，"
                    + "还原时使用兜底值（想精确还原请确认该形态是否有镜头表）");
            }

            var straight = BGW_GameDB.GetStraightCamDescDesc(lockCamId, resId)
                           ?? BGW_GameDB.GetStraightCamDescDesc(lockCamId, WukongResId);
            if (straight != null) b.StraightArmLength = straight.ArmLengthDefault;

            var giant = BGW_GameDB.GetGiantCamDescDesc(lockCamId, resId)
                        ?? BGW_GameDB.GetGiantCamDescDesc(lockCamId, WukongResId);
            if (giant != null) b.GiantArmLength = giant.ArmLength;

            return b;
        }

        // ============================== 维持定时器 ==============================

        /// <summary>
        /// 持续重发覆盖值：镜头 ID 一切换（走/跑/跳/锁定/换组）镜头系统就会重新读表，
        /// 不重发的话覆盖值会被冲掉。
        /// </summary>
        private static void StartTimerLocked()
        {
            StopTimerLocked();
            _keepTimer = new Timer(_ => Utils.TryRunOnGameThread(TickApply), null, _tickMs, _tickMs);
        }

        private static void StopTimerLocked()
        {
            _keepTimer?.Dispose();
            _keepTimer = null;
        }

        private static void TickApply()
        {
            if (!_active) return;
            CamTarget? target;
            lock (_lock)
            {
                target = _target;
            }
            if (target == null) return;

            var player = ModHelper.GetCharacter();
            if (player == null)
            {
                StopAll();
                return;
            }
            ApplyOverride(player, target);
            if (!_logged)
            {
                _logged = true;
                if (ModLog.Verbose) Log.Info($"[ActionsMod] 镜头覆盖维持中（每 {_tickMs}ms 重发，防止切镜头被表值冲掉）");
            }
        }

        private static void StopAll()
        {
            lock (_lock)
            {
                _active = false;
                _target = null;
                _baseline = null;
                StopTimerLocked();
            }
        }

        // ============================== 参数与日志 ==============================

        private static void LogCamera(string tag, BGUPlayerCharacterCS character, CamTarget t, int duration, int tickMs)
        {
            Log.Info($"[ActionsMod] {tag}"
                + $" 臂长={Fmt(t.ArmLength)} 高度={Fmt(t.Height)} 插槽Z={Fmt(t.SocketOffsetZ)}"
                + $" FOV={Fmt(t.Fov)} 俯仰=[{Fmt(t.PitchMin)},{Fmt(t.PitchMax)}]"
                + $" 插值速度={Fmt(t.ArmLengthSpeed)} 锁定臂长={Fmt(t.StraightArmLength)} 大体型臂长={Fmt(t.GiantArmLength)}"
                + $" （{(duration > 0 ? $"{duration}ms 后自动还原" : "常驻直到 ResetCamera/下次 SetCamera")}，维持间隔 {tickMs}ms）");
        }

        private static string Fmt(float? v) => v.HasValue ? v.Value.ToString("0.##") : "-";

        private static bool HasAnyParam(ActionConfig action)
        {
            string[] keys =
            {
                "ArmLength", "ArmLengthAdd", "Height", "HeightAdd", "SocketOffsetZ", "SocketOffsetZAdd",
                "LerpSpeed", "Fov", "PitchMin", "PitchMax", "MeshZOffsetLimit",
                "StraightArmLength", "GiantArmLength"
            };
            foreach (var k in keys)
            {
                if (ReadFloat(action, k).HasValue) return true;
            }
            return false;
        }

        private static float? ReadFloat(ActionConfig action, string key, float? fallback = null)
        {
            if (action.Params != null && action.Params.TryGetValue(key, out var v) && v != null)
            {
                if (float.TryParse(v.ToString(), out float f)) return f;
            }
            return fallback;
        }

        private static bool ReadBool(ActionConfig action, string key)
        {
            if (action.Params != null && action.Params.TryGetValue(key, out var v) && v != null)
            {
                string s = v.ToString() ?? "";
                return s.Equals("true", StringComparison.OrdinalIgnoreCase) || s == "1";
            }
            return false;
        }
    }
}
