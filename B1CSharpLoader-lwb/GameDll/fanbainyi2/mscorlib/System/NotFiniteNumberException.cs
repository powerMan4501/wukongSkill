using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System;

[Serializable]
[ComVisible(true)]
public class NotFiniteNumberException : ArithmeticException
{
	private double _offendingNumber;

	public double OffendingNumber => _offendingNumber;

	public NotFiniteNumberException()
		: base(Environment.GetResourceString("Arg_NotFiniteNumberException"))
	{
		_offendingNumber = 0.0;
		SetErrorCode(-2146233048);
	}

	public NotFiniteNumberException(double offendingNumber)
	{
		_offendingNumber = offendingNumber;
		SetErrorCode(-2146233048);
	}

	public NotFiniteNumberException(string message)
		: base(message)
	{
		_offendingNumber = 0.0;
		SetErrorCode(-2146233048);
	}

	public NotFiniteNumberException(string message, double offendingNumber)
		: base(message)
	{
		_offendingNumber = offendingNumber;
		SetErrorCode(-2146233048);
	}

	public NotFiniteNumberException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233048);
	}

	public NotFiniteNumberException(string message, double offendingNumber, Exception innerException)
		: base(message, innerException)
	{
		_offendingNumber = offendingNumber;
		SetErrorCode(-2146233048);
	}

	protected NotFiniteNumberException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		_offendingNumber = info.GetInt32("OffendingNumber");
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		base.GetObjectData(info, context);
		info.AddValue("OffendingNumber", _offendingNumber, typeof(int));
	}
}
