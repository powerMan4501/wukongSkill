using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Text.RegularExpressions;

[Serializable]
[global::__DynamicallyInvokable]
public class RegexMatchTimeoutException : TimeoutException, ISerializable
{
	private string regexInput;

	private string regexPattern;

	private TimeSpan matchTimeout = TimeSpan.FromTicks(-1L);

	[global::__DynamicallyInvokable]
	public string Pattern
	{
		[global::__DynamicallyInvokable]
		[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
		get
		{
			return regexPattern;
		}
	}

	[global::__DynamicallyInvokable]
	public string Input
	{
		[global::__DynamicallyInvokable]
		[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
		get
		{
			return regexInput;
		}
	}

	[global::__DynamicallyInvokable]
	public TimeSpan MatchTimeout
	{
		[global::__DynamicallyInvokable]
		[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
		get
		{
			return matchTimeout;
		}
	}

	[global::__DynamicallyInvokable]
	public RegexMatchTimeoutException(string regexInput, string regexPattern, TimeSpan matchTimeout)
		: base(SR.GetString("RegexMatchTimeoutException_Occurred"))
	{
		Init(regexInput, regexPattern, matchTimeout);
	}

	[global::__DynamicallyInvokable]
	public RegexMatchTimeoutException()
	{
		Init();
	}

	[global::__DynamicallyInvokable]
	public RegexMatchTimeoutException(string message)
		: base(message)
	{
		Init();
	}

	[global::__DynamicallyInvokable]
	public RegexMatchTimeoutException(string message, Exception inner)
		: base(message, inner)
	{
		Init();
	}

	[SecurityPermission(SecurityAction.LinkDemand, SerializationFormatter = true)]
	protected RegexMatchTimeoutException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		string input = info.GetString("regexInput");
		string pattern = info.GetString("regexPattern");
		TimeSpan timeout = TimeSpan.FromTicks(info.GetInt64("timeoutTicks"));
		Init(input, pattern, timeout);
	}

	[SecurityPermission(SecurityAction.LinkDemand, SerializationFormatter = true)]
	void ISerializable.GetObjectData(SerializationInfo si, StreamingContext context)
	{
		base.GetObjectData(si, context);
		si.AddValue("regexInput", regexInput);
		si.AddValue("regexPattern", regexPattern);
		si.AddValue("timeoutTicks", matchTimeout.Ticks);
	}

	private void Init()
	{
		Init("", "", TimeSpan.FromTicks(-1L));
	}

	private void Init(string input, string pattern, TimeSpan timeout)
	{
		regexInput = input;
		regexPattern = pattern;
		matchTimeout = timeout;
	}
}
