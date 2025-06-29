using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct FObjectInitializer
{
	private IntPtr NativeObject;

	private IntPtr NativeObjectInitializer;

	public bool IsNull => NativeObjectInitializer == IntPtr.Zero;

	public IntPtr Address => NativeObjectInitializer;

	public IntPtr ObjectAddress => NativeObject;

	public IntPtr ClassAddress => Native_FObjectInitializer.GetClass(NativeObjectInitializer);

	public IntPtr ParentClassAddress
	{
		get
		{
			IntPtr classAddress = ClassAddress;
			if (classAddress != IntPtr.Zero)
			{
				IntPtr intPtr = Native_UStruct.GetSuperStruct(classAddress);
				if (intPtr != classAddress)
				{
					return intPtr;
				}
			}
			return IntPtr.Zero;
		}
	}

	public FObjectInitializer(IntPtr nativeObjectInitializer)
	{
		NativeObject = ((nativeObjectInitializer == IntPtr.Zero) ? IntPtr.Zero : Native_FObjectInitializer.GetObj(nativeObjectInitializer));
		NativeObjectInitializer = nativeObjectInitializer;
	}

	public UObject GetArchetype()
	{
		return GCHelper.Find<UObject>(Native_FObjectInitializer.GetArchetype(NativeObjectInitializer));
	}

	public UObject GetObj()
	{
		return GCHelper.Find<UObject>(Native_FObjectInitializer.GetObj(NativeObjectInitializer));
	}

	public UClass GetClass()
	{
		return GCHelper.Find<UClass>(Native_FObjectInitializer.GetClass(NativeObjectInitializer));
	}

	public UObject CreateEditorOnlyDefaultSubobject(UObject outer, FName subobjectName, UClass returnType, bool transient)
	{
		return GCHelper.Find<UObject>(Native_FObjectInitializer.CreateEditorOnlyDefaultSubobject(NativeObjectInitializer, (outer == null) ? IntPtr.Zero : outer.Address, ref subobjectName, (returnType == null) ? IntPtr.Zero : returnType.Address, transient));
	}

	public T CreateDefaultSubobject<T>(UObject outer, FName subobjectName, bool transient = false) where T : UObject
	{
		return CreateDefaultSubobject<T, T>(outer, subobjectName, transient);
	}

	public TReturnType CreateDefaultSubobject<TReturnType, TClassToConstructByDefault>(UObject outer, FName subobjectName, bool transient = false) where TReturnType : UObject where TClassToConstructByDefault : UObject
	{
		return CreateDefaultSubobject(outer, subobjectName, UClass.GetClass<TReturnType>(), UClass.GetClass<TClassToConstructByDefault>(), isRequired: true, transient) as TReturnType;
	}

	public UObject CreateDefaultSubobject(UObject outer, FName subobjectFName, UClass returnType, UClass classToCreateByDefault, bool isRequired, bool isTransient)
	{
		return GCHelper.Find<UObject>(Native_FObjectInitializer.CreateDefaultSubobject(NativeObjectInitializer, (outer == null) ? IntPtr.Zero : outer.Address, ref subobjectFName, (returnType == null) ? IntPtr.Zero : returnType.Address, (classToCreateByDefault == null) ? IntPtr.Zero : classToCreateByDefault.Address, isRequired, isTransient));
	}

	public FObjectInitializer DoNotCreateDefaultSubobject(FName subobjectName)
	{
		Native_FObjectInitializer.DoNotCreateDefaultSubobject(NativeObjectInitializer, ref subobjectName);
		return this;
	}

	public FObjectInitializer DoNotCreateDefaultSubobject(string subobjectName)
	{
		using (FStringUnsafe fStringUnsafe = new FStringUnsafe(subobjectName))
		{
			Native_FObjectInitializer.DoNotCreateDefaultSubobjectStr(NativeObjectInitializer, ref fStringUnsafe.Array);
		}
		return this;
	}

	public bool IslegalOverride(FName componentName, UClass derivedComponentClass, UClass baseComponentClass)
	{
		return Native_FObjectInitializer.IslegalOverride(NativeObjectInitializer, ref componentName, (derivedComponentClass == null) ? IntPtr.Zero : derivedComponentClass.Address, (baseComponentClass == null) ? IntPtr.Zero : baseComponentClass.Address);
	}

	public void FinalizeSubobjectClassInitialization()
	{
		Native_FObjectInitializer.FinalizeSubobjectClassInitialization(NativeObjectInitializer);
	}

	public static void AssertIfInConstructor(UObject outer)
	{
		AssertIfInConstructor((outer == null) ? IntPtr.Zero : outer.Address);
	}

	public static void AssertIfInConstructor(UObject outer, string errorMessage)
	{
		AssertIfInConstructor((outer == null) ? IntPtr.Zero : outer.Address, errorMessage);
	}

	internal static void AssertIfInConstructor(IntPtr outer)
	{
		AssertIfInConstructor(outer, "NewObject with empty name can't be used to create default subobjects (inside of UObject derived class constructor) as it produces inconsistent object names. Use ObjectInitializer.CreateDefaultSuobject<> instead.");
	}

	internal static void AssertIfInConstructor(IntPtr outer, string errorMessage)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(errorMessage);
		Native_FObjectInitializer.AssertIfInConstructor(outer, ref fStringUnsafe.Array);
	}

	public static FObjectInitializer Get()
	{
		FObjectInitializer result = default(FObjectInitializer);
		IntPtr intPtr = Native_FObjectInitializer.Get();
		if (intPtr != IntPtr.Zero)
		{
			result.NativeObject = Native_FObjectInitializer.GetObj(intPtr);
			result.NativeObjectInitializer = intPtr;
		}
		return result;
	}
}
