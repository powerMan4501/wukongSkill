using System;

namespace b1;

public class DelLeakLogData : LeakLogData
{
	public string Target;

	public string TargetType;

	public string DelegateType;

	public string Method;

	public DelLeakLogData(Delegate Del)
	{
		if ((object)Del != null)
		{
			Target = ((Del.Target != null) ? Del.Target.ToString() : "None");
			TargetType = ((Del.Target != null) ? Del.Target.GetType().ToString() : Del.Method.DeclaringType.ToString());
			DelegateType = Del.GetType().ToString();
			Method = ((Del.Method != null) ? Del.Method.Name : "None");
		}
		else
		{
			Target = "None";
			TargetType = "Unkown";
			DelegateType = "Unkown";
			Method = "None";
		}
	}
}
