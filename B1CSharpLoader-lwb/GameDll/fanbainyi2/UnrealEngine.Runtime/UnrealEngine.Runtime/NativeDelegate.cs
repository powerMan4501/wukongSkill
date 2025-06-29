using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class NativeDelegate<TNativeDelegate, TRegisterNativeDelegate, TManagedDelegate> : INativeDelegate where TNativeDelegate : class where TRegisterNativeDelegate : class where TManagedDelegate : class
{
	[MonoNativeFunctionWrapper]
	private delegate void RegisterNativeDelegateWrapper(IntPtr handler, csbool enable);

	private Dictionary<TManagedDelegate, MethodInfo> boundEvents = new Dictionary<TManagedDelegate, MethodInfo>();

	private Dictionary<MethodInfo, TManagedDelegate> boundMethods = new Dictionary<MethodInfo, TManagedDelegate>();

	private bool registeredNativeCallback;

	private TNativeDelegate nativeCallback;

	protected static NativeDelegateHandle<TManagedDelegate> managed;

	private TRegisterNativeDelegate registerNativeDelegate;

	private Native_FCoreDelegates.Del_Reg_CoreDelegates registerNativeMulticastDelegateWrapper;

	private RegisterNativeDelegateWrapper registerNativeDelegateWrapper;

	public IntPtr TargetAddress { get; set; }

	public virtual bool IsMulticast => false;

	public NativeDelegate(IntPtr targetObjAddress)
		: this()
	{
		TargetAddress = targetObjAddress;
	}

	public NativeDelegate()
	{
		UpdateNativeRegistrar();
		UpdateNativeCallback();
	}

	private void UpdateNativeRegistrar()
	{
		if (registerNativeDelegate != null)
		{
			return;
		}
		BindingFlags bindingAttr = BindingFlags.Static | BindingFlags.Public;
		string text = typeof(TRegisterNativeDelegate).Name.Remove(0, "Del_".Length);
		FieldInfo[] fields = typeof(TRegisterNativeDelegate).DeclaringType.GetFields(bindingAttr);
		bool flag = false;
		FieldInfo[] array = fields;
		foreach (FieldInfo fieldInfo in array)
		{
			if (!fieldInfo.IsStatic || !(fieldInfo.Name == text))
			{
				continue;
			}
			if (fieldInfo.GetValue(null) is Delegate obj)
			{
				object firstArgument = null;
				if (!AssemblyContext.IsMono || SharedRuntimeState.GetInitializedRuntimes() == EDotNetRuntime.IL2CPP)
				{
					firstArgument = obj;
				}
				flag = true;
				if (IsMulticast)
				{
					registerNativeMulticastDelegateWrapper = (Native_FCoreDelegates.Del_Reg_CoreDelegates)obj;
				}
				else
				{
					registerNativeDelegateWrapper = (RegisterNativeDelegateWrapper)Delegate.CreateDelegate(typeof(RegisterNativeDelegateWrapper), firstArgument, obj.Method);
				}
			}
			break;
		}
	}

	private void UpdateNativeCallback()
	{
		if (nativeCallback != null)
		{
			return;
		}
		BindingFlags bindingAttr = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
		MethodInfo methodInfo = null;
		Type type = GetType();
		while (type != null)
		{
			methodInfo = type.GetMethod("NativeCallback", bindingAttr);
			if (methodInfo != null)
			{
				break;
			}
			type = type.BaseType;
		}
		if (methodInfo != null)
		{
			nativeCallback = Delegate.CreateDelegate(typeof(TNativeDelegate), null, methodInfo) as TNativeDelegate;
		}
	}

	public void Bind(TManagedDelegate evnt)
	{
		if (!(evnt is Delegate obj))
		{
			return;
		}
		if (obj.Target != null)
		{
			throw new Exception("il2cpp not support instanced callback");
		}
		MethodInfo method = obj.Method;
		if (!registeredNativeCallback)
		{
			IntPtr handler = IntPtr.Zero;
			if (nativeCallback != null)
			{
				handler = Marshal.GetFunctionPointerForDelegate(nativeCallback);
			}
			if (IsMulticast)
			{
				if (registerNativeMulticastDelegateWrapper != null && nativeCallback != null)
				{
					registerNativeMulticastDelegateWrapper(TargetAddress, handler, ref managed.Handle, true);
				}
			}
			else if (registerNativeDelegateWrapper != null && nativeCallback != null)
			{
				registerNativeDelegateWrapper(handler, true);
			}
			registeredNativeCallback = true;
		}
		if (!IsBound(evnt))
		{
			if (IsMulticast)
			{
				managed.Delegate = Delegate.Combine(managed.Delegate as Delegate, obj) as TManagedDelegate;
			}
			else
			{
				boundEvents.Clear();
				boundMethods.Clear();
				managed.Delegate = obj as TManagedDelegate;
			}
			boundEvents[evnt] = method;
			boundMethods[method] = evnt;
		}
	}

	public void Unbind(TManagedDelegate evnt)
	{
		if (!(evnt is Delegate obj) || obj.Method == null)
		{
			return;
		}
		if (obj.Target != null)
		{
			throw new Exception("il2cpp not support instanced callback");
		}
		if (!boundEvents.TryGetValue(evnt, out var value) && boundMethods.TryGetValue(obj.Method, out var _))
		{
			value = obj.Method;
		}
		if (!(value != null))
		{
			return;
		}
		boundEvents.Remove(evnt);
		boundMethods.Remove(value);
		managed.Delegate = Delegate.Remove(managed.Delegate as Delegate, evnt as Delegate) as TManagedDelegate;
		if (managed.Delegate != null || !registeredNativeCallback)
		{
			return;
		}
		IntPtr handler = IntPtr.Zero;
		if (nativeCallback != null)
		{
			handler = Marshal.GetFunctionPointerForDelegate(nativeCallback);
		}
		if (IsMulticast)
		{
			if (registerNativeMulticastDelegateWrapper != null && nativeCallback != null)
			{
				registerNativeMulticastDelegateWrapper(TargetAddress, handler, ref managed.Handle, false);
			}
		}
		else if (registerNativeDelegateWrapper != null && nativeCallback != null)
		{
			registerNativeDelegateWrapper(handler, false);
		}
		registeredNativeCallback = false;
	}

	public void OnUnload()
	{
		UnbindAll();
	}

	public void UnbindAll()
	{
		while (boundEvents.Count > 0)
		{
			using Dictionary<TManagedDelegate, MethodInfo>.Enumerator enumerator = boundEvents.GetEnumerator();
			if (enumerator.MoveNext())
			{
				Unbind(enumerator.Current.Key);
				continue;
			}
			break;
		}
	}

	public bool IsBound(TManagedDelegate evnt)
	{
		if (!(evnt is Delegate { Method: var method }))
		{
			return false;
		}
		if (!boundEvents.ContainsKey(evnt))
		{
			if (method != null)
			{
				return boundMethods.ContainsKey(method);
			}
			return false;
		}
		return true;
	}
}
