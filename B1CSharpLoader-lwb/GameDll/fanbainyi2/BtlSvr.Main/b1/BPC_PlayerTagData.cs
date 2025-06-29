using b1.ECS;
using BtlShare;

namespace b1;

public class BPC_PlayerTagData : IBPC_PlayerTagData, IPersistentECSData
{
	public GSBindList<float> PlayerTags { get; set; }

	private GSBindList<int> LastTimeOutPlayerTags { get; set; }

	public BPC_PlayerTagData()
	{
		PlayerTags = new GSBindList<float>();
		LastTimeOutPlayerTags = new GSBindList<int>();
		for (int i = 0; i < 4; i++)
		{
			PlayerTags.Add(0f);
		}
	}

	public bool HasTag(EBGPPlayerTag PlayerTag)
	{
		return PlayerTags[(int)PlayerTag] != 0f;
	}

	public void SetTag(EBGPPlayerTag PlayerTag, bool NeedForceUpdate, float Time = -1f)
	{
		float num = PlayerTags[(int)PlayerTag];
		if (!NeedForceUpdate && num > 0f && Time < num && Time > 0f)
		{
			Time = num;
		}
		PlayerTags[(int)PlayerTag] = Time;
	}

	public GSBindList<int> GetLastTimeOutPlayerTags()
	{
		return LastTimeOutPlayerTags;
	}

	public void UpdateTagTime(float DeltaTime)
	{
		LastTimeOutPlayerTags.Clear();
		for (int i = 0; i < 4; i++)
		{
			float num = PlayerTags[i];
			if (num > 0f)
			{
				num -= DeltaTime;
				if (num <= 0f)
				{
					num = 0f;
					LastTimeOutPlayerTags.Add(i);
				}
				PlayerTags[i] = num;
			}
		}
	}

	public void RemoveTag(EBGPPlayerTag PlayerTag)
	{
		PlayerTags[(int)PlayerTag] = 0f;
	}
}
