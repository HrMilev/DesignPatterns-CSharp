namespace ChainOfResposibility
{
    public abstract class Pipeline
    {
        private Pipeline _next;
        protected abstract void DoYourMagic(Request request);
        public void ProcessRequest(Request request)
        {
            DoYourMagic(request);
            if (_next != null)
            {
                _next.ProcessRequest(request);
            }
        }

        public void SetNext(Pipeline next)
        {
            _next = next;
        }
    }
}
