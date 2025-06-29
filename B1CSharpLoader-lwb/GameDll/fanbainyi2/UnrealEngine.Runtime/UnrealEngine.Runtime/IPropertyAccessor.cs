using System;

namespace UnrealEngine.Runtime;

public interface IPropertyAccessor<T>
{
	T GetValuePtr(IntPtr address);

	void SetValuePtr(IntPtr address, T value);
}
