using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_PropMgrType_Capsule_CollisionProfileName : BGU_PropMgrType_Capsule
{
	public BGU_PropMgrType_Capsule_CollisionProfileName(UCapsuleComponent InCapsuleComp)
		: base(InCapsuleComp)
	{
		base.PropType = EPropType.Capsule_CollisionProfileName;
		base.bCompositeProp = true;
	}

	public override void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection)
	{
		if (!(Request is BGU_StringPropRequest bGU_StringPropRequest) || !UBGUFunctionLibCollisionChannel.GetCollisionProfileData(base.CapsuleComp, new FName(bGU_StringPropRequest.Value), out var OutCollisionEnabled, out var OutObjectType, out var OutResponseToChannels))
		{
			return;
		}
		IBUC_PropMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(base.CapsuleComp.GetOwner());
		if (readOnlyData != null)
		{
			if (bGU_StringPropRequest.ChildHandleID != null && bGU_StringPropRequest.ChildHandleID.Count == 3)
			{
				EvtCollection.Evt_SetEnumProperty.Invoke(EPropType.Capsule_CollisionEnabled, (int)OutCollisionEnabled, bGU_StringPropRequest.ChildHandleID[0]);
				EvtCollection.Evt_SetEnumProperty.Invoke(EPropType.Capsule_CollisionObjectType, (int)OutObjectType, bGU_StringPropRequest.ChildHandleID[1]);
				EvtCollection.Evt_SetCollisionResponseProperty.Invoke(EPropType.Capsule_CollisionResponseToChannels, OutResponseToChannels, bGU_StringPropRequest.ChildHandleID[2]);
				return;
			}
			bGU_StringPropRequest.ChildHandleID = new List<uint>();
			EvtCollection.Evt_SetEnumProperty.Invoke(EPropType.Capsule_CollisionEnabled, (int)OutCollisionEnabled);
			bGU_StringPropRequest.ChildHandleID.Add(readOnlyData.GetLastHandleID());
			EvtCollection.Evt_SetEnumProperty.Invoke(EPropType.Capsule_CollisionObjectType, (int)OutObjectType);
			bGU_StringPropRequest.ChildHandleID.Add(readOnlyData.GetLastHandleID());
			EvtCollection.Evt_SetCollisionResponseProperty.Invoke(EPropType.Capsule_CollisionResponseToChannels, OutResponseToChannels);
			bGU_StringPropRequest.ChildHandleID.Add(readOnlyData.GetLastHandleID());
		}
	}

	public override void SetDefaultProperty(BUS_GSEventCollection EvtCollection)
	{
	}
}
