/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using UnityEngine;

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker.Events
{
	public class OSCTransmitterSendVector3 : OSCTransmitterSend<FsmVector3, Vector3>
	{
		#region Protected Methods

		protected override void FillMessage(OSCMessage message, Vector3 value)
		{
			message.AddValue(OSCValue.Float(value.x));
			message.AddValue(OSCValue.Float(value.y));
			message.AddValue(OSCValue.Float(value.z));
		}

		#endregion
	}
}

#endif