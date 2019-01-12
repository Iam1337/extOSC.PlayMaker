/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using extOSC.Mapping;

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker
{
	[ActionCategory("extOSC")]
	public abstract class OSCTransmitterAction : FsmStateAction
	{
		#region Public Vars

		[RequiredField]
		[DisplayOrder(0)]
		[CheckForComponent(typeof(OSCTransmitter))]
		[Tooltip("GameObject with OSCTransmitter.")]
		public FsmOwnerDefault TransmitterObject;

		[RequiredField]
		[DisplayOrder(1)]
		[Tooltip("OSCTransmitter messages address.")]
		public FsmString TransmitterAddress;

		[DisplayOrder(2)]
		[ObjectType(typeof(OSCMapBundle))]
		public FsmObject MapBundle;

        #endregion

        #region Protected Vars

        protected OSCTransmitter transmitter;

		#endregion

        #region Public Methods

        public override void Reset()
		{
			TransmitterObject = null;
			TransmitterAddress = null;
			MapBundle = null;
        }

		public override void Awake()
		{
			var go = Fsm.GetOwnerDefaultTarget(TransmitterObject);
			if (go == null)
			{
				LogError("Missing ReceiverObject.");
				return;
			}

			transmitter = go.GetComponent<OSCTransmitter>();
		}

        public void Send()
		{
			var message = new OSCMessage(TransmitterAddress.Value);

			if (FillMessage(message))
			{
				if (MapBundle != null && MapBundle.Value != null)
				{
					var mapBundle = (OSCMapBundle)MapBundle.Value;
					mapBundle.Map(message);
				}

                if (transmitter != null)
					transmitter.Send(message);
			}
		}

		#endregion

		#region Protected Methods

		protected abstract bool FillMessage(OSCMessage message);

		#endregion
	}
}

#endif