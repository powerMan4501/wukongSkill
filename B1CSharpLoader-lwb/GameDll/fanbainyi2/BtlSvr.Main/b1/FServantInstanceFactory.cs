namespace b1;

public static class FServantInstanceFactory
{
	public static FServantInstanceBase Create(FServantReq InReq)
	{
		FServantInstanceBase fServantInstanceBase = null;
		switch (InReq.ServantType)
		{
		case EServantType.Normal:
		case EServantType.MonsterSpawn:
		case EServantType.NeutralAnimSpawn:
			fServantInstanceBase = new FNormalServantInstance(InReq);
			break;
		case EServantType.Clone:
			fServantInstanceBase = new FCloneServantInstance(InReq);
			break;
		case EServantType.PhantomRush:
			fServantInstanceBase = new FPhantomRushServantInstance(InReq);
			break;
		}
		if (fServantInstanceBase != null)
		{
			fServantInstanceBase.SummonInstanceID = InReq.SummonInstanceID;
		}
		return fServantInstanceBase;
	}
}
