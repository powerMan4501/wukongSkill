using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using UnrealEngine.Engine;
using UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

namespace UnrealEngine.Runtime;

public class ManagedUnrealModuleInfo : ManagedUnrealReflectionBase
{
	[Flags]
	private enum Blueprintability
	{
		None = 0,
		Blueprintable = 1,
		BlueprintType = 2,
		NotBlueprintable = 4,
		NotBlueprintType = 8,
		ManagedTypeBlueprintable = 0x10,
		ManagedTypeBlueprintType = 0x20
	}

	private class CachedFunctionFlagInfo
	{
		public EFunctionFlags Flags;

		public ManagedUnrealFunctionFlags AdditionalFlags;

		public string OriginalName;

		public CachedFunctionFlagInfo(EFunctionFlags flags, ManagedUnrealFunctionFlags additionalFlags, string originalName)
		{
			Flags = flags;
			AdditionalFlags = additionalFlags;
			OriginalName = originalName;
		}
	}

	public static int NumWarnings;

	public static readonly bool SkipValidation;

	public static readonly bool UseBlittableStructResolving;

	private Dictionary<string, List<Type>> typesByName = new Dictionary<string, List<Type>>();

	private static CodeGeneratorSettings codeSettings;

	private static HashSet<Assembly> seenAssemblies;

	internal static Dictionary<Type, EStructFlags> resolvedStructCtorDtorFlags;

	private static Dictionary<MethodInfo, CachedFunctionFlagInfo> cachedFunctionFlags;

	private static ManagedUnrealFunctionInfo cachedDummyFunctionInfo;

	private static Dictionary<Type, KeyValuePair<EClassFlags, ManagedUnrealTypeInfoFlags>> cachedClassFlags;

	private static Dictionary<Type, string> cachedClassConfigName;

	private static ManagedUnrealTypeInfo cachedDummyClassInfo;

	private static Dictionary<Type, Blueprintability> cachedBlueprintability;

	private static Dictionary<Type, byte> cachedCalculatedEnumSize;

	private static Dictionary<Type, List<Type>> cachedImplementedInterfaces;

	private static Dictionary<Type, Dictionary<MethodInfo, MethodInfo>> cachedImplementedInterfacesFunctionMap;

	private static HashSet<Type> unexportableTypes;

	public static List<ManagedUnrealModuleInfo> Modules { get; private set; }

	public static Dictionary<Type, ManagedUnrealModuleInfo> ModulesByType { get; private set; }

	public static Dictionary<Assembly, ManagedUnrealModuleInfo> ModulesByAssembly { get; private set; }

	public string AssemblyName { get; set; }

	public string ModuleName { get; set; }

	public List<ManagedUnrealTypeInfo> Classes { get; set; }

	public List<ManagedUnrealTypeInfo> Structs { get; set; }

	public List<ManagedUnrealEnumInfo> Enums { get; set; }

	public List<ManagedUnrealTypeInfo> Interfaces { get; set; }

	public List<ManagedUnrealTypeInfo> Delegates { get; set; }

	public HashSet<string> ReferencedAssemblies { get; set; }

	public Dictionary<Type, ManagedUnrealTypeInfo> TypeInfosByType { get; private set; }

	public Dictionary<ManagedUnrealTypeInfo, Type> TypesByTypeInfo { get; private set; }

	public Dictionary<string, ManagedUnrealTypeInfo> TypeInfosByPath { get; private set; }

	internal static Dictionary<string, Type> AllTypesByPath { get; set; }

	internal static Dictionary<string, ManagedUnrealTypeInfo> AllTypeInfosByPath { get; set; }

	public static Dictionary<string, Type> AllKnownUnrealTypes { get; private set; }

	public static Dictionary<string, Type> AllKnownBlittableTypes { get; private set; }

	public static Dictionary<string, Type> AllKnownNonBlittableTypes { get; private set; }

	private void ValidateClass(ManagedUnrealTypeInfo typeInfo, Type type)
	{
		if (!SkipValidation)
		{
			if (typeInfo.ClassFlags.HasFlag(EClassFlags.EditInlineNew) && typeInfo.AdditionalFlags.HasFlag(ManagedUnrealTypeInfoFlags.Actor))
			{
				throw new ValidateUnrealClassFailedException(type, "Invalid class attribute: Creating actor instances via the property window is not allowed");
			}
			if (type.HasCustomAttribute<BlueprintableAttribute>(inherit: false) && type.HasCustomAttribute<NotBlueprintableAttribute>(inherit: false))
			{
				throw new ValidateUnrealClassFailedException(type, "Invalid class attribute: Cannot be both [Blueprintable] and [NotBlueprintable]");
			}
			if (type.HasCustomAttribute<BlueprintTypeAttribute>(inherit: false) && type.HasCustomAttribute<NotBlueprintTypeAttribute>(inherit: false))
			{
				throw new ValidateUnrealClassFailedException(type, "Invalid class attribute: Cannot be both [BlueprintType] and [NotBlueprintType]");
			}
		}
	}

	private void ValidateStruct(ManagedUnrealTypeInfo typeInfo, Type type)
	{
		_ = SkipValidation;
	}

	private void ValidateDelegate(ManagedUnrealTypeInfo typeInfo, Type type, ManagedUnrealFunctionInfo functionInfo, MethodInfo method)
	{
		if (SkipValidation || typeInfo.TypeCode != EPropertyType.MulticastDelegate || !(method.ReturnType != typeof(void)))
		{
			return;
		}
		throw new ValidateUnrealFunctionFailedException(method, "Multi-cast delegates function signatures must not return a value");
	}

	private void ValidateFunction(ManagedUnrealTypeInfo typeInfo, Type type, ManagedUnrealFunctionInfo functionInfo, MethodInfo method)
	{
		if (SkipValidation)
		{
			return;
		}
		EFunctionFlags flags = functionInfo.Flags;
		ManagedUnrealFunctionFlags additionalFlags = functionInfo.AdditionalFlags;
		if (typeInfo.IsInterface)
		{
			if (flags.HasFlag(EFunctionFlags.BlueprintPure))
			{
				throw new ValidateUnrealFunctionFailedException(method, "BlueprintPure specifier is not allowed for interface functions");
			}
			bool flag = type.GetCustomAttribute<CannotImplementInterfaceInBlueprintAttribute>(inherit: false) == null;
			if (flags.HasFlag(EFunctionFlags.BlueprintEvent) && !flag && type.GetCustomAttribute<BlueprintInternalUseOnlyAttribute>(inherit: false) == null)
			{
				throw new ValidateUnrealFunctionFailedException(method, "Interfaces that are not implementable in blueprints cannot have BlueprintImplementableEvent members.");
			}
			if (flags.HasFlag(EFunctionFlags.BlueprintCallable) && !flags.HasFlag(EFunctionFlags.BlueprintEvent) && flag)
			{
				throw new ValidateUnrealFunctionFailedException(method, "Blueprint implementable interfaces cannot contain BlueprintCallable functions that are not BlueprintImplementableEvents. Use CannotImplementInterfaceInBlueprint on the interface if you wish to keep this function. " + Environment.NewLine + "(The reason for this is that BlueprintCallable without BlueprintEvent states the function is callable from Blueprint but cannot be implemented in Blueprint. So if a Blueprint were to implement the interface there would be no implementation for the BlueprintCallable function. And as a result there would be a runtime error when called.)");
			}
			if (flags.HasFlag(EFunctionFlags.Final))
			{
				throw new ValidateUnrealFunctionFailedException(method, "Interface functions cannot be declared 'SealedEvent'");
			}
		}
		if (flags.HasFlag(EFunctionFlags.Final) && !flags.HasFlag(EFunctionFlags.Event))
		{
			throw new ValidateUnrealFunctionFailedException(method, "SealedEvent may only be used on events");
		}
		if (flags.HasFlag(EFunctionFlags.Net))
		{
			if (functionInfo.ReturnProp != null && !flags.HasFlag(EFunctionFlags.NetRequest) && !flags.HasFlag(EFunctionFlags.NetResponse))
			{
				throw new ValidateUnrealFunctionFailedException(method, "Replicated functions can't have return values");
			}
			if (functionInfo.IsStatic)
			{
				throw new ValidateUnrealFunctionFailedException(method, "Static functions can't be replicated");
			}
			if (flags.HasFlag(EFunctionFlags.Exec))
			{
				throw new ValidateUnrealFunctionFailedException(method, "Exec functions cannot be replicated!");
			}
		}
		if (flags.HasFlag(EFunctionFlags.BlueprintPure))
		{
			bool flag2 = functionInfo.ReturnProp != null;
			if (!flag2)
			{
				foreach (ManagedUnrealPropertyInfo item in functionInfo.Params)
				{
					if (item.IsOut)
					{
						flag2 = true;
						break;
					}
				}
			}
			if (!flag2)
			{
				throw new ValidateUnrealFunctionFailedException(method, "BlueprintPure specifier is not allowed for functions with no return value and no output parameters.");
			}
		}
		if (flags.HasFlag(EFunctionFlags.BlueprintEvent))
		{
			if (flags.HasFlag(EFunctionFlags.Net))
			{
				throw new ValidateUnrealFunctionFailedException(method, "BlueprintEvent functions cannot be replicated!");
			}
			if (additionalFlags.HasFlag(ManagedUnrealFunctionFlags.BlueprintGetter) || additionalFlags.HasFlag(ManagedUnrealFunctionFlags.BlueprintSetter))
			{
				throw new ValidateUnrealFunctionFailedException(method, "A function cannot be both BlueprintEvent and a Blueprint Property accessor! (getter/setter)");
			}
			if (flags.HasFlag(EFunctionFlags.Private))
			{
				throw new ValidateUnrealFunctionFailedException(method, "A Private function cannot be a BlueprintEvent!");
			}
		}
		if (functionInfo.IsOverride)
		{
			if (codeSettings.UseExplicitImplementationMethods && (functionInfo.IsBlueprintEvent || functionInfo.IsRPC))
			{
				ValidateImplementationMethodSignature(functionInfo, method, method.GetBaseDefinition());
			}
		}
		else
		{
			if (!codeSettings.UseExplicitImplementationMethods)
			{
				return;
			}
			if (functionInfo.IsImplementation)
			{
				if (functionInfo.IsBlueprintEvent && !functionInfo.IsVirtual)
				{
					throw new InvalidUnrealFunctionException(method, codeSettings.VarNames.ImplementationMethod + " method isn't virtual (" + type.FullName + "." + method.Name + ")");
				}
			}
			else if ((functionInfo.IsBlueprintEvent || functionInfo.IsRPC) && !typeInfo.IsInterface)
			{
				BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
				MethodInfo method2 = type.GetMethod(method.Name + codeSettings.VarNames.ImplementationMethod, bindingAttr);
				ValidateImplementationMethodSignature(functionInfo, method, method2);
			}
		}
	}

	private void ValidateFunctionParam(ManagedUnrealTypeInfo typeInfo, Type type, ManagedUnrealPropertyInfo propertyInfo, Type propertyType, ParameterInfo param, ManagedUnrealFunctionInfo functionInfo, MethodInfo method)
	{
		if (SkipValidation)
		{
			return;
		}
		if (functionInfo.Flags.HasFlag(EFunctionFlags.Net))
		{
			if (!functionInfo.Flags.HasFlag(EFunctionFlags.NetRequest))
			{
				if (propertyInfo.Flags.HasFlag(EPropertyFlags.OutParm))
				{
					throw new ValidateUnrealFunctionFailedException(method, "Replicated functions cannot contain out parameters");
				}
				if (propertyInfo.Flags.HasFlag(EPropertyFlags.RepSkip))
				{
					throw new ValidateUnrealFunctionFailedException(method, "Only service request functions cannot contain NoReplication parameters");
				}
				if (propertyInfo.IsDelegate)
				{
					throw new ValidateUnrealFunctionFailedException(method, "Replicated functions cannot contain delegate parameters (this would be insecure)");
				}
			}
			else if (!propertyInfo.Flags.HasFlag(EPropertyFlags.RepSkip))
			{
				if (propertyInfo.Flags.HasFlag(EPropertyFlags.OutParm))
				{
					throw new ValidateUnrealFunctionFailedException(method, "Service request functions cannot contain out parameters, unless marked NotReplicated");
				}
				if (propertyInfo.IsDelegate)
				{
					throw new ValidateUnrealFunctionFailedException(method, "Service request functions cannot contain delegate parameters, unless marked NotReplicated");
				}
			}
		}
		ValidatePropertyForBlueprint(type, method, typeInfo, functionInfo, propertyInfo, propertyType);
		if (!IsValidClassPropertyUsage(propertyInfo, propertyType, out var error))
		{
			throw new ValidateUnrealFunctionFailedException(method, error);
		}
		if (propertyInfo.IsFixedSizeArray)
		{
			throw new InvalidUnrealFunctionFixedSizeArrayUsedException(method);
		}
		if (!propertyInfo.IsFunctionParam || !propertyInfo.Flags.HasFlag(EPropertyFlags.RepSkip) || (functionInfo != null && functionInfo.Flags.HasFlag(EFunctionFlags.Net)))
		{
			return;
		}
		throw new ValidateUnrealFunctionFailedException(method, "Only parameters in service request functions can be marked NotReplicated. Param: '" + param.Name + "'");
	}

	private bool TryGetGetterSetterMethod(Type type, MemberInfo member, bool getter, out MethodInfo method, out string methodName)
	{
		method = null;
		methodName = null;
		if (getter)
		{
			BlueprintGetterAttribute customAttribute = member.GetCustomAttribute<BlueprintGetterAttribute>(inherit: false);
			if (customAttribute != null)
			{
				methodName = customAttribute.FunctionName;
			}
		}
		else
		{
			BlueprintSetterAttribute customAttribute2 = member.GetCustomAttribute<BlueprintSetterAttribute>(inherit: false);
			if (customAttribute2 != null)
			{
				methodName = customAttribute2.FunctionName;
			}
		}
		if (!string.IsNullOrEmpty(methodName))
		{
			BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
			MethodInfo[] methods = type.GetMethods(bindingAttr);
			foreach (MethodInfo methodInfo in methods)
			{
				if (methodInfo.Name == methodName)
				{
					method = methodInfo;
					break;
				}
			}
		}
		return method != null;
	}

	private void ValidatePropertyGetter(ManagedUnrealTypeInfo typeInfo, Type type, ManagedUnrealPropertyInfo propertyInfo, Type propertyType, MemberInfo member)
	{
		if (typeInfo.IsStruct)
		{
			throw new ValidateUnrealPropertyFailedException(member, "Cannot specify BlueprintGetter for a struct member.");
		}
		if (TryGetGetterSetterMethod(type, member, getter: true, out var method, out var methodName))
		{
			if (method.GetParameters().Length > 1 || method.ReturnParameter == null)
			{
				throw new ValidateUnrealPropertyFailedException(member, "Blueprint Property getter function '" + methodName + "' must not have parameters and must have a return type.");
			}
			ManagedUnrealPropertyInfo managedUnrealPropertyInfo = CreateProperty(method.ReturnParameter.ParameterType);
			if (managedUnrealPropertyInfo != null && !ManagedUnrealTypeInfo.IsSamePropertyType(propertyInfo, managedUnrealPropertyInfo))
			{
				throw new ValidateUnrealPropertyFailedException(member, "Blueprint Property getter function '" + method.DeclaringType?.ToString() + ":" + method.Name + "' must have the same value of type '" + propertyType.FullName + "'");
			}
			if (TryGetFunctionFlags(null, method, out var outFlags))
			{
				if (outFlags.Flags.HasFlag(EFunctionFlags.BlueprintEvent))
				{
					throw new ValidateUnrealPropertyFailedException(member, "Blueprint Property getter function cannot be a blueprint event.");
				}
				if (!outFlags.Flags.HasFlag(EFunctionFlags.BlueprintPure))
				{
					throw new ValidateUnrealPropertyFailedException(member, "Blueprint Property getter function must be pure.");
				}
			}
			return;
		}
		throw new ValidateUnrealPropertyFailedException(member, "Failed to find the target function for Blueprint Property getter function '" + methodName + "'");
	}

	private void ValidatePropertySetter(ManagedUnrealTypeInfo typeInfo, Type type, ManagedUnrealPropertyInfo propertyInfo, Type propertyType, MemberInfo member)
	{
		if (typeInfo.IsStruct)
		{
			throw new ValidateUnrealPropertyFailedException(member, "Cannot specify BlueprintSetter for a struct member.");
		}
		if (TryGetGetterSetterMethod(type, member, getter: false, out var method, out var methodName))
		{
			if (method.ReturnType != typeof(void))
			{
				throw new ValidateUnrealPropertyFailedException(member, "Blueprint Property setter function '" + methodName + "' must not have a return value.");
			}
			bool flag = true;
			ParameterInfo[] parameters = method.GetParameters();
			if (parameters.Length == 1)
			{
				ManagedUnrealPropertyInfo managedUnrealPropertyInfo = CreateProperty(parameters[0].ParameterType);
				if (managedUnrealPropertyInfo != null && !ManagedUnrealTypeInfo.IsSamePropertyType(propertyInfo, managedUnrealPropertyInfo))
				{
					flag = false;
				}
			}
			else
			{
				flag = false;
			}
			if (!flag)
			{
				throw new ValidateUnrealPropertyFailedException(member, "Blueprint Property setter function '" + method.DeclaringType?.ToString() + ":" + method.Name + "' must have exactly one parameter of type '" + propertyType.FullName + "'");
			}
			if (TryGetFunctionFlags(null, method, out var outFlags))
			{
				if (outFlags.Flags.HasFlag(EFunctionFlags.BlueprintEvent))
				{
					throw new ValidateUnrealPropertyFailedException(member, "Blueprint Property setter function cannot be a blueprint event.");
				}
				if (!outFlags.Flags.HasFlag(EFunctionFlags.BlueprintCallable))
				{
					throw new ValidateUnrealPropertyFailedException(member, "Blueprint Property setter function must be blueprint callable.");
				}
				if (outFlags.Flags.HasFlag(EFunctionFlags.BlueprintPure))
				{
					throw new ValidateUnrealPropertyFailedException(member, "Blueprint Property setter function must not be pure.");
				}
			}
			return;
		}
		throw new ValidateUnrealPropertyFailedException(member, "Failed to find the target function for Blueprint Property setter function '" + methodName + "'");
	}

	private void ValidateProperty(ManagedUnrealTypeInfo typeInfo, Type type, ManagedUnrealPropertyInfo propertyInfo, Type propertyType, MemberInfo member)
	{
		if (SkipValidation)
		{
			return;
		}
		if (propertyInfo.IsFixedSizeArray)
		{
			switch (propertyInfo.GenericArgs[0].TypeCode)
			{
			case EPropertyType.Array:
			case EPropertyType.Map:
			case EPropertyType.Set:
				throw new ValidateUnrealPropertyFailedException(member, "Fixed size arrays of containers are not allowed");
			case EPropertyType.Bool:
				throw new ValidateUnrealPropertyFailedException(member, "Fixed size bool arrays are not allowed");
			}
		}
		ValidatePropertyForBlueprint(typeInfo, type, propertyInfo, member, propertyType);
		if (!IsValidClassPropertyUsage(propertyInfo, propertyType, out var error))
		{
			throw new ValidateUnrealPropertyFailedException(member, error);
		}
		if (propertyInfo.Flags.HasFlag(EPropertyFlags.ExposeOnSpawn))
		{
			if (propertyInfo.Flags.HasFlag(EPropertyFlags.DisableEditOnInstance))
			{
				LogWarningProperty(member, "Property cannot have 'DisableEditOnInstance' or 'BlueprintReadOnly' and 'ExposeOnSpawn' flags");
			}
			if (!propertyInfo.Flags.HasFlag(EPropertyFlags.BlueprintVisible))
			{
				LogWarningProperty(member, "Property cannot have 'ExposeOnSpawn' without 'BlueprintVisible' flag.");
			}
			if (!IsSupportedExposeOnSpawnProperty(propertyInfo))
			{
				throw new ValidateUnrealPropertyFailedException(member, "ExposeOnSpawn - Property cannot be exposed");
			}
		}
		object[] customAttributes = member.GetCustomAttributes(typeof(EditorVisibleAttribute), inherit: false);
		if (customAttributes != null && customAttributes.Length > 1)
		{
			throw new ValidateUnrealPropertyFailedException(member, "Found more than one edit/visibility specifier, only one is allowed.");
		}
		int num = 0;
		foreach (BlueprintVisibleAttribute customAttribute in member.GetCustomAttributes<BlueprintVisibleAttribute>(inherit: false))
		{
			num++;
			if (customAttribute.ReadOnly && propertyInfo.AdditionalFlags.HasFlag(ManagedUnrealPropertyFlags.BlueprintGetter))
			{
				throw new ValidateUnrealPropertyFailedException(member, "Cannot specify a property as being both BlueprintReadOnly and having a BlueprintSetter.");
			}
			if (propertyInfo.AdditionalFlags.HasFlag(ManagedUnrealPropertyFlags.BlueprintSetter))
			{
				throw new ValidateUnrealPropertyFailedException(member, "Cannot specify both BlueprintReadOnly and BlueprintReadWrite or BlueprintSetter.");
			}
			if (!customAttribute.ReadOnly && propertyInfo.IsPrivate && member.GetCustomAttribute<AllowPrivateAccessAttribute>(inherit: false) == null)
			{
				throw new ValidateUnrealPropertyFailedException(member, "BlueprintReadWrite should not be used on private members");
			}
		}
		if (num > 1)
		{
			throw new ValidateUnrealPropertyFailedException(member, "Cannot specify a property as being both BlueprintReadOnly and BlueprintReadWrite.");
		}
		EPropertyFlags flags = propertyInfo.Flags;
		ManagedUnrealPropertyFlags additionalFlags = propertyInfo.AdditionalFlags;
		if (flags.HasFlag(EPropertyFlags.RepNotify))
		{
			MethodInfo methodInfo = null;
			if (typeInfo.IsStruct)
			{
				throw new ValidateUnrealPropertyFailedException(member, "Struct members cannot be replicated");
			}
			if (flags.HasFlag(EPropertyFlags.RepSkip) && !typeInfo.IsStruct)
			{
				throw new ValidateUnrealPropertyFailedException(member, "Only Struct members can be marked NotReplicated");
			}
			if (string.IsNullOrEmpty(propertyInfo.RepNotifyName))
			{
				throw new ValidateUnrealPropertyFailedException(member, "Must specify a valid function name for replication notifications");
			}
			BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
			MethodInfo[] methods = type.GetMethods(bindingAttr);
			foreach (MethodInfo methodInfo2 in methods)
			{
				if (methodInfo2.Name == propertyInfo.RepNotifyName)
				{
					if (!methodInfo2.HasCustomAttribute<UFunctionAttribute>(inherit: true))
					{
						throw new ValidateUnrealPropertyFailedException(member, "Must be marked as UFunction");
					}
					methodInfo = methodInfo2;
					break;
				}
			}
			if (!(methodInfo != null))
			{
				throw new ValidateUnrealPropertyFailedException(member, "Replication notification function '" + propertyInfo.RepNotifyName + "' not found");
			}
			if (methodInfo.ReturnType != typeof(void))
			{
				throw new ValidateUnrealPropertyFailedException(member, "Replication notification function '" + propertyInfo.RepNotifyName + "' must not have return value.");
			}
			int num2 = ((propertyInfo.Type.TypeCode != EPropertyType.Array) ? 1 : 2);
			ParameterInfo[] parameters = methodInfo.GetParameters();
			if (parameters.Length > num2)
			{
				throw new ValidateUnrealPropertyFailedException(member, "Replication notification function '" + propertyInfo.RepNotifyName + "' has too many parameters.");
			}
			if (parameters.Length >= 1)
			{
				ManagedUnrealPropertyInfo managedUnrealPropertyInfo = CreateProperty(parameters[0].ParameterType);
				if (managedUnrealPropertyInfo != null && !ManagedUnrealTypeInfo.IsSamePropertyType(propertyInfo, managedUnrealPropertyInfo))
				{
					throw new ValidateUnrealPropertyFailedException(member, "Replication notification function '" + propertyInfo.RepNotifyName + "' has invalid parameter for the property. First (optional) parameter must be of type '" + propertyType.FullName + "'");
				}
			}
			if (parameters.Length >= 2)
			{
				ManagedUnrealPropertyInfo managedUnrealPropertyInfo2 = CreateProperty(parameters[0].ParameterType);
				if (managedUnrealPropertyInfo2 != null && (managedUnrealPropertyInfo2.GenericArgs.Count != 1 || managedUnrealPropertyInfo2.GenericArgs[0].TypeCode != EPropertyType.Byte))
				{
					throw new ValidateUnrealPropertyFailedException(member, "Replication notification function '" + propertyInfo.RepNotifyName + "' (optional) second parameter must be a TArray supported type containing bytes.");
				}
			}
		}
		if (flags.HasFlag(EPropertyFlags.PersistentInstance))
		{
			if (propertyInfo.Type.TypeCode != EPropertyType.Object && propertyInfo.Type.TypeCode != EPropertyType.Class && propertyInfo.Type.TypeCode != EPropertyType.Array)
			{
				throw new ValidateUnrealPropertyFailedException(member, "'Instanced' is only allowed on object property (or array of objects)");
			}
			if (propertyType.IsSameOrSubclassOf(typeof(UClass)) || (propertyType.IsGenericType && propertyType.GenericTypeArguments[0].IsSameOrSubclassOf(typeof(UClass))))
			{
				throw new ValidateUnrealPropertyFailedException(member, "'Instanced' cannot be applied to class properties (UClass* or TSubclassOf<>)");
			}
		}
		if (flags.HasFlag(EPropertyFlags.Config))
		{
			EPropertyType typeCode = propertyInfo.Type.TypeCode;
			if (typeCode == EPropertyType.Interface || (uint)(typeCode - 15) <= 3u)
			{
				throw new ValidateUnrealPropertyFailedException(member, "Not allowed to use 'config' with object variables");
			}
		}
		if (flags.HasFlag(EPropertyFlags.BlueprintAssignable) && propertyInfo.Type.TypeCode != EPropertyType.MulticastDelegate)
		{
			throw new ValidateUnrealPropertyFailedException(member, "'BlueprintAssignable' is only allowed on multicast delegate properties");
		}
		if (flags.HasFlag(EPropertyFlags.BlueprintCallable) && propertyInfo.Type.TypeCode != EPropertyType.MulticastDelegate)
		{
			throw new ValidateUnrealPropertyFailedException(member, "'BlueprintCallable' is only allowed on a property when it is a multicast delegate");
		}
		if (flags.HasFlag(EPropertyFlags.BlueprintAuthorityOnly) && propertyInfo.Type.TypeCode != EPropertyType.MulticastDelegate)
		{
			throw new ValidateUnrealPropertyFailedException(member, "'BlueprintAuthorityOnly' is only allowed on a property when it is a multicast delegate");
		}
		EPropertyFlags ePropertyFlags = flags & (EPropertyFlags.DuplicateTransient | EPropertyFlags.TextExportTransient | EPropertyFlags.NonPIEDuplicateTransient);
		if (ePropertyFlags != ~EPropertyFlags.AllFlags && !typeInfo.IsClass)
		{
			throw new ValidateUnrealPropertyFailedException(member, "'" + ePropertyFlags.ToString() + "' specifier(s) are only allowed on class member variables");
		}
		if (additionalFlags.HasFlag(ManagedUnrealPropertyFlags.BlueprintGetter))
		{
			ValidatePropertyGetter(typeInfo, type, propertyInfo, propertyType, member);
		}
		if (additionalFlags.HasFlag(ManagedUnrealPropertyFlags.BlueprintSetter))
		{
			ValidatePropertySetter(typeInfo, type, propertyInfo, propertyType, member);
		}
		if (member as PropertyInfo != null && propertyInfo.Type.TypeCode == EPropertyType.InternalManagedFixedSizeArray)
		{
			throw new ValidateUnrealPropertyFailedException(member, "A regular array \"[]\" was used on a property. Use TFixedSizeArray<> instead (if a fixed size array was intended; otherwise use List<>)");
		}
		FieldInfo fieldInfo = member as FieldInfo;
		if (fieldInfo != null && propertyInfo.IsFixedSizeArray)
		{
			if (propertyInfo.Type.TypeCode == EPropertyType.InternalNativeFixedSizeArray)
			{
				throw new ValidateUnrealPropertyFailedException(member, "TFixedSizeArray<> used on a field. Use the array specifier instead \"[]\".");
			}
			if (fieldInfo.FieldType.GetArrayRank() > 1)
			{
				throw new ValidateUnrealPropertyFailedException(member, "A multidimensional array was used on a field. Only single dimensional arrays are supported.");
			}
		}
		if ((flags & (EPropertyFlags.Edit | EPropertyFlags.BlueprintVisible | EPropertyFlags.BlueprintAssignable | EPropertyFlags.BlueprintCallable)) == ~EPropertyFlags.AllFlags && member.GetCustomAttribute<CategoryAttribute>(inherit: false) != null)
		{
			LogWarningProperty(member, "Category is set but is not exposed to the editor or Blueprints with EditAnywhere, BlueprintReadWrite, VisibleAnywhere, BlueprintReadOnly, BlueprintAssignable, BlueprintCallable keywords.");
		}
		if (!flags.HasFlag(EPropertyFlags.Edit))
		{
			if (flags.HasFlag(EPropertyFlags.DisableEditOnInstance))
			{
				throw new ValidateUnrealPropertyFailedException(member, "Property cannot have 'DisableEditOnInstance' without being editable");
			}
			if (flags.HasFlag(EPropertyFlags.DisableEditOnTemplate))
			{
				throw new ValidateUnrealPropertyFailedException(member, "Property cannot have 'DisableEditOnTemplate' without being editable");
			}
		}
		if ((flags & EPropertyFlags.ParmFlags) == ~EPropertyFlags.AllFlags)
		{
			return;
		}
		throw new ValidateUnrealPropertyFailedException(member, "Illegal type modifiers in member variable declaration");
	}

	private void ValidateEnum(ManagedUnrealEnumInfo enumInfo, Type type)
	{
		if (SkipValidation || !IsTypeExposedToBlueprint(enumInfo) || !(type.GetEnumUnderlyingType() != typeof(byte)))
		{
			return;
		}
		throw new ValidateUnrealEnumFailedException(type, "Invalid BlueprintType enum base - currently only byte supported (constrain your enum by using \"enum MyEnum : byte\")");
	}

	private void ValidatePropertyForBlueprint(ManagedUnrealTypeInfo typeInfo, Type type, ManagedUnrealPropertyInfo propertyInfo, MemberInfo member, Type propertyType)
	{
		if (!SkipValidation && IsTypeExposedToBlueprint(typeInfo) && IsPropertyExposedToBlueprint(propertyInfo))
		{
			if (propertyInfo.Type.TypeCode == EPropertyType.Enum && GetEnumByteSize(propertyType) != 1)
			{
				throw new ValidateUnrealPropertyFailedException(member, "Invalid enum size for a property exposed to blueprint.  EnumType: '" + propertyType.FullName + "'");
			}
			if (!ManagedUnrealTypeInfo.DoesBlueprintSupportType(propertyInfo, memberVariable: true))
			{
				throw new InvalidUnrealTypeForBlueprintException(typeInfo, member, propertyInfo);
			}
			if (propertyInfo.IsFixedSizeArray)
			{
				throw new ValidateUnrealPropertyFailedException(member, "Fixed size array cannot be exposed to blueprint");
			}
		}
	}

	private void ValidatePropertyForBlueprint(Type type, MethodInfo method, ManagedUnrealTypeInfo typeInfo, ManagedUnrealFunctionInfo functionInfo, ManagedUnrealPropertyInfo propertyInfo, Type propertyType)
	{
		if (!SkipValidation && IsTypeExposedToBlueprint(typeInfo) && IsFunctionExposedToBlueprint(functionInfo))
		{
			if (propertyInfo.Type.TypeCode == EPropertyType.Enum && GetEnumByteSize(propertyType) != 1)
			{
				throw new ValidateUnrealFunctionFailedException(method, "Invalid enum size for function param exposed to blueprint.  EnumType: '" + propertyType.FullName + "'");
			}
			if (!ManagedUnrealTypeInfo.DoesBlueprintSupportType(propertyInfo, memberVariable: true))
			{
				throw new InvalidUnrealTypeForBlueprintException(typeInfo, method, propertyInfo);
			}
		}
	}

	private bool IsValidClassPropertyUsage(ManagedUnrealPropertyInfo propertyInfo, Type propertyType, out string error)
	{
		if (propertyType.IsByRef && propertyType.HasElementType)
		{
			propertyType = propertyType.GetElementType();
		}
		error = null;
		EPropertyType typeCode = propertyInfo.Type.TypeCode;
		if (((uint)(typeCode - 17) <= 1u || typeCode == EPropertyType.SoftObject) && propertyType.GenericTypeArguments[0].IsSameOrSubclassOf(typeof(UClass)))
		{
			switch (propertyInfo.Type.TypeCode)
			{
			case EPropertyType.WeakObject:
				error = "Class variables cannot be weak, they are always strong.";
				break;
			case EPropertyType.LazyObject:
				error = "Class variables cannot be lazy, they are always strong.";
				break;
			case EPropertyType.SoftObject:
				error = "Class variables cannot be stored in TSoftObjectPtr, use TSoftClassPtr instead.";
				break;
			}
		}
		return error == null;
	}

	private void ValidateImplementationMethodSignature(ManagedUnrealFunctionInfo functionInfo, MethodInfo method, MethodInfo other)
	{
		if (SkipValidation)
		{
			return;
		}
		if (other == null)
		{
			if (functionInfo.IsImplementation || (!functionInfo.IsBlueprintImplemented && (!functionInfo.IsBlueprintEvent || !codeSettings.UseImplicitBlueprintImplementableEvent)))
			{
				throw new InvalidUnrealFunctionException(method, codeSettings.VarNames.ImplementationMethod + " method is required for (" + method.DeclaringType.FullName + "." + method.Name + ")");
			}
		}
		else if (codeSettings.UseExplicitImplementationMethods && !IsSameMethodSignature(method, other))
		{
			throw new InvalidUnrealFunctionException(method, codeSettings.VarNames.ImplementationMethod + " method signature doesn't match the declaration method signature (" + method.DeclaringType.FullName + "." + method.Name + ")");
		}
	}

	private bool IsSameMethodSignature(MethodInfo method, MethodInfo other)
	{
		ParameterInfo[] parameters = method.GetParameters();
		ParameterInfo[] parameters2 = other.GetParameters();
		if (method.ReturnType != other.ReturnType)
		{
			return false;
		}
		if (parameters.Length != parameters2.Length)
		{
			return false;
		}
		for (int i = 0; i < parameters.Length; i++)
		{
			if (parameters[i].ParameterType != parameters2[i].ParameterType)
			{
				return false;
			}
		}
		return true;
	}

	private void ValidateNoUnrealExposedProperties(ManagedUnrealTypeInfo typeInfo, Type type)
	{
		if (SkipValidation)
		{
			return;
		}
		BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
		PropertyInfo[] properties = type.GetProperties(bindingAttr);
		foreach (PropertyInfo propertyInfo in properties)
		{
			if (propertyInfo.HasCustomAttribute<ManagedUnrealAttributeBase>(inherit: false) || propertyInfo.HasCustomAttribute<UMetaAttribute>(inherit: false))
			{
				throw new ValidateNoUnrealExposedException("Found Unreal tagged property which should be a field. Property: '" + type.FullName + ":" + propertyInfo.Name + "'");
			}
		}
	}

	private void ValidateNoUnrealExposedFields(ManagedUnrealTypeInfo typeInfo, Type type)
	{
		if (SkipValidation)
		{
			return;
		}
		BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
		FieldInfo[] fields = type.GetFields(bindingAttr);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (fieldInfo.HasCustomAttribute<ManagedUnrealAttributeBase>(inherit: false) || fieldInfo.HasCustomAttribute<UMetaAttribute>(inherit: false))
			{
				throw new ValidateNoUnrealExposedException("Found Unreal tagged field which should be a property. Field: '" + type.FullName + ":" + fieldInfo.Name + "'");
			}
		}
	}

	private bool IsSupportedExposeOnSpawnProperty(ManagedUnrealPropertyInfo propertyInfo)
	{
		bool flag = false;
		switch (propertyInfo.Type.TypeCode)
		{
		case EPropertyType.Bool:
		case EPropertyType.Int:
		case EPropertyType.Byte:
		case EPropertyType.Float:
		case EPropertyType.Interface:
		case EPropertyType.Class:
		case EPropertyType.Object:
		case EPropertyType.Str:
		case EPropertyType.Name:
		case EPropertyType.Text:
			flag = true;
			break;
		}
		if (!flag && propertyInfo.Type.TypeCode == EPropertyType.Struct && !string.IsNullOrEmpty(propertyInfo.Type.Path))
		{
			Type type = ManagedUnrealTypeInfo.FindTypeByPath(propertyInfo.Type.Path);
			if (type != null && type.GetCustomAttribute<BlueprintTypeAttribute>(inherit: false) != null)
			{
				flag = true;
			}
		}
		return flag;
	}

	private void LogWarning(string warning)
	{
		NumWarnings++;
		warning = "[WARNING] " + warning;
		Console.WriteLine(warning);
	}

	private void LogWarningProperty(MemberInfo member, string warning)
	{
		LogWarning("'" + member.DeclaringType.FullName + ":" + member.Name + "' Warning: " + warning);
	}

	public ManagedUnrealModuleInfo()
	{
		Classes = new List<ManagedUnrealTypeInfo>();
		Structs = new List<ManagedUnrealTypeInfo>();
		Enums = new List<ManagedUnrealEnumInfo>();
		Interfaces = new List<ManagedUnrealTypeInfo>();
		Delegates = new List<ManagedUnrealTypeInfo>();
		ReferencedAssemblies = new HashSet<string>();
		TypeInfosByType = new Dictionary<Type, ManagedUnrealTypeInfo>();
		TypesByTypeInfo = new Dictionary<ManagedUnrealTypeInfo, Type>();
		TypeInfosByPath = new Dictionary<string, ManagedUnrealTypeInfo>();
	}

	static ManagedUnrealModuleInfo()
	{
		NumWarnings = 0;
		SkipValidation = false;
		UseBlittableStructResolving = false;
		seenAssemblies = new HashSet<Assembly>();
		resolvedStructCtorDtorFlags = new Dictionary<Type, EStructFlags>();
		cachedFunctionFlags = new Dictionary<MethodInfo, CachedFunctionFlagInfo>();
		cachedDummyFunctionInfo = new ManagedUnrealFunctionInfo();
		cachedClassFlags = new Dictionary<Type, KeyValuePair<EClassFlags, ManagedUnrealTypeInfoFlags>>();
		cachedClassConfigName = new Dictionary<Type, string>();
		cachedDummyClassInfo = new ManagedUnrealTypeInfo();
		cachedBlueprintability = new Dictionary<Type, Blueprintability>();
		cachedCalculatedEnumSize = new Dictionary<Type, byte>();
		cachedImplementedInterfaces = new Dictionary<Type, List<Type>>();
		cachedImplementedInterfacesFunctionMap = new Dictionary<Type, Dictionary<MethodInfo, MethodInfo>>();
		unexportableTypes = new HashSet<Type>();
		Modules = new List<ManagedUnrealModuleInfo>();
		ModulesByType = new Dictionary<Type, ManagedUnrealModuleInfo>();
		ModulesByAssembly = new Dictionary<Assembly, ManagedUnrealModuleInfo>();
		seenAssemblies = new HashSet<Assembly>();
		AllTypesByPath = new Dictionary<string, Type>();
		AllTypeInfosByPath = new Dictionary<string, ManagedUnrealTypeInfo>();
		AllKnownUnrealTypes = new Dictionary<string, Type>();
		AllKnownBlittableTypes = new Dictionary<string, Type>();
		AllKnownNonBlittableTypes = new Dictionary<string, Type>();
		PreProcessAssemblies();
		codeSettings = new CodeGeneratorSettings();
		codeSettings.Load();
	}

	public static void PreProcessAssemblies()
	{
		List<Assembly> list = new List<Assembly>(CurrentAssemblyContext.GetAssemblies());
		list.Sort(delegate(Assembly a, Assembly b)
		{
			AssemblyName[] referencedAssemblies = a.GetReferencedAssemblies();
			for (int i = 0; i < referencedAssemblies.Length; i++)
			{
				if (referencedAssemblies[i].FullName == b.FullName)
				{
					return 1;
				}
			}
			referencedAssemblies = b.GetReferencedAssemblies();
			for (int i = 0; i < referencedAssemblies.Length; i++)
			{
				if (referencedAssemblies[i].FullName == a.FullName)
				{
					return -1;
				}
			}
			return 0;
		});
		Assembly[] array = list.ToArray();
		for (int num = 0; num < array.Length; num++)
		{
			PreProcessAssembly(array[num]);
		}
	}

	internal static void PreProcessAssembly(Assembly assembly)
	{
		if (seenAssemblies.Contains(assembly))
		{
			return;
		}
		seenAssemblies.Add(assembly);
		UnrealTypes.Load(assembly);
		if (!UnrealTypes.Assemblies.TryGetValue(assembly, out var value))
		{
			return;
		}
		foreach (Type item in value)
		{
			UUnrealTypePathAttribute pathAttribute = UnrealTypes.GetPathAttribute(item);
			if (!pathAttribute.IsManagedType)
			{
				AllTypesByPath[pathAttribute.Path] = item;
			}
			string path = pathAttribute.Path;
			AllKnownUnrealTypes[path] = item;
			if (!item.IsValueType)
			{
				continue;
			}
			bool flag = true;
			MethodInfo[] methods = item.GetMethods(BindingFlags.Static | BindingFlags.Public);
			for (int i = 0; i < methods.Length; i++)
			{
				if (methods[i].Name == "FromNative")
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				AllKnownBlittableTypes[path] = item;
			}
			else
			{
				AllKnownNonBlittableTypes[path] = item;
			}
		}
	}

	public static void Load()
	{
		Modules.Clear();
		ModulesByType.Clear();
		ModulesByAssembly.Clear();
		seenAssemblies.Clear();
		AllTypesByPath.Clear();
		AllTypeInfosByPath.Clear();
		AllKnownUnrealTypes.Clear();
		AllKnownBlittableTypes.Clear();
		AllKnownNonBlittableTypes.Clear();
		PreProcessAssemblies();
		HashSet<string> hashSet = new HashSet<string>();
		hashSet.Add(Assembly.GetExecutingAssembly().GetName().Name);
		foreach (KeyValuePair<Assembly, Type> item in UnrealTypes.AssemblySerializedModuleInfo)
		{
			ManagedUnrealModuleInfo managedUnrealModuleInfo = LoadModuleFromAssembly(item.Key, item.Value);
			hashSet.Add(managedUnrealModuleInfo.AssemblyName);
		}
		if (!File.Exists(UnrealTypes.GameAssemblyPath))
		{
			return;
		}
		string directoryName = System.IO.Path.GetDirectoryName(UnrealTypes.GameAssemblyPath);
		foreach (ManagedUnrealModuleInfo module in Modules)
		{
			foreach (string referencedAssembly in module.ReferencedAssemblies)
			{
				if (!hashSet.Add(referencedAssembly))
				{
					continue;
				}
				string text = System.IO.Path.Combine(directoryName, referencedAssembly + ".dll");
				if (File.Exists(text))
				{
					try
					{
						CurrentAssemblyContext.LoadFrom(text);
					}
					catch
					{
					}
				}
			}
		}
	}

	public static ManagedUnrealModuleInfo LoadModuleFromAssembly(Assembly assembly)
	{
		Type serializedModuleInfoTypeFromAssembly = GetSerializedModuleInfoTypeFromAssembly(assembly);
		if (serializedModuleInfoTypeFromAssembly != null)
		{
			return LoadModuleFromAssembly(assembly, serializedModuleInfoTypeFromAssembly);
		}
		return null;
	}

	private static ManagedUnrealModuleInfo LoadModuleFromAssembly(Assembly assembly, Type serializedModuleInfoType)
	{
		ManagedUnrealModuleInfo managedUnrealModuleInfo = ManagedUnrealReflectionBase.Deserialize<ManagedUnrealModuleInfo>(((ISerializedManagedUnrealModuleInfo)Activator.CreateInstance(serializedModuleInfoType)).GetString());
		if (managedUnrealModuleInfo != null)
		{
			Modules.Add(managedUnrealModuleInfo);
			ModulesByAssembly.Add(assembly, managedUnrealModuleInfo);
			managedUnrealModuleInfo.OnDeserialized(assembly);
			return managedUnrealModuleInfo;
		}
		return null;
	}

	public static Type GetSerializedModuleInfoTypeFromAssembly(Assembly assembly)
	{
		UnrealTypes.AssemblySerializedModuleInfo.TryGetValue(assembly, out var value);
		return value;
	}

	public static bool AssemblyHasSerializedModuleInfo(Assembly assembly)
	{
		return GetSerializedModuleInfoTypeFromAssembly(assembly) != null;
	}

	public static ManagedUnrealModuleInfo CreateModuleFromAssembly(Assembly assembly)
	{
		if (!seenAssemblies.Contains(assembly))
		{
			PreProcessAssembly(assembly);
		}
		ManagedUnrealModuleInfo value = null;
		if (ModulesByAssembly.TryGetValue(assembly, out value))
		{
			return value;
		}
		value = new ManagedUnrealModuleInfo();
		value.AssemblyName = assembly.GetName().Name;
		Modules.Add(value);
		ModulesByAssembly.Add(assembly, value);
		StringBuilder stringBuilder = new StringBuilder(value.AssemblyName);
		char[] source = new char[1] { '.' };
		for (int i = 0; i < value.AssemblyName.Length; i++)
		{
			if (source.Contains(value.AssemblyName[i]))
			{
				stringBuilder[i] = '-';
			}
		}
		value.ModuleName = stringBuilder.ToString();
		Type[] types = assembly.GetTypes();
		foreach (Type type in types)
		{
			if (value.TypeInfosByType.ContainsKey(type))
			{
				continue;
			}
			if (ManagedUnrealTypeInfo.IsExportableType(type))
			{
				string typeNameWithoutPrefix = ManagedUnrealTypeInfo.GetTypeNameWithoutPrefix(type, ManagedUnrealTypeInfo.GetTypeCode(type));
				if (!value.typesByName.TryGetValue(typeNameWithoutPrefix, out var value2))
				{
					value.typesByName.Add(typeNameWithoutPrefix, value2 = new List<Type>());
				}
				value2.Add(type);
				value.ProcessType(type);
			}
			else
			{
				unexportableTypes.Add(type);
			}
		}
		if (UseBlittableStructResolving)
		{
			value.ResolveStructBlittableStates();
		}
		value.LateResolveMissingClassFlags();
		return value;
	}

	private void LateResolveMissingClassFlags()
	{
		foreach (ManagedUnrealTypeInfo @class in Classes)
		{
			if (TryGetClassFlags(@class, TypesByTypeInfo[@class], lateResolve: true, out var outFlags, out var classConfigName))
			{
				@class.ClassFlags |= outFlags.Key;
				@class.AdditionalFlags |= outFlags.Value;
				@class.ClassConfigName = classConfigName;
			}
		}
		foreach (ManagedUnrealTypeInfo @interface in Interfaces)
		{
			if (TryGetClassFlags(@interface, TypesByTypeInfo[@interface], lateResolve: true, out var outFlags2, out var classConfigName2))
			{
				@interface.ClassFlags |= outFlags2.Key;
				@interface.AdditionalFlags |= outFlags2.Value;
				@interface.ClassConfigName = classConfigName2;
			}
		}
	}

	private void ResolveStructBlittableStates()
	{
		Dictionary<Type, ManagedUnrealTypeInfo> dictionary = new Dictionary<Type, ManagedUnrealTypeInfo>();
		Dictionary<Type, HashSet<Type>> dictionary2 = new Dictionary<Type, HashSet<Type>>();
		foreach (KeyValuePair<Type, ManagedUnrealTypeInfo> item in TypeInfosByType)
		{
			if (item.Value.TypeCode != EPropertyType.Struct)
			{
				continue;
			}
			dictionary.Add(item.Key, item.Value);
			HashSet<Type> hashSet = new HashSet<Type>();
			dictionary2.Add(item.Key, hashSet);
			BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
			FieldInfo[] fields = item.Key.GetFields(bindingAttr);
			foreach (FieldInfo fieldInfo in fields)
			{
				if (fieldInfo.FieldType.IsValueType && dictionary.ContainsKey(fieldInfo.FieldType))
				{
					hashSet.Add(fieldInfo.FieldType);
				}
			}
		}
		HashSet<Type> hashSet2 = new HashSet<Type>();
		foreach (Type key in dictionary2.Keys)
		{
			if (!hashSet2.Contains(key))
			{
				ResolveStructBlittableStateAndDependencies(key, dictionary, dictionary2, hashSet2);
			}
		}
	}

	private void ResolveStructBlittableStateAndDependencies(Type type, Dictionary<Type, ManagedUnrealTypeInfo> structTypes, Dictionary<Type, HashSet<Type>> structDepends, HashSet<Type> resolvedStructs)
	{
		ManagedUnrealTypeInfo managedUnrealTypeInfo = structTypes[type];
		if (managedUnrealTypeInfo.BlittableKind != ManagedUnrealBlittableKind.Unresolved)
		{
			return;
		}
		while (structDepends[type].Count > 0)
		{
			Type type2 = structDepends[type].First();
			if (!resolvedStructs.Contains(type2))
			{
				ResolveStructBlittableStateAndDependencies(type2, structTypes, structDepends, resolvedStructs);
			}
			structDepends[type].Remove(type2);
		}
		managedUnrealTypeInfo.BlittableKind = ManagedUnrealBlittableKind.Blittable;
		foreach (ManagedUnrealPropertyInfo property in managedUnrealTypeInfo.Properties)
		{
			ManagedUnrealBlittableKind blittableKind = GetBlittableKind(property.Type);
			if (blittableKind == ManagedUnrealBlittableKind.NotBlittable || blittableKind == ManagedUnrealBlittableKind.Unresolved)
			{
				managedUnrealTypeInfo.BlittableKind = ManagedUnrealBlittableKind.NotBlittable;
				break;
			}
		}
		resolvedStructs.Add(type);
	}

	private void OnDeserialized(Assembly assembly)
	{
		if (!seenAssemblies.Contains(assembly))
		{
			PreProcessAssembly(assembly);
		}
		TypeInfosByType.Clear();
		TypesByTypeInfo.Clear();
		TypeInfosByPath.Clear();
		List<ManagedUnrealTypeInfo> list = new List<ManagedUnrealTypeInfo>();
		list.AddRange(Classes);
		list.AddRange(Structs);
		list.AddRange(Enums);
		list.AddRange(Interfaces);
		list.AddRange(Delegates);
		foreach (ManagedUnrealTypeInfo item in list)
		{
			TypeInfosByPath.Add(item.Path, item);
		}
		if (UnrealTypes.Assemblies.TryGetValue(assembly, out var value))
		{
			foreach (Type item2 in value)
			{
				if (UnrealTypes.Managed.TryGetValue(item2, out var value2))
				{
					ManagedUnrealTypeInfo managedUnrealTypeInfo = TypeInfosByPath[value2.Path];
					TypeInfosByType.Add(item2, managedUnrealTypeInfo);
					TypesByTypeInfo.Add(managedUnrealTypeInfo, item2);
				}
			}
		}
		foreach (KeyValuePair<ManagedUnrealTypeInfo, Type> item3 in TypesByTypeInfo)
		{
			ModulesByType.Add(item3.Value, this);
			AllTypeInfosByPath.Add(item3.Key.Path, item3.Key);
			AllTypesByPath.Add(item3.Key.Path, item3.Value);
		}
	}

	private string GetTypePath(Type type)
	{
		return GetTypePath(type, ManagedUnrealTypeInfo.GetTypeCode(type));
	}

	private string GetTypePath(Type type, EPropertyType typeCode)
	{
		if (!seenAssemblies.Contains(type.Assembly))
		{
			CreateModuleFromAssembly(type.Assembly);
		}
		UMetaPathAttribute nativePathAttribute = UnrealTypes.GetNativePathAttribute(type);
		if (nativePathAttribute != null)
		{
			ReferencedAssemblies.Add(type.Assembly.GetName().Name);
			return nativePathAttribute.Path;
		}
		switch (typeCode)
		{
		case EPropertyType.Enum:
		case EPropertyType.Interface:
		case EPropertyType.Struct:
		case EPropertyType.Object:
		case EPropertyType.Delegate:
		case EPropertyType.MulticastDelegate:
		{
			ManagedUnrealTypeInfo managedUnrealTypeInfo = FindType(type, typeCode);
			if (managedUnrealTypeInfo == null)
			{
				ProcessType(type);
				managedUnrealTypeInfo = FindType(type);
			}
			if (managedUnrealTypeInfo != null)
			{
				ReferencedAssemblies.Add(type.Assembly.GetName().Name);
				return managedUnrealTypeInfo.Path;
			}
			return null;
		}
		case EPropertyType.Class:
		case EPropertyType.LazyObject:
		case EPropertyType.WeakObject:
		case EPropertyType.SoftClass:
		case EPropertyType.SoftObject:
			return GetTypePath(type.GenericTypeArguments[0]);
		default:
			return null;
		}
	}

	private ManagedUnrealTypeInfo ProcessType(Type type)
	{
		if (unexportableTypes.Contains(type))
		{
			return null;
		}
		if (!ManagedUnrealTypeInfo.IsExportableType(type))
		{
			unexportableTypes.Add(type);
			return null;
		}
		if (!ModulesByAssembly.TryGetValue(type.Assembly, out var value))
		{
			value = CreateModuleFromAssembly(type.Assembly);
		}
		if (value != this)
		{
			value.ProcessType(type);
			return null;
		}
		ManagedUnrealTypeInfo managedUnrealTypeInfo = CreateTypeInfoDecl(type);
		if (managedUnrealTypeInfo == null)
		{
			return null;
		}
		switch (managedUnrealTypeInfo.TypeCode)
		{
		case EPropertyType.Object:
			Classes.Add(managedUnrealTypeInfo);
			break;
		case EPropertyType.Struct:
			Structs.Add(managedUnrealTypeInfo);
			break;
		case EPropertyType.Enum:
			if (!(managedUnrealTypeInfo is ManagedUnrealEnumInfo item))
			{
				return null;
			}
			Enums.Add(item);
			break;
		case EPropertyType.Interface:
			Interfaces.Add(managedUnrealTypeInfo);
			break;
		case EPropertyType.Delegate:
		case EPropertyType.MulticastDelegate:
			Delegates.Add(managedUnrealTypeInfo);
			break;
		default:
			return null;
		}
		TypeInfosByType.Add(type, managedUnrealTypeInfo);
		TypesByTypeInfo.Add(managedUnrealTypeInfo, type);
		TypeInfosByPath.Add(managedUnrealTypeInfo.Path, managedUnrealTypeInfo);
		ModulesByType.Add(type, this);
		AllTypeInfosByPath.Add(managedUnrealTypeInfo.Path, managedUnrealTypeInfo);
		AllTypesByPath.Add(managedUnrealTypeInfo.Path, type);
		CreateTypeInfoBody(managedUnrealTypeInfo, type);
		return managedUnrealTypeInfo;
	}

	private string GetUniqueMemberName(ManagedUnrealTypeInfo typeInfo, ManagedUnrealPropertyInfo propertyInfo, MemberInfo member)
	{
		return member.Name;
	}

	private string GetUniqueMemberName(ManagedUnrealTypeInfo typeInfo, ManagedUnrealFunctionInfo functionInfo, MemberInfo member)
	{
		string text = member.Name;
		if (codeSettings.UseExplicitImplementationMethods && functionInfo.IsBlueprintEvent && functionInfo.IsOverride && member.Name.EndsWith(codeSettings.VarNames.ImplementationMethod))
		{
			text = text.Substring(0, text.Length - codeSettings.VarNames.ImplementationMethod.Length);
		}
		return text;
	}

	private string GetUniqueTypeName(ManagedUnrealTypeInfo typeInfo, Type type)
	{
		string text = ManagedUnrealTypeInfo.GetTypeNameWithoutPrefix(type, typeInfo.TypeCode);
		EPropertyType typeCode = typeInfo.TypeCode;
		if ((uint)(typeCode - 21) <= 1u)
		{
			text += "__DelegateSignature";
		}
		if (typesByName.TryGetValue(text, out var value) && value.Count > 1)
		{
			throw new ManagedUnrealTypeInfoException("TODO: Handle type name conflicts. Conflicting types: " + Environment.NewLine + string.Join(Environment.NewLine, value.Select((Type x) => x.FullName)));
		}
		return text;
	}

	private ManagedUnrealTypeInfo CreateTypeInfoDecl(Type type)
	{
		EPropertyType typeCode = ManagedUnrealTypeInfo.GetTypeCode(type);
		switch (typeCode)
		{
		case EPropertyType.Enum:
		case EPropertyType.Interface:
		case EPropertyType.Struct:
		case EPropertyType.Object:
		case EPropertyType.Delegate:
		case EPropertyType.MulticastDelegate:
			return CreateTypeInfoDecl(type, typeCode);
		default:
			return null;
		}
	}

	private ManagedUnrealTypeInfo CreateTypeInfoDecl(Type type, EPropertyType typeCode)
	{
		ManagedUnrealTypeInfo managedUnrealTypeInfo = null;
		managedUnrealTypeInfo = ((typeCode != EPropertyType.Enum) ? new ManagedUnrealTypeInfo() : new ManagedUnrealEnumInfo());
		managedUnrealTypeInfo.TypeCode = typeCode;
		switch (typeCode)
		{
		case EPropertyType.Enum:
		case EPropertyType.Interface:
		case EPropertyType.Struct:
		case EPropertyType.Object:
		case EPropertyType.Delegate:
		case EPropertyType.MulticastDelegate:
			managedUnrealTypeInfo.FullName = type.FullName;
			managedUnrealTypeInfo.Name = GetUniqueTypeName(managedUnrealTypeInfo, type);
			managedUnrealTypeInfo.Path = GlobalConf.ModulePathFix("/Script/" + ModuleName + "." + managedUnrealTypeInfo.Name);
			break;
		}
		if (typeCode == EPropertyType.Struct && type.IsSubclassOf(typeof(StructAsClass)))
		{
			managedUnrealTypeInfo.IsStructAsClass = true;
		}
		if (managedUnrealTypeInfo.IsClass || managedUnrealTypeInfo.IsInterface)
		{
			if (!TryGetClassFlags(managedUnrealTypeInfo, type, lateResolve: false, out var outFlags, out var classConfigName))
			{
				return null;
			}
			managedUnrealTypeInfo.ClassFlags = outFlags.Key;
			managedUnrealTypeInfo.AdditionalFlags = outFlags.Value;
			managedUnrealTypeInfo.ClassConfigName = classConfigName;
		}
		else
		{
			IEnumerable<ManagedUnrealAttributeBase> customAttributes = type.GetCustomAttributes<ManagedUnrealAttributeBase>(inherit: false);
			if (customAttributes != null)
			{
				foreach (ManagedUnrealAttributeBase item in customAttributes)
				{
					switch (typeCode)
					{
					case EPropertyType.Struct:
						item.ProcessStruct(managedUnrealTypeInfo);
						break;
					case EPropertyType.Enum:
						item.ProcessEnum(managedUnrealTypeInfo);
						break;
					case EPropertyType.Delegate:
					case EPropertyType.MulticastDelegate:
						item.ProcessDelegate(managedUnrealTypeInfo);
						break;
					default:
						throw new NotImplementedException();
					}
					if (item.InvalidTarget)
					{
						if (item.InvalidTargetReason != null)
						{
							throw new InvalidManagedUnrealAttributeException(type, item);
						}
						return null;
					}
				}
			}
			SetBlueprintability(managedUnrealTypeInfo, type);
		}
		return managedUnrealTypeInfo;
	}

	private void CreateTypeInfoBody(ManagedUnrealTypeInfo typeInfo, Type type)
	{
		switch (typeInfo.TypeCode)
		{
		case EPropertyType.Object:
			UpdateBaseType(typeInfo, type);
			ProcessProperties(typeInfo, type);
			ProcessFunctions(typeInfo, type);
			typeInfo.BlittableKind = (codeSettings.UObjectAsBlittableType ? ManagedUnrealBlittableKind.Blittable : ManagedUnrealBlittableKind.NotBlittable);
			ValidateClass(typeInfo, type);
			break;
		case EPropertyType.Struct:
		{
			UpdateBaseType(typeInfo, type);
			if (typeInfo.IsStructAsClass)
			{
				ProcessProperties(typeInfo, type);
				typeInfo.BlittableKind = ManagedUnrealBlittableKind.NotBlittable;
				break;
			}
			if (typeInfo.BlittableKind != ManagedUnrealBlittableKind.ForceBlittable)
			{
				typeInfo.BlittableKind = ManagedUnrealBlittableKind.Unresolved;
			}
			ProcessStructFields(typeInfo, type);
			if (typeInfo.BlittableKind != ManagedUnrealBlittableKind.Unresolved)
			{
				break;
			}
			bool flag = true;
			foreach (ManagedUnrealPropertyInfo property in typeInfo.Properties)
			{
				switch (GetBlittableKind(property.Type))
				{
				case ManagedUnrealBlittableKind.NotBlittable:
					typeInfo.BlittableKind = ManagedUnrealBlittableKind.NotBlittable;
					flag = false;
					goto end_IL_00f8;
				case ManagedUnrealBlittableKind.Unresolved:
					flag = false;
					goto end_IL_00f8;
				}
				continue;
				end_IL_00f8:
				break;
			}
			if (flag)
			{
				typeInfo.BlittableKind = ManagedUnrealBlittableKind.Blittable;
			}
			else if (!UseBlittableStructResolving)
			{
				typeInfo.BlittableKind = ManagedUnrealBlittableKind.NotBlittable;
			}
			break;
		}
		case EPropertyType.Interface:
			UpdateBaseType(typeInfo, type);
			ProcessFunctions(typeInfo, type);
			break;
		case EPropertyType.Enum:
		{
			ManagedUnrealEnumInfo managedUnrealEnumInfo = typeInfo as ManagedUnrealEnumInfo;
			UpdateBaseType(managedUnrealEnumInfo, type);
			ProcessEnumValues(managedUnrealEnumInfo, type);
			break;
		}
		case EPropertyType.Delegate:
		case EPropertyType.MulticastDelegate:
			ProcessDelegateSignature(typeInfo, type);
			break;
		case EPropertyType.Class:
		case EPropertyType.LazyObject:
		case EPropertyType.WeakObject:
		case EPropertyType.SoftClass:
		case EPropertyType.SoftObject:
			break;
		}
	}

	private List<Type> GetImplementedInterfaces(Type type)
	{
		if (cachedImplementedInterfaces.TryGetValue(type, out var value))
		{
			return value;
		}
		List<Type> list = new List<Type>();
		List<Type> list2 = new List<Type>();
		list.AddRange(type.GetInterfaces());
		if (type.BaseType != null)
		{
			Type[] interfaces = type.BaseType.GetInterfaces();
			foreach (Type item in interfaces)
			{
				list.Remove(item);
			}
		}
		foreach (Type item2 in list)
		{
			if (ManagedUnrealTypeInfo.GetTypeCode(item2) == EPropertyType.Interface)
			{
				list2.Add(item2);
			}
		}
		cachedImplementedInterfaces.Add(type, list2);
		return list2;
	}

	private void UpdateBaseType(ManagedUnrealTypeInfo typeInfo, Type type)
	{
		Dictionary<Type, EPropertyType> dictionary = new Dictionary<Type, EPropertyType>();
		if (type.BaseType != null)
		{
			dictionary.Add(type.BaseType, ManagedUnrealTypeInfo.GetTypeCode(type));
		}
		foreach (Type implementedInterface in GetImplementedInterfaces(type))
		{
			dictionary.Add(implementedInterface, EPropertyType.Interface);
		}
		bool flag = typeInfo is ManagedUnrealEnumInfo;
		typeInfo.BaseTypes.Clear();
		foreach (KeyValuePair<Type, EPropertyType> item in new Dictionary<Type, EPropertyType>(dictionary))
		{
			switch (item.Value)
			{
			case EPropertyType.Interface:
			case EPropertyType.Object:
			{
				string typePath = GetTypePath(item.Key, item.Value);
				if (!flag && !string.IsNullOrEmpty(typePath))
				{
					typeInfo.BaseTypes.Add(new ManagedUnrealTypeInfoReference(item.Value, typePath));
				}
				break;
			}
			case EPropertyType.Int8:
			case EPropertyType.Int16:
			case EPropertyType.Int:
			case EPropertyType.Int64:
			case EPropertyType.Byte:
			case EPropertyType.UInt16:
			case EPropertyType.UInt32:
			case EPropertyType.UInt64:
				if (flag)
				{
					typeInfo.BaseTypes.Add(new ManagedUnrealTypeInfoReference(item.Value));
				}
				break;
			}
		}
	}

	private void ProcessDelegateSignature(ManagedUnrealTypeInfo typeInfo, Type type)
	{
		List<Type> list = new List<Type>();
		type.GetNestedTypes();
		Type[] nestedTypes = type.GetNestedTypes();
		foreach (Type type2 in nestedTypes)
		{
			if (type2.IsSubclassOf(typeof(Delegate)))
			{
				list.Add(type2);
			}
		}
		if (list.Count != 1)
		{
			throw new InvalidUnrealDelegateException(type, "Bad delegate signature count . Found: " + list.Count + " Expected: 1. (The \"delegate signature\" is the singular nested delegate typically with a name of \"Signature\" which defines the signature of your delegate)");
		}
		MethodInfo method = list[0].GetMethod("Invoke");
		ManagedUnrealFunctionInfo managedUnrealFunctionInfo = CreateFunction(typeInfo, type, method);
		if (managedUnrealFunctionInfo != null)
		{
			managedUnrealFunctionInfo.Flags |= EFunctionFlags.Public | EFunctionFlags.Delegate;
			if (typeInfo.TypeCode == EPropertyType.MulticastDelegate)
			{
				managedUnrealFunctionInfo.Flags |= EFunctionFlags.MulticastDelegate;
			}
			managedUnrealFunctionInfo.Name = GetUniqueMemberName(typeInfo, managedUnrealFunctionInfo, method);
			managedUnrealFunctionInfo.Path = typeInfo.Path + ":" + managedUnrealFunctionInfo.Name;
			typeInfo.Functions.Add(managedUnrealFunctionInfo);
			ValidateDelegate(typeInfo, type, managedUnrealFunctionInfo, method);
		}
	}

	private void ProcessEnumValues(ManagedUnrealEnumInfo enumInfo, Type type)
	{
		byte calculatedEnumByteSize;
		foreach (KeyValuePair<string, ulong> enumNamesValue in type.GetEnumNamesValues(out calculatedEnumByteSize))
		{
			ManagedUnrealEnumValueInfo managedUnrealEnumValueInfo = new ManagedUnrealEnumValueInfo();
			managedUnrealEnumValueInfo.Name = enumNamesValue.Key;
			managedUnrealEnumValueInfo.Value = enumNamesValue.Value;
			enumInfo.EnumValues.Add(managedUnrealEnumValueInfo);
		}
		if (!cachedCalculatedEnumSize.ContainsKey(type))
		{
			cachedCalculatedEnumSize.Add(type, calculatedEnumByteSize);
		}
		SetBlueprintability(enumInfo, type);
		ValidateEnum(enumInfo, type);
	}

	private byte GetEnumByteSize(Type type)
	{
		if (!cachedCalculatedEnumSize.TryGetValue(type, out var value))
		{
			value = type.GetEnumByteSize();
			cachedCalculatedEnumSize.Add(type, value);
		}
		return value;
	}

	private void ProcessStructFields(ManagedUnrealTypeInfo typeInfo, Type type)
	{
		int num = 0;
		int num2 = 0;
		BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
		FieldInfo[] fields = type.GetFields(bindingAttr);
		foreach (FieldInfo fieldInfo in fields)
		{
			num++;
			ManagedUnrealPropertyInfo managedUnrealPropertyInfo = CreateProperty(fieldInfo);
			if (managedUnrealPropertyInfo != null)
			{
				num2++;
				managedUnrealPropertyInfo.IsField = true;
				managedUnrealPropertyInfo.Name = GetUniqueMemberName(typeInfo, managedUnrealPropertyInfo, fieldInfo);
				managedUnrealPropertyInfo.Path = typeInfo.Path + ":" + managedUnrealPropertyInfo.Name;
				typeInfo.Properties.Add(managedUnrealPropertyInfo);
				ValidateProperty(typeInfo, type, managedUnrealPropertyInfo, fieldInfo.FieldType, fieldInfo);
			}
		}
		if (num != num2)
		{
			typeInfo.BlittableKind = ManagedUnrealBlittableKind.NotBlittable;
		}
		ValidateNoUnrealExposedProperties(typeInfo, type);
	}

	private void ProcessProperties(ManagedUnrealTypeInfo typeInfo, Type type)
	{
		BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
		PropertyInfo[] properties = type.GetProperties(bindingAttr);
		foreach (PropertyInfo propertyInfo in properties)
		{
			ManagedUnrealPropertyInfo managedUnrealPropertyInfo = CreateProperty(propertyInfo);
			if (managedUnrealPropertyInfo != null)
			{
				if (typeInfo.ClassFlags.HasFlag(EClassFlags.Const))
				{
					managedUnrealPropertyInfo.Flags |= EPropertyFlags.BlueprintReadOnly;
				}
				managedUnrealPropertyInfo.Name = GetUniqueMemberName(typeInfo, managedUnrealPropertyInfo, propertyInfo);
				managedUnrealPropertyInfo.Path = typeInfo.Path + ":" + managedUnrealPropertyInfo.Name;
				typeInfo.Properties.Add(managedUnrealPropertyInfo);
				ValidateProperty(typeInfo, type, managedUnrealPropertyInfo, propertyInfo.PropertyType, propertyInfo);
			}
		}
		ValidateNoUnrealExposedFields(typeInfo, type);
	}

	private bool IsPropertyExposedToBlueprint(ManagedUnrealPropertyInfo propertyInfo)
	{
		EPropertyFlags ePropertyFlags = EPropertyFlags.BlueprintVisible | EPropertyFlags.BlueprintAssignable | EPropertyFlags.BlueprintCallable;
		return (propertyInfo.Flags & ePropertyFlags) != 0;
	}

	private bool IsTypeExposedToBlueprint(ManagedUnrealTypeInfo typeInfo)
	{
		ManagedUnrealTypeInfoFlags managedUnrealTypeInfoFlags = ManagedUnrealTypeInfoFlags.BlueprintTypeHierarchical | ManagedUnrealTypeInfoFlags.BlueprintableHierarchical;
		return (typeInfo.AdditionalFlags & managedUnrealTypeInfoFlags) != 0;
	}

	private bool IsFunctionExposedToBlueprint(ManagedUnrealFunctionInfo functionInfo)
	{
		EFunctionFlags eFunctionFlags = EFunctionFlags.BlueprintCallable | EFunctionFlags.BlueprintEvent;
		return (functionInfo.Flags & eFunctionFlags) != 0;
	}

	private ManagedUnrealPropertyInfo CreateProperty(Type type)
	{
		ManagedUnrealPropertyInfo managedUnrealPropertyInfo = new ManagedUnrealPropertyInfo();
		if (type.IsByRef && type.HasElementType)
		{
			type = type.GetElementType();
		}
		EPropertyType typeCode = ManagedUnrealTypeInfo.GetTypeCode(type);
		ManagedUnrealTypeInfoReference managedUnrealTypeInfoReference = null;
		switch (typeCode)
		{
		case EPropertyType.Enum:
		case EPropertyType.Interface:
		case EPropertyType.Struct:
		case EPropertyType.Class:
		case EPropertyType.Object:
		case EPropertyType.LazyObject:
		case EPropertyType.WeakObject:
		case EPropertyType.SoftClass:
		case EPropertyType.SoftObject:
		case EPropertyType.Delegate:
		case EPropertyType.MulticastDelegate:
		{
			string typePath = GetTypePath(type, typeCode);
			if (string.IsNullOrEmpty(typePath))
			{
				break;
			}
			managedUnrealTypeInfoReference = new ManagedUnrealTypeInfoReference(typeCode, typePath);
			EClassFlags eClassFlags = EClassFlags.None;
			Type value2;
			if (TypeInfosByPath.TryGetValue(typePath, out var value))
			{
				eClassFlags = value.ClassFlags;
			}
			else if (AllTypesByPath.TryGetValue(typePath, out value2))
			{
				UClassAttribute customAttribute = value2.GetCustomAttribute<UClassAttribute>();
				if (customAttribute != null)
				{
					eClassFlags = (EClassFlags)customAttribute.Flags;
				}
			}
			if ((eClassFlags & EClassFlags.DefaultToInstanced) == EClassFlags.DefaultToInstanced)
			{
				managedUnrealPropertyInfo.Flags |= EPropertyFlags.ExportObject | EPropertyFlags.InstancedReference;
			}
			break;
		}
		case EPropertyType.InternalNativeFixedSizeArray:
		case EPropertyType.InternalManagedFixedSizeArray:
			managedUnrealTypeInfoReference = new ManagedUnrealTypeInfoReference(typeCode);
			if (type.IsArray)
			{
				CreateGenericArgsTypeRefs(managedUnrealPropertyInfo, type.GetElementType());
			}
			else
			{
				CreateGenericArgsTypeRefs(managedUnrealPropertyInfo, type.GenericTypeArguments[0]);
			}
			break;
		case EPropertyType.Array:
			managedUnrealTypeInfoReference = new ManagedUnrealTypeInfoReference(typeCode);
			CreateGenericArgsTypeRefs(managedUnrealPropertyInfo, type.GenericTypeArguments[0]);
			break;
		case EPropertyType.Set:
			managedUnrealTypeInfoReference = new ManagedUnrealTypeInfoReference(typeCode);
			CreateGenericArgsTypeRefs(managedUnrealPropertyInfo, type.GenericTypeArguments[0]);
			if (!ManagedUnrealTypeInfo.HasGetTypeHash(managedUnrealPropertyInfo.GenericArgs[0].TypeCode))
			{
				return null;
			}
			break;
		case EPropertyType.Map:
			managedUnrealTypeInfoReference = new ManagedUnrealTypeInfoReference(typeCode);
			if (type == null || type.GenericTypeArguments.Length < 2)
			{
				return null;
			}
			CreateGenericArgsTypeRefs(managedUnrealPropertyInfo, type.GenericTypeArguments[0], type.GenericTypeArguments[1]);
			if (!ManagedUnrealTypeInfo.HasGetTypeHash(managedUnrealPropertyInfo.GenericArgs[0].TypeCode))
			{
				return null;
			}
			break;
		case EPropertyType.Bool:
		case EPropertyType.Int8:
		case EPropertyType.Int16:
		case EPropertyType.Int:
		case EPropertyType.Int64:
		case EPropertyType.Byte:
		case EPropertyType.UInt16:
		case EPropertyType.UInt32:
		case EPropertyType.UInt64:
		case EPropertyType.Double:
		case EPropertyType.Float:
		case EPropertyType.Str:
		case EPropertyType.Name:
		case EPropertyType.Text:
			managedUnrealTypeInfoReference = new ManagedUnrealTypeInfoReference(typeCode);
			break;
		default:
			return null;
		}
		if (managedUnrealTypeInfoReference == null)
		{
			return null;
		}
		foreach (ManagedUnrealTypeInfoReference genericArg in managedUnrealPropertyInfo.GenericArgs)
		{
			if (genericArg.TypeCode == EPropertyType.Unknown)
			{
				return null;
			}
		}
		managedUnrealPropertyInfo.Type = managedUnrealTypeInfoReference;
		return managedUnrealPropertyInfo;
	}

	private void CreateGenericArgsTypeRefs(ManagedUnrealPropertyInfo propertyInfo, params Type[] typeArgs)
	{
		propertyInfo.GenericArgs.AddRange(CreateGenericArgsTypeRefs(typeArgs));
	}

	private ManagedUnrealTypeInfoReference[] CreateGenericArgsTypeRefs(params Type[] typeArgs)
	{
		ManagedUnrealTypeInfoReference[] array = new ManagedUnrealTypeInfoReference[typeArgs.Length];
		for (int i = 0; i < typeArgs.Length; i++)
		{
			Type type = typeArgs[i];
			ManagedUnrealTypeInfoReference managedUnrealTypeInfoReference = new ManagedUnrealTypeInfoReference();
			managedUnrealTypeInfoReference.TypeCode = ManagedUnrealTypeInfo.GetTypeCode(type);
			managedUnrealTypeInfoReference.Path = GetTypePath(type, managedUnrealTypeInfoReference.TypeCode);
			array[i] = managedUnrealTypeInfoReference;
		}
		return array;
	}

	private ManagedUnrealPropertyInfo CreateProperty(MethodInfo method, ParameterInfo parameter)
	{
		ManagedUnrealPropertyInfo managedUnrealPropertyInfo = CreateProperty(parameter.ParameterType);
		if (managedUnrealPropertyInfo == null)
		{
			return null;
		}
		if (parameter.ParameterType.IsArray)
		{
			return null;
		}
		if (parameter.IsOut)
		{
			managedUnrealPropertyInfo.IsOut = true;
		}
		else if (parameter.ParameterType.IsByRef)
		{
			managedUnrealPropertyInfo.IsByRef = true;
		}
		IEnumerable<ManagedUnrealAttributeBase> customAttributes = parameter.GetCustomAttributes<ManagedUnrealAttributeBase>(inherit: false);
		if (customAttributes != null)
		{
			foreach (ManagedUnrealAttributeBase item in customAttributes)
			{
				item.ProcessProperty(managedUnrealPropertyInfo);
				if (item.InvalidTarget)
				{
					if (item.InvalidTargetReason != null)
					{
						throw new InvalidManagedUnrealAttributeException(method, parameter, item);
					}
					return null;
				}
			}
		}
		return managedUnrealPropertyInfo;
	}

	private ManagedUnrealPropertyInfo CreateProperty(MemberInfo member)
	{
		Type type = null;
		PropertyInfo propertyInfo = member as PropertyInfo;
		if (propertyInfo != null)
		{
			type = propertyInfo.PropertyType;
		}
		FieldInfo fieldInfo = member as FieldInfo;
		if (fieldInfo != null)
		{
			type = fieldInfo.FieldType;
		}
		if (type == null)
		{
			return null;
		}
		ManagedUnrealPropertyInfo managedUnrealPropertyInfo = CreateProperty(type);
		if (managedUnrealPropertyInfo == null)
		{
			if (member.GetCustomAttribute<UPropertyAttribute>(inherit: false) != null)
			{
				Console.WriteLine("[WARNING] Property '" + member.DeclaringType.FullName + ":" + member.Name + "' flagged as a [UProperty] is invalid and cannot be exported. Make sure the target type is valid and is exportable.");
				NumWarnings++;
			}
			return null;
		}
		if (propertyInfo != null)
		{
			MethodInfo methodInfo = ((propertyInfo.GetMethod != null) ? propertyInfo.GetMethod : propertyInfo.SetMethod);
			if (methodInfo.IsPublic)
			{
				managedUnrealPropertyInfo.IsPublic = true;
			}
			else if (methodInfo.IsPrivate)
			{
				managedUnrealPropertyInfo.IsPrivate = true;
			}
			else
			{
				managedUnrealPropertyInfo.IsProtected = true;
			}
		}
		else if (fieldInfo != null)
		{
			if (fieldInfo.IsPublic)
			{
				managedUnrealPropertyInfo.IsPublic = true;
			}
			else if (fieldInfo.IsPrivate)
			{
				managedUnrealPropertyInfo.IsPrivate = true;
			}
			else
			{
				managedUnrealPropertyInfo.IsProtected = true;
			}
		}
		IEnumerable<ManagedUnrealAttributeBase> customAttributes = member.GetCustomAttributes<ManagedUnrealAttributeBase>(inherit: false);
		if (customAttributes != null)
		{
			foreach (ManagedUnrealAttributeBase item in customAttributes)
			{
				item.ProcessProperty(managedUnrealPropertyInfo);
				if (item.InvalidTarget)
				{
					if (item.InvalidTargetReason != null)
					{
						throw new InvalidManagedUnrealAttributeException(member, item);
					}
					return null;
				}
			}
		}
		if (managedUnrealPropertyInfo.AdditionalFlags.HasFlag(ManagedUnrealPropertyFlags.BlueprintGetter) && !managedUnrealPropertyInfo.AdditionalFlags.HasFlag(ManagedUnrealPropertyFlags.BlueprintSetter))
		{
			managedUnrealPropertyInfo.Flags |= EPropertyFlags.BlueprintReadOnly;
		}
		switch (ManagedUnrealVisibility.PropertyRequirement)
		{
		case ManagedUnrealVisibility.Requirement.MainAttribute:
			if (!managedUnrealPropertyInfo.AdditionalFlags.HasFlag(ManagedUnrealPropertyFlags.UProperty))
			{
				return null;
			}
			break;
		case ManagedUnrealVisibility.Requirement.AnyAttribute:
			if (!member.HasCustomAttribute<ManagedUnrealAttributeBase>(inherit: false) && !member.HasCustomAttribute<UMetaAttribute>(inherit: false))
			{
				return null;
			}
			break;
		}
		if (ManagedUnrealVisibility.Members != ManagedUnrealVisibility.Member.None)
		{
			if ((managedUnrealPropertyInfo.Flags & (EPropertyFlags.BlueprintVisible | EPropertyFlags.BlueprintReadOnly)) == ~EPropertyFlags.AllFlags)
			{
				if (ManagedUnrealVisibility.Members.HasFlag(ManagedUnrealVisibility.Member.BlueprintVisible))
				{
					managedUnrealPropertyInfo.Flags |= EPropertyFlags.BlueprintVisible;
				}
				else if (ManagedUnrealVisibility.Members.HasFlag(ManagedUnrealVisibility.Member.BlueprintVisibleReadOnly))
				{
					managedUnrealPropertyInfo.Flags |= EPropertyFlags.BlueprintReadOnly;
				}
			}
			if ((managedUnrealPropertyInfo.Flags & EPropertyFlags.Edit) == ~EPropertyFlags.AllFlags)
			{
				if (ManagedUnrealVisibility.Members.HasFlag(ManagedUnrealVisibility.Member.EditorVisible))
				{
					managedUnrealPropertyInfo.Flags |= EPropertyFlags.Edit;
				}
				else if (ManagedUnrealVisibility.Members.HasFlag(ManagedUnrealVisibility.Member.EditorVisibleReadOnly))
				{
					managedUnrealPropertyInfo.Flags |= EPropertyFlags.Edit | EPropertyFlags.EditConst;
				}
			}
		}
		return managedUnrealPropertyInfo;
	}

	private bool IsMethodCompilerGenerated(MethodInfo method)
	{
		return method.GetCustomAttribute<CompilerGeneratedAttribute>(inherit: false) != null;
	}

	private void ProcessFunctions(ManagedUnrealTypeInfo typeInfo, Type type)
	{
		if (!typeInfo.IsInterface)
		{
			MethodInfo method = type.GetMethod("Initialize", new Type[1] { typeof(FObjectInitializer) });
			if (method != null)
			{
				if (method.DeclaringType == type)
				{
					typeInfo.OverridesObjectInitializer = true;
					typeInfo.OverridesObjectInitializerHierarchical = true;
				}
				else if (method.DeclaringType != typeof(UObject))
				{
					typeInfo.OverridesObjectInitializerHierarchical = true;
				}
			}
		}
		BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
		BindingFlags bindingAttr2 = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
		MethodInfo[] methods = type.GetMethods(bindingAttr);
		Array.Sort(methods, (MethodInfo info, MethodInfo methodInfo2) => info.Name.Length - methodInfo2.Name.Length);
		MethodInfo[] array = methods;
		foreach (MethodInfo methodInfo in array)
		{
			if (methodInfo.IsSpecialName || (methodInfo.Name.EndsWith(codeSettings.VarNames.RPCValidate) && type.GetMethod(methodInfo.Name.Substring(0, methodInfo.Name.Length - codeSettings.VarNames.RPCValidate.Length), bindingAttr2) != null) || (!codeSettings.UseExplicitImplementationMethods && methodInfo.Name.EndsWith(codeSettings.VarNames.ImplementationMethod) && type.GetMethod(methodInfo.Name.Substring(0, methodInfo.Name.Length - codeSettings.VarNames.ImplementationMethod.Length), bindingAttr2) != null))
			{
				continue;
			}
			ManagedUnrealFunctionInfo managedUnrealFunctionInfo = CreateFunction(typeInfo, type, methodInfo);
			if (managedUnrealFunctionInfo != null)
			{
				ValidateFunction(typeInfo, type, managedUnrealFunctionInfo, methodInfo);
				if (!managedUnrealFunctionInfo.IsImplementation || managedUnrealFunctionInfo.IsOverride)
				{
					managedUnrealFunctionInfo.Name = GetUniqueMemberName(typeInfo, managedUnrealFunctionInfo, methodInfo);
					managedUnrealFunctionInfo.Path = typeInfo.Path + ":" + managedUnrealFunctionInfo.Name;
					typeInfo.Functions.Add(managedUnrealFunctionInfo);
				}
			}
		}
	}

	private MethodInfo GetBaseInterfaceMethod(MethodInfo method)
	{
		Type declaringType = method.DeclaringType;
		if (!cachedImplementedInterfacesFunctionMap.TryGetValue(declaringType, out var value))
		{
			List<Type> implementedInterfaces = GetImplementedInterfaces(declaringType);
			if (implementedInterfaces.Count <= 0)
			{
				return method;
			}
			value = new Dictionary<MethodInfo, MethodInfo>();
			foreach (Type item in implementedInterfaces)
			{
				InterfaceMapping interfaceMap = declaringType.GetInterfaceMap(item);
				for (int i = 0; i < interfaceMap.InterfaceMethods.Length; i++)
				{
					value[interfaceMap.TargetMethods[i]] = interfaceMap.InterfaceMethods[i];
				}
			}
			cachedImplementedInterfacesFunctionMap.Add(declaringType, value);
		}
		if (value.TryGetValue(method, out var value2))
		{
			return value2;
		}
		return method;
	}

	private MethodInfo GetOriginalMethodDefinition(MethodInfo method)
	{
		if (method.GetBaseDefinition() == method)
		{
			string text = null;
			if (method.Name.EndsWith(codeSettings.VarNames.ImplementationMethod))
			{
				text = method.Name.Substring(0, method.Name.Length - codeSettings.VarNames.ImplementationMethod.Length);
			}
			else if (method.Name.EndsWith(codeSettings.VarNames.RPCValidate))
			{
				text = method.Name.Substring(0, method.Name.Length - codeSettings.VarNames.RPCValidate.Length);
			}
			if (!string.IsNullOrEmpty(text))
			{
				MethodInfo[] methods = method.DeclaringType.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				foreach (MethodInfo methodInfo in methods)
				{
					if (methodInfo.Name == text)
					{
						return methodInfo;
					}
				}
			}
		}
		return method;
	}

	private bool TryGetFunctionFlags(ManagedUnrealFunctionInfo functionInfo, MethodInfo method, out CachedFunctionFlagInfo outFlags)
	{
		if (cachedFunctionFlags.TryGetValue(method, out outFlags))
		{
			return true;
		}
		MethodInfo originalMethodDefinition = GetOriginalMethodDefinition(method);
		if (originalMethodDefinition != method && cachedFunctionFlags.TryGetValue(originalMethodDefinition, out outFlags))
		{
			cachedFunctionFlags.Add(method, outFlags);
			return true;
		}
		if (functionInfo == null)
		{
			functionInfo = cachedDummyFunctionInfo;
			functionInfo.Flags = ~EFunctionFlags.AllFlags;
			functionInfo.AdditionalFlags = ManagedUnrealFunctionFlags.None;
		}
		IEnumerable<ManagedUnrealAttributeBase> customAttributes = originalMethodDefinition.GetCustomAttributes<ManagedUnrealAttributeBase>(inherit: false);
		if (customAttributes != null)
		{
			foreach (ManagedUnrealAttributeBase item in customAttributes)
			{
				item.ProcessFunction(functionInfo);
				item.ProcessFunctionParams(functionInfo);
				if (item.InvalidTarget)
				{
					if (item.InvalidTargetReason != null)
					{
						throw new InvalidManagedUnrealAttributeException(originalMethodDefinition, item);
					}
					outFlags = null;
					return false;
				}
			}
		}
		EFunctionFlags eFunctionFlags = functionInfo.Flags;
		ManagedUnrealFunctionFlags managedUnrealFunctionFlags = functionInfo.AdditionalFlags;
		string originalName = functionInfo.OriginalName;
		MethodInfo methodInfo = method.GetBaseDefinition();
		if (methodInfo == method)
		{
			methodInfo = GetBaseInterfaceMethod(method);
		}
		CachedFunctionFlagInfo outFlags2;
		if (!(methodInfo != method))
		{
			eFunctionFlags = (originalMethodDefinition.IsPublic ? (eFunctionFlags | EFunctionFlags.Public) : ((!originalMethodDefinition.IsPrivate) ? (eFunctionFlags | EFunctionFlags.Protected) : (eFunctionFlags | EFunctionFlags.Private)));
		}
		else if (TryGetFunctionFlags(null, methodInfo, out outFlags2))
		{
			originalName = outFlags2.OriginalName;
			managedUnrealFunctionFlags = outFlags2.AdditionalFlags & ManagedUnrealFunctionFlags.UFunction;
			if (methodInfo.DeclaringType.IsInterface)
			{
				managedUnrealFunctionFlags |= ManagedUnrealFunctionFlags.InterfaceImplementation;
			}
			bool num = eFunctionFlags.HasFlag(EFunctionFlags.Final);
			eFunctionFlags |= outFlags2.Flags & EFunctionFlags.FuncInherit;
			if (num)
			{
				eFunctionFlags |= EFunctionFlags.Final;
			}
		}
		if (ManagedUnrealVisibility.Members.HasFlag(ManagedUnrealVisibility.Member.BlueprintCallable))
		{
			eFunctionFlags |= EFunctionFlags.BlueprintCallable;
		}
		outFlags = new CachedFunctionFlagInfo(eFunctionFlags, managedUnrealFunctionFlags, originalName);
		cachedFunctionFlags.Add(originalMethodDefinition, outFlags);
		if (method != originalMethodDefinition)
		{
			cachedFunctionFlags.Add(method, outFlags);
		}
		return true;
	}

	private void SetBlueprintability(ManagedUnrealTypeInfo typeInfo, Type type)
	{
		Blueprintability blueprintability = GetBlueprintability(type, typeInfo.TypeCode);
		if (blueprintability.HasFlag(Blueprintability.BlueprintType))
		{
			typeInfo.AdditionalFlags |= ManagedUnrealTypeInfoFlags.BlueprintTypeHierarchical;
		}
		if (blueprintability.HasFlag(Blueprintability.ManagedTypeBlueprintType))
		{
			typeInfo.AdditionalFlags |= ManagedUnrealTypeInfoFlags.BlueprintTypeStateManaged;
		}
		if (blueprintability.HasFlag(Blueprintability.Blueprintable))
		{
			typeInfo.AdditionalFlags |= ManagedUnrealTypeInfoFlags.BlueprintableHierarchical;
		}
		if (blueprintability.HasFlag(Blueprintability.ManagedTypeBlueprintable))
		{
			typeInfo.AdditionalFlags |= ManagedUnrealTypeInfoFlags.BlueprintableStateManaged;
		}
	}

	private Blueprintability GetBlueprintability(Type type, EPropertyType typeCode)
	{
		if (cachedBlueprintability.TryGetValue(type, out var value))
		{
			return value;
		}
		value = Blueprintability.None;
		if ((typeCode == EPropertyType.Object || typeCode == EPropertyType.Interface) && type.IsSameOrSubclassOf(typeof(UBlueprintFunctionLibrary)))
		{
			value = Blueprintability.BlueprintType;
		}
		if ((value & (Blueprintability.BlueprintType | Blueprintability.NotBlueprintType | Blueprintability.ManagedTypeBlueprintType)) == 0)
		{
			bool num = type.HasCustomAttribute<BlueprintSpawnableComponent>(inherit: false);
			bool flag = type.HasCustomAttribute<BlueprintTypeAttribute>(inherit: false);
			bool flag2 = type.HasCustomAttribute<NotBlueprintTypeAttribute>(inherit: false);
			if (num || flag)
			{
				value |= Blueprintability.BlueprintType;
				if (!UnrealTypes.IsNativeUnrealType(type))
				{
					value |= Blueprintability.ManagedTypeBlueprintType;
				}
			}
			else if (flag2)
			{
				value |= Blueprintability.NotBlueprintType;
				if (!UnrealTypes.IsNativeUnrealType(type))
				{
					value |= Blueprintability.ManagedTypeBlueprintType;
				}
			}
		}
		if ((value & (Blueprintability.Blueprintable | Blueprintability.NotBlueprintable | Blueprintability.ManagedTypeBlueprintable)) == 0)
		{
			bool num2 = type.HasCustomAttribute<BlueprintableAttribute>(inherit: false);
			bool flag3 = type.HasCustomAttribute<NotBlueprintableAttribute>(inherit: false);
			if (num2)
			{
				value |= Blueprintability.Blueprintable;
				if (!UnrealTypes.IsNativeUnrealType(type))
				{
					value |= Blueprintability.ManagedTypeBlueprintable;
				}
			}
			else if (flag3)
			{
				value |= Blueprintability.NotBlueprintable;
				if (!UnrealTypes.IsNativeUnrealType(type))
				{
					value |= Blueprintability.ManagedTypeBlueprintable;
				}
			}
		}
		if (typeCode == EPropertyType.Object || typeCode == EPropertyType.Interface)
		{
			if (type.BaseType != null && type.BaseType != typeof(UObject))
			{
				Blueprintability blueprintability = GetBlueprintability(type.BaseType, EPropertyType.Object);
				if ((value & (Blueprintability.BlueprintType | Blueprintability.NotBlueprintType | Blueprintability.ManagedTypeBlueprintType)) == 0)
				{
					value |= blueprintability & (Blueprintability.BlueprintType | Blueprintability.NotBlueprintType | Blueprintability.ManagedTypeBlueprintType);
				}
				if ((value & (Blueprintability.Blueprintable | Blueprintability.NotBlueprintable | Blueprintability.ManagedTypeBlueprintable)) == 0)
				{
					value |= blueprintability & (Blueprintability.Blueprintable | Blueprintability.NotBlueprintable | Blueprintability.ManagedTypeBlueprintable);
				}
			}
			Type[] interfaces = type.GetInterfaces();
			foreach (Type type2 in interfaces)
			{
				Blueprintability blueprintability2 = GetBlueprintability(type2, EPropertyType.Interface);
				if ((value & (Blueprintability.BlueprintType | Blueprintability.NotBlueprintType | Blueprintability.ManagedTypeBlueprintType)) == 0)
				{
					value |= blueprintability2 & (Blueprintability.BlueprintType | Blueprintability.NotBlueprintType | Blueprintability.ManagedTypeBlueprintType);
				}
				if ((value & (Blueprintability.Blueprintable | Blueprintability.NotBlueprintable | Blueprintability.ManagedTypeBlueprintable)) == 0)
				{
					value |= blueprintability2 & (Blueprintability.Blueprintable | Blueprintability.NotBlueprintable | Blueprintability.ManagedTypeBlueprintable);
				}
			}
		}
		ManagedUnrealVisibility.Type type3 = ManagedUnrealVisibility.Type.None;
		switch (typeCode)
		{
		case EPropertyType.Object:
			type3 = ManagedUnrealVisibility.Class;
			break;
		case EPropertyType.Interface:
			type3 = ManagedUnrealVisibility.Interface;
			break;
		case EPropertyType.Struct:
			type3 = ManagedUnrealVisibility.Struct;
			break;
		case EPropertyType.Enum:
			type3 = ManagedUnrealVisibility.Enum;
			break;
		}
		if (type3.HasFlag(ManagedUnrealVisibility.Type.BlueprintType) && !value.HasFlag(Blueprintability.ManagedTypeBlueprintType) && !UnrealTypes.IsNativeUnrealType(type))
		{
			value &= ~(Blueprintability.BlueprintType | Blueprintability.NotBlueprintType | Blueprintability.ManagedTypeBlueprintType);
			value |= Blueprintability.BlueprintType | Blueprintability.ManagedTypeBlueprintType;
		}
		if (type3.HasFlag(ManagedUnrealVisibility.Type.Blueprintable) && !value.HasFlag(Blueprintability.ManagedTypeBlueprintable) && !UnrealTypes.IsNativeUnrealType(type))
		{
			value &= ~(Blueprintability.Blueprintable | Blueprintability.NotBlueprintable | Blueprintability.ManagedTypeBlueprintable);
			value |= Blueprintability.Blueprintable | Blueprintability.ManagedTypeBlueprintable;
		}
		cachedBlueprintability.Add(type, value);
		return value;
	}

	private bool TryGetClassFlags(ManagedUnrealTypeInfo typeInfo, Type type, bool lateResolve, out KeyValuePair<EClassFlags, ManagedUnrealTypeInfoFlags> outFlags, out string classConfigName)
	{
		EClassFlags eClassFlags = EClassFlags.None;
		ManagedUnrealTypeInfoFlags managedUnrealTypeInfoFlags = ManagedUnrealTypeInfoFlags.None;
		bool flag = false;
		if (cachedClassFlags.TryGetValue(type, out outFlags))
		{
			eClassFlags = outFlags.Key;
			managedUnrealTypeInfoFlags = outFlags.Value;
			cachedClassConfigName.TryGetValue(type, out classConfigName);
		}
		else
		{
			flag = true;
			if (typeInfo == null)
			{
				typeInfo = cachedDummyClassInfo;
				typeInfo.Flags = 0u;
				typeInfo.AdditionalFlags = ManagedUnrealTypeInfoFlags.None;
				typeInfo.ClassConfigName = null;
			}
			if (typeInfo.IsInterface)
			{
				typeInfo.ClassFlags |= EClassFlags.Abstract | EClassFlags.Interface;
			}
			IEnumerable<ManagedUnrealAttributeBase> customAttributes = type.GetCustomAttributes<ManagedUnrealAttributeBase>(inherit: false);
			if (customAttributes != null)
			{
				foreach (ManagedUnrealAttributeBase item in customAttributes)
				{
					if (typeInfo.IsInterface)
					{
						item.ProcessInterface(typeInfo);
					}
					else
					{
						item.ProcessClass(typeInfo);
					}
					if (item.InvalidTarget)
					{
						if (item.InvalidTargetReason != null)
						{
							throw new InvalidManagedUnrealAttributeException(type, item);
						}
						outFlags = new KeyValuePair<EClassFlags, ManagedUnrealTypeInfoFlags>(EClassFlags.None, ManagedUnrealTypeInfoFlags.None);
						classConfigName = null;
						return false;
					}
				}
			}
			eClassFlags = typeInfo.ClassFlags;
			managedUnrealTypeInfoFlags = typeInfo.AdditionalFlags;
			classConfigName = typeInfo.ClassConfigName;
			Blueprintability blueprintability = GetBlueprintability(type, typeInfo.TypeCode);
			if (blueprintability.HasFlag(Blueprintability.BlueprintType))
			{
				managedUnrealTypeInfoFlags |= ManagedUnrealTypeInfoFlags.BlueprintTypeHierarchical;
			}
			if (blueprintability.HasFlag(Blueprintability.Blueprintable))
			{
				managedUnrealTypeInfoFlags |= ManagedUnrealTypeInfoFlags.BlueprintableHierarchical;
			}
			bool flag2 = false;
			UUnrealTypePathAttribute pathAttribute = UnrealTypes.GetPathAttribute(type);
			if (pathAttribute != null && !string.IsNullOrEmpty(pathAttribute.Path))
			{
				UClassAttribute customAttribute = type.GetCustomAttribute<UClassAttribute>(inherit: false);
				if (customAttribute != null)
				{
					eClassFlags = (EClassFlags)customAttribute.Flags;
					managedUnrealTypeInfoFlags |= ManagedUnrealTypeInfoFlags.HasLateResolvedClassFlags | ManagedUnrealTypeInfoFlags.UClass;
					flag2 = true;
				}
				UInterfaceAttribute customAttribute2 = type.GetCustomAttribute<UInterfaceAttribute>(inherit: false);
				if (customAttribute2 != null)
				{
					eClassFlags = (EClassFlags)customAttribute2.Flags;
					managedUnrealTypeInfoFlags |= ManagedUnrealTypeInfoFlags.HasLateResolvedClassFlags | ManagedUnrealTypeInfoFlags.UInterface;
					flag2 = true;
				}
				if (pathAttribute.Path == "/Script/Engine.Actor")
				{
					managedUnrealTypeInfoFlags |= ManagedUnrealTypeInfoFlags.Actor;
				}
			}
			if (!flag2)
			{
				if (type.BaseType != null && type.BaseType != typeof(object) && TryGetClassFlags(null, type.BaseType, lateResolve, out var outFlags2, out var classConfigName2))
				{
					eClassFlags |= outFlags2.Key & EClassFlags.Inherit;
					if (!string.IsNullOrEmpty(classConfigName2) && (string.IsNullOrEmpty(classConfigName) || classConfigName.Equals("inherit", StringComparison.CurrentCultureIgnoreCase)))
					{
						classConfigName = classConfigName2;
					}
					if (outFlags2.Value.HasFlag(ManagedUnrealTypeInfoFlags.Actor))
					{
						managedUnrealTypeInfoFlags |= ManagedUnrealTypeInfoFlags.Actor;
					}
				}
				Type[] interfaces = type.GetInterfaces();
				foreach (Type type2 in interfaces)
				{
					if (type2.GetCustomAttribute<UInterfaceAttribute>(inherit: false) == null)
					{
						continue;
					}
					managedUnrealTypeInfoFlags |= ManagedUnrealTypeInfoFlags.ImplementsInterface;
					if (TryGetClassFlags(null, type2, lateResolve, out var outFlags3, out var classConfigName3))
					{
						eClassFlags |= outFlags3.Key & EClassFlags.Inherit;
						if (!string.IsNullOrEmpty(classConfigName3) && (string.IsNullOrEmpty(classConfigName) || classConfigName.Equals("inherit", StringComparison.CurrentCultureIgnoreCase)))
						{
							classConfigName = classConfigName3;
						}
					}
				}
			}
		}
		if (lateResolve && !managedUnrealTypeInfoFlags.HasFlag(ManagedUnrealTypeInfoFlags.HasLateResolvedClassFlags))
		{
			flag = true;
			if (type.BaseType != null && type.BaseType != typeof(object) && TryGetClassFlags(null, type.BaseType, lateResolve, out var outFlags4, out var classConfigName4))
			{
				eClassFlags |= outFlags4.Key & EClassFlags.Inherit;
				if (!string.IsNullOrEmpty(classConfigName4) && (string.IsNullOrEmpty(classConfigName) || classConfigName.Equals("inherit", StringComparison.CurrentCultureIgnoreCase)))
				{
					classConfigName = classConfigName4;
				}
			}
			if (typeInfo != null && !eClassFlags.HasFlag(EClassFlags.Config))
			{
				foreach (ManagedUnrealPropertyInfo property in typeInfo.Properties)
				{
					if (property.Flags.HasFlag(EPropertyFlags.Config))
					{
						eClassFlags |= EClassFlags.Config;
					}
					if ((property.Flags & (EPropertyFlags.InstancedReference | EPropertyFlags.ContainsInstancedReference)) != ~EPropertyFlags.AllFlags)
					{
						eClassFlags |= EClassFlags.HasInstancedReference;
					}
				}
			}
			if (eClassFlags.HasFlag(EClassFlags.Config) && string.IsNullOrEmpty(classConfigName))
			{
				classConfigName = "Engine";
				throw new ValidateUnrealClassFailedException(type, "Classes with config / globalconfig member variables need to specify config file.");
			}
			managedUnrealTypeInfoFlags |= ManagedUnrealTypeInfoFlags.HasLateResolvedClassFlags;
		}
		outFlags = new KeyValuePair<EClassFlags, ManagedUnrealTypeInfoFlags>(eClassFlags, managedUnrealTypeInfoFlags);
		if (flag)
		{
			cachedClassFlags[type] = outFlags;
			cachedClassConfigName[type] = classConfigName;
		}
		return true;
	}

	private ManagedUnrealFunctionInfo CreateFunction(ManagedUnrealTypeInfo typeInfo, Type type, MethodInfo method)
	{
		if (method.GetCustomAttribute<UFunctionIgnoreAttribute>(inherit: false) != null)
		{
			return null;
		}
		if (method.IsGenericMethod)
		{
			return null;
		}
		ManagedUnrealFunctionInfo managedUnrealFunctionInfo = new ManagedUnrealFunctionInfo();
		managedUnrealFunctionInfo.IsStatic = method.IsStatic;
		managedUnrealFunctionInfo.IsOverride = method.GetBaseDefinition() != method;
		managedUnrealFunctionInfo.IsVirtual = method.IsVirtual && !method.IsFinal && !method.IsAbstract && !managedUnrealFunctionInfo.IsOverride;
		managedUnrealFunctionInfo.IsImplementation = method.Name.EndsWith(codeSettings.VarNames.ImplementationMethod);
		if (!TryGetFunctionFlags(managedUnrealFunctionInfo, method, out var outFlags))
		{
			return null;
		}
		managedUnrealFunctionInfo.Flags |= outFlags.Flags;
		managedUnrealFunctionInfo.AdditionalFlags |= outFlags.AdditionalFlags;
		managedUnrealFunctionInfo.OriginalName = outFlags.OriginalName;
		if (!managedUnrealFunctionInfo.IsStatic && typeInfo.ClassFlags.HasFlag(EClassFlags.Const))
		{
			managedUnrealFunctionInfo.Flags |= EFunctionFlags.Const;
		}
		if (!typeInfo.IsDelegate)
		{
			switch (ManagedUnrealVisibility.FunctionRequirement)
			{
			case ManagedUnrealVisibility.Requirement.MainAttribute:
				if (!managedUnrealFunctionInfo.AdditionalFlags.HasFlag(ManagedUnrealFunctionFlags.UFunction))
				{
					return null;
				}
				break;
			case ManagedUnrealVisibility.Requirement.AnyAttribute:
				if (!managedUnrealFunctionInfo.AdditionalFlags.HasFlag(ManagedUnrealFunctionFlags.UFunction) && !method.HasCustomAttribute<ManagedUnrealAttributeBase>(inherit: false) && !method.HasCustomAttribute<UMetaAttribute>(inherit: false))
				{
					return null;
				}
				break;
			}
		}
		if (managedUnrealFunctionInfo.IsOverride && !managedUnrealFunctionInfo.IsBlueprintEvent)
		{
			return null;
		}
		if (method.ReturnType != typeof(void))
		{
			managedUnrealFunctionInfo.ReturnProp = CreateProperty(method.ReturnType);
			if (managedUnrealFunctionInfo.ReturnProp == null)
			{
				throw new InvalidUnrealFunctionReturnTypeException(method, method.ReturnType);
			}
			managedUnrealFunctionInfo.Flags |= EFunctionFlags.HasOutParms;
			managedUnrealFunctionInfo.ReturnProp.IsFunctionReturnValue = true;
			managedUnrealFunctionInfo.ReturnProp.Name = "ReturnValue";
			ValidateFunctionParam(typeInfo, type, managedUnrealFunctionInfo.ReturnProp, method.ReturnType, method.ReturnParameter, managedUnrealFunctionInfo, method);
		}
		ParameterInfo[] parameters = method.GetParameters();
		foreach (ParameterInfo parameterInfo in parameters)
		{
			ManagedUnrealPropertyInfo managedUnrealPropertyInfo = CreateProperty(method, parameterInfo);
			if (managedUnrealPropertyInfo == null)
			{
				throw new InvalidUnrealFunctionParamTypeException(method, parameterInfo);
			}
			if (managedUnrealPropertyInfo.Flags.HasFlag(EPropertyFlags.OutParm))
			{
				managedUnrealFunctionInfo.Flags |= EFunctionFlags.HasOutParms;
			}
			managedUnrealPropertyInfo.IsFunctionParam = true;
			managedUnrealPropertyInfo.Name = parameterInfo.Name;
			managedUnrealFunctionInfo.Params.Add(managedUnrealPropertyInfo);
			ValidateFunctionParam(typeInfo, type, managedUnrealPropertyInfo, parameterInfo.ParameterType, parameterInfo, managedUnrealFunctionInfo, method);
		}
		if (codeSettings.UseExplicitImplementationMethods && !managedUnrealFunctionInfo.IsImplementation)
		{
			if ((managedUnrealFunctionInfo.IsBlueprintEvent || managedUnrealFunctionInfo.IsRPC) && managedUnrealFunctionInfo.IsVirtual && !typeInfo.IsInterface)
			{
				throw new InvalidUnrealFunctionException(method, "BlueprintEvent/RPC method definitions shouldn't be virtual when using explicit " + codeSettings.VarNames.ImplementationMethod + " methods");
			}
			if (managedUnrealFunctionInfo.IsBlueprintEvent && !managedUnrealFunctionInfo.IsOverride)
			{
				managedUnrealFunctionInfo.IsVirtual = true;
			}
		}
		return managedUnrealFunctionInfo;
	}

	private ManagedUnrealBlittableKind GetBlittableKind(ManagedUnrealTypeInfoReference typeRef)
	{
		switch (typeRef.TypeCode)
		{
		case EPropertyType.Int8:
		case EPropertyType.Int16:
		case EPropertyType.Int:
		case EPropertyType.Int64:
		case EPropertyType.Byte:
		case EPropertyType.UInt16:
		case EPropertyType.UInt32:
		case EPropertyType.UInt64:
		case EPropertyType.Double:
		case EPropertyType.Float:
		case EPropertyType.Name:
			return ManagedUnrealBlittableKind.Blittable;
		case EPropertyType.Object:
			if (!codeSettings.UObjectAsBlittableType)
			{
				return ManagedUnrealBlittableKind.NotBlittable;
			}
			return ManagedUnrealBlittableKind.Blittable;
		case EPropertyType.Struct:
		{
			ManagedUnrealTypeInfo managedUnrealTypeInfo = ManagedUnrealTypeInfo.FindTypeInfoByPath(typeRef.Path);
			if (managedUnrealTypeInfo == null)
			{
				if (AllKnownBlittableTypes.ContainsKey(typeRef.Path))
				{
					return ManagedUnrealBlittableKind.Blittable;
				}
				if (AllKnownNonBlittableTypes.ContainsKey(typeRef.Path))
				{
					return ManagedUnrealBlittableKind.NotBlittable;
				}
				return ManagedUnrealBlittableKind.Unresolved;
			}
			return managedUnrealTypeInfo.BlittableKind;
		}
		default:
			return ManagedUnrealBlittableKind.NotBlittable;
		}
	}

	public ManagedUnrealTypeInfo FindType(Type type)
	{
		return FindType(type, EPropertyType.Unknown);
	}

	public ManagedUnrealTypeInfo FindType(Type type, EPropertyType typeCode)
	{
		if (TypeInfosByType.TryGetValue(type, out var value))
		{
			if (value != null && (value.TypeCode == typeCode || typeCode == EPropertyType.Unknown))
			{
				return value;
			}
		}
		else
		{
			ManagedUnrealModuleInfo managedUnrealModuleInfo = FindModule(type);
			if (managedUnrealModuleInfo != null && managedUnrealModuleInfo != this)
			{
				return managedUnrealModuleInfo.FindType(type, typeCode);
			}
		}
		return null;
	}

	public ManagedUnrealTypeInfo FindStruct(Type type)
	{
		return FindType(type, EPropertyType.Struct);
	}

	public ManagedUnrealTypeInfo FindClass(Type type)
	{
		return FindType(type, EPropertyType.Object);
	}

	public ManagedUnrealEnumInfo FindEnum(Type type)
	{
		return FindType(type, EPropertyType.Enum) as ManagedUnrealEnumInfo;
	}

	public static ManagedUnrealModuleInfo FindModule(Type type)
	{
		ModulesByType.TryGetValue(type, out var value);
		return value;
	}

	public override void Serialize(BinaryWriter writer)
	{
		base.Serialize(writer);
		WriteString(writer, AssemblyName);
		WriteObjects(writer, Classes);
		WriteObjects(writer, Delegates);
		WriteObjects(writer, Enums);
		WriteObjects(writer, Interfaces);
		WriteString(writer, ModuleName);
		WriteStringSet(writer, ReferencedAssemblies);
		WriteObjects(writer, Structs);
	}

	public override void Deserialize(BinaryReader reader)
	{
		base.Deserialize(reader);
		AssemblyName = ReadString(reader);
		Classes = ReadObjects<ManagedUnrealTypeInfo>(reader);
		Delegates = ReadObjects<ManagedUnrealTypeInfo>(reader);
		Enums = ReadObjects<ManagedUnrealEnumInfo>(reader);
		Interfaces = ReadObjects<ManagedUnrealTypeInfo>(reader);
		ModuleName = ReadString(reader);
		ReferencedAssemblies = ReadStringSet(reader);
		Structs = ReadObjects<ManagedUnrealTypeInfo>(reader);
	}
}
