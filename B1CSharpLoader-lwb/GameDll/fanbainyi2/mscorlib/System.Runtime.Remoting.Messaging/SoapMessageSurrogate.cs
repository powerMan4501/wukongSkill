using System.Reflection;
using System.Runtime.Remoting.Metadata;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Security;
using System.Text;

namespace System.Runtime.Remoting.Messaging;

internal class SoapMessageSurrogate : ISerializationSurrogate
{
	private static Type _voidType = typeof(void);

	private static Type _soapFaultType = typeof(SoapFault);

	private string DefaultFakeRecordAssemblyName = "http://schemas.microsoft.com/urt/SystemRemotingSoapTopRecord";

	private object _rootObj;

	[SecurityCritical]
	private RemotingSurrogateSelector _ss;

	[SecurityCritical]
	internal SoapMessageSurrogate(RemotingSurrogateSelector ss)
	{
		_ss = ss;
	}

	internal void SetRootObject(object obj)
	{
		_rootObj = obj;
	}

	[SecurityCritical]
	internal virtual string[] GetInArgNames(IMethodCallMessage m, int c)
	{
		string[] array = new string[c];
		for (int i = 0; i < c; i++)
		{
			string text = m.GetInArgName(i);
			if (text == null)
			{
				text = "__param" + i;
			}
			array[i] = text;
		}
		return array;
	}

	[SecurityCritical]
	internal virtual string[] GetNames(IMethodCallMessage m, int c)
	{
		string[] array = new string[c];
		for (int i = 0; i < c; i++)
		{
			string text = m.GetArgName(i);
			if (text == null)
			{
				text = "__param" + i;
			}
			array[i] = text;
		}
		return array;
	}

	[SecurityCritical]
	public virtual void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		if (obj != null && obj != _rootObj)
		{
			new MessageSurrogate(_ss).GetObjectData(obj, info, context);
		}
		else if (obj is IMethodReturnMessage methodReturnMessage)
		{
			if (methodReturnMessage.Exception == null)
			{
				MethodBase methodBase = methodReturnMessage.MethodBase;
				SoapMethodAttribute soapMethodAttribute = (SoapMethodAttribute)InternalRemotingServices.GetCachedSoapAttribute(methodBase);
				string responseXmlElementName = soapMethodAttribute.ResponseXmlElementName;
				string responseXmlNamespace = soapMethodAttribute.ResponseXmlNamespace;
				string returnXmlElementName = soapMethodAttribute.ReturnXmlElementName;
				ArgMapper argMapper = new ArgMapper(methodReturnMessage, fOut: true);
				object[] args = argMapper.Args;
				info.FullTypeName = responseXmlElementName;
				info.AssemblyName = responseXmlNamespace;
				Type returnType = ((MethodInfo)methodBase).ReturnType;
				if (!(returnType == null) && !(returnType == _voidType))
				{
					info.AddValue(returnXmlElementName, methodReturnMessage.ReturnValue, returnType);
				}
				if (args == null)
				{
					return;
				}
				Type[] argTypes = argMapper.ArgTypes;
				for (int i = 0; i < args.Length; i++)
				{
					string text = argMapper.GetArgName(i);
					if (text == null || text.Length == 0)
					{
						text = "__param" + i;
					}
					info.AddValue(text, args[i], argTypes[i].IsByRef ? argTypes[i].GetElementType() : argTypes[i]);
				}
				return;
			}
			object data = CallContext.GetData("__ClientIsClr");
			bool flag = data == null || (bool)data;
			info.FullTypeName = "FormatterWrapper";
			info.AssemblyName = DefaultFakeRecordAssemblyName;
			Exception ex = methodReturnMessage.Exception;
			StringBuilder stringBuilder = new StringBuilder();
			bool flag2 = false;
			while (ex != null)
			{
				if (ex.Message.StartsWith("MustUnderstand", StringComparison.Ordinal))
				{
					flag2 = true;
				}
				stringBuilder.Append(" **** ");
				stringBuilder.Append(ex.GetType().FullName);
				stringBuilder.Append(" - ");
				stringBuilder.Append(ex.Message);
				ex = ex.InnerException;
			}
			ServerFault serverFault = null;
			serverFault = ((!flag) ? new ServerFault(methodReturnMessage.Exception.GetType().AssemblyQualifiedName, stringBuilder.ToString(), methodReturnMessage.Exception.StackTrace) : new ServerFault(methodReturnMessage.Exception));
			string faultCode = "Server";
			if (flag2)
			{
				faultCode = "MustUnderstand";
			}
			SoapFault value = new SoapFault(faultCode, stringBuilder.ToString(), null, serverFault);
			info.AddValue("__WrappedObject", value, _soapFaultType);
		}
		else
		{
			IMethodCallMessage methodCallMessage = (IMethodCallMessage)obj;
			MethodBase methodBase2 = methodCallMessage.MethodBase;
			string xmlNamespaceForMethodCall = SoapServices.GetXmlNamespaceForMethodCall(methodBase2);
			object[] inArgs = methodCallMessage.InArgs;
			string[] inArgNames = GetInArgNames(methodCallMessage, inArgs.Length);
			Type[] array = (Type[])methodCallMessage.MethodSignature;
			info.FullTypeName = methodCallMessage.MethodName;
			info.AssemblyName = xmlNamespaceForMethodCall;
			RemotingMethodCachedData reflectionCachedData = InternalRemotingServices.GetReflectionCachedData(methodBase2);
			int[] marshalRequestArgMap = reflectionCachedData.MarshalRequestArgMap;
			for (int j = 0; j < inArgs.Length; j++)
			{
				string text2 = null;
				text2 = ((inArgNames[j] != null && inArgNames[j].Length != 0) ? inArgNames[j] : ("__param" + j));
				int num = marshalRequestArgMap[j];
				Type type = null;
				info.AddValue(type: (!array[num].IsByRef) ? array[num] : array[num].GetElementType(), name: text2, value: inArgs[j]);
			}
		}
	}

	[SecurityCritical]
	public virtual object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_PopulateData"));
	}
}
