using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class FScopedSlowTask : FSlowTask
{
	public FScopedSlowTask(float amountOfWork, string defaultMessage = null, bool enabled = true)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(defaultMessage);
		base.Address = Native_FSlowTask.New_FScopedSlowTask(amountOfWork, ref fStringUnsafe.Array, enabled);
	}
}
