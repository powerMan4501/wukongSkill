using System.Runtime.Serialization;
using System.Security;

namespace System.Text;

[Serializable]
internal sealed class CodePageEncoding : ISerializable, IObjectReference
{
	[Serializable]
	internal sealed class Decoder : ISerializable, IObjectReference
	{
		[NonSerialized]
		private Encoding realEncoding;

		internal Decoder(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			realEncoding = (Encoding)info.GetValue("encoding", typeof(Encoding));
		}

		[SecurityCritical]
		public object GetRealObject(StreamingContext context)
		{
			return realEncoding.GetDecoder();
		}

		[SecurityCritical]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_ExecutionEngineException"));
		}
	}

	[NonSerialized]
	private int m_codePage;

	[NonSerialized]
	private bool m_isReadOnly;

	[NonSerialized]
	private bool m_deserializedFromEverett;

	[NonSerialized]
	private EncoderFallback encoderFallback;

	[NonSerialized]
	private DecoderFallback decoderFallback;

	[NonSerialized]
	private Encoding realEncoding;

	internal CodePageEncoding(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		m_codePage = (int)info.GetValue("m_codePage", typeof(int));
		try
		{
			m_isReadOnly = (bool)info.GetValue("m_isReadOnly", typeof(bool));
			encoderFallback = (EncoderFallback)info.GetValue("encoderFallback", typeof(EncoderFallback));
			decoderFallback = (DecoderFallback)info.GetValue("decoderFallback", typeof(DecoderFallback));
		}
		catch (SerializationException)
		{
			m_deserializedFromEverett = true;
			m_isReadOnly = true;
		}
	}

	[SecurityCritical]
	public object GetRealObject(StreamingContext context)
	{
		realEncoding = Encoding.GetEncoding(m_codePage);
		if (!m_deserializedFromEverett && !m_isReadOnly)
		{
			realEncoding = (Encoding)realEncoding.Clone();
			realEncoding.EncoderFallback = encoderFallback;
			realEncoding.DecoderFallback = decoderFallback;
		}
		return realEncoding;
	}

	[SecurityCritical]
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		throw new ArgumentException(Environment.GetResourceString("Arg_ExecutionEngineException"));
	}
}
