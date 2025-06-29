using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintSpawnableComponent]
[UClass]
[USharpPath("/Script/b1-Managed.StructGCTest")]
public class UStructGCTest : AActor
{
	public TestTargetUStruct SelfTTUS;

	public string TestString = "UUU";

	public bool TestBool;

	private static bool DA_IsValid;

	private static int DA_Offset;

	private static bool bDoGCCheck_IsValid;

	private static int bDoGCCheck_Offset;

	private static FFieldAddress bDoGCCheck_PropertyAddress;

	private static bool SMCActor_IsValid;

	private static int SMCActor_Offset;

	private static bool SMC_IsValid;

	private static int SMC_Offset;

	private static bool QueueData_IsValid;

	private static int QueueData_Offset;

	private static bool DoInit_IsValid;

	private static IntPtr DoInit_FunctionAddress;

	private static int DoInit_ParamsSize;

	private static bool DoCheck_IsValid;

	private static IntPtr DoCheck_FunctionAddress;

	private static int DoCheck_ParamsSize;

	private static bool DestroyFX_IsValid;

	private static IntPtr DestroyFX_FunctionAddress;

	private static int DestroyFX_ParamsSize;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("DA")]
	[USharpPath("/Script/b1-Managed.StructGCTest:DA")]
	public UStructTestDataAsset DA
	{
		get
		{
			CheckDestroyed();
			if (!DA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.StructGCTest:DA");
				return null;
			}
			return UObjectMarshaler<UStructTestDataAsset>.FromNative(IntPtr.Add(base.Address, DA_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.StructGCTest:DA");
			}
			else
			{
				UObjectMarshaler<UStructTestDataAsset>.ToNative(IntPtr.Add(base.Address, DA_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.StructGCTest:bDoGCCheck")]
	public bool bDoGCCheck
	{
		get
		{
			CheckDestroyed();
			if (!bDoGCCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.StructGCTest:bDoGCCheck");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDoGCCheck_Offset), 0, bDoGCCheck_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDoGCCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.StructGCTest:bDoGCCheck");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDoGCCheck_Offset), 0, bDoGCCheck_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.StructGCTest:SMCActor")]
	public AActor SMCActor
	{
		get
		{
			CheckDestroyed();
			if (!SMCActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.StructGCTest:SMCActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, SMCActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SMCActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.StructGCTest:SMCActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, SMCActor_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.StructGCTest:SMC")]
	public UStaticMeshComponent SMC
	{
		get
		{
			CheckDestroyed();
			if (!SMC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.StructGCTest:SMC");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, SMC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SMC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.StructGCTest:SMC");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, SMC_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.StructGCTest:QueueData")]
	public TestQueueData QueueData
	{
		get
		{
			CheckDestroyed();
			if (!QueueData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.StructGCTest:QueueData");
				return null;
			}
			return UObjectMarshaler<TestQueueData>.FromNative(IntPtr.Add(base.Address, QueueData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!QueueData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.StructGCTest:QueueData");
			}
			else
			{
				UObjectMarshaler<TestQueueData>.ToNative(IntPtr.Add(base.Address, QueueData_Offset), value);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.StructGCTest:DestroyFX")]
	public void DestroyFX()
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.StructGCTest:DoInit")]
	public void DoInit()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.StructGCTest:DoCheck")]
	public void DoCheck()
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.StructGCTest:DoInit")]
	private static void DoInit__Invoker(IntPtr buffer, IntPtr obj)
	{
		UStructGCTest uStructGCTest = GCHelper.Find<UStructGCTest>(obj);
		uStructGCTest.DoInit();
	}

	[UFunctionInvoker("/Script/b1-Managed.StructGCTest:DoCheck")]
	private static void DoCheck__Invoker(IntPtr buffer, IntPtr obj)
	{
		UStructGCTest uStructGCTest = GCHelper.Find<UStructGCTest>(obj);
		uStructGCTest.DoCheck();
	}

	[UFunctionInvoker("/Script/b1-Managed.StructGCTest:DestroyFX")]
	private static void DestroyFX__Invoker(IntPtr buffer, IntPtr obj)
	{
		UStructGCTest uStructGCTest = GCHelper.Find<UStructGCTest>(obj);
		uStructGCTest.DestroyFX();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.StructGCTest");
		DA_Offset = NativeReflection.GetPropertyOffset(intPtr, "DA");
		DA_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DA", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bDoGCCheck_PropertyAddress, intPtr, "bDoGCCheck");
		bDoGCCheck_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDoGCCheck");
		bDoGCCheck_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDoGCCheck", Classes.FBoolProperty);
		SMCActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "SMCActor");
		SMCActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SMCActor", Classes.FObjectProperty);
		SMC_Offset = NativeReflection.GetPropertyOffset(intPtr, "SMC");
		SMC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SMC", Classes.FObjectProperty);
		QueueData_Offset = NativeReflection.GetPropertyOffset(intPtr, "QueueData");
		QueueData_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "QueueData", Classes.FObjectProperty);
		DoInit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoInit");
		DoInit_ParamsSize = NativeReflection.GetFunctionParamsSize(DoInit_FunctionAddress);
		DoInit_IsValid = DoInit_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.StructGCTest:DoInit", DoInit_IsValid);
		DoCheck_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoCheck");
		DoCheck_ParamsSize = NativeReflection.GetFunctionParamsSize(DoCheck_FunctionAddress);
		DoCheck_IsValid = DoCheck_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.StructGCTest:DoCheck", DoCheck_IsValid);
		DestroyFX_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DestroyFX");
		DestroyFX_ParamsSize = NativeReflection.GetFunctionParamsSize(DestroyFX_FunctionAddress);
		DestroyFX_IsValid = DestroyFX_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.StructGCTest:DestroyFX", DestroyFX_IsValid);
	}

	static UStructGCTest()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UStructGCTest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStructGCTest));
	}
}
