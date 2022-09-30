namespace Common
{
    public class Validation
    {
        public int customValidation()
        {
			try
			{
				return 1;
			}
			catch (Exception exp)
			{
				return 0;
			}
        }
    }
}