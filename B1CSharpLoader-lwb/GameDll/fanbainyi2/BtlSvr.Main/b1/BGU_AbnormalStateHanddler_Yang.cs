using System.Collections.Generic;
using BtlShare;

namespace b1;

public class BGU_AbnormalStateHanddler_Yang : BGU_AbnormalStateHandlerBase
{
	public override void HandlerInit(BGUCharacterCS _OwnerChr)
	{
		AbnormalType = EAbnormalStateType.Abnormal_Yang;
		AbnormalImmueSS = EBGUSimpleState.YangImmue;
		DisableAutoRecoverSS = EBGUSimpleState.DisableAutoRecoverYang;
		AttrFloatMap = new Dictionary<EAbnormalAttrFloatMap, EBGUAttrFloat>
		{
			{
				EAbnormalAttrFloatMap.AbnormalAcc,
				EBGUAttrFloat.YangAbnormalAcc
			},
			{
				EAbnormalAttrFloatMap.AbnormalAccMax,
				EBGUAttrFloat.YangAbnormalAccMax
			},
			{
				EAbnormalAttrFloatMap.AbnormalAccMaxBase,
				EBGUAttrFloat.YangAbnormalAccMaxBase
			},
			{
				EAbnormalAttrFloatMap.AbnormalAccMaxMul,
				EBGUAttrFloat.YangAbnormalAccMaxMul
			},
			{
				EAbnormalAttrFloatMap.AbnormalDef,
				EBGUAttrFloat.YangDef
			}
		};
		ProgressBuffID = AbnormalStateGlobleParam.AccProcessBuffID_Yang;
		AccTriggerProcessAbnormalPercent = AbnormalStateGlobleParam.AccTriggerProcessAbnormalPercent_Yang;
	}
}
