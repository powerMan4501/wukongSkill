using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace HelloUSharp;

[BlueprintType]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.HelloWorldActor")]
public class HelloWorldActor : AActor
{
	private static bool Value123_IsValid;

	private static int Value123_Offset;

	private static bool CallMe_IsValid;

	private static IntPtr CallMe_FunctionAddress;

	private static int CallMe_ParamsSize;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.HelloWorldActor:Value123")]
	public int Value123
	{
		get
		{
			CheckDestroyed();
			if (!Value123_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.HelloWorldActor:Value123");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Value123_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Value123_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.HelloWorldActor:Value123");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Value123_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.HelloWorldActor:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
		USystemLibrary.PrintString(this, "Hello world", bPrintToScreen: true, bPrintToLog: true, FLinearColor.White, 2f, FName.None);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.HelloWorldActor:CallMe")]
	public void CallMe()
	{
		USystemLibrary.PrintString(this, Value123.ToString(), bPrintToScreen: true, bPrintToLog: true, FLinearColor.White, 2f, FName.None);
		SetActorLocation(default(FVector), bSweep: false, out var _, bTeleport: false);
	}

	[UFunctionInvoker("/Script/b1-Managed.HelloWorldActor:CallMe")]
	private static void CallMe__Invoker(IntPtr buffer, IntPtr obj)
	{
		HelloWorldActor helloWorldActor = GCHelper.Find<HelloWorldActor>(obj);
		helloWorldActor.CallMe();
	}

	[UFunctionInvoker("/Script/b1-Managed.HelloWorldActor:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		HelloWorldActor helloWorldActor = GCHelper.Find<HelloWorldActor>(obj);
		helloWorldActor.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.HelloWorldActor");
		Value123_Offset = NativeReflection.GetPropertyOffset(intPtr, "Value123");
		Value123_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Value123", Classes.FIntProperty);
		CallMe_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CallMe");
		CallMe_ParamsSize = NativeReflection.GetFunctionParamsSize(CallMe_FunctionAddress);
		CallMe_IsValid = CallMe_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.HelloWorldActor:CallMe", CallMe_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.HelloWorldActor:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}

	static HelloWorldActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(HelloWorldActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(HelloWorldActor));
	}
}
