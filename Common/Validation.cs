namespace Common
{
    public class Validation
    {
        public string customValidation()
        {
			try
			{
				return "Data inserted succesfully";
			}
			catch (Exception exp)
			{
				return "Data insert failed";
			}
        }
    }
}