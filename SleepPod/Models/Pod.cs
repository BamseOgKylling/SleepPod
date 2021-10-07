namespace SleepPod
{
    class Pod // internal är standard om man inte skriver något framför class.
    {
        // private är standard om du inte skriver något framför t.ex string.

        private string podId;
        private bool hasTV;
        private bool occupied;


        public Pod(string podId, bool hasTV)
        {
            this.podId = podId;
            this.hasTV = hasTV;
        }
    }
}