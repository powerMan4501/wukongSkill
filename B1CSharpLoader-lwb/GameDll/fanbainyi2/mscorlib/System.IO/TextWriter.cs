using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public abstract class TextWriter : MarshalByRefObject, IDisposable
{
	[Serializable]
	private sealed class NullTextWriter : TextWriter
	{
		public override Encoding Encoding => Encoding.Default;

		internal NullTextWriter()
			: base(CultureInfo.InvariantCulture)
		{
		}

		public override void Write(char[] buffer, int index, int count)
		{
		}

		public override void Write(string value)
		{
		}

		public override void WriteLine()
		{
		}

		public override void WriteLine(string value)
		{
		}

		public override void WriteLine(object value)
		{
		}
	}

	[Serializable]
	internal sealed class SyncTextWriter : TextWriter, IDisposable
	{
		private TextWriter _out;

		public override Encoding Encoding => _out.Encoding;

		public override IFormatProvider FormatProvider => _out.FormatProvider;

		public override string NewLine
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			get
			{
				return _out.NewLine;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_out.NewLine = value;
			}
		}

		internal SyncTextWriter(TextWriter t)
			: base(t.FormatProvider)
		{
			_out = t;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Close()
		{
			_out.Close();
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				((IDisposable)_out).Dispose();
			}
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Flush()
		{
			_out.Flush();
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Write(char value)
		{
			_out.Write(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Write(char[] buffer)
		{
			_out.Write(buffer);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Write(char[] buffer, int index, int count)
		{
			_out.Write(buffer, index, count);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Write(bool value)
		{
			_out.Write(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Write(int value)
		{
			_out.Write(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Write(uint value)
		{
			_out.Write(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Write(long value)
		{
			_out.Write(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Write(ulong value)
		{
			_out.Write(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Write(float value)
		{
			_out.Write(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Write(double value)
		{
			_out.Write(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Write(decimal value)
		{
			_out.Write(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Write(string value)
		{
			_out.Write(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Write(object value)
		{
			_out.Write(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Write(string format, object arg0)
		{
			_out.Write(format, arg0);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Write(string format, object arg0, object arg1)
		{
			_out.Write(format, arg0, arg1);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Write(string format, object arg0, object arg1, object arg2)
		{
			_out.Write(format, arg0, arg1, arg2);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Write(string format, params object[] arg)
		{
			_out.Write(format, arg);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void WriteLine()
		{
			_out.WriteLine();
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void WriteLine(char value)
		{
			_out.WriteLine(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void WriteLine(decimal value)
		{
			_out.WriteLine(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void WriteLine(char[] buffer)
		{
			_out.WriteLine(buffer);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void WriteLine(char[] buffer, int index, int count)
		{
			_out.WriteLine(buffer, index, count);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void WriteLine(bool value)
		{
			_out.WriteLine(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void WriteLine(int value)
		{
			_out.WriteLine(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void WriteLine(uint value)
		{
			_out.WriteLine(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void WriteLine(long value)
		{
			_out.WriteLine(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void WriteLine(ulong value)
		{
			_out.WriteLine(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void WriteLine(float value)
		{
			_out.WriteLine(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void WriteLine(double value)
		{
			_out.WriteLine(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void WriteLine(string value)
		{
			_out.WriteLine(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void WriteLine(object value)
		{
			_out.WriteLine(value);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void WriteLine(string format, object arg0)
		{
			_out.WriteLine(format, arg0);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void WriteLine(string format, object arg0, object arg1)
		{
			_out.WriteLine(format, arg0, arg1);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void WriteLine(string format, object arg0, object arg1, object arg2)
		{
			_out.WriteLine(format, arg0, arg1, arg2);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void WriteLine(string format, params object[] arg)
		{
			_out.WriteLine(format, arg);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[ComVisible(false)]
		public override Task WriteAsync(char value)
		{
			Write(value);
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[ComVisible(false)]
		public override Task WriteAsync(string value)
		{
			Write(value);
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[ComVisible(false)]
		public override Task WriteAsync(char[] buffer, int index, int count)
		{
			Write(buffer, index, count);
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[ComVisible(false)]
		public override Task WriteLineAsync(char value)
		{
			WriteLine(value);
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[ComVisible(false)]
		public override Task WriteLineAsync(string value)
		{
			WriteLine(value);
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[ComVisible(false)]
		public override Task WriteLineAsync(char[] buffer, int index, int count)
		{
			WriteLine(buffer, index, count);
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[ComVisible(false)]
		public override Task FlushAsync()
		{
			Flush();
			return Task.CompletedTask;
		}
	}

	[__DynamicallyInvokable]
	public static readonly TextWriter Null = new NullTextWriter();

	[NonSerialized]
	private static Action<object> _WriteCharDelegate = delegate(object state)
	{
		Tuple<TextWriter, char> tuple = (Tuple<TextWriter, char>)state;
		tuple.Item1.Write(tuple.Item2);
	};

	[NonSerialized]
	private static Action<object> _WriteStringDelegate = delegate(object state)
	{
		Tuple<TextWriter, string> tuple = (Tuple<TextWriter, string>)state;
		tuple.Item1.Write(tuple.Item2);
	};

	[NonSerialized]
	private static Action<object> _WriteCharArrayRangeDelegate = delegate(object state)
	{
		Tuple<TextWriter, char[], int, int> tuple = (Tuple<TextWriter, char[], int, int>)state;
		tuple.Item1.Write(tuple.Item2, tuple.Item3, tuple.Item4);
	};

	[NonSerialized]
	private static Action<object> _WriteLineCharDelegate = delegate(object state)
	{
		Tuple<TextWriter, char> tuple = (Tuple<TextWriter, char>)state;
		tuple.Item1.WriteLine(tuple.Item2);
	};

	[NonSerialized]
	private static Action<object> _WriteLineStringDelegate = delegate(object state)
	{
		Tuple<TextWriter, string> tuple = (Tuple<TextWriter, string>)state;
		tuple.Item1.WriteLine(tuple.Item2);
	};

	[NonSerialized]
	private static Action<object> _WriteLineCharArrayRangeDelegate = delegate(object state)
	{
		Tuple<TextWriter, char[], int, int> tuple = (Tuple<TextWriter, char[], int, int>)state;
		tuple.Item1.WriteLine(tuple.Item2, tuple.Item3, tuple.Item4);
	};

	[NonSerialized]
	private static Action<object> _FlushDelegate = delegate(object state)
	{
		((TextWriter)state).Flush();
	};

	private const string InitialNewLine = "\r\n";

	[__DynamicallyInvokable]
	protected char[] CoreNewLine = new char[2] { '\r', '\n' };

	private IFormatProvider InternalFormatProvider;

	[__DynamicallyInvokable]
	public virtual IFormatProvider FormatProvider
	{
		[__DynamicallyInvokable]
		get
		{
			if (InternalFormatProvider == null)
			{
				return Thread.CurrentThread.CurrentCulture;
			}
			return InternalFormatProvider;
		}
	}

	[__DynamicallyInvokable]
	public abstract Encoding Encoding
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public virtual string NewLine
	{
		[__DynamicallyInvokable]
		get
		{
			return new string(CoreNewLine);
		}
		[__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				value = "\r\n";
			}
			CoreNewLine = value.ToCharArray();
		}
	}

	[__DynamicallyInvokable]
	protected TextWriter()
	{
		InternalFormatProvider = null;
	}

	[__DynamicallyInvokable]
	protected TextWriter(IFormatProvider formatProvider)
	{
		InternalFormatProvider = formatProvider;
	}

	public virtual void Close()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[__DynamicallyInvokable]
	protected virtual void Dispose(bool disposing)
	{
	}

	[__DynamicallyInvokable]
	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[__DynamicallyInvokable]
	public virtual void Flush()
	{
	}

	[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
	public static TextWriter Synchronized(TextWriter writer)
	{
		if (writer == null)
		{
			throw new ArgumentNullException("writer");
		}
		if (writer is SyncTextWriter)
		{
			return writer;
		}
		return new SyncTextWriter(writer);
	}

	[__DynamicallyInvokable]
	public virtual void Write(char value)
	{
	}

	[__DynamicallyInvokable]
	public virtual void Write(char[] buffer)
	{
		if (buffer != null)
		{
			Write(buffer, 0, buffer.Length);
		}
	}

	[__DynamicallyInvokable]
	public virtual void Write(char[] buffer, int index, int count)
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
		for (int i = 0; i < count; i++)
		{
			Write(buffer[index + i]);
		}
	}

	[__DynamicallyInvokable]
	public virtual void Write(bool value)
	{
		Write(value ? "True" : "False");
	}

	[__DynamicallyInvokable]
	public virtual void Write(int value)
	{
		Write(value.ToString(FormatProvider));
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public virtual void Write(uint value)
	{
		Write(value.ToString(FormatProvider));
	}

	[__DynamicallyInvokable]
	public virtual void Write(long value)
	{
		Write(value.ToString(FormatProvider));
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public virtual void Write(ulong value)
	{
		Write(value.ToString(FormatProvider));
	}

	[__DynamicallyInvokable]
	public virtual void Write(float value)
	{
		Write(value.ToString(FormatProvider));
	}

	[__DynamicallyInvokable]
	public virtual void Write(double value)
	{
		Write(value.ToString(FormatProvider));
	}

	[__DynamicallyInvokable]
	public virtual void Write(decimal value)
	{
		Write(value.ToString(FormatProvider));
	}

	[__DynamicallyInvokable]
	public virtual void Write(string value)
	{
		if (value != null)
		{
			Write(value.ToCharArray());
		}
	}

	[__DynamicallyInvokable]
	public virtual void Write(object value)
	{
		if (value != null)
		{
			if (value is IFormattable formattable)
			{
				Write(formattable.ToString(null, FormatProvider));
			}
			else
			{
				Write(value.ToString());
			}
		}
	}

	[__DynamicallyInvokable]
	public virtual void Write(string format, object arg0)
	{
		Write(string.Format(FormatProvider, format, arg0));
	}

	[__DynamicallyInvokable]
	public virtual void Write(string format, object arg0, object arg1)
	{
		Write(string.Format(FormatProvider, format, arg0, arg1));
	}

	[__DynamicallyInvokable]
	public virtual void Write(string format, object arg0, object arg1, object arg2)
	{
		Write(string.Format(FormatProvider, format, arg0, arg1, arg2));
	}

	[__DynamicallyInvokable]
	public virtual void Write(string format, params object[] arg)
	{
		Write(string.Format(FormatProvider, format, arg));
	}

	[__DynamicallyInvokable]
	public virtual void WriteLine()
	{
		Write(CoreNewLine);
	}

	[__DynamicallyInvokable]
	public virtual void WriteLine(char value)
	{
		Write(value);
		WriteLine();
	}

	[__DynamicallyInvokable]
	public virtual void WriteLine(char[] buffer)
	{
		Write(buffer);
		WriteLine();
	}

	[__DynamicallyInvokable]
	public virtual void WriteLine(char[] buffer, int index, int count)
	{
		Write(buffer, index, count);
		WriteLine();
	}

	[__DynamicallyInvokable]
	public virtual void WriteLine(bool value)
	{
		Write(value);
		WriteLine();
	}

	[__DynamicallyInvokable]
	public virtual void WriteLine(int value)
	{
		Write(value);
		WriteLine();
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public virtual void WriteLine(uint value)
	{
		Write(value);
		WriteLine();
	}

	[__DynamicallyInvokable]
	public virtual void WriteLine(long value)
	{
		Write(value);
		WriteLine();
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public virtual void WriteLine(ulong value)
	{
		Write(value);
		WriteLine();
	}

	[__DynamicallyInvokable]
	public virtual void WriteLine(float value)
	{
		Write(value);
		WriteLine();
	}

	[__DynamicallyInvokable]
	public virtual void WriteLine(double value)
	{
		Write(value);
		WriteLine();
	}

	[__DynamicallyInvokable]
	public virtual void WriteLine(decimal value)
	{
		Write(value);
		WriteLine();
	}

	[__DynamicallyInvokable]
	public virtual void WriteLine(string value)
	{
		if (value == null)
		{
			WriteLine();
			return;
		}
		int length = value.Length;
		int num = CoreNewLine.Length;
		char[] array = new char[length + num];
		value.CopyTo(0, array, 0, length);
		switch (num)
		{
		case 2:
			array[length] = CoreNewLine[0];
			array[length + 1] = CoreNewLine[1];
			break;
		case 1:
			array[length] = CoreNewLine[0];
			break;
		default:
			Buffer.InternalBlockCopy(CoreNewLine, 0, array, length * 2, num * 2);
			break;
		}
		Write(array, 0, length + num);
	}

	[__DynamicallyInvokable]
	public virtual void WriteLine(object value)
	{
		if (value == null)
		{
			WriteLine();
		}
		else if (value is IFormattable formattable)
		{
			WriteLine(formattable.ToString(null, FormatProvider));
		}
		else
		{
			WriteLine(value.ToString());
		}
	}

	[__DynamicallyInvokable]
	public virtual void WriteLine(string format, object arg0)
	{
		WriteLine(string.Format(FormatProvider, format, arg0));
	}

	[__DynamicallyInvokable]
	public virtual void WriteLine(string format, object arg0, object arg1)
	{
		WriteLine(string.Format(FormatProvider, format, arg0, arg1));
	}

	[__DynamicallyInvokable]
	public virtual void WriteLine(string format, object arg0, object arg1, object arg2)
	{
		WriteLine(string.Format(FormatProvider, format, arg0, arg1, arg2));
	}

	[__DynamicallyInvokable]
	public virtual void WriteLine(string format, params object[] arg)
	{
		WriteLine(string.Format(FormatProvider, format, arg));
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task WriteAsync(char value)
	{
		Tuple<TextWriter, char> state = new Tuple<TextWriter, char>(this, value);
		return Task.Factory.StartNew(_WriteCharDelegate, state, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task WriteAsync(string value)
	{
		Tuple<TextWriter, string> state = new Tuple<TextWriter, string>(this, value);
		return Task.Factory.StartNew(_WriteStringDelegate, state, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task WriteAsync(char[] buffer)
	{
		if (buffer == null)
		{
			return Task.CompletedTask;
		}
		return WriteAsync(buffer, 0, buffer.Length);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task WriteAsync(char[] buffer, int index, int count)
	{
		Tuple<TextWriter, char[], int, int> state = new Tuple<TextWriter, char[], int, int>(this, buffer, index, count);
		return Task.Factory.StartNew(_WriteCharArrayRangeDelegate, state, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task WriteLineAsync(char value)
	{
		Tuple<TextWriter, char> state = new Tuple<TextWriter, char>(this, value);
		return Task.Factory.StartNew(_WriteLineCharDelegate, state, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task WriteLineAsync(string value)
	{
		Tuple<TextWriter, string> state = new Tuple<TextWriter, string>(this, value);
		return Task.Factory.StartNew(_WriteLineStringDelegate, state, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task WriteLineAsync(char[] buffer)
	{
		if (buffer == null)
		{
			return Task.CompletedTask;
		}
		return WriteLineAsync(buffer, 0, buffer.Length);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task WriteLineAsync(char[] buffer, int index, int count)
	{
		Tuple<TextWriter, char[], int, int> state = new Tuple<TextWriter, char[], int, int>(this, buffer, index, count);
		return Task.Factory.StartNew(_WriteLineCharArrayRangeDelegate, state, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task WriteLineAsync()
	{
		return WriteAsync(CoreNewLine);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task FlushAsync()
	{
		return Task.Factory.StartNew(_FlushDelegate, this, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
	}
}
