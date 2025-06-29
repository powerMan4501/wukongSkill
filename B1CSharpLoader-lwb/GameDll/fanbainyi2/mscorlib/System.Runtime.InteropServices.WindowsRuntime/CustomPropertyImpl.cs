using System.Globalization;
using System.Reflection;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class CustomPropertyImpl : ICustomProperty
{
	private PropertyInfo m_property;

	public string Name => m_property.Name;

	public bool CanRead => m_property.GetGetMethod() != null;

	public bool CanWrite => m_property.GetSetMethod() != null;

	public Type Type => m_property.PropertyType;

	public CustomPropertyImpl(PropertyInfo propertyInfo)
	{
		if (propertyInfo == null)
		{
			throw new ArgumentNullException("propertyInfo");
		}
		m_property = propertyInfo;
	}

	public object GetValue(object target)
	{
		return InvokeInternal(target, null, getValue: true);
	}

	public object GetValue(object target, object indexValue)
	{
		return InvokeInternal(target, new object[1] { indexValue }, getValue: true);
	}

	public void SetValue(object target, object value)
	{
		InvokeInternal(target, new object[1] { value }, getValue: false);
	}

	public void SetValue(object target, object value, object indexValue)
	{
		InvokeInternal(target, new object[2] { indexValue, value }, getValue: false);
	}

	[SecuritySafeCritical]
	private object InvokeInternal(object target, object[] args, bool getValue)
	{
		if (target is IGetProxyTarget getProxyTarget)
		{
			target = getProxyTarget.GetTarget();
		}
		MethodInfo methodInfo = (getValue ? m_property.GetGetMethod(nonPublic: true) : m_property.GetSetMethod(nonPublic: true));
		if (methodInfo == null)
		{
			throw new ArgumentException(Environment.GetResourceString(getValue ? "Arg_GetMethNotFnd" : "Arg_SetMethNotFnd"));
		}
		if (!methodInfo.IsPublic)
		{
			throw new MethodAccessException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Arg_MethodAccessException_WithMethodName"), methodInfo.ToString(), methodInfo.DeclaringType.FullName));
		}
		RuntimeMethodInfo runtimeMethodInfo = methodInfo as RuntimeMethodInfo;
		if (runtimeMethodInfo == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeMethodInfo"));
		}
		return runtimeMethodInfo.UnsafeInvoke(target, BindingFlags.Default, null, args, null);
	}
}
