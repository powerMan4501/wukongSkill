using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class CLRIReferenceImpl<T> : CLRIPropertyValueImpl, IReference<T>, IPropertyValue, ICustomPropertyProvider
{
	private T _value;

	public T Value => _value;

	Type ICustomPropertyProvider.Type => _value.GetType();

	public CLRIReferenceImpl(PropertyType type, T obj)
		: base(type, obj)
	{
		_value = obj;
	}

	public override string ToString()
	{
		if (_value != null)
		{
			return _value.ToString();
		}
		return base.ToString();
	}

	ICustomProperty ICustomPropertyProvider.GetCustomProperty(string name)
	{
		return ICustomPropertyProviderImpl.CreateProperty(_value, name);
	}

	ICustomProperty ICustomPropertyProvider.GetIndexedProperty(string name, Type indexParameterType)
	{
		return ICustomPropertyProviderImpl.CreateIndexedProperty(_value, name, indexParameterType);
	}

	string ICustomPropertyProvider.GetStringRepresentation()
	{
		return _value.ToString();
	}

	[FriendAccessAllowed]
	internal static object UnboxHelper(object wrapper)
	{
		IReference<T> reference = (IReference<T>)wrapper;
		return reference.Value;
	}
}
