using System.Reflection;
using b1;
using HarmonyLib;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace MagicMod.Patches
{
    /// <summary>
    /// 对 <c>FInputActionProcessor:InputActionTrigger</c> 加 Postfix：
    /// 傀儡附身状态下监听 IA_B1MoveForward / IA_B1MoveSideways 的 Completed（松开）事件，
    /// 调用 <see cref="CustomTransSystem.CancelMove"/> 取消 boss 当前的 AI 移动请求。
    /// 参考 爬塔mod反编译/Wukong_Challenge/PlayerTransSystem.cs 的 hookOnInputCastSkill。
    ///
    /// 由 <c>Program.Init</c> 中的 <c>new Harmony("magicmod.customtrans").PatchAll()</c> 应用；
    /// Postfix 运行在游戏线程，可直接调用 UE API。
    /// </summary>
    [HarmonyPatch]
    public class InputActionTriggerPatch
    {
        private static MethodBase TargetMethod()
        {
            // public void InputActionTrigger(string ActionName, ETriggerEvent TriggerEvent, EInputActionValueType InputActionValueType, FVector InputActionValue)
            return AccessTools.Method(typeof(FInputActionProcessor), "InputActionTrigger");
        }

        private static void Postfix(string ActionName, ETriggerEvent TriggerEvent)
        {
            // 傀儡附身（CustomTransSystem）已停用：不再取消 boss 的 AI 移动请求（代码保留，仅停用调用）
            // if (!CustomTransSystem.IsActive) return;
            // if (TriggerEvent != ETriggerEvent.Completed) return;
            // if (ActionName != "IA_B1MoveForward" && ActionName != "IA_B1MoveSideways") return;
            // CustomTransSystem.CancelMove();
            return;
        }
    }
}
