using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Utils;
using ILRuntime.Mono.Cecil;
using ILRuntime.Mono.Cecil.Cil;
using ILRuntime.Mono.Cecil.Mdb;
using ILRuntime.Mono.Cecil.Pdb;
using ILRuntime.Other;
using ILRuntime.Runtime.Adapters;
using ILRuntime.Runtime.CLRBinding;
using ILRuntime.Runtime.Debugger;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Intepreter.RegisterVM;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.Runtime.Enviorment;

public class AppDomain
{
	private Queue<ILIntepreter> freeIntepreters = new Queue<ILIntepreter>();

	private Dictionary<int, ILIntepreter> intepreters = new Dictionary<int, ILIntepreter>();

	private Dictionary<Type, CrossBindingAdaptor> crossAdaptors = new Dictionary<Type, CrossBindingAdaptor>(new ByReferenceKeyComparer<Type>());

	private Dictionary<Type, ValueTypeBinder> valueTypeBinders = new Dictionary<Type, ValueTypeBinder>();

	private ThreadSafeDictionary<string, IType> mapType = new ThreadSafeDictionary<string, IType>();

	private Dictionary<Type, IType> clrTypeMapping = new Dictionary<Type, IType>(new ByReferenceKeyComparer<Type>());

	private List<IType> typesByIndex = new List<IType>();

	private ThreadSafeDictionary<int, IType> mapTypeToken = new ThreadSafeDictionary<int, IType>();

	private ThreadSafeDictionary<int, IMethod> mapMethod = new ThreadSafeDictionary<int, IMethod>();

	private ThreadSafeDictionary<long, string> mapString = new ThreadSafeDictionary<long, string>();

	private Dictionary<MethodBase, CLRRedirectionDelegate> redirectMap = new Dictionary<MethodBase, CLRRedirectionDelegate>();

	private Dictionary<FieldInfo, CLRFieldGetterDelegate> fieldGetterMap = new Dictionary<FieldInfo, CLRFieldGetterDelegate>();

	private Dictionary<FieldInfo, CLRFieldSetterDelegate> fieldSetterMap = new Dictionary<FieldInfo, CLRFieldSetterDelegate>();

	private Dictionary<FieldInfo, KeyValuePair<CLRFieldBindingDelegate, CLRFieldBindingDelegate>> fieldBindingMap = new Dictionary<FieldInfo, KeyValuePair<CLRFieldBindingDelegate, CLRFieldBindingDelegate>>();

	private Dictionary<Type, CLRMemberwiseCloneDelegate> memberwiseCloneMap = new Dictionary<Type, CLRMemberwiseCloneDelegate>(new ByReferenceKeyComparer<Type>());

	private Dictionary<Type, CLRCreateDefaultInstanceDelegate> createDefaultInstanceMap = new Dictionary<Type, CLRCreateDefaultInstanceDelegate>(new ByReferenceKeyComparer<Type>());

	private Dictionary<Type, CLRCreateArrayInstanceDelegate> createArrayInstanceMap = new Dictionary<Type, CLRCreateArrayInstanceDelegate>(new ByReferenceKeyComparer<Type>());

	private IType voidType;

	private IType intType;

	private IType longType;

	private IType boolType;

	private IType floatType;

	private IType doubleType;

	private IType objectType;

	private IType jitAttributeType;

	private DelegateManager dMgr;

	private Assembly[] loadedAssemblies;

	private Dictionary<string, byte[]> references = new Dictionary<string, byte[]>();

	private DebugService debugService;

	private AsyncJITCompileWorker jitWorker = new AsyncJITCompileWorker();

	private int defaultJITFlags;

	private bool IsThreadBinding;

	private bool IsBindingDone;

	private static object bindingLockObject = new object();

	public bool AllowUnboundCLRMethod { get; set; }

	internal bool SuppressStaticConstructor { get; set; }

	public int DefaultJITFlags => defaultJITFlags;

	public IType VoidType => voidType;

	public IType IntType => intType;

	public IType LongType => longType;

	public IType BoolType => boolType;

	public IType FloatType => floatType;

	public IType DoubleType => doubleType;

	public IType ObjectType => objectType;

	public IType JITAttributeType => jitAttributeType;

	public Dictionary<string, IType> LoadedTypes => mapType.InnerDictionary;

	internal Dictionary<MethodBase, CLRRedirectionDelegate> RedirectMap
	{
		get
		{
			if (!IsThreadBinding && IsBindingDone)
			{
				return redirectMap;
			}
			lock (bindingLockObject)
			{
				return redirectMap;
			}
		}
	}

	internal Dictionary<FieldInfo, CLRFieldGetterDelegate> FieldGetterMap
	{
		get
		{
			if (!IsThreadBinding && IsBindingDone)
			{
				return fieldGetterMap;
			}
			lock (bindingLockObject)
			{
				return fieldGetterMap;
			}
		}
	}

	internal Dictionary<FieldInfo, CLRFieldSetterDelegate> FieldSetterMap
	{
		get
		{
			if (!IsThreadBinding && IsBindingDone)
			{
				return fieldSetterMap;
			}
			lock (bindingLockObject)
			{
				return fieldSetterMap;
			}
		}
	}

	internal Dictionary<FieldInfo, KeyValuePair<CLRFieldBindingDelegate, CLRFieldBindingDelegate>> FieldBindingMap
	{
		get
		{
			if (!IsThreadBinding && IsBindingDone)
			{
				return fieldBindingMap;
			}
			lock (bindingLockObject)
			{
				return fieldBindingMap;
			}
		}
	}

	internal Dictionary<Type, CLRMemberwiseCloneDelegate> MemberwiseCloneMap
	{
		get
		{
			if (!IsThreadBinding && IsBindingDone)
			{
				return memberwiseCloneMap;
			}
			lock (bindingLockObject)
			{
				return memberwiseCloneMap;
			}
		}
	}

	internal Dictionary<Type, CLRCreateDefaultInstanceDelegate> CreateDefaultInstanceMap
	{
		get
		{
			if (!IsThreadBinding && IsBindingDone)
			{
				return createDefaultInstanceMap;
			}
			lock (bindingLockObject)
			{
				return createDefaultInstanceMap;
			}
		}
	}

	internal Dictionary<Type, CLRCreateArrayInstanceDelegate> CreateArrayInstanceMap
	{
		get
		{
			if (!IsThreadBinding && IsBindingDone)
			{
				return createArrayInstanceMap;
			}
			lock (bindingLockObject)
			{
				return createArrayInstanceMap;
			}
		}
	}

	internal Dictionary<Type, CrossBindingAdaptor> CrossBindingAdaptors => crossAdaptors;

	internal Dictionary<Type, ValueTypeBinder> ValueTypeBinders
	{
		get
		{
			if (!IsThreadBinding && IsBindingDone)
			{
				return valueTypeBinders;
			}
			lock (bindingLockObject)
			{
				return valueTypeBinders;
			}
		}
	}

	public DebugService DebugService => debugService;

	internal Dictionary<int, ILIntepreter> Intepreters => intepreters;

	internal Queue<ILIntepreter> FreeIntepreters => freeIntepreters;

	public DelegateManager DelegateManager => dMgr;

	public unsafe AppDomain(int defaultJITFlags = 0)
	{
		AllowUnboundCLRMethod = true;
		InvocationContext.InitializeDefaultConverters();
		loadedAssemblies = System.AppDomain.CurrentDomain.GetAssemblies();
		MethodInfo method = typeof(RuntimeHelpers).GetMethod("InitializeArray");
		RegisterCLRMethodRedirection(method, CLRRedirections.InitializeArray);
		method = typeof(AppDomain).GetMethod("GetCurrentStackTrace");
		RegisterCLRMethodRedirection(method, CLRRedirections.GetCurrentStackTrace);
		MethodInfo[] methods = typeof(Activator).GetMethods();
		foreach (MethodInfo methodInfo in methods)
		{
			if (methodInfo.Name == "CreateInstance" && methodInfo.IsGenericMethodDefinition)
			{
				RegisterCLRMethodRedirection(methodInfo, CLRRedirections.CreateInstance);
			}
			else if (methodInfo.Name == "CreateInstance" && methodInfo.GetParameters().Length == 1)
			{
				RegisterCLRMethodRedirection(methodInfo, CLRRedirections.CreateInstance2);
			}
			else if (methodInfo.Name == "CreateInstance" && methodInfo.GetParameters().Length == 2)
			{
				RegisterCLRMethodRedirection(methodInfo, CLRRedirections.CreateInstance3);
			}
		}
		methods = typeof(Type).GetMethods();
		foreach (MethodInfo methodInfo2 in methods)
		{
			if (methodInfo2.Name == "GetType" && methodInfo2.IsStatic)
			{
				RegisterCLRMethodRedirection(methodInfo2, CLRRedirections.GetType);
			}
			if (methodInfo2.Name == "Equals" && methodInfo2.GetParameters()[0].ParameterType == typeof(Type))
			{
				RegisterCLRMethodRedirection(methodInfo2, CLRRedirections.TypeEquals);
			}
			if (methodInfo2.Name == "IsAssignableFrom" && methodInfo2.GetParameters()[0].ParameterType == typeof(Type))
			{
				RegisterCLRMethodRedirection(methodInfo2, CLRRedirections.IsAssignableFrom);
			}
		}
		methods = typeof(Delegate).GetMethods();
		foreach (MethodInfo methodInfo3 in methods)
		{
			if (methodInfo3.Name == "Combine" && methodInfo3.GetParameters().Length == 2)
			{
				RegisterCLRMethodRedirection(methodInfo3, CLRRedirections.DelegateCombine);
			}
			if (methodInfo3.Name == "Remove")
			{
				RegisterCLRMethodRedirection(methodInfo3, CLRRedirections.DelegateRemove);
			}
			if (methodInfo3.Name == "op_Equality")
			{
				RegisterCLRMethodRedirection(methodInfo3, CLRRedirections.DelegateEqulity);
			}
			if (methodInfo3.Name == "op_Inequality")
			{
				RegisterCLRMethodRedirection(methodInfo3, CLRRedirections.DelegateInequlity);
			}
		}
		methods = typeof(MethodBase).GetMethods();
		foreach (MethodInfo methodInfo4 in methods)
		{
			if (methodInfo4.Name == "Invoke" && methodInfo4.GetParameters().Length == 2)
			{
				RegisterCLRMethodRedirection(methodInfo4, CLRRedirections.MethodInfoInvoke);
			}
		}
		methods = typeof(Enum).GetMethods();
		foreach (MethodInfo methodInfo5 in methods)
		{
			if (methodInfo5.Name == "Parse" && methodInfo5.GetParameters().Length == 2)
			{
				RegisterCLRMethodRedirection(methodInfo5, CLRRedirections.EnumParse);
			}
			if (methodInfo5.Name == "GetValues" && methodInfo5.GetParameters().Length == 1)
			{
				RegisterCLRMethodRedirection(methodInfo5, CLRRedirections.EnumGetValues);
			}
			if (methodInfo5.Name == "GetNames" && methodInfo5.GetParameters().Length == 1)
			{
				RegisterCLRMethodRedirection(methodInfo5, CLRRedirections.EnumGetNames);
			}
			if (methodInfo5.Name == "GetName")
			{
				RegisterCLRMethodRedirection(methodInfo5, CLRRedirections.EnumGetName);
			}
			if (methodInfo5.Name == "HasFlag")
			{
				RegisterCLRMethodRedirection(methodInfo5, CLRRedirections.EnumHasFlag);
			}
			if (methodInfo5.Name == "CompareTo")
			{
				RegisterCLRMethodRedirection(methodInfo5, CLRRedirections.EnumCompareTo);
			}
			if (methodInfo5.Name == "ToObject" && methodInfo5.GetParameters()[1].ParameterType == typeof(int))
			{
				RegisterCLRMethodRedirection(methodInfo5, CLRRedirections.EnumToObject);
			}
		}
		method = typeof(Type).GetMethod("GetTypeFromHandle");
		RegisterCLRMethodRedirection(method, CLRRedirections.GetTypeFromHandle);
		method = typeof(Type).GetMethod("MakeGenericType");
		RegisterCLRMethodRedirection(method, CLRRedirections.TypeMakeGenericType);
		method = typeof(object).GetMethod("GetType");
		RegisterCLRMethodRedirection(method, CLRRedirections.ObjectGetType);
		method = typeof(Delegate).GetMethod("CreateDelegate", new Type[2]
		{
			typeof(Type),
			typeof(MethodInfo)
		});
		RegisterCLRMethodRedirection(method, CLRRedirections.DelegateCreateDelegate);
		method = typeof(Delegate).GetMethod("CreateDelegate", new Type[3]
		{
			typeof(Type),
			typeof(object),
			typeof(string)
		});
		RegisterCLRMethodRedirection(method, CLRRedirections.DelegateCreateDelegate2);
		method = typeof(Delegate).GetMethod("CreateDelegate", new Type[3]
		{
			typeof(Type),
			typeof(object),
			typeof(MethodInfo)
		});
		RegisterCLRMethodRedirection(method, CLRRedirections.DelegateCreateDelegate3);
		method = typeof(Delegate).GetMethod("get_Target");
		RegisterCLRMethodRedirection(method, CLRRedirections.DelegateGetTarget);
		dMgr = new DelegateManager(this);
		dMgr.RegisterDelegateConvertor<Action>((Delegate dele) => dele);
		RegisterCrossBindingAdaptor(new AttributeAdapter());
		debugService = new DebugService(this);
		this.defaultJITFlags = defaultJITFlags & 3;
	}

	public void Dispose()
	{
		debugService.StopDebugService();
		jitWorker.Dispose();
	}

	internal void EnqueueJITCompileJob(ILMethod method)
	{
		jitWorker.QueueCompileJob(method);
	}

	public void LoadAssemblyFile(string path)
	{
		if (!new FileInfo(path).Exists)
		{
			throw new FileNotFoundException($"Assembly File not find!:\r\n{path}");
		}
		using FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
		LoadAssembly(fileStream);
		fileStream.Dispose();
	}

	public string GetCurrentStackTrace()
	{
		throw new NotSupportedException("Cannot call this method from CLR side");
	}

	public void LoadAssemblyFileAndSymbol(string path)
	{
		FileInfo fileInfo = new FileInfo(path);
		if (!fileInfo.Exists)
		{
			throw new FileNotFoundException($"Assembly File not find!:\r\n{path}");
		}
		string directoryName = fileInfo.DirectoryName;
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileInfo.Name);
		string text = $"{directoryName}/{fileNameWithoutExtension}.pdb";
		string text2 = $"{directoryName}/{fileNameWithoutExtension}.mdb";
		string text3 = "";
		bool flag = true;
		if (File.Exists(text))
		{
			text3 = text;
		}
		else if (File.Exists(text2))
		{
			text3 = text2;
			flag = false;
		}
		if (string.IsNullOrEmpty(text3))
		{
			throw new FileNotFoundException($"symbol file not find!:\r\ncheck:\r\n{text}\r\n{text2}\r\n");
		}
		using FileStream stream = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read);
		using FileStream symbol = new FileStream(text3, FileMode.Open);
		if (flag)
		{
			LoadAssemblyPDB(stream, symbol);
		}
		else
		{
			LoadAssemblyMDB(stream, symbol);
		}
	}

	public void LoadAssemblyFileAndPDB(string assemblyFilePath, string symbolFilePath)
	{
		FileInfo fileInfo = new FileInfo(assemblyFilePath);
		FileInfo fileInfo2 = new FileInfo(symbolFilePath);
		if (!fileInfo.Exists)
		{
			throw new FileNotFoundException($"Assembly File not find!:\r\n{assemblyFilePath}");
		}
		if (!fileInfo2.Exists)
		{
			throw new FileNotFoundException($"symbol file not find!:\r\n{symbolFilePath}");
		}
		using FileStream stream = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read);
		using FileStream symbol = new FileStream(fileInfo2.FullName, FileMode.Open);
		LoadAssemblyPDB(stream, symbol);
	}

	public void LoadAssemblyPDB(Stream stream, Stream symbol)
	{
		LoadAssembly(stream, symbol, new PdbReaderProvider());
	}

	public void LoadAssemblyFileAndMDB(string assemblyFilePath, string symbolFilePath)
	{
		FileInfo fileInfo = new FileInfo(assemblyFilePath);
		FileInfo fileInfo2 = new FileInfo(symbolFilePath);
		if (!fileInfo.Exists)
		{
			throw new FileNotFoundException($"Assembly File not find!:\r\n{assemblyFilePath}");
		}
		if (!fileInfo2.Exists)
		{
			throw new FileNotFoundException($"symbol file not find!:\r\n{symbolFilePath}");
		}
		using FileStream stream = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read);
		using FileStream symbol = new FileStream(fileInfo2.FullName, FileMode.Open);
		LoadAssemblyMDB(stream, symbol);
	}

	public void LoadAssemblyMDB(Stream stream, Stream symbol)
	{
		LoadAssembly(stream, symbol, new MdbReaderProvider());
	}

	public void LoadAssembly(Stream stream)
	{
		LoadAssembly(stream, null, null);
	}

	public void LoadAssembly(Stream stream, Stream symbol, ISymbolReaderProvider symbolReader)
	{
		ModuleDefinition moduleDefinition = ModuleDefinition.ReadModule(stream);
		if (symbolReader != null && symbol != null)
		{
			moduleDefinition.ReadSymbols(symbolReader.GetSymbolReader(moduleDefinition, symbol));
		}
		_ = moduleDefinition.HasAssemblyReferences;
		if (moduleDefinition.HasTypes)
		{
			List<ILType> list = new List<ILType>();
			foreach (TypeDefinition type in moduleDefinition.GetTypes())
			{
				ILType iLType = new ILType(type, this);
				mapType[type.FullName] = iLType;
				mapTypeToken[iLType.GetHashCode()] = iLType;
				list.Add(iLType);
			}
		}
		if (voidType == null)
		{
			voidType = GetType("System.Void");
			intType = GetType("System.Int32");
			longType = GetType("System.Int64");
			boolType = GetType("System.Boolean");
			floatType = GetType("System.Single");
			doubleType = GetType("System.Double");
			objectType = GetType("System.Object");
			jitAttributeType = GetType("ILRuntime.Runtime.ILRuntimeJITAttribute");
		}
	}

	public void AddReferenceBytes(string name, byte[] content)
	{
		references[name] = content;
	}

	public void RegisterCLRMethodRedirection(MethodBase mi, CLRRedirectionDelegate func)
	{
		if (mi == null)
		{
			return;
		}
		if (!IsThreadBinding)
		{
			if (!redirectMap.ContainsKey(mi))
			{
				redirectMap[mi] = func;
			}
			return;
		}
		lock (bindingLockObject)
		{
			if (!redirectMap.ContainsKey(mi))
			{
				redirectMap[mi] = func;
			}
		}
	}

	public void RegisterCLRFieldGetter(FieldInfo f, CLRFieldGetterDelegate getter)
	{
		if (!IsThreadBinding)
		{
			if (!fieldGetterMap.ContainsKey(f))
			{
				fieldGetterMap[f] = getter;
			}
			return;
		}
		lock (bindingLockObject)
		{
			if (!fieldGetterMap.ContainsKey(f))
			{
				fieldGetterMap[f] = getter;
			}
		}
	}

	public void RegisterCLRFieldSetter(FieldInfo f, CLRFieldSetterDelegate setter)
	{
		if (!IsThreadBinding)
		{
			if (!fieldSetterMap.ContainsKey(f))
			{
				fieldSetterMap[f] = setter;
			}
			return;
		}
		lock (bindingLockObject)
		{
			if (!fieldSetterMap.ContainsKey(f))
			{
				fieldSetterMap[f] = setter;
			}
		}
	}

	public void RegisterCLRFieldBinding(FieldInfo f, CLRFieldBindingDelegate copyToStack, CLRFieldBindingDelegate assignFromStack)
	{
		if (!IsThreadBinding)
		{
			if (!fieldBindingMap.ContainsKey(f))
			{
				fieldBindingMap[f] = new KeyValuePair<CLRFieldBindingDelegate, CLRFieldBindingDelegate>(copyToStack, assignFromStack);
			}
			return;
		}
		lock (bindingLockObject)
		{
			if (!fieldBindingMap.ContainsKey(f))
			{
				fieldBindingMap[f] = new KeyValuePair<CLRFieldBindingDelegate, CLRFieldBindingDelegate>(copyToStack, assignFromStack);
			}
		}
	}

	public void RegisterCLRMemberwiseClone(Type t, CLRMemberwiseCloneDelegate memberwiseClone)
	{
		if (!IsThreadBinding)
		{
			if (!memberwiseCloneMap.ContainsKey(t))
			{
				memberwiseCloneMap[t] = memberwiseClone;
			}
			return;
		}
		lock (bindingLockObject)
		{
			if (!memberwiseCloneMap.ContainsKey(t))
			{
				memberwiseCloneMap[t] = memberwiseClone;
			}
		}
	}

	public void RegisterCLRCreateDefaultInstance(Type t, CLRCreateDefaultInstanceDelegate createDefaultInstance)
	{
		if (!IsThreadBinding)
		{
			if (!createDefaultInstanceMap.ContainsKey(t))
			{
				createDefaultInstanceMap[t] = createDefaultInstance;
			}
			return;
		}
		lock (bindingLockObject)
		{
			if (!createDefaultInstanceMap.ContainsKey(t))
			{
				createDefaultInstanceMap[t] = createDefaultInstance;
			}
		}
	}

	public void RegisterCLRCreateArrayInstance(Type t, CLRCreateArrayInstanceDelegate createArray)
	{
		if (!IsThreadBinding)
		{
			if (!createArrayInstanceMap.ContainsKey(t))
			{
				createArrayInstanceMap[t] = createArray;
			}
			return;
		}
		lock (bindingLockObject)
		{
			if (!createArrayInstanceMap.ContainsKey(t))
			{
				createArrayInstanceMap[t] = createArray;
			}
		}
	}

	public void RegisterValueTypeBinder(Type t, ValueTypeBinder binder)
	{
		if (!IsThreadBinding)
		{
			if (!valueTypeBinders.ContainsKey(t))
			{
				valueTypeBinders[t] = binder;
				binder.RegisterCLRRedirection(this);
				CLRType cLRType = GetType(t) as CLRType;
				binder.CLRType = cLRType;
			}
			return;
		}
		lock (bindingLockObject)
		{
			if (!valueTypeBinders.ContainsKey(t))
			{
				valueTypeBinders[t] = binder;
				binder.RegisterCLRRedirection(this);
				CLRType cLRType2 = GetType(t) as CLRType;
				binder.CLRType = cLRType2;
			}
		}
	}

	public void InitializeBindings(bool isThread = false)
	{
		if (IsBindingDone)
		{
			return;
		}
		IsThreadBinding = isThread;
		if (isThread)
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				CLRBindingUtils.Initialize(this);
				IsBindingDone = true;
			});
			thread.Name = $"CLRBindings-Thread #{thread.ManagedThreadId}";
			thread.Start();
		}
		else
		{
			CLRBindingUtils.Initialize(this);
			IsBindingDone = true;
		}
	}

	public IType GetType(string fullname)
	{
		if (fullname == null)
		{
			return null;
		}
		if (mapType.TryGetValue(fullname, out var value))
		{
			return value;
		}
		ParseGenericType(fullname, out var baseType, out var genericParams, out var isArray, out var rank);
		bool flag = !string.IsNullOrEmpty(baseType) && baseType[baseType.Length - 1] == '&';
		if (flag)
		{
			baseType = baseType.Substring(0, baseType.Length - 1);
		}
		if (genericParams != null || isArray || flag)
		{
			IType type = GetType(baseType);
			if (type == null)
			{
				type = GetType(baseType.Replace("/", "+"));
			}
			if (type == null)
			{
				return null;
			}
			if (genericParams != null)
			{
				KeyValuePair<string, IType>[] array = new KeyValuePair<string, IType>[genericParams.Count];
				for (int i = 0; i < array.Length; i++)
				{
					string text = null;
					text = ((!(type is ILType)) ? ("!" + i) : ((ILType)type).TypeDefinition.GenericParameters[i].FullName);
					IType type2 = GetType(genericParams[i]);
					if (type2 == null)
					{
						return null;
					}
					array[i] = new KeyValuePair<string, IType>(text, type2);
				}
				type = type.MakeGenericInstance(array);
				mapType[type.FullName] = type;
				mapTypeToken[type.GetHashCode()] = type;
				if (type is CLRType)
				{
					clrTypeMapping[type.TypeForCLR] = type;
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append(baseType);
					stringBuilder.Append('<');
					for (int j = 0; j < genericParams.Count; j++)
					{
						if (j > 0)
						{
							stringBuilder.Append(",");
						}
						stringBuilder.Append(genericParams[j]);
					}
					stringBuilder.Append('>');
					string text2 = stringBuilder.ToString();
					if (type.FullName != text2)
					{
						mapType[text2] = type;
					}
				}
			}
			if (isArray)
			{
				type = type.MakeArrayType(rank);
				if (type is CLRType)
				{
					clrTypeMapping[type.TypeForCLR] = type;
				}
				mapType[type.FullName] = type;
				mapTypeToken[type.GetHashCode()] = type;
				if (!flag)
				{
					mapType[fullname] = type;
					return type;
				}
			}
			if (flag)
			{
				value = type.MakeByRefType();
				if (type is CLRType)
				{
					clrTypeMapping[type.TypeForCLR] = type;
				}
				mapType[fullname] = value;
				mapType[value.FullName] = value;
				mapTypeToken[value.GetHashCode()] = value;
				return value;
			}
			mapType[fullname] = type;
			return type;
		}
		Type type3 = Type.GetType(fullname);
		if (type3 != null)
		{
			if (!clrTypeMapping.TryGetValue(type3, out value))
			{
				value = new CLRType(type3, this);
				clrTypeMapping[type3] = value;
			}
			mapType[fullname] = value;
			mapType[value.FullName] = value;
			mapType[type3.AssemblyQualifiedName] = value;
			mapTypeToken[value.GetHashCode()] = value;
			return value;
		}
		return null;
	}

	internal static void ParseGenericType(string fullname, out string baseType, out List<string> genericParams, out bool isArray, out byte rank)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		rank = 0;
		baseType = "";
		genericParams = null;
		if (fullname.Length > 2 && fullname[fullname.Length - 2] == '[' && fullname[fullname.Length - 1] == ']')
		{
			fullname = fullname.Substring(0, fullname.Length - 2);
			rank = 1;
			isArray = true;
		}
		else
		{
			isArray = false;
		}
		if (fullname.Length > 2 && fullname[fullname.Length - 2] == '[' && fullname[fullname.Length - 1] == ']')
		{
			baseType = fullname;
			return;
		}
		bool flag = false;
		string text = fullname;
		foreach (char c in text)
		{
			if (c == '<' || c == '[')
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			text = fullname;
			foreach (char c2 in text)
			{
				if (c2 == '<' || c2 == '[')
				{
					num++;
					if (num == 1)
					{
						if (!isArray || stringBuilder.Length != 0)
						{
							baseType = stringBuilder.ToString();
							stringBuilder.Length = 0;
							genericParams = new List<string>();
						}
						continue;
					}
				}
				if (c2 == ',' && num == 1)
				{
					string text2 = stringBuilder.ToString();
					if (text2.StartsWith("["))
					{
						text2 = text2.Substring(1, text2.Length - 2);
					}
					if (!string.IsNullOrEmpty(text2))
					{
						genericParams.Add(text2);
					}
					else
					{
						rank++;
					}
					stringBuilder.Length = 0;
					continue;
				}
				if (c2 == '>' || c2 == ']')
				{
					num--;
					if (num == 0)
					{
						string text3 = stringBuilder.ToString();
						if (text3.StartsWith("["))
						{
							text3 = text3.Substring(1, text3.Length - 2);
						}
						if (!string.IsNullOrEmpty(text3))
						{
							genericParams.Add(text3);
						}
						else
						{
							if (string.IsNullOrEmpty(baseType))
							{
								stringBuilder.Append("<>");
								continue;
							}
							if (!isArray)
							{
								isArray = true;
								rank++;
							}
							else
							{
								baseType += "[]";
							}
						}
						stringBuilder.Length = 0;
						continue;
					}
				}
				stringBuilder.Append(c2);
			}
			if (stringBuilder.Length > 0)
			{
				baseType += stringBuilder.ToString();
			}
			if (genericParams != null && genericParams.Count == 0)
			{
				genericParams = null;
			}
		}
		else
		{
			baseType = fullname;
		}
	}

	private string GetAssemblyName(IMetadataScope scope)
	{
		if (!(scope is AssemblyNameReference))
		{
			return null;
		}
		return ((AssemblyNameReference)scope).FullName;
	}

	internal int AllocTypeIndex(IType type)
	{
		lock (typesByIndex)
		{
			int count = typesByIndex.Count;
			typesByIndex.Add(type);
			return count;
		}
	}

	internal IType GetTypeByIndex(int index)
	{
		return typesByIndex[index];
	}

	internal IType GetType(object token, IType contextType, IMethod contextMethod)
	{
		int hashCode = token.GetHashCode();
		if (mapTypeToken.TryGetValue(hashCode, out var value))
		{
			return value;
		}
		KeyValuePair<string, IType>[] array = null;
		string text = null;
		string text2 = null;
		bool flag = false;
		if (token is TypeDefinition)
		{
			TypeDefinition typeDefinition = token as TypeDefinition;
			_ = typeDefinition.Module;
			text = typeDefinition.FullName;
			text2 = GetAssemblyName(typeDefinition.Scope);
		}
		else
		{
			if (!(token is TypeReference))
			{
				throw new NotImplementedException();
			}
			TypeReference typeReference = token as TypeReference;
			if (typeReference.IsGenericParameter)
			{
				IType type = null;
				if (contextType != null)
				{
					type = contextType.FindGenericArgument(typeReference.Name);
				}
				if (type == null && contextMethod != null && contextMethod is ILMethod)
				{
					type = ((ILMethod)contextMethod).FindGenericArgument(typeReference.Name);
				}
				if (type != null)
				{
					mapTypeToken[type.GetHashCode()] = type;
					mapType[type.FullName] = type;
				}
				return type;
			}
			if (typeReference.IsByReference)
			{
				TypeReference elementType = ((ByReferenceType)typeReference).ElementType;
				bool flag2 = !elementType.ContainsGenericParameter;
				IType type2 = GetType(elementType, contextType, contextMethod);
				if (type2 != null)
				{
					value = type2.MakeByRefType();
					if (value is ILType && flag2)
					{
						((ILType)value).TypeReference = typeReference;
					}
					if (flag2)
					{
						mapTypeToken[hashCode] = value;
						mapTypeToken[value.GetHashCode()] = value;
						if (!string.IsNullOrEmpty(value.FullName))
						{
							mapType[value.FullName] = value;
						}
					}
					return value;
				}
				return null;
			}
			if (typeReference.IsArray)
			{
				ArrayType arrayType = (ArrayType)typeReference;
				IType type3 = GetType(arrayType.ElementType, contextType, contextMethod);
				if (type3 != null)
				{
					value = type3.MakeArrayType(arrayType.Rank);
					if (!typeReference.ContainsGenericParameter)
					{
						if (value is ILType)
						{
							((ILType)value).TypeReference = typeReference;
						}
						mapTypeToken[hashCode] = value;
					}
					mapTypeToken[value.GetHashCode()] = value;
					if (!string.IsNullOrEmpty(value.FullName))
					{
						mapType[value.FullName] = value;
					}
					return value;
				}
				return type3;
			}
			_ = typeReference.Module;
			if (typeReference.IsGenericInstance)
			{
				GenericInstanceType genericInstanceType = (GenericInstanceType)typeReference;
				text = genericInstanceType.ElementType.FullName;
				text2 = GetAssemblyName(genericInstanceType.ElementType.Scope);
				TypeReference elementType2 = genericInstanceType.ElementType;
				array = new KeyValuePair<string, IType>[genericInstanceType.GenericArguments.Count];
				for (int i = 0; i < array.Length; i++)
				{
					string name = elementType2.GenericParameters[i].Name;
					IType type4;
					if (genericInstanceType.GenericArguments[i].IsGenericParameter)
					{
						type4 = contextType.FindGenericArgument(genericInstanceType.GenericArguments[i].Name);
						flag = true;
						if (type4 == null)
						{
							if (contextMethod == null || !(contextMethod is ILMethod))
							{
								return null;
							}
							type4 = ((ILMethod)contextMethod).FindGenericArgument(genericInstanceType.GenericArguments[i].Name);
						}
					}
					else
					{
						type4 = GetType(genericInstanceType.GenericArguments[i], contextType, contextMethod);
					}
					if (genericInstanceType.GenericArguments[i].ContainsGenericParameter)
					{
						flag = true;
					}
					if (type4 != null)
					{
						array[i] = new KeyValuePair<string, IType>(name, type4);
						continue;
					}
					if (!flag)
					{
						return null;
					}
					array = null;
					break;
				}
			}
			else
			{
				text = typeReference.FullName;
				text2 = GetAssemblyName(typeReference.Scope);
			}
		}
		value = GetType(text);
		if (value == null)
		{
			text = text.Replace("/", "+");
			value = GetType(text);
		}
		if (value == null && text2 != null)
		{
			value = GetType(text + ", " + text2);
		}
		if (value == null)
		{
			if (text2 != null)
			{
				string text3 = text2.Split(new char[1] { ',' })[0];
				Assembly[] array2 = loadedAssemblies;
				foreach (Assembly assembly in array2)
				{
					if (text3 == assembly.GetName().Name)
					{
						value = GetType(text + ", " + assembly.FullName);
						if (value != null)
						{
							break;
						}
					}
				}
			}
			if (value == null)
			{
				Assembly[] array2 = loadedAssemblies;
				foreach (Assembly assembly2 in array2)
				{
					value = GetType(text + ", " + assembly2.FullName);
					if (value != null)
					{
						break;
					}
				}
			}
			if (value != null && text2 != null)
			{
				mapType[text + ", " + text2] = value;
			}
		}
		if (value == null)
		{
			throw new KeyNotFoundException("Cannot find Type:" + text);
		}
		if (array != null)
		{
			value = value.MakeGenericInstance(array);
			if (!flag && value is ILType)
			{
				((ILType)value).TypeReference = (TypeReference)token;
			}
			if (!string.IsNullOrEmpty(value.FullName) && (value is CLRType || !((ILType)value).TypeReference.HasGenericParameters))
			{
				mapType[value.FullName] = value;
			}
		}
		mapTypeToken[value.GetHashCode()] = value;
		if (!flag)
		{
			mapTypeToken[hashCode] = value;
		}
		return value;
	}

	public IType GetType(int hash)
	{
		if (mapTypeToken.TryGetValue(hash, out var value))
		{
			return value;
		}
		return null;
	}

	public IType GetType(Type t)
	{
		if (clrTypeMapping.TryGetValue(t, out var value))
		{
			return value;
		}
		return GetType(t.AssemblyQualifiedName);
	}

	public T Instantiate<T>(string type, object[] args = null)
	{
		return (T)Instantiate(type, args).CLRInstance;
	}

	public ILTypeInstance Instantiate(string type, object[] args = null)
	{
		if (mapType.TryGetValue(type, out var value) && value is ILType iLType)
		{
			bool flag = args != null && args.Length != 0;
			ILTypeInstance iLTypeInstance = iLType.Instantiate(!flag);
			if (flag)
			{
				IMethod constructor = iLType.GetConstructor(args.Length);
				Invoke(constructor, iLTypeInstance, args);
			}
			return iLTypeInstance;
		}
		return null;
	}

	public void Prewarm(string type, bool recursive = true)
	{
		IType type2 = GetType(type);
		if (type2 == null || type2 is CLRType)
		{
			return;
		}
		foreach (TypeDefinition nestedType in ((ILType)type2).TypeDefinition.NestedTypes)
		{
			Prewarm(nestedType.FullName, recursive);
		}
		foreach (ILMethod method in type2.GetMethods())
		{
			method.Prewarm(recursive);
		}
	}

	public void Prewarm(PrewarmInfo[] info, bool recursive = true)
	{
		for (int i = 0; i < info.Length; i++)
		{
			PrewarmInfo prewarmInfo = info[i];
			IType type = GetType(prewarmInfo.TypeName);
			if (type == null || type is CLRType || prewarmInfo.MethodNames == null)
			{
				continue;
			}
			List<IMethod> methods = type.GetMethods();
			string[] methodNames = prewarmInfo.MethodNames;
			foreach (string text in methodNames)
			{
				foreach (ILMethod item in methods)
				{
					if (item.Name == text && item.GenericParameterCount == 0)
					{
						item.Prewarm(recursive);
					}
				}
			}
		}
	}

	public object Invoke(string type, string method, object instance, params object[] p)
	{
		IType type2 = GetType(type);
		if (type2 == null)
		{
			return null;
		}
		IMethod method2 = type2.GetMethod(method, (p != null) ? p.Length : 0);
		if (method2 != null)
		{
			for (int i = 0; i < method2.ParameterCount; i++)
			{
				if (p[i] != null && !method2.Parameters[i].TypeForCLR.IsAssignableFrom(p[i].GetType()))
				{
					throw new ArgumentException("Parameter type mismatch");
				}
			}
			return Invoke(method2, instance, p);
		}
		return null;
	}

	public object InvokeGenericMethod(string type, string method, IType[] genericArguments, object instance, params object[] p)
	{
		IType type2 = GetType(type);
		if (type2 == null)
		{
			return null;
		}
		IMethod method2 = type2.GetMethod(method, p.Length);
		if (method2 != null)
		{
			method2 = method2.MakeGenericMethod(genericArguments);
			return Invoke(method2, instance, p);
		}
		return null;
	}

	internal ILIntepreter RequestILIntepreter()
	{
		ILIntepreter iLIntepreter = null;
		lock (freeIntepreters)
		{
			if (freeIntepreters.Count > 0)
			{
				iLIntepreter = freeIntepreters.Dequeue();
				iLIntepreter.ClearDebugState();
			}
			else
			{
				iLIntepreter = new ILIntepreter(this);
			}
		}
		return iLIntepreter;
	}

	internal void FreeILIntepreter(ILIntepreter inteptreter)
	{
		lock (freeIntepreters)
		{
			inteptreter.Stack.ManagedStack.Clear();
			inteptreter.Stack.Frames.Clear();
			inteptreter.Stack.ClearAllocator();
			freeIntepreters.Enqueue(inteptreter);
		}
	}

	public object Invoke(IMethod m, object instance, params object[] p)
	{
		object result = null;
		if (m is ILMethod)
		{
			ILIntepreter iLIntepreter = RequestILIntepreter();
			try
			{
				result = iLIntepreter.Run((ILMethod)m, instance, p);
			}
			finally
			{
				FreeILIntepreter(iLIntepreter);
			}
		}
		return result;
	}

	public InvocationContext BeginInvoke(IMethod m)
	{
		if (m is ILMethod)
		{
			return new InvocationContext(RequestILIntepreter(), (ILMethod)m);
		}
		throw new NotSupportedException("Cannot invoke CLRMethod");
	}

	private bool IsInvalidMethodReference(MethodReference _ref)
	{
		if ((_ref.DeclaringType.Name == "Object" || _ref.DeclaringType.Name == "Attribute") && _ref.Name == ".ctor" && _ref.DeclaringType.Namespace == "System" && _ref.ReturnType.Name == "Void" && _ref.ReturnType.Namespace == "System")
		{
			return true;
		}
		return false;
	}

	internal IMethod GetMethod(object token, ILType contextType, ILMethod contextMethod, out bool invalidToken)
	{
		string text = null;
		string text2 = null;
		List<IType> list = null;
		int hashCode = token.GetHashCode();
		IType[] array = null;
		invalidToken = false;
		bool flag = false;
		if (mapMethod.TryGetValue(hashCode, out var value))
		{
			return value;
		}
		IType type = null;
		if (token is MethodReference)
		{
			MethodReference methodReference = token as MethodReference;
			if (IsInvalidMethodReference(methodReference))
			{
				mapMethod[hashCode] = null;
				return null;
			}
			text = methodReference.Name;
			TypeReference declaringType = methodReference.DeclaringType;
			type = GetType(declaringType, contextType, contextMethod);
			if (type == null)
			{
				throw new KeyNotFoundException("Cannot find type:" + text2);
			}
			flag = ((!(token is MethodDefinition)) ? (text == ".ctor") : (methodReference as MethodDefinition).IsConstructor);
			if (methodReference.IsGenericInstance)
			{
				GenericInstanceMethod genericInstanceMethod = (GenericInstanceMethod)methodReference;
				array = new IType[genericInstanceMethod.GenericArguments.Count];
				for (int i = 0; i < array.Length; i++)
				{
					if (genericInstanceMethod.GenericArguments[i].ContainsGenericParameter)
					{
						invalidToken = true;
					}
					IType type2 = GetType(genericInstanceMethod.GenericArguments[i], contextType, contextMethod);
					if (type2 == null)
					{
						type2 = contextMethod.FindGenericArgument(genericInstanceMethod.GenericArguments[i].Name);
						if (type2 == null)
						{
							array = null;
							break;
						}
						array[i] = type2;
					}
					else
					{
						array[i] = type2;
					}
				}
			}
			if (!invalidToken && declaringType.IsGenericInstance)
			{
				GenericInstanceType genericInstanceType = (GenericInstanceType)declaringType;
				for (int j = 0; j < genericInstanceType.GenericArguments.Count; j++)
				{
					if (genericInstanceType.GenericArguments[j].ContainsGenericParameter)
					{
						invalidToken = true;
						break;
					}
				}
			}
			list = methodReference.GetParamList(this, contextType, contextMethod, array);
			IType type3 = GetType(methodReference.ReturnType, type, null);
			if (type3 == null)
			{
				type3 = GetType(methodReference.ReturnType, contextType, null);
			}
			value = ((!flag) ? type.GetMethod(text, list, array, type3, declaredOnly: true) : type.GetConstructor(list));
			if (value == null)
			{
				if (!flag || contextType.FirstCLRBaseType == null || !(contextType.FirstCLRBaseType is CrossBindingAdaptor) || !(type.TypeForCLR == ((CrossBindingAdaptor)contextType.FirstCLRBaseType).BaseCLRType))
				{
					throw new KeyNotFoundException($"Cannot find method:{text} in type:{type.FullName}, token={token}");
				}
				value = contextType.BaseType.GetConstructor(list);
				if (value == null)
				{
					throw new KeyNotFoundException($"Cannot find method:{text} in type:{type.FullName}, token={token}");
				}
				invalidToken = true;
				mapMethod[value.GetHashCode()] = value;
			}
			if (!invalidToken)
			{
				mapMethod[hashCode] = value;
			}
			else
			{
				mapMethod[value.GetHashCode()] = value;
			}
			return value;
		}
		throw new NotImplementedException();
	}

	internal IMethod GetMethod(int tokenHash)
	{
		if (mapMethod.TryGetValue(tokenHash, out var value))
		{
			return value;
		}
		return null;
	}

	internal long GetStaticFieldIndex(object token, IType contextType, IMethod contextMethod)
	{
		FieldReference fieldReference = token as FieldReference;
		IType type = GetType(fieldReference.DeclaringType, contextType, contextMethod);
		if (type is ILType)
		{
			ILType iLType = type as ILType;
			int fieldIndex = iLType.GetFieldIndex(token);
			if (iLType.TypeReference.HasGenericParameters)
			{
				mapTypeToken[type.GetHashCode()] = iLType;
			}
			return ((long)type.GetHashCode() << 32) | (uint)fieldIndex;
		}
		int fieldIndex2 = type.GetFieldIndex(token);
		return ((long)type.GetHashCode() << 32) | (uint)fieldIndex2;
	}

	internal long CacheString(object token)
	{
		long num = token.GetHashCode() & 0xFFFFFFFFu;
		long num2 = num;
		string newStr = (string)token;
		lock (mapString)
		{
			bool flag = CheckStringCollision(num2, newStr);
			long num3 = 0L;
			while (flag)
			{
				num3++;
				num2 = (num3 << 32) | num;
				flag = CheckStringCollision(num2, newStr);
			}
			mapString[num2] = (string)token;
			return num2;
		}
	}

	private bool CheckStringCollision(long hashCode, string newStr)
	{
		if (mapString.TryGetValue(hashCode, out var value))
		{
			return value != newStr;
		}
		return false;
	}

	internal string GetString(long hashCode)
	{
		string value = null;
		mapString.TryGetValue(hashCode, out value);
		return value;
	}

	public void RegisterCrossBindingAdaptor(CrossBindingAdaptor adaptor)
	{
		Type baseCLRType = adaptor.BaseCLRType;
		if (baseCLRType != null)
		{
			if (!crossAdaptors.ContainsKey(baseCLRType))
			{
				Type adaptorType = adaptor.AdaptorType;
				IType type = GetType(adaptorType);
				if (type == null)
				{
					type = new CLRType(adaptorType, this);
					mapType[type.FullName] = type;
					mapType[adaptorType.AssemblyQualifiedName] = type;
					clrTypeMapping[adaptorType] = type;
				}
				adaptor.RuntimeType = type;
				crossAdaptors[baseCLRType] = adaptor;
				return;
			}
			throw new Exception("Crossbinding Adapter for " + baseCLRType.FullName + " is already added.");
		}
		Type[] baseCLRTypes = adaptor.BaseCLRTypes;
		Type adaptorType2 = adaptor.AdaptorType;
		IType type2 = GetType(adaptorType2);
		if (type2 == null)
		{
			type2 = new CLRType(adaptorType2, this);
			mapType[type2.FullName] = type2;
			mapType[adaptorType2.AssemblyQualifiedName] = type2;
			clrTypeMapping[adaptorType2] = type2;
		}
		adaptor.RuntimeType = type2;
		Type[] array = baseCLRTypes;
		foreach (Type type3 in array)
		{
			if (!crossAdaptors.ContainsKey(type3))
			{
				crossAdaptors[type3] = adaptor;
				continue;
			}
			throw new Exception("Crossbinding Adapter for " + type3.FullName + " is already added.");
		}
	}

	public unsafe int GetSizeInMemory(out List<TypeSizeInfo> detail)
	{
		int num = 16384 * sizeof(StackObject) * intepreters.Count;
		detail = new List<TypeSizeInfo>();
		HashSet<object> traversed = new HashSet<object>();
		foreach (KeyValuePair<string, IType> loadedType in LoadedTypes)
		{
			if (loadedType.Value is ILType iLType)
			{
				TypeSizeInfo item = default(TypeSizeInfo);
				item.Type = iLType;
				item.StaticFieldSize = iLType.GetStaticFieldSizeInMemory(traversed);
				item.MethodBodySize = iLType.GetMethodBodySizeInMemory();
				item.TotalSize = item.StaticFieldSize + item.MethodBodySize;
				num += item.TotalSize;
				detail.Add(item);
			}
		}
		detail.Sort((TypeSizeInfo a, TypeSizeInfo b) => b.TotalSize - a.TotalSize);
		return num;
	}
}
