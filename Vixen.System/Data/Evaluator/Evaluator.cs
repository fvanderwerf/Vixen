﻿using Vixen.Commands;
using Vixen.Data.Value;
using Vixen.Sys;
using Vixen.Sys.Dispatch;

namespace Vixen.Data.Evaluator
{
	public abstract class Evaluator : Dispatchable<Evaluator>, IEvaluator, IAnyIntentStateHandler
	{
		public ICommand Evaluate(IIntentState intentState)
		{
			intentState.Dispatch(this);
			return EvaluatorValue;
		}

		// Opt-in, not opt-out.  Default handlers will not be called
		// from the base class.

		public virtual void Handle(IIntentState<ColorValue> obj)
		{
		}

		public virtual void Handle(IIntentState<LightingValue> obj)
		{
		}

		public virtual void Handle(IIntentState<PositionValue> obj)
		{
		}

		public virtual void Handle(IIntentState<CommandValue> obj)
		{
		}

		public virtual void Handle(IIntentState<CustomValue> obj)
		{
		}

		protected ICommand EvaluatorValue { get; set; }

		
	}
}