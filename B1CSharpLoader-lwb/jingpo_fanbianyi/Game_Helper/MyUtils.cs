using System;
using System.Reflection;
using System.Runtime.InteropServices;
using b1;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace Game_Helper;

public static class MyUtils
{
	private static UWorld world;

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool SetConsoleOutputCP(uint wCodePageID);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool SetConsoleCP(uint wCodePageID);

	public static void EnableCNInConsole()
	{
		SetConsoleCP(65001u);
		SetConsoleOutputCP(65001u);
	}

	public static UWorld GetWorld()
	{
		if (world == null)
		{
			world = GCHelper.FindRef(FGlobals.GWorld)?.Managed as UWorld;
		}
		return world;
	}

	public static APawn GetControlledPawn()
	{
		return UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)GetWorld()).GetControlledPawn();
	}

	public static BGUPlayerCharacterCS GetBGUPlayerCharacterCS()
	{
		APawn controlledPawn = GetControlledPawn();
		return (BGUPlayerCharacterCS)(object)((controlledPawn is BGUPlayerCharacterCS) ? controlledPawn : null);
	}

	public static BGP_PlayerControllerB1 GetPlayerController()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		return (BGP_PlayerControllerB1)UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)GetWorld());
	}

	public static BUS_GSEventCollection GetBUS_GSEventCollection()
	{
		return BUS_EventCollectionCS.Get((AActor)GetControlledPawn());
	}

	public static T LoadAsset<T>(string asset) where T : UObject
	{
		return BGW_PreloadAssetMgr.Get((UObject)GetWorld()).TryGetCachedResourceObj<T>(asset, (ELoadResourceType)1, (EAssetPriority)0, (Action<int, UObject>)null, -1, -1);
	}

	public static UClass LoadClass(string asset)
	{
		return LoadAsset<UClass>(asset);
	}

	public static AActor SpawnActor(string classAsset)
	{
		APawn controlledPawn = GetControlledPawn();
		FVector actorLocation = controlledPawn.GetActorLocation();
		FVector fVector = controlledPawn.GetActorForwardVector() * 1000.0;
		FVector fVector2 = actorLocation + fVector;
		FRotator fRotator = UMathLibrary.FindLookAtRotation(fVector2, actorLocation);
		UClass uClass = LoadClass("PrefabricatorAsset'" + classAsset + "'");
		if (uClass == null)
		{
			return null;
		}
		return BGUFunctionLibraryCS.BGUSpawnActor(controlledPawn.World, (TSubclassOf<AActor>)uClass, fVector2, fRotator);
	}

	public static AActor GetActorOfClass(string classAsset)
	{
		return UGameplayStatics.GetActorOfClass(GetWorld(), LoadAsset<UClass>(classAsset));
	}

	public static FieldType GetFieldOrProperty<FieldType>(this object obj, string field_name) where FieldType : class
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
		if ((object)property == null)
		{
			return;
		}
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

	public static object CallPrivateFunc(this object obj, string method_name, object[] paras)
	{
		Type type = obj.GetType();
		return type.GetMethod(method_name, BindingFlags.Instance | BindingFlags.NonPublic)?.Invoke(obj, paras);
	}
}
