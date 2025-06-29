using System.Collections.Generic;

namespace b1;

public interface IBUC_PlayerTransData
{
	float TransBackDurationTime { get; }

	float AttackDur { get; set; }

	float RollDur { get; set; }

	Dictionary<string, TransDmgStruct> GetTransDmgDict();
}
