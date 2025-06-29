namespace UnrealEngine.Runtime;

public static class UObjectStatic
{
	public static bool IsNullOrDestroyed(this UObject Obj)
	{
		if ((object)Obj == null)
		{
			return true;
		}
		if (Obj.IsDestroyed)
		{
			return true;
		}
		if (SharedRuntimeState.IsShutdown)
		{
			return true;
		}
		if (Obj.HasAnyFlags(EObjectFlags.FinishDestroyed))
		{
			return true;
		}
		return Obj.IsPendingKill;
	}

	public static bool IsNullFastCheck(this UObject Obj)
	{
		if ((object)Obj == null)
		{
			return true;
		}
		if (Obj.IsDestroyed)
		{
			return true;
		}
		return false;
	}
}
