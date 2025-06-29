using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_PlayerTransData : IBUC_PlayerTransData, IPersistentECSData
{
	public Dictionary<string, bool> OriMeshHiddenInGame = new Dictionary<string, bool>();

	public Dictionary<string, TransDmgStruct> TransDmgDict = new Dictionary<string, TransDmgStruct>();

	private TStrongObjectPtr<UAnimInstance> mOriAnimInst = new TStrongObjectPtr<UAnimInstance>();

	public EPlayerTransEndType TransTypeCached;

	public int TransBackSkillID { get; set; }

	public float TransBackDurationTime { get; set; }

	public bool WaitSeqDestory { get; set; }

	public uint HiddenInGameHandleID { get; set; }

	public float AttackDur { get; set; }

	public float RollDur { get; set; }

	public UAnimInstance OriAnimInst
	{
		get
		{
			return mOriAnimInst.Get();
		}
		set
		{
			mOriAnimInst.Set(value);
		}
	}

	public BUC_PlayerTransData()
	{
		TransTypeCached = EPlayerTransEndType.None;
		WaitSeqDestory = false;
		AttackDur = 0f;
		RollDur = 0f;
	}

	public Dictionary<string, TransDmgStruct> GetTransDmgDict()
	{
		return TransDmgDict;
	}
}
