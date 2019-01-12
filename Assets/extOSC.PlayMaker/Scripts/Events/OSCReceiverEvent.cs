/* Copyright (c) 2019 ExT (V.Sigalkin) */

#if EXTOSC && PLAYMAKER

using HutongGames.PlayMaker;

namespace extOSC.PlayMaker.Events
{
    public abstract class OSCReceiverEvent : OSCReceiverAction
    {
        #region Public Vars

        [Tooltip("Invoked when a message is received.")]
        public FsmEvent MessageSendEvent;

        #endregion

        #region Public Methods

        public override void Reset()
        {
            base.Reset();

            MessageSendEvent = null;
        }

        #endregion

        #region Protected Methods

        protected override void Invoke(OSCMessage message)
        {
            if (ProcessMessage(message))
            {
                Fsm.Event(MessageSendEvent);
            }
        }

        protected abstract bool ProcessMessage(OSCMessage message);

        #endregion
    }

    public abstract class OSCReceiverEvent<TFsmValue, TValue> : OSCReceiverAction where TFsmValue : NamedVariable
    {
        #region Public Vars

        [Tooltip("Invoked when a message is received.")]
        public FsmEvent MessageSendEvent;

        [UIHint(UIHint.Variable)]
        [Tooltip("Store the message value in a variable.")]
        public TFsmValue MessageStoreValue;

        #endregion

        #region Public Methods

        public override void Reset()
        {
            base.Reset();

            MessageSendEvent = null;
            MessageStoreValue = null;
        }

        #endregion

        #region Protected Methods

        protected override void Invoke(OSCMessage message)
        {
            TValue value;

            if (ProcessMessage(message, out value))
            {
                Fsm.Event(MessageSendEvent);

                if (MessageStoreValue != null)
                    MessageStoreValue.RawValue = value;
            }
        }

        protected abstract bool ProcessMessage(OSCMessage message, out TValue value);

        #endregion
    }
}

#endif