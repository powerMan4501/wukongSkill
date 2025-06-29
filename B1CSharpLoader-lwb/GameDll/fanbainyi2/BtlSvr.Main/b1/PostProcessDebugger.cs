using System.Reflection;
using b1.Plugins.CustomLightSystem;
using UnrealEngine.Engine;

namespace b1;

internal static class PostProcessDebugger
{
	public static void PrintAll(UWorld World)
	{
		BGW_LogUtil.LogError("PostProcessDebugger Begin------------------");
		PrintAllLighting(World);
		PrintAllClsLighting(World);
		PrintAllClsLighting(World);
		PrintAllPostProcess(World);
		BGW_LogUtil.LogError("PostProcessDebugger End------------------");
	}

	public static void PrintAllLighting(UWorld World)
	{
		ADirectionalLight[] allActorsOfClass = World.GetAllActorsOfClass<ADirectionalLight>();
		foreach (ADirectionalLight aDirectionalLight in allActorsOfClass)
		{
			if (aDirectionalLight.LightComponent.Visible)
			{
				PrintObjProperties(aDirectionalLight.LightComponent, aDirectionalLight.PathName);
			}
		}
		ASkyLight[] allActorsOfClass2 = World.GetAllActorsOfClass<ASkyLight>();
		foreach (ASkyLight aSkyLight in allActorsOfClass2)
		{
			if (aSkyLight.LightComponent.Visible)
			{
				PrintObjProperties(aSkyLight.LightComponent, aSkyLight.PathName);
			}
		}
		AExponentialHeightFog[] allActorsOfClass3 = World.GetAllActorsOfClass<AExponentialHeightFog>();
		foreach (AExponentialHeightFog aExponentialHeightFog in allActorsOfClass3)
		{
			if (aExponentialHeightFog.Component.Visible)
			{
				PrintObjProperties(aExponentialHeightFog.Component, aExponentialHeightFog.PathName);
			}
		}
		AAtmosphericFog[] allActorsOfClass4 = World.GetAllActorsOfClass<AAtmosphericFog>();
		foreach (AAtmosphericFog aAtmosphericFog in allActorsOfClass4)
		{
			if (aAtmosphericFog.AtmosphericFogComponent.Visible)
			{
				PrintObjProperties(aAtmosphericFog.AtmosphericFogComponent, aAtmosphericFog.PathName);
			}
		}
	}

	public static void PrintAllClsLighting(UWorld World)
	{
		ACLSDirectionalLight[] allActorsOfClass = World.GetAllActorsOfClass<ACLSDirectionalLight>();
		foreach (ACLSDirectionalLight aCLSDirectionalLight in allActorsOfClass)
		{
			if (aCLSDirectionalLight.DirectionalLightComponent.Visible)
			{
				PrintObjProperties(aCLSDirectionalLight.DirectionalLightComponent, aCLSDirectionalLight.PathName);
			}
		}
		ACLSSkyLight[] allActorsOfClass2 = World.GetAllActorsOfClass<ACLSSkyLight>();
		foreach (ACLSSkyLight aCLSSkyLight in allActorsOfClass2)
		{
			if (aCLSSkyLight.SkyLightComponent.Visible)
			{
				PrintObjProperties(aCLSSkyLight.SkyLightComponent, aCLSSkyLight.PathName);
			}
		}
		ACLSExponentialHeightFog[] allActorsOfClass3 = World.GetAllActorsOfClass<ACLSExponentialHeightFog>();
		foreach (ACLSExponentialHeightFog aCLSExponentialHeightFog in allActorsOfClass3)
		{
			if (aCLSExponentialHeightFog.ExponentialHeightFogComponent.Visible)
			{
				PrintObjProperties(aCLSExponentialHeightFog.ExponentialHeightFogComponent, aCLSExponentialHeightFog.PathName);
			}
		}
		ACLSAtmosphericFog[] allActorsOfClass4 = World.GetAllActorsOfClass<ACLSAtmosphericFog>();
		foreach (ACLSAtmosphericFog aCLSAtmosphericFog in allActorsOfClass4)
		{
			if (aCLSAtmosphericFog.AtmosphericFogComponent.Visible)
			{
				PrintObjProperties(aCLSAtmosphericFog.AtmosphericFogComponent, aCLSAtmosphericFog.PathName);
			}
		}
	}

	private static void PrintObjProperties(object UObj, string PathName)
	{
		PropertyInfo[] properties = UObj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
		foreach (PropertyInfo propertyInfo in properties)
		{
			object value = propertyInfo.GetValue(UObj);
			if (value != null)
			{
				BGW_LogUtil.LogError("{0}.{1}:{2}", PathName, propertyInfo.Name, value.ToString());
			}
		}
	}

	private static void PrintStructProperties(object UObj, string PathName)
	{
		FieldInfo[] fields = UObj.GetType().GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			object value = fieldInfo.GetValue(UObj);
			if (value != null)
			{
				BGW_LogUtil.LogError("{0}.{1}:{2}", PathName, fieldInfo.Name, value.ToString());
			}
		}
	}

	public static void PrintAllPostProcess(UWorld World)
	{
		APostProcessVolume[] allActorsOfClass = World.GetAllActorsOfClass<APostProcessVolume>();
		foreach (APostProcessVolume aPostProcessVolume in allActorsOfClass)
		{
			if (aPostProcessVolume.Enabled)
			{
				PrintStructProperties(aPostProcessVolume.Settings, aPostProcessVolume.PathName);
			}
		}
	}

	public static void DestroyUIWS(UWorld World)
	{
	}
}
