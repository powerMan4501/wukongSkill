using System.Runtime.InteropServices;

namespace System.Reflection;

[Serializable]
[ComVisible(true)]
public struct ParameterModifier
{
	private bool[] _byRef;

	internal bool[] IsByRefArray => _byRef;

	public bool this[int index]
	{
		get
		{
			return _byRef[index];
		}
		set
		{
			_byRef[index] = value;
		}
	}

	public ParameterModifier(int parameterCount)
	{
		if (parameterCount <= 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_ParmArraySize"));
		}
		_byRef = new bool[parameterCount];
	}
}
