using UnrealEngine.Engine;

namespace b1;

public class BUCMUAVelocity : BUChangeMaterialUnitAttrTemplate
{
	public BUCMUAVelocity()
	{
		base.AttrType = EChangeMatUnitAttrType.Velocity;
	}

	public override float GetAttrValue(AActor Owner)
	{
		if (Owner == null)
		{
			return 0f;
		}
		IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(Owner);
		if (readOnlyData != null && readOnlyData.HasSimpleState(EBGUSimpleState.PhysicsSimulationMoveMode))
		{
			b1.IBUC_PhysicalMoveData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_PhysicalMoveData, b1.BUC_PhysicalMoveData>(Owner);
			if (unPersistentReadOnlyData != null)
			{
				return unPersistentReadOnlyData.PhysicalMoveVelocity.Size();
			}
		}
		return Owner.GetVelocity().Size();
	}
}
