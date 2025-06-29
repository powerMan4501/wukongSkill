using System;
using b1.Plugins.AsyncLoadingScreen;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace b1;

public class Adapt_TravelLevelTemplateBase : CrossBindingAdaptor
{
	public class Adaptor : TravelLevelTemplateBase, CrossBindingAdaptorType
	{
		private readonly ILRuntime.Runtime.Enviorment.AppDomain _appdomain;

		private readonly ILTypeInstance _instance;

		private readonly CrossBindingFunctionInfo<string> _getLevelNameMethod = new CrossBindingFunctionInfo<string>("GetLevelName");

		private readonly CrossBindingFunctionInfo<EGSLoadingScreenType> _getLoadingScreenTypeMethod = new CrossBindingFunctionInfo<EGSLoadingScreenType>("GetLoadingScreenType");

		private readonly CrossBindingFunctionInfo<string> _getLevelOptionsMethod = new CrossBindingFunctionInfo<string>("GetLevelOptions");

		private readonly CrossBindingFunctionInfo<bool> _isNeedOpenLoadingScreenMethod = new CrossBindingFunctionInfo<bool>("IsNeedOpenLoadingScreen");

		private readonly CrossBindingFunctionInfo<bool> _isNeedCloseLoadingScreenMethod = new CrossBindingFunctionInfo<bool>("IsNeedCloseLoadingScreen");

		private readonly CrossBindingFunctionInfo<bool> _isNeedPostLeaveLevelMethod = new CrossBindingFunctionInfo<bool>("IsNeedPostLeaveLevel");

		private readonly CrossBindingFunctionInfo<bool> _isNeedPreEnterLevelMethod = new CrossBindingFunctionInfo<bool>("IsNeedPreEnterLevel");

		private readonly CrossBindingFunctionInfo<bool> _isNeedResetGameInstanceDataMethod = new CrossBindingFunctionInfo<bool>("IsNeedResetGameInstanceData");

		private readonly CrossBindingFunctionInfo<FChoosePlayerStartInfo> _choosePlayerStartMethod = new CrossBindingFunctionInfo<FChoosePlayerStartInfo>("OnChoosePlayerStart");

		private readonly CrossBindingMethodInfo<Action> _preLeaveLevelMethod = new CrossBindingMethodInfo<Action>("OnPreLeaveLevel");

		private readonly CrossBindingMethodInfo<Action> _postEnterLevelFinishMethod = new CrossBindingMethodInfo<Action>("OnPostEnterLevelFinish");

		private readonly CrossBindingMethodInfo<Action> _postGsLoginFinishMethod = new CrossBindingMethodInfo<Action>("OnPostGSLoginFinish");

		private readonly CrossBindingMethodInfo<Action> _travelLevelBeginMethod = new CrossBindingMethodInfo<Action>("OnTravelLevelBegin");

		private readonly CrossBindingMethodInfo<Action> _travelLevelEndMethod = new CrossBindingMethodInfo<Action>("OnTravelLevelEnd");

		public ILTypeInstance ILInstance => _instance;

		public Adaptor()
		{
		}

		public Adaptor(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
		{
			_appdomain = appdomain;
			_instance = instance;
		}

		protected override string GetLevelName()
		{
			if (_getLevelNameMethod.CheckShouldInvokeBase(_instance))
			{
				return base.GetLevelName();
			}
			return _getLevelNameMethod.Invoke(_instance);
		}

		public override EGSLoadingScreenType GetLoadingScreenType()
		{
			if (_getLoadingScreenTypeMethod.CheckShouldInvokeBase(_instance))
			{
				return base.GetLoadingScreenType();
			}
			return _getLoadingScreenTypeMethod.Invoke(_instance);
		}

		protected override string GetLevelOptions()
		{
			if (_getLevelOptionsMethod.CheckShouldInvokeBase(_instance))
			{
				return base.GetLevelOptions();
			}
			return _getLevelOptionsMethod.Invoke(_instance);
		}

		public override bool IsNeedOpenLoadingScreen()
		{
			if (_isNeedOpenLoadingScreenMethod.CheckShouldInvokeBase(_instance))
			{
				return base.IsNeedOpenLoadingScreen();
			}
			return _isNeedOpenLoadingScreenMethod.Invoke(_instance);
		}

		public override bool IsNeedCloseLoadingScreen()
		{
			if (_isNeedCloseLoadingScreenMethod.CheckShouldInvokeBase(_instance))
			{
				return base.IsNeedCloseLoadingScreen();
			}
			return _isNeedCloseLoadingScreenMethod.Invoke(_instance);
		}

		public override bool IsNeedPostLeaveLevel()
		{
			if (_isNeedPostLeaveLevelMethod.CheckShouldInvokeBase(_instance))
			{
				return base.IsNeedPostLeaveLevel();
			}
			return _isNeedPostLeaveLevelMethod.Invoke(_instance);
		}

		public override bool IsNeedPreEnterLevel()
		{
			if (_isNeedPreEnterLevelMethod.CheckShouldInvokeBase(_instance))
			{
				return base.IsNeedPreEnterLevel();
			}
			return _isNeedPreEnterLevelMethod.Invoke(_instance);
		}

		public override bool IsNeedResetGameInstanceData()
		{
			if (_isNeedResetGameInstanceDataMethod.CheckShouldInvokeBase(_instance))
			{
				return base.IsNeedResetGameInstanceData();
			}
			return _isNeedResetGameInstanceDataMethod.Invoke(_instance);
		}

		public override FChoosePlayerStartInfo OnChoosePlayerStart()
		{
			if (_choosePlayerStartMethod.CheckShouldInvokeBase(_instance))
			{
				return base.OnChoosePlayerStart();
			}
			return _choosePlayerStartMethod.Invoke(_instance);
		}

		public override void OnPostEnterLevelFinish(Action FinishEvent)
		{
			if (_postEnterLevelFinishMethod.CheckShouldInvokeBase(_instance))
			{
				base.OnPostEnterLevelFinish(FinishEvent);
			}
			else
			{
				_postEnterLevelFinishMethod.Invoke(_instance, FinishEvent);
			}
		}

		public override void OnPreLeaveLevel(Action FinishEvent)
		{
			if (_preLeaveLevelMethod.CheckShouldInvokeBase(_instance))
			{
				base.OnPreLeaveLevel(FinishEvent);
			}
			else
			{
				_preLeaveLevelMethod.Invoke(_instance, FinishEvent);
			}
		}

		public override void OnPostGSLoginFinish(Action FinishEvent)
		{
			if (_postGsLoginFinishMethod.CheckShouldInvokeBase(_instance))
			{
				base.OnPostGSLoginFinish(FinishEvent);
			}
			else
			{
				_postGsLoginFinishMethod.Invoke(_instance, FinishEvent);
			}
		}

		public override void OnTravelLevelBegin(Action FinishEvent)
		{
			if (_travelLevelBeginMethod.CheckShouldInvokeBase(_instance))
			{
				base.OnTravelLevelBegin(FinishEvent);
			}
			else
			{
				_travelLevelBeginMethod.Invoke(_instance, FinishEvent);
			}
		}

		public override void OnTravelLevelEnd(Action FinishEvent)
		{
			if (_travelLevelEndMethod.CheckShouldInvokeBase(_instance))
			{
				base.OnTravelLevelEnd(FinishEvent);
			}
			else
			{
				_travelLevelEndMethod.Invoke(_instance, FinishEvent);
			}
		}
	}

	public override Type BaseCLRType => typeof(TravelLevelTemplateBase);

	public override Type AdaptorType => typeof(Adaptor);

	public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
	{
		return new Adaptor(appdomain, instance);
	}
}
