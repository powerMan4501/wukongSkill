using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptEditor.JavascriptScrubControlPanel", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptScrubControlPanel : UWidget
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptScrubControlPanel:SetPlaybackPosition__DelegateSignature")]
	public class FSetPlaybackPosition : FMulticastDelegate<FSetPlaybackPosition.Signature>
	{
		public delegate void Signature();

		private static bool SetPlaybackPosition__DelegateSignature_IsValid;

		private static IntPtr SetPlaybackPosition__DelegateSignature_FunctionAddress;

		private static int SetPlaybackPosition__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FSetPlaybackPosition()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			SetPlaybackPosition__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptScrubControlPanel:SetPlaybackPosition__DelegateSignature");
			SetPlaybackPosition__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaybackPosition__DelegateSignature_FunctionAddress);
			SetPlaybackPosition__DelegateSignature_IsValid = SetPlaybackPosition__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptScrubControlPanel:SetPlaybackPosition__DelegateSignature", SetPlaybackPosition__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!SetPlaybackPosition__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptScrubControlPanel:SetPlaybackPosition__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(SetPlaybackPosition__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaybackPosition__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_ToggleLoop__DelegateSignature")]
	public class FOnClick_ToggleLoop : FMulticastDelegate<FOnClick_ToggleLoop.Signature>
	{
		public delegate void Signature();

		private static bool OnClick_ToggleLoop__DelegateSignature_IsValid;

		private static IntPtr OnClick_ToggleLoop__DelegateSignature_FunctionAddress;

		private static int OnClick_ToggleLoop__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnClick_ToggleLoop()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnClick_ToggleLoop__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_ToggleLoop__DelegateSignature");
			OnClick_ToggleLoop__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClick_ToggleLoop__DelegateSignature_FunctionAddress);
			OnClick_ToggleLoop__DelegateSignature_IsValid = OnClick_ToggleLoop__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_ToggleLoop__DelegateSignature", OnClick_ToggleLoop__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!OnClick_ToggleLoop__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_ToggleLoop__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnClick_ToggleLoop__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnClick_ToggleLoop__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Forward_Step__DelegateSignature")]
	public class FOnClick_Forward_Step : FMulticastDelegate<FOnClick_Forward_Step.Signature>
	{
		public delegate void Signature();

		private static bool OnClick_Forward_Step__DelegateSignature_IsValid;

		private static IntPtr OnClick_Forward_Step__DelegateSignature_FunctionAddress;

		private static int OnClick_Forward_Step__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnClick_Forward_Step()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnClick_Forward_Step__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Forward_Step__DelegateSignature");
			OnClick_Forward_Step__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClick_Forward_Step__DelegateSignature_FunctionAddress);
			OnClick_Forward_Step__DelegateSignature_IsValid = OnClick_Forward_Step__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Forward_Step__DelegateSignature", OnClick_Forward_Step__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!OnClick_Forward_Step__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Forward_Step__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnClick_Forward_Step__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnClick_Forward_Step__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Forward_End__DelegateSignature")]
	public class FOnClick_Forward_End : FMulticastDelegate<FOnClick_Forward_End.Signature>
	{
		public delegate void Signature();

		private static bool OnClick_Forward_End__DelegateSignature_IsValid;

		private static IntPtr OnClick_Forward_End__DelegateSignature_FunctionAddress;

		private static int OnClick_Forward_End__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnClick_Forward_End()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnClick_Forward_End__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Forward_End__DelegateSignature");
			OnClick_Forward_End__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClick_Forward_End__DelegateSignature_FunctionAddress);
			OnClick_Forward_End__DelegateSignature_IsValid = OnClick_Forward_End__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Forward_End__DelegateSignature", OnClick_Forward_End__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!OnClick_Forward_End__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Forward_End__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnClick_Forward_End__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnClick_Forward_End__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Forward__DelegateSignature")]
	public class FOnClick_Forward : FMulticastDelegate<FOnClick_Forward.Signature>
	{
		public delegate void Signature();

		private static bool OnClick_Forward__DelegateSignature_IsValid;

		private static IntPtr OnClick_Forward__DelegateSignature_FunctionAddress;

		private static int OnClick_Forward__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnClick_Forward()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnClick_Forward__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Forward__DelegateSignature");
			OnClick_Forward__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClick_Forward__DelegateSignature_FunctionAddress);
			OnClick_Forward__DelegateSignature_IsValid = OnClick_Forward__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Forward__DelegateSignature", OnClick_Forward__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!OnClick_Forward__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Forward__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnClick_Forward__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnClick_Forward__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Backward_Step__DelegateSignature")]
	public class FOnClick_Backward_Step : FMulticastDelegate<FOnClick_Backward_Step.Signature>
	{
		public delegate void Signature();

		private static bool OnClick_Backward_Step__DelegateSignature_IsValid;

		private static IntPtr OnClick_Backward_Step__DelegateSignature_FunctionAddress;

		private static int OnClick_Backward_Step__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnClick_Backward_Step()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnClick_Backward_Step__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Backward_Step__DelegateSignature");
			OnClick_Backward_Step__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClick_Backward_Step__DelegateSignature_FunctionAddress);
			OnClick_Backward_Step__DelegateSignature_IsValid = OnClick_Backward_Step__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Backward_Step__DelegateSignature", OnClick_Backward_Step__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!OnClick_Backward_Step__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Backward_Step__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnClick_Backward_Step__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnClick_Backward_Step__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Backward_End__DelegateSignature")]
	public class FOnClick_Backward_End : FMulticastDelegate<FOnClick_Backward_End.Signature>
	{
		public delegate void Signature();

		private static bool OnClick_Backward_End__DelegateSignature_IsValid;

		private static IntPtr OnClick_Backward_End__DelegateSignature_FunctionAddress;

		private static int OnClick_Backward_End__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnClick_Backward_End()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnClick_Backward_End__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Backward_End__DelegateSignature");
			OnClick_Backward_End__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClick_Backward_End__DelegateSignature_FunctionAddress);
			OnClick_Backward_End__DelegateSignature_IsValid = OnClick_Backward_End__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Backward_End__DelegateSignature", OnClick_Backward_End__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!OnClick_Backward_End__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Backward_End__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnClick_Backward_End__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnClick_Backward_End__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Backward__DelegateSignature")]
	public class FOnClick_Backward : FMulticastDelegate<FOnClick_Backward.Signature>
	{
		public delegate void Signature();

		private static bool OnClick_Backward__DelegateSignature_IsValid;

		private static IntPtr OnClick_Backward__DelegateSignature_FunctionAddress;

		private static int OnClick_Backward__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnClick_Backward()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnClick_Backward__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Backward__DelegateSignature");
			OnClick_Backward__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClick_Backward__DelegateSignature_FunctionAddress);
			OnClick_Backward__DelegateSignature_IsValid = OnClick_Backward__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Backward__DelegateSignature", OnClick_Backward__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!OnClick_Backward__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptScrubControlPanel:OnClick_Backward__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnClick_Backward__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnClick_Backward__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	private static bool SetSumFrames_IsValid;

	private static IntPtr SetSumFrames_FunctionAddress;

	private static int SetSumFrames_ParamsSize;

	private static bool SetSumFrames_NewSumFrames_IsValid;

	private static FFieldAddress SetSumFrames_NewSumFrames_PropertyAddress;

	private static int SetSumFrames_NewSumFrames_Offset;

	private static bool SetPlaybackPosition_IsValid;

	private static IntPtr SetPlaybackPosition_FunctionAddress;

	private static int SetPlaybackPosition_ParamsSize;

	private static bool SetPlaybackPosition_NewTime_IsValid;

	private static FFieldAddress SetPlaybackPosition_NewTime_PropertyAddress;

	private static int SetPlaybackPosition_NewTime_Offset;

	private static bool SetLooping_IsValid;

	private static IntPtr SetLooping_FunctionAddress;

	private static int SetLooping_ParamsSize;

	private static bool SetLooping_NewbLooping_IsValid;

	private static FFieldAddress SetLooping_NewbLooping_PropertyAddress;

	private static int SetLooping_NewbLooping_Offset;

	private static bool SetFramesPerSecond_IsValid;

	private static IntPtr SetFramesPerSecond_FunctionAddress;

	private static int SetFramesPerSecond_ParamsSize;

	private static bool SetFramesPerSecond_NewFramesPerSecond_IsValid;

	private static FFieldAddress SetFramesPerSecond_NewFramesPerSecond_PropertyAddress;

	private static int SetFramesPerSecond_NewFramesPerSecond_Offset;

	private static bool IsLooping_IsValid;

	private static IntPtr IsLooping_FunctionAddress;

	private static int IsLooping_ParamsSize;

	private static bool IsLooping_ReturnValue_IsValid;

	private static FFieldAddress IsLooping_ReturnValue_PropertyAddress;

	private static int IsLooping_ReturnValue_Offset;

	private static bool GetViewRangeMin_IsValid;

	private static IntPtr GetViewRangeMin_FunctionAddress;

	private static int GetViewRangeMin_ParamsSize;

	private static bool GetViewRangeMin_ReturnValue_IsValid;

	private static FFieldAddress GetViewRangeMin_ReturnValue_PropertyAddress;

	private static int GetViewRangeMin_ReturnValue_Offset;

	private static bool GetViewRangeMax_IsValid;

	private static IntPtr GetViewRangeMax_FunctionAddress;

	private static int GetViewRangeMax_ParamsSize;

	private static bool GetViewRangeMax_ReturnValue_IsValid;

	private static FFieldAddress GetViewRangeMax_ReturnValue_PropertyAddress;

	private static int GetViewRangeMax_ReturnValue_Offset;

	private static bool GetTotalSequenceLength_IsValid;

	private static IntPtr GetTotalSequenceLength_FunctionAddress;

	private static int GetTotalSequenceLength_ParamsSize;

	private static bool GetTotalSequenceLength_ReturnValue_IsValid;

	private static FFieldAddress GetTotalSequenceLength_ReturnValue_PropertyAddress;

	private static int GetTotalSequenceLength_ReturnValue_Offset;

	private static bool GetPlaybackPosition_IsValid;

	private static IntPtr GetPlaybackPosition_FunctionAddress;

	private static int GetPlaybackPosition_ParamsSize;

	private static bool GetPlaybackPosition_ReturnValue_IsValid;

	private static FFieldAddress GetPlaybackPosition_ReturnValue_PropertyAddress;

	private static int GetPlaybackPosition_ReturnValue_Offset;

	private static bool GetFramesPerSecond_IsValid;

	private static IntPtr GetFramesPerSecond_FunctionAddress;

	private static int GetFramesPerSecond_ParamsSize;

	private static bool GetFramesPerSecond_ReturnValue_IsValid;

	private static FFieldAddress GetFramesPerSecond_ReturnValue_PropertyAddress;

	private static int GetFramesPerSecond_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptScrubControlPanel:SetSumFrames")]
	public unsafe void SetSumFrames(float NewSumFrames)
	{
		CheckDestroyed();
		if (!SetSumFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptScrubControlPanel:SetSumFrames");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSumFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSumFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSumFrames_NewSumFrames_Offset), 0, SetSumFrames_NewSumFrames_PropertyAddress.Address, NewSumFrames);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSumFrames_FunctionAddress, intPtr, SetSumFrames_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptScrubControlPanel:SetPlaybackPosition")]
	public unsafe void SetPlaybackPosition(float NewTime)
	{
		CheckDestroyed();
		if (!SetPlaybackPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptScrubControlPanel:SetPlaybackPosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaybackPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaybackPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlaybackPosition_NewTime_Offset), 0, SetPlaybackPosition_NewTime_PropertyAddress.Address, NewTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlaybackPosition_FunctionAddress, intPtr, SetPlaybackPosition_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptScrubControlPanel:SetLooping")]
	public unsafe void SetLooping(bool NewbLooping)
	{
		CheckDestroyed();
		if (!SetLooping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptScrubControlPanel:SetLooping");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLooping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLooping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLooping_NewbLooping_Offset), 0, SetLooping_NewbLooping_PropertyAddress.Address, NewbLooping);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLooping_FunctionAddress, intPtr, SetLooping_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptScrubControlPanel:SetFramesPerSecond")]
	public unsafe void SetFramesPerSecond(float NewFramesPerSecond)
	{
		CheckDestroyed();
		if (!SetFramesPerSecond_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptScrubControlPanel:SetFramesPerSecond");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFramesPerSecond_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFramesPerSecond_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFramesPerSecond_NewFramesPerSecond_Offset), 0, SetFramesPerSecond_NewFramesPerSecond_PropertyAddress.Address, NewFramesPerSecond);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFramesPerSecond_FunctionAddress, intPtr, SetFramesPerSecond_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptScrubControlPanel:IsLooping")]
	public unsafe bool IsLooping()
	{
		CheckDestroyed();
		if (!IsLooping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptScrubControlPanel:IsLooping");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLooping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLooping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLooping_FunctionAddress, intPtr, IsLooping_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLooping_ReturnValue_Offset), 0, IsLooping_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptScrubControlPanel:GetViewRangeMin")]
	public unsafe float GetViewRangeMin()
	{
		CheckDestroyed();
		if (!GetViewRangeMin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptScrubControlPanel:GetViewRangeMin");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewRangeMin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewRangeMin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewRangeMin_FunctionAddress, intPtr, GetViewRangeMin_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetViewRangeMin_ReturnValue_Offset), 0, GetViewRangeMin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptScrubControlPanel:GetViewRangeMax")]
	public unsafe float GetViewRangeMax()
	{
		CheckDestroyed();
		if (!GetViewRangeMax_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptScrubControlPanel:GetViewRangeMax");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewRangeMax_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewRangeMax_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewRangeMax_FunctionAddress, intPtr, GetViewRangeMax_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetViewRangeMax_ReturnValue_Offset), 0, GetViewRangeMax_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptScrubControlPanel:GetTotalSequenceLength")]
	public unsafe float GetTotalSequenceLength()
	{
		CheckDestroyed();
		if (!GetTotalSequenceLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptScrubControlPanel:GetTotalSequenceLength");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTotalSequenceLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTotalSequenceLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTotalSequenceLength_FunctionAddress, intPtr, GetTotalSequenceLength_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTotalSequenceLength_ReturnValue_Offset), 0, GetTotalSequenceLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptScrubControlPanel:GetPlaybackPosition")]
	public unsafe float GetPlaybackPosition()
	{
		CheckDestroyed();
		if (!GetPlaybackPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptScrubControlPanel:GetPlaybackPosition");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlaybackPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlaybackPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlaybackPosition_FunctionAddress, intPtr, GetPlaybackPosition_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPlaybackPosition_ReturnValue_Offset), 0, GetPlaybackPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptScrubControlPanel:GetFramesPerSecond")]
	public unsafe float GetFramesPerSecond()
	{
		CheckDestroyed();
		if (!GetFramesPerSecond_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptScrubControlPanel:GetFramesPerSecond");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFramesPerSecond_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFramesPerSecond_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFramesPerSecond_FunctionAddress, intPtr, GetFramesPerSecond_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFramesPerSecond_ReturnValue_Offset), 0, GetFramesPerSecond_ReturnValue_PropertyAddress.Address);
	}

	static UJavascriptScrubControlPanel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptScrubControlPanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptScrubControlPanel));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/JavascriptEditor.JavascriptScrubControlPanel");
		SetSumFrames_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSumFrames");
		SetSumFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSumFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSumFrames_NewSumFrames_PropertyAddress, SetSumFrames_FunctionAddress, "NewSumFrames");
		SetSumFrames_NewSumFrames_Offset = NativeReflectionCached.GetPropertyOffset(SetSumFrames_FunctionAddress, "NewSumFrames");
		SetSumFrames_NewSumFrames_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSumFrames_FunctionAddress, "NewSumFrames", Classes.FFloatProperty);
		SetSumFrames_IsValid = SetSumFrames_FunctionAddress != IntPtr.Zero && SetSumFrames_NewSumFrames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptScrubControlPanel:SetSumFrames", SetSumFrames_IsValid);
		SetPlaybackPosition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPlaybackPosition");
		SetPlaybackPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaybackPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackPosition_NewTime_PropertyAddress, SetPlaybackPosition_FunctionAddress, "NewTime");
		SetPlaybackPosition_NewTime_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackPosition_FunctionAddress, "NewTime");
		SetPlaybackPosition_NewTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackPosition_FunctionAddress, "NewTime", Classes.FFloatProperty);
		SetPlaybackPosition_IsValid = SetPlaybackPosition_FunctionAddress != IntPtr.Zero && SetPlaybackPosition_NewTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptScrubControlPanel:SetPlaybackPosition", SetPlaybackPosition_IsValid);
		SetLooping_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLooping");
		SetLooping_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLooping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLooping_NewbLooping_PropertyAddress, SetLooping_FunctionAddress, "NewbLooping");
		SetLooping_NewbLooping_Offset = NativeReflectionCached.GetPropertyOffset(SetLooping_FunctionAddress, "NewbLooping");
		SetLooping_NewbLooping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLooping_FunctionAddress, "NewbLooping", Classes.FBoolProperty);
		SetLooping_IsValid = SetLooping_FunctionAddress != IntPtr.Zero && SetLooping_NewbLooping_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptScrubControlPanel:SetLooping", SetLooping_IsValid);
		SetFramesPerSecond_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetFramesPerSecond");
		SetFramesPerSecond_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFramesPerSecond_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFramesPerSecond_NewFramesPerSecond_PropertyAddress, SetFramesPerSecond_FunctionAddress, "NewFramesPerSecond");
		SetFramesPerSecond_NewFramesPerSecond_Offset = NativeReflectionCached.GetPropertyOffset(SetFramesPerSecond_FunctionAddress, "NewFramesPerSecond");
		SetFramesPerSecond_NewFramesPerSecond_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFramesPerSecond_FunctionAddress, "NewFramesPerSecond", Classes.FFloatProperty);
		SetFramesPerSecond_IsValid = SetFramesPerSecond_FunctionAddress != IntPtr.Zero && SetFramesPerSecond_NewFramesPerSecond_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptScrubControlPanel:SetFramesPerSecond", SetFramesPerSecond_IsValid);
		IsLooping_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsLooping");
		IsLooping_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLooping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLooping_ReturnValue_PropertyAddress, IsLooping_FunctionAddress, "ReturnValue");
		IsLooping_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLooping_FunctionAddress, "ReturnValue");
		IsLooping_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLooping_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLooping_IsValid = IsLooping_FunctionAddress != IntPtr.Zero && IsLooping_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptScrubControlPanel:IsLooping", IsLooping_IsValid);
		GetViewRangeMin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetViewRangeMin");
		GetViewRangeMin_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewRangeMin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewRangeMin_ReturnValue_PropertyAddress, GetViewRangeMin_FunctionAddress, "ReturnValue");
		GetViewRangeMin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewRangeMin_FunctionAddress, "ReturnValue");
		GetViewRangeMin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewRangeMin_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetViewRangeMin_IsValid = GetViewRangeMin_FunctionAddress != IntPtr.Zero && GetViewRangeMin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptScrubControlPanel:GetViewRangeMin", GetViewRangeMin_IsValid);
		GetViewRangeMax_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetViewRangeMax");
		GetViewRangeMax_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewRangeMax_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewRangeMax_ReturnValue_PropertyAddress, GetViewRangeMax_FunctionAddress, "ReturnValue");
		GetViewRangeMax_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewRangeMax_FunctionAddress, "ReturnValue");
		GetViewRangeMax_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewRangeMax_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetViewRangeMax_IsValid = GetViewRangeMax_FunctionAddress != IntPtr.Zero && GetViewRangeMax_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptScrubControlPanel:GetViewRangeMax", GetViewRangeMax_IsValid);
		GetTotalSequenceLength_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTotalSequenceLength");
		GetTotalSequenceLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTotalSequenceLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTotalSequenceLength_ReturnValue_PropertyAddress, GetTotalSequenceLength_FunctionAddress, "ReturnValue");
		GetTotalSequenceLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTotalSequenceLength_FunctionAddress, "ReturnValue");
		GetTotalSequenceLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTotalSequenceLength_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetTotalSequenceLength_IsValid = GetTotalSequenceLength_FunctionAddress != IntPtr.Zero && GetTotalSequenceLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptScrubControlPanel:GetTotalSequenceLength", GetTotalSequenceLength_IsValid);
		GetPlaybackPosition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPlaybackPosition");
		GetPlaybackPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlaybackPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlaybackPosition_ReturnValue_PropertyAddress, GetPlaybackPosition_FunctionAddress, "ReturnValue");
		GetPlaybackPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaybackPosition_FunctionAddress, "ReturnValue");
		GetPlaybackPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaybackPosition_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPlaybackPosition_IsValid = GetPlaybackPosition_FunctionAddress != IntPtr.Zero && GetPlaybackPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptScrubControlPanel:GetPlaybackPosition", GetPlaybackPosition_IsValid);
		GetFramesPerSecond_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFramesPerSecond");
		GetFramesPerSecond_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFramesPerSecond_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFramesPerSecond_ReturnValue_PropertyAddress, GetFramesPerSecond_FunctionAddress, "ReturnValue");
		GetFramesPerSecond_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFramesPerSecond_FunctionAddress, "ReturnValue");
		GetFramesPerSecond_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFramesPerSecond_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFramesPerSecond_IsValid = GetFramesPerSecond_FunctionAddress != IntPtr.Zero && GetFramesPerSecond_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptScrubControlPanel:GetFramesPerSecond", GetFramesPerSecond_IsValid);
	}
}
