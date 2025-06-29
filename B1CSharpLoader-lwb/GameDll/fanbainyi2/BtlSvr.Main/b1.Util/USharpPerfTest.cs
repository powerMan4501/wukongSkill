using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Util;

[UClass]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.SharpPerfTest")]
internal class USharpPerfTest : AUSharpPerfTestBase
{
	private const int AMOUNT_SUPER_HUGE = 50000000;

	private const int AMOUNT_LARGE = 500000;

	private const int AMOUNT_MED = 5000;

	public int IntMember;

	private static bool CSIntProperty_IsValid;

	private static int CSIntProperty_Offset;

	private static bool DelegateCB_IsValid;

	private static IntPtr DelegateCB_FunctionAddress;

	private static int DelegateCB_ParamsSize;

	private static bool DelegateCB_P1_IsValid;

	private static int DelegateCB_P1_Offset;

	private static bool DelegateCB_P2_IsValid;

	private static int DelegateCB_P2_Offset;

	private static bool DelegateCB_P3_IsValid;

	private static int DelegateCB_P3_Offset;

	private static bool DelegateCB_P4_IsValid;

	private static int DelegateCB_P4_Offset;

	private static bool TickInCS_IsValid;

	private static IntPtr TickInCS_FunctionAddress;

	private static int TickInCS_ParamsSize;

	private static bool TickInCS_DeltaTime_IsValid;

	private static int TickInCS_DeltaTime_Offset;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SharpPerfTest:CSIntProperty")]
	public int CSIntProperty
	{
		get
		{
			CheckDestroyed();
			if (!CSIntProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.SharpPerfTest:CSIntProperty");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CSIntProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CSIntProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.SharpPerfTest:CSIntProperty");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CSIntProperty_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.SharpPerfTest:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
		base.FBUE_USharpCallbackPerfTest.Bind(DelegateCB);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.SharpPerfTest:DelegateCB")]
	public void DelegateCB(int P1, int P2, int P3, int P4)
	{
		USystemLibrary.PrintString(this, "del", bPrintToScreen: true, bPrintToLog: true, FLinearColor.White, 2f, FName.None);
	}

	[USharpPath("/Script/b1-Managed.SharpPerfTest:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
		base.ReceiveTick_Implementation(DeltaSeconds);
	}

	[USharpPath("/Script/b1-Managed.SharpPerfTest:TickInCS")]
	protected override void TickInCS_Implementation(float DeltaTime)
	{
		base.FBUE_USharpCallbackPerfTest.Invoke(1, 2, 3, 4);
	}

	private void TestSimpleAdd()
	{
		for (int i = 0; i < 50000000; i++)
		{
			IntMember++;
		}
	}

	private void TestReadWriteCppProperty()
	{
		for (int i = 0; i < 500000; i++)
		{
			base.IntProp++;
		}
	}

	private void TestReadWriteCSharpProperty()
	{
		for (int i = 0; i < 500000; i++)
		{
			CSIntProperty++;
		}
	}

	private void TestCallTickInCS()
	{
		for (int i = 0; i < 500000; i++)
		{
			TickInCS(0.1f);
		}
	}

	private void TestCallFuncWithParam()
	{
		for (int i = 0; i < 500000; i++)
		{
			EmptyCallableFuncWithParams(1, 2f, 3, bP4: true);
		}
	}

	private void TestCallFuncWithParam2()
	{
		for (int i = 0; i < 500000; i++)
		{
			EmptyCallableFuncWithParams2(B1GlobalFNames.num_123, "123", FText.FromString("123"));
		}
	}

	private void TestCallMultiDel()
	{
		for (int i = 0; i < 500000; i++)
		{
			base.FBUE_USharpCallbackPerfTest.Invoke(1, 2, 3, 4);
		}
	}

	private void TestCallMultiDelNoDyn()
	{
		for (int i = 0; i < 500000; i++)
		{
			InvokeMultiDelegateNoDyn(1, 2, 3, 4);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.SharpPerfTest:DelegateCB")]
	private static void DelegateCB__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.Util.USharpPerfTest uSharpPerfTest = GCHelper.Find<b1.Util.USharpPerfTest>(obj);
		int p = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, DelegateCB_P1_Offset));
		int p2 = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, DelegateCB_P2_Offset));
		int p3 = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, DelegateCB_P3_Offset));
		int p4 = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, DelegateCB_P4_Offset));
		uSharpPerfTest.DelegateCB(p, p2, p3, p4);
	}

	[UFunctionInvoker("/Script/b1-Managed.SharpPerfTest:TickInCS")]
	private static void TickInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.Util.USharpPerfTest uSharpPerfTest = GCHelper.Find<b1.Util.USharpPerfTest>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickInCS_DeltaTime_Offset));
		uSharpPerfTest.TickInCS_Implementation(deltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.SharpPerfTest:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.Util.USharpPerfTest uSharpPerfTest = GCHelper.Find<b1.Util.USharpPerfTest>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		uSharpPerfTest.ReceiveTick_Implementation(deltaSeconds);
	}

	[UFunctionInvoker("/Script/b1-Managed.SharpPerfTest:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.Util.USharpPerfTest uSharpPerfTest = GCHelper.Find<b1.Util.USharpPerfTest>(obj);
		uSharpPerfTest.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.SharpPerfTest");
		CSIntProperty_Offset = NativeReflection.GetPropertyOffset(intPtr, "CSIntProperty");
		CSIntProperty_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CSIntProperty", Classes.FIntProperty);
		DelegateCB_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DelegateCB");
		DelegateCB_ParamsSize = NativeReflection.GetFunctionParamsSize(DelegateCB_FunctionAddress);
		DelegateCB_P1_Offset = NativeReflection.GetPropertyOffset(DelegateCB_FunctionAddress, "P1");
		DelegateCB_P1_IsValid = NativeReflection.ValidatePropertyClass(DelegateCB_FunctionAddress, "P1", Classes.FIntProperty);
		DelegateCB_P2_Offset = NativeReflection.GetPropertyOffset(DelegateCB_FunctionAddress, "P2");
		DelegateCB_P2_IsValid = NativeReflection.ValidatePropertyClass(DelegateCB_FunctionAddress, "P2", Classes.FIntProperty);
		DelegateCB_P3_Offset = NativeReflection.GetPropertyOffset(DelegateCB_FunctionAddress, "P3");
		DelegateCB_P3_IsValid = NativeReflection.ValidatePropertyClass(DelegateCB_FunctionAddress, "P3", Classes.FIntProperty);
		DelegateCB_P4_Offset = NativeReflection.GetPropertyOffset(DelegateCB_FunctionAddress, "P4");
		DelegateCB_P4_IsValid = NativeReflection.ValidatePropertyClass(DelegateCB_FunctionAddress, "P4", Classes.FIntProperty);
		DelegateCB_IsValid = DelegateCB_FunctionAddress != IntPtr.Zero && DelegateCB_P1_IsValid && DelegateCB_P2_IsValid && DelegateCB_P3_IsValid && DelegateCB_P4_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.SharpPerfTest:DelegateCB", DelegateCB_IsValid);
		TickInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickInCS");
		TickInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickInCS_FunctionAddress);
		TickInCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickInCS_FunctionAddress, "DeltaTime");
		TickInCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickInCS_IsValid = TickInCS_FunctionAddress != IntPtr.Zero && TickInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.SharpPerfTest:TickInCS", TickInCS_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.SharpPerfTest:ReceiveTick", ReceiveTick_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.SharpPerfTest:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}

	static USharpPerfTest()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.Util.USharpPerfTest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.Util.USharpPerfTest));
	}
}
