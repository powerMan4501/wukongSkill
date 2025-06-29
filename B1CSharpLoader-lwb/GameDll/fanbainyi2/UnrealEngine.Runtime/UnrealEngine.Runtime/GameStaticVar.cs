namespace UnrealEngine.Runtime;

public class GameStaticVar<T> : StaticVar
{
	public T Value;

	public override void OnPIEBegin(bool simulating)
	{
		Value = default(T);
	}

	public override void OnPIEEnd(bool simulating)
	{
		Value = default(T);
	}

	public static implicit operator T(GameStaticVar<T> value)
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}
}
