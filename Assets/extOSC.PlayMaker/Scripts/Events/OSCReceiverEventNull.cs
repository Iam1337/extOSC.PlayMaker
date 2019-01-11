/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

namespace extOSC.PlayMaker.Events
{
    public class OSCReceiverEventNull : OSCReceiverEvent
    {
        #region Protected Methods

        protected override bool ProcessMessage(OSCMessage message)
        {
            return message.HasNull();
        }

        #endregion
    }
}

#endif