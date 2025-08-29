using System;
using System.Reflection;
using b1;
using HarmonyLib;
using UnrealEngine.Runtime;

namespace bian;

[HarmonyPatch]
public class Hooks
{
    [HarmonyPatch]
    public class HookBGGGameStateCS
    {
        private static MethodBase TargetMethod()
        {
            return AccessTools.Method("b1.BGGGameStateCS:AfterInitAllComp", (Type[])null, (Type[])null);
        }

        [HarmonyPatch]
        private static void Prefix(ref BGGGameStateCS __instance)
        {
            if ((UObject)(object)__instance != null)
            {
                Manager.loadAllStaticData(false, 0);
            }
        }
    }

    // 新增的拦截器类
    [HarmonyPatch]
    public class HookBUS_PassiveSkillComp
    {
        private static MethodBase TargetMethod()
        {
            return AccessTools.Method("b1.BUS_PassiveSkillComp:OnAttach", (Type[])null, (Type[])null);
        }
        [HarmonyPrefix]
        private static void Prefix()
        {
            try
            {
                // 在 OnAttach 执行前加载和应用被动技能配置
                LoadUtils.LoadAndApplyPassiveSkills();
                LoadUtils.LoadAndApplyChargeSkill();
                LoadUtils.ModifyIronData();
                Console.WriteLine($"InitPassiveSkillMap.Prefix");
            }

            catch (Exception ex)
            {
                // 记录错误但不阻止原始方法执行
                Console.WriteLine($"Error in HookBUS_PassiveSkillComp.Prefix: {ex.Message}");
            }
        }
    }


    [HarmonyPatch]
    public class HookBUS_IronBodyComp
    {
        private static MethodBase TargetMethod()
        {
            return AccessTools.Method("b1.BUS_IronBodyComp:OnAttach", (Type[])null, (Type[])null);
        }

        [HarmonyPatch]
        private static void Prefix()
        {
            LoadUtils.ModifyIronData();
            LoadUtils.LoadAndApplyPassiveSkills();
            LoadUtils.LoadAndApplyChargeSkill();
            Console.WriteLine($"BUS_IronBodyComp.Prefix");
        }
    }
}
