using System.Collections;
using System.Reflection;
using System.Reflection.Emit;

namespace System.Runtime.InteropServices.TCEAdapterGen;

internal class TCEAdapterGenerator
{
	private ModuleBuilder m_Module;

	private Hashtable m_SrcItfToSrcItfInfoMap = new Hashtable();

	private static volatile CustomAttributeBuilder s_NoClassItfCABuilder;

	private static volatile CustomAttributeBuilder s_HiddenCABuilder;

	public void Process(ModuleBuilder ModBldr, ArrayList EventItfList)
	{
		m_Module = ModBldr;
		int count = EventItfList.Count;
		for (int i = 0; i < count; i++)
		{
			EventItfInfo eventItfInfo = (EventItfInfo)EventItfList[i];
			Type eventItfType = eventItfInfo.GetEventItfType();
			Type srcItfType = eventItfInfo.GetSrcItfType();
			string eventProviderName = eventItfInfo.GetEventProviderName();
			Type sinkHelperType = new EventSinkHelperWriter(m_Module, srcItfType, eventItfType).Perform();
			new EventProviderWriter(m_Module, eventProviderName, eventItfType, srcItfType, sinkHelperType).Perform();
		}
	}

	internal static void SetClassInterfaceTypeToNone(TypeBuilder tb)
	{
		if (s_NoClassItfCABuilder == null)
		{
			Type[] types = new Type[1] { typeof(ClassInterfaceType) };
			ConstructorInfo constructor = typeof(ClassInterfaceAttribute).GetConstructor(types);
			s_NoClassItfCABuilder = new CustomAttributeBuilder(constructor, new object[1] { ClassInterfaceType.None });
		}
		tb.SetCustomAttribute(s_NoClassItfCABuilder);
	}

	internal static TypeBuilder DefineUniqueType(string strInitFullName, TypeAttributes attrs, Type BaseType, Type[] aInterfaceTypes, ModuleBuilder mb)
	{
		string text = strInitFullName;
		int num = 2;
		while (mb.GetType(text) != null)
		{
			text = strInitFullName + "_" + num;
			num++;
		}
		return mb.DefineType(text, attrs, BaseType, aInterfaceTypes);
	}

	internal static void SetHiddenAttribute(TypeBuilder tb)
	{
		if (s_HiddenCABuilder == null)
		{
			Type[] types = new Type[1] { typeof(TypeLibTypeFlags) };
			ConstructorInfo constructor = typeof(TypeLibTypeAttribute).GetConstructor(types);
			s_HiddenCABuilder = new CustomAttributeBuilder(constructor, new object[1] { TypeLibTypeFlags.FHidden });
		}
		tb.SetCustomAttribute(s_HiddenCABuilder);
	}

	internal static MethodInfo[] GetNonPropertyMethods(Type type)
	{
		MethodInfo[] methods = type.GetMethods();
		ArrayList arrayList = new ArrayList(methods);
		PropertyInfo[] properties = type.GetProperties();
		PropertyInfo[] array = properties;
		foreach (PropertyInfo propertyInfo in array)
		{
			MethodInfo[] accessors = propertyInfo.GetAccessors();
			MethodInfo[] array2 = accessors;
			foreach (MethodInfo methodInfo in array2)
			{
				for (int k = 0; k < arrayList.Count; k++)
				{
					if ((MethodInfo)arrayList[k] == methodInfo)
					{
						arrayList.RemoveAt(k);
					}
				}
			}
		}
		MethodInfo[] array3 = new MethodInfo[arrayList.Count];
		arrayList.CopyTo(array3);
		return array3;
	}

	internal static MethodInfo[] GetPropertyMethods(Type type)
	{
		MethodInfo[] methods = type.GetMethods();
		ArrayList arrayList = new ArrayList();
		PropertyInfo[] properties = type.GetProperties();
		PropertyInfo[] array = properties;
		foreach (PropertyInfo propertyInfo in array)
		{
			MethodInfo[] accessors = propertyInfo.GetAccessors();
			MethodInfo[] array2 = accessors;
			foreach (MethodInfo value in array2)
			{
				arrayList.Add(value);
			}
		}
		MethodInfo[] array3 = new MethodInfo[arrayList.Count];
		arrayList.CopyTo(array3);
		return array3;
	}
}
