using System.Collections.Generic;
using System.Reflection;

namespace System.Diagnostics.Tracing;

internal sealed class TypeAnalysis
{
	internal readonly PropertyAnalysis[] properties;

	internal readonly string name;

	internal readonly EventKeywords keywords;

	internal readonly EventLevel level = (EventLevel)(-1);

	internal readonly EventOpcode opcode = (EventOpcode)(-1);

	internal readonly EventTags tags;

	public TypeAnalysis(Type dataType, EventDataAttribute eventAttrib, List<Type> recursionCheck)
	{
		IEnumerable<PropertyInfo> enumerable = Statics.GetProperties(dataType);
		List<PropertyAnalysis> list = new List<PropertyAnalysis>();
		foreach (PropertyInfo item in enumerable)
		{
			if (!Statics.HasCustomAttribute(item, typeof(EventIgnoreAttribute)) && item.CanRead && item.GetIndexParameters().Length == 0)
			{
				MethodInfo getMethod = Statics.GetGetMethod(item);
				if (!(getMethod == null) && !getMethod.IsStatic && getMethod.IsPublic)
				{
					Type propertyType = item.PropertyType;
					TraceLoggingTypeInfo typeInfoInstance = Statics.GetTypeInfoInstance(propertyType, recursionCheck);
					EventFieldAttribute customAttribute = Statics.GetCustomAttribute<EventFieldAttribute>(item);
					string text = ((customAttribute != null && customAttribute.Name != null) ? customAttribute.Name : (Statics.ShouldOverrideFieldName(item.Name) ? typeInfoInstance.Name : item.Name));
					list.Add(new PropertyAnalysis(text, getMethod, typeInfoInstance, customAttribute));
				}
			}
		}
		properties = list.ToArray();
		PropertyAnalysis[] array = properties;
		foreach (PropertyAnalysis propertyAnalysis in array)
		{
			TraceLoggingTypeInfo typeInfo = propertyAnalysis.typeInfo;
			level = (EventLevel)Statics.Combine((int)typeInfo.Level, (int)level);
			opcode = (EventOpcode)Statics.Combine((int)typeInfo.Opcode, (int)opcode);
			keywords |= typeInfo.Keywords;
			tags |= typeInfo.Tags;
		}
		if (eventAttrib != null)
		{
			level = (EventLevel)Statics.Combine((int)eventAttrib.Level, (int)level);
			opcode = (EventOpcode)Statics.Combine((int)eventAttrib.Opcode, (int)opcode);
			keywords |= eventAttrib.Keywords;
			tags |= eventAttrib.Tags;
			name = eventAttrib.Name;
		}
		if (name == null)
		{
			name = dataType.Name;
		}
	}
}
