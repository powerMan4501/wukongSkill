using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class BGU_CollisionResponsePropRequest : BGU_PropMgrRequestBase
{
	public Dictionary<ECollisionChannel, ECollisionResponseType> Value { get; private set; }

	public BGU_CollisionResponsePropRequest(Dictionary<ECollisionChannel, ECollisionResponseType> RequestValue)
	{
		Value = RequestValue;
	}

	public BGU_CollisionResponsePropRequest()
	{
		Value = new Dictionary<ECollisionChannel, ECollisionResponseType>();
	}

	public override BGU_PropMgrRequestBase Clone()
	{
		BGU_CollisionResponsePropRequest bGU_CollisionResponsePropRequest = new BGU_CollisionResponsePropRequest();
		foreach (KeyValuePair<ECollisionChannel, ECollisionResponseType> item in Value)
		{
			bGU_CollisionResponsePropRequest.Value.Add(item.Key, item.Value);
		}
		return bGU_CollisionResponsePropRequest;
	}

	public override bool Equals(BGU_PropMgrRequestBase Other)
	{
		if (!(Other is BGU_CollisionResponsePropRequest bGU_CollisionResponsePropRequest))
		{
			return false;
		}
		if (bGU_CollisionResponsePropRequest.Value.Count != Value.Count)
		{
			return false;
		}
		foreach (KeyValuePair<ECollisionChannel, ECollisionResponseType> item in Value)
		{
			if (!bGU_CollisionResponsePropRequest.Value.ContainsKey(item.Key))
			{
				return false;
			}
			if (bGU_CollisionResponsePropRequest.Value[item.Key] != item.Value)
			{
				return false;
			}
		}
		return true;
	}

	public override void Merge(BGU_PropMgrRequestBase Other)
	{
		if (!(Other is BGU_CollisionResponsePropRequest bGU_CollisionResponsePropRequest))
		{
			return;
		}
		foreach (KeyValuePair<ECollisionChannel, ECollisionResponseType> item in bGU_CollisionResponsePropRequest.Value)
		{
			if (Value.ContainsKey(item.Key))
			{
				Value[item.Key] = item.Value;
			}
			else
			{
				Value.Add(item.Key, item.Value);
			}
		}
	}
}
