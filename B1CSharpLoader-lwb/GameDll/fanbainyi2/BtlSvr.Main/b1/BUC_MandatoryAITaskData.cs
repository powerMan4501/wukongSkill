using System.Collections.Generic;

namespace b1;

public class BUC_MandatoryAITaskData : IBUC_MandatoryAITaskData
{
	public List<FMandatoryTask> MandatoryTasks { get; } = new List<FMandatoryTask>();

	public List<FMandatoryTask> BeAttackTasks { get; } = new List<FMandatoryTask>();

	public void InitData()
	{
		MandatoryTasks.Clear();
		BeAttackTasks.Clear();
	}
}
