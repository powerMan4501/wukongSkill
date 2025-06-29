using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Util.PerfTest;

[UClass]
[USharpPath("/Script/b1-Managed.IL2CPPUnitTest")]
public class IL2CPPUnitTest : AUSharpPerfTestBase
{
	private List<IL2CPPUnitTestStructOuter> PackedLists = new List<IL2CPPUnitTestStructOuter>();

	private bool sss = true;

	private static bool CSIntProperty_IsValid;

	private static int CSIntProperty_Offset;

	private static bool StructArrayTest_IsValid;

	private static int StructArrayTest_Offset;

	private static bool TestArrEdit_IsValid;

	private static int TestArrEdit_Offset;

	private static FFieldAddress TestArrEdit_PropertyAddress;

	private TArrayReadWriteMarshaler<IL2CPPUnitTestStruct1> TestArrEdit_Marshaler;

	private static bool CallInBP_IsValid;

	private static IntPtr CallInBP_FunctionAddress;

	private static int CallInBP_ParamsSize;

	private static bool CallInBP_CheckIt_IsValid;

	private static int CallInBP_CheckIt_Offset;

	private static FFieldAddress CallInBP_CheckIt_PropertyAddress;

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

	private static bool TestPassComplexStruct_IsValid;

	private static IntPtr TestPassComplexStruct_FunctionAddress;

	private static int TestPassComplexStruct_ParamsSize;

	private static bool TestPassComplexStruct_OuterStruct_IsValid;

	private static int TestPassComplexStruct_OuterStruct_Offset;

	private static FFieldAddress TestPassComplexStruct_OuterStruct_PropertyAddress;

	private static bool TickInCS_IsValid;

	private static IntPtr TickInCS_FunctionAddress;

	private static int TickInCS_ParamsSize;

	private static bool TickInCS_DeltaTime_IsValid;

	private static int TickInCS_DeltaTime_Offset;

	private static bool IntRetTest_IsValid;

	private static IntPtr IntRetTest_FunctionAddress;

	private static int IntRetTest_ParamsSize;

	private static bool IntRetTest_P1_IsValid;

	private static int IntRetTest_P1_Offset;

	private static bool IntRetTest_P2_IsValid;

	private static int IntRetTest_P2_Offset;

	private static bool IntRetTest_bP3_IsValid;

	private static int IntRetTest_bP3_Offset;

	private static FFieldAddress IntRetTest_bP3_PropertyAddress;

	private static bool IntRetTest_Out1_IsValid;

	private static int IntRetTest_Out1_Offset;

	private static bool IntRetTest_ReturnValue_IsValid;

	private static int IntRetTest_ReturnValue_Offset;

	private static bool BoolRetTest_IsValid;

	private static IntPtr BoolRetTest_FunctionAddress;

	private static int BoolRetTest_ParamsSize;

	private static bool BoolRetTest_P1_IsValid;

	private static int BoolRetTest_P1_Offset;

	private static bool BoolRetTest_P2_IsValid;

	private static int BoolRetTest_P2_Offset;

	private static bool BoolRetTest_bP3_IsValid;

	private static int BoolRetTest_bP3_Offset;

	private static FFieldAddress BoolRetTest_bP3_PropertyAddress;

	private static bool BoolRetTest_ReturnValue_IsValid;

	private static int BoolRetTest_ReturnValue_Offset;

	private static FFieldAddress BoolRetTest_ReturnValue_PropertyAddress;

	private static bool IntRetTest2_IsValid;

	private static IntPtr IntRetTest2_FunctionAddress;

	private static int IntRetTest2_ParamsSize;

	private static bool IntRetTest2_P1_IsValid;

	private static int IntRetTest2_P1_Offset;

	private static bool IntRetTest2_P2_IsValid;

	private static int IntRetTest2_P2_Offset;

	private static bool IntRetTest2_bP3_IsValid;

	private static int IntRetTest2_bP3_Offset;

	private static FFieldAddress IntRetTest2_bP3_PropertyAddress;

	private static bool IntRetTest2_ReturnValue_IsValid;

	private static int IntRetTest2_ReturnValue_Offset;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTest:CSIntProperty")]
	public int CSIntProperty
	{
		get
		{
			CheckDestroyed();
			if (!CSIntProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.IL2CPPUnitTest:CSIntProperty");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CSIntProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CSIntProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.IL2CPPUnitTest:CSIntProperty");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CSIntProperty_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTest:StructArrayTest")]
	public IL2CPPUnitTestStructOuter StructArrayTest
	{
		get
		{
			CheckDestroyed();
			if (!StructArrayTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.IL2CPPUnitTest:StructArrayTest");
				return default(IL2CPPUnitTestStructOuter);
			}
			return IL2CPPUnitTestStructOuter.FromNative(IntPtr.Add(base.Address, StructArrayTest_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StructArrayTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.IL2CPPUnitTest:StructArrayTest");
			}
			else
			{
				IL2CPPUnitTestStructOuter.ToNative(IntPtr.Add(base.Address, StructArrayTest_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTest:TestArrEdit")]
	public TArrayReadWrite<IL2CPPUnitTestStruct1> TestArrEdit
	{
		get
		{
			CheckDestroyed();
			if (!TestArrEdit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.IL2CPPUnitTest:TestArrEdit");
				return null;
			}
			if (TestArrEdit_Marshaler == null)
			{
				TestArrEdit_Marshaler = new TArrayReadWriteMarshaler<IL2CPPUnitTestStruct1>(1, TestArrEdit_PropertyAddress, CachedMarshalingDelegates<IL2CPPUnitTestStruct1, IL2CPPUnitTestStruct1>.FromNative, CachedMarshalingDelegates<IL2CPPUnitTestStruct1, IL2CPPUnitTestStruct1>.ToNative);
			}
			return TestArrEdit_Marshaler.FromNative(IntPtr.Add(base.Address, TestArrEdit_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.IL2CPPUnitTest:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		base.FBUE_USharpCallbackPerfTest.Bind(DelegateCB);
		base.FBUE_USharpCallbackPerfTest.Invoke(3, 4, 5, 6);
	}

	[USharpPath("/Script/b1-Managed.IL2CPPUnitTest:BoolRetTest")]
	protected override bool BoolRetTest_Implementation(int P1, float P2, bool bP3)
	{
		return bP3;
	}

	[USharpPath("/Script/b1-Managed.IL2CPPUnitTest:IntRetTest")]
	protected override int IntRetTest_Implementation(int P1, float P2, bool bP3, out int Out1)
	{
		Out1 = P1;
		return P1;
	}

	[USharpPath("/Script/b1-Managed.IL2CPPUnitTest:IntRetTest2")]
	protected override int IntRetTest2_Implementation(int P1, float P2, bool bP3)
	{
		return P1;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTest:DelegateCB")]
	public void DelegateCB(int P1, int P2, int P3, int P4)
	{
		USystemLibrary.PrintString(this, "del" + P1 + CSIntProperty, bPrintToScreen: true, bPrintToLog: true, FLinearColor.White, 2f, FName.None);
		if (TestArrEdit.Count <= 0)
		{
			return;
		}
		foreach (IL2CPPUnitTestStruct1 item in TestArrEdit)
		{
			int cSIntProperty = item.CSIntProperty2;
			USystemLibrary.PrintString(this, "tmap" + cSIntProperty, bPrintToScreen: true, bPrintToLog: true, FLinearColor.White, 2f, FName.None);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTest:CallInBP")]
	public void CallInBP(string CheckIt)
	{
		USystemLibrary.PrintString(this, "CallInBP:" + CheckIt, bPrintToScreen: true, bPrintToLog: true, FLinearColor.White, 2f, FName.None);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTest:TestPassComplexStruct")]
	public void TestPassComplexStruct(IL2CPPUnitTestStructOuter OuterStruct)
	{
		if (OuterStruct.ItemStructs.Count > 0 && OuterStruct.ItemStructs[0].ItemInts.Count > 0)
		{
			USystemLibrary.PrintString(this, "usharp struct array test:" + OuterStruct.ItemStructs[0].ItemInts[0].ToString() + OuterStruct.ItemStructs[0].InnerStruct[0].GameTag.TagName.ToString(), bPrintToScreen: true, bPrintToLog: true, FLinearColor.White, 2f, FName.None);
			USystemLibrary.PrintString(this, "usharp struct animseq test:" + ((OuterStruct.Anim != null) ? OuterStruct.Anim.GetName() : "null"), bPrintToScreen: true, bPrintToLog: true, FLinearColor.White, 2f, FName.None);
		}
		PackedLists.Add(OuterStruct);
		USystemLibrary.PrintString(this, "usharp struct add animseq list" + PackedLists[0].Anim.GetName(), bPrintToScreen: true, bPrintToLog: true, FLinearColor.White, 2f, FName.None);
	}

	[USharpPath("/Script/b1-Managed.IL2CPPUnitTest:TickInCS")]
	protected override void TickInCS_Implementation(float DeltaTime)
	{
		if (!sss)
		{
			GC.Collect();
			USystemLibrary.PrintString(this, "usharp haha" + CSIntProperty, bPrintToScreen: true, bPrintToLog: true, FLinearColor.White, 2f, FName.None);
			InvokeMultiDelegateNoDyn(1, 2, 3, 4);
			InvokeMultiDelegate(1, 2, 3, 4);
			UObject.NewObject<ACharacter>(null);
			TestPassComplexStruct(StructArrayTest);
			FUSharpTestStructAsClass inVal = StructAsClassCreate(443);
			USystemLibrary.PrintString(this, "usharp struct as class:" + StructAsClassGetInt(inVal), bPrintToScreen: true, bPrintToLog: true, FLinearColor.White, 2f, FName.None);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.IL2CPPUnitTest:CallInBP")]
	private static void CallInBP__Invoker(IntPtr buffer, IntPtr obj)
	{
		IL2CPPUnitTest iL2CPPUnitTest = GCHelper.Find<IL2CPPUnitTest>(obj);
		string checkIt = FStringMarshaler.FromNative(IntPtr.Add(buffer, CallInBP_CheckIt_Offset));
		iL2CPPUnitTest.CallInBP(checkIt);
	}

	[UFunctionInvoker("/Script/b1-Managed.IL2CPPUnitTest:DelegateCB")]
	private static void DelegateCB__Invoker(IntPtr buffer, IntPtr obj)
	{
		IL2CPPUnitTest iL2CPPUnitTest = GCHelper.Find<IL2CPPUnitTest>(obj);
		int p = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, DelegateCB_P1_Offset));
		int p2 = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, DelegateCB_P2_Offset));
		int p3 = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, DelegateCB_P3_Offset));
		int p4 = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, DelegateCB_P4_Offset));
		iL2CPPUnitTest.DelegateCB(p, p2, p3, p4);
	}

	[UFunctionInvoker("/Script/b1-Managed.IL2CPPUnitTest:TestPassComplexStruct")]
	private static void TestPassComplexStruct__Invoker(IntPtr buffer, IntPtr obj)
	{
		IL2CPPUnitTest iL2CPPUnitTest = GCHelper.Find<IL2CPPUnitTest>(obj);
		IL2CPPUnitTestStructOuter outerStruct = IL2CPPUnitTestStructOuter.FromNative(IntPtr.Add(buffer, TestPassComplexStruct_OuterStruct_Offset));
		iL2CPPUnitTest.TestPassComplexStruct(outerStruct);
	}

	[UFunctionInvoker("/Script/b1-Managed.IL2CPPUnitTest:TickInCS")]
	private static void TickInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		IL2CPPUnitTest iL2CPPUnitTest = GCHelper.Find<IL2CPPUnitTest>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickInCS_DeltaTime_Offset));
		iL2CPPUnitTest.TickInCS_Implementation(deltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.IL2CPPUnitTest:IntRetTest")]
	private static void IntRetTest__Invoker(IntPtr buffer, IntPtr obj)
	{
		IL2CPPUnitTest iL2CPPUnitTest = GCHelper.Find<IL2CPPUnitTest>(obj);
		int p = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, IntRetTest_P1_Offset));
		float p2 = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, IntRetTest_P2_Offset));
		bool bP = BoolMarshaler.FromNative(IntPtr.Add(buffer, IntRetTest_bP3_Offset), 0, IntRetTest_bP3_PropertyAddress.Address);
		int Out;
		int value = iL2CPPUnitTest.IntRetTest_Implementation(p, p2, bP, out Out);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, IntRetTest_ReturnValue_Offset), value);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, IntRetTest_Out1_Offset), Out);
	}

	[UFunctionInvoker("/Script/b1-Managed.IL2CPPUnitTest:BoolRetTest")]
	private static void BoolRetTest__Invoker(IntPtr buffer, IntPtr obj)
	{
		IL2CPPUnitTest iL2CPPUnitTest = GCHelper.Find<IL2CPPUnitTest>(obj);
		int p = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BoolRetTest_P1_Offset));
		float p2 = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BoolRetTest_P2_Offset));
		bool bP = BoolMarshaler.FromNative(IntPtr.Add(buffer, BoolRetTest_bP3_Offset), 0, BoolRetTest_bP3_PropertyAddress.Address);
		bool value = iL2CPPUnitTest.BoolRetTest_Implementation(p, p2, bP);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, BoolRetTest_ReturnValue_Offset), 0, BoolRetTest_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.IL2CPPUnitTest:IntRetTest2")]
	private static void IntRetTest2__Invoker(IntPtr buffer, IntPtr obj)
	{
		IL2CPPUnitTest iL2CPPUnitTest = GCHelper.Find<IL2CPPUnitTest>(obj);
		int p = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, IntRetTest2_P1_Offset));
		float p2 = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, IntRetTest2_P2_Offset));
		bool bP = BoolMarshaler.FromNative(IntPtr.Add(buffer, IntRetTest2_bP3_Offset), 0, IntRetTest2_bP3_PropertyAddress.Address);
		int value = iL2CPPUnitTest.IntRetTest2_Implementation(p, p2, bP);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, IntRetTest2_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.IL2CPPUnitTest:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		IL2CPPUnitTest iL2CPPUnitTest = GCHelper.Find<IL2CPPUnitTest>(obj);
		iL2CPPUnitTest.BeginPlayInCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.IL2CPPUnitTest");
		CSIntProperty_Offset = NativeReflection.GetPropertyOffset(intPtr, "CSIntProperty");
		CSIntProperty_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CSIntProperty", Classes.FIntProperty);
		StructArrayTest_Offset = NativeReflection.GetPropertyOffset(intPtr, "StructArrayTest");
		StructArrayTest_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StructArrayTest", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref TestArrEdit_PropertyAddress, intPtr, "TestArrEdit");
		TestArrEdit_Offset = NativeReflection.GetPropertyOffset(intPtr, "TestArrEdit");
		TestArrEdit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TestArrEdit", Classes.FArrayProperty);
		CallInBP_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CallInBP");
		CallInBP_ParamsSize = NativeReflection.GetFunctionParamsSize(CallInBP_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CallInBP_CheckIt_PropertyAddress, CallInBP_FunctionAddress, "CheckIt");
		CallInBP_CheckIt_Offset = NativeReflection.GetPropertyOffset(CallInBP_FunctionAddress, "CheckIt");
		CallInBP_CheckIt_IsValid = NativeReflection.ValidatePropertyClass(CallInBP_FunctionAddress, "CheckIt", Classes.FStrProperty);
		CallInBP_IsValid = CallInBP_FunctionAddress != IntPtr.Zero && CallInBP_CheckIt_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.IL2CPPUnitTest:CallInBP", CallInBP_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.IL2CPPUnitTest:DelegateCB", DelegateCB_IsValid);
		TestPassComplexStruct_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TestPassComplexStruct");
		TestPassComplexStruct_ParamsSize = NativeReflection.GetFunctionParamsSize(TestPassComplexStruct_FunctionAddress);
		NativeReflection.GetPropertyRef(ref TestPassComplexStruct_OuterStruct_PropertyAddress, TestPassComplexStruct_FunctionAddress, "OuterStruct");
		TestPassComplexStruct_OuterStruct_Offset = NativeReflection.GetPropertyOffset(TestPassComplexStruct_FunctionAddress, "OuterStruct");
		TestPassComplexStruct_OuterStruct_IsValid = NativeReflection.ValidatePropertyClass(TestPassComplexStruct_FunctionAddress, "OuterStruct", Classes.FStructProperty);
		TestPassComplexStruct_IsValid = TestPassComplexStruct_FunctionAddress != IntPtr.Zero && TestPassComplexStruct_OuterStruct_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.IL2CPPUnitTest:TestPassComplexStruct", TestPassComplexStruct_IsValid);
		TickInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickInCS");
		TickInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickInCS_FunctionAddress);
		TickInCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickInCS_FunctionAddress, "DeltaTime");
		TickInCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickInCS_IsValid = TickInCS_FunctionAddress != IntPtr.Zero && TickInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.IL2CPPUnitTest:TickInCS", TickInCS_IsValid);
		IntRetTest_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IntRetTest");
		IntRetTest_ParamsSize = NativeReflection.GetFunctionParamsSize(IntRetTest_FunctionAddress);
		IntRetTest_P1_Offset = NativeReflection.GetPropertyOffset(IntRetTest_FunctionAddress, "P1");
		IntRetTest_P1_IsValid = NativeReflection.ValidatePropertyClass(IntRetTest_FunctionAddress, "P1", Classes.FIntProperty);
		IntRetTest_P2_Offset = NativeReflection.GetPropertyOffset(IntRetTest_FunctionAddress, "P2");
		IntRetTest_P2_IsValid = NativeReflection.ValidatePropertyClass(IntRetTest_FunctionAddress, "P2", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IntRetTest_bP3_PropertyAddress, IntRetTest_FunctionAddress, "bP3");
		IntRetTest_bP3_Offset = NativeReflection.GetPropertyOffset(IntRetTest_FunctionAddress, "bP3");
		IntRetTest_bP3_IsValid = NativeReflection.ValidatePropertyClass(IntRetTest_FunctionAddress, "bP3", Classes.FBoolProperty);
		IntRetTest_Out1_Offset = NativeReflection.GetPropertyOffset(IntRetTest_FunctionAddress, "Out1");
		IntRetTest_Out1_IsValid = NativeReflection.ValidatePropertyClass(IntRetTest_FunctionAddress, "Out1", Classes.FIntProperty);
		IntRetTest_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IntRetTest_FunctionAddress, "ReturnValue");
		IntRetTest_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IntRetTest_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		IntRetTest_IsValid = IntRetTest_FunctionAddress != IntPtr.Zero && IntRetTest_P1_IsValid && IntRetTest_P2_IsValid && IntRetTest_bP3_IsValid && IntRetTest_Out1_IsValid && IntRetTest_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.IL2CPPUnitTest:IntRetTest", IntRetTest_IsValid);
		BoolRetTest_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BoolRetTest");
		BoolRetTest_ParamsSize = NativeReflection.GetFunctionParamsSize(BoolRetTest_FunctionAddress);
		BoolRetTest_P1_Offset = NativeReflection.GetPropertyOffset(BoolRetTest_FunctionAddress, "P1");
		BoolRetTest_P1_IsValid = NativeReflection.ValidatePropertyClass(BoolRetTest_FunctionAddress, "P1", Classes.FIntProperty);
		BoolRetTest_P2_Offset = NativeReflection.GetPropertyOffset(BoolRetTest_FunctionAddress, "P2");
		BoolRetTest_P2_IsValid = NativeReflection.ValidatePropertyClass(BoolRetTest_FunctionAddress, "P2", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref BoolRetTest_bP3_PropertyAddress, BoolRetTest_FunctionAddress, "bP3");
		BoolRetTest_bP3_Offset = NativeReflection.GetPropertyOffset(BoolRetTest_FunctionAddress, "bP3");
		BoolRetTest_bP3_IsValid = NativeReflection.ValidatePropertyClass(BoolRetTest_FunctionAddress, "bP3", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BoolRetTest_ReturnValue_PropertyAddress, BoolRetTest_FunctionAddress, "ReturnValue");
		BoolRetTest_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BoolRetTest_FunctionAddress, "ReturnValue");
		BoolRetTest_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BoolRetTest_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BoolRetTest_IsValid = BoolRetTest_FunctionAddress != IntPtr.Zero && BoolRetTest_P1_IsValid && BoolRetTest_P2_IsValid && BoolRetTest_bP3_IsValid && BoolRetTest_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.IL2CPPUnitTest:BoolRetTest", BoolRetTest_IsValid);
		IntRetTest2_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IntRetTest2");
		IntRetTest2_ParamsSize = NativeReflection.GetFunctionParamsSize(IntRetTest2_FunctionAddress);
		IntRetTest2_P1_Offset = NativeReflection.GetPropertyOffset(IntRetTest2_FunctionAddress, "P1");
		IntRetTest2_P1_IsValid = NativeReflection.ValidatePropertyClass(IntRetTest2_FunctionAddress, "P1", Classes.FIntProperty);
		IntRetTest2_P2_Offset = NativeReflection.GetPropertyOffset(IntRetTest2_FunctionAddress, "P2");
		IntRetTest2_P2_IsValid = NativeReflection.ValidatePropertyClass(IntRetTest2_FunctionAddress, "P2", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IntRetTest2_bP3_PropertyAddress, IntRetTest2_FunctionAddress, "bP3");
		IntRetTest2_bP3_Offset = NativeReflection.GetPropertyOffset(IntRetTest2_FunctionAddress, "bP3");
		IntRetTest2_bP3_IsValid = NativeReflection.ValidatePropertyClass(IntRetTest2_FunctionAddress, "bP3", Classes.FBoolProperty);
		IntRetTest2_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IntRetTest2_FunctionAddress, "ReturnValue");
		IntRetTest2_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IntRetTest2_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		IntRetTest2_IsValid = IntRetTest2_FunctionAddress != IntPtr.Zero && IntRetTest2_P1_IsValid && IntRetTest2_P2_IsValid && IntRetTest2_bP3_IsValid && IntRetTest2_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.IL2CPPUnitTest:IntRetTest2", IntRetTest2_IsValid);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.IL2CPPUnitTest:BeginPlayInCS", BeginPlayInCS_IsValid);
	}

	static IL2CPPUnitTest()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(IL2CPPUnitTest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IL2CPPUnitTest));
	}
}
