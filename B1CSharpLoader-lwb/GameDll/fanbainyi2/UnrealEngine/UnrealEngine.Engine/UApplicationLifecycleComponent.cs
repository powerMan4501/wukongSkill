using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.ApplicationLifecycleComponent", "Engine", UnrealModuleType.Engine)]
public class UApplicationLifecycleComponent : UActorComponent
{
	[UDelegate]
	[UMetaPath("/Script/Engine.ApplicationLifecycleComponent:OnTemperatureChangeDelegate__DelegateSignature")]
	public class FOnTemperatureChangeDelegate : FMulticastDelegate<FOnTemperatureChangeDelegate.Signature>
	{
		public delegate void Signature(ETemperatureSeverityType Severity);

		private static bool OnTemperatureChangeDelegate__DelegateSignature_IsValid;

		private static IntPtr OnTemperatureChangeDelegate__DelegateSignature_FunctionAddress;

		private static int OnTemperatureChangeDelegate__DelegateSignature_ParamsSize;

		private static bool OnTemperatureChangeDelegate__DelegateSignature_Severity_IsValid;

		private static FFieldAddress OnTemperatureChangeDelegate__DelegateSignature_Severity_PropertyAddress;

		private static int OnTemperatureChangeDelegate__DelegateSignature_Severity_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnTemperatureChangeDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnTemperatureChangeDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ApplicationLifecycleComponent:OnTemperatureChangeDelegate__DelegateSignature");
			OnTemperatureChangeDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTemperatureChangeDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnTemperatureChangeDelegate__DelegateSignature_Severity_PropertyAddress, OnTemperatureChangeDelegate__DelegateSignature_FunctionAddress, "Severity");
			OnTemperatureChangeDelegate__DelegateSignature_Severity_Offset = NativeReflectionCached.GetPropertyOffset(OnTemperatureChangeDelegate__DelegateSignature_FunctionAddress, "Severity");
			OnTemperatureChangeDelegate__DelegateSignature_Severity_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTemperatureChangeDelegate__DelegateSignature_FunctionAddress, "Severity", Classes.FEnumProperty);
			OnTemperatureChangeDelegate__DelegateSignature_IsValid = OnTemperatureChangeDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && OnTemperatureChangeDelegate__DelegateSignature_Severity_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/Engine.ApplicationLifecycleComponent:OnTemperatureChangeDelegate__DelegateSignature", OnTemperatureChangeDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(ETemperatureSeverityType Severity)
		{
			if (!OnTemperatureChangeDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ApplicationLifecycleComponent:OnTemperatureChangeDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnTemperatureChangeDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTemperatureChangeDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				EnumMarshaler<ETemperatureSeverityType>.ToNative(IntPtr.Add(intPtr, OnTemperatureChangeDelegate__DelegateSignature_Severity_Offset), 0, OnTemperatureChangeDelegate__DelegateSignature_Severity_PropertyAddress.Address, Severity);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/Engine.ApplicationLifecycleComponent:OnLowPowerModeDelegate__DelegateSignature")]
	public class FOnLowPowerModeDelegate : FMulticastDelegate<FOnLowPowerModeDelegate.Signature>
	{
		public delegate void Signature(bool bInLowPowerMode);

		private static bool OnLowPowerModeDelegate__DelegateSignature_IsValid;

		private static IntPtr OnLowPowerModeDelegate__DelegateSignature_FunctionAddress;

		private static int OnLowPowerModeDelegate__DelegateSignature_ParamsSize;

		private static bool OnLowPowerModeDelegate__DelegateSignature_bInLowPowerMode_IsValid;

		private static FFieldAddress OnLowPowerModeDelegate__DelegateSignature_bInLowPowerMode_PropertyAddress;

		private static int OnLowPowerModeDelegate__DelegateSignature_bInLowPowerMode_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnLowPowerModeDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnLowPowerModeDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ApplicationLifecycleComponent:OnLowPowerModeDelegate__DelegateSignature");
			OnLowPowerModeDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLowPowerModeDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnLowPowerModeDelegate__DelegateSignature_bInLowPowerMode_PropertyAddress, OnLowPowerModeDelegate__DelegateSignature_FunctionAddress, "bInLowPowerMode");
			OnLowPowerModeDelegate__DelegateSignature_bInLowPowerMode_Offset = NativeReflectionCached.GetPropertyOffset(OnLowPowerModeDelegate__DelegateSignature_FunctionAddress, "bInLowPowerMode");
			OnLowPowerModeDelegate__DelegateSignature_bInLowPowerMode_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLowPowerModeDelegate__DelegateSignature_FunctionAddress, "bInLowPowerMode", Classes.FBoolProperty);
			OnLowPowerModeDelegate__DelegateSignature_IsValid = OnLowPowerModeDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && OnLowPowerModeDelegate__DelegateSignature_bInLowPowerMode_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/Engine.ApplicationLifecycleComponent:OnLowPowerModeDelegate__DelegateSignature", OnLowPowerModeDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(bool bInLowPowerMode)
		{
			if (!OnLowPowerModeDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ApplicationLifecycleComponent:OnLowPowerModeDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnLowPowerModeDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLowPowerModeDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnLowPowerModeDelegate__DelegateSignature_bInLowPowerMode_Offset), 0, OnLowPowerModeDelegate__DelegateSignature_bInLowPowerMode_PropertyAddress.Address, bInLowPowerMode);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/Engine.ApplicationLifecycleComponent:ApplicationStartupArgumentsDelegate__DelegateSignature")]
	public class FApplicationStartupArgumentsDelegate : FMulticastDelegate<FApplicationStartupArgumentsDelegate.Signature>
	{
		public delegate void Signature(List<string> StartupArguments);

		private static bool ApplicationStartupArgumentsDelegate__DelegateSignature_IsValid;

		private static IntPtr ApplicationStartupArgumentsDelegate__DelegateSignature_FunctionAddress;

		private static int ApplicationStartupArgumentsDelegate__DelegateSignature_ParamsSize;

		private static bool ApplicationStartupArgumentsDelegate__DelegateSignature_StartupArguments_IsValid;

		private static FFieldAddress ApplicationStartupArgumentsDelegate__DelegateSignature_StartupArguments_PropertyAddress;

		private static int ApplicationStartupArgumentsDelegate__DelegateSignature_StartupArguments_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FApplicationStartupArgumentsDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			ApplicationStartupArgumentsDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ApplicationLifecycleComponent:ApplicationStartupArgumentsDelegate__DelegateSignature");
			ApplicationStartupArgumentsDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplicationStartupArgumentsDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref ApplicationStartupArgumentsDelegate__DelegateSignature_StartupArguments_PropertyAddress, ApplicationStartupArgumentsDelegate__DelegateSignature_FunctionAddress, "StartupArguments");
			ApplicationStartupArgumentsDelegate__DelegateSignature_StartupArguments_Offset = NativeReflectionCached.GetPropertyOffset(ApplicationStartupArgumentsDelegate__DelegateSignature_FunctionAddress, "StartupArguments");
			ApplicationStartupArgumentsDelegate__DelegateSignature_StartupArguments_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplicationStartupArgumentsDelegate__DelegateSignature_FunctionAddress, "StartupArguments", Classes.FArrayProperty);
			ApplicationStartupArgumentsDelegate__DelegateSignature_IsValid = ApplicationStartupArgumentsDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && ApplicationStartupArgumentsDelegate__DelegateSignature_StartupArguments_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/Engine.ApplicationLifecycleComponent:ApplicationStartupArgumentsDelegate__DelegateSignature", ApplicationStartupArgumentsDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(List<string> StartupArguments)
		{
			if (!ApplicationStartupArgumentsDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ApplicationLifecycleComponent:ApplicationStartupArgumentsDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(ApplicationStartupArgumentsDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplicationStartupArgumentsDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				new TArrayCopyMarshaler<string>(1, ApplicationStartupArgumentsDelegate__DelegateSignature_StartupArguments_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, ApplicationStartupArgumentsDelegate__DelegateSignature_StartupArguments_Offset), StartupArguments);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(ApplicationStartupArgumentsDelegate__DelegateSignature_StartupArguments_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/Engine.ApplicationLifecycleComponent:ApplicationLifetimeDelegate__DelegateSignature")]
	public class FApplicationLifetimeDelegate : FMulticastDelegate<FApplicationLifetimeDelegate.Signature>
	{
		public delegate void Signature();

		private static bool ApplicationLifetimeDelegate__DelegateSignature_IsValid;

		private static IntPtr ApplicationLifetimeDelegate__DelegateSignature_FunctionAddress;

		private static int ApplicationLifetimeDelegate__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FApplicationLifetimeDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			ApplicationLifetimeDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ApplicationLifecycleComponent:ApplicationLifetimeDelegate__DelegateSignature");
			ApplicationLifetimeDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplicationLifetimeDelegate__DelegateSignature_FunctionAddress);
			ApplicationLifetimeDelegate__DelegateSignature_IsValid = ApplicationLifetimeDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/Engine.ApplicationLifecycleComponent:ApplicationLifetimeDelegate__DelegateSignature", ApplicationLifetimeDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!ApplicationLifetimeDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ApplicationLifecycleComponent:ApplicationLifetimeDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(ApplicationLifetimeDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplicationLifetimeDelegate__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	private static bool ApplicationWillDeactivateDelegate_IsValid;

	private static int ApplicationWillDeactivateDelegate_Offset;

	private FApplicationLifetimeDelegate ApplicationWillDeactivateDelegate_DelegateCached;

	private static bool ApplicationHasReactivatedDelegate_IsValid;

	private static int ApplicationHasReactivatedDelegate_Offset;

	private FApplicationLifetimeDelegate ApplicationHasReactivatedDelegate_DelegateCached;

	private static bool ApplicationWillEnterBackgroundDelegate_IsValid;

	private static int ApplicationWillEnterBackgroundDelegate_Offset;

	private FApplicationLifetimeDelegate ApplicationWillEnterBackgroundDelegate_DelegateCached;

	private static bool ApplicationHasEnteredForegroundDelegate_IsValid;

	private static int ApplicationHasEnteredForegroundDelegate_Offset;

	private FApplicationLifetimeDelegate ApplicationHasEnteredForegroundDelegate_DelegateCached;

	private static bool ApplicationWillTerminateDelegate_IsValid;

	private static int ApplicationWillTerminateDelegate_Offset;

	private FApplicationLifetimeDelegate ApplicationWillTerminateDelegate_DelegateCached;

	private static bool ApplicationShouldUnloadResourcesDelegate_IsValid;

	private static int ApplicationShouldUnloadResourcesDelegate_Offset;

	private FApplicationLifetimeDelegate ApplicationShouldUnloadResourcesDelegate_DelegateCached;

	private static bool ApplicationReceivedStartupArgumentsDelegate_IsValid;

	private static int ApplicationReceivedStartupArgumentsDelegate_Offset;

	private FApplicationStartupArgumentsDelegate ApplicationReceivedStartupArgumentsDelegate_DelegateCached;

	private static bool OnTemperatureChangeDelegate_IsValid;

	private static int OnTemperatureChangeDelegate_Offset;

	private FOnTemperatureChangeDelegate OnTemperatureChangeDelegate_DelegateCached;

	private static bool OnLowPowerModeDelegate_IsValid;

	private static int OnLowPowerModeDelegate_Offset;

	private FOnLowPowerModeDelegate OnLowPowerModeDelegate_DelegateCached;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.ApplicationLifecycleComponent:ApplicationWillDeactivateDelegate")]
	public FApplicationLifetimeDelegate ApplicationWillDeactivateDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationWillDeactivateDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ApplicationLifecycleComponent:ApplicationWillDeactivateDelegate");
				return new FApplicationLifetimeDelegate();
			}
			if (ApplicationWillDeactivateDelegate_DelegateCached == null)
			{
				ApplicationWillDeactivateDelegate_DelegateCached = new FApplicationLifetimeDelegate();
				ApplicationWillDeactivateDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationWillDeactivateDelegate_Offset));
			}
			return ApplicationWillDeactivateDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.ApplicationLifecycleComponent:ApplicationHasReactivatedDelegate")]
	public FApplicationLifetimeDelegate ApplicationHasReactivatedDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationHasReactivatedDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ApplicationLifecycleComponent:ApplicationHasReactivatedDelegate");
				return new FApplicationLifetimeDelegate();
			}
			if (ApplicationHasReactivatedDelegate_DelegateCached == null)
			{
				ApplicationHasReactivatedDelegate_DelegateCached = new FApplicationLifetimeDelegate();
				ApplicationHasReactivatedDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationHasReactivatedDelegate_Offset));
			}
			return ApplicationHasReactivatedDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.ApplicationLifecycleComponent:ApplicationWillEnterBackgroundDelegate")]
	public FApplicationLifetimeDelegate ApplicationWillEnterBackgroundDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationWillEnterBackgroundDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ApplicationLifecycleComponent:ApplicationWillEnterBackgroundDelegate");
				return new FApplicationLifetimeDelegate();
			}
			if (ApplicationWillEnterBackgroundDelegate_DelegateCached == null)
			{
				ApplicationWillEnterBackgroundDelegate_DelegateCached = new FApplicationLifetimeDelegate();
				ApplicationWillEnterBackgroundDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationWillEnterBackgroundDelegate_Offset));
			}
			return ApplicationWillEnterBackgroundDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.ApplicationLifecycleComponent:ApplicationHasEnteredForegroundDelegate")]
	public FApplicationLifetimeDelegate ApplicationHasEnteredForegroundDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationHasEnteredForegroundDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ApplicationLifecycleComponent:ApplicationHasEnteredForegroundDelegate");
				return new FApplicationLifetimeDelegate();
			}
			if (ApplicationHasEnteredForegroundDelegate_DelegateCached == null)
			{
				ApplicationHasEnteredForegroundDelegate_DelegateCached = new FApplicationLifetimeDelegate();
				ApplicationHasEnteredForegroundDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationHasEnteredForegroundDelegate_Offset));
			}
			return ApplicationHasEnteredForegroundDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.ApplicationLifecycleComponent:ApplicationWillTerminateDelegate")]
	public FApplicationLifetimeDelegate ApplicationWillTerminateDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationWillTerminateDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ApplicationLifecycleComponent:ApplicationWillTerminateDelegate");
				return new FApplicationLifetimeDelegate();
			}
			if (ApplicationWillTerminateDelegate_DelegateCached == null)
			{
				ApplicationWillTerminateDelegate_DelegateCached = new FApplicationLifetimeDelegate();
				ApplicationWillTerminateDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationWillTerminateDelegate_Offset));
			}
			return ApplicationWillTerminateDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.ApplicationLifecycleComponent:ApplicationShouldUnloadResourcesDelegate")]
	public FApplicationLifetimeDelegate ApplicationShouldUnloadResourcesDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationShouldUnloadResourcesDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ApplicationLifecycleComponent:ApplicationShouldUnloadResourcesDelegate");
				return new FApplicationLifetimeDelegate();
			}
			if (ApplicationShouldUnloadResourcesDelegate_DelegateCached == null)
			{
				ApplicationShouldUnloadResourcesDelegate_DelegateCached = new FApplicationLifetimeDelegate();
				ApplicationShouldUnloadResourcesDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationShouldUnloadResourcesDelegate_Offset));
			}
			return ApplicationShouldUnloadResourcesDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.ApplicationLifecycleComponent:ApplicationReceivedStartupArgumentsDelegate")]
	public FApplicationStartupArgumentsDelegate ApplicationReceivedStartupArgumentsDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationReceivedStartupArgumentsDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ApplicationLifecycleComponent:ApplicationReceivedStartupArgumentsDelegate");
				return new FApplicationStartupArgumentsDelegate();
			}
			if (ApplicationReceivedStartupArgumentsDelegate_DelegateCached == null)
			{
				ApplicationReceivedStartupArgumentsDelegate_DelegateCached = new FApplicationStartupArgumentsDelegate();
				ApplicationReceivedStartupArgumentsDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationReceivedStartupArgumentsDelegate_Offset));
			}
			return ApplicationReceivedStartupArgumentsDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.ApplicationLifecycleComponent:OnTemperatureChangeDelegate")]
	public FOnTemperatureChangeDelegate OnTemperatureChangeDelegate
	{
		get
		{
			CheckDestroyed();
			if (!OnTemperatureChangeDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ApplicationLifecycleComponent:OnTemperatureChangeDelegate");
				return new FOnTemperatureChangeDelegate();
			}
			if (OnTemperatureChangeDelegate_DelegateCached == null)
			{
				OnTemperatureChangeDelegate_DelegateCached = new FOnTemperatureChangeDelegate();
				OnTemperatureChangeDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTemperatureChangeDelegate_Offset));
			}
			return OnTemperatureChangeDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.ApplicationLifecycleComponent:OnLowPowerModeDelegate")]
	public FOnLowPowerModeDelegate OnLowPowerModeDelegate
	{
		get
		{
			CheckDestroyed();
			if (!OnLowPowerModeDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ApplicationLifecycleComponent:OnLowPowerModeDelegate");
				return new FOnLowPowerModeDelegate();
			}
			if (OnLowPowerModeDelegate_DelegateCached == null)
			{
				OnLowPowerModeDelegate_DelegateCached = new FOnLowPowerModeDelegate();
				OnLowPowerModeDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnLowPowerModeDelegate_Offset));
			}
			return OnLowPowerModeDelegate_DelegateCached;
		}
	}

	static UApplicationLifecycleComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UApplicationLifecycleComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UApplicationLifecycleComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.ApplicationLifecycleComponent");
		ApplicationWillDeactivateDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationWillDeactivateDelegate");
		ApplicationWillDeactivateDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationWillDeactivateDelegate", Classes.FMulticastDelegateProperty);
		ApplicationHasReactivatedDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationHasReactivatedDelegate");
		ApplicationHasReactivatedDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationHasReactivatedDelegate", Classes.FMulticastDelegateProperty);
		ApplicationWillEnterBackgroundDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationWillEnterBackgroundDelegate");
		ApplicationWillEnterBackgroundDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationWillEnterBackgroundDelegate", Classes.FMulticastDelegateProperty);
		ApplicationHasEnteredForegroundDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationHasEnteredForegroundDelegate");
		ApplicationHasEnteredForegroundDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationHasEnteredForegroundDelegate", Classes.FMulticastDelegateProperty);
		ApplicationWillTerminateDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationWillTerminateDelegate");
		ApplicationWillTerminateDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationWillTerminateDelegate", Classes.FMulticastDelegateProperty);
		ApplicationShouldUnloadResourcesDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationShouldUnloadResourcesDelegate");
		ApplicationShouldUnloadResourcesDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationShouldUnloadResourcesDelegate", Classes.FMulticastDelegateProperty);
		ApplicationReceivedStartupArgumentsDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationReceivedStartupArgumentsDelegate");
		ApplicationReceivedStartupArgumentsDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationReceivedStartupArgumentsDelegate", Classes.FMulticastDelegateProperty);
		OnTemperatureChangeDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnTemperatureChangeDelegate");
		OnTemperatureChangeDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnTemperatureChangeDelegate", Classes.FMulticastDelegateProperty);
		OnLowPowerModeDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnLowPowerModeDelegate");
		OnLowPowerModeDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnLowPowerModeDelegate", Classes.FMulticastDelegateProperty);
	}
}
