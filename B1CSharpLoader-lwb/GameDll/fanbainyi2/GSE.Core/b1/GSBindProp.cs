namespace b1;

public class GSBindProp<T>
{
	public delegate void ValueChangedHandler(EChangeReason Reason, T OldValue, T NewValue);

	public ValueChangedHandler OnValueChanged;

	private T MValue;

	public T Value => MValue;

	public void InitForEnumBugFix(T InitValue)
	{
		MValue = InitValue;
	}

	public bool SetValue(EChangeReason Reason, T value, bool Force = false)
	{
		if (!object.Equals(MValue, value) || Force)
		{
			T mValue = MValue;
			MValue = value;
			OnValueChanged?.Invoke(Reason, mValue, MValue);
			return true;
		}
		return false;
	}

	public bool SetTrigger(EChangeReason Reason, T value)
	{
		T mValue = MValue;
		OnValueChanged?.Invoke(Reason, mValue, value);
		return true;
	}

	public override string ToString()
	{
		return MValue.ToString();
	}
}
