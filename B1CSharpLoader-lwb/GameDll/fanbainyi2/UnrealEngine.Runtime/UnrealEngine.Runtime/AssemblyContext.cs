using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

namespace UnrealEngine.Runtime;

public class AssemblyContext
{
	public class MethodRedirects
	{
		public delegate object GetLoadContextDel(Assembly assembly);

		public delegate Assembly LoadFromAssemblyPathDel(string assemblyPath);

		private static FieldInfo stateField;

		public static GetLoadContextDel GetLoadContext;

		public static void Initialize(FieldInfo stateField, MethodInfo getLoadContextMethod)
		{
			MethodRedirects.stateField = stateField;
			GetLoadContext = (GetLoadContextDel)getLoadContextMethod.CreateDelegate(typeof(GetLoadContextDel));
		}

		public static bool IsAlive(IAssemblyLoadContext context)
		{
			return (int)Convert.ChangeType(stateField.GetValue(context), TypeCode.Int32) == 0;
		}

		public static AssemblyContext GetOwner(IAssemblyLoadContext context, long contextId)
		{
			if (contexts.TryGetValue(contextId, out var value))
			{
				return value;
			}
			return null;
		}

		public static IAssemblyLoadContext GetLoadContextInternal(Assembly assembly)
		{
			return GetLoadContext(assembly) as IAssemblyLoadContext;
		}

		public static Assembly[] GetAssemblies(IAssemblyLoadContext context)
		{
			List<Assembly> list = new List<Assembly>();
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			foreach (Assembly assembly in assemblies)
			{
				if (GetLoadContextInternal(assembly) == context)
				{
					list.Add(assembly);
				}
			}
			return list.ToArray();
		}

		public static Assembly LoadFromAssemblyPath(IAssemblyLoadContext context, string assemblyPath, LoadFromAssemblyPathDel baseMethod)
		{
			return baseMethod(assemblyPath);
		}

		public static void OnUnloading(object contextObj)
		{
			if (contextObj is IAssemblyLoadContext assemblyLoadContext)
			{
				assemblyLoadContext.GetOwner().OnUnloading();
			}
		}

		public static Assembly OnResolving(object contextObj, AssemblyName assemblyName)
		{
			if (contextObj is IAssemblyLoadContext assemblyLoadContext)
			{
				return assemblyLoadContext.GetOwner().OnResolving(assemblyName);
			}
			return null;
		}
	}

	private static long nextContextId;

	private static Dictionary<long, AssemblyContext> contexts;

	private static Type generatedContextType;

	public static readonly bool IsMono;

	public static readonly bool IsCoreCLR;

	public static readonly bool IsCLR;

	public const string CurrentAppDomainContextRefKey = "CurrentAppDomainContextRef";

	private WeakReference weakRef;

	public IAssemblyLoadContext LoadContext { get; private set; }

	public AppDomain Domain { get; private set; }

	public AssemblyContextRef Reference { get; private set; }

	public long Id => Reference.Id;

	public long OwnerId => Reference.OwnerId;

	public bool IsUnloaded => State == AssemblyContextState.Unloaded;

	public AssemblyContextState State { get; private set; }

	public bool IsFullyUnloaded
	{
		get
		{
			if (IsUnloaded)
			{
				if (weakRef != null)
				{
					return !weakRef.IsAlive;
				}
				return true;
			}
			return false;
		}
	}

	public event Action<KeyValuePair<long, long>> Unloading;

	public event Func<KeyValuePair<long, long>, AssemblyName, Assembly> Resolving;

	static AssemblyContext()
	{
		nextContextId = 2L;
		if (Type.GetType("Mono.Runtime") != null)
		{
			IsMono = true;
		}
		else if (Type.GetType("System.Runtime.Loader.AssemblyLoadContext") != null)
		{
			IsCoreCLR = true;
		}
		else
		{
			IsCLR = true;
		}
	}

	public static void Initialize()
	{
		contexts = new Dictionary<long, AssemblyContext>();
		if (IsCoreCLR)
		{
			CreateAssemblyLoadContextType();
		}
		AssemblyContextProxy.Initialize(isContextMaintainer: true);
	}

	public static void Initialize(AssemblyContextRef currentContext)
	{
		if (contexts == null)
		{
			AssemblyContextProxy.Initialize(isContextMaintainer: false);
		}
		if (!IsCoreCLR && !currentContext.IsInvalid)
		{
			AppDomain.CurrentDomain.SetData("CurrentAppDomainContextRef", currentContext.Format());
		}
	}

	internal static AssemblyContext InternalGetContext(AssemblyContextRef contextRef)
	{
		if (contexts == null)
		{
			throw new Exception("Attempting to get context on an AssemblyContext which doesn't maintain a list of contexts");
		}
		lock (contexts)
		{
			if (contexts.TryGetValue(contextRef.Id, out var value))
			{
				return value;
			}
		}
		throw new Exception("Unknown AssemblyContextHelper contextId: " + contextRef.Id);
	}

	public static AssemblyContextRef GetContextRef(Assembly assembly)
	{
		if (IsCoreCLR)
		{
			if (contexts != null)
			{
				IAssemblyLoadContext loadContextInternal = MethodRedirects.GetLoadContextInternal(assembly);
				if (loadContextInternal != null)
				{
					AssemblyContext owner = loadContextInternal.GetOwner();
					if (owner != null)
					{
						return owner.Reference;
					}
				}
				return AssemblyContextRef.Invalid;
			}
			return AssemblyContextProxy.GetContextRef(assembly);
		}
		return AssemblyContextProxy.GetContextRef(assembly);
	}

	public static AssemblyContextRef Create()
	{
		return Create(new AssemblyContextRef(1L, 1L));
	}

	public static AssemblyContextRef Create(AssemblyContextRef currentContext)
	{
		if (contexts == null)
		{
			return AssemblyContextProxy.Create(currentContext);
		}
		lock (contexts)
		{
			if (!IsCoreCLR)
			{
				throw new NotImplementedException("Use the overload taking an AppDomain parameter on runtimes which support AppDomain loading/unloading");
			}
			AssemblyContextRef assemblyContextRef = new AssemblyContextRef(nextContextId, currentContext.Id);
			AssemblyContext value = new AssemblyContext((IAssemblyLoadContext)Activator.CreateInstance(generatedContextType, assemblyContextRef.Id), assemblyContextRef);
			contexts.Add(assemblyContextRef.Id, value);
			nextContextId++;
			return assemblyContextRef;
		}
	}

	public static AssemblyContextRef Create(AppDomain domain)
	{
		return Create(domain, new AssemblyContextRef(1L, 1L));
	}

	public static AssemblyContextRef Create(AppDomain domain, AssemblyContextRef currentContext)
	{
		if (contexts == null)
		{
			throw new NotImplementedException("Already within a context. TODO: Allow an AppDomain to have sub domains?");
		}
		lock (contexts)
		{
			if (IsCoreCLR)
			{
				throw new NotImplementedException("Use the overload taking no parameters on runtimes which don't support AppDomain loading/unloading");
			}
			AssemblyContextRef assemblyContextRef = new AssemblyContextRef(nextContextId, currentContext.Id);
			AssemblyContext assemblyContext = new AssemblyContext(domain, assemblyContextRef);
			contexts.Add(assemblyContext.Id, assemblyContext);
			nextContextId++;
			return assemblyContextRef;
		}
	}

	private static void RemoveContext(AssemblyContext context)
	{
		lock (contexts)
		{
			contexts.Remove(context.Id);
		}
	}

	public AssemblyContext(IAssemblyLoadContext loadContext, AssemblyContextRef reference)
	{
		LoadContext = loadContext;
		weakRef = new WeakReference(LoadContext);
		Reference = reference;
	}

	public AssemblyContext(AppDomain domain, AssemblyContextRef reference)
	{
		Domain = domain;
		weakRef = new WeakReference(Domain);
		Reference = reference;
	}

	private void ClearEvents()
	{
		this.Unloading = null;
		this.Resolving = null;
	}

	internal void OnUnloading()
	{
		bool num = State == AssemblyContextState.Alive;
		if (this.Unloading != null)
		{
			this.Unloading(Reference);
		}
		_ = IsCoreCLR;
		if (num)
		{
			LoadContext = null;
			RemoveContext(this);
			ClearEvents();
			State = AssemblyContextState.Unloaded;
		}
	}

	internal Assembly OnResolving(AssemblyName assemblyName)
	{
		if (this.Resolving != null)
		{
			return this.Resolving(Reference, assemblyName);
		}
		return null;
	}

	[Conditional("DEBUG")]
	private void EnsureUnsubscribed()
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		if (!IsCoreCLR)
		{
			object value = Type.GetType("System.AppDomain").GetProperty("CurrentDomain").GetValue(null);
			EnsureUnsubscribed(value, "AssemblyLoad", "AssemblyLoad");
			EnsureUnsubscribed(value, "AssemblyResolve", "_AssemblyResolve");
			EnsureUnsubscribed(value, "DomainUnload", "_domainUnload");
			EnsureUnsubscribed(value, "FirstChanceException", "_firstChanceException");
			EnsureUnsubscribed(value, "ProcessExit", "_processExit");
			EnsureUnsubscribed(value, "ResourceResolve", "_ResourceResolve");
			EnsureUnsubscribed(value, "TypeResolve", "_TypeResolve");
			EnsureUnsubscribed(value, "UnhandledException", "_unhandledException");
		}
		stopwatch.Stop();
		SharedRuntimeState.Log("EnsureUnsubscribed took: " + stopwatch.Elapsed.ToString());
	}

	private void EnsureUnsubscribed<T>(string eventName, string fieldName)
	{
		EnsureUnsubscribed(null, typeof(T), eventName, fieldName);
	}

	private void EnsureUnsubscribed(object obj, string eventName, string fieldName)
	{
		if (obj != null)
		{
			EnsureUnsubscribed(obj, obj.GetType(), eventName, fieldName);
		}
	}

	private void EnsureUnsubscribed(object obj, Type type, string eventName, string fieldName)
	{
		FieldInfo fieldInfo;
		Delegate obj2 = GetDelegate(obj, type, eventName, fieldName, out fieldInfo);
		if ((object)obj2 == null)
		{
			return;
		}
		Delegate[] invocationList = obj2.GetInvocationList();
		foreach (Delegate obj3 in invocationList)
		{
			Assembly assembly = obj3.Method.DeclaringType.Assembly;
			if (GetContextRef(assembly) == Reference)
			{
				obj2 = Delegate.Remove(obj2, obj3);
				SharedRuntimeState.LogWarning("Event is still being subscribed to in an assembly which is unloading. Assembly: " + assembly.FullName + " event: " + type.Name + "." + eventName + " target: " + obj3.Method.DeclaringType.FullName + "." + obj3.Method.Name);
			}
		}
		fieldInfo.SetValue(obj, obj2);
	}

	private static Delegate GetDelegate(object obj, Type type, string eventName, string fieldName)
	{
		FieldInfo fieldInfo;
		return GetDelegate(obj, type, eventName, fieldName, out fieldInfo);
	}

	private static Delegate GetDelegate(object obj, Type type, string eventName, string fieldName, out FieldInfo fieldInfo)
	{
		BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
		if (type.GetEvent(eventName, bindingAttr) == null)
		{
			fieldInfo = null;
			return null;
		}
		fieldInfo = type.GetField(fieldName, bindingAttr);
		if (fieldInfo == null)
		{
			return null;
		}
		return fieldInfo.GetValue(obj) as Delegate;
	}

	public void Unload()
	{
		EnsureAlive();
		State = AssemblyContextState.Unloading;
		if (Domain != null)
		{
			try
			{
				AppDomain.Unload(Domain);
			}
			catch
			{
				State = AssemblyContextState.Alive;
				throw;
			}
			Domain = null;
		}
		if (LoadContext != null)
		{
			LoadContext.Unload();
			LoadContext = null;
		}
		RemoveContext(this);
		ClearEvents();
		State = AssemblyContextState.Unloaded;
	}

	public Assembly[] GetAssemblies()
	{
		EnsureAlive();
		if (LoadContext != null)
		{
			return LoadContext.GetAssemblies();
		}
		if (Domain != null)
		{
			return Domain.GetAssemblies();
		}
		return null;
	}

	public Assembly LoadFrom(string assemblyPath)
	{
		EnsureAlive();
		if (LoadContext != null)
		{
			return LoadContext.LoadFromAssemblyPath(assemblyPath);
		}
		if (Domain != null)
		{
			return CurrentAssemblyContext.LoadFromInternal(assemblyPath);
		}
		return null;
	}

	public Assembly LoadFromStream(Stream assembly, Stream assemblySymbols)
	{
		EnsureAlive();
		if (LoadContext != null)
		{
			return LoadContext.LoadFromStream(assembly, assemblySymbols);
		}
		if (Domain != null)
		{
			throw new NotImplementedException("AppDomain doesn't have LoadFrom functions taking a stream / byte array. Use AppDomain.Load instead.");
		}
		return null;
	}

	private void EnsureAlive()
	{
		if (State != AssemblyContextState.Alive)
		{
			throw new InvalidOperationException("Trying to access unloaded AssemblyContext");
		}
	}

	private static void CreateAssemblyLoadContextType()
	{
		Type type = Type.GetType("System.Runtime.Loader.AssemblyLoadContext");
		Type typeFromHandle = typeof(MethodRedirects);
		ConstructorInfo constructor = typeof(MethodRedirects.LoadFromAssemblyPathDel).GetConstructor(new Type[2]
		{
			typeof(object),
			typeof(IntPtr)
		});
		MethodInfo method = typeFromHandle.GetMethod("LoadFromAssemblyPath");
		MethodInfo method2 = typeFromHandle.GetMethod("IsAlive");
		MethodInfo method3 = typeFromHandle.GetMethod("GetOwner");
		MethodInfo method4 = typeFromHandle.GetMethod("GetAssemblies");
		MethodInfo method5 = typeFromHandle.GetMethod("OnUnloading");
		MethodInfo method6 = typeFromHandle.GetMethod("OnResolving");
		MethodRedirects.Initialize(type.GetField("state", BindingFlags.Instance | BindingFlags.NonPublic), type.GetMethod("GetLoadContext", BindingFlags.Static | BindingFlags.Public));
		ConstructorInfo constructor2 = type.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[1] { typeof(bool) }, null);
		MethodInfo method7 = type.GetMethod("Load", BindingFlags.Instance | BindingFlags.NonPublic);
		MethodInfo method8 = type.GetMethod("Unload", BindingFlags.Instance | BindingFlags.Public);
		MethodInfo method9 = type.GetMethod("LoadFromAssemblyPath");
		MethodInfo method10 = type.GetMethod("LoadFromStream", new Type[2]
		{
			typeof(Stream),
			typeof(Stream)
		});
		EventInfo eventInfo = type.GetEvent("Unloading");
		EventInfo eventInfo2 = type.GetEvent("Resolving");
		AssemblyName assemblyName = new AssemblyName("AssemblyLoadContextHelper");
		TypeBuilder typeBuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.RunAndCollect).DefineDynamicModule(assemblyName.Name).DefineType("GeneratedAssemblyLoadContext", TypeAttributes.Public, type, new Type[1] { typeof(IAssemblyLoadContext) });
		FieldBuilder field = typeBuilder.DefineField("unloadingEvent", typeof(Action<object>), FieldAttributes.Private);
		ConstructorInfo constructor3 = typeof(Action<object>).GetConstructor(new Type[2]
		{
			typeof(object),
			typeof(IntPtr)
		});
		Type typeFromHandle2 = typeof(Func<object, AssemblyName, Assembly>);
		FieldBuilder field2 = typeBuilder.DefineField("resolvingEvent", typeFromHandle2, FieldAttributes.Private);
		ConstructorInfo constructor4 = typeFromHandle2.GetConstructor(new Type[2]
		{
			typeof(object),
			typeof(IntPtr)
		});
		FieldBuilder field3 = typeBuilder.DefineField("baseLoadFromAssemblyPath", typeof(MethodRedirects.LoadFromAssemblyPathDel), FieldAttributes.Private);
		FieldBuilder field4 = typeBuilder.DefineField("contextId", typeof(long), FieldAttributes.Private);
		MethodBuilder methodBuilder = typeBuilder.DefineMethod("OnUnloading", MethodAttributes.Private | MethodAttributes.HideBySig, CallingConventions.HasThis, typeof(void), new Type[1] { type });
		ILGenerator iLGenerator = methodBuilder.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Ldfld, field);
		iLGenerator.Emit(OpCodes.Call, eventInfo.RemoveMethod);
		iLGenerator.Emit(OpCodes.Ldarg_1);
		iLGenerator.Emit(OpCodes.Call, method5);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Ldfld, field2);
		iLGenerator.Emit(OpCodes.Call, eventInfo2.RemoveMethod);
		iLGenerator.Emit(OpCodes.Ret);
		MethodBuilder methodBuilder2 = typeBuilder.DefineMethod("OnResolving", MethodAttributes.Private | MethodAttributes.HideBySig, CallingConventions.HasThis, typeof(Assembly), new Type[2]
		{
			type,
			typeof(AssemblyName)
		});
		ILGenerator iLGenerator2 = methodBuilder2.GetILGenerator();
		iLGenerator2.Emit(OpCodes.Ldarg_1);
		iLGenerator2.Emit(OpCodes.Ldarg_2);
		iLGenerator2.Emit(OpCodes.Call, method6);
		iLGenerator2.Emit(OpCodes.Ret);
		ILGenerator iLGenerator3 = typeBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.HasThis, new Type[1] { typeof(long) }).GetILGenerator();
		iLGenerator3.Emit(OpCodes.Ldarg_0);
		iLGenerator3.Emit(OpCodes.Ldc_I4_1);
		iLGenerator3.Emit(OpCodes.Call, constructor2);
		iLGenerator3.Emit(OpCodes.Ldarg_0);
		iLGenerator3.Emit(OpCodes.Ldarg_0);
		iLGenerator3.Emit(OpCodes.Ldftn, methodBuilder);
		iLGenerator3.Emit(OpCodes.Newobj, constructor3);
		iLGenerator3.Emit(OpCodes.Stfld, field);
		iLGenerator3.Emit(OpCodes.Ldarg_0);
		iLGenerator3.Emit(OpCodes.Ldarg_0);
		iLGenerator3.Emit(OpCodes.Ldfld, field);
		iLGenerator3.Emit(OpCodes.Call, eventInfo.AddMethod);
		iLGenerator3.Emit(OpCodes.Ldarg_0);
		iLGenerator3.Emit(OpCodes.Ldarg_0);
		iLGenerator3.Emit(OpCodes.Ldftn, methodBuilder2);
		iLGenerator3.Emit(OpCodes.Newobj, constructor4);
		iLGenerator3.Emit(OpCodes.Stfld, field2);
		iLGenerator3.Emit(OpCodes.Ldarg_0);
		iLGenerator3.Emit(OpCodes.Ldarg_0);
		iLGenerator3.Emit(OpCodes.Ldfld, field2);
		iLGenerator3.Emit(OpCodes.Call, eventInfo2.AddMethod);
		iLGenerator3.Emit(OpCodes.Ldarg_0);
		iLGenerator3.Emit(OpCodes.Ldarg_1);
		iLGenerator3.Emit(OpCodes.Stfld, field4);
		iLGenerator3.Emit(OpCodes.Ldarg_0);
		iLGenerator3.Emit(OpCodes.Ldarg_0);
		iLGenerator3.Emit(OpCodes.Ldftn, method9);
		iLGenerator3.Emit(OpCodes.Newobj, constructor);
		iLGenerator3.Emit(OpCodes.Stfld, field3);
		iLGenerator3.Emit(OpCodes.Ret);
		MethodBuilder methodBuilder3 = typeBuilder.DefineMethod("Load", MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, CallingConventions.HasThis, typeof(Assembly), new Type[1] { typeof(AssemblyName) });
		ILGenerator iLGenerator4 = methodBuilder3.GetILGenerator();
		iLGenerator4.Emit(OpCodes.Ldnull);
		iLGenerator4.Emit(OpCodes.Ret);
		typeBuilder.DefineMethodOverride(methodBuilder3, method7);
		ILGenerator iLGenerator5 = typeBuilder.DefineMethod("Unload", MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, CallingConventions.HasThis, typeof(void), Type.EmptyTypes).GetILGenerator();
		iLGenerator5.Emit(OpCodes.Ldarg_0);
		iLGenerator5.Emit(OpCodes.Call, method8);
		iLGenerator5.Emit(OpCodes.Ret);
		typeBuilder.DefineMethodOverride(methodBuilder3, method7);
		ILGenerator iLGenerator6 = typeBuilder.DefineMethod("GetAssemblies", MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, CallingConventions.HasThis, typeof(Assembly[]), Type.EmptyTypes).GetILGenerator();
		iLGenerator6.Emit(OpCodes.Ldarg_0);
		iLGenerator6.Emit(OpCodes.Call, method4);
		iLGenerator6.Emit(OpCodes.Ret);
		ILGenerator iLGenerator7 = typeBuilder.DefineMethod("IsAlive", MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, CallingConventions.HasThis, typeof(bool), Type.EmptyTypes).GetILGenerator();
		iLGenerator7.Emit(OpCodes.Ldarg_0);
		iLGenerator7.Emit(OpCodes.Call, method2);
		iLGenerator7.Emit(OpCodes.Ret);
		ILGenerator iLGenerator8 = typeBuilder.DefineMethod("GetOwner", MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, CallingConventions.HasThis, typeof(AssemblyContext), Type.EmptyTypes).GetILGenerator();
		iLGenerator8.Emit(OpCodes.Ldarg_0);
		iLGenerator8.Emit(OpCodes.Ldarg_0);
		iLGenerator8.Emit(OpCodes.Ldfld, field4);
		iLGenerator8.Emit(OpCodes.Call, method3);
		iLGenerator8.Emit(OpCodes.Ret);
		ILGenerator iLGenerator9 = typeBuilder.DefineMethod("LoadFromAssemblyPath", MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, CallingConventions.HasThis, typeof(Assembly), new Type[1] { typeof(string) }).GetILGenerator();
		iLGenerator9.Emit(OpCodes.Ldarg_0);
		iLGenerator9.Emit(OpCodes.Ldarg_1);
		iLGenerator9.Emit(OpCodes.Ldarg_0);
		iLGenerator9.Emit(OpCodes.Ldfld, field3);
		iLGenerator9.Emit(OpCodes.Call, method);
		iLGenerator9.Emit(OpCodes.Ret);
		ILGenerator iLGenerator10 = typeBuilder.DefineMethod("LoadFromStream", MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, CallingConventions.HasThis, typeof(Assembly), new Type[2]
		{
			typeof(Stream),
			typeof(Stream)
		}).GetILGenerator();
		iLGenerator10.Emit(OpCodes.Ldarg_0);
		iLGenerator10.Emit(OpCodes.Ldarg_1);
		iLGenerator10.Emit(OpCodes.Ldarg_2);
		iLGenerator10.Emit(OpCodes.Call, method10);
		iLGenerator10.Emit(OpCodes.Ret);
		generatedContextType = typeBuilder.CreateType();
	}
}
