using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SweetDAL;
using SweetModel;

namespace SweetWEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SweetRetailController : ControllerBase
    {

        public List<RetailModel> DisplayAllIteams()
        {
            try
            {
                Read read = new Read();
                return read.GetSweetData();
                
            }
            catch (Exception expMsg)
            {
                return null; ;
            }
        }
        [HttpPost]
        [Route("InsertData")]
        public string InsertSweetData(RetailModel retailModel)
        {
            try
            {
                ADD add = new ADD();
                string ADDMessage = add.AddSweetRecord(retailModel);
                return ADDMessage;
            }
            catch
            {
                return null;
            }
        }
        [HttpPost]
        [Route("UpdateData")]
        public string UpdateSweetData(RetailModel retailModel)
        {
            try
            {
                Update update = new Update();
                string UpdateMessage = update.UpdateSweetRecord(retailModel);
                return UpdateMessage;
            }
            catch
            {
                return null;
            }
        }
        [HttpDelete]
        [Route("DeletetData")]
        public string DeleteSweetData(RetailModel retailModel)
        {
            try
            {
                Delete delete = new Delete();
                string DeleteMessage = delete.DeleteSweetRecord(retailModel);
                return DeleteMessage;
            }
            catch
            {
                return null;
            }
        }

    }
}
