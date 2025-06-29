using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;

namespace System.Reflection;

[Serializable]
[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_Module))]
[ComVisible(true)]
[__DynamicallyInvokable]
[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
public abstract class Module : _Module, ISerializable, ICustomAttributeProvider
{
	public static readonly TypeFilter FilterTypeName;

	public static readonly TypeFilter FilterTypeNameIgnoreCase;

	private const BindingFlags DefaultLookup = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;

	[__DynamicallyInvokable]
	public virtual IEnumerable<CustomAttributeData> CustomAttributes
	{
		[__DynamicallyInvokable]
		get
		{
			return GetCustomAttributesData();
		}
	}

	public virtual int MDStreamVersion
	{
		get
		{
			RuntimeModule runtimeModule = this as RuntimeModule;
			if (runtimeModule != null)
			{
				return runtimeModule.MDStreamVersion;
			}
			throw new NotImplementedException();
		}
	}

	[__DynamicallyInvokable]
	public virtual string FullyQualifiedName
	{
		[__DynamicallyInvokable]
		get
		{
			throw new NotImplementedException();
		}
	}

	public virtual Guid ModuleVersionId
	{
		get
		{
			RuntimeModule runtimeModule = this as RuntimeModule;
			if (runtimeModule != null)
			{
				return runtimeModule.ModuleVersionId;
			}
			throw new NotImplementedException();
		}
	}

	public virtual int MetadataToken
	{
		get
		{
			RuntimeModule runtimeModule = this as RuntimeModule;
			if (runtimeModule != null)
			{
				return runtimeModule.MetadataToken;
			}
			throw new NotImplementedException();
		}
	}

	public virtual string ScopeName
	{
		get
		{
			RuntimeModule runtimeModule = this as RuntimeModule;
			if (runtimeModule != null)
			{
				return runtimeModule.ScopeName;
			}
			throw new NotImplementedException();
		}
	}

	[__DynamicallyInvokable]
	public virtual string Name
	{
		[__DynamicallyInvokable]
		get
		{
			RuntimeModule runtimeModule = this as RuntimeModule;
			if (runtimeModule != null)
			{
				return runtimeModule.Name;
			}
			throw new NotImplementedException();
		}
	}

	[__DynamicallyInvokable]
	public virtual Assembly Assembly
	{
		[__DynamicallyInvokable]
		get
		{
			RuntimeModule runtimeModule = this as RuntimeModule;
			if (runtimeModule != null)
			{
				return runtimeModule.Assembly;
			}
			throw new NotImplementedException();
		}
	}

	public ModuleHandle ModuleHandle => GetModuleHandle();

	static Module()
	{
		__Filters _Filters = new __Filters();
		FilterTypeName = _Filters.FilterTypeName;
		FilterTypeNameIgnoreCase = _Filters.FilterTypeNameIgnoreCase;
	}

	[__DynamicallyInvokable]
	public static bool operator ==(Module left, Module right)
	{
		if ((object)left == right)
		{
			return true;
		}
		if ((object)left == null || (object)right == null || left is RuntimeModule || right is RuntimeModule)
		{
			return false;
		}
		return left.Equals(right);
	}

	[__DynamicallyInvokable]
	public static bool operator !=(Module left, Module right)
	{
		return !(left == right);
	}

	[__DynamicallyInvokable]
	public override bool Equals(object o)
	{
		return base.Equals(o);
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		return ScopeName;
	}

	public virtual object[] GetCustomAttributes(bool inherit)
	{
		throw new NotImplementedException();
	}

	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		throw new NotImplementedException();
	}

	public virtual bool IsDefined(Type attributeType, bool inherit)
	{
		throw new NotImplementedException();
	}

	public virtual IList<CustomAttributeData> GetCustomAttributesData()
	{
		throw new NotImplementedException();
	}

	public MethodBase ResolveMethod(int metadataToken)
	{
		return ResolveMethod(metadataToken, null, null);
	}

	public virtual MethodBase ResolveMethod(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
	{
		RuntimeModule runtimeModule = this as RuntimeModule;
		if (runtimeModule != null)
		{
			return runtimeModule.ResolveMethod(metadataToken, genericTypeArguments, genericMethodArguments);
		}
		throw new NotImplementedException();
	}

	public FieldInfo ResolveField(int metadataToken)
	{
		return ResolveField(metadataToken, null, null);
	}

	public virtual FieldInfo ResolveField(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
	{
		RuntimeModule runtimeModule = this as RuntimeModule;
		if (runtimeModule != null)
		{
			return runtimeModule.ResolveField(metadataToken, genericTypeArguments, genericMethodArguments);
		}
		throw new NotImplementedException();
	}

	public Type ResolveType(int metadataToken)
	{
		return ResolveType(metadataToken, null, null);
	}

	public virtual Type ResolveType(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
	{
		RuntimeModule runtimeModule = this as RuntimeModule;
		if (runtimeModule != null)
		{
			return runtimeModule.ResolveType(metadataToken, genericTypeArguments, genericMethodArguments);
		}
		throw new NotImplementedException();
	}

	public MemberInfo ResolveMember(int metadataToken)
	{
		return ResolveMember(metadataToken, null, null);
	}

	public virtual MemberInfo ResolveMember(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
	{
		RuntimeModule runtimeModule = this as RuntimeModule;
		if (runtimeModule != null)
		{
			return runtimeModule.ResolveMember(metadataToken, genericTypeArguments, genericMethodArguments);
		}
		throw new NotImplementedException();
	}

	public virtual byte[] ResolveSignature(int metadataToken)
	{
		RuntimeModule runtimeModule = this as RuntimeModule;
		if (runtimeModule != null)
		{
			return runtimeModule.ResolveSignature(metadataToken);
		}
		throw new NotImplementedException();
	}

	public virtual string ResolveString(int metadataToken)
	{
		RuntimeModule runtimeModule = this as RuntimeModule;
		if (runtimeModule != null)
		{
			return runtimeModule.ResolveString(metadataToken);
		}
		throw new NotImplementedException();
	}

	public virtual void GetPEKind(out PortableExecutableKinds peKind, out ImageFileMachine machine)
	{
		RuntimeModule runtimeModule = this as RuntimeModule;
		if (runtimeModule != null)
		{
			runtimeModule.GetPEKind(out peKind, out machine);
		}
		throw new NotImplementedException();
	}

	[SecurityCritical]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		throw new NotImplementedException();
	}

	[ComVisible(true)]
	public virtual Type GetType(string className, bool ignoreCase)
	{
		return GetType(className, throwOnError: false, ignoreCase);
	}

	[ComVisible(true)]
	public virtual Type GetType(string className)
	{
		return GetType(className, throwOnError: false, ignoreCase: false);
	}

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public virtual Type GetType(string className, bool throwOnError, bool ignoreCase)
	{
		throw new NotImplementedException();
	}

	public virtual Type[] FindTypes(TypeFilter filter, object filterCriteria)
	{
		Type[] types = GetTypes();
		int num = 0;
		for (int i = 0; i < types.Length; i++)
		{
			if (filter != null && !filter(types[i], filterCriteria))
			{
				types[i] = null;
			}
			else
			{
				num++;
			}
		}
		if (num == types.Length)
		{
			return types;
		}
		Type[] array = new Type[num];
		num = 0;
		for (int j = 0; j < types.Length; j++)
		{
			if (types[j] != null)
			{
				array[num++] = types[j];
			}
		}
		return array;
	}

	public virtual Type[] GetTypes()
	{
		throw new NotImplementedException();
	}

	public virtual bool IsResource()
	{
		RuntimeModule runtimeModule = this as RuntimeModule;
		if (runtimeModule != null)
		{
			return runtimeModule.IsResource();
		}
		throw new NotImplementedException();
	}

	public FieldInfo[] GetFields()
	{
		return GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
	}

	public virtual FieldInfo[] GetFields(BindingFlags bindingFlags)
	{
		RuntimeModule runtimeModule = this as RuntimeModule;
		if (runtimeModule != null)
		{
			return runtimeModule.GetFields(bindingFlags);
		}
		throw new NotImplementedException();
	}

	public FieldInfo GetField(string name)
	{
		return GetField(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
	}

	public virtual FieldInfo GetField(string name, BindingFlags bindingAttr)
	{
		RuntimeModule runtimeModule = this as RuntimeModule;
		if (runtimeModule != null)
		{
			return runtimeModule.GetField(name, bindingAttr);
		}
		throw new NotImplementedException();
	}

	public MethodInfo[] GetMethods()
	{
		return GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
	}

	public virtual MethodInfo[] GetMethods(BindingFlags bindingFlags)
	{
		RuntimeModule runtimeModule = this as RuntimeModule;
		if (runtimeModule != null)
		{
			return runtimeModule.GetMethods(bindingFlags);
		}
		throw new NotImplementedException();
	}

	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		for (int i = 0; i < types.Length; i++)
		{
			if (types[i] == null)
			{
				throw new ArgumentNullException("types");
			}
		}
		return GetMethodImpl(name, bindingAttr, binder, callConvention, types, modifiers);
	}

	public MethodInfo GetMethod(string name, Type[] types)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		for (int i = 0; i < types.Length; i++)
		{
			if (types[i] == null)
			{
				throw new ArgumentNullException("types");
			}
		}
		return GetMethodImpl(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, CallingConventions.Any, types, null);
	}

	public MethodInfo GetMethod(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return GetMethodImpl(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, CallingConventions.Any, null, null);
	}

	protected virtual MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		throw new NotImplementedException();
	}

	internal virtual ModuleHandle GetModuleHandle()
	{
		return ModuleHandle.EmptyHandle;
	}

	public virtual X509Certificate GetSignerCertificate()
	{
		throw new NotImplementedException();
	}

	void _Module.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _Module.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _Module.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _Module.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}
}
