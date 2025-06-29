namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Property)]
public sealed class DataObjectFieldAttribute : Attribute
{
	private bool _primaryKey;

	private bool _isIdentity;

	private bool _isNullable;

	private int _length;

	public bool IsIdentity => _isIdentity;

	public bool IsNullable => _isNullable;

	public int Length => _length;

	public bool PrimaryKey => _primaryKey;

	public DataObjectFieldAttribute(bool primaryKey)
		: this(primaryKey, isIdentity: false, isNullable: false, -1)
	{
	}

	public DataObjectFieldAttribute(bool primaryKey, bool isIdentity)
		: this(primaryKey, isIdentity, isNullable: false, -1)
	{
	}

	public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable)
		: this(primaryKey, isIdentity, isNullable, -1)
	{
	}

	public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable, int length)
	{
		_primaryKey = primaryKey;
		_isIdentity = isIdentity;
		_isNullable = isNullable;
		_length = length;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is DataObjectFieldAttribute dataObjectFieldAttribute && dataObjectFieldAttribute.IsIdentity == IsIdentity && dataObjectFieldAttribute.IsNullable == IsNullable && dataObjectFieldAttribute.Length == Length)
		{
			return dataObjectFieldAttribute.PrimaryKey == PrimaryKey;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}
}
