using System.Collections.Generic;
using BtlShare;

namespace b1;

public class BGU_AbnormalStateHanddler_Yin : BGU_AbnormalStateHandlerBase
{
	public override void HandlerInit(BGUCharacterCS _OwnerChr)
	{
		AbnormalType = EAbnormalStateType.Abnormal_Yin;
		AbnormalImmueSS = EBGUSimpleState.YinImmue;
		DisableAutoRecoverSS = EBGUSimpleState.DisableAutoRecoverYin;
		AttrFloatMap = new Dictionary<EAbnormalAttrFloatMap, EBGUAttrFloat>();
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAcc, EBGUAttrFloat.YinAbnormalAcc);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAccMax, EBGUAttrFloat.YinAbnormalAccMax);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAccMaxBase, EBGUAttrFloat.YinAbnormalAccMaxBase);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAccMaxMul, EBGUAttrFloat.YinAbnormalAccMaxMul);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalDef, EBGUAttrFloat.YinDef);
		ProgressBuffID = AbnormalStateGlobleParam.AccProcessBuffID_Yin;
		AccTriggerProcessAbnormalPercent = AbnormalStateGlobleParam.AccTriggerProcessAbnormalPercent_Yin;
	}
}
