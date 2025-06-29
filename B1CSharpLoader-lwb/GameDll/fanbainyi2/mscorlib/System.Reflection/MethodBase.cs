using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;

namespace System.Reflection;

[Serializable]
[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_MethodBase))]
[ComVisible(true)]
[__DynamicallyInvokable]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public abstract class MethodBase : MemberInfo, _MethodBase
{
	internal virtual bool IsDynamicallyInvokable
	{
		[__DynamicallyInvokable]
		get
		{
			return true;
		}
	}

	[__DynamicallyInvokable]
	public virtual MethodImplAttributes MethodImplementationFlags
	{
		[__DynamicallyInvokable]
		get
		{
			return GetMethodImplementationFlags();
		}
	}

	[__DynamicallyInvokable]
	public abstract RuntimeMethodHandle MethodHandle
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public abstract MethodAttributes Attributes
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public virtual CallingConventions CallingConvention
	{
		[__DynamicallyInvokable]
		get
		{
			return CallingConventions.Standard;
		}
	}

	[__DynamicallyInvokable]
	public virtual bool IsGenericMethodDefinition
	{
		[__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[__DynamicallyInvokable]
	public virtual bool ContainsGenericParameters
	{
		[__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[__DynamicallyInvokable]
	public virtual bool IsGenericMethod
	{
		[__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	public virtual bool IsSecurityCritical
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public virtual bool IsSecuritySafeCritical
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public virtual bool IsSecurityTransparent
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	[__DynamicallyInvokable]
	public bool IsPublic
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Public;
		}
	}

	[__DynamicallyInvokable]
	public bool IsPrivate
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Private;
		}
	}

	[__DynamicallyInvokable]
	public bool IsFamily
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Family;
		}
	}

	[__DynamicallyInvokable]
	public bool IsAssembly
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Assembly;
		}
	}

	[__DynamicallyInvokable]
	public bool IsFamilyAndAssembly
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.FamANDAssem;
		}
	}

	[__DynamicallyInvokable]
	public bool IsFamilyOrAssembly
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.FamORAssem;
		}
	}

	[__DynamicallyInvokable]
	public bool IsStatic
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & MethodAttributes.Static) != 0;
		}
	}

	[__DynamicallyInvokable]
	public bool IsFinal
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & MethodAttributes.Final) != 0;
		}
	}

	[__DynamicallyInvokable]
	public bool IsVirtual
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & MethodAttributes.Virtual) != 0;
		}
	}

	[__DynamicallyInvokable]
	public bool IsHideBySig
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & MethodAttributes.HideBySig) != 0;
		}
	}

	[__DynamicallyInvokable]
	public bool IsAbstract
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & MethodAttributes.Abstract) != 0;
		}
	}

	[__DynamicallyInvokable]
	public bool IsSpecialName
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & MethodAttributes.SpecialName) != 0;
		}
	}

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public bool IsConstructor
	{
		[__DynamicallyInvokable]
		get
		{
			if (this is ConstructorInfo && !IsStatic)
			{
				return (Attributes & MethodAttributes.RTSpecialName) == MethodAttributes.RTSpecialName;
			}
			return false;
		}
	}

	internal string FullName => $"{DeclaringType.FullName}.{FormatNameAndSig()}";

	bool _MethodBase.IsPublic => IsPublic;

	bool _MethodBase.IsPrivate => IsPrivate;

	bool _MethodBase.IsFamily => IsFamily;

	bool _MethodBase.IsAssembly => IsAssembly;

	bool _MethodBase.IsFamilyAndAssembly => IsFamilyAndAssembly;

	bool _MethodBase.IsFamilyOrAssembly => IsFamilyOrAssembly;

	bool _MethodBase.IsStatic => IsStatic;

	bool _MethodBase.IsFinal => IsFinal;

	bool _MethodBase.IsVirtual => IsVirtual;

	bool _MethodBase.IsHideBySig => IsHideBySig;

	bool _MethodBase.IsAbstract => IsAbstract;

	bool _MethodBase.IsSpecialName => IsSpecialName;

	bool _MethodBase.IsConstructor => IsConstructor;

	[__DynamicallyInvokable]
	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle)
	{
		if (handle.IsNullHandle())
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidHandle"));
		}
		MethodBase methodBase = RuntimeType.GetMethodBase(handle.GetMethodInfo());
		Type declaringType = methodBase.DeclaringType;
		if (declaringType != null && declaringType.IsGenericType)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_MethodDeclaringTypeGeneric"), methodBase, declaringType.GetGenericTypeDefinition()));
		}
		return methodBase;
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle, RuntimeTypeHandle declaringType)
	{
		if (handle.IsNullHandle())
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidHandle"));
		}
		return RuntimeType.GetMethodBase(declaringType.GetRuntimeType(), handle.GetMethodInfo());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MethodBase GetCurrentMethod()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeMethodInfo.InternalGetCurrentMethod(ref stackMark);
	}

	[__DynamicallyInvokable]
	public static bool operator ==(MethodBase left, MethodBase right)
	{
		if ((object)left == right)
		{
			return true;
		}
		if ((object)left == null || (object)right == null)
		{
			return false;
		}
		MethodInfo methodInfo;
		MethodInfo methodInfo2;
		if ((methodInfo = left as MethodInfo) != null && (methodInfo2 = right as MethodInfo) != null)
		{
			return methodInfo == methodInfo2;
		}
		ConstructorInfo constructorInfo;
		ConstructorInfo constructorInfo2;
		if ((constructorInfo = left as ConstructorInfo) != null && (constructorInfo2 = right as ConstructorInfo) != null)
		{
			return constructorInfo == constructorInfo2;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public static bool operator !=(MethodBase left, MethodBase right)
	{
		return !(left == right);
	}

	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		return base.Equals(obj);
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	[SecurityCritical]
	private IntPtr GetMethodDesc()
	{
		return MethodHandle.Value;
	}

	internal virtual ParameterInfo[] GetParametersNoCopy()
	{
		return GetParameters();
	}

	[__DynamicallyInvokable]
	public abstract ParameterInfo[] GetParameters();

	public abstract MethodImplAttributes GetMethodImplementationFlags();

	public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public virtual Type[] GetGenericArguments()
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_SubclassOverride"));
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[__DynamicallyInvokable]
	public object Invoke(object obj, object[] parameters)
	{
		return Invoke(obj, BindingFlags.Default, null, parameters, null);
	}

	[SecuritySafeCritical]
	[ReflectionPermission(SecurityAction.Demand, Flags = ReflectionPermissionFlag.MemberAccess)]
	public virtual MethodBody GetMethodBody()
	{
		throw new InvalidOperationException();
	}

	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string value = "";
		foreach (Type type in parameterTypes)
		{
			stringBuilder.Append(value);
			string text = type.FormatTypeName(serialization);
			if (type.IsByRef && !serialization)
			{
				stringBuilder.Append(text.TrimEnd('&'));
				stringBuilder.Append(" ByRef");
			}
			else
			{
				stringBuilder.Append(text);
			}
			value = ", ";
		}
		if ((callingConvention & CallingConventions.VarArgs) == CallingConventions.VarArgs)
		{
			stringBuilder.Append(value);
			stringBuilder.Append("...");
		}
		return stringBuilder.ToString();
	}

	internal string FormatNameAndSig()
	{
		return FormatNameAndSig(serialization: false);
	}

	internal virtual string FormatNameAndSig(bool serialization)
	{
		StringBuilder stringBuilder = new StringBuilder(Name);
		stringBuilder.Append("(");
		stringBuilder.Append(ConstructParameters(GetParameterTypes(), CallingConvention, serialization));
		stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	internal virtual Type[] GetParameterTypes()
	{
		ParameterInfo[] parametersNoCopy = GetParametersNoCopy();
		Type[] array = new Type[parametersNoCopy.Length];
		for (int i = 0; i < parametersNoCopy.Length; i++)
		{
			array[i] = parametersNoCopy[i].ParameterType;
		}
		return array;
	}

	[SecuritySafeCritical]
	internal object[] CheckArguments(object[] parameters, Binder binder, BindingFlags invokeAttr, CultureInfo culture, Signature sig)
	{
		object[] array = new object[parameters.Length];
		ParameterInfo[] array2 = null;
		for (int i = 0; i < parameters.Length; i++)
		{
			object obj = parameters[i];
			RuntimeType runtimeType = sig.Arguments[i];
			if (obj == Type.Missing)
			{
				if (array2 == null)
				{
					array2 = GetParametersNoCopy();
				}
				if (array2[i].DefaultValue == DBNull.Value)
				{
					throw new ArgumentException(Environment.GetResourceString("Arg_VarMissNull"), "parameters");
				}
				obj = array2[i].DefaultValue;
			}
			array[i] = runtimeType.CheckValue(obj, binder, culture, invokeAttr);
		}
		return array;
	}

	Type _MethodBase.GetType()
	{
		return GetType();
	}

	void _MethodBase.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _MethodBase.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _MethodBase.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _MethodBase.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}
}
