using System.Security;
using System.Threading;

namespace System.Runtime.Versioning;

internal static class MultitargetingHelpers
{
	private static Func<Type, string> defaultConverter = (Type t) => t.AssemblyQualifiedName;

	internal static string GetAssemblyQualifiedName(Type type, Func<Type, string> converter)
	{
		string text = null;
		if (type != null)
		{
			if (converter != null)
			{
				try
				{
					text = converter(type);
				}
				catch (Exception ex)
				{
					if (IsSecurityOrCriticalException(ex))
					{
						throw;
					}
				}
			}
			if (text == null)
			{
				text = defaultConverter(type);
			}
		}
		return text;
	}

	private static bool IsCriticalException(Exception ex)
	{
		if (!(ex is NullReferenceException) && !(ex is StackOverflowException) && !(ex is OutOfMemoryException) && !(ex is ThreadAbortException) && !(ex is IndexOutOfRangeException))
		{
			return ex is AccessViolationException;
		}
		return true;
	}

	private static bool IsSecurityOrCriticalException(Exception ex)
	{
		if (!(ex is SecurityException))
		{
			return IsCriticalException(ex);
		}
		return true;
	}
}
