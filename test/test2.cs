[HarmonyPatch(typeof(BUS_GSEventCollection), "Evt_CastSkillWithAnimMontageMultiCast_Implementation")]
[HarmonyPrefix]
private static bool CastSkill(BUS_GSEventCollection __instance, ref UAnimMontage Montage, ref float PlayTimeRate, ref float MontagePosOffset, FName StartSectionName)
{


    //return true;
    MontagePosOffset = 0.5f * Montage.SequenceLength; // d动画开始位置
    Montage.SequenceLength = Montage.SequenceLength * 0.9f; //动画结束位置
    PlayTimeRate = 1.0f; //动画播放速率

    //  Console.WriteLine($"{Montage.GetPlayLength()}-{PlayTimeRate}-{MontagePosOffset}");
    //string str = Montage.GetFullName();
    //if (!strings.Contains(str))
    //{
    //    strings.Add(str);
    //    Montage.SequenceLength = Montage.SequenceLength;
    //    return true;
    //}


    // Montage.GetAnimPoseAtTime();


    //return HookActions(ref Montage, ref PlayTimeRate, MontagePosOffset, StartSectionName, __instance);
    return true;
}