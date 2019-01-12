/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

namespace extOSC.PlayMaker.Events
{
	public class OSCTransmitterSendImpulse : OSCTransmitterSend
	{
		#region Protected Methods

		protected override bool FillMessage(OSCMessage message)
		{
			message.AddValue(OSCValue.Impulse());

			return true;
		}

		#endregion
	}
}

#endif