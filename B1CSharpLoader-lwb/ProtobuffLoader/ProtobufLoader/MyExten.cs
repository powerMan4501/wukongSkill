using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using b1;
using b1.BGW;
using Google.Protobuf;
using LitJson;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace ProtobufLoader;

public static class MyExten
{
	private static UWorld? world;

	public static string Name => "ProtobufLoader";

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool SetConsoleOutputCP(uint wCodePageID);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool SetConsoleCP(uint wCodePageID);

	public static void EnableCNInConsole()
	{
		SetConsoleCP(65001u);
		SetConsoleOutputCP(65001u);
		Log("将控制台代码页设置为UTF8!! 开启控制台中文输出");
	}

	public static void AddOrIgnore(this Dictionary<Type, Dictionary<int, IMessage?>> obj, Type t, int id, IMessage? value)
	{
		if (!obj.ContainsKey(t))
		{
			obj.Add(t, new Dictionary<int, IMessage>());
		}
		if (!obj[t].ContainsKey(id))
		{
			obj[t].Add(id, value);
		}
	}

	public static FieldType? GetFieldOrProperty<FieldType>(this object obj, string field_name) where FieldType : class
	{
		Type type = obj.GetType();
		FieldInfo field = type.GetField(field_name, BindingFlags.Instance | BindingFlags.NonPublic);
		if ((object)field == null)
		{
			field = type.GetField(field_name, BindingFlags.Instance | BindingFlags.Public);
		}
		if ((object)field == null)
		{
			field = type.GetField(field_name, BindingFlags.Static | BindingFlags.NonPublic);
		}
		if ((object)field == null)
		{
			field = type.GetField(field_name, BindingFlags.Static | BindingFlags.Public);
		}
		if ((object)field != null)
		{
			return field.GetValue(obj) as FieldType;
		}
		PropertyInfo property = type.GetProperty(field_name, BindingFlags.Instance | BindingFlags.NonPublic);
		if ((object)property == null)
		{
			property = type.GetProperty(field_name, BindingFlags.Instance | BindingFlags.Public);
		}
		if ((object)property == null)
		{
			property = type.GetProperty(field_name, BindingFlags.Static | BindingFlags.NonPublic);
		}
		if ((object)property == null)
		{
			property = type.GetProperty(field_name, BindingFlags.Static | BindingFlags.Public);
		}
		if ((object)property != null)
		{
			return property.GetValue(obj) as FieldType;
		}
		Console.WriteLine(Name + " Fatal Error: Can't Find " + field_name);
		return null;
	}

	public static Type? GetFieldOrPropertyType(this object obj, string field_name)
	{
		Type type = obj.GetType();
		FieldInfo field = type.GetField(field_name, BindingFlags.Instance | BindingFlags.NonPublic);
		if ((object)field == null)
		{
			field = type.GetField(field_name, BindingFlags.Instance | BindingFlags.Public);
		}
		if ((object)field == null)
		{
			field = type.GetField(field_name, BindingFlags.Static | BindingFlags.NonPublic);
		}
		if ((object)field == null)
		{
			field = type.GetField(field_name, BindingFlags.Static | BindingFlags.Public);
		}
		if ((object)field != null)
		{
			return field.FieldType;
		}
		PropertyInfo property = type.GetProperty(field_name, BindingFlags.Instance | BindingFlags.NonPublic);
		if ((object)property == null)
		{
			property = type.GetProperty(field_name, BindingFlags.Instance | BindingFlags.Public);
		}
		if ((object)property == null)
		{
			property = type.GetProperty(field_name, BindingFlags.Static | BindingFlags.NonPublic);
		}
		if ((object)property == null)
		{
			property = type.GetProperty(field_name, BindingFlags.Static | BindingFlags.Public);
		}
		if ((object)property != null)
		{
			return property.PropertyType;
		}
		Error("GetFieldOrPropertyType : Can't Find " + field_name);
		return null;
	}

	public static void SetFieldOrProperty(this object obj, string field_name, object value)
	{
		Type type = obj.GetType();
		FieldInfo field = type.GetField(field_name, BindingFlags.Instance | BindingFlags.NonPublic);
		if ((object)field == null)
		{
			field = type.GetField(field_name, BindingFlags.Instance | BindingFlags.Public);
		}
		if ((object)field == null)
		{
			field = type.GetField(field_name, BindingFlags.Static | BindingFlags.NonPublic);
		}
		if ((object)field == null)
		{
			field = type.GetField(field_name, BindingFlags.Static | BindingFlags.Public);
		}
		if ((object)field != null)
		{
			if (field.FieldType.Name != value.GetType().Name && value.GetType() == typeof(string))
			{
				if (field.FieldType == typeof(float))
				{
					field.SetValue(obj, float.Parse(value as string));
				}
				else if (field.FieldType == typeof(double))
				{
					field.SetValue(obj, double.Parse(value as string));
				}
				else if (field.FieldType == typeof(int))
				{
					field.SetValue(obj, int.Parse(value as string));
				}
				else if (field.FieldType == typeof(short))
				{
					field.SetValue(obj, short.Parse(value as string));
				}
				else if (field.FieldType == typeof(long))
				{
					field.SetValue(obj, long.Parse(value as string));
				}
				else
				{
					field.SetValue(obj, value);
				}
			}
			else
			{
				field.SetValue(obj, value);
			}
			return;
		}
		PropertyInfo property = type.GetProperty(field_name, BindingFlags.Instance | BindingFlags.NonPublic);
		if ((object)property == null)
		{
			property = type.GetProperty(field_name, BindingFlags.Instance | BindingFlags.Public);
		}
		if ((object)property == null)
		{
			property = type.GetProperty(field_name, BindingFlags.Static | BindingFlags.NonPublic);
		}
		if ((object)property == null)
		{
			property = type.GetProperty(field_name, BindingFlags.Static | BindingFlags.Public);
		}
		if ((object)property != null)
		{
			if (property.PropertyType.Name != value.GetType().Name && value.GetType() == typeof(string))
			{
				if (property.PropertyType == typeof(float))
				{
					property.SetValue(obj, float.Parse(value as string));
				}
				else if (property.PropertyType == typeof(double))
				{
					property.SetValue(obj, double.Parse(value as string));
				}
				else if (property.PropertyType == typeof(int))
				{
					property.SetValue(obj, int.Parse(value as string));
				}
				else if (property.PropertyType == typeof(short))
				{
					property.SetValue(obj, short.Parse(value as string));
				}
				else if (property.PropertyType == typeof(long))
				{
					property.SetValue(obj, long.Parse(value as string));
				}
				else
				{
					property.SetValue(obj, value);
				}
			}
			else
			{
				property.SetValue(obj, value);
			}
		}
		else
		{
			Console.WriteLine(Name + " Fatal Error: Can't Find " + field_name);
		}
	}

	public static object? CallPrivateFunc(this object obj, string method_name, object[] paras)
	{
		MethodInfo method = obj.GetType().GetMethod(method_name, BindingFlags.Instance | BindingFlags.NonPublic);
		if ((object)method == null)
		{
			Console.WriteLine(Name + " Fatal Error: Can't Find " + method_name);
			return null;
		}
		return method.Invoke(obj, paras);
	}

	public static object? CallPrivateGenericFunc(this object obj, string method_name, Type[] para_type4search, Type[] generic_types, object[] paras)
	{
		MethodInfo[] methods = obj.GetType().GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if (!methodInfo.IsGenericMethod || !(methodInfo.Name == method_name))
			{
				continue;
			}
			ParameterInfo[] parameters = methodInfo.GetParameters();
			if (parameters.Length != para_type4search.Length)
			{
				continue;
			}
			bool flag = true;
			for (int j = 0; j < para_type4search.Length; j++)
			{
				if (parameters[j].ParameterType.Name != para_type4search[j].Name)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				MethodInfo methodInfo2 = methodInfo.MakeGenericMethod(generic_types);
				if ((object)methodInfo2 != null)
				{
					return methodInfo2.Invoke(obj, paras);
				}
				Console.WriteLine(Name + " Fatal Error: Can't get instance of generic: " + method_name);
			}
		}
		Console.WriteLine(Name + " Fatal Error: Can't Find " + method_name);
		return null;
	}

	public static void Log(string msg, int verLevel = 0)
	{
		if ((verLevel < 2 || !Config.ShutUp) && (verLevel < 1 || !Config.ShuutUp) && !Config.ShuuutUp)
		{
			Console.WriteLine("[" + Name + "]: " + msg);
		}
	}

	public static void Error(string msg, int verLevel = 0)
	{
		Console.WriteLine("Error! [" + Name + "]: " + msg);
	}

	public static void DebugLog(string msg)
	{
	}

	public static ObjectType? CreateObjectFromJson<ObjectType>(JsonData json) where ObjectType : class, new()
	{
		ObjectType val = new ObjectType();
		if (json == null || !json.IsObject)
		{
			return null;
		}
		foreach (string key in json.Keys)
		{
			JsonData val2 = json[key];
			Type fieldOrPropertyType = val.GetFieldOrPropertyType(key);
			if (fieldOrPropertyType == null)
			{
				continue;
			}
			if (fieldOrPropertyType == typeof(string))
			{
				if (val2.IsString)
				{
					val.SetFieldOrProperty(key, ((object)val2).ToString());
				}
				else
				{
					Log("Ignore " + key + ".Need String");
				}
			}
			else if (fieldOrPropertyType == typeof(int) || fieldOrPropertyType == typeof(short) || fieldOrPropertyType == typeof(bool))
			{
				if (val2.IsInt)
				{
					val.SetFieldOrProperty(key, (int)val2);
				}
				else
				{
					Log("Ignore " + key + ".Need Int");
				}
			}
			else if (fieldOrPropertyType.IsEnum)
			{
				if (val2.IsInt)
				{
					val.SetFieldOrProperty(key, (int)val2);
				}
				else if (val2.IsString)
				{
					bool flag = false;
					foreach (object enumValue in fieldOrPropertyType.GetEnumValues())
					{
						if (fieldOrPropertyType.GetEnumName(enumValue) == ((object)val2).ToString())
						{
							val.SetFieldOrProperty(key, enumValue);
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						Log("Ignore " + ((object)val2).ToString() + ".Can't find in enum " + fieldOrPropertyType.Name);
					}
				}
				else
				{
					Log("Ignore " + key + ".Need Int or String for enum");
				}
			}
			else if (fieldOrPropertyType == typeof(float) || fieldOrPropertyType == typeof(double))
			{
				if (val2.IsInt)
				{
					val.SetFieldOrProperty(key, (int)val2);
				}
				else if (val2.IsDouble)
				{
					val.SetFieldOrProperty(key, (double)val2);
				}
				else
				{
					Log("Ignore " + key + ".Need float");
				}
			}
			else
			{
				Log("Ignore " + key + ".Not supported type " + fieldOrPropertyType.Name);
			}
		}
		return val;
	}

	public static UWorld? GetWorld()
	{
		if ((UObject)(object)world == (UObject)null)
		{
			UObject obj = GCHelper.FindRef(FGlobals.GWorld)?.Managed;
			world = (UWorld?)(object)((obj is UWorld) ? obj : null);
		}
		return world;
	}

	public static APawn GetControlledPawn()
	{
		return ((AController)UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)(object)GetWorld())).GetControlledPawn();
	}

	public static BGUPlayerCharacterCS GetBGUPlayerCharacterCS()
	{
		APawn controlledPawn = GetControlledPawn();
		return (BGUPlayerCharacterCS)(object)((controlledPawn is BGUPlayerCharacterCS) ? controlledPawn : null);
	}

	public static BGP_PlayerControllerB1 GetPlayerController()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		return (BGP_PlayerControllerB1)UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)(object)GetWorld());
	}

	public static BUS_GSEventCollection GetBUS_GSEventCollection()
	{
		return BUS_EventCollectionCS.Get((AActor)(object)GetControlledPawn());
	}

	public static T LoadAsset<T>(string asset) where T : UObject
	{
		return BGW_PreloadAssetMgr.Get((UObject)(object)GetWorld()).TryGetCachedResourceObj<T>(asset, (ELoadResourceType)1, (EAssetPriority)0, (Action<int, UObject>)null, -1, -1);
	}

	public static UClass LoadClass(string asset)
	{
		return MyExten.LoadAsset<UClass>(asset);
	}

	public static AActor? SpawnActor(string classAsset)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		APawn controlledPawn = GetControlledPawn();
		FVector actorLocation = ((AActor)controlledPawn).GetActorLocation();
		FVector val = ((AActor)controlledPawn).GetActorForwardVector() * 1000.0;
		FVector val2 = actorLocation + val;
		FRotator val3 = UMathLibrary.FindLookAtRotation(val2, actorLocation);
		UClass val4 = LoadClass("PrefabricatorAsset'" + classAsset + "'");
		if ((UObject)(object)val4 == (UObject)null)
		{
			return null;
		}
		return BGUFunctionLibraryCS.BGUSpawnActor(((AActor)controlledPawn).World, TSubclassOf<AActor>.op_Implicit(val4), val2, val3);
	}

	public static AActor GetActorOfClass(string classAsset)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return UGameplayStatics.GetActorOfClass((UObject)(object)GetWorld(), TSubclassOf<AActor>.op_Implicit(MyExten.LoadAsset<UClass>(classAsset)));
	}
}
