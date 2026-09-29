using System.Reflection;
using b1;
using HarmonyLib;
using UnrealEngine.Runtime;

namespace MagicMod.Patches
{
    /// <summary>
    /// 对 <c>BUS_PlayerInputActionComp:TickInputForMoving</c> 加 Postfix：
    /// 傀儡附身状态下，读取玩家移动输入轴 MoveInputAxis，驱动 boss 傀儡按镜头相对方向移动。
    /// 参考 爬塔mod反编译/Wukong_Challenge/PlayerTransSystem.cs 的 hookTickInputForMoving。
    ///
    /// 由 <c>Program.Init</c> 中的 <c>new Harmony("magicmod.customtrans").PatchAll()</c> 应用；
    /// Postfix 运行在游戏线程，可直接调用 UE API。
    /// </summary>
    [HarmonyPatch]
    public class TickInputForMovingPatch
    {
        private static MethodBase TargetMethod()
        {
            // TickInputForMoving 是私有实例方法：private void TickInputForMoving(in FVector MoveInputAxis, float DeltaTime)
            return AccessTools.Method(typeof(BUS_PlayerInputActionComp), "TickInputForMoving");
        }

        private static void Postfix(in FVector MoveInputAxis, float DeltaTime)
        {
            // 傀儡附身（CustomTransSystem）已停用：不再驱动逐帧维护与移动（代码保留，仅停用调用）
            // if (!CustomTransSystem.IsActive) return;
            // CustomTransSystem.FrameTick(DeltaTime);
            // if (!CustomTransSystem.IsActive) return;
            // CustomTransSystem.DriveMove(MoveInputAxis, DeltaTime);
            return;
        }
    }
}
