/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using System.Collections;

using HutongGames.PlayMaker;

using extOSC.Core;
using extOSC.Core.Events;
using extOSC.Mapping;

namespace extOSC.PlayMaker
{
	[ActionCategory("extOSC")]
	public abstract class OSCReceiverAction : FsmStateAction, IOSCBind
	{
		#region Public Vars

		[RequiredField]
		[DisplayOrder(0)]
		[CheckForComponent(typeof(OSCReceiver))]
		[Tooltip("GameObject with OSCReceiver.")]
		public FsmOwnerDefault ReceiverObject;

		[RequiredField]
		[DisplayOrder(1)]
		[Tooltip("OSCReceiver binding address.")]
		public FsmString ReceiverAddress;

		[DisplayOrder(2)]
		[ObjectType(typeof(OSCMapBundle))]
		public FsmObject MapBundle;

		// Hidden by Interface.
		string IOSCBind.ReceiverAddress
		{
			get { return ReceiverAddress.Value; }
		}

		OSCEventMessage IOSCBind.Callback
		{
			get
			{
				if (callback == null)
				{
					callback = new OSCEventMessage();
					callback.AddListener(InvokeMessage);
				}

				return callback;
			}
		}

		#endregion

		#region Protected Vars

		protected OSCEventMessage callback;

		protected OSCReceiver receiver;

		#endregion

		#region Public Methods

		public override void Reset()
		{
			ReceiverObject = null;
			ReceiverAddress = null;
			MapBundle = null;
		}

		public override void OnEnter()
		{
			var go = Fsm.GetOwnerDefaultTarget(ReceiverObject);
			if (go == null)
			{
				LogError("Missing ReceiverObject.");
				return;
			}

			receiver = go.GetComponent<OSCReceiver>();

			StartCoroutine(BindCoroutine());
		}

		public override void OnExit()
		{
			var gameObject = Fsm.FsmComponent.gameObject;

			if (gameObject.activeInHierarchy)
				StartCoroutine(UnbindCoroutine());
		}

		#endregion

		#region Protected Methods

		protected abstract void Invoke(OSCMessage message);

		#endregion

		#region Private Methods

		private void InvokeMessage(OSCMessage message)
		{
			if (MapBundle != null && MapBundle.Value != null)
			{
				var mapBundle = (OSCMapBundle) MapBundle.Value;
				mapBundle.Map(message);
			}

			Invoke(message);
		}

		private IEnumerator BindCoroutine()
		{
			yield return null;

			if (receiver != null)
				receiver.Bind(this);
		}

		private IEnumerator UnbindCoroutine()
		{
			yield return null;

			if (receiver != null)
				receiver.Unbind(this);
		}

		#endregion
	}
}

#endif