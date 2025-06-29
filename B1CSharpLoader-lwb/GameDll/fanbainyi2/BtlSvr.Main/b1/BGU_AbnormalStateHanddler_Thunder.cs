using System.Collections.Generic;
using BtlShare;

namespace b1;

public class BGU_AbnormalStateHanddler_Thunder : BGU_AbnormalStateHandlerBase
{
	public override void HandlerInit(BGUCharacterCS _OwnerChr)
	{
		AbnormalType = EAbnormalStateType.Abnormal_Thunder;
		AbnormalImmueSS = EBGUSimpleState.ThunderImmue;
		DisableAutoRecoverSS = EBGUSimpleState.DisableAutoRecoverThunder;
		AttrFloatMap = new Dictionary<EAbnormalAttrFloatMap, EBGUAttrFloat>();
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAcc, EBGUAttrFloat.ThunderAbnormalAcc);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAccMax, EBGUAttrFloat.ThunderAbnormalAccMax);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAccMaxBase, EBGUAttrFloat.ThunderAbnormalAccMaxBase);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAccMaxMul, EBGUAttrFloat.ThunderAbnormalAccMaxMul);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalDef, EBGUAttrFloat.ThunderDef);
	}
}
