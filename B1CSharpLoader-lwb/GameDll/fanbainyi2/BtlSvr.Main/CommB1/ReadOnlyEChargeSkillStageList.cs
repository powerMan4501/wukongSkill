using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEChargeSkillStageList : ReadOnlyPrimitiveList<EChargeSkillStage>
{
	public ReadOnlyEChargeSkillStageList(RepeatedField<EChargeSkillStage> pbData)
		: base(pbData)
	{
	}
}
