using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.USharpPerfTestBase", "b1", UnrealModuleType.Game)]
public class AUSharpPerfTestBase : AActor
{
	private static bool IntProp_IsValid;

	private static int IntProp_Offset;

	private static bool FBUE_USharpCallbackPerfTest_IsValid;

	private static int FBUE_USharpCallbackPerfTest_Offset;

	private FBUE_USharpPerfTest FBUE_USharpCallbackPerfTest_DelegateCached;

	private static bool TickInCS_IsValid;

	private IntPtr TickInCS_InstanceFunctionAddress;

	private static IntPtr TickInCS_FunctionAddress;

	private static int TickInCS_ParamsSize;

	private static bool TickInCS_DeltaTime_IsValid;

	private static FFieldAddress TickInCS_DeltaTime_PropertyAddress;

	private static int TickInCS_DeltaTime_Offset;

	private static bool TestFastFuncExport_IsValid;

	private static IntPtr TestFastFuncExport_FunctionAddress;

	private static int TestFastFuncExport_ParamsSize;

	private static bool TestFastFuncExport_P1_IsValid;

	private static FFieldAddress TestFastFuncExport_P1_PropertyAddress;

	private static int TestFastFuncExport_P1_Offset;

	private static bool TestFastFuncExport_P2_IsValid;

	private static FFieldAddress TestFastFuncExport_P2_PropertyAddress;

	private static int TestFastFuncExport_P2_Offset;

	private static bool TestFastFuncExport_P3_IsValid;

	private static FFieldAddress TestFastFuncExport_P3_PropertyAddress;

	private static int TestFastFuncExport_P3_Offset;

	private static bool TestFastFuncExport_bP4_IsValid;

	private static FFieldAddress TestFastFuncExport_bP4_PropertyAddress;

	private static int TestFastFuncExport_bP4_Offset;

	private static bool TestFastFuncExport_ReturnValue_IsValid;

	private static FFieldAddress TestFastFuncExport_ReturnValue_PropertyAddress;

	private static int TestFastFuncExport_ReturnValue_Offset;

	private static bool StructAsClassGetInt_IsValid;

	private static IntPtr StructAsClassGetInt_FunctionAddress;

	private static int StructAsClassGetInt_ParamsSize;

	private static bool StructAsClassGetInt_InVal_IsValid;

	private static FFieldAddress StructAsClassGetInt_InVal_PropertyAddress;

	private static int StructAsClassGetInt_InVal_Offset;

	private static bool StructAsClassGetInt_ReturnValue_IsValid;

	private static FFieldAddress StructAsClassGetInt_ReturnValue_PropertyAddress;

	private static int StructAsClassGetInt_ReturnValue_Offset;

	private static bool StructAsClassCreate_IsValid;

	private static IntPtr StructAsClassCreate_FunctionAddress;

	private static int StructAsClassCreate_ParamsSize;

	private static bool StructAsClassCreate_RawValue_IsValid;

	private static FFieldAddress StructAsClassCreate_RawValue_PropertyAddress;

	private static int StructAsClassCreate_RawValue_Offset;

	private static bool StructAsClassCreate_ReturnValue_IsValid;

	private static FFieldAddress StructAsClassCreate_ReturnValue_PropertyAddress;

	private static int StructAsClassCreate_ReturnValue_Offset;

	private static bool InvokeMultiDelegateNoDyn_IsValid;

	private static IntPtr InvokeMultiDelegateNoDyn_FunctionAddress;

	private static int InvokeMultiDelegateNoDyn_ParamsSize;

	private static bool InvokeMultiDelegateNoDyn_AttrID_IsValid;

	private static FFieldAddress InvokeMultiDelegateNoDyn_AttrID_PropertyAddress;

	private static int InvokeMultiDelegateNoDyn_AttrID_Offset;

	private static bool InvokeMultiDelegateNoDyn_RealNewValue_IsValid;

	private static FFieldAddress InvokeMultiDelegateNoDyn_RealNewValue_PropertyAddress;

	private static int InvokeMultiDelegateNoDyn_RealNewValue_Offset;

	private static bool InvokeMultiDelegateNoDyn_RealOrgValue_IsValid;

	private static FFieldAddress InvokeMultiDelegateNoDyn_RealOrgValue_PropertyAddress;

	private static int InvokeMultiDelegateNoDyn_RealOrgValue_Offset;

	private static bool InvokeMultiDelegateNoDyn_ExpectChangeValue_IsValid;

	private static FFieldAddress InvokeMultiDelegateNoDyn_ExpectChangeValue_PropertyAddress;

	private static int InvokeMultiDelegateNoDyn_ExpectChangeValue_Offset;

	private static bool InvokeMultiDelegate_IsValid;

	private static IntPtr InvokeMultiDelegate_FunctionAddress;

	private static int InvokeMultiDelegate_ParamsSize;

	private static bool InvokeMultiDelegate_AttrID_IsValid;

	private static FFieldAddress InvokeMultiDelegate_AttrID_PropertyAddress;

	private static int InvokeMultiDelegate_AttrID_Offset;

	private static bool InvokeMultiDelegate_RealNewValue_IsValid;

	private static FFieldAddress InvokeMultiDelegate_RealNewValue_PropertyAddress;

	private static int InvokeMultiDelegate_RealNewValue_Offset;

	private static bool InvokeMultiDelegate_RealOrgValue_IsValid;

	private static FFieldAddress InvokeMultiDelegate_RealOrgValue_PropertyAddress;

	private static int InvokeMultiDelegate_RealOrgValue_Offset;

	private static bool InvokeMultiDelegate_ExpectChangeValue_IsValid;

	private static FFieldAddress InvokeMultiDelegate_ExpectChangeValue_PropertyAddress;

	private static int InvokeMultiDelegate_ExpectChangeValue_Offset;

	private static bool IntRetTest2_IsValid;

	private IntPtr IntRetTest2_InstanceFunctionAddress;

	private static IntPtr IntRetTest2_FunctionAddress;

	private static int IntRetTest2_ParamsSize;

	private static bool IntRetTest2_P1_IsValid;

	private static FFieldAddress IntRetTest2_P1_PropertyAddress;

	private static int IntRetTest2_P1_Offset;

	private static bool IntRetTest2_P2_IsValid;

	private static FFieldAddress IntRetTest2_P2_PropertyAddress;

	private static int IntRetTest2_P2_Offset;

	private static bool IntRetTest2_bP3_IsValid;

	private static FFieldAddress IntRetTest2_bP3_PropertyAddress;

	private static int IntRetTest2_bP3_Offset;

	private static bool IntRetTest2_ReturnValue_IsValid;

	private static FFieldAddress IntRetTest2_ReturnValue_PropertyAddress;

	private static int IntRetTest2_ReturnValue_Offset;

	private static bool IntRetTest_IsValid;

	private IntPtr IntRetTest_InstanceFunctionAddress;

	private static IntPtr IntRetTest_FunctionAddress;

	private static int IntRetTest_ParamsSize;

	private static bool IntRetTest_P1_IsValid;

	private static FFieldAddress IntRetTest_P1_PropertyAddress;

	private static int IntRetTest_P1_Offset;

	private static bool IntRetTest_P2_IsValid;

	private static FFieldAddress IntRetTest_P2_PropertyAddress;

	private static int IntRetTest_P2_Offset;

	private static bool IntRetTest_bP3_IsValid;

	private static FFieldAddress IntRetTest_bP3_PropertyAddress;

	private static int IntRetTest_bP3_Offset;

	private static bool IntRetTest_Out1_IsValid;

	private static FFieldAddress IntRetTest_Out1_PropertyAddress;

	private static int IntRetTest_Out1_Offset;

	private static bool IntRetTest_ReturnValue_IsValid;

	private static FFieldAddress IntRetTest_ReturnValue_PropertyAddress;

	private static int IntRetTest_ReturnValue_Offset;

	private static bool EmptyCallableFuncWithParams2_IsValid;

	private static IntPtr EmptyCallableFuncWithParams2_FunctionAddress;

	private static int EmptyCallableFuncWithParams2_ParamsSize;

	private static bool EmptyCallableFuncWithParams2_P1_IsValid;

	private static FFieldAddress EmptyCallableFuncWithParams2_P1_PropertyAddress;

	private static int EmptyCallableFuncWithParams2_P1_Offset;

	private static bool EmptyCallableFuncWithParams2_P2_IsValid;

	private static FFieldAddress EmptyCallableFuncWithParams2_P2_PropertyAddress;

	private static int EmptyCallableFuncWithParams2_P2_Offset;

	private static bool EmptyCallableFuncWithParams2_P3_IsValid;

	private static FFieldAddress EmptyCallableFuncWithParams2_P3_PropertyAddress;

	private static int EmptyCallableFuncWithParams2_P3_Offset;

	private static bool EmptyCallableFuncWithParams_IsValid;

	private static IntPtr EmptyCallableFuncWithParams_FunctionAddress;

	private static int EmptyCallableFuncWithParams_ParamsSize;

	private static bool EmptyCallableFuncWithParams_P1_IsValid;

	private static FFieldAddress EmptyCallableFuncWithParams_P1_PropertyAddress;

	private static int EmptyCallableFuncWithParams_P1_Offset;

	private static bool EmptyCallableFuncWithParams_P2_IsValid;

	private static FFieldAddress EmptyCallableFuncWithParams_P2_PropertyAddress;

	private static int EmptyCallableFuncWithParams_P2_Offset;

	private static bool EmptyCallableFuncWithParams_P3_IsValid;

	private static FFieldAddress EmptyCallableFuncWithParams_P3_PropertyAddress;

	private static int EmptyCallableFuncWithParams_P3_Offset;

	private static bool EmptyCallableFuncWithParams_bP4_IsValid;

	private static FFieldAddress EmptyCallableFuncWithParams_bP4_PropertyAddress;

	private static int EmptyCallableFuncWithParams_bP4_Offset;

	private static bool EmptyCallableFunc_IsValid;

	private static IntPtr EmptyCallableFunc_FunctionAddress;

	private static int EmptyCallableFunc_ParamsSize;

	private static bool BoolRetTest_IsValid;

	private IntPtr BoolRetTest_InstanceFunctionAddress;

	private static IntPtr BoolRetTest_FunctionAddress;

	private static int BoolRetTest_ParamsSize;

	private static bool BoolRetTest_P1_IsValid;

	private static FFieldAddress BoolRetTest_P1_PropertyAddress;

	private static int BoolRetTest_P1_Offset;

	private static bool BoolRetTest_P2_IsValid;

	private static FFieldAddress BoolRetTest_P2_PropertyAddress;

	private static int BoolRetTest_P2_Offset;

	private static bool BoolRetTest_bP3_IsValid;

	private static FFieldAddress BoolRetTest_bP3_PropertyAddress;

	private static int BoolRetTest_bP3_Offset;

	private static bool BoolRetTest_ReturnValue_IsValid;

	private static FFieldAddress BoolRetTest_ReturnValue_PropertyAddress;

	private static int BoolRetTest_ReturnValue_Offset;

	private static bool BeginPlayInCS_IsValid;

	private IntPtr BeginPlayInCS_InstanceFunctionAddress;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.USharpPerfTestBase:IntProp")]
	public int IntProp
	{
		get
		{
			CheckDestroyed();
			if (!IntProp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.USharpPerfTestBase:IntProp");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, IntProp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IntProp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.USharpPerfTestBase:IntProp");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, IntProp_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/b1.USharpPerfTestBase:FBUE_USharpCallbackPerfTest")]
	public FBUE_USharpPerfTest FBUE_USharpCallbackPerfTest
	{
		get
		{
			CheckDestroyed();
			if (!FBUE_USharpCallbackPerfTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.USharpPerfTestBase:FBUE_USharpCallbackPerfTest");
				return new FBUE_USharpPerfTest();
			}
			if (FBUE_USharpCallbackPerfTest_DelegateCached == null)
			{
				FBUE_USharpCallbackPerfTest_DelegateCached = new FBUE_USharpPerfTest();
				FBUE_USharpCallbackPerfTest_DelegateCached.SetAddress(IntPtr.Add(base.Address, FBUE_USharpCallbackPerfTest_Offset));
			}
			return FBUE_USharpCallbackPerfTest_DelegateCached;
		}
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.USharpPerfTestBase:TickInCS")]
	protected unsafe void TickInCS(float DeltaTime)
	{
		CheckDestroyed();
		if (!TickInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.USharpPerfTestBase:TickInCS");
			return;
		}
		if (TickInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			TickInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "TickInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(TickInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TickInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TickInCS_DeltaTime_Offset), 0, TickInCS_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, TickInCS_InstanceFunctionAddress, intPtr, TickInCS_ParamsSize);
	}

	protected unsafe virtual void TickInCS_Implementation(float DeltaTime)
	{
		CheckDestroyed();
		if (!TickInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.USharpPerfTestBase:TickInCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TickInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TickInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TickInCS_DeltaTime_Offset), 0, TickInCS_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, TickInCS_FunctionAddress, intPtr, TickInCS_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.USharpPerfTestBase:TestFastFuncExport")]
	protected unsafe float TestFastFuncExport(int P1, float P2, int P3, bool bP4)
	{
		CheckDestroyed();
		if (!TestFastFuncExport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.USharpPerfTestBase:TestFastFuncExport");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TestFastFuncExport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TestFastFuncExport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, TestFastFuncExport_P1_Offset), 0, TestFastFuncExport_P1_PropertyAddress.Address, P1);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TestFastFuncExport_P2_Offset), 0, TestFastFuncExport_P2_PropertyAddress.Address, P2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, TestFastFuncExport_P3_Offset), 0, TestFastFuncExport_P3_PropertyAddress.Address, P3);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, TestFastFuncExport_bP4_Offset), 0, TestFastFuncExport_bP4_PropertyAddress.Address, bP4);
		NativeReflection.InvokeFunctionOptimized(base.Address, TestFastFuncExport_FunctionAddress, intPtr, TestFastFuncExport_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, TestFastFuncExport_ReturnValue_Offset), 0, TestFastFuncExport_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339870721u)]
	[UMetaPath("/Script/b1.USharpPerfTestBase:StructAsClassGetInt")]
	public unsafe int StructAsClassGetInt(FUSharpTestStructAsClass InVal)
	{
		CheckDestroyed();
		if (!StructAsClassGetInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.USharpPerfTestBase:StructAsClassGetInt");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StructAsClassGetInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StructAsClassGetInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(StructAsClassGetInt_InVal_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FUSharpTestStructAsClass>.ToNative(IntPtr.Add(intPtr, StructAsClassGetInt_InVal_Offset), 0, StructAsClassGetInt_InVal_PropertyAddress.Address, InVal);
		NativeReflection.InvokeFunctionOptimized(base.Address, StructAsClassGetInt_FunctionAddress, intPtr, StructAsClassGetInt_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, StructAsClassGetInt_ReturnValue_Offset), 0, StructAsClassGetInt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/b1.USharpPerfTestBase:StructAsClassCreate")]
	public unsafe FUSharpTestStructAsClass StructAsClassCreate(int RawValue)
	{
		CheckDestroyed();
		if (!StructAsClassCreate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.USharpPerfTestBase:StructAsClassCreate");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StructAsClassCreate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StructAsClassCreate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, StructAsClassCreate_RawValue_Offset), 0, StructAsClassCreate_RawValue_PropertyAddress.Address, RawValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, StructAsClassCreate_FunctionAddress, intPtr, StructAsClassCreate_ParamsSize);
		return StructAsClassMarshaler<FUSharpTestStructAsClass>.FromNative(IntPtr.Add(intPtr, StructAsClassCreate_ReturnValue_Offset), 0, StructAsClassCreate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.USharpPerfTestBase:InvokeMultiDelegateNoDyn")]
	protected unsafe void InvokeMultiDelegateNoDyn(int AttrID, int RealNewValue, int RealOrgValue, int ExpectChangeValue)
	{
		CheckDestroyed();
		if (!InvokeMultiDelegateNoDyn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.USharpPerfTestBase:InvokeMultiDelegateNoDyn");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InvokeMultiDelegateNoDyn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InvokeMultiDelegateNoDyn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, InvokeMultiDelegateNoDyn_AttrID_Offset), 0, InvokeMultiDelegateNoDyn_AttrID_PropertyAddress.Address, AttrID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, InvokeMultiDelegateNoDyn_RealNewValue_Offset), 0, InvokeMultiDelegateNoDyn_RealNewValue_PropertyAddress.Address, RealNewValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, InvokeMultiDelegateNoDyn_RealOrgValue_Offset), 0, InvokeMultiDelegateNoDyn_RealOrgValue_PropertyAddress.Address, RealOrgValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, InvokeMultiDelegateNoDyn_ExpectChangeValue_Offset), 0, InvokeMultiDelegateNoDyn_ExpectChangeValue_PropertyAddress.Address, ExpectChangeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, InvokeMultiDelegateNoDyn_FunctionAddress, intPtr, InvokeMultiDelegateNoDyn_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.USharpPerfTestBase:InvokeMultiDelegate")]
	protected unsafe void InvokeMultiDelegate(int AttrID, int RealNewValue, int RealOrgValue, int ExpectChangeValue)
	{
		CheckDestroyed();
		if (!InvokeMultiDelegate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.USharpPerfTestBase:InvokeMultiDelegate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InvokeMultiDelegate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InvokeMultiDelegate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, InvokeMultiDelegate_AttrID_Offset), 0, InvokeMultiDelegate_AttrID_PropertyAddress.Address, AttrID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, InvokeMultiDelegate_RealNewValue_Offset), 0, InvokeMultiDelegate_RealNewValue_PropertyAddress.Address, RealNewValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, InvokeMultiDelegate_RealOrgValue_Offset), 0, InvokeMultiDelegate_RealOrgValue_PropertyAddress.Address, RealOrgValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, InvokeMultiDelegate_ExpectChangeValue_Offset), 0, InvokeMultiDelegate_ExpectChangeValue_PropertyAddress.Address, ExpectChangeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, InvokeMultiDelegate_FunctionAddress, intPtr, InvokeMultiDelegate_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.USharpPerfTestBase:IntRetTest2")]
	protected unsafe int IntRetTest2(int P1, float P2, bool bP3)
	{
		CheckDestroyed();
		if (!IntRetTest2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.USharpPerfTestBase:IntRetTest2");
			return 0;
		}
		if (IntRetTest2_InstanceFunctionAddress == IntPtr.Zero)
		{
			IntRetTest2_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IntRetTest2");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IntRetTest2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IntRetTest2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, IntRetTest2_P1_Offset), 0, IntRetTest2_P1_PropertyAddress.Address, P1);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, IntRetTest2_P2_Offset), 0, IntRetTest2_P2_PropertyAddress.Address, P2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, IntRetTest2_bP3_Offset), 0, IntRetTest2_bP3_PropertyAddress.Address, bP3);
		NativeReflection.InvokeFunctionOptimized(base.Address, IntRetTest2_InstanceFunctionAddress, intPtr, IntRetTest2_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, IntRetTest2_ReturnValue_Offset), 0, IntRetTest2_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int IntRetTest2_Implementation(int P1, float P2, bool bP3)
	{
		CheckDestroyed();
		if (!IntRetTest2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.USharpPerfTestBase:IntRetTest2");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IntRetTest2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IntRetTest2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, IntRetTest2_P1_Offset), 0, IntRetTest2_P1_PropertyAddress.Address, P1);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, IntRetTest2_P2_Offset), 0, IntRetTest2_P2_PropertyAddress.Address, P2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, IntRetTest2_bP3_Offset), 0, IntRetTest2_bP3_PropertyAddress.Address, bP3);
		NativeReflection.InvokeFunctionOptimized(base.Address, IntRetTest2_FunctionAddress, intPtr, IntRetTest2_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, IntRetTest2_ReturnValue_Offset), 0, IntRetTest2_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 138938368u)]
	[UMetaPath("/Script/b1.USharpPerfTestBase:IntRetTest")]
	protected unsafe int IntRetTest(int P1, float P2, bool bP3, out int Out1)
	{
		CheckDestroyed();
		if (!IntRetTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.USharpPerfTestBase:IntRetTest");
			Out1 = 0;
			return 0;
		}
		if (IntRetTest_InstanceFunctionAddress == IntPtr.Zero)
		{
			IntRetTest_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IntRetTest");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IntRetTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IntRetTest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, IntRetTest_P1_Offset), 0, IntRetTest_P1_PropertyAddress.Address, P1);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, IntRetTest_P2_Offset), 0, IntRetTest_P2_PropertyAddress.Address, P2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, IntRetTest_bP3_Offset), 0, IntRetTest_bP3_PropertyAddress.Address, bP3);
		NativeReflection.InvokeFunctionOptimized(base.Address, IntRetTest_InstanceFunctionAddress, intPtr, IntRetTest_ParamsSize);
		Out1 = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, IntRetTest_Out1_Offset), 0, IntRetTest_Out1_PropertyAddress.Address);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, IntRetTest_ReturnValue_Offset), 0, IntRetTest_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int IntRetTest_Implementation(int P1, float P2, bool bP3, out int Out1)
	{
		CheckDestroyed();
		if (!IntRetTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.USharpPerfTestBase:IntRetTest");
			Out1 = 0;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IntRetTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IntRetTest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, IntRetTest_P1_Offset), 0, IntRetTest_P1_PropertyAddress.Address, P1);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, IntRetTest_P2_Offset), 0, IntRetTest_P2_PropertyAddress.Address, P2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, IntRetTest_bP3_Offset), 0, IntRetTest_bP3_PropertyAddress.Address, bP3);
		NativeReflection.InvokeFunctionOptimized(base.Address, IntRetTest_FunctionAddress, intPtr, IntRetTest_ParamsSize);
		Out1 = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, IntRetTest_Out1_Offset), 0, IntRetTest_Out1_PropertyAddress.Address);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, IntRetTest_ReturnValue_Offset), 0, IntRetTest_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.USharpPerfTestBase:EmptyCallableFuncWithParams2")]
	protected unsafe void EmptyCallableFuncWithParams2(FName P1, string P2, FText P3)
	{
		CheckDestroyed();
		if (!EmptyCallableFuncWithParams2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.USharpPerfTestBase:EmptyCallableFuncWithParams2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EmptyCallableFuncWithParams2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EmptyCallableFuncWithParams2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, EmptyCallableFuncWithParams2_P1_Offset), 0, EmptyCallableFuncWithParams2_P1_PropertyAddress.Address, P1);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, EmptyCallableFuncWithParams2_P2_Offset), 0, EmptyCallableFuncWithParams2_P2_PropertyAddress.Address, P2);
		NativeReflection.InitializeValue_InContainer(EmptyCallableFuncWithParams2_P3_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, EmptyCallableFuncWithParams2_P3_Offset), 0, EmptyCallableFuncWithParams2_P3_PropertyAddress.Address, P3);
		NativeReflection.InvokeFunctionOptimized(base.Address, EmptyCallableFuncWithParams2_FunctionAddress, intPtr, EmptyCallableFuncWithParams2_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EmptyCallableFuncWithParams2_P2_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(EmptyCallableFuncWithParams2_P3_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.USharpPerfTestBase:EmptyCallableFuncWithParams")]
	protected unsafe void EmptyCallableFuncWithParams(int P1, float P2, int P3, bool bP4)
	{
		CheckDestroyed();
		if (!EmptyCallableFuncWithParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.USharpPerfTestBase:EmptyCallableFuncWithParams");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EmptyCallableFuncWithParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EmptyCallableFuncWithParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, EmptyCallableFuncWithParams_P1_Offset), 0, EmptyCallableFuncWithParams_P1_PropertyAddress.Address, P1);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, EmptyCallableFuncWithParams_P2_Offset), 0, EmptyCallableFuncWithParams_P2_PropertyAddress.Address, P2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, EmptyCallableFuncWithParams_P3_Offset), 0, EmptyCallableFuncWithParams_P3_PropertyAddress.Address, P3);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EmptyCallableFuncWithParams_bP4_Offset), 0, EmptyCallableFuncWithParams_bP4_PropertyAddress.Address, bP4);
		NativeReflection.InvokeFunctionOptimized(base.Address, EmptyCallableFuncWithParams_FunctionAddress, intPtr, EmptyCallableFuncWithParams_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.USharpPerfTestBase:EmptyCallableFunc")]
	protected unsafe void EmptyCallableFunc()
	{
		CheckDestroyed();
		if (!EmptyCallableFunc_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.USharpPerfTestBase:EmptyCallableFunc");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EmptyCallableFunc_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EmptyCallableFunc_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EmptyCallableFunc_FunctionAddress, argsSize: EmptyCallableFunc_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.USharpPerfTestBase:BoolRetTest")]
	protected unsafe bool BoolRetTest(int P1, float P2, bool bP3)
	{
		CheckDestroyed();
		if (!BoolRetTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.USharpPerfTestBase:BoolRetTest");
			return false;
		}
		if (BoolRetTest_InstanceFunctionAddress == IntPtr.Zero)
		{
			BoolRetTest_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BoolRetTest");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BoolRetTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BoolRetTest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BoolRetTest_P1_Offset), 0, BoolRetTest_P1_PropertyAddress.Address, P1);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BoolRetTest_P2_Offset), 0, BoolRetTest_P2_PropertyAddress.Address, P2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BoolRetTest_bP3_Offset), 0, BoolRetTest_bP3_PropertyAddress.Address, bP3);
		NativeReflection.InvokeFunctionOptimized(base.Address, BoolRetTest_InstanceFunctionAddress, intPtr, BoolRetTest_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BoolRetTest_ReturnValue_Offset), 0, BoolRetTest_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool BoolRetTest_Implementation(int P1, float P2, bool bP3)
	{
		CheckDestroyed();
		if (!BoolRetTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.USharpPerfTestBase:BoolRetTest");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BoolRetTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BoolRetTest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BoolRetTest_P1_Offset), 0, BoolRetTest_P1_PropertyAddress.Address, P1);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BoolRetTest_P2_Offset), 0, BoolRetTest_P2_PropertyAddress.Address, P2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BoolRetTest_bP3_Offset), 0, BoolRetTest_bP3_PropertyAddress.Address, bP3);
		NativeReflection.InvokeFunctionOptimized(base.Address, BoolRetTest_FunctionAddress, intPtr, BoolRetTest_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BoolRetTest_ReturnValue_Offset), 0, BoolRetTest_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.USharpPerfTestBase:BeginPlayInCS")]
	protected unsafe void BeginPlayInCS()
	{
		CheckDestroyed();
		if (!BeginPlayInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.USharpPerfTestBase:BeginPlayInCS");
			return;
		}
		if (BeginPlayInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			BeginPlayInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BeginPlayInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginPlayInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginPlayInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BeginPlayInCS_InstanceFunctionAddress, argsSize: BeginPlayInCS_ParamsSize);
	}

	protected unsafe virtual void BeginPlayInCS_Implementation()
	{
		CheckDestroyed();
		if (!BeginPlayInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.USharpPerfTestBase:BeginPlayInCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginPlayInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginPlayInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BeginPlayInCS_FunctionAddress, argsSize: BeginPlayInCS_ParamsSize);
	}

	static AUSharpPerfTestBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AUSharpPerfTestBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AUSharpPerfTestBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.USharpPerfTestBase");
		IntProp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IntProp");
		IntProp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IntProp", Classes.FIntProperty);
		FBUE_USharpCallbackPerfTest_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FBUE_USharpCallbackPerfTest");
		FBUE_USharpCallbackPerfTest_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FBUE_USharpCallbackPerfTest", Classes.FMulticastDelegateProperty);
		TickInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickInCS");
		TickInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TickInCS_DeltaTime_PropertyAddress, TickInCS_FunctionAddress, "DeltaTime");
		TickInCS_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(TickInCS_FunctionAddress, "DeltaTime");
		TickInCS_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(TickInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickInCS_IsValid = TickInCS_FunctionAddress != IntPtr.Zero && TickInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.USharpPerfTestBase:TickInCS", TickInCS_IsValid);
		TestFastFuncExport_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TestFastFuncExport");
		TestFastFuncExport_ParamsSize = NativeReflection.GetFunctionParamsSize(TestFastFuncExport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TestFastFuncExport_P1_PropertyAddress, TestFastFuncExport_FunctionAddress, "P1");
		TestFastFuncExport_P1_Offset = NativeReflectionCached.GetPropertyOffset(TestFastFuncExport_FunctionAddress, "P1");
		TestFastFuncExport_P1_IsValid = NativeReflectionCached.ValidatePropertyClass(TestFastFuncExport_FunctionAddress, "P1", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref TestFastFuncExport_P2_PropertyAddress, TestFastFuncExport_FunctionAddress, "P2");
		TestFastFuncExport_P2_Offset = NativeReflectionCached.GetPropertyOffset(TestFastFuncExport_FunctionAddress, "P2");
		TestFastFuncExport_P2_IsValid = NativeReflectionCached.ValidatePropertyClass(TestFastFuncExport_FunctionAddress, "P2", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TestFastFuncExport_P3_PropertyAddress, TestFastFuncExport_FunctionAddress, "P3");
		TestFastFuncExport_P3_Offset = NativeReflectionCached.GetPropertyOffset(TestFastFuncExport_FunctionAddress, "P3");
		TestFastFuncExport_P3_IsValid = NativeReflectionCached.ValidatePropertyClass(TestFastFuncExport_FunctionAddress, "P3", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref TestFastFuncExport_bP4_PropertyAddress, TestFastFuncExport_FunctionAddress, "bP4");
		TestFastFuncExport_bP4_Offset = NativeReflectionCached.GetPropertyOffset(TestFastFuncExport_FunctionAddress, "bP4");
		TestFastFuncExport_bP4_IsValid = NativeReflectionCached.ValidatePropertyClass(TestFastFuncExport_FunctionAddress, "bP4", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TestFastFuncExport_ReturnValue_PropertyAddress, TestFastFuncExport_FunctionAddress, "ReturnValue");
		TestFastFuncExport_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TestFastFuncExport_FunctionAddress, "ReturnValue");
		TestFastFuncExport_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TestFastFuncExport_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		TestFastFuncExport_IsValid = TestFastFuncExport_FunctionAddress != IntPtr.Zero && TestFastFuncExport_P1_IsValid && TestFastFuncExport_P2_IsValid && TestFastFuncExport_P3_IsValid && TestFastFuncExport_bP4_IsValid && TestFastFuncExport_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.USharpPerfTestBase:TestFastFuncExport", TestFastFuncExport_IsValid);
		StructAsClassGetInt_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StructAsClassGetInt");
		StructAsClassGetInt_ParamsSize = NativeReflection.GetFunctionParamsSize(StructAsClassGetInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StructAsClassGetInt_InVal_PropertyAddress, StructAsClassGetInt_FunctionAddress, "InVal");
		StructAsClassGetInt_InVal_Offset = NativeReflectionCached.GetPropertyOffset(StructAsClassGetInt_FunctionAddress, "InVal");
		StructAsClassGetInt_InVal_IsValid = NativeReflectionCached.ValidatePropertyClass(StructAsClassGetInt_FunctionAddress, "InVal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref StructAsClassGetInt_ReturnValue_PropertyAddress, StructAsClassGetInt_FunctionAddress, "ReturnValue");
		StructAsClassGetInt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StructAsClassGetInt_FunctionAddress, "ReturnValue");
		StructAsClassGetInt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StructAsClassGetInt_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		StructAsClassGetInt_IsValid = StructAsClassGetInt_FunctionAddress != IntPtr.Zero && StructAsClassGetInt_InVal_IsValid && StructAsClassGetInt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.USharpPerfTestBase:StructAsClassGetInt", StructAsClassGetInt_IsValid);
		StructAsClassCreate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StructAsClassCreate");
		StructAsClassCreate_ParamsSize = NativeReflection.GetFunctionParamsSize(StructAsClassCreate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StructAsClassCreate_RawValue_PropertyAddress, StructAsClassCreate_FunctionAddress, "RawValue");
		StructAsClassCreate_RawValue_Offset = NativeReflectionCached.GetPropertyOffset(StructAsClassCreate_FunctionAddress, "RawValue");
		StructAsClassCreate_RawValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StructAsClassCreate_FunctionAddress, "RawValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref StructAsClassCreate_ReturnValue_PropertyAddress, StructAsClassCreate_FunctionAddress, "ReturnValue");
		StructAsClassCreate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StructAsClassCreate_FunctionAddress, "ReturnValue");
		StructAsClassCreate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StructAsClassCreate_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		StructAsClassCreate_IsValid = StructAsClassCreate_FunctionAddress != IntPtr.Zero && StructAsClassCreate_RawValue_IsValid && StructAsClassCreate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.USharpPerfTestBase:StructAsClassCreate", StructAsClassCreate_IsValid);
		InvokeMultiDelegateNoDyn_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InvokeMultiDelegateNoDyn");
		InvokeMultiDelegateNoDyn_ParamsSize = NativeReflection.GetFunctionParamsSize(InvokeMultiDelegateNoDyn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InvokeMultiDelegateNoDyn_AttrID_PropertyAddress, InvokeMultiDelegateNoDyn_FunctionAddress, "AttrID");
		InvokeMultiDelegateNoDyn_AttrID_Offset = NativeReflectionCached.GetPropertyOffset(InvokeMultiDelegateNoDyn_FunctionAddress, "AttrID");
		InvokeMultiDelegateNoDyn_AttrID_IsValid = NativeReflectionCached.ValidatePropertyClass(InvokeMultiDelegateNoDyn_FunctionAddress, "AttrID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref InvokeMultiDelegateNoDyn_RealNewValue_PropertyAddress, InvokeMultiDelegateNoDyn_FunctionAddress, "RealNewValue");
		InvokeMultiDelegateNoDyn_RealNewValue_Offset = NativeReflectionCached.GetPropertyOffset(InvokeMultiDelegateNoDyn_FunctionAddress, "RealNewValue");
		InvokeMultiDelegateNoDyn_RealNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InvokeMultiDelegateNoDyn_FunctionAddress, "RealNewValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref InvokeMultiDelegateNoDyn_RealOrgValue_PropertyAddress, InvokeMultiDelegateNoDyn_FunctionAddress, "RealOrgValue");
		InvokeMultiDelegateNoDyn_RealOrgValue_Offset = NativeReflectionCached.GetPropertyOffset(InvokeMultiDelegateNoDyn_FunctionAddress, "RealOrgValue");
		InvokeMultiDelegateNoDyn_RealOrgValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InvokeMultiDelegateNoDyn_FunctionAddress, "RealOrgValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref InvokeMultiDelegateNoDyn_ExpectChangeValue_PropertyAddress, InvokeMultiDelegateNoDyn_FunctionAddress, "ExpectChangeValue");
		InvokeMultiDelegateNoDyn_ExpectChangeValue_Offset = NativeReflectionCached.GetPropertyOffset(InvokeMultiDelegateNoDyn_FunctionAddress, "ExpectChangeValue");
		InvokeMultiDelegateNoDyn_ExpectChangeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InvokeMultiDelegateNoDyn_FunctionAddress, "ExpectChangeValue", Classes.FIntProperty);
		InvokeMultiDelegateNoDyn_IsValid = InvokeMultiDelegateNoDyn_FunctionAddress != IntPtr.Zero && InvokeMultiDelegateNoDyn_AttrID_IsValid && InvokeMultiDelegateNoDyn_RealNewValue_IsValid && InvokeMultiDelegateNoDyn_RealOrgValue_IsValid && InvokeMultiDelegateNoDyn_ExpectChangeValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.USharpPerfTestBase:InvokeMultiDelegateNoDyn", InvokeMultiDelegateNoDyn_IsValid);
		InvokeMultiDelegate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InvokeMultiDelegate");
		InvokeMultiDelegate_ParamsSize = NativeReflection.GetFunctionParamsSize(InvokeMultiDelegate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InvokeMultiDelegate_AttrID_PropertyAddress, InvokeMultiDelegate_FunctionAddress, "AttrID");
		InvokeMultiDelegate_AttrID_Offset = NativeReflectionCached.GetPropertyOffset(InvokeMultiDelegate_FunctionAddress, "AttrID");
		InvokeMultiDelegate_AttrID_IsValid = NativeReflectionCached.ValidatePropertyClass(InvokeMultiDelegate_FunctionAddress, "AttrID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref InvokeMultiDelegate_RealNewValue_PropertyAddress, InvokeMultiDelegate_FunctionAddress, "RealNewValue");
		InvokeMultiDelegate_RealNewValue_Offset = NativeReflectionCached.GetPropertyOffset(InvokeMultiDelegate_FunctionAddress, "RealNewValue");
		InvokeMultiDelegate_RealNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InvokeMultiDelegate_FunctionAddress, "RealNewValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref InvokeMultiDelegate_RealOrgValue_PropertyAddress, InvokeMultiDelegate_FunctionAddress, "RealOrgValue");
		InvokeMultiDelegate_RealOrgValue_Offset = NativeReflectionCached.GetPropertyOffset(InvokeMultiDelegate_FunctionAddress, "RealOrgValue");
		InvokeMultiDelegate_RealOrgValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InvokeMultiDelegate_FunctionAddress, "RealOrgValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref InvokeMultiDelegate_ExpectChangeValue_PropertyAddress, InvokeMultiDelegate_FunctionAddress, "ExpectChangeValue");
		InvokeMultiDelegate_ExpectChangeValue_Offset = NativeReflectionCached.GetPropertyOffset(InvokeMultiDelegate_FunctionAddress, "ExpectChangeValue");
		InvokeMultiDelegate_ExpectChangeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InvokeMultiDelegate_FunctionAddress, "ExpectChangeValue", Classes.FIntProperty);
		InvokeMultiDelegate_IsValid = InvokeMultiDelegate_FunctionAddress != IntPtr.Zero && InvokeMultiDelegate_AttrID_IsValid && InvokeMultiDelegate_RealNewValue_IsValid && InvokeMultiDelegate_RealOrgValue_IsValid && InvokeMultiDelegate_ExpectChangeValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.USharpPerfTestBase:InvokeMultiDelegate", InvokeMultiDelegate_IsValid);
		IntRetTest2_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IntRetTest2");
		IntRetTest2_ParamsSize = NativeReflection.GetFunctionParamsSize(IntRetTest2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IntRetTest2_P1_PropertyAddress, IntRetTest2_FunctionAddress, "P1");
		IntRetTest2_P1_Offset = NativeReflectionCached.GetPropertyOffset(IntRetTest2_FunctionAddress, "P1");
		IntRetTest2_P1_IsValid = NativeReflectionCached.ValidatePropertyClass(IntRetTest2_FunctionAddress, "P1", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IntRetTest2_P2_PropertyAddress, IntRetTest2_FunctionAddress, "P2");
		IntRetTest2_P2_Offset = NativeReflectionCached.GetPropertyOffset(IntRetTest2_FunctionAddress, "P2");
		IntRetTest2_P2_IsValid = NativeReflectionCached.ValidatePropertyClass(IntRetTest2_FunctionAddress, "P2", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IntRetTest2_bP3_PropertyAddress, IntRetTest2_FunctionAddress, "bP3");
		IntRetTest2_bP3_Offset = NativeReflectionCached.GetPropertyOffset(IntRetTest2_FunctionAddress, "bP3");
		IntRetTest2_bP3_IsValid = NativeReflectionCached.ValidatePropertyClass(IntRetTest2_FunctionAddress, "bP3", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IntRetTest2_ReturnValue_PropertyAddress, IntRetTest2_FunctionAddress, "ReturnValue");
		IntRetTest2_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IntRetTest2_FunctionAddress, "ReturnValue");
		IntRetTest2_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IntRetTest2_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		IntRetTest2_IsValid = IntRetTest2_FunctionAddress != IntPtr.Zero && IntRetTest2_P1_IsValid && IntRetTest2_P2_IsValid && IntRetTest2_bP3_IsValid && IntRetTest2_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.USharpPerfTestBase:IntRetTest2", IntRetTest2_IsValid);
		IntRetTest_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IntRetTest");
		IntRetTest_ParamsSize = NativeReflection.GetFunctionParamsSize(IntRetTest_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IntRetTest_P1_PropertyAddress, IntRetTest_FunctionAddress, "P1");
		IntRetTest_P1_Offset = NativeReflectionCached.GetPropertyOffset(IntRetTest_FunctionAddress, "P1");
		IntRetTest_P1_IsValid = NativeReflectionCached.ValidatePropertyClass(IntRetTest_FunctionAddress, "P1", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IntRetTest_P2_PropertyAddress, IntRetTest_FunctionAddress, "P2");
		IntRetTest_P2_Offset = NativeReflectionCached.GetPropertyOffset(IntRetTest_FunctionAddress, "P2");
		IntRetTest_P2_IsValid = NativeReflectionCached.ValidatePropertyClass(IntRetTest_FunctionAddress, "P2", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IntRetTest_bP3_PropertyAddress, IntRetTest_FunctionAddress, "bP3");
		IntRetTest_bP3_Offset = NativeReflectionCached.GetPropertyOffset(IntRetTest_FunctionAddress, "bP3");
		IntRetTest_bP3_IsValid = NativeReflectionCached.ValidatePropertyClass(IntRetTest_FunctionAddress, "bP3", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IntRetTest_Out1_PropertyAddress, IntRetTest_FunctionAddress, "Out1");
		IntRetTest_Out1_Offset = NativeReflectionCached.GetPropertyOffset(IntRetTest_FunctionAddress, "Out1");
		IntRetTest_Out1_IsValid = NativeReflectionCached.ValidatePropertyClass(IntRetTest_FunctionAddress, "Out1", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IntRetTest_ReturnValue_PropertyAddress, IntRetTest_FunctionAddress, "ReturnValue");
		IntRetTest_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IntRetTest_FunctionAddress, "ReturnValue");
		IntRetTest_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IntRetTest_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		IntRetTest_IsValid = IntRetTest_FunctionAddress != IntPtr.Zero && IntRetTest_P1_IsValid && IntRetTest_P2_IsValid && IntRetTest_bP3_IsValid && IntRetTest_Out1_IsValid && IntRetTest_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.USharpPerfTestBase:IntRetTest", IntRetTest_IsValid);
		EmptyCallableFuncWithParams2_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EmptyCallableFuncWithParams2");
		EmptyCallableFuncWithParams2_ParamsSize = NativeReflection.GetFunctionParamsSize(EmptyCallableFuncWithParams2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EmptyCallableFuncWithParams2_P1_PropertyAddress, EmptyCallableFuncWithParams2_FunctionAddress, "P1");
		EmptyCallableFuncWithParams2_P1_Offset = NativeReflectionCached.GetPropertyOffset(EmptyCallableFuncWithParams2_FunctionAddress, "P1");
		EmptyCallableFuncWithParams2_P1_IsValid = NativeReflectionCached.ValidatePropertyClass(EmptyCallableFuncWithParams2_FunctionAddress, "P1", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref EmptyCallableFuncWithParams2_P2_PropertyAddress, EmptyCallableFuncWithParams2_FunctionAddress, "P2");
		EmptyCallableFuncWithParams2_P2_Offset = NativeReflectionCached.GetPropertyOffset(EmptyCallableFuncWithParams2_FunctionAddress, "P2");
		EmptyCallableFuncWithParams2_P2_IsValid = NativeReflectionCached.ValidatePropertyClass(EmptyCallableFuncWithParams2_FunctionAddress, "P2", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref EmptyCallableFuncWithParams2_P3_PropertyAddress, EmptyCallableFuncWithParams2_FunctionAddress, "P3");
		EmptyCallableFuncWithParams2_P3_Offset = NativeReflectionCached.GetPropertyOffset(EmptyCallableFuncWithParams2_FunctionAddress, "P3");
		EmptyCallableFuncWithParams2_P3_IsValid = NativeReflectionCached.ValidatePropertyClass(EmptyCallableFuncWithParams2_FunctionAddress, "P3", Classes.FTextProperty);
		EmptyCallableFuncWithParams2_IsValid = EmptyCallableFuncWithParams2_FunctionAddress != IntPtr.Zero && EmptyCallableFuncWithParams2_P1_IsValid && EmptyCallableFuncWithParams2_P2_IsValid && EmptyCallableFuncWithParams2_P3_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.USharpPerfTestBase:EmptyCallableFuncWithParams2", EmptyCallableFuncWithParams2_IsValid);
		EmptyCallableFuncWithParams_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EmptyCallableFuncWithParams");
		EmptyCallableFuncWithParams_ParamsSize = NativeReflection.GetFunctionParamsSize(EmptyCallableFuncWithParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EmptyCallableFuncWithParams_P1_PropertyAddress, EmptyCallableFuncWithParams_FunctionAddress, "P1");
		EmptyCallableFuncWithParams_P1_Offset = NativeReflectionCached.GetPropertyOffset(EmptyCallableFuncWithParams_FunctionAddress, "P1");
		EmptyCallableFuncWithParams_P1_IsValid = NativeReflectionCached.ValidatePropertyClass(EmptyCallableFuncWithParams_FunctionAddress, "P1", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref EmptyCallableFuncWithParams_P2_PropertyAddress, EmptyCallableFuncWithParams_FunctionAddress, "P2");
		EmptyCallableFuncWithParams_P2_Offset = NativeReflectionCached.GetPropertyOffset(EmptyCallableFuncWithParams_FunctionAddress, "P2");
		EmptyCallableFuncWithParams_P2_IsValid = NativeReflectionCached.ValidatePropertyClass(EmptyCallableFuncWithParams_FunctionAddress, "P2", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EmptyCallableFuncWithParams_P3_PropertyAddress, EmptyCallableFuncWithParams_FunctionAddress, "P3");
		EmptyCallableFuncWithParams_P3_Offset = NativeReflectionCached.GetPropertyOffset(EmptyCallableFuncWithParams_FunctionAddress, "P3");
		EmptyCallableFuncWithParams_P3_IsValid = NativeReflectionCached.ValidatePropertyClass(EmptyCallableFuncWithParams_FunctionAddress, "P3", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref EmptyCallableFuncWithParams_bP4_PropertyAddress, EmptyCallableFuncWithParams_FunctionAddress, "bP4");
		EmptyCallableFuncWithParams_bP4_Offset = NativeReflectionCached.GetPropertyOffset(EmptyCallableFuncWithParams_FunctionAddress, "bP4");
		EmptyCallableFuncWithParams_bP4_IsValid = NativeReflectionCached.ValidatePropertyClass(EmptyCallableFuncWithParams_FunctionAddress, "bP4", Classes.FBoolProperty);
		EmptyCallableFuncWithParams_IsValid = EmptyCallableFuncWithParams_FunctionAddress != IntPtr.Zero && EmptyCallableFuncWithParams_P1_IsValid && EmptyCallableFuncWithParams_P2_IsValid && EmptyCallableFuncWithParams_P3_IsValid && EmptyCallableFuncWithParams_bP4_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.USharpPerfTestBase:EmptyCallableFuncWithParams", EmptyCallableFuncWithParams_IsValid);
		EmptyCallableFunc_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EmptyCallableFunc");
		EmptyCallableFunc_ParamsSize = NativeReflection.GetFunctionParamsSize(EmptyCallableFunc_FunctionAddress);
		EmptyCallableFunc_IsValid = EmptyCallableFunc_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.USharpPerfTestBase:EmptyCallableFunc", EmptyCallableFunc_IsValid);
		BoolRetTest_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BoolRetTest");
		BoolRetTest_ParamsSize = NativeReflection.GetFunctionParamsSize(BoolRetTest_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BoolRetTest_P1_PropertyAddress, BoolRetTest_FunctionAddress, "P1");
		BoolRetTest_P1_Offset = NativeReflectionCached.GetPropertyOffset(BoolRetTest_FunctionAddress, "P1");
		BoolRetTest_P1_IsValid = NativeReflectionCached.ValidatePropertyClass(BoolRetTest_FunctionAddress, "P1", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BoolRetTest_P2_PropertyAddress, BoolRetTest_FunctionAddress, "P2");
		BoolRetTest_P2_Offset = NativeReflectionCached.GetPropertyOffset(BoolRetTest_FunctionAddress, "P2");
		BoolRetTest_P2_IsValid = NativeReflectionCached.ValidatePropertyClass(BoolRetTest_FunctionAddress, "P2", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BoolRetTest_bP3_PropertyAddress, BoolRetTest_FunctionAddress, "bP3");
		BoolRetTest_bP3_Offset = NativeReflectionCached.GetPropertyOffset(BoolRetTest_FunctionAddress, "bP3");
		BoolRetTest_bP3_IsValid = NativeReflectionCached.ValidatePropertyClass(BoolRetTest_FunctionAddress, "bP3", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BoolRetTest_ReturnValue_PropertyAddress, BoolRetTest_FunctionAddress, "ReturnValue");
		BoolRetTest_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BoolRetTest_FunctionAddress, "ReturnValue");
		BoolRetTest_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BoolRetTest_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BoolRetTest_IsValid = BoolRetTest_FunctionAddress != IntPtr.Zero && BoolRetTest_P1_IsValid && BoolRetTest_P2_IsValid && BoolRetTest_bP3_IsValid && BoolRetTest_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.USharpPerfTestBase:BoolRetTest", BoolRetTest_IsValid);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.USharpPerfTestBase:BeginPlayInCS", BeginPlayInCS_IsValid);
	}
}
