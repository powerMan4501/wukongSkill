using System.Collections.Generic;
using BtlShare;

namespace b1;

public class BGU_AbnormalStateHanddler_Burn : BGU_AbnormalStateHandlerBase
{
	public override void HandlerInit(BGUCharacterCS _OwnerChr)
	{
		AbnormalType = EAbnormalStateType.Abnormal_Burn;
		AbnormalImmueSS = EBGUSimpleState.BurnImmue;
		DisableAutoRecoverSS = EBGUSimpleState.DisableAutoRecoverBurn;
		AttrFloatMap = new Dictionary<EAbnormalAttrFloatMap, EBGUAttrFloat>();
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAcc, EBGUAttrFloat.BurnAbnormalAcc);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAccMax, EBGUAttrFloat.BurnAbnormalAccMax);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAccMaxBase, EBGUAttrFloat.BurnAbnormalAccMaxBase);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAccMaxMul, EBGUAttrFloat.BurnAbnormalAccMaxMul);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalDef, EBGUAttrFloat.BurnDef);
	}
}
