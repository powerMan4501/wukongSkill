using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UClass(Flags = (ClassFlags)818413728uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.FunctionalTestingManager", "FunctionalTesting", UnrealModuleType.Engine)]
public class UFunctionalTestingManager : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool OnSetupTests_IsValid;

	private static int OnSetupTests_Offset;

	private FFunctionalTestEventSignature OnSetupTests_DelegateCached;

	private static bool OnTestsComplete_IsValid;

	private static int OnTestsComplete_Offset;

	private FFunctionalTestEventSignature OnTestsComplete_DelegateCached;

	private static bool OnTestsBegin_IsValid;

	private static int OnTestsBegin_Offset;

	private FFunctionalTestEventSignature OnTestsBegin_DelegateCached;

	private static bool RunAllFunctionalTests_IsValid;

	private static IntPtr RunAllFunctionalTests_FunctionAddress;

	private static int RunAllFunctionalTests_ParamsSize;

	private static bool RunAllFunctionalTests_WorldContextObject_IsValid;

	private static FFieldAddress RunAllFunctionalTests_WorldContextObject_PropertyAddress;

	private static int RunAllFunctionalTests_WorldContextObject_Offset;

	private static bool RunAllFunctionalTests_bNewLog_IsValid;

	private static FFieldAddress RunAllFunctionalTests_bNewLog_PropertyAddress;

	private static int RunAllFunctionalTests_bNewLog_Offset;

	private static bool RunAllFunctionalTests_bRunLooped_IsValid;

	private static FFieldAddress RunAllFunctionalTests_bRunLooped_PropertyAddress;

	private static int RunAllFunctionalTests_bRunLooped_Offset;

	private static bool RunAllFunctionalTests_FailedTestsReproString_IsValid;

	private static FFieldAddress RunAllFunctionalTests_FailedTestsReproString_PropertyAddress;

	private static int RunAllFunctionalTests_FailedTestsReproString_Offset;

	private static bool RunAllFunctionalTests_ReturnValue_IsValid;

	private static FFieldAddress RunAllFunctionalTests_ReturnValue_PropertyAddress;

	private static int RunAllFunctionalTests_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTestingManager:OnSetupTests")]
	public FFunctionalTestEventSignature OnSetupTests
	{
		get
		{
			CheckDestroyed();
			if (!OnSetupTests_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTestingManager:OnSetupTests");
				return new FFunctionalTestEventSignature();
			}
			if (OnSetupTests_DelegateCached == null)
			{
				OnSetupTests_DelegateCached = new FFunctionalTestEventSignature();
				OnSetupTests_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnSetupTests_Offset));
			}
			return OnSetupTests_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTestingManager:OnTestsComplete")]
	public FFunctionalTestEventSignature OnTestsComplete
	{
		get
		{
			CheckDestroyed();
			if (!OnTestsComplete_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTestingManager:OnTestsComplete");
				return new FFunctionalTestEventSignature();
			}
			if (OnTestsComplete_DelegateCached == null)
			{
				OnTestsComplete_DelegateCached = new FFunctionalTestEventSignature();
				OnTestsComplete_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTestsComplete_Offset));
			}
			return OnTestsComplete_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTestingManager:OnTestsBegin")]
	public FFunctionalTestEventSignature OnTestsBegin
	{
		get
		{
			CheckDestroyed();
			if (!OnTestsBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTestingManager:OnTestsBegin");
				return new FFunctionalTestEventSignature();
			}
			if (OnTestsBegin_DelegateCached == null)
			{
				OnTestsBegin_DelegateCached = new FFunctionalTestEventSignature();
				OnTestsBegin_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTestsBegin_Offset));
			}
			return OnTestsBegin_DelegateCached;
		}
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTestingManager:RunAllFunctionalTests")]
	public unsafe static bool RunAllFunctionalTests(UObject WorldContextObject, bool bNewLog = true, bool bRunLooped = false, string FailedTestsReproString = null)
	{
		if (!RunAllFunctionalTests_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTestingManager:RunAllFunctionalTests");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RunAllFunctionalTests_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RunAllFunctionalTests_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RunAllFunctionalTests_WorldContextObject_Offset), 0, RunAllFunctionalTests_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RunAllFunctionalTests_bNewLog_Offset), 0, RunAllFunctionalTests_bNewLog_PropertyAddress.Address, bNewLog);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RunAllFunctionalTests_bRunLooped_Offset), 0, RunAllFunctionalTests_bRunLooped_PropertyAddress.Address, bRunLooped);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RunAllFunctionalTests_FailedTestsReproString_Offset), 0, RunAllFunctionalTests_FailedTestsReproString_PropertyAddress.Address, FailedTestsReproString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RunAllFunctionalTests_FunctionAddress, intPtr, RunAllFunctionalTests_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RunAllFunctionalTests_FailedTestsReproString_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RunAllFunctionalTests_ReturnValue_Offset), 0, RunAllFunctionalTests_ReturnValue_PropertyAddress.Address);
	}

	static UFunctionalTestingManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFunctionalTestingManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFunctionalTestingManager));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FunctionalTesting.FunctionalTestingManager");
		OnSetupTests_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnSetupTests");
		OnSetupTests_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnSetupTests", Classes.FMulticastDelegateProperty);
		OnTestsComplete_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnTestsComplete");
		OnTestsComplete_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnTestsComplete", Classes.FMulticastDelegateProperty);
		OnTestsBegin_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnTestsBegin");
		OnTestsBegin_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnTestsBegin", Classes.FMulticastDelegateProperty);
		RunAllFunctionalTests_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RunAllFunctionalTests");
		RunAllFunctionalTests_ParamsSize = NativeReflection.GetFunctionParamsSize(RunAllFunctionalTests_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RunAllFunctionalTests_WorldContextObject_PropertyAddress, RunAllFunctionalTests_FunctionAddress, "WorldContextObject");
		RunAllFunctionalTests_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(RunAllFunctionalTests_FunctionAddress, "WorldContextObject");
		RunAllFunctionalTests_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(RunAllFunctionalTests_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RunAllFunctionalTests_bNewLog_PropertyAddress, RunAllFunctionalTests_FunctionAddress, "bNewLog");
		RunAllFunctionalTests_bNewLog_Offset = NativeReflectionCached.GetPropertyOffset(RunAllFunctionalTests_FunctionAddress, "bNewLog");
		RunAllFunctionalTests_bNewLog_IsValid = NativeReflectionCached.ValidatePropertyClass(RunAllFunctionalTests_FunctionAddress, "bNewLog", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RunAllFunctionalTests_bRunLooped_PropertyAddress, RunAllFunctionalTests_FunctionAddress, "bRunLooped");
		RunAllFunctionalTests_bRunLooped_Offset = NativeReflectionCached.GetPropertyOffset(RunAllFunctionalTests_FunctionAddress, "bRunLooped");
		RunAllFunctionalTests_bRunLooped_IsValid = NativeReflectionCached.ValidatePropertyClass(RunAllFunctionalTests_FunctionAddress, "bRunLooped", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RunAllFunctionalTests_FailedTestsReproString_PropertyAddress, RunAllFunctionalTests_FunctionAddress, "FailedTestsReproString");
		RunAllFunctionalTests_FailedTestsReproString_Offset = NativeReflectionCached.GetPropertyOffset(RunAllFunctionalTests_FunctionAddress, "FailedTestsReproString");
		RunAllFunctionalTests_FailedTestsReproString_IsValid = NativeReflectionCached.ValidatePropertyClass(RunAllFunctionalTests_FunctionAddress, "FailedTestsReproString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RunAllFunctionalTests_ReturnValue_PropertyAddress, RunAllFunctionalTests_FunctionAddress, "ReturnValue");
		RunAllFunctionalTests_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RunAllFunctionalTests_FunctionAddress, "ReturnValue");
		RunAllFunctionalTests_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RunAllFunctionalTests_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RunAllFunctionalTests_IsValid = RunAllFunctionalTests_FunctionAddress != IntPtr.Zero && RunAllFunctionalTests_WorldContextObject_IsValid && RunAllFunctionalTests_bNewLog_IsValid && RunAllFunctionalTests_bRunLooped_IsValid && RunAllFunctionalTests_FailedTestsReproString_IsValid && RunAllFunctionalTests_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTestingManager:RunAllFunctionalTests", RunAllFunctionalTests_IsValid);
	}
}
