namespace System.Diagnostics.Contracts;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
[Conditional("CONTRACTS_FULL")]
[__DynamicallyInvokable]
public sealed class ContractOptionAttribute : Attribute
{
	private string _category;

	private string _setting;

	private bool _enabled;

	private string _value;

	[__DynamicallyInvokable]
	public string Category
	{
		[__DynamicallyInvokable]
		get
		{
			return _category;
		}
	}

	[__DynamicallyInvokable]
	public string Setting
	{
		[__DynamicallyInvokable]
		get
		{
			return _setting;
		}
	}

	[__DynamicallyInvokable]
	public bool Enabled
	{
		[__DynamicallyInvokable]
		get
		{
			return _enabled;
		}
	}

	[__DynamicallyInvokable]
	public string Value
	{
		[__DynamicallyInvokable]
		get
		{
			return _value;
		}
	}

	[__DynamicallyInvokable]
	public ContractOptionAttribute(string category, string setting, bool enabled)
	{
		_category = category;
		_setting = setting;
		_enabled = enabled;
	}

	[__DynamicallyInvokable]
	public ContractOptionAttribute(string category, string setting, string value)
	{
		_category = category;
		_setting = setting;
		_value = value;
	}
}
