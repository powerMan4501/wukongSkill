using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;
using System.Security;
using System.Text;

namespace System.Runtime.Remoting;

[SecurityCritical]
[ComVisible(true)]
public class SoapServices
{
	private class XmlEntry
	{
		public string Name;

		public string Namespace;

		public XmlEntry(string name, string xmlNamespace)
		{
			Name = name;
			Namespace = xmlNamespace;
		}
	}

	private class XmlToFieldTypeMap
	{
		private class FieldEntry
		{
			public Type Type;

			public string Name;

			public FieldEntry(Type type, string name)
			{
				Type = type;
				Name = name;
			}
		}

		private Hashtable _attributes = new Hashtable();

		private Hashtable _elements = new Hashtable();

		[SecurityCritical]
		public void AddXmlElement(Type fieldType, string fieldName, string xmlElement, string xmlNamespace)
		{
			_elements[CreateKey(xmlElement, xmlNamespace)] = new FieldEntry(fieldType, fieldName);
		}

		[SecurityCritical]
		public void AddXmlAttribute(Type fieldType, string fieldName, string xmlAttribute, string xmlNamespace)
		{
			_attributes[CreateKey(xmlAttribute, xmlNamespace)] = new FieldEntry(fieldType, fieldName);
		}

		[SecurityCritical]
		public void GetFieldTypeAndNameFromXmlElement(string xmlElement, string xmlNamespace, out Type type, out string name)
		{
			FieldEntry fieldEntry = (FieldEntry)_elements[CreateKey(xmlElement, xmlNamespace)];
			if (fieldEntry != null)
			{
				type = fieldEntry.Type;
				name = fieldEntry.Name;
			}
			else
			{
				type = null;
				name = null;
			}
		}

		[SecurityCritical]
		public void GetFieldTypeAndNameFromXmlAttribute(string xmlAttribute, string xmlNamespace, out Type type, out string name)
		{
			FieldEntry fieldEntry = (FieldEntry)_attributes[CreateKey(xmlAttribute, xmlNamespace)];
			if (fieldEntry != null)
			{
				type = fieldEntry.Type;
				name = fieldEntry.Name;
			}
			else
			{
				type = null;
				name = null;
			}
		}
	}

	private static Hashtable _interopXmlElementToType = Hashtable.Synchronized(new Hashtable());

	private static Hashtable _interopTypeToXmlElement = Hashtable.Synchronized(new Hashtable());

	private static Hashtable _interopXmlTypeToType = Hashtable.Synchronized(new Hashtable());

	private static Hashtable _interopTypeToXmlType = Hashtable.Synchronized(new Hashtable());

	private static Hashtable _xmlToFieldTypeMap = Hashtable.Synchronized(new Hashtable());

	private static Hashtable _methodBaseToSoapAction = Hashtable.Synchronized(new Hashtable());

	private static Hashtable _soapActionToMethodBase = Hashtable.Synchronized(new Hashtable());

	internal static string startNS = "http://schemas.microsoft.com/clr/";

	internal static string assemblyNS = "http://schemas.microsoft.com/clr/assem/";

	internal static string namespaceNS = "http://schemas.microsoft.com/clr/ns/";

	internal static string fullNS = "http://schemas.microsoft.com/clr/nsassem/";

	public static string XmlNsForClrType => startNS;

	public static string XmlNsForClrTypeWithAssembly => assemblyNS;

	public static string XmlNsForClrTypeWithNs => namespaceNS;

	public static string XmlNsForClrTypeWithNsAndAssembly => fullNS;

	private SoapServices()
	{
	}

	private static string CreateKey(string elementName, string elementNamespace)
	{
		if (elementNamespace == null)
		{
			return elementName;
		}
		return elementName + " " + elementNamespace;
	}

	[SecurityCritical]
	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type)
	{
		_interopXmlElementToType[CreateKey(xmlElement, xmlNamespace)] = type;
		_interopTypeToXmlElement[type] = new XmlEntry(xmlElement, xmlNamespace);
	}

	[SecurityCritical]
	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type)
	{
		_interopXmlTypeToType[CreateKey(xmlType, xmlTypeNamespace)] = type;
		_interopTypeToXmlType[type] = new XmlEntry(xmlType, xmlTypeNamespace);
	}

	[SecurityCritical]
	public static void PreLoad(Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (!(type is RuntimeType))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"));
		}
		MethodInfo[] methods = type.GetMethods();
		MethodInfo[] array = methods;
		foreach (MethodInfo mb in array)
		{
			RegisterSoapActionForMethodBase(mb);
		}
		SoapTypeAttribute soapTypeAttribute = (SoapTypeAttribute)InternalRemotingServices.GetCachedSoapAttribute(type);
		if (soapTypeAttribute.IsInteropXmlElement())
		{
			RegisterInteropXmlElement(soapTypeAttribute.XmlElementName, soapTypeAttribute.XmlNamespace, type);
		}
		if (soapTypeAttribute.IsInteropXmlType())
		{
			RegisterInteropXmlType(soapTypeAttribute.XmlTypeName, soapTypeAttribute.XmlTypeNamespace, type);
		}
		int num = 0;
		XmlToFieldTypeMap xmlToFieldTypeMap = new XmlToFieldTypeMap();
		FieldInfo[] fields = type.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			SoapFieldAttribute soapFieldAttribute = (SoapFieldAttribute)InternalRemotingServices.GetCachedSoapAttribute(fieldInfo);
			if (soapFieldAttribute.IsInteropXmlElement())
			{
				string xmlElementName = soapFieldAttribute.XmlElementName;
				string xmlNamespace = soapFieldAttribute.XmlNamespace;
				if (soapFieldAttribute.UseAttribute)
				{
					xmlToFieldTypeMap.AddXmlAttribute(fieldInfo.FieldType, fieldInfo.Name, xmlElementName, xmlNamespace);
				}
				else
				{
					xmlToFieldTypeMap.AddXmlElement(fieldInfo.FieldType, fieldInfo.Name, xmlElementName, xmlNamespace);
				}
				num++;
			}
		}
		if (num > 0)
		{
			_xmlToFieldTypeMap[type] = xmlToFieldTypeMap;
		}
	}

	[SecurityCritical]
	public static void PreLoad(Assembly assembly)
	{
		if (assembly == null)
		{
			throw new ArgumentNullException("assembly");
		}
		if (!(assembly is RuntimeAssembly))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeAssembly"), "assembly");
		}
		Type[] types = assembly.GetTypes();
		Type[] array = types;
		foreach (Type type in array)
		{
			PreLoad(type);
		}
	}

	[SecurityCritical]
	public static Type GetInteropTypeFromXmlElement(string xmlElement, string xmlNamespace)
	{
		return (Type)_interopXmlElementToType[CreateKey(xmlElement, xmlNamespace)];
	}

	[SecurityCritical]
	public static Type GetInteropTypeFromXmlType(string xmlType, string xmlTypeNamespace)
	{
		return (Type)_interopXmlTypeToType[CreateKey(xmlType, xmlTypeNamespace)];
	}

	public static void GetInteropFieldTypeAndNameFromXmlElement(Type containingType, string xmlElement, string xmlNamespace, out Type type, out string name)
	{
		if (containingType == null)
		{
			type = null;
			name = null;
			return;
		}
		XmlToFieldTypeMap xmlToFieldTypeMap = (XmlToFieldTypeMap)_xmlToFieldTypeMap[containingType];
		if (xmlToFieldTypeMap != null)
		{
			xmlToFieldTypeMap.GetFieldTypeAndNameFromXmlElement(xmlElement, xmlNamespace, out type, out name);
			return;
		}
		type = null;
		name = null;
	}

	public static void GetInteropFieldTypeAndNameFromXmlAttribute(Type containingType, string xmlAttribute, string xmlNamespace, out Type type, out string name)
	{
		if (containingType == null)
		{
			type = null;
			name = null;
			return;
		}
		XmlToFieldTypeMap xmlToFieldTypeMap = (XmlToFieldTypeMap)_xmlToFieldTypeMap[containingType];
		if (xmlToFieldTypeMap != null)
		{
			xmlToFieldTypeMap.GetFieldTypeAndNameFromXmlAttribute(xmlAttribute, xmlNamespace, out type, out name);
			return;
		}
		type = null;
		name = null;
	}

	[SecurityCritical]
	public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace)
	{
		XmlEntry xmlEntry = (XmlEntry)_interopTypeToXmlElement[type];
		if (xmlEntry != null)
		{
			xmlElement = xmlEntry.Name;
			xmlNamespace = xmlEntry.Namespace;
			return true;
		}
		SoapTypeAttribute soapTypeAttribute = (SoapTypeAttribute)InternalRemotingServices.GetCachedSoapAttribute(type);
		if (soapTypeAttribute.IsInteropXmlElement())
		{
			xmlElement = soapTypeAttribute.XmlElementName;
			xmlNamespace = soapTypeAttribute.XmlNamespace;
			return true;
		}
		xmlElement = null;
		xmlNamespace = null;
		return false;
	}

	[SecurityCritical]
	public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace)
	{
		XmlEntry xmlEntry = (XmlEntry)_interopTypeToXmlType[type];
		if (xmlEntry != null)
		{
			xmlType = xmlEntry.Name;
			xmlTypeNamespace = xmlEntry.Namespace;
			return true;
		}
		SoapTypeAttribute soapTypeAttribute = (SoapTypeAttribute)InternalRemotingServices.GetCachedSoapAttribute(type);
		if (soapTypeAttribute.IsInteropXmlType())
		{
			xmlType = soapTypeAttribute.XmlTypeName;
			xmlTypeNamespace = soapTypeAttribute.XmlTypeNamespace;
			return true;
		}
		xmlType = null;
		xmlTypeNamespace = null;
		return false;
	}

	[SecurityCritical]
	public static string GetXmlNamespaceForMethodCall(MethodBase mb)
	{
		SoapMethodAttribute soapMethodAttribute = (SoapMethodAttribute)InternalRemotingServices.GetCachedSoapAttribute(mb);
		return soapMethodAttribute.XmlNamespace;
	}

	[SecurityCritical]
	public static string GetXmlNamespaceForMethodResponse(MethodBase mb)
	{
		SoapMethodAttribute soapMethodAttribute = (SoapMethodAttribute)InternalRemotingServices.GetCachedSoapAttribute(mb);
		return soapMethodAttribute.ResponseXmlNamespace;
	}

	[SecurityCritical]
	public static void RegisterSoapActionForMethodBase(MethodBase mb)
	{
		SoapMethodAttribute soapMethodAttribute = (SoapMethodAttribute)InternalRemotingServices.GetCachedSoapAttribute(mb);
		if (soapMethodAttribute.SoapActionExplicitySet)
		{
			RegisterSoapActionForMethodBase(mb, soapMethodAttribute.SoapAction);
		}
	}

	public static void RegisterSoapActionForMethodBase(MethodBase mb, string soapAction)
	{
		if (soapAction == null)
		{
			return;
		}
		_methodBaseToSoapAction[mb] = soapAction;
		ArrayList arrayList = (ArrayList)_soapActionToMethodBase[soapAction];
		if (arrayList == null)
		{
			lock (_soapActionToMethodBase)
			{
				arrayList = ArrayList.Synchronized(new ArrayList());
				_soapActionToMethodBase[soapAction] = arrayList;
			}
		}
		arrayList.Add(mb);
	}

	[SecurityCritical]
	public static string GetSoapActionFromMethodBase(MethodBase mb)
	{
		string text = (string)_methodBaseToSoapAction[mb];
		if (text == null)
		{
			SoapMethodAttribute soapMethodAttribute = (SoapMethodAttribute)InternalRemotingServices.GetCachedSoapAttribute(mb);
			text = soapMethodAttribute.SoapAction;
		}
		return text;
	}

	[SecurityCritical]
	public static bool IsSoapActionValidForMethodBase(string soapAction, MethodBase mb)
	{
		if (mb == null)
		{
			throw new ArgumentNullException("mb");
		}
		if (soapAction[0] == '"' && soapAction[soapAction.Length - 1] == '"')
		{
			soapAction = soapAction.Substring(1, soapAction.Length - 2);
		}
		SoapMethodAttribute soapMethodAttribute = (SoapMethodAttribute)InternalRemotingServices.GetCachedSoapAttribute(mb);
		if (string.CompareOrdinal(soapMethodAttribute.SoapAction, soapAction) == 0)
		{
			return true;
		}
		string text = (string)_methodBaseToSoapAction[mb];
		if (text != null && string.CompareOrdinal(text, soapAction) == 0)
		{
			return true;
		}
		string[] array = soapAction.Split('#');
		if (array.Length == 2)
		{
			bool assemblyIncluded;
			string typeNameForSoapActionNamespace = XmlNamespaceEncoder.GetTypeNameForSoapActionNamespace(array[0], out assemblyIncluded);
			if (typeNameForSoapActionNamespace == null)
			{
				return false;
			}
			string value = array[1];
			RuntimeMethodInfo runtimeMethodInfo = mb as RuntimeMethodInfo;
			RuntimeConstructorInfo runtimeConstructorInfo = mb as RuntimeConstructorInfo;
			RuntimeModule runtimeModule;
			if (runtimeMethodInfo != null)
			{
				runtimeModule = runtimeMethodInfo.GetRuntimeModule();
			}
			else
			{
				if (!(runtimeConstructorInfo != null))
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeReflectionObject"));
				}
				runtimeModule = runtimeConstructorInfo.GetRuntimeModule();
			}
			string text2 = mb.DeclaringType.FullName;
			if (assemblyIncluded)
			{
				text2 = text2 + ", " + runtimeModule.GetRuntimeAssembly().GetSimpleName();
			}
			if (text2.Equals(typeNameForSoapActionNamespace))
			{
				return mb.Name.Equals(value);
			}
			return false;
		}
		return false;
	}

	public static bool GetTypeAndMethodNameFromSoapAction(string soapAction, out string typeName, out string methodName)
	{
		if (soapAction[0] == '"' && soapAction[soapAction.Length - 1] == '"')
		{
			soapAction = soapAction.Substring(1, soapAction.Length - 2);
		}
		ArrayList arrayList = (ArrayList)_soapActionToMethodBase[soapAction];
		if (arrayList != null)
		{
			if (arrayList.Count > 1)
			{
				typeName = null;
				methodName = null;
				return false;
			}
			MethodBase methodBase = (MethodBase)arrayList[0];
			if (methodBase != null)
			{
				RuntimeMethodInfo runtimeMethodInfo = methodBase as RuntimeMethodInfo;
				RuntimeConstructorInfo runtimeConstructorInfo = methodBase as RuntimeConstructorInfo;
				RuntimeModule runtimeModule;
				if (runtimeMethodInfo != null)
				{
					runtimeModule = runtimeMethodInfo.GetRuntimeModule();
				}
				else
				{
					if (!(runtimeConstructorInfo != null))
					{
						throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeReflectionObject"));
					}
					runtimeModule = runtimeConstructorInfo.GetRuntimeModule();
				}
				typeName = methodBase.DeclaringType.FullName + ", " + runtimeModule.GetRuntimeAssembly().GetSimpleName();
				methodName = methodBase.Name;
				return true;
			}
		}
		string[] array = soapAction.Split('#');
		if (array.Length == 2)
		{
			typeName = XmlNamespaceEncoder.GetTypeNameForSoapActionNamespace(array[0], out var _);
			if (typeName == null)
			{
				methodName = null;
				return false;
			}
			methodName = array[1];
			return true;
		}
		typeName = null;
		methodName = null;
		return false;
	}

	public static bool IsClrTypeNamespace(string namespaceString)
	{
		if (namespaceString.StartsWith(startNS, StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}

	[SecurityCritical]
	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		if (IsNameNull(typeNamespace))
		{
			if (IsNameNull(assemblyName))
			{
				throw new ArgumentNullException("typeNamespace,assemblyName");
			}
			stringBuilder.Append(assemblyNS);
			UriEncode(assemblyName, stringBuilder);
		}
		else if (IsNameNull(assemblyName))
		{
			stringBuilder.Append(namespaceNS);
			stringBuilder.Append(typeNamespace);
		}
		else
		{
			stringBuilder.Append(fullNS);
			if (typeNamespace[0] == '.')
			{
				stringBuilder.Append(typeNamespace.Substring(1));
			}
			else
			{
				stringBuilder.Append(typeNamespace);
			}
			stringBuilder.Append('/');
			UriEncode(assemblyName, stringBuilder);
		}
		return stringBuilder.ToString();
	}

	[SecurityCritical]
	public static bool DecodeXmlNamespaceForClrTypeNamespace(string inNamespace, out string typeNamespace, out string assemblyName)
	{
		if (IsNameNull(inNamespace))
		{
			throw new ArgumentNullException("inNamespace");
		}
		assemblyName = null;
		typeNamespace = "";
		if (inNamespace.StartsWith(assemblyNS, StringComparison.Ordinal))
		{
			assemblyName = UriDecode(inNamespace.Substring(assemblyNS.Length));
		}
		else if (inNamespace.StartsWith(namespaceNS, StringComparison.Ordinal))
		{
			typeNamespace = inNamespace.Substring(namespaceNS.Length);
		}
		else
		{
			if (!inNamespace.StartsWith(fullNS, StringComparison.Ordinal))
			{
				return false;
			}
			int num = inNamespace.IndexOf("/", fullNS.Length);
			typeNamespace = inNamespace.Substring(fullNS.Length, num - fullNS.Length);
			assemblyName = UriDecode(inNamespace.Substring(num + 1));
		}
		return true;
	}

	internal static void UriEncode(string value, StringBuilder sb)
	{
		if (value == null || value.Length == 0)
		{
			return;
		}
		for (int i = 0; i < value.Length; i++)
		{
			if (value[i] == ' ')
			{
				sb.Append("%20");
			}
			else if (value[i] == '=')
			{
				sb.Append("%3D");
			}
			else if (value[i] == ',')
			{
				sb.Append("%2C");
			}
			else
			{
				sb.Append(value[i]);
			}
		}
	}

	internal static string UriDecode(string value)
	{
		if (value == null || value.Length == 0)
		{
			return value;
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < value.Length; i++)
		{
			if (value[i] == '%' && value.Length - i >= 3)
			{
				if (value[i + 1] == '2' && value[i + 2] == '0')
				{
					stringBuilder.Append(' ');
					i += 2;
				}
				else if (value[i + 1] == '3' && value[i + 2] == 'D')
				{
					stringBuilder.Append('=');
					i += 2;
				}
				else if (value[i + 1] == '2' && value[i + 2] == 'C')
				{
					stringBuilder.Append(',');
					i += 2;
				}
				else
				{
					stringBuilder.Append(value[i]);
				}
			}
			else
			{
				stringBuilder.Append(value[i]);
			}
		}
		return stringBuilder.ToString();
	}

	private static bool IsNameNull(string name)
	{
		if (name == null || name.Length == 0)
		{
			return true;
		}
		return false;
	}
}
