using UnrealEngine.Runtime;

namespace b1;

public class FSummonProcessor_Spawn : FSummonProcessorBase
{
	public override ESummonProcessorTag Tag => ESummonProcessorTag.Spawn;

	protected override ESummonProcessorTag GetNext(FSummonInstance InSummonInstance)
	{
		return ESummonProcessorTag.Finished;
	}

	protected override bool RunProcessor(FSummonInstance InSummonInstance)
	{
		for (int i = 0; i < InSummonInstance.ServantReqList.Count; i++)
		{
			FServantReq fServantReq = InSummonInstance.ServantReqList[i];
			string text = null;
			if (fServantReq.ServantType == EServantType.Dummy)
			{
				BGUCharacterCS bGUCharacterCS = fServantReq.DummyServantActor as BGUCharacterCS;
				if (bGUCharacterCS != null)
				{
					BGUFuncLibActorTransformCS.BGUSetActorLocationAndRotation(bGUCharacterCS, fServantReq.BornTransform.GetLocation(), fServantReq.BornTransform.GetRotation().Rotator(), bSweep: false, bTeleport: true);
					BGUFuncLibAnim.BGUActorTryPlayMontage(bGUCharacterCS, fServantReq.BornMontage, FName.None);
				}
			}
			else
			{
				text = BGU_UnrealWorldUtil.RequestSpawnServant(InSummonInstance.SystemContext.SystemOwner.World, fServantReq.TamerTemplate, in fServantReq.BornTransform, fServantReq, fServantReq.SafeClampToLand);
			}
			fServantReq.ServantTamerGuid = text;
			InSummonInstance.ServantReqList[i] = fServantReq;
			if (string.IsNullOrEmpty(text))
			{
				InSummonInstance.ServantReqList.RemoveAt(i--);
			}
		}
		return true;
	}
}
