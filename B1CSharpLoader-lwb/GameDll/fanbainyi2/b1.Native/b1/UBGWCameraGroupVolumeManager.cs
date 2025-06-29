using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWCameraGroupVolumeManager", "b1", UnrealModuleType.Game)]
public class UBGWCameraGroupVolumeManager : UBGWVolumeManagerBase
{
	[UDelegate]
	[UMetaPath("/Script/b1.BGWCameraGroupVolumeManager:OnSwitchCameraGroupTo__DelegateSignature")]
	public class FOnSwitchCameraGroupTo : FMulticastDelegate<FOnSwitchCameraGroupTo.Signature>
	{
		public delegate void Signature(int TargetCameraGroupId, float Alpha, float BlendTime);

		private static bool OnSwitchCameraGroupTo__DelegateSignature_IsValid;

		private static IntPtr OnSwitchCameraGroupTo__DelegateSignature_FunctionAddress;

		private static int OnSwitchCameraGroupTo__DelegateSignature_ParamsSize;

		private static bool OnSwitchCameraGroupTo__DelegateSignature_TargetCameraGroupId_IsValid;

		private static FFieldAddress OnSwitchCameraGroupTo__DelegateSignature_TargetCameraGroupId_PropertyAddress;

		private static int OnSwitchCameraGroupTo__DelegateSignature_TargetCameraGroupId_Offset;

		private static bool OnSwitchCameraGroupTo__DelegateSignature_Alpha_IsValid;

		private static FFieldAddress OnSwitchCameraGroupTo__DelegateSignature_Alpha_PropertyAddress;

		private static int OnSwitchCameraGroupTo__DelegateSignature_Alpha_Offset;

		private static bool OnSwitchCameraGroupTo__DelegateSignature_BlendTime_IsValid;

		private static FFieldAddress OnSwitchCameraGroupTo__DelegateSignature_BlendTime_PropertyAddress;

		private static int OnSwitchCameraGroupTo__DelegateSignature_BlendTime_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnSwitchCameraGroupTo()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnSwitchCameraGroupTo__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.BGWCameraGroupVolumeManager:OnSwitchCameraGroupTo__DelegateSignature");
			OnSwitchCameraGroupTo__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSwitchCameraGroupTo__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnSwitchCameraGroupTo__DelegateSignature_TargetCameraGroupId_PropertyAddress, OnSwitchCameraGroupTo__DelegateSignature_FunctionAddress, "TargetCameraGroupId");
			OnSwitchCameraGroupTo__DelegateSignature_TargetCameraGroupId_Offset = NativeReflectionCached.GetPropertyOffset(OnSwitchCameraGroupTo__DelegateSignature_FunctionAddress, "TargetCameraGroupId");
			OnSwitchCameraGroupTo__DelegateSignature_TargetCameraGroupId_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSwitchCameraGroupTo__DelegateSignature_FunctionAddress, "TargetCameraGroupId", Classes.FIntProperty);
			NativeReflectionCached.GetPropertyRef(ref OnSwitchCameraGroupTo__DelegateSignature_Alpha_PropertyAddress, OnSwitchCameraGroupTo__DelegateSignature_FunctionAddress, "Alpha");
			OnSwitchCameraGroupTo__DelegateSignature_Alpha_Offset = NativeReflectionCached.GetPropertyOffset(OnSwitchCameraGroupTo__DelegateSignature_FunctionAddress, "Alpha");
			OnSwitchCameraGroupTo__DelegateSignature_Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSwitchCameraGroupTo__DelegateSignature_FunctionAddress, "Alpha", Classes.FFloatProperty);
			NativeReflectionCached.GetPropertyRef(ref OnSwitchCameraGroupTo__DelegateSignature_BlendTime_PropertyAddress, OnSwitchCameraGroupTo__DelegateSignature_FunctionAddress, "BlendTime");
			OnSwitchCameraGroupTo__DelegateSignature_BlendTime_Offset = NativeReflectionCached.GetPropertyOffset(OnSwitchCameraGroupTo__DelegateSignature_FunctionAddress, "BlendTime");
			OnSwitchCameraGroupTo__DelegateSignature_BlendTime_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSwitchCameraGroupTo__DelegateSignature_FunctionAddress, "BlendTime", Classes.FFloatProperty);
			OnSwitchCameraGroupTo__DelegateSignature_IsValid = OnSwitchCameraGroupTo__DelegateSignature_FunctionAddress != IntPtr.Zero && OnSwitchCameraGroupTo__DelegateSignature_TargetCameraGroupId_IsValid && OnSwitchCameraGroupTo__DelegateSignature_Alpha_IsValid && OnSwitchCameraGroupTo__DelegateSignature_BlendTime_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1.BGWCameraGroupVolumeManager:OnSwitchCameraGroupTo__DelegateSignature", OnSwitchCameraGroupTo__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(int TargetCameraGroupId, float Alpha, float BlendTime)
		{
			if (!OnSwitchCameraGroupTo__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWCameraGroupVolumeManager:OnSwitchCameraGroupTo__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnSwitchCameraGroupTo__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSwitchCameraGroupTo__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnSwitchCameraGroupTo__DelegateSignature_TargetCameraGroupId_Offset), 0, OnSwitchCameraGroupTo__DelegateSignature_TargetCameraGroupId_PropertyAddress.Address, TargetCameraGroupId);
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnSwitchCameraGroupTo__DelegateSignature_Alpha_Offset), 0, OnSwitchCameraGroupTo__DelegateSignature_Alpha_PropertyAddress.Address, Alpha);
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnSwitchCameraGroupTo__DelegateSignature_BlendTime_Offset), 0, OnSwitchCameraGroupTo__DelegateSignature_BlendTime_PropertyAddress.Address, BlendTime);
				ProcessDelegate(intPtr);
			}
		}
	}

	private static IntPtr classAddress;

	private static bool OnSwitchCameraGroupTo_IsValid;

	private static int OnSwitchCameraGroupTo_Offset;

	private FOnSwitchCameraGroupTo OnSwitchCameraGroupTo_DelegateCached;

	private static bool EnableCameraGroupManager_IsValid;

	private static FFieldAddress EnableCameraGroupManager_PropertyAddress;

	private static int EnableCameraGroupManager_Offset;

	private static bool TickIntervalMs_IsValid;

	private static int TickIntervalMs_Offset;

	private static bool LastFrameTargetGroupId_IsValid;

	private static int LastFrameTargetGroupId_Offset;

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
	[UMetaPath("/Script/b1.BGWCameraGroupVolumeManager:OnSwitchCameraGroupTo")]
	public FOnSwitchCameraGroupTo OnSwitchCameraGroupTo
	{
		get
		{
			CheckDestroyed();
			if (!OnSwitchCameraGroupTo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWCameraGroupVolumeManager:OnSwitchCameraGroupTo");
				return new FOnSwitchCameraGroupTo();
			}
			if (OnSwitchCameraGroupTo_DelegateCached == null)
			{
				OnSwitchCameraGroupTo_DelegateCached = new FOnSwitchCameraGroupTo();
				OnSwitchCameraGroupTo_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnSwitchCameraGroupTo_Offset));
			}
			return OnSwitchCameraGroupTo_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGWCameraGroupVolumeManager:bEnableCameraGroupManager")]
	public bool EnableCameraGroupManager
	{
		get
		{
			CheckDestroyed();
			if (!EnableCameraGroupManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWCameraGroupVolumeManager:bEnableCameraGroupManager");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableCameraGroupManager_Offset), 0, EnableCameraGroupManager_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableCameraGroupManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWCameraGroupVolumeManager:bEnableCameraGroupManager");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableCameraGroupManager_Offset), 0, EnableCameraGroupManager_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGWCameraGroupVolumeManager:TickIntervalMs")]
	public int TickIntervalMs
	{
		get
		{
			CheckDestroyed();
			if (!TickIntervalMs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWCameraGroupVolumeManager:TickIntervalMs");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TickIntervalMs_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TickIntervalMs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWCameraGroupVolumeManager:TickIntervalMs");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TickIntervalMs_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234414101uL)]
	[UMetaPath("/Script/b1.BGWCameraGroupVolumeManager:LastFrameTargetGroupId")]
	public int LastFrameTargetGroupId
	{
		get
		{
			CheckDestroyed();
			if (!LastFrameTargetGroupId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWCameraGroupVolumeManager:LastFrameTargetGroupId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LastFrameTargetGroupId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LastFrameTargetGroupId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWCameraGroupVolumeManager:LastFrameTargetGroupId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LastFrameTargetGroupId_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGWCameraGroupVolumeManager:Get")]
	public unsafe static UBGWCameraGroupVolumeManager Get(UObject WorldContext)
	{
		if (!Get_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWCameraGroupVolumeManager:Get");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Get_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Get_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, Get_WorldContext_Offset), 0, Get_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Get_FunctionAddress, intPtr, Get_ParamsSize);
		return UObjectMarshaler<UBGWCameraGroupVolumeManager>.FromNative(IntPtr.Add(intPtr, Get_ReturnValue_Offset), 0, Get_ReturnValue_PropertyAddress.Address);
	}

	static UBGWCameraGroupVolumeManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWCameraGroupVolumeManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWCameraGroupVolumeManager));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGWCameraGroupVolumeManager");
		OnSwitchCameraGroupTo_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnSwitchCameraGroupTo");
		OnSwitchCameraGroupTo_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnSwitchCameraGroupTo", Classes.FMulticastDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableCameraGroupManager_PropertyAddress, classAddress, "bEnableCameraGroupManager");
		EnableCameraGroupManager_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "bEnableCameraGroupManager");
		EnableCameraGroupManager_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "bEnableCameraGroupManager", Classes.FBoolProperty);
		TickIntervalMs_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "TickIntervalMs");
		TickIntervalMs_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "TickIntervalMs", Classes.FIntProperty);
		LastFrameTargetGroupId_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "LastFrameTargetGroupId");
		LastFrameTargetGroupId_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "LastFrameTargetGroupId", Classes.FIntProperty);
		Get_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Get");
		Get_ParamsSize = NativeReflection.GetFunctionParamsSize(Get_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Get_WorldContext_PropertyAddress, Get_FunctionAddress, "WorldContext");
		Get_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(Get_FunctionAddress, "WorldContext");
		Get_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(Get_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Get_ReturnValue_PropertyAddress, Get_FunctionAddress, "ReturnValue");
		Get_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Get_FunctionAddress, "ReturnValue");
		Get_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Get_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Get_IsValid = Get_FunctionAddress != IntPtr.Zero && Get_WorldContext_IsValid && Get_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWCameraGroupVolumeManager:Get", Get_IsValid);
	}
}
