using System;

namespace UnrealEngine.Runtime;

public struct ObjectOuter
{
	public UObject Object;

	public bool IsAnyPackage;

	public IntPtr Address
	{
		get
		{
			if (IsAnyPackage)
			{
				return new IntPtr(-1);
			}
			if (!(Object == null))
			{
				return Object.Address;
			}
			return IntPtr.Zero;
		}
	}

	public static ObjectOuter AnyPackage => new ObjectOuter
	{
		IsAnyPackage = true
	};

	public static ObjectOuter Null => default(ObjectOuter);

	public static implicit operator ObjectOuter(UObject obj)
	{
		return new ObjectOuter
		{
			Object = obj
		};
	}
}
