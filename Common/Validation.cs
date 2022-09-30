namespace Common
{
    public class Validation
    {
        public string customValidation()
        {
			try
			{
				return "true";
			}
			catch (Exception exp)
			{
				return "false";
			}
        }
    }
}