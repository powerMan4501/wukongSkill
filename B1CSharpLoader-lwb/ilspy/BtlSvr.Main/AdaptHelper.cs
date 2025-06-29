using System;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;

public static class AdaptHelper
{
	public class AdaptMethod
	{
		public string Name;

		public int ParamCount;

		public IMethod Method;
	}

	public static IMethod GetMethod(this ILType type, AdaptMethod m)
	{
		if (m.Method != null)
		{
			return m.Method;
		}
		m.Method = type.GetMethod(m.Name, m.ParamCount);
		if (m.Method == null)
		{
			string text = "";
			if (type.FirstCLRBaseType != null)
			{
				text = type.FirstCLRBaseType.FullName;
			}
			else if (type.FirstCLRInterface != null)
			{
				text = type.FirstCLRInterface.FullName;
			}
			throw new Exception($"can't find the method: {type.FullName}.{m.Name}:{text}, paramCount={m.ParamCount}");
		}
		return m.Method;
	}
}
