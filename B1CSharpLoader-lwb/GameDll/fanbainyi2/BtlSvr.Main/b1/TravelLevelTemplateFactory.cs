using System.Collections.Generic;

namespace b1;

public static class TravelLevelTemplateFactory
{
	private static readonly Dictionary<EGlobalTravelLevelType, TravelLevelTemplateBase> StaticCreateTravelTemplateFuncMap = new Dictionary<EGlobalTravelLevelType, TravelLevelTemplateBase>();

	public static void Register(EGlobalTravelLevelType TravelLevelType, TravelLevelTemplateBase Template)
	{
		StaticCreateTravelTemplateFuncMap[TravelLevelType] = Template;
	}

	public static TravelLevelTemplateBase GetTemplate(EGlobalTravelLevelType TravelLevelType)
	{
		if (StaticCreateTravelTemplateFuncMap.TryGetValue(TravelLevelType, out var value))
		{
			return value;
		}
		return null;
	}
}
