namespace LoansBackend.Utils
{
    public class SequenceGenerator
    {
        private static int currentSeq;

        public int GenerateId()
        {
            return Interlocked.Increment(ref currentSeq);
        }
    }
}
