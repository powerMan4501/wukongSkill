using System.Collections.Generic;
using BtlB1;
using BtlShare;

namespace b1;

public class FMandatoryTask
{
	public EAITaskCondition TaskCondition { get; set; }

	public EAITaskActivationEvent TaskActivationEvent { get; set; }

	public EGSYesNo IsReverseCondition { get; set; }

	public IList<float> ConditionFloatParams { get; set; }

	public IList<int> ConditionIntParams { get; set; }

	public IList<FUStAITaskInfo> AITaskInfoList { get; set; }

	public bool IsDone { get; set; }
}
