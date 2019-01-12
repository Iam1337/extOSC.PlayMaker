/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker.Events
{
	public abstract class OSCTransmitterSend : OSCTransmitterAction
	{
        #region Public Vars

		[Tooltip("Repeat every frame")]
		public bool EveryFrame;

        #endregion

		#region Public Methods

		public override void Reset()
		{
			base.Reset();

			EveryFrame = false;
		}

		public override void OnEnter()
		{
			Send();

			if (!EveryFrame)
				Finish();
		}

		public override void OnUpdate()
		{
			Send();
		}

        #endregion
    }

	public abstract class OSCTransmitterSend<TFsmValue, TValue> : OSCTransmitterSend where TFsmValue : NamedVariable
	{

		#region Public Vars

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Message value.")]
		public TFsmValue MessageValue;

        #endregion

		#region Public Methods

		public override void Reset()
		{
			base.Reset();

			MessageValue = null;
		}

        #endregion

        #region Protected Methods

        protected override bool FillMessage(OSCMessage message)
		{
			if (MessageValue != null && MessageValue.RawValue != null)
			{
				FillMessage(message, (TValue) MessageValue.RawValue);

				return true;
			}

			return false;
		}

		protected abstract void FillMessage(OSCMessage message, TValue value);

		#endregion
	}
}

#endif