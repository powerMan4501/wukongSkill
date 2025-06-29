using System.Collections;
using System.Reflection;
using System.Security.Permissions;

namespace System.ComponentModel.Design.Serialization;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
public sealed class InstanceDescriptor
{
	private MemberInfo member;

	private ICollection arguments;

	private bool isComplete;

	public ICollection Arguments => arguments;

	public bool IsComplete => isComplete;

	public MemberInfo MemberInfo => member;

	public InstanceDescriptor(MemberInfo member, ICollection arguments)
		: this(member, arguments, isComplete: true)
	{
	}

	public InstanceDescriptor(MemberInfo member, ICollection arguments, bool isComplete)
	{
		this.member = member;
		this.isComplete = isComplete;
		if (arguments == null)
		{
			this.arguments = new object[0];
		}
		else
		{
			object[] array = new object[arguments.Count];
			arguments.CopyTo(array, 0);
			this.arguments = array;
		}
		if (member is FieldInfo)
		{
			FieldInfo fieldInfo = (FieldInfo)member;
			if (!fieldInfo.IsStatic)
			{
				throw new ArgumentException(SR.GetString("InstanceDescriptorMustBeStatic"));
			}
			if (this.arguments.Count != 0)
			{
				throw new ArgumentException(SR.GetString("InstanceDescriptorLengthMismatch"));
			}
		}
		else if (member is ConstructorInfo)
		{
			ConstructorInfo constructorInfo = (ConstructorInfo)member;
			if (constructorInfo.IsStatic)
			{
				throw new ArgumentException(SR.GetString("InstanceDescriptorCannotBeStatic"));
			}
			if (this.arguments.Count != constructorInfo.GetParameters().Length)
			{
				throw new ArgumentException(SR.GetString("InstanceDescriptorLengthMismatch"));
			}
		}
		else if (member is MethodInfo)
		{
			MethodInfo methodInfo = (MethodInfo)member;
			if (!methodInfo.IsStatic)
			{
				throw new ArgumentException(SR.GetString("InstanceDescriptorMustBeStatic"));
			}
			if (this.arguments.Count != methodInfo.GetParameters().Length)
			{
				throw new ArgumentException(SR.GetString("InstanceDescriptorLengthMismatch"));
			}
		}
		else if (member is PropertyInfo)
		{
			PropertyInfo propertyInfo = (PropertyInfo)member;
			if (!propertyInfo.CanRead)
			{
				throw new ArgumentException(SR.GetString("InstanceDescriptorMustBeReadable"));
			}
			MethodInfo getMethod = propertyInfo.GetGetMethod();
			if (getMethod != null && !getMethod.IsStatic)
			{
				throw new ArgumentException(SR.GetString("InstanceDescriptorMustBeStatic"));
			}
		}
	}

	public object Invoke()
	{
		object[] array = new object[arguments.Count];
		arguments.CopyTo(array, 0);
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] is InstanceDescriptor)
			{
				array[i] = ((InstanceDescriptor)array[i]).Invoke();
			}
		}
		if (member is ConstructorInfo)
		{
			return ((ConstructorInfo)member).Invoke(array);
		}
		if (member is MethodInfo)
		{
			return ((MethodInfo)member).Invoke(null, array);
		}
		if (member is PropertyInfo)
		{
			return ((PropertyInfo)member).GetValue(null, array);
		}
		if (member is FieldInfo)
		{
			return ((FieldInfo)member).GetValue(null);
		}
		return null;
	}
}
