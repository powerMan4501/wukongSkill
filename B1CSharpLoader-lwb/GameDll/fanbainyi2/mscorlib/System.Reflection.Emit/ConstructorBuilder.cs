using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.Reflection.Emit;

[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_ConstructorBuilder))]
[ComVisible(true)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class ConstructorBuilder : ConstructorInfo, _ConstructorBuilder
{
	private readonly MethodBuilder m_methodBuilder;

	internal bool m_isDefaultConstructor;

	internal int MetadataTokenInternal => m_methodBuilder.MetadataTokenInternal;

	public override Module Module => m_methodBuilder.Module;

	public override Type ReflectedType => m_methodBuilder.ReflectedType;

	public override Type DeclaringType => m_methodBuilder.DeclaringType;

	public override string Name => m_methodBuilder.Name;

	public override MethodAttributes Attributes => m_methodBuilder.Attributes;

	public override RuntimeMethodHandle MethodHandle => m_methodBuilder.MethodHandle;

	public override CallingConventions CallingConvention
	{
		get
		{
			if (DeclaringType.IsGenericType)
			{
				return CallingConventions.HasThis;
			}
			return CallingConventions.Standard;
		}
	}

	[Obsolete("This property has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
	public Type ReturnType => GetReturnType();

	public string Signature => m_methodBuilder.Signature;

	public bool InitLocals
	{
		get
		{
			return m_methodBuilder.InitLocals;
		}
		set
		{
			m_methodBuilder.InitLocals = value;
		}
	}

	private ConstructorBuilder()
	{
	}

	[SecurityCritical]
	internal ConstructorBuilder(string name, MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes, Type[][] requiredCustomModifiers, Type[][] optionalCustomModifiers, ModuleBuilder mod, TypeBuilder type)
	{
		m_methodBuilder = new MethodBuilder(name, attributes, callingConvention, null, null, null, parameterTypes, requiredCustomModifiers, optionalCustomModifiers, mod, type, bIsGlobalMethod: false);
		type.m_listMethods.Add(m_methodBuilder);
		int length;
		byte[] array = m_methodBuilder.GetMethodSignature().InternalGetSignature(out length);
		MethodToken token = m_methodBuilder.GetToken();
	}

	[SecurityCritical]
	internal ConstructorBuilder(string name, MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes, ModuleBuilder mod, TypeBuilder type)
		: this(name, attributes, callingConvention, parameterTypes, null, null, mod, type)
	{
	}

	internal override Type[] GetParameterTypes()
	{
		return m_methodBuilder.GetParameterTypes();
	}

	private TypeBuilder GetTypeBuilder()
	{
		return m_methodBuilder.GetTypeBuilder();
	}

	internal ModuleBuilder GetModuleBuilder()
	{
		return GetTypeBuilder().GetModuleBuilder();
	}

	public override string ToString()
	{
		return m_methodBuilder.ToString();
	}

	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicModule"));
	}

	public override ParameterInfo[] GetParameters()
	{
		ConstructorInfo constructor = GetTypeBuilder().GetConstructor(m_methodBuilder.m_parameterTypes);
		return constructor.GetParameters();
	}

	public override MethodImplAttributes GetMethodImplementationFlags()
	{
		return m_methodBuilder.GetMethodImplementationFlags();
	}

	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicModule"));
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		return m_methodBuilder.GetCustomAttributes(inherit);
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return m_methodBuilder.GetCustomAttributes(attributeType, inherit);
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return m_methodBuilder.IsDefined(attributeType, inherit);
	}

	public MethodToken GetToken()
	{
		return m_methodBuilder.GetToken();
	}

	public ParameterBuilder DefineParameter(int iSequence, ParameterAttributes attributes, string strParamName)
	{
		attributes &= ~ParameterAttributes.ReservedMask;
		return m_methodBuilder.DefineParameter(iSequence, attributes, strParamName);
	}

	public void SetSymCustomAttribute(string name, byte[] data)
	{
		m_methodBuilder.SetSymCustomAttribute(name, data);
	}

	public ILGenerator GetILGenerator()
	{
		if (m_isDefaultConstructor)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_DefaultConstructorILGen"));
		}
		return m_methodBuilder.GetILGenerator();
	}

	public ILGenerator GetILGenerator(int streamSize)
	{
		if (m_isDefaultConstructor)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_DefaultConstructorILGen"));
		}
		return m_methodBuilder.GetILGenerator(streamSize);
	}

	public void SetMethodBody(byte[] il, int maxStack, byte[] localSignature, IEnumerable<ExceptionHandler> exceptionHandlers, IEnumerable<int> tokenFixups)
	{
		if (m_isDefaultConstructor)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_DefaultConstructorDefineBody"));
		}
		m_methodBuilder.SetMethodBody(il, maxStack, localSignature, exceptionHandlers, tokenFixups);
	}

	[SecuritySafeCritical]
	public void AddDeclarativeSecurity(SecurityAction action, PermissionSet pset)
	{
		if (pset == null)
		{
			throw new ArgumentNullException("pset");
		}
		if (!Enum.IsDefined(typeof(SecurityAction), action) || action == SecurityAction.RequestMinimum || action == SecurityAction.RequestOptional || action == SecurityAction.RequestRefuse)
		{
			throw new ArgumentOutOfRangeException("action");
		}
		if (m_methodBuilder.IsTypeCreated())
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_TypeHasBeenCreated"));
		}
		byte[] array = pset.EncodeXml();
		TypeBuilder.AddDeclarativeSecurity(GetModuleBuilder().GetNativeHandle(), GetToken().Token, action, array, array.Length);
	}

	public Module GetModule()
	{
		return m_methodBuilder.GetModule();
	}

	internal override Type GetReturnType()
	{
		return m_methodBuilder.ReturnType;
	}

	[ComVisible(true)]
	public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
	{
		m_methodBuilder.SetCustomAttribute(con, binaryAttribute);
	}

	public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
	{
		m_methodBuilder.SetCustomAttribute(customBuilder);
	}

	public void SetImplementationFlags(MethodImplAttributes attributes)
	{
		m_methodBuilder.SetImplementationFlags(attributes);
	}

	void _ConstructorBuilder.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _ConstructorBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _ConstructorBuilder.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _ConstructorBuilder.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}
}
