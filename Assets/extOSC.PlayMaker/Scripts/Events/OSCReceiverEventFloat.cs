/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker.Events
{
    public class OSCReceiverEventFloat : OSCReceiverEvent<FsmFloat, float>
    {
        #region Protected Methods

        protected override bool ProcessMessage(OSCMessage message, out float value)
        {
            value = 0f;

            if (message.ToFloat(out value))
                return true;

            return false;
        }

        #endregion
    }
}

#endif