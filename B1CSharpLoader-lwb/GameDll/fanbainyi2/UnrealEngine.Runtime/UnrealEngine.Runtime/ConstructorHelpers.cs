using System;
using System.Diagnostics;

namespace UnrealEngine.Runtime;

public static class ConstructorHelpers
{
	public struct FObjectFinder<T> where T : UObject
	{
		public T Object;

		public bool Succeeded => Object != null;

		public FObjectFinder(string objectToFind)
		{
			string pathName = objectToFind;
			StripObjectClass(ref pathName, assertOnBadPath: true);
			Object = FindOrLoadObject<T>(pathName);
			ValidateObject(Object, pathName, objectToFind);
		}

		public static T Find(string objectToFind)
		{
			return new FObjectFinder<T>(objectToFind).Object;
		}
	}

	public class FObjectFinderOptional<T> where T : UObject
	{
		private T obj;

		private string objectToFind;

		public bool Succeeded => Get() != null;

		public FObjectFinderOptional(string objectToFind)
		{
			obj = null;
			this.objectToFind = objectToFind;
		}

		public T Get()
		{
			if (obj == null && !string.IsNullOrEmpty(objectToFind))
			{
				string pathName = objectToFind;
				StripObjectClass(ref pathName, assertOnBadPath: true);
				obj = FindOrLoadObject<T>(pathName);
				ValidateObject(obj, pathName, objectToFind);
				objectToFind = null;
			}
			return obj;
		}
	}

	public struct FClassFinder<T> where T : UObject
	{
		public TSubclassOf<T> Class;

		public FClassFinder(string classToFind)
		{
			string pathName = classToFind;
			StripObjectClass(ref pathName, assertOnBadPath: true);
			Class = FindOrLoadClass(pathName, UClass.GetClass<T>());
			ValidateObject(Class.Value, pathName, classToFind);
		}

		public UClass Find(string classToFind)
		{
			return new FClassFinder<T>(classToFind).Class.Value;
		}
	}

	private static T FindOrLoadObject<T>(string pathName) where T : UObject
	{
		if (typeof(T) == typeof(UPackage))
		{
			return FindOrLoadPackage(pathName) as T;
		}
		if (pathName.IndexOf('.') == -1)
		{
			int num = pathName.LastIndexOf('/');
			if (num != -1)
			{
				pathName = pathName + "." + pathName.Substring(num + 1);
			}
		}
		UClass uClass = UClass.GetClass<T>();
		if (uClass != null)
		{
			uClass.GetDefaultObject();
			T val = UObject.LoadObject<T>(null, pathName);
			if (val != null)
			{
				val.AddToRoot();
			}
			return val;
		}
		return null;
	}

	private static UPackage FindOrLoadPackage(string pathName)
	{
		int num = pathName.IndexOf('.');
		if (num != -1)
		{
			pathName = pathName.Remove(num, 1);
		}
		UPackage uPackage = UObject.FindPackage(null, pathName);
		if (uPackage == null)
		{
			uPackage = UObject.LoadPackage(null, pathName, ELoadFlags.None);
		}
		if (uPackage != null)
		{
			uPackage.AddToRoot();
		}
		return uPackage;
	}

	private static UClass FindOrLoadClass(string pathName, UClass baseClass)
	{
		if (pathName.IndexOf('.') == -1)
		{
			int num = pathName.LastIndexOf('/');
			if (num != -1)
			{
				pathName = pathName + "." + pathName.Substring(num + 1) + "_C";
			}
		}
		UClass uClass = UObject.LoadClass(baseClass, null, pathName);
		if (uClass != null)
		{
			uClass.AddToRoot();
		}
		return uClass;
	}

	private static void FailedToFind(string objectToFind)
	{
		FObjectInitializer fObjectInitializer = FUObjectThreadContext.TopInitializer();
		UClass uClass = (fObjectInitializer.IsNull ? null : fObjectInitializer.GetClass());
		string str = string.Format("CDO Constructor ({0}): Failed to find {1}\n", (uClass != null) ? uClass.GetName() : "Unknown", objectToFind);
		Log(ELogVerbosity.Error, str);
	}

	private static void CheckFoundViaRedirect(UObject obj, string pathName, string objectToFind)
	{
		UObjectRedirector uObjectRedirector = UObject.FindObject<UObjectRedirector>(ObjectOuter.AnyPackage, pathName);
		if (uObjectRedirector != null && uObjectRedirector.DestinationObject == obj)
		{
			string arg = obj.GetFullName().Replace(" ", "'") + "'";
			FObjectInitializer fObjectInitializer = FUObjectThreadContext.TopInitializer();
			UClass uClass = (fObjectInitializer.IsNull ? null : fObjectInitializer.GetClass());
			string str = string.Format("CDO Constructor ({0}): Followed redirector ({1}), change code to new path ({2])\n", (uClass != null) ? uClass.GetName() : "Unknown", objectToFind, arg);
			Log(ELogVerbosity.Warning, str);
		}
	}

	private static void ValidateObject(UObject obj, string pathName, string objectToFind)
	{
		if (obj == null)
		{
			FailedToFind(objectToFind);
		}
	}

	[Conditional("DEBUG")]
	private static void CheckIfIsInConstructor(string objectToFind)
	{
		_ = FUObjectThreadContext.IsInConstructor;
	}

	private static void StripObjectClass(ref string pathName, bool assertOnBadPath = false)
	{
		int num = pathName.IndexOf('\'');
		if (num != -1)
		{
			int num2 = pathName.LastIndexOf('\'');
			if (num2 > num)
			{
				pathName = pathName.Substring(num + 1, num2 - num - 1);
			}
		}
	}

	private static void Log(ELogVerbosity verbosity, string str)
	{
		FMessage.Log(verbosity, str);
	}

	[Conditional("DEBUG")]
	private static void LogFatal(string str)
	{
		FMessage.Log(ELogVerbosity.Fatal, str);
	}

	public static FProperty CreatePropertyWrapper(IntPtr Address)
	{
		return new FProperty
		{
			Address = Address
		};
	}
}
