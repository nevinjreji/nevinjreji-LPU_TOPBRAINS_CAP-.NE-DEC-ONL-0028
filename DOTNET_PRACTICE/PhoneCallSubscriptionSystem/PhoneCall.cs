using System;
namespace PhoneCallSubscriptionSystem
{
    public delegate void Notify();

    class PhoneCall
    {
        public event Notify PhoneCallEvent;
        public string Message { get; private set; }  

        private void OnSubscribe()
        {
            Message = "Subscribed to Call";
        }  
        private void OnUnSubscribe()
        {
            Message = "Unscubscribed to Call";
        }
        public void MakeAPhoneCall(bool notify)
        {
            PhoneCallEvent = null;

            if (notify)
            {
                PhoneCallEvent += OnSubscribe;
            }
            else
            {
                PhoneCallEvent += OnUnSubscribe;
            }
            PhoneCallEvent?.Invoke();
        }
    }
}