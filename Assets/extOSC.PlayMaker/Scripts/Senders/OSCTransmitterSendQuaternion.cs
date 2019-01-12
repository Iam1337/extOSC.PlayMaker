/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using UnityEngine;

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker.Events
{
	public class OSCTransmitterSendQuaternion : OSCTransmitterSend<FsmQuaternion, Quaternion>
	{
		#region Protected Methods

		protected override void FillMessage(OSCMessage message, Quaternion value)
		{
			message.AddValue(OSCValue.Float(value.x));
			message.AddValue(OSCValue.Float(value.y));
			message.AddValue(OSCValue.Float(value.z));
			message.AddValue(OSCValue.Float(value.w));
		}

		#endregion
	}
}

#endif