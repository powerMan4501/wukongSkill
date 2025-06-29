using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.ActorComp;

[BlueprintSpawnableComponent]
[UClass]
[USharpPath("/Script/b1-Managed.BGUPhysicalAnimTail")]
internal class BGUPhysicalAnimTail : UPhysicalAnimationComponent
{
	private static bool PhysicalAnimationData_IsValid;

	private static int PhysicalAnimationData_Offset;

	private static bool BonesName_IsValid;

	private static int BonesName_Offset;

	private static FFieldAddress BonesName_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> BonesName_Marshaler;

	private static bool BoneBlendCurve_IsValid;

	private static int BoneBlendCurve_Offset;

	private static bool InitializePhysicalAnimation_IsValid;

	private static IntPtr InitializePhysicalAnimation_FunctionAddress;

	private static int InitializePhysicalAnimation_ParamsSize;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Parameters")]
	[USharpPath("/Script/b1-Managed.BGUPhysicalAnimTail:PhysicalAnimationData")]
	public FPhysicalAnimationData PhysicalAnimationData
	{
		get
		{
			CheckDestroyed();
			if (!PhysicalAnimationData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPhysicalAnimTail:PhysicalAnimationData");
				return default(FPhysicalAnimationData);
			}
			return FPhysicalAnimationData.FromNative(IntPtr.Add(base.Address, PhysicalAnimationData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysicalAnimationData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPhysicalAnimTail:PhysicalAnimationData");
			}
			else
			{
				FPhysicalAnimationData.ToNative(IntPtr.Add(base.Address, PhysicalAnimationData_Offset), value);
			}
		}
	}

	[Category("Parameters")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUPhysicalAnimTail:BonesName")]
	public TArrayReadWrite<FName> BonesName
	{
		get
		{
			CheckDestroyed();
			if (!BonesName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPhysicalAnimTail:BonesName");
				return null;
			}
			if (BonesName_Marshaler == null)
			{
				BonesName_Marshaler = new TArrayReadWriteMarshaler<FName>(1, BonesName_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return BonesName_Marshaler.FromNative(IntPtr.Add(base.Address, BonesName_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Parameters")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUPhysicalAnimTail:BoneBlendCurve")]
	public UCurveFloat BoneBlendCurve
	{
		get
		{
			CheckDestroyed();
			if (!BoneBlendCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPhysicalAnimTail:BoneBlendCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, BoneBlendCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoneBlendCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPhysicalAnimTail:BoneBlendCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, BoneBlendCurve_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BGUPhysicalAnimTail:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUPhysicalAnimTail:InitializePhysicalAnimation")]
	public void InitializePhysicalAnimation()
	{
		USystemLibrary.PrintString(this, "Warning: Deprecated!!!!!!!!!Should delete!!!!!!!!", bPrintToScreen: true, bPrintToLog: true, FLinearColor.White, 10f, FName.None);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUPhysicalAnimTail:InitializePhysicalAnimation")]
	private static void InitializePhysicalAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGU.ActorComp.BGUPhysicalAnimTail bGUPhysicalAnimTail = GCHelper.Find<b1.BGU.ActorComp.BGUPhysicalAnimTail>(obj);
		bGUPhysicalAnimTail.InitializePhysicalAnimation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUPhysicalAnimTail:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGU.ActorComp.BGUPhysicalAnimTail bGUPhysicalAnimTail = GCHelper.Find<b1.BGU.ActorComp.BGUPhysicalAnimTail>(obj);
		bGUPhysicalAnimTail.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUPhysicalAnimTail");
		PhysicalAnimationData_Offset = NativeReflection.GetPropertyOffset(intPtr, "PhysicalAnimationData");
		PhysicalAnimationData_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PhysicalAnimationData", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref BonesName_PropertyAddress, intPtr, "BonesName");
		BonesName_Offset = NativeReflection.GetPropertyOffset(intPtr, "BonesName");
		BonesName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BonesName", Classes.FArrayProperty);
		BoneBlendCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "BoneBlendCurve");
		BoneBlendCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BoneBlendCurve", Classes.FObjectProperty);
		InitializePhysicalAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitializePhysicalAnimation");
		InitializePhysicalAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(InitializePhysicalAnimation_FunctionAddress);
		InitializePhysicalAnimation_IsValid = InitializePhysicalAnimation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPhysicalAnimTail:InitializePhysicalAnimation", InitializePhysicalAnimation_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPhysicalAnimTail:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}

	static BGUPhysicalAnimTail()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGU.ActorComp.BGUPhysicalAnimTail)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGU.ActorComp.BGUPhysicalAnimTail));
	}
}
