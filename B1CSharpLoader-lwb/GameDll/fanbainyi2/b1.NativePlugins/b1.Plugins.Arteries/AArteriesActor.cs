using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.Arteries;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Arteries.ArteriesActor", "Arteries", UnrealModuleType.GamePlugin)]
public class AArteriesActor : AActor
{
	[UDelegate]
	[UMetaPath("/Script/Arteries.ArteriesActor:OnBuildCompleted__DelegateSignature")]
	public class FOnBuildCompleted : FMulticastDelegate<FOnBuildCompleted.Signature>
	{
		public delegate void Signature(UArteriesObject Object, FTransform Transform);

		private static bool OnBuildCompleted__DelegateSignature_IsValid;

		private static IntPtr OnBuildCompleted__DelegateSignature_FunctionAddress;

		private static int OnBuildCompleted__DelegateSignature_ParamsSize;

		private static bool OnBuildCompleted__DelegateSignature_Object_IsValid;

		private static FFieldAddress OnBuildCompleted__DelegateSignature_Object_PropertyAddress;

		private static int OnBuildCompleted__DelegateSignature_Object_Offset;

		private static bool OnBuildCompleted__DelegateSignature_Transform_IsValid;

		private static FFieldAddress OnBuildCompleted__DelegateSignature_Transform_PropertyAddress;

		private static int OnBuildCompleted__DelegateSignature_Transform_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnBuildCompleted()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnBuildCompleted__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Arteries.ArteriesActor:OnBuildCompleted__DelegateSignature");
			OnBuildCompleted__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBuildCompleted__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnBuildCompleted__DelegateSignature_Object_PropertyAddress, OnBuildCompleted__DelegateSignature_FunctionAddress, "Object");
			OnBuildCompleted__DelegateSignature_Object_Offset = NativeReflectionCached.GetPropertyOffset(OnBuildCompleted__DelegateSignature_FunctionAddress, "Object");
			OnBuildCompleted__DelegateSignature_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(OnBuildCompleted__DelegateSignature_FunctionAddress, "Object", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnBuildCompleted__DelegateSignature_Transform_PropertyAddress, OnBuildCompleted__DelegateSignature_FunctionAddress, "Transform");
			OnBuildCompleted__DelegateSignature_Transform_Offset = NativeReflectionCached.GetPropertyOffset(OnBuildCompleted__DelegateSignature_FunctionAddress, "Transform");
			OnBuildCompleted__DelegateSignature_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(OnBuildCompleted__DelegateSignature_FunctionAddress, "Transform", Classes.FStructProperty);
			OnBuildCompleted__DelegateSignature_IsValid = OnBuildCompleted__DelegateSignature_FunctionAddress != IntPtr.Zero && OnBuildCompleted__DelegateSignature_Object_IsValid && OnBuildCompleted__DelegateSignature_Transform_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesActor:OnBuildCompleted__DelegateSignature", OnBuildCompleted__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(UArteriesObject Object, FTransform Transform)
		{
			if (!OnBuildCompleted__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesActor:OnBuildCompleted__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnBuildCompleted__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBuildCompleted__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UArteriesObject>.ToNative(IntPtr.Add(intPtr, OnBuildCompleted__DelegateSignature_Object_Offset), 0, OnBuildCompleted__DelegateSignature_Object_PropertyAddress.Address, Object);
				NativeReflection.InitializeValue_InContainer(OnBuildCompleted__DelegateSignature_Transform_PropertyAddress.Address, intPtr);
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, OnBuildCompleted__DelegateSignature_Transform_Offset), 0, OnBuildCompleted__DelegateSignature_Transform_PropertyAddress.Address, Transform);
				ProcessDelegate(intPtr);
			}
		}
	}

	private static bool OnBuildCompleted_IsValid;

	private static int OnBuildCompleted_Offset;

	private FOnBuildCompleted OnBuildCompleted_DelegateCached;

	private static bool FinalObject_IsValid;

	private static int FinalObject_Offset;

	private static bool WaitForCount_IsValid;

	private static IntPtr WaitForCount_FunctionAddress;

	private static int WaitForCount_ParamsSize;

	private static bool WaitForCount_GroupName_IsValid;

	private static FFieldAddress WaitForCount_GroupName_PropertyAddress;

	private static int WaitForCount_GroupName_Offset;

	private static bool WaitForCount_Count_IsValid;

	private static FFieldAddress WaitForCount_Count_PropertyAddress;

	private static int WaitForCount_Count_Offset;

	private static bool WaitForCount_Timeout_IsValid;

	private static FFieldAddress WaitForCount_Timeout_PropertyAddress;

	private static int WaitForCount_Timeout_Offset;

	private static bool OnBuild_IsValid;

	private IntPtr OnBuild_InstanceFunctionAddress;

	private static IntPtr OnBuild_FunctionAddress;

	private static int OnBuild_ParamsSize;

	private static bool Increment_IsValid;

	private static IntPtr Increment_FunctionAddress;

	private static int Increment_ParamsSize;

	private static bool Increment_GroupName_IsValid;

	private static FFieldAddress Increment_GroupName_PropertyAddress;

	private static int Increment_GroupName_Offset;

	private static bool Build_IsValid;

	private static IntPtr Build_FunctionAddress;

	private static int Build_ParamsSize;

	private static bool Build_bForceRebuild_IsValid;

	private static FFieldAddress Build_bForceRebuild_PropertyAddress;

	private static int Build_bForceRebuild_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Arteries.ArteriesActor:OnBuildCompleted")]
	public FOnBuildCompleted OnBuildCompleted
	{
		get
		{
			CheckDestroyed();
			if (!OnBuildCompleted_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Arteries.ArteriesActor:OnBuildCompleted");
				return new FOnBuildCompleted();
			}
			if (OnBuildCompleted_DelegateCached == null)
			{
				OnBuildCompleted_DelegateCached = new FOnBuildCompleted();
				OnBuildCompleted_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnBuildCompleted_Offset));
			}
			return OnBuildCompleted_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Arteries.ArteriesActor:FinalObject")]
	public UArteriesObject FinalObject
	{
		get
		{
			CheckDestroyed();
			if (!FinalObject_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Arteries.ArteriesActor:FinalObject");
				return null;
			}
			return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(base.Address, FinalObject_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FinalObject_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Arteries.ArteriesActor:FinalObject");
			}
			else
			{
				UObjectMarshaler<UArteriesObject>.ToNative(IntPtr.Add(base.Address, FinalObject_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesActor:WaitForCount")]
	public unsafe void WaitForCount(FName GroupName, int Count, float Timeout = 10f)
	{
		CheckDestroyed();
		if (!WaitForCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesActor:WaitForCount");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WaitForCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WaitForCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, WaitForCount_GroupName_Offset), 0, WaitForCount_GroupName_PropertyAddress.Address, GroupName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, WaitForCount_Count_Offset), 0, WaitForCount_Count_PropertyAddress.Address, Count);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, WaitForCount_Timeout_Offset), 0, WaitForCount_Timeout_PropertyAddress.Address, Timeout);
		NativeReflection.InvokeFunctionOptimized(base.Address, WaitForCount_FunctionAddress, intPtr, WaitForCount_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Arteries.ArteriesActor:OnBuild")]
	public unsafe void OnBuild()
	{
		CheckDestroyed();
		if (!OnBuild_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesActor:OnBuild");
			return;
		}
		if (OnBuild_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnBuild_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnBuild");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnBuild_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBuild_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnBuild_InstanceFunctionAddress, argsSize: OnBuild_ParamsSize);
	}

	protected unsafe virtual void OnBuild_Implementation()
	{
		CheckDestroyed();
		if (!OnBuild_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesActor:OnBuild");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnBuild_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBuild_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnBuild_FunctionAddress, argsSize: OnBuild_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesActor:Increment")]
	public unsafe void Increment(FName GroupName)
	{
		CheckDestroyed();
		if (!Increment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesActor:Increment");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Increment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Increment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Increment_GroupName_Offset), 0, Increment_GroupName_PropertyAddress.Address, GroupName);
		NativeReflection.InvokeFunctionOptimized(base.Address, Increment_FunctionAddress, intPtr, Increment_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesActor:Build")]
	public unsafe void Build(bool bForceRebuild)
	{
		CheckDestroyed();
		if (!Build_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesActor:Build");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Build_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Build_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Build_bForceRebuild_Offset), 0, Build_bForceRebuild_PropertyAddress.Address, bForceRebuild);
		NativeReflection.InvokeFunctionOptimized(base.Address, Build_FunctionAddress, intPtr, Build_ParamsSize);
	}

	static AArteriesActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AArteriesActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AArteriesActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Arteries.ArteriesActor");
		OnBuildCompleted_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnBuildCompleted");
		OnBuildCompleted_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnBuildCompleted", Classes.FMulticastDelegateProperty);
		FinalObject_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FinalObject");
		FinalObject_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FinalObject", Classes.FObjectProperty);
		WaitForCount_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "WaitForCount");
		WaitForCount_ParamsSize = NativeReflection.GetFunctionParamsSize(WaitForCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WaitForCount_GroupName_PropertyAddress, WaitForCount_FunctionAddress, "GroupName");
		WaitForCount_GroupName_Offset = NativeReflectionCached.GetPropertyOffset(WaitForCount_FunctionAddress, "GroupName");
		WaitForCount_GroupName_IsValid = NativeReflectionCached.ValidatePropertyClass(WaitForCount_FunctionAddress, "GroupName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref WaitForCount_Count_PropertyAddress, WaitForCount_FunctionAddress, "Count");
		WaitForCount_Count_Offset = NativeReflectionCached.GetPropertyOffset(WaitForCount_FunctionAddress, "Count");
		WaitForCount_Count_IsValid = NativeReflectionCached.ValidatePropertyClass(WaitForCount_FunctionAddress, "Count", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref WaitForCount_Timeout_PropertyAddress, WaitForCount_FunctionAddress, "Timeout");
		WaitForCount_Timeout_Offset = NativeReflectionCached.GetPropertyOffset(WaitForCount_FunctionAddress, "Timeout");
		WaitForCount_Timeout_IsValid = NativeReflectionCached.ValidatePropertyClass(WaitForCount_FunctionAddress, "Timeout", Classes.FFloatProperty);
		WaitForCount_IsValid = WaitForCount_FunctionAddress != IntPtr.Zero && WaitForCount_GroupName_IsValid && WaitForCount_Count_IsValid && WaitForCount_Timeout_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesActor:WaitForCount", WaitForCount_IsValid);
		OnBuild_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnBuild");
		OnBuild_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBuild_FunctionAddress);
		OnBuild_IsValid = OnBuild_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesActor:OnBuild", OnBuild_IsValid);
		Increment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Increment");
		Increment_ParamsSize = NativeReflection.GetFunctionParamsSize(Increment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Increment_GroupName_PropertyAddress, Increment_FunctionAddress, "GroupName");
		Increment_GroupName_Offset = NativeReflectionCached.GetPropertyOffset(Increment_FunctionAddress, "GroupName");
		Increment_GroupName_IsValid = NativeReflectionCached.ValidatePropertyClass(Increment_FunctionAddress, "GroupName", Classes.FNameProperty);
		Increment_IsValid = Increment_FunctionAddress != IntPtr.Zero && Increment_GroupName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesActor:Increment", Increment_IsValid);
		Build_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Build");
		Build_ParamsSize = NativeReflection.GetFunctionParamsSize(Build_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Build_bForceRebuild_PropertyAddress, Build_FunctionAddress, "bForceRebuild");
		Build_bForceRebuild_Offset = NativeReflectionCached.GetPropertyOffset(Build_FunctionAddress, "bForceRebuild");
		Build_bForceRebuild_IsValid = NativeReflectionCached.ValidatePropertyClass(Build_FunctionAddress, "bForceRebuild", Classes.FBoolProperty);
		Build_IsValid = Build_FunctionAddress != IntPtr.Zero && Build_bForceRebuild_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesActor:Build", Build_IsValid);
	}
}
