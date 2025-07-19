public static void OnGSTryCastSkill(string unitGuid, int skillID)
{
    try
    {

        UObject @this = MyUtils.GetWorld();
        IBGC_TamerData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_TamerData, BGC_TamerData>(@this);
        if (gameStateReadonlyData == null)
        {
            return;
        }
        gameStateReadonlyData.GetSpawnedMonsterList(out var OutMonsterList);
        AActor play = MyUtils.GetControlledPawn();
        FVector actorLocation = play.GetActorLocation();
        actorLocation.Z += 20;
        FRotator fRotator2 = play.GetActorRotation();
        foreach (string item in OutMonsterList)
        {
            // BGUFunctionLibraryCS.BGUSetUnitSimpleState(BGU_DataUtil.GetActorByGuid(@this, item), EBGUSimpleState.ImmueDamage, IsRemove: false);
            //AActor actorByGuid1 = BGU_DataUtil.GetActorByGuid(@this, item);


            //actorByGuid1.Teleport(actorLocation + play.GetActorForwardVector() * 50, fRotator2);

            Console.WriteLine(item);
        }

    }
    catch
    {

    }




}