using System.Collections.Generic;
using b1.EventDelDefine;

namespace b1;

internal class BUS_SuperArmorLevelMappingComp : UActorCompBaseCS
{
	private BUC_SuperArmorLevelMappingData SuperArmorLevelMappingData;

	public override void OnAttach()
	{
		SuperArmorLevelMappingData = RequireWritableData<BUC_SuperArmorLevelMappingData>();
		base.BUSEventCollection.Evt_SetSuperArmorLevelMapping += new Del_SetSuperArmorLevelMapping(OnSetSuperArmorLevelMapping);
		base.BUSEventCollection.Evt_RemoveSuperArmorLevelMapping += new Del_RemoveSuperArmorLevelMapping(OnRemoveSuperArmorLevelMapping);
	}

	private void OnSetSuperArmorLevelMapping(int BuffID, string OriginalLevelName, string TargetLevelName, float ValueIntervalMin, float ValueIntervalMax, float ValueBias)
	{
		if (SuperArmorLevelMappingData.SuperArmorLevelMapping.TryGetValue(OriginalLevelName, out var value))
		{
			value.Insert(0, new GSSuperArmorMappingTargetInfo(BuffID, TargetLevelName, ValueIntervalMin, ValueIntervalMax, ValueBias));
			return;
		}
		SuperArmorLevelMappingData.SuperArmorLevelMapping.Add(OriginalLevelName, new List<GSSuperArmorMappingTargetInfo>
		{
			new GSSuperArmorMappingTargetInfo(BuffID, TargetLevelName, ValueIntervalMin, ValueIntervalMax, ValueBias)
		});
	}

	private void OnRemoveSuperArmorLevelMapping(int BuffID, string OriginalLevelName)
	{
		if (!SuperArmorLevelMappingData.SuperArmorLevelMapping.TryGetValue(OriginalLevelName, out var value))
		{
			return;
		}
		for (int num = value.Count - 1; num >= 0; num--)
		{
			if (value[num].BuffID == BuffID)
			{
				value.RemoveAt(num);
			}
		}
		if (value.Count == 0)
		{
			SuperArmorLevelMappingData.SuperArmorLevelMapping.Remove(OriginalLevelName);
		}
	}
}
