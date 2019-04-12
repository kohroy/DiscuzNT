namespace Discuz.Data
{
    public class DbException : Discuz.Common.DNTException
    {
        public DbException(string message)
            : base(message)
        {
        }

        public int Number
        {
            get { return 0 ; }
        }

       
    }
}
