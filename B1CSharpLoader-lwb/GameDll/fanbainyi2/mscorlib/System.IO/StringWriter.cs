using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace System.IO;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class StringWriter : TextWriter
{
	private static volatile UnicodeEncoding m_encoding;

	private StringBuilder _sb;

	private bool _isOpen;

	[__DynamicallyInvokable]
	public override Encoding Encoding
	{
		[__DynamicallyInvokable]
		get
		{
			if (m_encoding == null)
			{
				m_encoding = new UnicodeEncoding(bigEndian: false, byteOrderMark: false);
			}
			return m_encoding;
		}
	}

	[__DynamicallyInvokable]
	public StringWriter()
		: this(new StringBuilder(), CultureInfo.CurrentCulture)
	{
	}

	[__DynamicallyInvokable]
	public StringWriter(IFormatProvider formatProvider)
		: this(new StringBuilder(), formatProvider)
	{
	}

	[__DynamicallyInvokable]
	public StringWriter(StringBuilder sb)
		: this(sb, CultureInfo.CurrentCulture)
	{
	}

	[__DynamicallyInvokable]
	public StringWriter(StringBuilder sb, IFormatProvider formatProvider)
		: base(formatProvider)
	{
		if (sb == null)
		{
			throw new ArgumentNullException("sb", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		_sb = sb;
		_isOpen = true;
	}

	public override void Close()
	{
		Dispose(disposing: true);
	}

	[__DynamicallyInvokable]
	protected override void Dispose(bool disposing)
	{
		_isOpen = false;
		base.Dispose(disposing);
	}

	[__DynamicallyInvokable]
	public virtual StringBuilder GetStringBuilder()
	{
		return _sb;
	}

	[__DynamicallyInvokable]
	public override void Write(char value)
	{
		if (!_isOpen)
		{
			__Error.WriterClosed();
		}
		_sb.Append(value);
	}

	[__DynamicallyInvokable]
	public override void Write(char[] buffer, int index, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - index < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (!_isOpen)
		{
			__Error.WriterClosed();
		}
		_sb.Append(buffer, index, count);
	}

	[__DynamicallyInvokable]
	public override void Write(string value)
	{
		if (!_isOpen)
		{
			__Error.WriterClosed();
		}
		if (value != null)
		{
			_sb.Append(value);
		}
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task WriteAsync(char value)
	{
		Write(value);
		return Task.CompletedTask;
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task WriteAsync(string value)
	{
		Write(value);
		return Task.CompletedTask;
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task WriteAsync(char[] buffer, int index, int count)
	{
		Write(buffer, index, count);
		return Task.CompletedTask;
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task WriteLineAsync(char value)
	{
		WriteLine(value);
		return Task.CompletedTask;
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task WriteLineAsync(string value)
	{
		WriteLine(value);
		return Task.CompletedTask;
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task WriteLineAsync(char[] buffer, int index, int count)
	{
		WriteLine(buffer, index, count);
		return Task.CompletedTask;
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task FlushAsync()
	{
		return Task.CompletedTask;
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		return _sb.ToString();
	}
}
