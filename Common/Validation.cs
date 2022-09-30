namespace Common
{
    public class Validation
    {
        public bool customValidation()
        {
			try
			{
				return true;
			}
			catch (Exception exp)
			{
				return false;
			}
        }
    }
}