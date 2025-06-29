using System.Reflection;
using System.Security;

namespace System.Runtime.Remoting.Metadata;

internal class RemotingTypeCachedData : RemotingCachedData
{
	private class LastCalledMethodClass
	{
		public string methodName;

		public MethodBase MB;
	}

	private RuntimeType RI;

	private LastCalledMethodClass _lastMethodCalled;

	private TypeInfo _typeInfo;

	private string _qualifiedTypeName;

	private string _assemblyName;

	private string _simpleAssemblyName;

	internal TypeInfo TypeInfo
	{
		[SecurityCritical]
		get
		{
			if (_typeInfo == null)
			{
				_typeInfo = new TypeInfo(RI);
			}
			return _typeInfo;
		}
	}

	internal string QualifiedTypeName
	{
		[SecurityCritical]
		get
		{
			if (_qualifiedTypeName == null)
			{
				_qualifiedTypeName = RemotingServices.DetermineDefaultQualifiedTypeName(RI);
			}
			return _qualifiedTypeName;
		}
	}

	internal string AssemblyName
	{
		get
		{
			if (_assemblyName == null)
			{
				_assemblyName = RI.Module.Assembly.FullName;
			}
			return _assemblyName;
		}
	}

	internal string SimpleAssemblyName
	{
		[SecurityCritical]
		get
		{
			if (_simpleAssemblyName == null)
			{
				_simpleAssemblyName = RI.GetRuntimeAssembly().GetSimpleName();
			}
			return _simpleAssemblyName;
		}
	}

	internal RemotingTypeCachedData(RuntimeType ri)
	{
		RI = ri;
	}

	internal override SoapAttribute GetSoapAttributeNoLock()
	{
		SoapAttribute soapAttribute = null;
		object[] customAttributes = RI.GetCustomAttributes(typeof(SoapTypeAttribute), inherit: true);
		soapAttribute = ((customAttributes == null || customAttributes.Length == 0) ? new SoapTypeAttribute() : ((SoapAttribute)customAttributes[0]));
		soapAttribute.SetReflectInfo(RI);
		return soapAttribute;
	}

	internal MethodBase GetLastCalledMethod(string newMeth)
	{
		LastCalledMethodClass lastMethodCalled = _lastMethodCalled;
		if (lastMethodCalled == null)
		{
			return null;
		}
		string methodName = lastMethodCalled.methodName;
		MethodBase mB = lastMethodCalled.MB;
		if (mB == null || methodName == null)
		{
			return null;
		}
		if (methodName.Equals(newMeth))
		{
			return mB;
		}
		return null;
	}

	internal void SetLastCalledMethod(string newMethName, MethodBase newMB)
	{
		LastCalledMethodClass lastCalledMethodClass = new LastCalledMethodClass();
		lastCalledMethodClass.methodName = newMethName;
		lastCalledMethodClass.MB = newMB;
		_lastMethodCalled = lastCalledMethodClass;
	}
}
