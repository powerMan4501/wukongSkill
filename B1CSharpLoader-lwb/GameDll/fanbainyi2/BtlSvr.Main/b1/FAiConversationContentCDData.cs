using System.Collections.Generic;
using System.Linq;

namespace b1;

public class FAiConversationContentCDData
{
	private float GlobalCDTimer;

	private Dictionary<string, float> EntityCDTimerMap = new Dictionary<string, float>();

	public bool IsInCD(string UnitGUID)
	{
		if (GlobalCDTimer > 0f)
		{
			return true;
		}
		if (EntityCDTimerMap.ContainsKey(UnitGUID))
		{
			return true;
		}
		return false;
	}

	public void CastCD(string UnitGUID, float NewCD, bool bIsGlobalCD = false)
	{
		if (!(NewCD <= 0f))
		{
			if (bIsGlobalCD)
			{
				GlobalCDTimer = NewCD;
			}
			else if (EntityCDTimerMap.ContainsKey(UnitGUID))
			{
				EntityCDTimerMap[UnitGUID] = NewCD;
			}
			else
			{
				EntityCDTimerMap.Add(UnitGUID, NewCD);
			}
		}
	}

	public void UpdateData(float DeltaTime)
	{
		if (GlobalCDTimer > 0f)
		{
			GlobalCDTimer -= DeltaTime;
			GlobalCDTimer = ((GlobalCDTimer < 0f) ? (-1f) : GlobalCDTimer);
		}
		if (EntityCDTimerMap.Count <= 0)
		{
			return;
		}
		string[] array = EntityCDTimerMap.Keys.ToArray();
		foreach (string key in array)
		{
			if (EntityCDTimerMap[key] > 0f)
			{
				EntityCDTimerMap[key] -= DeltaTime;
			}
			else
			{
				EntityCDTimerMap.Remove(key);
			}
		}
	}

	public bool IsEmpty()
	{
		if (GlobalCDTimer <= 0f && EntityCDTimerMap.Count < 1)
		{
			return true;
		}
		return false;
	}
}
