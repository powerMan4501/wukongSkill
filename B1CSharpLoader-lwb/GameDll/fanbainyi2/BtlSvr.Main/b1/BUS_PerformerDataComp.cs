using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_PerformerDataComp")]
internal class BUS_PerformerDataComp : BUS_BGUDataCompBase
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_GuidData>();
		CreateDataClass<BUC_ActorTransformInfoData>();
		CreateDataClass<BUC_AKMgrData>();
		CreateDataClass<BUC_PerformerEquipData>();
		CreateDataClass<BUC_CharacterModularData>();
		CreateDataClass<BUC_EquipData>();
		CreateDataClass<BUC_SeqPerformerConfigInfoData>();
		CreateDataClass<b1.BUC_InteractInfoCollectionData>();
		CreateDataClass<BUC_AiConversationData>();
		CreateDataClass<BUC_AiConversationBlackboard>();
		CreateDataClass<BUC_FacialAnimData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_PerformerDataComp");
	}

	static BUS_PerformerDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_PerformerDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_PerformerDataComp));
	}
}
