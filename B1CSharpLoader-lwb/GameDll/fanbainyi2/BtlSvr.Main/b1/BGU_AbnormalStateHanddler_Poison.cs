using System.Collections.Generic;
using BtlShare;

namespace b1;

public class BGU_AbnormalStateHanddler_Poison : BGU_AbnormalStateHandlerBase
{
	public override void HandlerInit(BGUCharacterCS _OwnerChr)
	{
		AbnormalType = EAbnormalStateType.Abnormal_Poison;
		AbnormalImmueSS = EBGUSimpleState.PoisonImmue;
		DisableAutoRecoverSS = EBGUSimpleState.DisableAutoRecoverPoison;
		AttrFloatMap = new Dictionary<EAbnormalAttrFloatMap, EBGUAttrFloat>();
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAcc, EBGUAttrFloat.PoisonAbnormalAcc);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAccMax, EBGUAttrFloat.PoisonAbnormalAccMax);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAccMaxBase, EBGUAttrFloat.PoisonAbnormalAccMaxBase);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAccMaxMul, EBGUAttrFloat.PoisonAbnormalAccMaxMul);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalDef, EBGUAttrFloat.PoisonDef);
	}
}
