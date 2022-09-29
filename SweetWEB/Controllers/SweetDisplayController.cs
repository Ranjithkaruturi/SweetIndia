﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SweetDAL;
using SweetModel;

namespace SweetWEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SweetDisplayController : ControllerBase
    {

        [HttpGet]
        [Route("DisplayAllIteams")]
            public List<DisplayModel> DisplayAllIteams()
            {
                try
                {
                    Read read = new Read();
                    return read.GetSweetData1();
            
                }
                catch (Exception expMsg)
                {
                    return null; ;
                }
            }
            [HttpPost]
            [Route("InsertData")]
            public string InsertSweetData(MainModel mainModel)
            {
                try
                {
                    ADD add = new ADD();
                    string ADDMessage = add.AddSweetRecord(mainModel);
                    return ADDMessage;
                }
                catch
                {
                    return null;
                }
            }
            [HttpPost]
            [Route("UpdateData")]
            public string UpdateSweetData(MainModel mainModel)
            {
                try
                {
                    Update update = new Update();
                    string UpdateMessage = update.UpdateSweetRecord(mainModel);
                    return UpdateMessage;
                }
                catch
                {
                    return null;
                }
            }
            [HttpDelete]
            [Route("DeletetData")]
            public string DeleteSweetData(MainModel mainModel)
            {
                try
                {
                    Delete delete = new Delete();
                    string DeleteMessage = delete.DeleteSweetRecord(mainModel);
                    return DeleteMessage;
                }
                catch
                {
                    return null;
                }
            }

        }
    }

