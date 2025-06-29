using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.PCSEW_Base")]
public class PCSEW_Base : UObject
{
	private static bool Owner_IsValid;

	private static int Owner_Offset;

	private static bool MainThread_IsValid;

	private static IntPtr MainThread_FunctionAddress;

	private static int MainThread_ParamsSize;

	[UProperty]
	[USharpPath("/Script/b1-Managed.PCSEW_Base:Owner")]
	public AActor Owner
	{
		get
		{
			CheckDestroyed();
			if (!Owner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PCSEW_Base:Owner");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, Owner_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Owner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PCSEW_Base:Owner");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, Owner_Offset), value);
			}
		}
	}

	public void Init(AActor _Owner)
	{
		Owner = _Owner;
		if (Owner.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Owner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_PCSEW_Destroy.Invoke(this);
			}
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.PCSEW_Base:MainThread")]
	public void MainThread()
	{
		Wrapper();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Owner);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_PCSEW_Destroy.Invoke(this);
		}
	}

	public virtual void Wrapper()
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.PCSEW_Base:MainThread")]
	private static void MainThread__Invoker(IntPtr buffer, IntPtr obj)
	{
		PCSEW_Base pCSEW_Base = GCHelper.Find<PCSEW_Base>(obj);
		pCSEW_Base.MainThread();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.PCSEW_Base");
		Owner_Offset = NativeReflection.GetPropertyOffset(intPtr, "Owner");
		Owner_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Owner", Classes.FObjectProperty);
		MainThread_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MainThread");
		MainThread_ParamsSize = NativeReflection.GetFunctionParamsSize(MainThread_FunctionAddress);
		MainThread_IsValid = MainThread_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.PCSEW_Base:MainThread", MainThread_IsValid);
	}

	static PCSEW_Base()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(PCSEW_Base)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(PCSEW_Base));
	}
}
