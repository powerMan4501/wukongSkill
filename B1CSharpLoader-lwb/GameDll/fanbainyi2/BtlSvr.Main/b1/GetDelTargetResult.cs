using UnrealEngine.Runtime;

namespace b1;

public class GetDelTargetResult
{
	public UObject Obj;

	private bool IsLeak;

	private bool IsCatch;

	public GetDelTargetResult(UObject InObj, bool InIsLeak, bool InIsCatch)
	{
		Obj = InObj;
		IsLeak = InIsLeak;
		IsCatch = InIsCatch;
	}

	public bool GetIsLeak()
	{
		if (!IsLeak)
		{
			if ((object)Obj != null)
			{
				return Obj.IsDestroyed;
			}
			return false;
		}
		return true;
	}

	public bool GetIsCatch()
	{
		return IsCatch;
	}

	public bool GetIsValid()
	{
		return !Obj.IsNullOrDestroyed();
	}
}
