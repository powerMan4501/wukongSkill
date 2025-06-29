using System.Threading;

namespace System.Text;

[Serializable]
[__DynamicallyInvokable]
public abstract class DecoderFallback
{
	internal bool bIsMicrosoftBestFitFallback;

	private static volatile DecoderFallback replacementFallback;

	private static volatile DecoderFallback exceptionFallback;

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
	public static DecoderFallback ReplacementFallback
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
						replacementFallback = new DecoderReplacementFallback();
					}
				}
			}
			return replacementFallback;
		}
	}

	[__DynamicallyInvokable]
	public static DecoderFallback ExceptionFallback
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
						exceptionFallback = new DecoderExceptionFallback();
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

	internal bool IsMicrosoftBestFitFallback => bIsMicrosoftBestFitFallback;

	[__DynamicallyInvokable]
	public abstract DecoderFallbackBuffer CreateFallbackBuffer();

	[__DynamicallyInvokable]
	protected DecoderFallback()
	{
	}
}
