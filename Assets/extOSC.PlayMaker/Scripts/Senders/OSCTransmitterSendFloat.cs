/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker.Events
{
	public class OSCTransmitterSendFloat : OSCTransmitterSend<FsmFloat, float>
	{
		#region Protected Methods

		protected override void FillMessage(OSCMessage message, float value)
		{
			message.AddValue(OSCValue.Float(value));
		}

		#endregion
	}
}

#endif