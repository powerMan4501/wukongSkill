namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
[Conditional("CODE_ANALYSIS")]
[__DynamicallyInvokable]
public sealed class SuppressMessageAttribute : Attribute
{
	private string category;

	private string justification;

	private string checkId;

	private string scope;

	private string target;

	private string messageId;

	[__DynamicallyInvokable]
	public string Category
	{
		[__DynamicallyInvokable]
		get
		{
			return category;
		}
	}

	[__DynamicallyInvokable]
	public string CheckId
	{
		[__DynamicallyInvokable]
		get
		{
			return checkId;
		}
	}

	[__DynamicallyInvokable]
	public string Scope
	{
		[__DynamicallyInvokable]
		get
		{
			return scope;
		}
		[__DynamicallyInvokable]
		set
		{
			scope = value;
		}
	}

	[__DynamicallyInvokable]
	public string Target
	{
		[__DynamicallyInvokable]
		get
		{
			return target;
		}
		[__DynamicallyInvokable]
		set
		{
			target = value;
		}
	}

	[__DynamicallyInvokable]
	public string MessageId
	{
		[__DynamicallyInvokable]
		get
		{
			return messageId;
		}
		[__DynamicallyInvokable]
		set
		{
			messageId = value;
		}
	}

	[__DynamicallyInvokable]
	public string Justification
	{
		[__DynamicallyInvokable]
		get
		{
			return justification;
		}
		[__DynamicallyInvokable]
		set
		{
			justification = value;
		}
	}

	[__DynamicallyInvokable]
	public SuppressMessageAttribute(string category, string checkId)
	{
		this.category = category;
		this.checkId = checkId;
	}
}
