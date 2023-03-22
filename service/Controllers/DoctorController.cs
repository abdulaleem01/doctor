﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business_Logic;
using Model;
using Doctor;

namespace service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly ILogic _logic;
        public DoctorController(ILogic logic)
        {
            _logic = logic;
        }
        [HttpGet("/getAll")]
        public ActionResult Get()
        {
            var Doct = _logic.GetAllDocts();
            return Ok(Doct);
        }
        [HttpGet("particular")]
        public ActionResult Getp(string email)
        {
            var users = _logic.GetDoct(email);
            return Ok(users);
        }
        [HttpPost("Add")]
        public ActionResult Post([FromBody] doctorr user)
        {
            var users = _logic.ADD(user);
            return Ok(users);
        }

        [HttpGet("test")]
        public ActionResult TestRun(){
            return Ok("Done");
        }


    }
}
