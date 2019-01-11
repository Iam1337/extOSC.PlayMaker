/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

namespace extOSC.PlayMaker.Events
{
    public class OSCReceiverEventImpulse : OSCReceiverEvent
    {
        #region Protected Methods

        protected override bool ProcessMessage(OSCMessage message)
        {
            return message.HasImpulse();
        }

        #endregion
    }
}

#endif