using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace HelloUSharp;

[BlueprintType]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.HelloUFromUSharp")]
public class HelloUFromUSharp : AActor
{
	private static bool Value123_IsValid;

	private static int Value123_Offset;

	private static bool Value456_IsValid;

	private static int Value456_Offset;

	private static bool DelegateTest_IsValid;

	private static int DelegateTest_Offset;

	private HelloUSharpDelegate DelegateTest_DelegateCached;

	private static bool TestComp_IsValid;

	private static int TestComp_Offset;

	private static bool TestArr2_IsValid;

	private static int TestArr2_Offset;

	private static FFieldAddress TestArr2_PropertyAddress;

	private TArrayReadWriteMarshaler<int> TestArr2_Marshaler;

	private static bool ActorClass_IsValid;

	private static int ActorClass_Offset;

	private static bool ActorClass4_IsValid;

	private static int ActorClass4_Offset;

	private static bool Struct_IsValid;

	private static int Struct_Offset;

	private static bool CallMe_IsValid;

	private static IntPtr CallMe_FunctionAddress;

	private static int CallMe_ParamsSize;

	private static bool CallMe_arg1_IsValid;

	private static int CallMe_arg1_Offset;

	private static FFieldAddress CallMe_arg1_PropertyAddress;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.HelloUFromUSharp:Value123")]
	public int Value123
	{
		get
		{
			CheckDestroyed();
			if (!Value123_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.HelloUFromUSharp:Value123");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Value123_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Value123_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.HelloUFromUSharp:Value123");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Value123_Offset), value);
			}
		}
	}

	[Category("MyCategory")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.HelloUFromUSharp:Value456")]
	public string Value456
	{
		get
		{
			CheckDestroyed();
			if (!Value456_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.HelloUFromUSharp:Value456");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Value456_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Value456_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.HelloUFromUSharp:Value456");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Value456_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty(PropFlags.BlueprintAssignable | PropFlags.BlueprintCallable)]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.HelloUFromUSharp:DelegateTest")]
	public HelloUSharpDelegate DelegateTest
	{
		get
		{
			CheckDestroyed();
			if (!DelegateTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.HelloUFromUSharp:DelegateTest");
				return null;
			}
			if (DelegateTest_DelegateCached == null)
			{
				DelegateTest_DelegateCached = new HelloUSharpDelegate();
				DelegateTest_DelegateCached.SetAddress(IntPtr.Add(base.Address, DelegateTest_Offset));
			}
			return DelegateTest_DelegateCached;
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.HelloUFromUSharp:TestComp")]
	public HelloUTestComp TestComp
	{
		get
		{
			CheckDestroyed();
			if (!TestComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.HelloUFromUSharp:TestComp");
				return null;
			}
			return UObjectMarshaler<HelloUTestComp>.FromNative(IntPtr.Add(base.Address, TestComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TestComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.HelloUFromUSharp:TestComp");
			}
			else
			{
				UObjectMarshaler<HelloUTestComp>.ToNative(IntPtr.Add(base.Address, TestComp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.HelloUFromUSharp:TestArr2")]
	public TArrayReadWrite<int> TestArr2
	{
		get
		{
			CheckDestroyed();
			if (!TestArr2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.HelloUFromUSharp:TestArr2");
				return null;
			}
			if (TestArr2_Marshaler == null)
			{
				TestArr2_Marshaler = new TArrayReadWriteMarshaler<int>(1, TestArr2_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return TestArr2_Marshaler.FromNative(IntPtr.Add(base.Address, TestArr2_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.HelloUFromUSharp:ActorClass")]
	public TSubclassOf<AActor> ActorClass
	{
		get
		{
			CheckDestroyed();
			if (!ActorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.HelloUFromUSharp:ActorClass");
				return default(TSubclassOf<AActor>);
			}
			return TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, ActorClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.HelloUFromUSharp:ActorClass");
			}
			else
			{
				TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, ActorClass_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.HelloUFromUSharp:ActorClass4")]
	public UClass ActorClass4
	{
		get
		{
			CheckDestroyed();
			if (!ActorClass4_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.HelloUFromUSharp:ActorClass4");
				return null;
			}
			return UObjectMarshaler<UClass>.FromNative(IntPtr.Add(base.Address, ActorClass4_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorClass4_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.HelloUFromUSharp:ActorClass4");
			}
			else
			{
				UObjectMarshaler<UClass>.ToNative(IntPtr.Add(base.Address, ActorClass4_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.HelloUFromUSharp:Struct")]
	private HelloUStructTest Struct
	{
		get
		{
			CheckDestroyed();
			if (!Struct_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.HelloUFromUSharp:Struct");
				return default(HelloUStructTest);
			}
			return BlittableTypeMarshaler<HelloUStructTest>.FromNative(IntPtr.Add(base.Address, Struct_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Struct_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.HelloUFromUSharp:Struct");
			}
			else
			{
				BlittableTypeMarshaler<HelloUStructTest>.ToNative(IntPtr.Add(base.Address, Struct_Offset), value);
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.HelloUFromUSharp:CallMe")]
	public void CallMe(string arg1)
	{
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		TestComp = initializer.CreateDefaultSubobject<HelloUTestComp>(this, new FName("TestComp"));
	}

	[USharpPath("/Script/b1-Managed.HelloUFromUSharp:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
		if (ActorClass.Value != null)
		{
			BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(base.World, ActorClass.Value, GetActorLocation(), GetActorRotation());
		}
		int num = 0;
		for (int i = 0; i < TestArr2.Count; i++)
		{
			num += TestArr2[i];
		}
		TestComp.MarkPendingKill();
		DelegateTest.Invoke(1, "", 1);
	}

	[UFunctionInvoker("/Script/b1-Managed.HelloUFromUSharp:CallMe")]
	private static void CallMe__Invoker(IntPtr buffer, IntPtr obj)
	{
		HelloUFromUSharp helloUFromUSharp = GCHelper.Find<HelloUFromUSharp>(obj);
		string arg = FStringMarshaler.FromNative(IntPtr.Add(buffer, CallMe_arg1_Offset));
		helloUFromUSharp.CallMe(arg);
	}

	[UFunctionInvoker("/Script/b1-Managed.HelloUFromUSharp:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		HelloUFromUSharp helloUFromUSharp = GCHelper.Find<HelloUFromUSharp>(obj);
		helloUFromUSharp.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.HelloUFromUSharp");
		Value123_Offset = NativeReflection.GetPropertyOffset(intPtr, "Value123");
		Value123_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Value123", Classes.FIntProperty);
		Value456_Offset = NativeReflection.GetPropertyOffset(intPtr, "Value456");
		Value456_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Value456", Classes.FStrProperty);
		DelegateTest_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelegateTest");
		DelegateTest_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelegateTest", Classes.FMulticastDelegateProperty);
		TestComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "TestComp");
		TestComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TestComp", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref TestArr2_PropertyAddress, intPtr, "TestArr2");
		TestArr2_Offset = NativeReflection.GetPropertyOffset(intPtr, "TestArr2");
		TestArr2_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TestArr2", Classes.FArrayProperty);
		ActorClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorClass");
		ActorClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorClass", Classes.FClassProperty);
		ActorClass4_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorClass4");
		ActorClass4_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorClass4", Classes.FObjectProperty);
		Struct_Offset = NativeReflection.GetPropertyOffset(intPtr, "Struct");
		Struct_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Struct", Classes.FStructProperty);
		CallMe_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CallMe");
		CallMe_ParamsSize = NativeReflection.GetFunctionParamsSize(CallMe_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CallMe_arg1_PropertyAddress, CallMe_FunctionAddress, "arg1");
		CallMe_arg1_Offset = NativeReflection.GetPropertyOffset(CallMe_FunctionAddress, "arg1");
		CallMe_arg1_IsValid = NativeReflection.ValidatePropertyClass(CallMe_FunctionAddress, "arg1", Classes.FStrProperty);
		CallMe_IsValid = CallMe_FunctionAddress != IntPtr.Zero && CallMe_arg1_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.HelloUFromUSharp:CallMe", CallMe_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.HelloUFromUSharp:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}

	static HelloUFromUSharp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(HelloUFromUSharp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(HelloUFromUSharp));
	}
}
