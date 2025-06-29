using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.AutoOnlineSubsystemTest", "UnrealExtent", UnrealModuleType.Game)]
public class UAutoOnlineSubsystemTest : UObject
{
	private static IntPtr classAddress;

	private static bool TestLogin_IsValid;

	private static IntPtr TestLogin_FunctionAddress;

	private static int TestLogin_ParamsSize;

	private static bool TestGSSdkAuthToken_IsValid;

	private static IntPtr TestGSSdkAuthToken_FunctionAddress;

	private static int TestGSSdkAuthToken_ParamsSize;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.AutoOnlineSubsystemTest:TestLogin")]
	public unsafe static void TestLogin()
	{
		if (!TestLogin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoOnlineSubsystemTest:TestLogin");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TestLogin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TestLogin_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: TestLogin_FunctionAddress, argsSize: TestLogin_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.AutoOnlineSubsystemTest:TestGSSdkAuthToken")]
	public unsafe static void TestGSSdkAuthToken()
	{
		if (!TestGSSdkAuthToken_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoOnlineSubsystemTest:TestGSSdkAuthToken");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TestGSSdkAuthToken_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TestGSSdkAuthToken_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: TestGSSdkAuthToken_FunctionAddress, argsSize: TestGSSdkAuthToken_ParamsSize);
	}

	static UAutoOnlineSubsystemTest()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAutoOnlineSubsystemTest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAutoOnlineSubsystemTest));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.AutoOnlineSubsystemTest");
		TestLogin_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TestLogin");
		TestLogin_ParamsSize = NativeReflection.GetFunctionParamsSize(TestLogin_FunctionAddress);
		TestLogin_IsValid = TestLogin_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoOnlineSubsystemTest:TestLogin", TestLogin_IsValid);
		TestGSSdkAuthToken_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TestGSSdkAuthToken");
		TestGSSdkAuthToken_ParamsSize = NativeReflection.GetFunctionParamsSize(TestGSSdkAuthToken_FunctionAddress);
		TestGSSdkAuthToken_IsValid = TestGSSdkAuthToken_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoOnlineSubsystemTest:TestGSSdkAuthToken", TestGSSdkAuthToken_IsValid);
	}
}
