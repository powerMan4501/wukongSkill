using UnrealEngine.Runtime;

namespace b1.FUnctionLibUtil;

internal static class FunctionLibUtil
{
	public static bool ReturnIfUnitNullOrDestroyed(UObject Obj)
	{
		if (Obj is BGUCharacterCS obj)
		{
			return obj.IsNullOrDestroyed();
		}
		return false;
	}
}
