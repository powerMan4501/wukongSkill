namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Method)]
public sealed class DataObjectMethodAttribute : Attribute
{
	private bool _isDefault;

	private DataObjectMethodType _methodType;

	public bool IsDefault => _isDefault;

	public DataObjectMethodType MethodType => _methodType;

	public DataObjectMethodAttribute(DataObjectMethodType methodType)
		: this(methodType, isDefault: false)
	{
	}

	public DataObjectMethodAttribute(DataObjectMethodType methodType, bool isDefault)
	{
		_methodType = methodType;
		_isDefault = isDefault;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is DataObjectMethodAttribute dataObjectMethodAttribute && dataObjectMethodAttribute.MethodType == MethodType)
		{
			return dataObjectMethodAttribute.IsDefault == IsDefault;
		}
		return false;
	}

	public override int GetHashCode()
	{
		int methodType = (int)_methodType;
		return methodType.GetHashCode() ^ _isDefault.GetHashCode();
	}

	public override bool Match(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is DataObjectMethodAttribute dataObjectMethodAttribute)
		{
			return dataObjectMethodAttribute.MethodType == MethodType;
		}
		return false;
	}
}
