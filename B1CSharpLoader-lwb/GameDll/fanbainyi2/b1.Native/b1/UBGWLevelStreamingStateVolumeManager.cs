using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWLevelStreamingStateVolumeManager", "b1", UnrealModuleType.Game)]
public class UBGWLevelStreamingStateVolumeManager : UObject
{
	[UDelegate]
	[UMetaPath("/Script/b1.BGWLevelStreamingStateVolumeManager:OnRequestUpdateLevelState__DelegateSignature")]
	public class FOnRequestUpdateLevelState : FMulticastDelegate<FOnRequestUpdateLevelState.Signature>
	{
		public delegate void Signature();

		private static bool OnRequestUpdateLevelState__DelegateSignature_IsValid;

		private static IntPtr OnRequestUpdateLevelState__DelegateSignature_FunctionAddress;

		private static int OnRequestUpdateLevelState__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnRequestUpdateLevelState()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnRequestUpdateLevelState__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.BGWLevelStreamingStateVolumeManager:OnRequestUpdateLevelState__DelegateSignature");
			OnRequestUpdateLevelState__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRequestUpdateLevelState__DelegateSignature_FunctionAddress);
			OnRequestUpdateLevelState__DelegateSignature_IsValid = OnRequestUpdateLevelState__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/b1.BGWLevelStreamingStateVolumeManager:OnRequestUpdateLevelState__DelegateSignature", OnRequestUpdateLevelState__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!OnRequestUpdateLevelState__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWLevelStreamingStateVolumeManager:OnRequestUpdateLevelState__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnRequestUpdateLevelState__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRequestUpdateLevelState__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	private static IntPtr classAddress;

	private static bool OnRequestUpdateLevelState_IsValid;

	private static int OnRequestUpdateLevelState_Offset;

	private FOnRequestUpdateLevelState OnRequestUpdateLevelState_DelegateCached;

	private static bool CurrentActiveVolumes_IsValid;

	private static FFieldAddress CurrentActiveVolumes_PropertyAddress;

	private static int CurrentActiveVolumes_Offset;

	private TArrayReadOnlyMarshaler<string> CurrentActiveVolumes_MarshalerCached;

	private static bool UpdateCurrentActiveVolumes_IsValid;

	private static IntPtr UpdateCurrentActiveVolumes_FunctionAddress;

	private static int UpdateCurrentActiveVolumes_ParamsSize;

	private static bool Get_IsValid;

	private static IntPtr Get_FunctionAddress;

	private static int Get_ParamsSize;

	private static bool Get_WorldContext_IsValid;

	private static FFieldAddress Get_WorldContext_PropertyAddress;

	private static int Get_WorldContext_Offset;

	private static bool Get_ReturnValue_IsValid;

	private static FFieldAddress Get_ReturnValue_PropertyAddress;

	private static int Get_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/b1.BGWLevelStreamingStateVolumeManager:OnRequestUpdateLevelState")]
	public FOnRequestUpdateLevelState OnRequestUpdateLevelState
	{
		get
		{
			CheckDestroyed();
			if (!OnRequestUpdateLevelState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWLevelStreamingStateVolumeManager:OnRequestUpdateLevelState");
				return new FOnRequestUpdateLevelState();
			}
			if (OnRequestUpdateLevelState_DelegateCached == null)
			{
				OnRequestUpdateLevelState_DelegateCached = new FOnRequestUpdateLevelState();
				OnRequestUpdateLevelState_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnRequestUpdateLevelState_Offset));
			}
			return OnRequestUpdateLevelState_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599627510293uL)]
	[UMetaPath("/Script/b1.BGWLevelStreamingStateVolumeManager:CurrentActiveVolumes")]
	public TArrayReadOnly<string> CurrentActiveVolumes
	{
		get
		{
			CheckDestroyed();
			if (!CurrentActiveVolumes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWLevelStreamingStateVolumeManager:CurrentActiveVolumes");
				return null;
			}
			if (CurrentActiveVolumes_MarshalerCached == null)
			{
				CurrentActiveVolumes_MarshalerCached = new TArrayReadOnlyMarshaler<string>(1, CurrentActiveVolumes_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return CurrentActiveVolumes_MarshalerCached.FromNative(IntPtr.Add(base.Address, CurrentActiveVolumes_Offset));
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWLevelStreamingStateVolumeManager:UpdateCurrentActiveVolumes")]
	public unsafe void UpdateCurrentActiveVolumes()
	{
		CheckDestroyed();
		if (!UpdateCurrentActiveVolumes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWLevelStreamingStateVolumeManager:UpdateCurrentActiveVolumes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateCurrentActiveVolumes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateCurrentActiveVolumes_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateCurrentActiveVolumes_FunctionAddress, argsSize: UpdateCurrentActiveVolumes_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGWLevelStreamingStateVolumeManager:Get")]
	public unsafe static UBGWLevelStreamingStateVolumeManager Get(UObject WorldContext)
	{
		if (!Get_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWLevelStreamingStateVolumeManager:Get");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Get_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Get_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, Get_WorldContext_Offset), 0, Get_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Get_FunctionAddress, intPtr, Get_ParamsSize);
		return UObjectMarshaler<UBGWLevelStreamingStateVolumeManager>.FromNative(IntPtr.Add(intPtr, Get_ReturnValue_Offset), 0, Get_ReturnValue_PropertyAddress.Address);
	}

	static UBGWLevelStreamingStateVolumeManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWLevelStreamingStateVolumeManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWLevelStreamingStateVolumeManager));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGWLevelStreamingStateVolumeManager");
		OnRequestUpdateLevelState_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnRequestUpdateLevelState");
		OnRequestUpdateLevelState_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnRequestUpdateLevelState", Classes.FMulticastDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref CurrentActiveVolumes_PropertyAddress, classAddress, "CurrentActiveVolumes");
		CurrentActiveVolumes_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "CurrentActiveVolumes");
		CurrentActiveVolumes_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "CurrentActiveVolumes", Classes.FArrayProperty);
		UpdateCurrentActiveVolumes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UpdateCurrentActiveVolumes");
		UpdateCurrentActiveVolumes_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateCurrentActiveVolumes_FunctionAddress);
		UpdateCurrentActiveVolumes_IsValid = UpdateCurrentActiveVolumes_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWLevelStreamingStateVolumeManager:UpdateCurrentActiveVolumes", UpdateCurrentActiveVolumes_IsValid);
		Get_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Get");
		Get_ParamsSize = NativeReflection.GetFunctionParamsSize(Get_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Get_WorldContext_PropertyAddress, Get_FunctionAddress, "WorldContext");
		Get_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(Get_FunctionAddress, "WorldContext");
		Get_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(Get_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Get_ReturnValue_PropertyAddress, Get_FunctionAddress, "ReturnValue");
		Get_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Get_FunctionAddress, "ReturnValue");
		Get_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Get_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Get_IsValid = Get_FunctionAddress != IntPtr.Zero && Get_WorldContext_IsValid && Get_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWLevelStreamingStateVolumeManager:Get", Get_IsValid);
	}
}
