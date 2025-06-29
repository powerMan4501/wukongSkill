using System.Threading;

namespace System.Text;

[Serializable]
[__DynamicallyInvokable]
public abstract class EncoderFallback
{
	internal bool bIsMicrosoftBestFitFallback;

	private static volatile EncoderFallback replacementFallback;

	private static volatile EncoderFallback exceptionFallback;

	private static object s_InternalSyncObject;

	private static object InternalSyncObject
	{
		get
		{
			if (s_InternalSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange<object>(ref s_InternalSyncObject, value, (object)null);
			}
			return s_InternalSyncObject;
		}
	}

	[__DynamicallyInvokable]
	public static EncoderFallback ReplacementFallback
	{
		[__DynamicallyInvokable]
		get
		{
			if (replacementFallback == null)
			{
				lock (InternalSyncObject)
				{
					if (replacementFallback == null)
					{
						replacementFallback = new EncoderReplacementFallback();
					}
				}
			}
			return replacementFallback;
		}
	}

	[__DynamicallyInvokable]
	public static EncoderFallback ExceptionFallback
	{
		[__DynamicallyInvokable]
		get
		{
			if (exceptionFallback == null)
			{
				lock (InternalSyncObject)
				{
					if (exceptionFallback == null)
					{
						exceptionFallback = new EncoderExceptionFallback();
					}
				}
			}
			return exceptionFallback;
		}
	}

	[__DynamicallyInvokable]
	public abstract int MaxCharCount
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public abstract EncoderFallbackBuffer CreateFallbackBuffer();

	[__DynamicallyInvokable]
	protected EncoderFallback()
	{
	}
}
