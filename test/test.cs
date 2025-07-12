wukong.SummonManagerData = RequireReadOnlyGameStateData<IBGC_SummonData, BGC_SummonData>();

wukong.SummonManagerData.GetSummonInstancesBySummoner(wukong.GuidData.GetFinalGuid(), out var OutSummonInstances);

foreach (FSummonInstance item in OutSummonInstances)
{
    //if (num >= TargetPosition.Count)
    //{
    //    break;
    //}

    //if (lockTargetActor != null)
    //{
    //    rotation.Yaw = (fVector - fVector2).Rotation().Yaw;
    //}
    // rotation.Yaw = (fVector - fVector2).Rotation().Yaw;
    Console.WriteLine("<============================>2");
    foreach (FServantInstanceBase servantInstance in item.ServantInstances)
    {
        //servantInstance.CastCopySkill(uAnimMontage, new FTransform(rotation, fVector2));
        //servantInstance.CastCopySkill(uAnimMontage, fVector3);
        //servantInstance.CatSkill(skillInstsData.CurrentCastingSkillID);
        //BGUFunctionLibraryCS.BGUTryCastSpellWithStartSection(m, wukong.skillInstsData.CurrentCastingSkillID, FName.None);
        AActor m = servantInstance.GetMonsterActor();
        //BUTamerActor mm =m as BUTamerActor;
        BGUFuncLibActorTransformCS.BGUSetActorRotation(m, rotation, true, true);
        //BGUPlayerCharacterCS bGUPlayerCharacterCS = Owner as BGUPlayerCharacterCS;
        //bGUPlayerCharacterCS.CameraBoom1.DetachFromComponent(EDetachmentRule.KeepWorld);
        //bGUPlayerCharacterCS.CameraBoom1.AttachToComponent(mm.GetMonster().Mesh, new FName("dasheng"), EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: true);

        sp.X = fVector2.X + fVector1.X * -200;
        sp.Y = fVector2.Y + fVector1.Y * 200;
        sp.Z = fVector2.Z - 100f;
        m.Teleport(sp, rotation);
        m.SetActorScale3D(new FVector(0.3, 0.3, 0.3));
        BGUFunctionLibraryCS.BGUSetBehaviorTree(m, null);

        if (700102 <= skillID && skillID <= 700106)
        {

            //if (skillID == 700102)
            //{
            //    servantInstance.CastCopySkill(uAnimMontage, fVector3); return;
            //}

            BGUFunctionLibraryCS.BGUTryCastSpellWithStartSection(m, skillID, FName.None);
            //servantInstance.AddLifeTime(1000);

        }
        else
        {

            // BGUFunctionLibraryCS.BGUTryCastSpellWithStartSection(m, skillID, FName.None);



        }

        // AActor m = servantInstance.GetMonsterActor(); 这个就是获取召唤的aactor

        //  m.GetFullName(); 区分召唤的是哪一个boss
    }
}