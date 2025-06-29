using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessActor")]
public class GSDispLib_PostProcessActor : AActor
{
	private static bool MaterialPrototype_IsValid;

	private static int MaterialPrototype_Offset;

	private static bool MaterialInstDynamic_IsValid;

	private static int MaterialInstDynamic_Offset;

	private static bool PPContext_IsValid;

	private static int PPContext_Offset;

	private static bool PPConf_IsValid;

	private static int PPConf_Offset;

	private static bool Progress_IsValid;

	private static int Progress_Offset;

	private static bool IsAutoPlay_IsValid;

	private static int IsAutoPlay_Offset;

	private static FFieldAddress IsAutoPlay_PropertyAddress;

	private static bool Parameters_IsValid;

	private static int Parameters_Offset;

	private static bool EffectID_IsValid;

	private static int EffectID_Offset;

	private static bool OnInit_IsValid;

	private static IntPtr OnInit_FunctionAddress;

	private static int OnInit_ParamsSize;

	private static bool OnInit_Context_IsValid;

	private static int OnInit_Context_Offset;

	private static bool OnInit_Conf_IsValid;

	private static int OnInit_Conf_Offset;

	private static FFieldAddress OnInit_Conf_PropertyAddress;

	private IntPtr OnInit_InstanceFunctionAddressInstance;

	private static bool OnEndBegin_IsValid;

	private static IntPtr OnEndBegin_FunctionAddress;

	private static int OnEndBegin_ParamsSize;

	private static bool OnEndBegin_Context_IsValid;

	private static int OnEndBegin_Context_Offset;

	private IntPtr OnEndBegin_InstanceFunctionAddressInstance;

	private static bool OnEndFinish_IsValid;

	private static IntPtr OnEndFinish_FunctionAddress;

	private static int OnEndFinish_ParamsSize;

	private static bool OnEndFinish_Context_IsValid;

	private static int OnEndFinish_Context_Offset;

	private IntPtr OnEndFinish_InstanceFunctionAddressInstance;

	private static bool OnEffectTick_IsValid;

	private static IntPtr OnEffectTick_FunctionAddress;

	private static int OnEffectTick_ParamsSize;

	private static bool OnEffectTick_DeltaTime_IsValid;

	private static int OnEffectTick_DeltaTime_Offset;

	private static bool OnEffectTick_Progress_IsValid;

	private static int OnEffectTick_Progress_Offset;

	private static bool OnEffectTick_Context_IsValid;

	private static int OnEffectTick_Context_Offset;

	private IntPtr OnEffectTick_InstanceFunctionAddressInstance;

	private static bool OnEnterBegin_IsValid;

	private static IntPtr OnEnterBegin_FunctionAddress;

	private static int OnEnterBegin_ParamsSize;

	private static bool OnEnterBegin_Context_IsValid;

	private static int OnEnterBegin_Context_Offset;

	private IntPtr OnEnterBegin_InstanceFunctionAddressInstance;

	private static bool OnEnterFinish_IsValid;

	private static IntPtr OnEnterFinish_FunctionAddress;

	private static int OnEnterFinish_ParamsSize;

	private static bool OnEnterFinish_Context_IsValid;

	private static int OnEnterFinish_Context_Offset;

	private IntPtr OnEnterFinish_InstanceFunctionAddressInstance;

	private static bool OnAlreadyBegin_IsValid;

	private static IntPtr OnAlreadyBegin_FunctionAddress;

	private static int OnAlreadyBegin_ParamsSize;

	private static bool OnAlreadyBegin_Context_IsValid;

	private static int OnAlreadyBegin_Context_Offset;

	private IntPtr OnAlreadyBegin_InstanceFunctionAddressInstance;

	private static bool OnAlreadyFinish_IsValid;

	private static IntPtr OnAlreadyFinish_FunctionAddress;

	private static int OnAlreadyFinish_ParamsSize;

	private static bool OnAlreadyFinish_Context_IsValid;

	private static int OnAlreadyFinish_Context_Offset;

	private IntPtr OnAlreadyFinish_InstanceFunctionAddressInstance;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessActor:MaterialPrototype")]
	public UMaterialInstance MaterialPrototype
	{
		get
		{
			CheckDestroyed();
			if (!MaterialPrototype_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:MaterialPrototype");
				return null;
			}
			return UObjectMarshaler<UMaterialInstance>.FromNative(IntPtr.Add(base.Address, MaterialPrototype_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaterialPrototype_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:MaterialPrototype");
			}
			else
			{
				UObjectMarshaler<UMaterialInstance>.ToNative(IntPtr.Add(base.Address, MaterialPrototype_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessActor:MaterialInstDynamic")]
	public UMaterialInstanceDynamic MaterialInstDynamic
	{
		get
		{
			CheckDestroyed();
			if (!MaterialInstDynamic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:MaterialInstDynamic");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, MaterialInstDynamic_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaterialInstDynamic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:MaterialInstDynamic");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, MaterialInstDynamic_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessActor:PPContext")]
	public GSDispLib_PostProcessContext PPContext
	{
		get
		{
			CheckDestroyed();
			if (!PPContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:PPContext");
				return null;
			}
			return UObjectMarshaler<GSDispLib_PostProcessContext>.FromNative(IntPtr.Add(base.Address, PPContext_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PPContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:PPContext");
			}
			else
			{
				UObjectMarshaler<GSDispLib_PostProcessContext>.ToNative(IntPtr.Add(base.Address, PPContext_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessActor:PPConf")]
	public UDispLib_PostPorcessCommonConf PPConf
	{
		get
		{
			CheckDestroyed();
			if (!PPConf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:PPConf");
				return default(UDispLib_PostPorcessCommonConf);
			}
			return UDispLib_PostPorcessCommonConf.FromNative(IntPtr.Add(base.Address, PPConf_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PPConf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:PPConf");
			}
			else
			{
				UDispLib_PostPorcessCommonConf.ToNative(IntPtr.Add(base.Address, PPConf_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessActor:Progress")]
	public float Progress
	{
		get
		{
			CheckDestroyed();
			if (!Progress_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:Progress");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Progress_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Progress_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:Progress");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Progress_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessActor:IsAutoPlay")]
	public bool IsAutoPlay
	{
		get
		{
			CheckDestroyed();
			if (!IsAutoPlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:IsAutoPlay");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsAutoPlay_Offset), 0, IsAutoPlay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsAutoPlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:IsAutoPlay");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsAutoPlay_Offset), 0, IsAutoPlay_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessActor:Parameters")]
	public UDispLib_PPEffectParameters Parameters
	{
		get
		{
			CheckDestroyed();
			if (!Parameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:Parameters");
				return null;
			}
			return UObjectMarshaler<UDispLib_PPEffectParameters>.FromNative(IntPtr.Add(base.Address, Parameters_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Parameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:Parameters");
			}
			else
			{
				UObjectMarshaler<UDispLib_PPEffectParameters>.ToNative(IntPtr.Add(base.Address, Parameters_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessActor:EffectID")]
	public int EffectID
	{
		get
		{
			CheckDestroyed();
			if (!EffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:EffectID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EffectID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:EffectID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EffectID_Offset), value);
			}
		}
	}

	[UFunction]
	[BlueprintEvent]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessActor:OnInit")]
	public unsafe void OnInit(GSDispLib_PostProcessContext Context, UDispLib_PostPorcessCommonConf Conf)
	{
		CheckDestroyed();
		if (!OnInit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:OnInit");
			return;
		}
		if (OnInit_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnInit_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnInit");
		}
		byte* value = stackalloc byte[(int)(uint)OnInit_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnInit_ParamsSize);
		UObjectMarshaler<GSDispLib_PostProcessContext>.ToNative(IntPtr.Add(intPtr, OnInit_Context_Offset), Context);
		UDispLib_PostPorcessCommonConf.ToNative(IntPtr.Add(intPtr, OnInit_Conf_Offset), Conf);
		NativeReflection.InvokeFunction(base.Address, OnInit_InstanceFunctionAddressInstance, intPtr, OnInit_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnInit_Conf_PropertyAddress.Address, intPtr);
	}

	public virtual void OnInit_Implementation(GSDispLib_PostProcessContext Context, UDispLib_PostPorcessCommonConf Conf)
	{
		PPContext = Context;
		PPConf.Copy(Conf);
		if (MaterialPrototype != null)
		{
			MaterialInstDynamic = UMaterialLibrary.CreateDynamicMaterialInstance(this, MaterialPrototype, MaterialPrototype.GetFName(), EMIDCreationFlags.None);
		}
	}

	public void OnSetParameters(UDispLib_PPEffectParameters InParameters)
	{
		Parameters = InParameters;
	}

	[UFunction]
	[BlueprintEvent]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEffectTick")]
	public unsafe void OnEffectTick(float DeltaTime, float Progress, GSDispLib_PostProcessContext Context)
	{
		CheckDestroyed();
		if (!OnEffectTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEffectTick");
			return;
		}
		if (OnEffectTick_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnEffectTick_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnEffectTick");
		}
		byte* value = stackalloc byte[(int)(uint)OnEffectTick_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnEffectTick_ParamsSize);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnEffectTick_DeltaTime_Offset), DeltaTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnEffectTick_Progress_Offset), Progress);
		UObjectMarshaler<GSDispLib_PostProcessContext>.ToNative(IntPtr.Add(intPtr, OnEffectTick_Context_Offset), Context);
		NativeReflection.InvokeFunction(base.Address, OnEffectTick_InstanceFunctionAddressInstance, intPtr, OnEffectTick_ParamsSize);
	}

	public virtual void OnEffectTick_Implementation(float DeltaTime, float Progress, GSDispLib_PostProcessContext Context)
	{
	}

	[BlueprintCallable]
	[UFunction]
	[BlueprintEvent]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEnterBegin")]
	public unsafe void OnEnterBegin(GSDispLib_PostProcessContext Context)
	{
		CheckDestroyed();
		if (!OnEnterBegin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEnterBegin");
			return;
		}
		if (OnEnterBegin_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnEnterBegin_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnEnterBegin");
		}
		byte* value = stackalloc byte[(int)(uint)OnEnterBegin_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnEnterBegin_ParamsSize);
		UObjectMarshaler<GSDispLib_PostProcessContext>.ToNative(IntPtr.Add(intPtr, OnEnterBegin_Context_Offset), Context);
		NativeReflection.InvokeFunction(base.Address, OnEnterBegin_InstanceFunctionAddressInstance, intPtr, OnEnterBegin_ParamsSize);
	}

	public virtual void OnEnterBegin_Implementation(GSDispLib_PostProcessContext Context)
	{
		PPContext = Context;
		if (MaterialInstDynamic != null && Context != null && Context.PostProcessVolume != null && !Context.PostProcessVolume.IsPendingKill)
		{
			UGSE_PostProcessFuncLib.SetPPVWeightedBlendableWeight(Context.PostProcessVolume, MaterialInstDynamic, 1f);
		}
	}

	[UFunction]
	[BlueprintEvent]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEndBegin")]
	public unsafe void OnEndBegin(GSDispLib_PostProcessContext Context)
	{
		CheckDestroyed();
		if (!OnEndBegin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEndBegin");
			return;
		}
		if (OnEndBegin_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnEndBegin_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnEndBegin");
		}
		byte* value = stackalloc byte[(int)(uint)OnEndBegin_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnEndBegin_ParamsSize);
		UObjectMarshaler<GSDispLib_PostProcessContext>.ToNative(IntPtr.Add(intPtr, OnEndBegin_Context_Offset), Context);
		NativeReflection.InvokeFunction(base.Address, OnEndBegin_InstanceFunctionAddressInstance, intPtr, OnEndBegin_ParamsSize);
	}

	public virtual void OnEndBegin_Implementation(GSDispLib_PostProcessContext Context)
	{
	}

	[BlueprintCallable]
	[BlueprintEvent]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEnterFinish")]
	public unsafe void OnEnterFinish(GSDispLib_PostProcessContext Context)
	{
		CheckDestroyed();
		if (!OnEnterFinish_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEnterFinish");
			return;
		}
		if (OnEnterFinish_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnEnterFinish_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnEnterFinish");
		}
		byte* value = stackalloc byte[(int)(uint)OnEnterFinish_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnEnterFinish_ParamsSize);
		UObjectMarshaler<GSDispLib_PostProcessContext>.ToNative(IntPtr.Add(intPtr, OnEnterFinish_Context_Offset), Context);
		NativeReflection.InvokeFunction(base.Address, OnEnterFinish_InstanceFunctionAddressInstance, intPtr, OnEnterFinish_ParamsSize);
	}

	public virtual void OnEnterFinish_Implementation(GSDispLib_PostProcessContext Context)
	{
	}

	[UFunction]
	[BlueprintEvent]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEndFinish")]
	public unsafe void OnEndFinish(GSDispLib_PostProcessContext Context)
	{
		CheckDestroyed();
		if (!OnEndFinish_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEndFinish");
			return;
		}
		if (OnEndFinish_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnEndFinish_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnEndFinish");
		}
		byte* value = stackalloc byte[(int)(uint)OnEndFinish_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnEndFinish_ParamsSize);
		UObjectMarshaler<GSDispLib_PostProcessContext>.ToNative(IntPtr.Add(intPtr, OnEndFinish_Context_Offset), Context);
		NativeReflection.InvokeFunction(base.Address, OnEndFinish_InstanceFunctionAddressInstance, intPtr, OnEndFinish_ParamsSize);
	}

	public virtual void OnEndFinish_Implementation(GSDispLib_PostProcessContext Context)
	{
		if (Context != null && Context.PostProcessVolume != null && !Context.PostProcessVolume.IsPendingKill)
		{
			UGSE_PostProcessFuncLib.RemovePPVWeightBlendable(Context.PostProcessVolume, MaterialInstDynamic);
		}
	}

	[BlueprintEvent]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessActor:OnAlreadyBegin")]
	public unsafe void OnAlreadyBegin(GSDispLib_PostProcessContext Context)
	{
		CheckDestroyed();
		if (!OnAlreadyBegin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:OnAlreadyBegin");
			return;
		}
		if (OnAlreadyBegin_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnAlreadyBegin_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnAlreadyBegin");
		}
		byte* value = stackalloc byte[(int)(uint)OnAlreadyBegin_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnAlreadyBegin_ParamsSize);
		UObjectMarshaler<GSDispLib_PostProcessContext>.ToNative(IntPtr.Add(intPtr, OnAlreadyBegin_Context_Offset), Context);
		NativeReflection.InvokeFunction(base.Address, OnAlreadyBegin_InstanceFunctionAddressInstance, intPtr, OnAlreadyBegin_ParamsSize);
	}

	public virtual void OnAlreadyBegin_Implementation(GSDispLib_PostProcessContext Context)
	{
		if (Context != null && Context.PostProcessVolume != null && !Context.PostProcessVolume.IsPendingKill && MaterialInstDynamic != null)
		{
			if (PPContext.PostProcessVolume != null)
			{
				UGSE_PostProcessFuncLib.RemovePPVWeightBlendable(PPContext.PostProcessVolume, MaterialInstDynamic);
			}
			UGSE_PostProcessFuncLib.SetPPVWeightedBlendableWeight(Context.PostProcessVolume, MaterialInstDynamic, 1f);
		}
		PPContext = Context;
	}

	[UFunction]
	[BlueprintCallable]
	[BlueprintEvent]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessActor:OnAlreadyFinish")]
	public unsafe void OnAlreadyFinish(GSDispLib_PostProcessContext Context)
	{
		CheckDestroyed();
		if (!OnAlreadyFinish_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.GSDispLib_PostProcessActor:OnAlreadyFinish");
			return;
		}
		if (OnAlreadyFinish_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnAlreadyFinish_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnAlreadyFinish");
		}
		byte* value = stackalloc byte[(int)(uint)OnAlreadyFinish_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnAlreadyFinish_ParamsSize);
		UObjectMarshaler<GSDispLib_PostProcessContext>.ToNative(IntPtr.Add(intPtr, OnAlreadyFinish_Context_Offset), Context);
		NativeReflection.InvokeFunction(base.Address, OnAlreadyFinish_InstanceFunctionAddressInstance, intPtr, OnAlreadyFinish_ParamsSize);
	}

	public virtual void OnAlreadyFinish_Implementation(GSDispLib_PostProcessContext Context)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.GSDispLib_PostProcessActor:OnInit")]
	private static void OnInit__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib_PostProcessActor gSDispLib_PostProcessActor = GCHelper.Find<GSDispLib_PostProcessActor>(obj);
		GSDispLib_PostProcessContext context = UObjectMarshaler<GSDispLib_PostProcessContext>.FromNative(IntPtr.Add(buffer, OnInit_Context_Offset));
		UDispLib_PostPorcessCommonConf conf = UDispLib_PostPorcessCommonConf.FromNative(IntPtr.Add(buffer, OnInit_Conf_Offset));
		gSDispLib_PostProcessActor.OnInit_Implementation(context, conf);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEndBegin")]
	private static void OnEndBegin__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib_PostProcessActor gSDispLib_PostProcessActor = GCHelper.Find<GSDispLib_PostProcessActor>(obj);
		GSDispLib_PostProcessContext context = UObjectMarshaler<GSDispLib_PostProcessContext>.FromNative(IntPtr.Add(buffer, OnEndBegin_Context_Offset));
		gSDispLib_PostProcessActor.OnEndBegin_Implementation(context);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEndFinish")]
	private static void OnEndFinish__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib_PostProcessActor gSDispLib_PostProcessActor = GCHelper.Find<GSDispLib_PostProcessActor>(obj);
		GSDispLib_PostProcessContext context = UObjectMarshaler<GSDispLib_PostProcessContext>.FromNative(IntPtr.Add(buffer, OnEndFinish_Context_Offset));
		gSDispLib_PostProcessActor.OnEndFinish_Implementation(context);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEffectTick")]
	private static void OnEffectTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib_PostProcessActor gSDispLib_PostProcessActor = GCHelper.Find<GSDispLib_PostProcessActor>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OnEffectTick_DeltaTime_Offset));
		float progress = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OnEffectTick_Progress_Offset));
		GSDispLib_PostProcessContext context = UObjectMarshaler<GSDispLib_PostProcessContext>.FromNative(IntPtr.Add(buffer, OnEffectTick_Context_Offset));
		gSDispLib_PostProcessActor.OnEffectTick_Implementation(deltaTime, progress, context);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEnterBegin")]
	private static void OnEnterBegin__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib_PostProcessActor gSDispLib_PostProcessActor = GCHelper.Find<GSDispLib_PostProcessActor>(obj);
		GSDispLib_PostProcessContext context = UObjectMarshaler<GSDispLib_PostProcessContext>.FromNative(IntPtr.Add(buffer, OnEnterBegin_Context_Offset));
		gSDispLib_PostProcessActor.OnEnterBegin_Implementation(context);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEnterFinish")]
	private static void OnEnterFinish__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib_PostProcessActor gSDispLib_PostProcessActor = GCHelper.Find<GSDispLib_PostProcessActor>(obj);
		GSDispLib_PostProcessContext context = UObjectMarshaler<GSDispLib_PostProcessContext>.FromNative(IntPtr.Add(buffer, OnEnterFinish_Context_Offset));
		gSDispLib_PostProcessActor.OnEnterFinish_Implementation(context);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSDispLib_PostProcessActor:OnAlreadyBegin")]
	private static void OnAlreadyBegin__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib_PostProcessActor gSDispLib_PostProcessActor = GCHelper.Find<GSDispLib_PostProcessActor>(obj);
		GSDispLib_PostProcessContext context = UObjectMarshaler<GSDispLib_PostProcessContext>.FromNative(IntPtr.Add(buffer, OnAlreadyBegin_Context_Offset));
		gSDispLib_PostProcessActor.OnAlreadyBegin_Implementation(context);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSDispLib_PostProcessActor:OnAlreadyFinish")]
	private static void OnAlreadyFinish__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib_PostProcessActor gSDispLib_PostProcessActor = GCHelper.Find<GSDispLib_PostProcessActor>(obj);
		GSDispLib_PostProcessContext context = UObjectMarshaler<GSDispLib_PostProcessContext>.FromNative(IntPtr.Add(buffer, OnAlreadyFinish_Context_Offset));
		gSDispLib_PostProcessActor.OnAlreadyFinish_Implementation(context);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSDispLib_PostProcessActor");
		MaterialPrototype_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaterialPrototype");
		MaterialPrototype_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaterialPrototype", Classes.FObjectProperty);
		MaterialInstDynamic_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaterialInstDynamic");
		MaterialInstDynamic_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaterialInstDynamic", Classes.FObjectProperty);
		PPContext_Offset = NativeReflection.GetPropertyOffset(intPtr, "PPContext");
		PPContext_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PPContext", Classes.FObjectProperty);
		PPConf_Offset = NativeReflection.GetPropertyOffset(intPtr, "PPConf");
		PPConf_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PPConf", Classes.FStructProperty);
		Progress_Offset = NativeReflection.GetPropertyOffset(intPtr, "Progress");
		Progress_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Progress", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IsAutoPlay_PropertyAddress, intPtr, "IsAutoPlay");
		IsAutoPlay_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsAutoPlay");
		IsAutoPlay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsAutoPlay", Classes.FBoolProperty);
		Parameters_Offset = NativeReflection.GetPropertyOffset(intPtr, "Parameters");
		Parameters_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Parameters", Classes.FObjectProperty);
		EffectID_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectID");
		EffectID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectID", Classes.FIntProperty);
		OnInit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnInit");
		OnInit_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInit_FunctionAddress);
		OnInit_Context_Offset = NativeReflection.GetPropertyOffset(OnInit_FunctionAddress, "Context");
		OnInit_Context_IsValid = NativeReflection.ValidatePropertyClass(OnInit_FunctionAddress, "Context", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref OnInit_Conf_PropertyAddress, OnInit_FunctionAddress, "Conf");
		OnInit_Conf_Offset = NativeReflection.GetPropertyOffset(OnInit_FunctionAddress, "Conf");
		OnInit_Conf_IsValid = NativeReflection.ValidatePropertyClass(OnInit_FunctionAddress, "Conf", Classes.FStructProperty);
		OnInit_IsValid = OnInit_FunctionAddress != IntPtr.Zero && OnInit_Context_IsValid && OnInit_Conf_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSDispLib_PostProcessActor:OnInit", OnInit_IsValid);
		OnEndBegin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnEndBegin");
		OnEndBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEndBegin_FunctionAddress);
		OnEndBegin_Context_Offset = NativeReflection.GetPropertyOffset(OnEndBegin_FunctionAddress, "Context");
		OnEndBegin_Context_IsValid = NativeReflection.ValidatePropertyClass(OnEndBegin_FunctionAddress, "Context", Classes.FObjectProperty);
		OnEndBegin_IsValid = OnEndBegin_FunctionAddress != IntPtr.Zero && OnEndBegin_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEndBegin", OnEndBegin_IsValid);
		OnEndFinish_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnEndFinish");
		OnEndFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEndFinish_FunctionAddress);
		OnEndFinish_Context_Offset = NativeReflection.GetPropertyOffset(OnEndFinish_FunctionAddress, "Context");
		OnEndFinish_Context_IsValid = NativeReflection.ValidatePropertyClass(OnEndFinish_FunctionAddress, "Context", Classes.FObjectProperty);
		OnEndFinish_IsValid = OnEndFinish_FunctionAddress != IntPtr.Zero && OnEndFinish_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEndFinish", OnEndFinish_IsValid);
		OnEffectTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnEffectTick");
		OnEffectTick_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEffectTick_FunctionAddress);
		OnEffectTick_DeltaTime_Offset = NativeReflection.GetPropertyOffset(OnEffectTick_FunctionAddress, "DeltaTime");
		OnEffectTick_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(OnEffectTick_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		OnEffectTick_Progress_Offset = NativeReflection.GetPropertyOffset(OnEffectTick_FunctionAddress, "Progress");
		OnEffectTick_Progress_IsValid = NativeReflection.ValidatePropertyClass(OnEffectTick_FunctionAddress, "Progress", Classes.FFloatProperty);
		OnEffectTick_Context_Offset = NativeReflection.GetPropertyOffset(OnEffectTick_FunctionAddress, "Context");
		OnEffectTick_Context_IsValid = NativeReflection.ValidatePropertyClass(OnEffectTick_FunctionAddress, "Context", Classes.FObjectProperty);
		OnEffectTick_IsValid = OnEffectTick_FunctionAddress != IntPtr.Zero && OnEffectTick_DeltaTime_IsValid && OnEffectTick_Progress_IsValid && OnEffectTick_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEffectTick", OnEffectTick_IsValid);
		OnEnterBegin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnEnterBegin");
		OnEnterBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEnterBegin_FunctionAddress);
		OnEnterBegin_Context_Offset = NativeReflection.GetPropertyOffset(OnEnterBegin_FunctionAddress, "Context");
		OnEnterBegin_Context_IsValid = NativeReflection.ValidatePropertyClass(OnEnterBegin_FunctionAddress, "Context", Classes.FObjectProperty);
		OnEnterBegin_IsValid = OnEnterBegin_FunctionAddress != IntPtr.Zero && OnEnterBegin_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEnterBegin", OnEnterBegin_IsValid);
		OnEnterFinish_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnEnterFinish");
		OnEnterFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEnterFinish_FunctionAddress);
		OnEnterFinish_Context_Offset = NativeReflection.GetPropertyOffset(OnEnterFinish_FunctionAddress, "Context");
		OnEnterFinish_Context_IsValid = NativeReflection.ValidatePropertyClass(OnEnterFinish_FunctionAddress, "Context", Classes.FObjectProperty);
		OnEnterFinish_IsValid = OnEnterFinish_FunctionAddress != IntPtr.Zero && OnEnterFinish_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSDispLib_PostProcessActor:OnEnterFinish", OnEnterFinish_IsValid);
		OnAlreadyBegin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAlreadyBegin");
		OnAlreadyBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAlreadyBegin_FunctionAddress);
		OnAlreadyBegin_Context_Offset = NativeReflection.GetPropertyOffset(OnAlreadyBegin_FunctionAddress, "Context");
		OnAlreadyBegin_Context_IsValid = NativeReflection.ValidatePropertyClass(OnAlreadyBegin_FunctionAddress, "Context", Classes.FObjectProperty);
		OnAlreadyBegin_IsValid = OnAlreadyBegin_FunctionAddress != IntPtr.Zero && OnAlreadyBegin_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSDispLib_PostProcessActor:OnAlreadyBegin", OnAlreadyBegin_IsValid);
		OnAlreadyFinish_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAlreadyFinish");
		OnAlreadyFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAlreadyFinish_FunctionAddress);
		OnAlreadyFinish_Context_Offset = NativeReflection.GetPropertyOffset(OnAlreadyFinish_FunctionAddress, "Context");
		OnAlreadyFinish_Context_IsValid = NativeReflection.ValidatePropertyClass(OnAlreadyFinish_FunctionAddress, "Context", Classes.FObjectProperty);
		OnAlreadyFinish_IsValid = OnAlreadyFinish_FunctionAddress != IntPtr.Zero && OnAlreadyFinish_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSDispLib_PostProcessActor:OnAlreadyFinish", OnAlreadyFinish_IsValid);
	}

	static GSDispLib_PostProcessActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDispLib_PostProcessActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDispLib_PostProcessActor));
	}
}
